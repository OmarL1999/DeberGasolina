using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberGasolina.Clases
{
    class Cliente
    {
        private String nombres;

        public String Nombres
        {
            get { return nombres; }
            set
            {
               if(value.Split().Length<2)
                {
                    throw new Exception("Ingrese Nombre Valido");
                }
                
                nombres = value;
            }
        }
        private String apellidos;

        public String Apellidos
        {
            get { return apellidos; }
            set 
            {
                if (value.Split().Length < 2)
                {
                    throw new Exception("Ingrese Apellido Valido");
                }
                apellidos = value; 
            }
        }
        private int cedula;

        public int Cedula
        {
            get { return cedula; }
            set {
                cedula = value; 
                
            }
        }
        private String direccion;

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }




    }
}
