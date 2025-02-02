namespace SortingAlgorithmDemo;

public class Sort
{
    public static bool IsSorted(int[] array)
    {
        // handle cases where array size is less than 2
        if(array.Length < 2 && array[0] < array[1]) return true;
        
        for(int i = 1; i < array.Length; i++)
        {
            if(array[i - 1] > array[i]) return false;
        }
        
        return true;
    }
    
    public static int[] BubbleSort(int[] array)
    {
        int[] sorted = array;
        int allSortedFromIndex = array.Length; // initialized as entire array is not sorted
        int currentStartValue = array[0];

        while(!IsSorted(sorted))
        {
            for(int i = 1; i < allSortedFromIndex; i++)
            {
                if(sorted[i - 1] > sorted[i])
                {
                    int temp = sorted[i];
                    sorted[i] = sorted[i - 1];
                    sorted[i - 1] = temp;
                }
            }

            if(sorted[allSortedFromIndex - 1] == currentStartValue)
            {
                currentStartValue = sorted[0];
                allSortedFromIndex--;
            }
        }
        
        return sorted;
    }
}
