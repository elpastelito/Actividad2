using System;

namespace Actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("----- PUNTO 3 -----");
            Console.WriteLine("");
            Console.WriteLine("Ingrese su nota: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nota: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nota: ");
            float n3 = float.Parse(Console.ReadLine());
            float nt = (n1 + n2 + n3) / 3;
            Console.WriteLine("La nota definitiva es: " + nt);
            Console.WriteLine("");
            Console.WriteLine("----- PUNTO 7 -----");
            Console.WriteLine("");
            int hora, minuto, segundo;
            Console.WriteLine("Ingrese la hora: ");
            hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los minutos: ");
            minuto = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los segundos: ");
            segundo = int.Parse(Console.ReadLine());
            hora = hora * 60;
            minuto = (minuto * 60) + (hora * 60);
            segundo = segundo + minuto;
            Console.WriteLine("");
            Console.WriteLine("El total de segundos son: " + segundo + "s");
            Console.WriteLine("");
            Console.WriteLine("----- PUNTO 11 -----");
            Console.WriteLine("");
            Console.WriteLine("Ingrese su nota parcial: ");
            float nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nota parcial: ");
            float nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nota parcial: ");
            float nota3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del examen final: ");
            float ef = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del trabajo final: ");
            float tf = float.Parse(Console.ReadLine());
            double npf = ((nota1 + nota2 + nota3) / 3) * 0.55;
            double etf = ef * 0.3;
            double ttf = tf * 0.15;
            Console.WriteLine("Su nota final es: " + (npf + etf + ttf));
            Console.WriteLine("");
            Console.WriteLine("----- PUNTO 15 -----");
            Console.WriteLine("");
            double tt = 0, tta = 0;
            String pregunta;
            do
            {
                Console.WriteLine("Ingrese el precio del producto: ");
                tt = double.Parse(Console.ReadLine());
                Console.WriteLine("¿Quieres volver a ingresar? R// ");
                pregunta = Console.ReadLine();
                tta = tta + tt;
            } while (pregunta.Equals("si"));
            tta = (tta * 0.19) + tta;
            Console.WriteLine("");
            Console.WriteLine("El total a pagar: " + tta);
            Console.WriteLine("");
            Console.WriteLine("Ingrese el dinero en efectivo: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Su cambio es: " + (tta - r));
            Console.WriteLine("");
            Console.WriteLine("----- PUNTO 19 -----");
            Console.WriteLine("");
            Console.WriteLine("Ingrese su nombre: ");
            String name = Console.ReadLine();
            Console.WriteLine("Ingrese su programa de formaciòn: ");
            String formacion = Console.ReadLine();
            Console.WriteLine("Ingrese su ficha de formaciòn: ");
            String ficha = Console.ReadLine();
            Console.WriteLine("Ingrese la nota: ");
            double nn1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota: ");
            double nn2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota: ");
            double nn3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota: ");
            double nn4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota: ");
            double nn5 = double.Parse(Console.ReadLine());
            double nnt = ((nn1 + nn2 + nn3 + nn4 + nn5) / 5);
            Console.WriteLine("");
            Console.WriteLine("NOMBRE:                " + name);
            Console.WriteLine("PROGRAMA DE FORMACIÒN: " + formacion);
            Console.WriteLine("FICHA DE FORMACIÒN:    " + ficha);
            Console.WriteLine("NOTA FINAL:            " + nnt);
            Console.WriteLine("");
            Console.WriteLine("----- PUNTO 23 -----");
            Console.WriteLine("");
            Console.WriteLine("Ingrese la cantidad de metros que decea subir: ");
            float mm = float.Parse(Console.ReadLine());
            float hh = (float)0.714285714286;
            float mh = mm * hh;
            Console.WriteLine("El tiempo que tardarà es: " + mh + " horas");
        }
    }
}
