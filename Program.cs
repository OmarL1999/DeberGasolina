using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeberGasolina.Clases;
using System.Threading.Tasks;

namespace DeberGasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente D = new Cliente();
            Gasolina I = new Gasolina();
            Console.WriteLine("----------------------------------------------Cía. Ltda----------------------------------------------");
            Console.WriteLine("-----------Datos del Cliente-----------");
            Boolean val = true;
            
            do
            {
                try
                {

                    Console.WriteLine("Ingrese Nombres: ");
                    D.Nombres = Convert.ToString(Console.ReadLine());
                    val = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (val);
            Boolean val1 = true;    
            do { 
                try
                    {
                        Console.WriteLine("Ingrese Apellidos: ");
                        D.Apellidos = Convert.ToString(Console.ReadLine());
                    val1 = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                       
                   
               
            } while (val1);
            
            Console.WriteLine("Ingrese N° de Cedula: ");
            
            D.Cedula = Convert.ToInt32(Console.ReadLine());
               
            Boolean val2 = true;
            do
            {
                try
                {
                    Console.WriteLine("Ingrese Direccion");
                    D.Direccion = Convert.ToString(Console.ReadLine());
                    val2 = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (val2);

                int opt =0;
            
                Console.WriteLine("----Escoja el tipo de Gasolina---");
                Console.WriteLine("     -----------------------");
                Console.WriteLine("     |      1.-Extra       |");
                Console.WriteLine("     |      2.-Super       |");
                Console.WriteLine("     -----------------------");
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("---------------Usted A elegido Gasolina Extra---------");
                        I.Extra();
                        Console.WriteLine("------------Cliente------------");
                    Console.WriteLine("Nombres:" + D.Nombres + " " + D.Apellidos);

                    Console.WriteLine("Cedula: " + D.Cedula);
                    Console.WriteLine("Direccion: " + D.Direccion);
                    

                    break;
                    case 2:
                        Console.WriteLine("---------------Usted A elegido Gasolina Super---------");
                        I.Super();
                        Console.WriteLine("----------Cliente-----------");
                        Console.WriteLine("Nombres:"+D.Nombres+" "+D.Apellidos);
                      
                        Console.WriteLine("Cedula: "+D.Cedula);
                        Console.WriteLine("Direccion: "+D.Direccion);
                    
                    
                       
                        break;

                }
            Console.ReadKey();
            

        }
    }
}
