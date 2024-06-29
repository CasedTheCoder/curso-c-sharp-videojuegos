// Ejemplo de Declaración de Variables

/*
Esto es un ejemplo
de un comentario en bloque
para mis queridos suscriptores
de youtube
*/

int health = 100;
float speed = 5.5f;
char inicial = 'C';
string nombre = "Carlos";
bool isDead = false;

Console.WriteLine("La salud de nuestro personaje es " + health);
Console.WriteLine("La velocidad es " + speed);
Console.WriteLine("La inicial es " + inicial);
Console.WriteLine("El nombre es " + nombre);
Console.WriteLine("¿Está el personaje muerto?" + isDead);


// OPERACIONES CON VARIABLES

int salud = 100;
float mejora = 50;
float multiplicador = 2;
float penalizador = 2;

float saludMejorada = salud + mejora;
float saludMultiplicada = salud * multiplicador;
float saludPenalizada = salud / penalizador;

Console.WriteLine("Salud Mejorada: " + saludMejorada);
Console.WriteLine("Salud Multiplicada: " + saludMultiplicada);
Console.WriteLine("Salud Penalizada: " + saludPenalizada);

Console.WriteLine("Prueba suma de " + "strings o cadenas");
//Console.WriteLine("Prueba resta de " - "strings o cadenas");
//Console.WriteLine("Prueba multiplicación de " * "strings o cadenas");
//Console.WriteLine("Prueba división de " / "strings o cadenas");



// LECTURA DE VARIABLES DESDE TECLADO

Console.WriteLine("Introduce Primer Número: ");
int primerNumero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Primer Número: " + primerNumero);


Console.WriteLine("Introduce Segundo Número: ");
int segundoNumero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Segundo Número: " + segundoNumero);

Console.WriteLine("Suma de los números: " + (primerNumero + segundoNumero));
Console.WriteLine("Resta de los números: " + (primerNumero - segundoNumero));
Console.WriteLine("Multiplicación de los números: " + (primerNumero * segundoNumero));
Console.WriteLine("División de los números: " + ((float)primerNumero / (float)segundoNumero));


Console.WriteLine("Introduce el Nombre de tu Personaje: ");
nombre = Console.ReadLine();
Console.WriteLine("Bienvenido al Juego de Cased The Coder " + nombre);
