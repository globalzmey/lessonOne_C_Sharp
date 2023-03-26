int firstNum = 0;
int secondNum = 0;
string firstNumString = "";
string secondNumString = "";

Console.WriteLine("Введите первое число");
while(!(Convert.ToBoolean(firstNum))) {
    firstNumString = Console.ReadLine();
    if(!(firstNumString != null && int.TryParse(firstNumString, out firstNum))) Console.WriteLine("Ввод не может быть пустым и должен быть числом. Повторите ввод первого числа.");
}

Console.WriteLine("Введите второе число");
while(!(Convert.ToBoolean(secondNum))) {
    secondNumString = Console.ReadLine();
    if(!(secondNumString != null && int.TryParse(secondNumString, out secondNum))) Console.WriteLine("Ввод не может быть пустым и должен быть числом. Повторите ввод первого числа.");
}

if(firstNum > secondNum) {
    Console.Write("max = ");
    Console.Write(firstNum);
}
else {
    Console.Write("max = ");
    Console.Write(secondNum);
}
Console.WriteLine();