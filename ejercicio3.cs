using System;
class ejercicio3 {
  static void Main() {
     double myDouble = 9.78;
     
     int edad;
     string nombre;
     
     Console.WriteLine("Ingrese su nombre: ");
     nombre = Console.ReadLine();
     Console.WriteLine("Ingrese su edad: ");
     edad = Convert.ToInt16(Console.ReadLine());
     Console.WriteLine("Su nombre es: " + nombre);
     Console.WriteLine("Su edad es: " + edad);
  }
}
