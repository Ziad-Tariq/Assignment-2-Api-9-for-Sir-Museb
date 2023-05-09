using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    [Keyless]
    public class User
    {
      public string name { get; set;}
      public string email { get; set;}
      public string address { get; set;}
      public int no { get; set;}
    }
}
