using Proxy.Interfaces;
using System;

namespace Proxy.Clases
{
    public class Auto : ILlave 
    {
        public void EncenderAuto(int _iLlave)
        {
            Console.WriteLine("Encendiendo el auto.");
        }
    }
}
