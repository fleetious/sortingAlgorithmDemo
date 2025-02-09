namespace SortingAlgorithmDemo;

public class Sort
{
    public static (int, int) FindSmallestValue(int[] array, int startSearchFromIndex)
    {
        int smallestValue = array[startSearchFromIndex];
        int indexOfSmallestValue = startSearchFromIndex;

        for(int i = startSearchFromIndex + 1; i < array.Length; i++)
        {
            if (array[i] < smallestValue)
            {
                smallestValue = array[i];
                indexOfSmallestValue = i;
            }
        }

        return (smallestValue, indexOfSmallestValue);
    }
    
    public static int[] BubbleSort(int[] array)
    {
        int allSortedFromIndex = array.Length; // initialized as entire array is not array
        int currentStartValue = array[0];
        bool hasSwapOccured = true;

        while(hasSwapOccured)
        {
            hasSwapOccured = false;

            for(int i = 1; i < allSortedFromIndex; i++)
            {
                if(array[i - 1] > array[i])
                {
                    int temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;

                    hasSwapOccured = true;
                }
            }

            if(array[allSortedFromIndex - 1] == currentStartValue)
            {
                currentStartValue = array[0];
                allSortedFromIndex--;
            }

        }
        
        return array;
    }

    public static int[] SelectionSort(int[] array)
    {
        int allSortedBeforeIndex = 0;

        while(allSortedBeforeIndex < array.Length)
        {
            int temp = array[allSortedBeforeIndex];
            (int value, int index) = FindSmallestValue(array, allSortedBeforeIndex);

            array[index] = temp;
            array[allSortedBeforeIndex] = value;

            allSortedBeforeIndex++;
        }

        return array;
    }

    public static int[] InsertionSort(int[] array)
    {
        bool hasSwapOccurred = true;

        for(int i = 1; i < array.Length; i++)
        {
            hasSwapOccurred = false;
            for(int j = i; j > 0; j--)
            {
                if(array[j] > array[j - 1]) continue; // greater than sign = least to greatest sort, and vice versa
                
                int temp = array[j];
                array[j] = array[j - 1];
                array[j - 1] = temp;
                
                hasSwapOccurred = true;
            }
        }

        return array;
    }
}
