using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldGit
		{
		class Runner
				{

				public Runner()
						{
						}

				public void Run()
						{
						Console.WriteLine("Hello Git World");
						Console.WriteLine("Just adding another...");
						Console.WriteLine("Just adding another line...");

						var calc = new Calculator();
						Console.WriteLine("Added values are: " + calc.Add(7, 8));

						Console.WriteLine("Subtracted values are: " + calc.Sub(7, 8));
						Console.WriteLine("Subtracted values are: " + calc.Sub(8, 7));

						Console.WriteLine("Divided values are: " + calc.Div(14, 2));
						Console.WriteLine("Divided values are: " + calc.Div(14, 0));
						Console.WriteLine("Multiplied values are: " + calc.Mult(8, 7));

						Console.WriteLine("Modulus result is: " + calc.Modulus(8, 7));
						Console.WriteLine("Modulus result is: " + calc.Modulus(15, 4));

						Console.WriteLine("StdDivided values are: " + calc.StdDiv(14, 2.54));
						Console.WriteLine("StdDivided values are: " + calc.StdDiv(14, 0));

						}

				}
		}
