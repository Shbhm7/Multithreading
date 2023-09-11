class Worker
{
    public static async Task DoWorkAsync(int threadId)
    {
        Console.WriteLine($"Thread {threadId} is starting.");
        await Task.Delay(1000);
        Console.WriteLine($"Thread {threadId} is done.");
    }
}