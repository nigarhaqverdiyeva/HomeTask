#region  Verilən stringi tərsinə yaz   task1
//string text = "necesen";
//string ReverseText = " ";
//for (int i = text.Length-1; i >=0; i--)
//{
//    ReverseText += text[i];
//}
//Console.WriteLine(ReverseText);

#endregion

#region Ədədin perfect number olub olmadığını tap (Ədədin bölənləri cəmi özünü qaytarırsa bu perfect numberdir. 1+2+3=6)   task2
//int num = 6;
//int sum=0;
//for (int i = 1;i<num;i++)
//{
//    if (num%i==0)
//    {
//        sum += i;
//    }
//}
//if(num==sum)
//{
//    Console.WriteLine(num+" "+" perfect number-dir");
//}
//else
//{
//    Console.WriteLine(num + " " + " perfect number deyil");
//}





#endregion

#region Sözdəki saitlərin sayını tapın. task3
//char[] letters = { 'a', 'e', 'o', 'u', 'i', 'A', 'E', 'U', 'I', 'O' };
//string[] strArr = { "Salam", "aztu", "ab108", "codeacadmey", "Sagol" };
//int countInput ;
//int count = 0;
//for (int i = 0; i < strArr.Length; i++)
//{
//    Console.WriteLine(strArr[i]);
//    Console.Write("Zehmet olmasa eded daxil edin");
//    countInput = int.Parse(Console.ReadLine());
//    count = 0;
//    for (int k = 0; k < strArr[i].Length; k++)
//    {
//        for (int j = 0; j < letters.Length; j++)
//        {
//            if (strArr[i][k] == letters[j])
//            {
//                count++;
//                break;
//            }
//        }
//    }
//        if (count == countInput)
//        {
//            Console.WriteLine("Eded duzgun daxil edilib");
//        }
//        else
//        {
//            Console.WriteLine("Eded duzgun daxil edilmeyib");
//        }
//}


#endregion

#region  2 arrayı birləşdirin
int[] arr = { 1, 2, 3, 4, 5, 5 };
int[] arr1 = { 6, 7, 8, 9, 10, 11, 12, 13 };
int[] newarr = new int[arr.Length + arr1.Length];
int index = 0;
for (int i = 0; i < arr.Length; i++)
{
    newarr[index++] = arr[i];
}
index++;
for (int j = 0; j < newarr.Length; j++)
{
    newarr[index++] = newarr[j];
}
Console.WriteLine(index);

#endregion

#region Arrayın sıralı olub olmadığını yoxlayın
//int[] arr = {1,2,3,4,5,8,6,7};
//bool a=false;
//for(int i=1;i<arr.Length;i++)
//{
//    if (arr[i] < arr[i - 1])
//    {
//        a = false;
//        break;
//    }
//    else
//    {
//        a = true;
//    }
//}
//Console.WriteLine(a);

#endregion

