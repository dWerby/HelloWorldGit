using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldGit
		{
		class Calculator
				{
				public Calculator()
						{

						}

				public int Add(int left, int right)
						{
						return left + right;
						}

				public int Sub(int left, int right)
						{
						return left - right;
						}

				public int Div(int left, int right)
						{
						if (right == 0)
								{
								return 0;
								}
						return left / right;
						}

				public int Mult(int left, int right)
						{
						return left * right;
						}

				public int Modulus (int left, int right)
						{
						return left % right;
						}

				public double StdDiv(double left, double right)
						{
						if (right == 0)
								{
								return 0;
								}
						return left / right;
						}

				}
		}
