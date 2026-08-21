using System;

namespace _30ejercicios
{
    internal class Program
    {
        static void Main()
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("      GUÍA DE EJERCICIOS PRÁCTICOS EN C# (1-30)   ");
                Console.WriteLine("==================================================");
                Console.WriteLine("1 - 10 : Nivel 1 (Variables, Constantes y Operaciones)");
                Console.WriteLine("11 - 20: Nivel 2 (Condicionales Simples)");
                Console.WriteLine("21 - 30: Nivel 3 (Condicionales Múltiples)");
                Console.WriteLine("0      : Salir");
                Console.WriteLine("==================================================");
                Console.Write("Ingrese el número de ejercicio a ejecutar (0-30): ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("\n[Error] Ingrese un número válido.");
                    Pausar();
                    continue;
                }

                Console.Clear();
                EjecutarEjercicio(opcion);

            } while (opcion != 0);
        }

        static void Pausar()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        static void EjecutarEjercicio(int numero)
        {
            switch (numero)
            {
                case 0:
                    Console.WriteLine("¡Hasta luego!");
                    break;
                case 1: Ejercicio01(); break;
                case 2: Ejercicio02(); break;
                case 3: Ejercicio03(); break;
                case 4: Ejercicio04(); break;
                case 5: Ejercicio05(); break;
                case 6: Ejercicio06(); break;
                case 7: Ejercicio07(); break;
                case 8: Ejercicio08(); break;
                case 9: Ejercicio09(); break;
                case 10: Ejercicio10(); break;
                case 11: Ejercicio11(); break;
                case 12: Ejercicio12(); break;
                case 13: Ejercicio13(); break;
                case 14: Ejercicio14(); break;
                case 15: Ejercicio15(); break;
                case 16: Ejercicio16(); break;
                case 17: Ejercicio17(); break;
                case 18: Ejercicio18(); break;
                case 19: Ejercicio19(); break;
                case 20: Ejercicio20(); break;
                case 21: Ejercicio21(); break;
                case 22: Ejercicio22(); break;
                case 23: Ejercicio23(); break;
                case 24: Ejercicio24(); break;
                case 25: Ejercicio25(); break;
                case 26: Ejercicio26(); break;
                case 27: Ejercicio27(); break;
                case 28: Ejercicio28(); break;
                case 29: Ejercicio29(); break;
                case 30: Ejercicio30(); break;
                default:
                    Console.WriteLine("Número de ejercicio fuera de rango.");
                    break;
            }

            if (numero != 0) Pausar();
        }

        #region NIVEL 1: Variables, Constantes y Operaciones
        static void Ejercicio01()
        {
            Console.WriteLine("--- Ejercicio 01 ---");
            string nombre = "Jhasim";
            Console.WriteLine($"Bienvenido a Programación II, {nombre}");
        }

        static void Ejercicio02()
        {
            Console.WriteLine("--- Ejercicio 02 ---");
            const double PI = 3.14159;
            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            double area = PI * Math.Pow(radio, 2);
            Console.WriteLine($"El área del círculo es: {area}");
        }

        static void Ejercicio03()
        {
            Console.WriteLine("--- Ejercicio 03 ---");
            Console.Write("Ingrese su año de nacimiento: ");
            int anioNacimiento = Convert.ToInt32(Console.ReadLine());
            int anioActual = DateTime.Now.Year;
            int edad = anioActual - anioNacimiento;
            Console.WriteLine($"Su edad aproximada es: {edad} años.");
        }

        static void Ejercicio04()
        {
            Console.WriteLine("--- Ejercicio 04 ---");
            const double IVA = 0.13;
            Console.Write("Ingrese el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());
            double precioConIVA = precio + (precio * IVA);
            Console.WriteLine($"El precio final con IVA (13%) es: {precioConIVA}");
        }

        static void Ejercicio05()
        {
            Console.WriteLine("--- Ejercicio 05 ---");
            Console.Write("Ingrese el primer número decimal: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo número decimal: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Suma: {num1 + num2}");
            Console.WriteLine($"Resta: {num1 - num2}");
            Console.WriteLine($"Multiplicación: {num1 * num2}");
            Console.WriteLine($"División: {(num2 != 0 ? (num1 / num2).ToString() : "Indefinida (División por cero)")}");
        }

        static void Ejercicio06()
        {
            Console.WriteLine("--- Ejercicio 06 ---");
            Console.Write("Ingrese la nota 1: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la nota 2: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la nota 3: ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            double promedio = (n1 + n2 + n3) / 3.0;
            Console.WriteLine($"El promedio final es: {promedio:F2}");
        }

        static void Ejercicio07()
        {
            Console.WriteLine("--- Ejercicio 07 ---");
            int a = 5, b = 10;
            Console.WriteLine($"Valores originales -> a: {a}, b: {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Valores intercambiados -> a: {a}, b: {b}");
        }

        static void Ejercicio08()
        {
            Console.WriteLine("--- Ejercicio 08 ---");
            Console.Write("Ingrese la temperatura en grados Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Equivalente en Fahrenheit: {fahrenheit}°F");
        }

        static void Ejercicio09()
        {
            Console.WriteLine("--- Ejercicio 09 ---");
            Console.Write("Ingrese la cantidad de minutos: ");
            int minutosTotales = Convert.ToInt32(Console.ReadLine());
            int horas = minutosTotales / 60;
            int minutos = minutosTotales % 60;
            Console.WriteLine($"Equivale a: {horas} hora(s) y {minutos} minuto(s)");
        }

        static void Ejercicio10()
        {
            Console.WriteLine("--- Ejercicio 10 ---");
            Console.Write("Ingrese el dividendo: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el divisor: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 != 0)
                Console.WriteLine($"El residuo (%) de dividir {num1} entre {num2} es: {num1 % num2}");
            else
                Console.WriteLine("No se puede calcular el módulo con divisor cero.");
        }
        #endregion

        #region NIVEL 2: Condicionales Simples
        static void Ejercicio11()
        {
            Console.WriteLine("--- Ejercicio 11 ---");
            Console.Write("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(edad >= 18 ? "Es mayor de edad." : "Es menor de edad.");
        }

        static void Ejercicio12()
        {
            Console.WriteLine("--- Ejercicio 12 ---");
            Console.Write("Ingrese un número entero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num % 2 == 0 ? "El número es PAR." : "El número es IMPAR.");
        }

        static void Ejercicio13()
        {
            Console.WriteLine("--- Ejercicio 13 ---");
            Console.Write("Ingrese el primer número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            if (n1 > n2) Console.WriteLine($"El mayor es: {n1}");
            else if (n2 > n1) Console.WriteLine($"El mayor es: {n2}");
            else Console.WriteLine("Ambos números son iguales.");
        }

        static void Ejercicio14()
        {
            Console.WriteLine("--- Ejercicio 14 ---");
            Console.Write("Ingrese un número: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num >= 0 ? "El número es POSITIVO." : "El número es NEGATIVO.");
        }

        static void Ejercicio15()
        {
            Console.WriteLine("--- Ejercicio 15 ---");
            Console.Write("Ingrese la nota final (1-100): ");
            int nota = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nota >= 51 ? "Aprobado" : "Reprobado");
        }

        static void Ejercicio16()
        {
            Console.WriteLine("--- Ejercicio 16 ---");
            const string CLAVE_CORRECTA = "1234";
            Console.Write("Ingrese la contraseña: ");
            string clave = Console.ReadLine() ?? "";
            Console.WriteLine(clave == CLAVE_CORRECTA ? "Acceso permitido" : "Acceso denegado");
        }

        static void Ejercicio17()
        {
            Console.WriteLine("--- Ejercicio 17 ---");
            Console.Write("Ingrese un año: ");
            int anio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(anio % 4 == 0 ? "Es un año bisiesto." : "No es un año bisiesto.");
        }

        static void Ejercicio18()
        {
            Console.WriteLine("--- Ejercicio 18 ---");
            Console.Write("Ingrese el monto de la compra: ");
            double monto = Convert.ToDouble(Console.ReadLine());
            if (monto > 100)
                Console.WriteLine($"Aplica 10% de descuento. Total: ${monto * 0.90}");
            else
                Console.WriteLine($"Precio original: ${monto}");
        }

        static void Ejercicio19()
        {
            Console.WriteLine("--- Ejercicio 19 ---");
            Console.Write("Ingrese el primer número entero: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número entero: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n2 != 0 && n1 % n2 == 0)
                Console.WriteLine($"{n1} es divisible exactamente entre {n2}.");
            else
                Console.WriteLine($"{n1} NO es divisible exactamente entre {n2}.");
        }

        static void Ejercicio20()
        {
            Console.WriteLine("--- Ejercicio 20 ---");
            Console.Write("Ingrese las horas trabajadas: ");
            int horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(horas > 40 ? "Tiene horas extra" : "Jornada normal");
        }
        #endregion

        #region NIVEL 3: Condicionales Múltiples
        static void Ejercicio21()
        {
            Console.WriteLine("--- Ejercicio 21 ---");
            Console.Write("Ingrese un número entero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0) Console.WriteLine("El número es POSITIVO.");
            else if (num < 0) Console.WriteLine("El número es NEGATIVO.");
            else Console.WriteLine("El número es CERO.");
        }

        static void Ejercicio22()
        {
            Console.WriteLine("--- Ejercicio 22 ---");
            Console.Write("Ingrese n1: "); double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese n2: "); double n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese n3: "); double n3 = Convert.ToDouble(Console.ReadLine());

            if (n1 >= n2 && n1 >= n3) Console.WriteLine($"El mayor es: {n1}");
            else if (n2 >= n1 && n2 >= n3) Console.WriteLine($"El mayor es: {n2}");
            else Console.WriteLine($"El mayor es: {n3}");
        }

        static void Ejercicio23()
        {
            Console.WriteLine("--- Ejercicio 23 ---");
            Console.Write("Ingrese la nota (0-100): ");
            int nota = Convert.ToInt32(Console.ReadLine());
            if (nota >= 90) Console.WriteLine("Calificación: 'A'");
            else if (nota >= 80) Console.WriteLine("Calificación: 'B'");
            else if (nota >= 70) Console.WriteLine("Calificación: 'C'");
            else if (nota >= 60) Console.WriteLine("Calificación: 'D'");
            else Console.WriteLine("Calificación: 'F'");
        }

        static void Ejercicio24()
        {
            Console.WriteLine("--- Ejercicio 24 ---");
            Console.Write("Ingrese la edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            if (edad <= 12) Console.WriteLine("Etapa: Niño");
            else if (edad <= 17) Console.WriteLine("Etapa: Adolescente");
            else if (edad <= 64) Console.WriteLine("Etapa: Adulto");
            else Console.WriteLine("Etapa: Adulto mayor");
        }

        static void Ejercicio25()
        {
            Console.WriteLine("--- Ejercicio 25 ---");
            Console.Write("Ingrese n1: "); double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese n2: "); double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1:Suma, 2:Resta, 3:Multiplicación, 4:División");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1: Console.WriteLine($"Resultado: {n1 + n2}"); break;
                case 2: Console.WriteLine($"Resultado: {n1 - n2}"); break;
                case 3: Console.WriteLine($"Resultado: {n1 * n2}"); break;
                case 4: Console.WriteLine(n2 != 0 ? $"Resultado: {n1 / n2}" : "Error: División entre cero."); break;
                default: Console.WriteLine("Opción no válida."); break;
            }
        }

        static void Ejercicio26()
        {
            Console.WriteLine("--- Ejercicio 26 ---");
            Console.Write("Ingrese día (1-7): ");
            int dia = Convert.ToInt32(Console.ReadLine());
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            if (dia >= 1 && dia <= 7) Console.WriteLine(dias[dia - 1]);
            else Console.WriteLine("Error: Número fuera de rango.");
        }

        static void Ejercicio27()
        {
            Console.WriteLine("--- Ejercicio 27 ---");
            Console.Write("Ingrese peso (kg): "); double peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese estatura (m): "); double est = Convert.ToDouble(Console.ReadLine());
            double imc = peso / (est * est);
            Console.WriteLine($"IMC: {imc:F2}");

            if (imc < 18.5) Console.WriteLine("Categoría: Bajo peso");
            else if (imc <= 24.9) Console.WriteLine("Categoría: Normal");
            else if (imc <= 29.9) Console.WriteLine("Categoría: Sobrepeso");
            else Console.WriteLine("Categoría: Obesidad");
        }

        static void Ejercicio28()
        {
            Console.WriteLine("--- Ejercicio 28 ---");
            Console.WriteLine("1: Moto ($2), 2: Auto ($5), 3: Autobús ($10), 4: Camión ($15)");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1: Console.WriteLine("Costo: $2"); break;
                case 2: Console.WriteLine("Costo: $5"); break;
                case 3: Console.WriteLine("Costo: $10"); break;
                case 4: Console.WriteLine("Costo: $15"); break;
                default: Console.WriteLine("Opción inválida."); break;
            }
        }

        static void Ejercicio29()
        {
            Console.WriteLine("--- Ejercicio 29 ---");
            Console.Write("Lado 1: "); double l1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lado 2: "); double l2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lado 3: "); double l3 = Convert.ToDouble(Console.ReadLine());

            if (l1 == l2 && l2 == l3) Console.WriteLine("Triángulo Equilátero");
            else if (l1 == l2 || l1 == l3 || l2 == l3) Console.WriteLine("Triángulo Isósceles");
            else Console.WriteLine("Triángulo Escaleno");
        }

        static void Ejercicio30()
        {
            Console.WriteLine("--- Ejercicio 30 ---");
            Console.Write("Color del semáforo (rojo, amarillo, verde): ");
            string estado = Console.ReadLine()?.ToLower() ?? "";
            if (estado == "rojo") Console.WriteLine("Detenerse");
            else if (estado == "amarillo") Console.WriteLine("Precaución");
            else if (estado == "verde") Console.WriteLine("Avanzar");
            else Console.WriteLine("Color no reconocido.");
        }
        #endregion
    }
}