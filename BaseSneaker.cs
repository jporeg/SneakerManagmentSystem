/******************************************************************* 
 * Name: Joseph Oregero  JOSORE9146
 * Date: 06-02-2024
 * Assignment: SDC320 CIS317 Project
 *  
 * This class provides a template for sneaker objects with a unique identifier.
 */ 
public abstract class BaseSneaker
{
public int SneakerID { get; set; }
public BaseSneaker(int id)
{
SneakerID = id;
}
public int GetSneakerID()
{
return SneakerID;
}
}