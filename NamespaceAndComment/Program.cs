

using NamespaceAndComment.Fruit;
using NamespaceAndComment.Heroes.MobileLegends.Fighter;
using System;
using System.Collections;

using PinoyHero = NamespaceAndComment.Heroes.Pinoy.Bisaya;

namespace NamespaceAndComment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // using a namespace built-in class

            var queue = new Queue(); // using a namespace built-in class

            var berry = new Strawberry(); // using a class from the same namespace
            var orange = new Fruit.Orange(); // other way using a class from a nested namespace

            var lapulapu = new LapuLapu(); // the mobile legends hero LapuLapu

            var heroLapuLapu = new PinoyHero.LapuLapu(); // the pinoy hero LapuLapu

            var mageHeroMl = new NamespaceAndComment.Heroes.MobileLegends.Mage.Change; // using full namespace path. Not recommended.
        }
    }
}
