namespace AlgorythmsAndDataEstructs.Challenges
{
  public class Arrays() {
    public static int[] ints = { 2, 4, 6, 8, 10, 12, 1, 16, 18, 20 };
  //Encontrar o maior e o menor elemento em um array
    public static int[] FindHigherAndlowerNums(int[] arr)
    {
      int lower = arr[0];
      int higher = arr[0];

      for (var i = 0; i <= arr.Length -1; i++) {
        if (arr[i] > higher) higher = arr[i];
        if (arr[i] < lower) lower = arr[i];
      }      
      return [higher, lower];
    } 

  }
}