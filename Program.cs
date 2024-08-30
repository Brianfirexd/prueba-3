class EjemplosVarios
{

    static void Main()
    {
        int opcion;
        double capitalSocial;
        double aporte1, aporte2, aporte3;
        double porcentaje1, porcentaje2, porcentaje3;

        double promedio;
        string nombre_estudiante;

        double colegiatura = 0;
        int cantidad_materias;

        double a, b, c, x1, x2;
        double discriminante;

        Console.WriteLine("Ejemplos varios");
        Console.WriteLine("1) Socios");
        Console.WriteLine("2) Promedio");
        Console.WriteLine("3) Colegiatura");
        Console.WriteLine("4) Ecuación ax^2+bx+c=0");
        Console.WriteLine("Seleccione opcion");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Digite el aporte del primer socio");
                aporte1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite el aporte del segundo socio");
                aporte2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite el aporte del tercer socio");
                aporte3 = double.Parse(Console.ReadLine());
                capitalSocial = aporte1 + aporte2 + aporte3;
                porcentaje1 = aporte1 / capitalSocial * 100;
                porcentaje2 = aporte2 / capitalSocial * 100;
                porcentaje3 = aporte3 / capitalSocial * 100;
                Console.WriteLine("El aporte porcentual del primer socio es:" + porcentaje1 + "%");
                Console.WriteLine("El aporte porcentual del segundo socio es:" + porcentaje2 + "%");
                Console.WriteLine("El aporte porcentual del tercer socio es:" + porcentaje3 + "%");
                break;
            case 2:
                Console.WriteLine("Digite el nombre del estudiante:");
                nombre_estudiante = Console.ReadLine();
                Console.WriteLine("Digite el promedio");
                promedio = double.Parse(Console.ReadLine());

                if (promedio < 0)
                {
                    Console.WriteLine("Promedio incorrecta, promedio no puede ser negativo");
                }
                else if (promedio >= 0 && promedio < 60)
                {
                    Console.WriteLine("El estudiante " + nombre_estudiante + " está en proceso de aprendizaje");
                }
                else if (promedio >= 60 && promedio < 71)
                {
                    Console.WriteLine("El estudiante " + nombre_estudiante + " tiene promedio REGULAR");
                }
                else if (promedio >= 71 && promedio < 81)
                {
                    Console.WriteLine("El estudiante " + nombre_estudiante + " tiene promedio BUENO");
                }
                else if (promedio >= 81 && promedio < 91)
                {
                    Console.WriteLine("El estudiante " + nombre_estudiante + " tiene promedio muy bueno");
                }
                else if (promedio >= 91 && promedio <= 100)
                {
                    Console.WriteLine("El estudiante " + nombre_estudiante + " tiene promedio EXCELENTE!!!");
                }
                else
                {
                    Console.WriteLine("El promeido máximo no puede ser mayor que 100");
                }

                break;
            case 3:
                Console.WriteLine("Digite la cantidad de materias a inscribir");
                cantidad_materias = int.Parse(Console.ReadLine());
                if (cantidad_materias <= 15 && cantidad_materias >= 1)
                {
                    colegiatura = cantidad_materias * 50;
                }
                else if (cantidad_materias > 15 && cantidad_materias <= 20)
                {
                    colegiatura = 750;
                }
                else
                {
                    Console.WriteLine("Cantidad de materias no válida");
                }
                Console.WriteLine("Monto por colegiatura:" + colegiatura);

                break;
            case 4:
                Console.WriteLine("Ecuación cuadrática");
                Console.WriteLine("Digite el valor de a, b, c");
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());

                discriminante = Math.Pow(b, 2) - 4 * a * c;

                if (discriminante == 0)
                {
                    Console.WriteLine("La solución única");
                    x1 = -b / (2 * a);
                    Console.WriteLine("X1:" + x1);
                }
                else if (discriminante > 0)
                {
                    Console.WriteLine("Tiene dos soluciones:");
                    x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                    Console.WriteLine("X1:" + x1);
                    Console.WriteLine("X2:" + x2);
                }
                else
                {
                    Console.WriteLine("La ecuación no tiene soluciones reales");
                    discriminante = Math.Abs(discriminante);

                    Console.WriteLine("x1:" + (-b) / (2 * a) + "+" + ((Math.Sqrt(Math.Abs(discriminante)) / (2 * a))) + "i");
                    Console.WriteLine("x2:" + (-b) / (2 * a) + "-" + ((Math.Sqrt(Math.Abs(discriminante)) / (2 * a))) + "i");


                }


                break;
            default:
                Console.WriteLine("Opción no válida");
                break;

        }


    }

}