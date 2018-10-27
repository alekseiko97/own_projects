using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyTimer
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer taskTimer = new System.Timers.Timer();
        private Timer countdownTimer = new Timer();
        private decimal totalSeconds;
        private List<string> processes;

        public Form1()
        {
            InitializeComponent();
            processes = Process.GetProcesses().Select(x => x.ProcessName).Distinct().OrderBy(x => x).ToList();

            taskTimer.Elapsed += Timer_Tick;
            taskTimer.AutoReset = false; // raise the event only once

            countdownTimer.Interval = 1000; // 1 sec
            countdownTimer.Tick += CountdownTimer_Tick;

            string filterParameter = processName_tb.Text;
            List<string> filteredItems = processes.FindAll(x => x.Contains(filterParameter));

            comboBox1.DataSource = filteredItems;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DisplayMember = "ProcessName";
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan t = TimeSpan.FromSeconds(Convert.ToDouble(totalSeconds));
            time_lbl.Text = t.ToString(@"hh\:mm\:ss");
            totalSeconds--;

            if (totalSeconds == -1)
            {
                countdownTimer.Stop();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (InvokeRequired)
                Invoke(new MethodInvoker(delegate
                {
                    Console.WriteLine(comboBox1.SelectedText);
                    var processes = Process.GetProcesses().Where(pr => pr.ProcessName == comboBox1.Text).ToList();
                    if (processes.Count != 0)
                        foreach (var p in processes)
                        {
                            try
                            {
                                p.Kill();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            if (shutdown_cb.Checked)
                            {
                                Process.Start("shutdown", "/s /t 0");
                            }

                        }
                    else
                    {
                        MessageBox.Show("Nothing to kill!");
                    }
                }));
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var hours = hours_nud.Value;
                var minutes = minutes_nud.Value;
                var seconds = seconds_nud.Value;
                this.totalSeconds = (hours * 3600) + (minutes * 60) + seconds;
                var milliseconds = TimeSpan.FromSeconds(Convert.ToDouble(totalSeconds)).TotalMilliseconds;
                taskTimer.Interval = Convert.ToInt32(milliseconds);
                countdownTimer.Start();
                taskTimer.Start();
            } catch (ArgumentException)
            {
                MessageBox.Show("Please enter a valid value for time!");
            }
            
        }

        private void processName_tb_TextChanged(object sender, EventArgs e)
        {
            string filterParameter = processName_tb.Text;
            List<string> filteredItems = processes.FindAll(x => x.Contains(filterParameter));

            if (String.IsNullOrWhiteSpace(filterParameter))
            {
                comboBox1.DataSource = processes;
            } else
            {
                comboBox1.DataSource = filteredItems;
            }
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            string filterParameter = comboBox1.Text;
           
            List<string> filteredItems = processes.FindAll(x => x.Contains(filterParameter));

            comboBox1.DataSource = filteredItems;

            if (String.IsNullOrWhiteSpace(filterParameter))
            {
                comboBox1.DataSource = processes;
            }

            comboBox1.IntegralHeight = true;

            comboBox1.SelectedIndex = -1;
            comboBox1.Text = filterParameter;

            comboBox1.DroppedDown = true;
            Cursor.Current = Cursors.Default;
        }
    }
}
