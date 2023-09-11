class TaskManager
{
    private int threadCount;
    public TaskManager(int threadCount)
    {
        this.threadCount = threadCount;
    }

    public async Task RunTasksAsync()
    {
        List<Task> tasks = new List<Task>();
        for (int i = 0; i < threadCount; i++)
        {
            int threadId=i;
            Task task = Task.Run(async () =>
            {
                await Worker.DoWorkAsync(threadId);
            });
            tasks.Add(task);
        }
        await Task.WhenAll(tasks);
    }
}