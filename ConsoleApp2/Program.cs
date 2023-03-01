// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

for (int i = 0; i < 1000; i++)
{
    Console.WriteLine($"#:{i + 1}");
    ThreadPool.QueueUserWorkItem(MyMethod);
    Thread.Sleep(10000);
}

void MyMethod(object? obj)
{
    Thread thread = new Thread(() =>
    {
        thread = Thread.CurrentThread;
    });

    thread.IsBackground = true;
    thread.Start();
    Console.WriteLine($"ThreadID:{thread.ManagedThreadId}\nAmount of threds in the Pool:{ThreadPool.ThreadCount}\nThredIsBackground?:{thread.IsBackground}");
}