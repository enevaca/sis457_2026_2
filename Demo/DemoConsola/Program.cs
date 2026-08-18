using DemoConsola;
// Esto es un comentario de una sola línea
/* Esto es un comentario
 * de varias líneas */

// Variables

var variable = "Cualquier valor";
bool esActivo = false;
short enteroCorto = 10;
int entero = 1263;
long enteroLargo = 1234567890;
double real = 3.1416;
decimal real2 = 3.1416m;
float real3 = 3.1416f;
char caracter = 'A';
string cadena = "Esto es una cadena";
Boolean esActivo2 = true; // bool
Int16 enteroCorto2 = 20; // short
Int32 entero2 = 6548; // int
Int64 enteroLargo2 = 9876543210; // long
DateOnly fecha = new DateOnly(2007, 6, 1);
DateTime fechaHora = new DateTime(2026, 8, 15, 9, 42, 50);
DateTime fechaHora2 = DateTime.Now;

// Constantes
const double PI = 3.1416;
const string SIGLA_MATERIA = "SIS457";
const int NUMERO_MAXIMO = 10;

// Operadores y expresiones
entero = 25;
entero2 += 12;
entero2 %= 2;
bool esPar = entero % 2 == 0;
int a = 6 + 8 * 2;
int b = (6 + 8) * 2;
b--;

// Conversiones y cadenas
string conversionCadena = real.ToString();
string conversionCadena2 = Convert.ToString(real2);
int conversionEntero = Convert.ToInt32(real);
int conversionEntero2 = (int)real;
int conversionEntero3 = int.Parse("3");

string materia = "Fundamentos de la Programación";
string concatenar = SIGLA_MATERIA + " " + materia + ".";
string concatenar2 = $"{SIGLA_MATERIA} {materia}.";
string invertir = string.Concat(materia.Reverse());
string invertir2 = new string(materia.Reverse()?.ToArray());
int longitudCadena = materia.Length;
string mayusculas = materia.ToUpper();
string minusculas = materia.ToLower();
string interpolacion = string.Format("{0} - {1}.", SIGLA_MATERIA, materia);
string reemplazar = materia.Replace("a", "@").Replace("o", "0").Replace(" ", "_");
string subcadena = materia.Substring(10, 9);
int quitarEspaciosExtremos = ("    " + materia + "   ").Trim().Length;
string[] separar = materia.Split(' ');

// Estructuras de Control
bool esMenorEdad;
if (enteroCorto < 18) esMenorEdad = true;
else esMenorEdad = false;
esMenorEdad = enteroCorto < 18 ? true : false;
esMenorEdad = enteroCorto < 18;

switch (esMenorEdad)
{
    case true: cadena = "Es menor de edad"; break;
    default: cadena = "Es mayor de edad"; break;
}

int contador = 0;
while (contador < 3) {
    Console.WriteLine($"Contador while: {contador}");
    contador++;
}

do {
    Console.WriteLine($"Contador do-while: {contador}");
    contador--;
} while (contador > 0);

for (int i = 0; i < 3; i++) {
    Console.WriteLine($"Variable i en ciclo for: {i}");
}

// Métodos o funciones
void saludar(string nombre) {
    Console.WriteLine($"Hola, {nombre}");
}
saludar("Juan");

string invertirTexto(string texto) { 
    return string.Concat(texto.Reverse());
}
Console.WriteLine($"Texto invertido: {invertirTexto("Hola Mundo")}");

long factorial(int numero) {
    long factorial = 1;
    for (int i = 2; i <= Math.Abs(numero); i++) factorial *= i;

    if (numero < 0) factorial *= -1;
    return factorial;
}

Console.Write("Introduzca un número + o - para calcular el factorial: ");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"El factorial de {numero} es: {factorial(numero)}");

// POO - Programación Orientada a Objetos
Persona persona = new Persona();
persona.cedulaIdentidad = "123456";
persona.nombres = "Juan";
persona.primerApellido = "Pérez";
persona.segundoApellido = "López";
persona.fechaNacimiento = new DateOnly(2005, 12, 25);
persona.celular = 71717171;
persona.saludar();
Console.WriteLine($"edad: {persona.calcularEdad()}");

var estudiante = new Estudiante
{
    cedulaIdentidad = "654321",
    nombres = "María",
    primerApellido = "Guzmán",
    segundoApellido = "Suárez",
    fechaNacimiento = new DateOnly(2006, 8, 6),
    celular = 727277272,
    carnetUniversitario = "26-1234"
};
estudiante.saludar();

// Clases abstractas
//FiguraGeometrica figura = new FiguraGeometrica(); // Da error porque no se instancian las clases abstractas
Cuadrado cuadrado = new Cuadrado(5);
Console.WriteLine($"Cuadrado - Área: {cuadrado.area()}, Perímetro: {cuadrado.perimetro()}");

FiguraGeometrica rectangulo = new Rectangulo(4, 6);
Console.WriteLine($"Rectángulo - Área: {rectangulo.area()}, Perímetro: {rectangulo.perimetro()}");
