/******************************************************************* 
 * Name: Joseph Oregero  JOSORE9146
 * Date: 06-02-2024
 * Assignment: SDC320 CIS317 Project
 *  
 * This program tests the SneakerCollection and Sneaker classes.
 */ 
using System;
using System.Collections.Generic;

class Program
{
static void Main()
{
string databasePath = "sneakers.db";
SneakerCollection collection = new SneakerCollection(databasePath);
Sneaker sneaker1 = new Sneaker(1, "Air Max", "Red", 10, new DateTime(2023, 1, 1));
Sneaker sneaker2 = new Sneaker(2, "Air Jordan", "Blue", 9, new DateTime(2023, 2, 15));
collection.AddSneaker(sneaker1);
collection.AddSneaker(sneaker2);
List<Sneaker> sneakers = collection.GetAllSneakers();
foreach (var sneaker in sneakers)
{
sneaker.DisplayDetails();
}
collection.UpdateSneaker(1, "Air Max", "Green", 10, new DateTime(2023, 3, 1));
collection.GetSneaker(1).DisplayDetails();
collection.DeleteSneaker(2);
sneakers = collection.GetAllSneakers();
foreach (var sneaker in sneakers)
{
sneaker.DisplayDetails();
}
}
}
