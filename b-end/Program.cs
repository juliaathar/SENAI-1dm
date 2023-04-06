// string name = "Júlia";
// Console.WriteLine (name);

// int idade = 18;
// Console.WriteLine("A idade da " + name + " é " + idade + " anos ");

//crie um programa para calcular o IMC de uma pessoa

//algoritmo

string name = "Júlia";
int idade = 18;
float peso = 65;
float altura = 1.65F;

//processamento

float imc = peso / (altura * altura);

//saída 
Console.WriteLine("O IMC da " + name + " é " + Math.Round(imc,2));
