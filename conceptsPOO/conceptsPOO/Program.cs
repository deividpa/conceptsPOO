using conceptsPOO;
using System;

try
{
    Console.WriteLine(new Date(2022, 2, 29));
    Console.WriteLine(new Date(2021, 10, 31));
    Console.WriteLine(new Date(2021, 7, 4));
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}

