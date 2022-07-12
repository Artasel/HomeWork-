// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

string res = "";
int count = 0;

while (true)
{
    Console.WriteLine("Введите числа");

    string? input = Console.ReadLine();     //вопрос означает готовность принять null вроде как

    bool provChtoChisloWwedeno = int.TryParse(input, out int result);  //проверка на число

    if(provChtoChisloWwedeno)
    {
        if(res == "")  res += input;
        else    res += "," + input;
        count++;
    }
    if(!provChtoChisloWwedeno)  break;
}


int[] Mass = new int[count];
string sborochnaiaPeremen = "";
int convertPeremen = 0;
int count2 = 0;

for(int i = 0; i < res.Length; i++)
{
    bool provChtoChislo = Char.IsNumber(res[i]);  //проверка на число

    if(provChtoChislo || res[i] == '-')
    {
        sborochnaiaPeremen += res[i];
    }  
    else
    {
        convertPeremen = Convert.ToInt32(sborochnaiaPeremen);
        Mass[count2] = convertPeremen;
        count2++;
        sborochnaiaPeremen = "";
    }
    if(i == res.Length - 1)
    {
        convertPeremen = Convert.ToInt32(sborochnaiaPeremen);
        Mass[count2] = convertPeremen;
    }
}

Console.WriteLine($"{String.Join(", ", Mass)}");

int bolsheNolia = 0;

for(int i = 0; i < Mass.Length; i++)
{
    if(Mass[i] > 0) bolsheNolia++;
}

Console.WriteLine($"Пользователь ввел {bolsheNolia} чисел больше ноля.");
