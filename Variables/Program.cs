// Ejemplo de declaración de variables

int health = 100;
float speed = 5.5f;
char inicial = 'C';
string nombre = "Carlos";
bool isDead = false;


// Ejemplo de imprimir por pantalla variables

Console.WriteLine("La salud de nuestro personaje es " + health);
Console.WriteLine("La velocidad es " + speed);
Console.WriteLine("La inicial es " + inicial);
Console.WriteLine("El nombre es " + nombre);
Console.WriteLine("¿Está el personaje muerto?" + isDead);


/*
Esto es un ejemplo
de un comentario
en bloque
para mis seguidores
de Youtube
*/


// OPERACIONES CON VARIABLES

int saludInt = 100;
int mejoraInt = 50;
int multiplicadorInt = 2;
int penalizadorInt = 2;

int saludFinalSumaInt = saludInt + mejoraInt;
int saludFinalRestaInt  = saludInt - mejoraInt;
int saludFinalMultiplacionInt  = saludInt * multiplicadorInt;
int saludFinalPenalizadaInt  = saludInt / penalizadorInt;


Console.WriteLine("La salud sumada en int de nuestro personaje es " + saludFinalSumaInt);
Console.WriteLine("La salud restada en int de nuestro personaje es " + saludFinalRestaInt);
Console.WriteLine("La salud multiplicada en int de nuestro personaje es " + saludFinalMultiplacionInt);
Console.WriteLine("La salud penalizada en int de nuestro personaje es " + saludFinalPenalizadaInt);


float saludFloat = 100.0f;
float mejoraFloat = 25.5f;
float multiplicadorFloat = 1.5f;
float penalizadorFloat = 1.5f;

float saludFinalSumaFloat  = saludInt + mejoraFloat;
float saludFinalRestaFloat  = saludFloat - mejoraFloat;
float saludFinalMultiplacionFloat  = saludFloat * multiplicadorFloat;
float saludFinalPenalizadaFloat  = saludFloat / penalizadorFloat;

Console.WriteLine("La salud sumada en float de nuestro personaje es " + saludFinalSumaFloat);
Console.WriteLine("La salud restada en float de nuestro personaje es " + saludFinalRestaFloat);
Console.WriteLine("La salud multiplicada en float de nuestro personaje es " + saludFinalMultiplacionFloat);
Console.WriteLine("La salud penalizada en float de nuestro personaje es " + saludFinalPenalizadaFloat);


Console.WriteLine("Prueba de suma de " + "cadenas");
//Console.WriteLine("Prueba de resta de " - "cadenas");
//Console.WriteLine("Prueba de multiplicación de " * "cadenas");
//Console.WriteLine("Prueba de división de " / "cadenas");


// LECTURA D VARIABLES POR TECLADO

Console.WriteLine("Introduce primer número: ");
float primerNumero = (float)Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Introduce segundo número: ");
float segundoNumero = (float)Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Primer número: " + primerNumero);
Console.WriteLine("Segundo número: " + segundoNumero);

Console.WriteLine("Suma: " + (primerNumero + segundoNumero));
Console.WriteLine("Resta: " + (primerNumero - segundoNumero));
Console.WriteLine("Multiplicación: " + primerNumero * segundoNumero);
Console.WriteLine("División: " + primerNumero / segundoNumero);

Console.WriteLine("Introduce el Nombre de tu Personaje:");
string nombre = Console.ReadLine();
Console.WriteLine("Bienvenida al juego de Cased the Coder, " + nombre);
