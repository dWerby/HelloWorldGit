﻿using System;
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
						if (left >= right)
								{
								return left - right;
								}
						return 0;
						}

				}
		}
