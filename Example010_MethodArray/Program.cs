﻿int[] array = { 11, 21, 17, 41, 15, 6, 17, 83 };

int n = array.Length;
int find = 17;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}