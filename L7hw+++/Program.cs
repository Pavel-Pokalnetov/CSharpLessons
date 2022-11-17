/* 
Задача со звездочкой: Написать программу для перевода римских чисел в десятичные арабские.
III -> 3
LVIII -> 58
MCMXCIV -> 1994
*/

int RomeToAracbic(char sumbol)
{   //возвращает арабское число соответствующее входной греческой цифре
    string romeNumeric = "IVXLCDM";
    int[] arabicNumeric = new int[7] { 1, 5, 10, 50, 100, 500, 1000 };
    int index = romeNumeric.IndexOf(sumbol);
    if (index >= 0) return arabicNumeric[index];
    return 0;//если не найден символ греческих цифр возвращаем 0
}

int RomeNumberParse(string romeNumber)
{
    int result = 0;
    for (int i = 0; i < romeNumber.Length; i++)
    {
        int currentNumber = RomeToAracbic(romeNumber[i]);
        if (currentNumber == 0)
        {   //выбрасываем исключение если обнаружен неверный символ
            throw new Exception("Error in the Greek number symbols.");
        }
        if (i + 1 < romeNumber.Length)
        {
            //если есть следующая цифра
            if (currentNumber < RomeToAracbic(romeNumber[i + 1]))
            {
                result -= currentNumber;
            }
            else
            {
                result += currentNumber;
            }
        }
        else
        // обработка последней цифры 
        {
            result += currentNumber;
        }
    }
    return result;
}

//проверка по значениям из задания
string[] exampleRome = { "III", "LVIII", "MCMXCIV" };
foreach (var item in exampleRome)
{
    int arabicNumber = RomeNumberParse(item);
    Console.WriteLine($"{item} = {arabicNumber}");
}

/* вывод консоли
III = 3
LVIII = 58
MCMXCIV = 1994
*/