﻿// #1 DECLARE VARIABLES

// "string name;" --> Al declarar una variable sin asignarle valor se lo llama inicializar la variable
// No obstante vamos a inicializarla de una forma más limpia, asignandole un valor vacío:

string name = string.Empty;
int age  = 0; //Hay que evitar que no tengan un valor por defecto
int retirementAge = 65; //Por ejemplo en España

/**************************************************************************************************/

// #2 PROMPT THE USER INPUT

// NAME

Console.WriteLine("Please enter your name"); // Escribe la línea "Por favor introduce tu nombre". Es lo que se le pide al usuario

name = Console.ReadLine(); //Permitirá en la consola (recordemos que esto es una aplicación de consola) lectura (escritura del lado del usuario) de la línea que se espera que rellene. En este caso el nombre = lo que el usuario introduzca



// AGE

Console.WriteLine("Please enter your age");
age = Convert.ToInt32(Console.ReadLine()); // La función Console.ReadLine funciona para strings. Con una variable numérica como la edad tendremos que transformar el la función de manera que lea "Int" --> función Convert.(distintas opciones)



// #3 PROCESS THE DATA

// Declararemos edad de jubilación arriba

int workingYearsRemaining = retirementAge - age;

// Output the results to the user:

Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");



