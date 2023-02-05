Problem1();
Problem2();

// Array of integers and two threads. The first thread adds up all the even numbers in the array,
// and the second thread adds up all the odd numbers in the array. Once both threads have finished,
// the main thread should output the sum of both results.
async void Problem1()
{
    var sum100 = Task.Run(() => SumRangeOdd(100));
    var sum1000 = Task.Run(() => SumRangeEven(1000));
    var sum10000 = Task.Run(() => SumRange(10000));

    await Task.WhenAll(sum100, sum1000, sum10000);
    
    Console.WriteLine(sum100.Result);
    Console.WriteLine(sum1000.Result);
    Console.WriteLine(sum10000.Result);

    int SumRangeOdd(int endRange)
    {
        int sum = 0;

        for (int i = 0; i < endRange; i++)
        {
            if (i % 2 != 0)
            {
                sum += i;
            }
        }

        return sum;
    }

    int SumRangeEven(int endRange)
    {
        int sum = 0;

        for (int i = 0; i < endRange; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }

        return sum;
    }
    int SumRange(int endRange)
    {
        int sum = 0;

        for (int i = 0; i < endRange; i++)
        {
            sum += i;
        }

        return sum;
    }

}

// Given an array of integers, create a multi-threaded solution to calculate the sum of all elements in the array.
void Problem2()
{
    var arr = Enumerable.Range(0, 100).Select(i => i).ToArray();
    var arrays = Split(arr, 20);
    //var arraysSum = new int[arrays.Count()];

    //int sumIndex = 0;
    List<Task<int>> tasks = new();

    foreach (var splitArray in arrays)
    {
        var sumTask = Task.Run(() => splitArray.Sum());
        tasks.Add(sumTask);

        //arraysSum[sumIndex] = sumTask.Result;
        //sumIndex++;
    }

    var res = Task.WhenAll(tasks).Result;

    Console.WriteLine($"Final sum is {res.Sum()}");
}

IEnumerable<IEnumerable<int>> Split(int[] self, int chunkSize)
{
    var splitList = new List<List<int>>();
    var chunkCount = (int)Math.Ceiling(self.Length / (double)chunkSize);

    for (int c = 0; c < chunkCount; c++)
    {
        var skip = c * chunkSize;
        var take = skip + chunkSize;
        var chunk = new List<int>(chunkSize);

        for (int e = skip; e < take && e < self.Length; e++)
        {
            chunk.Add(self.ElementAt(e));
        }

        splitList.Add(chunk);
    }

    return splitList;
}


