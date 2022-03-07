//     Exercise 01  

Console.WriteLine("Digite um número: ");
string number = Console.ReadLine();
Console.WriteLine("O número informado foi: " + number);


//    Exercise 02

Console.WriteLine("Informe o primeiro valor: ");
string valueOne = Console.ReadLine();
int numberOne = int.Parse(valueOne);
numberOne = Convert.ToInt32(valueOne);
Console.WriteLine("Informe o segundo valor: ");
string valueTwo = Console.ReadLine();
int numberTwo = int.Parse(valueTwo);
numberTwo = Convert.ToInt32(valueTwo);
int plus = numberOne + numberTwo;
Console.WriteLine("A soma dos valores propostos são: " + plus);


//     Exercise 03  

int numero1 = 19;
int numero2 = 18;
Console.WriteLine(Math.Max(numberOne , numberTwo));


//         Exercise 04  

int valor = 19;

if (valor % 2 == 0){
      Console.WriteLine(number + " é par");
}
else if (valor % 2 != 0) {
      Console.WriteLine(number + " é ímpar");
}


//     Exercise 05 
 
int[] numbers = {11, 22, 19, 78, 99};

foreach (int i in numbers){
      Console.WriteLine(numbers.Max());
}


//     Exercise 06 

for (int i = 1; i <= 10; i++){
     Console.WriteLine(i + " x " + "3" + " = " + i * 3);
}