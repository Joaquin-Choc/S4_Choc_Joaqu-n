namespace S4_Choc_Joaquín
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            bool continuar = true;

            while(continuar)
            {
                //Ingreso de opción
                bool opcioncorrecta = false;
                while (!opcioncorrecta)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Supervisado - Joaquín Choc - 1280423");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Menú");
                    Console.WriteLine("1. Meses del año");
                    Console.WriteLine("2. Encontrar el número mayor");
                    Console.WriteLine("3. Signos del zodiaco");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine("Ingrese una opción del menú");



                    try
                    {
                        opcion = Convert.ToInt32(Console.ReadLine());
                        if (opcion > 0 && opcion <= 4)
                        {
                            opcioncorrecta= true;
                        }
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("No debe ingresar letras o decimales");
                        Console.ReadKey();
                    }
                    Console.Clear();
                
                // fin de ingreso
                // ejecución de ejercicio según 
            }
            switch (opcion)
            {
                case 1: 
                    Console.WriteLine("Aqui va el ejercicio 1");
                    Console.WriteLine("Ingrese un número del 1 al 12");
                    int mes;

                    mes= Convert.ToInt32(Console.ReadLine());

                    if (mes >= 1 && mes <= 12) {

                        switch(mes)
                        {
                            case 1: Console.WriteLine("Mes = enero");
                                break;
                            case 2:
                                Console.WriteLine("Mes = febrero");
                                break;
                            case 3:
                                Console.WriteLine("Mes = marzo");
                                break;
                            case 4:
                                Console.WriteLine("Mes = abril");
                                break;
                            case 5:
                                Console.WriteLine("Mes = mayo");
                                break;
                            case 6:
                                Console.WriteLine("Mes = junio");
                                break;
                            case 7:
                                Console.WriteLine("Mes = julio");
                                break;
                            case 8:
                                Console.WriteLine("Mes = agosto");
                                break;
                            case 9:
                                Console.WriteLine("Mes = septiembre");
                                break;
                            case 10:
                                Console.WriteLine("Mes = octubre");
                                break;
                            case 11:
                                Console.WriteLine("Mes = noviembre");
                                break;
                            case 12:
                                Console.WriteLine("Mes = diciembre");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: debe ingresar un número entre 1 y 12");
                    }
                    Console.ReadKey();
                        break;
                    case 2: Console.WriteLine(" Aqui va el ejercicio 2");
                    int n1, n2, n3;
                        bool cero = false;

                    Console.WriteLine("Ingresar primer número");
                    n1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingresar segundo número");
                    n2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingresar tercer número");
                    n3 = Convert.ToInt32(Console.ReadLine());
                        if(n1 > 0)
                        {
                            cero = true;
                        }else if(n2 > 0)
                        {
                            cero = true;
                        }else if (n3 > 0)
                        {
                            cero = true;
                        }
                    if (cero)
                    {
                        if (n1 > n2)
                        {
                            if (n1 > n3)
                            {
                                Console.WriteLine("Número 1 es mayor");
                            }
                            else if (n1 == n3)
                            {
                                Console.WriteLine("Número 1 y 3 son mayor");
                            }
                            else
                            {
                                Console.WriteLine("Número 3 es mayor");
                            }
                        }
                        else if (n1 == n2)
                        {
                            if (n1 > n3)
                            {
                                Console.WriteLine("Número 1 y 2 son mayores");
                            } else if (n1 == n3)
                            {
                                Console.WriteLine("Todos los números son iguales");
                            }
                            else
                            {
                                Console.WriteLine("Número 3 es mayor");
                            }
                        }
                        else
                        {
                            if (n2 > n3)
                            {
                                Console.WriteLine("Número 2 es mayor");
                            }
                            else if(n2 == n3)
                            {
                                Console.WriteLine("Números 2 y 3 son mayores");
                            }
                            else
                            {
                                Console.WriteLine("Número 3 es mayor");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Ingresa un número");
                    }

                    Console.ReadKey();
                        break;
                    case 3: 
                    Console.WriteLine("Aqui va el ejercicio 3");
                        break;
                    case 4: 
                    continuar = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}