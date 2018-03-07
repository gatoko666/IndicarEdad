using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  11) Escribir un método que acepte un datetime que represente la
//fecha de nacimiento de una persona y retornar su edad al día de hoy.Nota: DateTime.Today te da la fecha de hoy.

namespace CalcularEdad
{
    class Program
    {
 

        static void Main(string[] args)
        {


            
            DateTime Hoy = DateTime.Now;
            DateTime nacimiento = new DateTime(1992, 03, 19);
            TimeSpan resta = Hoy - nacimiento;
            int diferencia = resta.Days;


            Console.WriteLine("Tú edad es  {0} años ",diferencia/365);

            Console.Read();


           

 

        }
    }

  

}
