﻿// See https://aka.ms/new-console-template for more information
// The link actually isn't an example of using XUnit. I'm using the code in the link, to learn 
// how to use XUnit. 
Console.WriteLine("Hello, World!");

int a = 2;
int b = 3;
int x = Add2(a, b);

Console.WriteLine($"The sum of the two ints is {x}");

int Add2(int a, int b) => a + b;
