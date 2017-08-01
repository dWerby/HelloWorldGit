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
						Console.WriteLine("...User 1");

						var calc = new Calculator();
						Console.WriteLine("Added values are: " + calc.Add(7, 8));

						Console.WriteLine("Subtracted values are: " + calc.Sub(7, 8));
						Console.WriteLine("Subtracted values are: " + calc.Sub(8, 7));

						}

				}
		}
