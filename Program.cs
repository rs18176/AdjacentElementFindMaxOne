using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[5] { 5, 3, 3, 3, 4};
        ArrayList list = new ArrayList();
        foreach (int i in arr)
        {
            list.Add(i);
            list.Sort();
        }

        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list.Count; j++)
            {
                if (i != j && ((int)list[i]).Equals((int)list[j]))
                {
                    int temp = (int)list[i] + 1;
                    list.Add(temp);
                    list.Remove(list[i]);
                    list.Remove(list[i]);
                    list.Sort();
                    i = -1;
                    break;
                }
            }
        }
        int max = list.Cast<int>().Max();
        Console.WriteLine(max);
        Console.ReadLine();
    }
}