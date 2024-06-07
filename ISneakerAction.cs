/******************************************************************* 
 * Name: Joseph Oregero  JOSORE9146
 * Date: 06-02-2024
 * Assignment: SDC320 CIS317 Project
 *  
 * This interface defines the basic CRUD operations for managing sneakers.
 */ 
using System.Collections.Generic;
public interface ISneakerActions
{
void AddSneaker(Sneaker sneaker);
void UpdateSneaker(int id, string model, string color, int size, DateTime releaseDate);
void DeleteSneaker(int id);
Sneaker GetSneaker(int id);
List<Sneaker> GetAllSneakers();
}