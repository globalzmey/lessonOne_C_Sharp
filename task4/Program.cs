int max = 0;
int firstNum = 0;
int secondNum = 0;
int thirdNum = 0;
string firstNumString = "";
string secondNumString = "";
string thirdNumString = "";

Console.WriteLine("Введите первое число");
while(!(Convert.ToBoolean(firstNum))) {
    firstNumString = Console.ReadLine();
    if(!(firstNumString != null && int.TryParse(firstNumString, out firstNum))) Console.WriteLine("Ввод не может быть пустым и должен быть числом. Повторите ввод первого числа.");
}

Console.WriteLine("Введите второе число");
while(!(Convert.ToBoolean(secondNum))) {
    secondNumString = Console.ReadLine();
    if(!(thirdNumString != null && int.TryParse(secondNumString, out secondNum))) Console.WriteLine("Ввод не может быть пустым и должен быть числом. Повторите ввод второго числа.");
}

Console.WriteLine("Введите третье число");
while(!(Convert.ToBoolean(thirdNum))) {
    thirdNumString = Console.ReadLine();
    if(!(thirdNumString != null && int.TryParse(thirdNumString, out thirdNum))) Console.WriteLine("Ввод не может быть пустым и должен быть числом. Повторите ввод третьего числа.");
}

max = firstNum;

if(max < secondNum) max = secondNum;
if(max < thirdNum) max = thirdNum;

Console.Write("Максимальное число - ");
Console.WriteLine(max);