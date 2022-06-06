using MVCExample.Data;
using MVCExample.Models;

namespace MVCExample
{
  public class SampleData
  {
    public static void Initialize(MobileContext context)
    {
      if (!context.Phones.Any())
      {
        context.Phones.AddRange(
          new Phone
          {
            Name = "Iphone 11",
            Company = "Apple",
            Price = 700
          },
          new Phone
          {
            Name = "S8",
            Company = "Samsung",
            Price = 500
          },
          new Phone
          {
            Name = "Redmi 5",
            Company = "Xiaomi",
            Price = 800
          });
          };
    }
  }
}

