using System.Collections.Generic;

namespace Package.Models
{
  public class Parcel
  {
    public string Description { get; set; }
    private static List<Parcel> _instances = new List<Parcel> { };

    public Parcel(string description)
    {
      Description = description;
      _instances.Add(this);
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}