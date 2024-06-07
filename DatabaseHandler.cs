/******************************************************************* 
 * Name: Joseph Oregero  JOSORE9146
 * Date: 06-02-2024
 * Assignment: SDC320 CIS317 Project
 *  
 * This class handles SQLite database operations for the Sneaker Management System.
 */ 
using System;
using System.Data.SQLite;

public class DatabaseHandler
{
private SQLiteConnection connection;
public DatabaseHandler(string databasePath)
{
connection = new SQLiteConnection($"Data Source={databasePath};Version=3;");
connection.Open();
CreateSneakerTable();
}
private void CreateSneakerTable()
{
string createTableQuery = @"CREATE TABLE IF NOT EXISTS Sneakers (
                                    SneakerID INTEGER PRIMARY KEY,
                                    Model TEXT NOT NULL,
                                    Color TEXT NOT NULL,
                                    Size INTEGER NOT NULL,
                                    ReleaseDate TEXT NOT NULL);";
using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
{
command.ExecuteNonQuery();
}
}
public void AddSneaker(Sneaker sneaker)
{
string insertQuery = @"INSERT INTO Sneakers (Model, Color, Size, ReleaseDate)
                               VALUES (@Model, @Color, @Size, @ReleaseDate);";
using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
{
command.Parameters.AddWithValue("@Model", sneaker.Model);
command.Parameters.AddWithValue("@Color", sneaker.Color);
command.Parameters.AddWithValue("@Size", sneaker.Size);
command.Parameters.AddWithValue("@ReleaseDate", sneaker.ReleaseDate.ToString("yyyy-MM-dd"));
command.ExecuteNonQuery();
}
}
public void UpdateSneaker(Sneaker sneaker)
{
string updateQuery = @"UPDATE Sneakers SET Model = @Model, Color = @Color, Size = @Size, ReleaseDate = @ReleaseDate
                               WHERE SneakerID = @SneakerID;";
using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
{
command.Parameters.AddWithValue("@Model", sneaker.Model);
command.Parameters.AddWithValue("@Color", sneaker.Color);
command.Parameters.AddWithValue("@Size", sneaker.Size);
command.Parameters.AddWithValue("@ReleaseDate", sneaker.ReleaseDate.ToString("yyyy-MM-dd"));
command.Parameters.AddWithValue("@SneakerID", sneaker.SneakerID);
command.ExecuteNonQuery();
}
}
public void DeleteSneaker(int sneakerID)
{
string deleteQuery = @"DELETE FROM Sneakers WHERE SneakerID = @SneakerID;";
using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
{
command.Parameters.AddWithValue("@SneakerID", sneakerID);
command.ExecuteNonQuery();
}
}
public Sneaker GetSneaker(int sneakerID)
{
string selectQuery = @"SELECT * FROM Sneakers WHERE SneakerID = @SneakerID;";
using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
{
command.Parameters.AddWithValue("@SneakerID", sneakerID);
using (SQLiteDataReader reader = command.ExecuteReader())
{
if (reader.Read())
{
return new Sneaker(
reader.GetInt32(0),
reader.GetString(1),
reader.GetString(2),
reader.GetInt32(3),
DateTime.Parse(reader.GetString(4))
);
}
}
}
return null;
}
public List<Sneaker> GetAllSneakers()
{
List<Sneaker> sneakers = new List<Sneaker>();
string selectAllQuery = "SELECT * FROM Sneakers;";
using (SQLiteCommand command = new SQLiteCommand(selectAllQuery, connection))
{
using (SQLiteDataReader reader = command.ExecuteReader())
{
while (reader.Read())
{
sneakers.Add(new Sneaker(
reader.GetInt32(0),
reader.GetString(1),
reader.GetString(2),
reader.GetInt32(3),
DateTime.Parse(reader.GetString(4))
));
}
}
}
return sneakers;
}
}
