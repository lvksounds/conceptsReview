namespace AlgorythmsAndDataEstructs.Challenges
{
  public class Arrays() {
  
  //Encontrar o maior e o menor elemento em um array
    public static (int min, int max) FindHigherAndlowerNums(int[] arr)
    {
      int lower = arr[0];
      int higher = arr[0];

      for (var i = 0; i <= arr.Length -1; i++) {
        if (arr[i] > higher) higher = arr[i];
        if (arr[i] < lower) lower = arr[i];
      }      
      return (higher, lower);
    }

    //Remover duplicatas de um array ordenado 

    public static int[] DuplicityRemove(int[] arr) {
      int[] NotduplicatedNums = new int[arr.Length];
      
      for(var num = 0; num < arr.Length; num++) {
        if(!NotduplicatedNums.Contains(num)){
          NotduplicatedNums[num] = arr[num];
        }
      }
      return NotduplicatedNums;      
    }

  }
}