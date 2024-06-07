/******************************************************************* 
 * Name: Joseph Oregero  JOSORE9146
 * Date: 05-25-2024
 * Assignment: SDC320 CIS317 Project
 *  
 * This class represents a sneaker and includes properties.
 */ 
using System;
public class Sneaker : BaseSneaker, ISneakerActions
{
public string Model { get; set; }
public string Color { get; set; }
public int Size { get; set; }
public DateTime ReleaseDate { get; set; }
public Sneaker(int id, string model, string color, int size, DateTime releaseDate) 
        : base(id)
{
Model = model;
Color = color;
Size = size;
ReleaseDate = releaseDate;
}
public override string ToString()
{
return $"ID: {SneakerID}, Model: {Model}, Color: {Color}, Size: {Size}, Release Date: {ReleaseDate.ToShortDateString()}";
}
public void DisplayDetails()
{
Console.WriteLine(ToString());
}
public void AddSneaker(Sneaker sneaker)
{
throw new NotImplementedException();
}
public void UpdateSneaker(int id, string model, string color, int size, DateTime releaseDate)
{
throw new NotImplementedException();
}
public void DeleteSneaker(int id)
{
throw new NotImplementedException();
}
public Sneaker GetSneaker(int id)
{
throw new NotImplementedException();
}
public List<Sneaker> GetAllSneakers()
{
throw new NotImplementedException();
}
}