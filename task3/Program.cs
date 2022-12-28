/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Например,[“Russia”, “Denmark”, “Kazan”] → [] */
Console.Write($"Введите элементы массива: ");

int size = Convert.ToInt32(Console.ReadLine());
string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    arrayStrings[i] = element;
}
 string[] arrayFinal = new string[size];
 int len = 3;
 int pos = 0;
 for (int j = 0; j < size; j++)
 {
    if (arrayStrings[j].Length <= len)
    {
        arrayFinal[pos] = arrayStrings[j];
         pos++;
    }
 }
 Console.WriteLine();