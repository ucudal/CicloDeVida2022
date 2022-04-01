//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            
          /*  for (int i = 0; i < 10000000; i++)
            {
                var Ferrocarril  = new Train($"Nos vamos a qatar {i}");
                Console.WriteLine($"Tren = {Ferrocarril.id}");
                
            }*/
            
            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");
            
            Boolean Verificacion = (t1==t2);
            Boolean Verificacion2 = (t2==t3);

            Console.WriteLine(Verificacion);
        
            Console.WriteLine(Verificacion2);
    }
}
}