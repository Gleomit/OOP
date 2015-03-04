namespace AsynchronousTimer
{
    using System;

    public class AsyncTimer
    {
        private Action theAction;
        private int ticks;
        private double t;
        private System.Timers.Timer timer;

        public AsyncTimer(Action action, int ticks, double t)
        {
            this.theAction = action;
            this.ticks = ticks;
            this.t = t;

            this.timer = new System.Timers.Timer(this.t);
            timer.Start();
            timer.Elapsed += timer_Elapsed;
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.theAction();
            this.ticks--;
            if (this.ticks <= 0)
            {
                this.timer.Stop();
                this.timer.Elapsed -= timer_Elapsed;
                Console.WriteLine("\n-----End-----");
            }
        }
    }
}
