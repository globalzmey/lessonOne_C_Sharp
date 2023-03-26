int num = 0;
string numString = "";

Console.WriteLine("Введите число");
while(!(Convert.ToBoolean(num))) {
    numString = Console.ReadLine();
    if(!(numString != null && int.TryParse(numString, out num))) Console.WriteLine("Ввод не может быть пустым и должен быть числом. Повторите ввод.");
}

if(!(Convert.ToBoolean(num % 2))) Console.WriteLine("Число чётное");
