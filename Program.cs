using System;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main(string[] args)
    {
        // ingrasar los nombres
        string[] nombres = new string[5];
        Console.WriteLine("ingrese el primer nombre");
        nombres[0] = Console.ReadLine();
        Console.WriteLine("ingrese el segundo nombre");
        nombres[1] = Console.ReadLine();
        Console.WriteLine("ingrese el tercer nombre");
        nombres[2] = Console.ReadLine();
        Console.WriteLine("ingrese el cuarto nombre");
        nombres[3] = Console.ReadLine();
        Console.WriteLine("ingrese el quinto nombre");
        nombres[4] = Console.ReadLine();



        int[] notas = new int[5];
        Console.WriteLine("ingrese la primera nota");
        notas[0] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese la segunda nota");
        notas[1] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese la tercera nota");
        notas[2] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese la cuarta nota");
        notas[3] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese la quinta nota");
        notas[4] = Convert.ToInt32(Console.ReadLine());
       

        int option = 0;

        Console.WriteLine("Por escoga una opcion del 1 al 3: "," promedio", "nota mas alta", "nota mayor y menor");
        option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            //Calcular promedio
            case 1:
                int totalnota = notas.Sum();
                int promedio = totalnota / 5;
                Console.WriteLine("El promedio del la notas es " + promedio);
                break;
            //Calcular nota mas alta
            case 2:
                int notaA = notas.Max();
                Console.WriteLine(notas.Max());
                Console.WriteLine("la notas mas alta es:  " + notaA);
                break;
            //Calcular mayor y menor al promedio
            case 3:
                int totanota = notas.Sum();
                int prom = totanota / 5;
                Console.WriteLine("El promedio del las notas es " + prom);

                for(int i = 0; i< notas.Length; i++)
                {
                    if (notas[i] > prom)
                    {
                        Console.WriteLine("La nota " + notas[i]+ " encima del promedio");
                    }else{
                        Console.WriteLine("La nota " + notas[i]+ " abajo del promedio");

                    }
                  
                };
                break;


        }




    }
       
        
 }
