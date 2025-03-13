using System;
using System.Security.Cryptography.X509Certificates;

namespace assignment4_2
{
    public class Puber
    {
        long InTime = 0;
        long ClockTime = -1;
        public delegate void MsgHandler(object sender, string msg);
        public event MsgHandler Tick;
        public event MsgHandler Tock;
        public event MsgHandler Alarm;
        public void SetClock(long t)
        {
            ClockTime = t;
        }
        //检查是否有订阅者
        public void ClockGo()
        {
            if (InTime == ClockTime)
            {
                Alarm?.Invoke(this, "The clock is ringing");
            }else if(InTime == 0)
            {
                ;
            }
            else if (InTime % 2 == 1)
            {
                Tick?.Invoke(this, "Tick");
            }
            else
            {
                Tock?.Invoke(this, "Tock");
            }
            InTime++;
        }
    }
    public class Suber
    {
        public void HandleMsg(object sender,string msg)
        {
            Console.WriteLine(msg);
        }
    }


    public class assignment4_2
    {
        static void RunLoop(Puber clock,CancellationToken token)
        {
            long MaxLoop = 0;
            try
            {
                while (!token.IsCancellationRequested && MaxLoop < long.MaxValue)
                {
                    clock.ClockGo();
                    MaxLoop++;
                    Task.Delay(1000, token).Wait(token);
                }
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Detect escape key");
            }
        }
        public static void Main(string[] args)
        {
            Puber clock = new Puber();
            Suber Sender = new Suber();
            //注册
            clock.Tick += Sender.HandleMsg;
            clock.Tock += Sender.HandleMsg;
            clock.Alarm += Sender.HandleMsg;
            Console.WriteLine("Set a clock time:(h:m:s)");
            //闹钟解析
            string[] ClockTime = Console.ReadLine().Split(new char[] {':','：'});
            int h = 0, m = 0, s = 0;
            if (!(int.TryParse(ClockTime[0], out h) && int.TryParse(ClockTime[1], out m) && int.TryParse(ClockTime[2], out s)))
            {
                Console.WriteLine("ERROR:Invalid Input!");
                return;
            }
            else
            {
                clock.SetClock(h * 3600 + m * 60 + s);
            }
            // 创建取消令牌源，用于发送退出信号
            var cts = new CancellationTokenSource();
            Console.WriteLine("Press esc to escape...");
            var task = Task.Run(() => RunLoop(clock,cts.Token));

            // 监听 ESC 键
            while (!task.IsCompleted)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    cts.Cancel(); // 触发取消
                    break;
                }
                Thread.Sleep(100); // 降低 CPU 占用
            }

            try { task.Wait(); } // 等待任务结束
            catch (AggregateException) { /* 忽略取消异常 */ }
            
            Console.WriteLine("Program end");
        }
    }
}
