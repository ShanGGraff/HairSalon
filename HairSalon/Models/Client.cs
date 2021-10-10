using System.Collections.Generic;
namespace HairSalon.Models
{
  public class Client
  {

    // public Client()
    // {
    //   this.Stylists = new HashSet<Stylist>();
    // }
    public int ClientId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
    // public virtual ICollection<Stylist> Stylists { get; set; }
  }
}