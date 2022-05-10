Console.WriteLine("введите количество элементов массива");
string strN = Console.ReadLine();
int N =int.Parse(strN);
Console.WriteLine("введите  элементы массива");
string [] array = new string[N];
void MayArray(string [] array)
{
  for( int i = 0;i<array.Length;i++)
    {
    Console.Write(": ");
    string element = Console.ReadLine();
    array[i]=element;
    }
}

void ConclusionArray(string [] array)
{
  for(int i=0;i<array.Length;i++)
    {
    char[] mass = array[i].ToCharArray();
    if(mass.Length<=3)
         {
           Console.Write($"{array[i]},");
         }
    }
}
MayArray(array);
Console.Write($"массив из строк длина которых 3 или меньше символов =>\t");
ConclusionArray(array);