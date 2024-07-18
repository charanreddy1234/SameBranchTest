using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Project1
{
    internal class FileName
    {

        string ptrtr = string.Empty;
        double width, length, wallArea, ceilingArea;
        string widthString, lengthString;
        double HEIGHT = 8;

        Console.WriteLine( "Calculation of Room Paint Requirements");
      Console.Write( "Enter room length: ");
      lengthString = Console.ReadLine();
      length = double.Parse(lengthString);
        Console.Write( "Enter room width: ");
      widthString = Console.ReadLine();
      width = double.Parse(widthString);


    }
}
