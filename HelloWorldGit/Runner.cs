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

						}

				}
		}
