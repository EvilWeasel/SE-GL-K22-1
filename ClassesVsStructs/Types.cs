using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
namespace ClassesVsStructs
{
  internal class Types
  {
    public Types()
    {

      var OrderStatus = MyNum.Order_Recieved;

      //int x;
      //x = 10;
      //x = 42.91;

      //var x;
      //x = 10;

      dynamic x = "Hello World!";
      x = 10;

      x = 10.97;

      x = new PersonModel("Hans", "Vader");






      if (OrderStatus == MyNum.Order_Recieved)
      {
        Console.WriteLine("Hello World!");
      }


    }
    double Calculate(int a, int b, Operator op)
    {
      int i = (int)op;

      switch (i)
      {
        case 0:
          return a + b;
        case 1:
          return a - b;
        case 2:
          return a * b;
        case 3:
          return a / b;
        default:
          return 0;
      }
    }


    public enum MyNum
    {
      Order_Recieved = 200,
      Order_Ready_For_Pickup = 301,
      Order_Out_For_Delivery = 404
    }



    public enum Operator { Plus, Minus, Multiply, Divide }

  }

}
