/******************************************************************* 
 * Name: Joseph Oregero  JOSORE9146
 * Date: 06-02-2024
 * Assignment: SDC320 CIS317 Project
 *  
 * This class manages a collection of Sneaker objects and implements ops defined in the ISneakerActions.
 */ 
using System;
using System.Collections.Generic;

public class SneakerCollection : ISneakerActions
{
private DatabaseHandler dbHandler;
public SneakerCollection(string databasePath)
{
dbHandler = new DatabaseHandler(databasePath);
}
public void AddSneaker(Sneaker sneaker)
{
dbHandler.AddSneaker(sneaker);
Console.WriteLine("Sneaker added successfully.");
}
public void UpdateSneaker(int id, string model, string color, int size, DateTime releaseDate)
{
Sneaker sneaker = new Sneaker(id, model, color, size, releaseDate);
dbHandler.UpdateSneaker(sneaker);
Console.WriteLine("Sneaker updated successfully.");
}
public void DeleteSneaker(int id)
{
dbHandler.DeleteSneaker(id);
Console.WriteLine("Sneaker deleted successfully.");
}
public Sneaker GetSneaker(int id)
{
return dbHandler.GetSneaker(id);
}

public List<Sneaker> GetAllSneakers()
{
return dbHandler.GetAllSneakers();
}
}