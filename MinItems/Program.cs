
List<int> items = new List<int> { 6, 1, 3, 0, 2, 4, 5 };

MinItems.getMin(items);

public class MinItems
{

    public static void getMin(List<int> list)
    {

        int temp = 0;
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i+1; j < list.Count; j++)
            {
                if(list[j] < list[i])
                {
                    temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;

                }
            }

            Console.WriteLine(list[i]);
        }


    }
}





