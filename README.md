# Итоговая проверочная работа - 1 Четверть
## Текст задания
![Текст задания](https://gbcdn.mrgcdn.ru/uploads/asset/4312773/attachment/ed8c1f2c15da325114976e1c313ef5f8.png)
## Описание решения
1. Создаем первоначальный массив строк *arrayOriginal*, считывая строки из консоли. Пользователь вводит строки через пробел.
```
string inputString = Console.ReadLine()!;
string[] arrayOriginal = inputString.Split(" ");
```
2. Определяем число строк в первоначальном массиве, длина которых меньше либо равна 3 символа, и записываем их в переменную типа int *newArrayElements*, используя метод *CountArrayElements*.
```
int newArrayElements = CountArrayElements(arrayOriginal);
```
Переменная newArrayElements используется для задания длины нового массива со строками соответсвующими требованию ТЗ.

3. Инициализируем новый массив и заполняем его строками требуемой длины используя метод *CreateNewArray*.
```
string[] resultArray = CreateNewArray(arrayOriginal);
```
4. Выводим в консоль первоначаный массив строк и целевой массив строк.
```
Console.WriteLine();
Console.WriteLine("Origin array:");
Console.Write("[" + $"{String.Join(", ", arrayOriginal)}" + "]");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("New array:");
Console.Write("[" + $"{String.Join(", ", resultArray)}" + "]");
```
* Описание метода *CountArrayElements*

В цикле проверяем все строки первоначального массива, начиная с нулевого индекса, на соответствие условию - число символов меньше либо равно 3.
Если условие выполняется прибавляем к счетчику единицу. 
```
    if (elementMaxLength <= 3)
    {
        newArrayElements++;
    }
```
* Описание метода *CreateNewArray*

Метод создает новый массив строк с числом строк равным *newArrayElements*. 
```
string[] newArray = new string[newArrayElements];
    
```
Заполняем массив *newArray* строками из первоначального массива, удовлетворяющих условию *stringArray[i].Length <= 3*

```
    for (int i = 0; i < arrayOriginal.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            newArray[j] = stringArray[i];
            j++;
        }
    }
```