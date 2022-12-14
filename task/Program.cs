

using static System.Console;
Clear();
string[] array1 = new string[] { "1", "you", "score", "text", "tst", "programs", "40" };
string[] array2 = new string[array1.Length];

void TextScore(string[] array1, string[] array2)

{
 int count = 0;
  for (int i = 0; i < array1.Length; i++)
  {
      if (array1[i].Length < 4)
      {
          {
          array2[count] = array1[i];
          count++;
          }
      } 
  }
}
void PrintScore(string[] array)
  {
     for (int i = 0; i < array.Length; i++)
      {
          Write($"{array[i]} ");
      }
     WriteLine();
}
TextScore(array1, array2);
PrintScore(array2);