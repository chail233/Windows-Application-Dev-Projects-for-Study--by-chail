using System.Timers;

namespace Timer
{
    public partial class TimerForm : Form
    {
        public int timerd = 0;
        private int status = 0;
        private int dh = 0, dm = 0, ds = 0;
        public TimerForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCutDown.Checked == false) timerd++;
            else timerd--;
            int current_time = timerd;
            int current_hour = current_time / 216000;
            current_time %= 216000;
            int current_minute = current_time / 3600;
            current_time = current_time % 3600;
            int current_second = current_time / 60;
            int current_msecond = current_time % 60;
            string string_hour, string_minute, string_second, string_msecond;
            string_hour = current_hour.ToString();
            string_minute = current_minute.ToString();
            string_second = current_second.ToString();
            string_msecond = current_msecond.ToString();
            if (current_hour < 10) string_hour = "0" + string_hour;
            if (current_minute < 10) string_minute = "0" + string_minute;
            if (current_second < 10) string_second = "0" + string_second;
            if (current_msecond < 10) string_msecond = "0" + string_msecond;
            hour.Text = string_hour;
            minute.Text = string_minute;
            second.Text = string_second;
            msecond.Text = string_msecond;
            if (timerd <= 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                MessageBox.Show("倒计时结束！");
                start.Enabled = true;
                pause.Enabled = false;
                stop.Enabled = false;
                houradd.Enabled = true;
                minuteadd.Enabled = true;
                secondadd.Enabled = true;
                secondminus.Enabled = true;
                minuteminus.Enabled = true;
                hourminus.Enabled = true;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (isCutDown.Checked == true)
            {
                timerd += dh * 216000;
                timerd += dm * 3600;
                timerd += ds * 60;
                dh = 0;
                dm = 0;
                ds = 0;
            }
            status = 0;
            timer1.Enabled = true;
            timer2.Enabled = true;
            pause.Enabled = true;
            stop.Enabled = true;
            start.Enabled = false;
            houradd.Enabled = false;
            minuteadd.Enabled = false;
            secondadd.Enabled = false;
            secondminus.Enabled = false;
            minuteminus.Enabled = false;
            hourminus.Enabled = false;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timerd = 0;
            timer1.Enabled = false;
            timer2.Enabled = false;
            stop.Enabled = false;
            pause.Enabled = false;
            start.Enabled = true;
            houradd.Enabled = true;
            minuteadd.Enabled = true;
            secondadd.Enabled = true;
            secondminus.Enabled = true;
            minuteminus.Enabled = true;
            hourminus.Enabled = true;
        }

        private void pause_Click(object sender, EventArgs e)
        {

            if (status == 0)
            {
                status = 1;
                timer1.Enabled = false;
                timer2.Enabled = false;
                pause.Text = "继续";
                stop.Enabled = false;
            }
            else
            {
                status = 0;
                timer1.Enabled = true;
                timer2.Enabled = true;
                pause.Text = "暂停";
                stop.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (colon1.Visible) colon1.Visible = false;
            else colon1.Visible = true;
            if (colon2.Visible) colon2.Visible = false;
            else colon2.Visible = true;
            if (colon3.Visible) colon3.Visible = false;
            else colon3.Visible = true;
        }

        private void houradd_Click(object sender, EventArgs e)
        {
            if (dh >= 60) return;
            dh++;
            hour.Text = dh.ToString("D2");
        }

        private void hourminus_Click(object sender, EventArgs e)
        {
            if (dh <= 0) return;
            dh--;
            hour.Text = dh.ToString("D2");
        }

        private void minuteadd_Click(object sender, EventArgs e)
        {
            if (dm >= 60) return;
            dm++;
            minute.Text = dm.ToString("D2");
        }

        private void minuteminus_Click(object sender, EventArgs e)
        {
            if (dm <= 0) return;
            dm--;
            minute.Text = dm.ToString("D2");
        }

        private void secondadd_Click(object sender, EventArgs e)
        {
            if (ds >= 60) return;
            ds++;
            second.Text = ds.ToString("D2");
        }

        private void secondminus_Click(object sender, EventArgs e)
        {
            if (ds <= 0) return;
            ds--;
            second.Text = ds.ToString("D2");
        }

        private void reset_Click(object sender, EventArgs e)
        {
            int current_time = timerd;
            int current_hour = current_time / 216000;
            current_time %= 216000;
            int current_minute = current_time / 3600;
            current_time = current_time % 3600;
            int current_second = current_time / 60;
            int current_msecond = current_time % 60;
            string string_hour, string_minute, string_second, string_msecond;
            string_hour = current_hour.ToString();
            string_minute = current_minute.ToString();
            string_second = current_second.ToString();
            string_msecond = current_msecond.ToString();
            if (current_hour < 10) string_hour = "0" + string_hour;
            if (current_minute < 10) string_minute = "0" + string_minute;
            if (current_second < 10) string_second = "0" + string_second;
            if (current_msecond < 10) string_msecond = "0" + string_msecond;
            hour.Text = string_hour;
            minute.Text = string_minute;
            second.Text = string_second;
            msecond.Text = string_msecond;
        }
    }
}
