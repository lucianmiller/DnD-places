using System.Collections.Generic;

namespace DndPlaces.Models
{
  public class Place
  {
    public string Description { get; set; }
    string Id { get; }
    private static List<Place> _instances = new List<Place>();

    public Place(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}