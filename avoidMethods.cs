class avoidMethods{
    public static async Task<int> RunTaskAsync(){
        return await Task.Run(() => {
            Task.Delay(1000).Wait();
            return 42;
        });
    }

    public static void RunTask(){
        Task.Run(MyTask);
    }

    public static async Task MyTask()
    {
        await Task.Delay(1000);
        Console.WriteLine("Task Completed");
    }
    

    public static async Task<string> ConfigureAwaitExampleAsync()
    {
        await Task.Delay(1000).ConfigureAwait(false);
        return "Completed";
    }

    public static string GetResult()
    {
        Task<int> task = Task.Run(() => 42);
        return task.Result.ToString();
    }
}