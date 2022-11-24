/*
Задача со звездочкой: Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.
Пример правильной скобочной последовательности: (), ()[]{}
Пример неправильной: (], ({)}
Написать программу, которая определяет правильная ли скобочная последовательность была введена

 
Шпаргалка:
var name = new Stack<type>();
В классе Stack можно выделить следующие методы:
Clear: очищает стек
Contains: проверяет наличие в стеке элемента и возвращает true при его наличии
Push: добавляет элемент в стек в верхушку стека
Pop: извлекает и возвращает первый элемент из стека
Peek: просто возвращает первый элемент из стека без его удаления

поиск символа в строке
string.IndexOf(char)

 */
int maxLen(string[] array)
{
    int len = 0;
    foreach (var item in array)
    {
        if (len < item.Length) len = item.Length;
    }
    return len;
}


bool Check(string codeline)
{
    var stack = new Stack<char>();
    foreach (char item in codeline)
    {
        if ("({[".IndexOf(item) > -1)
        {//открывающие скобки суем в стек
            stack.Push(item);
        }
        else
        {
            if ("]})".IndexOf(item) == -1) continue;//если не скобка читаем дальше
            if (stack.Count > 0)
            {//стек не пуст -> достаем из него открывающую скобку
                int bracket = stack.Pop();
                
                if ((bracket == '[' && item != ']') ||             //закрывающая не совпадает с открывающей 
                    (bracket == '{' && item != '}') ||             //
                    (bracket == '(' && item != ')')) return false; //

            }
            else
            {//закрывающая скобка пришла, но стек пуст
                return false;
            }
        }
    }
    if (stack.Count > 0) { return false; }//строка закончилась а скобки не закрыты
    return true;
}


/* TEST */
string[] test = new string[]
{
    "()",       //true
    "()[]{ }",  //true
    "(]",       //false
    " ({)}",    //false
    "(sdrgkgb).sk25dh{s##1rh}=[s1/\\!dthsth]",  //true
    "(sdrgkgb).skdh{sr(h}=[sdt)hsth}",          //false
    ")()",  //false
};

foreach (var item in test)
{
    Console.WriteLine($"{Check(item),5} <- \"{item}\"");
}

