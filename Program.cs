
class Program
{
    static async Task Main()
    {
        int threadCount = 4;
        TaskManager taskManager = new TaskManager(threadCount);
        await taskManager.RunTasksAsync();
        Console.WriteLine("All tasks are completed.");
    }
}