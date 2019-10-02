using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //se mandara un mensaje que diga hola mundo           
            //se declara variable 
            string nom;

            Console.WriteLine("Hello World!");
            //aqui se pregunta el nombre del usuario a mandar el mensaje       
            Console.Write("\n\t¿ Cual es tu nombre ? R= ");
            //aqui se le da valor a la variable que el nombre que escriba estara en el mensaje 
            nom = Console.ReadLine();
            //aqui se usa la concatenacion para mostrar el mensaje 
            Console.Write("\n\thola: " + nom + " \n\nY tu mensaje es Hola mundo. ");                        //este es el proceso de salida 
            Console.WriteLine("\npresione cualquier tecla para terminar...");
            Console.ReadKey();
        }
    }
}

namespace conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se declara la variable con el valor asignado 
            string numero = "1234";
            //Se muestra la el tipo de dato de la varible 
            Console.WriteLine(numero.GetType().ToString());
            //Se realiza la conversion del tipo de dato String a int 
            int intNumero = Convert.ToInt32(numero);
            //Se muestra el tipo de dato de la varible para mostrar el cambio 
            Console.WriteLine(intNumero.GetType().ToString());
            //Se imprime la nueva variable 
            Console.WriteLine(String.Format("El número es {0}", intNumero));
            Console.ReadLine();
        }
    }
}

namespace Aleatorio
{
    class Program
    {
        //SUMA DE NUMEROS ALEATORIOS 

        static public float numero1 = 24.5F;
        static void Main(String[] args)
        {
            //Hacemos la declaracion dentro de un metodo 
            float numero2 = 0.0F;
            //Aqui es donde se le asigna un valor aleatorio 
            Random numAleatorio = new Random();
            numero2 = (float)numAleatorio.Next(1, 11);
            Console.WriteLine(string.Format(
            "El resultdo de la suma de {0} y {1} es {2}",
            numero1, numero2, numero1 + numero2));
            Console.ReadLine();
        }
    }
}
namespace Entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primero se declara la variable a usar 
            string valor;
            //Posteriormente se pide la variable 
            Console.Write("\n\n\tEscribe algo: ");
            //A continuacion se lee y se guarda en la variable declarada 
            valor = Console.ReadLine();
            //Se hace un try catch que es mas facil de usar y con menos problemas que con el if else 
            try
            {
                int x = int.Parse(valor);
                Console.WriteLine("\n\tDato entero {0} es correcto.", valor);
            }
            catch
            {
                Console.WriteLine("\n\tDato no es entero. Intentar de nuevo.");
            }
            //Y finalmente se acaba el programa 
            Console.WriteLine("\n\tPresiona enter para continuar....");
            //Se hace un ReadKey ya que sin el no se veria el programa solo correria sin pausarse 
            Console.ReadKey();
        }
    }
}
namespace nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            // la variable string  es una secuencia ordenada 
            // de longitud arbitaria aunque finita 
            Console.Write(" Escribe un nombre: ");
            nombre = Console.ReadLine();
            Console.Write(" Escribe un Apellido: ");
            apellido = Console.ReadLine();
            // la variable ToUpper se utiliza para hacer los nombres en mayúsculas  
            nombre = nombre.ToUpper();
            apellido = apellido.ToUpper();

            // la variable StringBuilder es una cadena de caracteres mutable y es un objeto del espacio de nombres 

            StringBuilder nombrecompleto = new StringBuilder();
            nombrecompleto.Append(nombre);
            nombrecompleto.Append(" ");
            nombrecompleto.Append(apellido);

            Console.WriteLine(nombrecompleto);
            Console.ReadKey();

        }
    }
}
namespace tabla
{
    class Program
    {
        static void Main(string[] args)
        {

            string _numero;
            int numero;

            //tenemos que poner las variables que ocupamos y convertirlo en un valor numerico  
            Console.Write("esribe un numero del 1 al 9");
            _numero = Console.ReadLine();
            numero = Convert.ToInt32(_numero);
            // El for es una variable contada como un bucle 

            for (int i = 1; i <= 10; i++)
                Console.WriteLine(
                    string.Format("{0} x {1} = {2}");
            numero,i,numero* i));

            // tiene que terminar  
            Console.WriteLine("");
            Console.WriteLine("darle enter para continuar");
            Console.ReadKey();
        }
    }
}
namespace Tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            // temenos que poner la variable int para determinar el numero que se utlizara 
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Tabla del " + i);
                // ponemos la variable for para que se repita, como son multiplicacion 
                for (int e = 1; e <= 10; e++)
                {
                    res = i * e;
                    Console.WriteLine(i + " x " + e + " = " + res);
                }

                Console.WriteLine(" ");
            }
            // tenemos que terminar el programa  
            Console.ReadKey();
        }
    }
}
namespace compara
{
    class Program
    {
        static void Main(string[] args)
        {
            //siempre se deben poner los datos que vamos a ocupar int es para numeros enteros 
            // string para hacer una cadena  

            string _num1 = "", _num2 = "";
            int num1 = 0, num2 = 0;

            Console.Write("num1 :");
            _num1 = Console.ReadLine();

            Console.Write("num2 : ");
            _num2 = Console.ReadLine();

            num1 = Convert.ToInt32(_num1);
            num2 = Convert.ToInt32(_num2);


            if (num1 == num2)
                // if se utiliza para hablar sobre situaciones si es real o es falso  
                Console.WriteLine(
                    String.Format(
                        "NUMEROS PROPORCIONADOS {0} y {1} {2}",
                        num1, num2, "LOS NUMEROS SON IGUALES"));


            else
            // else va con el if cuando es una estructura de control 
            if (num1 > num2)


                Console.WriteLine(
                    String.Format("NUMEROS PROPORCIONADOS {0} y {1} {2}",
                    num1, num2, "EL MAYOR ES EL SEGUNDO "));
            // para que demos finalidad al programa 

            Console.WriteLine("");
            Console.WriteLine("DARLE ENTER PARA CONTINUAR");
            Console.ReadKey();
        }
    }
}
namespace acumulado
{
    class Program
    {
        static void Main(string[] args)
        {
            string _numero;
            int numero;
            int acumulado = 0;

            Console.WriteLine("ponga los enteros a acumular");
            Console.WriteLine("dejar vacio y dar enter para que salga");
            Console.WriteLine("");

            while (true)

                // el while si utiliza para que se pueda repetir las veces que sean 
                // tienen que dar la orden de de pararlo con otras variables  

                Console.Write("pon un numero entero : ");
            _numero = Console.ReadLine();
            if (_numero == "") ;
            //nos permite si es verdad o falso  
            else

            if (int.TryParse(_numero out numero)) ;


            acumulado += numero;
            Console.WriteLine(String.Format("Monto acumulado : {0}"), acumulado));


            else

                Console.WriteLine("El dato proporcionado es un numero entero");

            // tenemos que poner readkey para terminar  
            Console.WriteLine("");
            Console.WriteLine("darle enter para continuar");
            Console.ReadKey();
        }
    }
}
namespace multiplo
{
    class Program
    {
        static void Main(string[] args)
        {

            string _numero;
            int numero;
            bool esMultiplo3, esMultiplo5, esMultiplo7;


            // la variable bool es tipo booleno tiene 2 posibles valores verdaderos  
            try

                // try para poner las intrucciones que desen realizar 

            console.write("dame un numero entero");
            _numero = Console.ReadLine();
            numero = Convert.ToInt32(_numero);

            esMultiplo3 = ((numero % 3 == 0);
            esMultiplo3 = ((numero % 5 == 0);
            esMultiplo3 = ((numero % 7 == 0);

            if ((esMultiplo3 & esMultiplo5 | esMultiplo7)
                // if para determinar si es verdero o falso 


                Console.WriteLine("Correcto");

            else
                Console.WriteLine("Incorrecto");
            
            }
    }
}

          
    

















