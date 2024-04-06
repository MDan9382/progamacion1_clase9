using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_9.Clases
{
    public class Carro
    {
        public string marca { get; }// = "nissan";
        public int modelo { get; }// = 2021;
        public string color { get; set; }
        public string dueño { get; set; }

        private int encendido = 0; 
        private int velocidad_actual = 0;
        public int maxvelocidad {get; set;} //incorrecto

        public Carro(string marc, int model, string col)
        {
            marca =  marc;
            modelo = model;
            color = col;


        }
       
        public int accel(int onoff)
        {
            if (onoff == 0)
            {
                Console.WriteLine("el carro esta apagado");
                return 0;
            }
            else
            {
                velocidad_actual += 10;
                return velocidad_actual; //Console.WriteLine(velocidad_actual + "km/h");
                
            }
        }

    }
}
