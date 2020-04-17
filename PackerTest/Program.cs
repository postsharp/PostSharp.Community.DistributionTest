using System;
using PostSharp.Community.Packer;
using Soothsilver.Random;

[assembly: Packer]

namespace PackerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (R.Next(1) == 0)
            {
                // ok
            }
            else
            {
                throw new Exception("Zero must be zero.");
            }
        }
    }
}