using System;

namespace AlarmClock
{
	public delegate void Tickhandler(object sender, TickEventArgs args);
	public delegate void Alarmhandler(object sender);
	public class TickEventArgs
	{
		public int Hour { get; set; }
		public int Minute { get; set; }
		public int Second { get; set; }

	}
	public class AlarmColok
	{
		private int hour;
		private int minute;
		private int second;

        public AlarmColok()
        {
        }

        public AlarmColok(int hour, int minute, int second)
		{
			this.hour = hour;
			this.minute = minute;
			this.second = second;
		}
		public event Tickhandler Tick;
		public event Alarmhandler Alarm;
		public void Ticking(int hour, int minute, int second)
		{
			Console.WriteLine($"闹钟开始滴答，目前时间是{hour}hour.{minute}minute.{second}second");
			TickEventArgs args = new TickEventArgs()
			{
				Hour = hour,
				Minute = minute,
				Second = second
			};
			Tick(this, args);
			Alarm(this);
		}
	}
	public class Form {
		public AlarmColok alarmClock = new AlarmColok();
		
		public Form() {
			
            alarmClock.Alarm += Alarm_On;
			alarmClock.Tick += Tick_On;

		}

        private void Tick_On(object sender, TickEventArgs args)
        {
            
			Console.WriteLine("持续滴答");
        }

        private void Alarm_On(object sender)
        {
            
			Console.WriteLine("发出闹铃");
        }
    }
	class Program
    {
		static void Main(String[] args) {
			Form form1 = new Form();
			form1.alarmClock.Ticking(4, 2, 30);
		}

    }
}
