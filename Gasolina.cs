using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberGasolina.Clases
{
    class Gasolina
    {
        double Subtotal;
        double IVA;
        double Total;
        public Gasolina()
        {
            Subtotal = 0;
            IVA = 0;
            Total = 0;
        }
        public void Extra()
        {
            double dato;
            Console.WriteLine("Ingrese numero de Galones de Gasolina");
            dato = double.Parse(Console.ReadLine());
            
            Subtotal=dato*1.5;
            IVA = Subtotal * 0.12;
            Total = IVA + Subtotal;
            Console.WriteLine("--------------------");
            Console.WriteLine("|El subtotal es: " + Subtotal+"|");
            Console.WriteLine("--------------------");
            Console.WriteLine("-----------------");
            Console.WriteLine("|El IVA es: " + IVA+"|");
            Console.WriteLine("-----------------");
            Console.WriteLine("---------------------");
            Console.WriteLine("|El total es : " + Total+"|");
            Console.WriteLine("---------------------");
            Console.WriteLine("Los galones ingresados fueron: "+dato );
            Console.WriteLine("El costo por galon es de 1,5$");
        }
        public void Super()
        {
            double dato;
            Console.WriteLine("Ingrese numero de Galones de Gasolina");
            dato = double.Parse(Console.ReadLine());

            Subtotal = dato * 2;
            IVA = Subtotal * 0.12;
            Total = IVA + Subtotal;
            Console.WriteLine("--------------------");
            Console.WriteLine("|El subtotal es: " + Subtotal + "|");
            Console.WriteLine("--------------------");
            Console.WriteLine("-----------------");
            Console.WriteLine("|El IVA es: " + IVA + "|");
            Console.WriteLine("-----------------");
            Console.WriteLine("---------------------");
            Console.WriteLine("|El total es : " + Total + "|");
            Console.WriteLine("---------------------");
            Console.WriteLine("Los galones ingresados fueron: " + dato);
            Console.WriteLine("El costo por galon es de 2$");
        }



    }
}
