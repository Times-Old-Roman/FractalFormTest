using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalFormTest
{
    public partial class Form1 : Form
    {
        delegate void fracFunc();
        private Bitmap bmp;
        private static Mutex mut = new Mutex();
        public Bitmap Bmp
        {
            get { return bmp; }
            set { bmp = value; }
        }
		static Random rnd = new Random();
		private int dragonIter = 0;
		private string minkowskyString = "F";
		private string hilbertString = "A";
		List<int> dragonAngles = new List<int>();
		private double minkowskyAngle, hilbertAngle;
		private int minkowskyLength, hilbertLength;
		Point dragonStart, minkowskyStart, hilbertStart;
        Thread fracThread = null;
        public Form1()
		{
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
		}

        private void fracChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
			drawBtn.Enabled = true;
        }
        private void drawDragon()
        {
            mut.WaitOne();
            Color c = Color.Black;
            if (InvokeRequired)
                this.Invoke((MethodInvoker)(() => 
                { 
                    c = Color.FromArgb(fracR.Value, fracG.Value, fracB.Value); 
                }
                ));
            else c = Color.FromArgb(fracR.Value, fracG.Value, fracB.Value);
            Pen line = new Pen(c, 2);
            Graphics g = Graphics.FromImage(bmp);
            int count = dragonAngles.Count();
            if (dragonIter == 0)
            {
                g.DrawLine(line, dragonStart, new Point(dragonStart.X, dragonStart.Y - 1));
                dragonStart.X += 1;
                dragonAngles.Add(90);
                dragonIter = 1;
                if (InvokeRequired)
                    this.Invoke((MethodInvoker)(() =>
                    {
                        Refresh();
                    }
                    ));
                else Refresh();
                return;
            }
            for (int i = 0; i < dragonIter; i++)
            {
                switch (dragonAngles[count - 1 - i])
                {
                    case 270:
                        g.DrawLine(line, dragonStart, new Point(dragonStart.X + 1, dragonStart.Y));
                        dragonStart.X += 1;
                        break;
                    case 0:
                        g.DrawLine(line, dragonStart, new Point(dragonStart.X, dragonStart.Y - 1));
                        dragonStart.Y -= 1;
                        break;
                    case 90:
                        g.DrawLine(line, dragonStart, new Point(dragonStart.X - 1, dragonStart.Y));
                        dragonStart.X -= 1;
                        break;
                    case 180:
                        g.DrawLine(line, dragonStart, new Point(dragonStart.X, dragonStart.Y + 1));
                        dragonStart.Y += 1;
                        break;
                }
                dragonAngles.Add((dragonAngles[count - 1 - i] + 90) % 360);
            }
            dragonIter *= 2;
            if (InvokeRequired)
                this.Invoke((MethodInvoker)(() =>
                {
                    Refresh();
                }
                ));
            else Refresh();
            mut.ReleaseMutex();
        }
		private void LSysMinkowsky()
		{
			minkowskyString = "F";
			for(int i = 0; i < Convert.ToInt32(iterAmount.Text); i++)
			{
				if (minkowskyString.Contains("F"))
					minkowskyString = minkowskyString.Replace("F", "F-F+F+FF-F-F+F");
			}
		}
		private void LSysHilbert()
		{
			hilbertString = "A";
			for (int i = 0; i < Convert.ToInt32(iterAmount.Text); i++)
			{
				string buf = "";
				foreach (char ch in hilbertString)
				{
					if (ch == 'A')
						buf += "-BF+AFA+FB-";
					else if (ch == 'B')
						buf += "+AF-BFB-FA+";
					else buf += ch;
				}
				hilbertString = buf;
			}
		}
		private void drawMinkowsky()
		{
			mut.WaitOne();
			Color c = Color.Black;
			if (InvokeRequired)
				this.Invoke((MethodInvoker)(() =>
				{
					c = Color.FromArgb(fracR.Value, fracG.Value, fracB.Value);
				}
				));
			else c = Color.FromArgb(fracR.Value, fracG.Value, fracB.Value);
			Pen line = new Pen(c, 2);
			Graphics g = Graphics.FromImage(bmp);
			LSysMinkowsky();
			for (int i = 0; i < minkowskyString.Length; i++)
			{
				switch (minkowskyString[i])
				{
					case '+':
						minkowskyAngle = (minkowskyAngle + Math.PI /2) % (2 * Math.PI);
						break;
					case '-':
						minkowskyAngle = (minkowskyAngle - Math.PI / 2) % (2 * Math.PI);
						break;
					case 'F':
						Point newStart = new Point(minkowskyStart.X +
							minkowskyLength * (int)Math.Cos(minkowskyAngle),
							minkowskyStart.Y + minkowskyLength * (int)Math.Sin(minkowskyAngle));
						g.DrawLine(line, new Point(minkowskyStart.X, minkowskyStart.Y), newStart);
						minkowskyStart = newStart;
						if (Convert.ToInt32(iterAmount.Text) <= 3)
						{
							if (InvokeRequired)
								this.Invoke((MethodInvoker)(() =>
								{
									Refresh();
								}
								));
							else Refresh();
						}
						Thread.Sleep(Convert.ToInt32(iterSleep.Text));
						break;
				}
			}
			minkowskyStart = new Point(10, (this.Height - 30) / 2);
			if (InvokeRequired)
				this.Invoke((MethodInvoker)(() =>
				{
					Refresh();
				}
				));
			else Refresh();
			MessageBox.Show("Рисовка закончена!");
			mut.ReleaseMutex();
		}
		private void drawHilbert()
		{
			mut.WaitOne();
			Color c = Color.Black;
			if (InvokeRequired)
				this.Invoke((MethodInvoker)(() =>
				{
					c = Color.FromArgb(fracR.Value, fracG.Value, fracB.Value);
				}
				));
			else c = Color.FromArgb(fracR.Value, fracG.Value, fracB.Value);
			Pen line = new Pen(c, 2);
			Graphics g = Graphics.FromImage(bmp);
			LSysHilbert();
			for (int i = 0; i < hilbertString.Length; i++)
			{
				switch (hilbertString[i])
				{
					case '+':
						hilbertAngle = (hilbertAngle + Math.PI / 2) % (2 * Math.PI);
						break;
					case '-':
						hilbertAngle = (hilbertAngle - Math.PI / 2) % (2 * Math.PI);
						break;
					case 'F':
						Point newStart = new Point(hilbertStart.X +
							hilbertLength * (int)Math.Cos(hilbertAngle),
							hilbertStart.Y + hilbertLength * (int)Math.Sin(hilbertAngle));
						g.DrawLine(line, new Point(hilbertStart.X, hilbertStart.Y), newStart);
						hilbertStart = newStart;
						if (Convert.ToInt32(iterAmount.Text) < 6)
						{
							if (InvokeRequired)
								this.Invoke((MethodInvoker)(() =>
								{
									Refresh();
								}
								));
							else Refresh();
						}
						Thread.Sleep(Convert.ToInt32(iterSleep.Text));
						break;
				}
			}
			hilbertStart = new Point((bmp.Width + 10) / 3, 2 * (bmp.Height + 100) / 3);
			if (InvokeRequired)
				this.Invoke((MethodInvoker)(() =>
				{
					Refresh();
				}
				));
			else Refresh();
			MessageBox.Show("Рисовка закончена!");
			mut.ReleaseMutex();
		}
		private void drawBtn_Click(object sender, EventArgs e)
        {
			if (iterAmount.Text == "")
				iterAmount.Text = "2";
			if (iterSleep.Text == "")
				iterSleep.Text = "0";
			refreshBtn.Enabled = false;
            fracThread = new Thread(new ParameterizedThreadStart(chooseFractal));
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.FromArgb(backR.Value, backG.Value, backB.Value));
            fracThread.Start(fracChoice.SelectedIndex);
        }

        private async void chooseFractal(object index)
		{
			int fracNum = Convert.ToInt32(index);
			int iterN = Convert.ToInt32(iterAmount.Text);
			int iterS = Convert.ToInt32(iterSleep.Text);
			fracFunc fractalCall = null;
			try
			{
				switch (Convert.ToInt32(index))
				{
					case 0:
						fractalCall = drawDragon;
						break;
					case 1:
						minkowskyLength = 1;
						await Task.Run(() => drawMinkowsky());
						break;
					case 2:
						hilbertLength = 2 * (bmp.Height - 100) / (int)(3 * Math.Pow(2, iterN));
						hilbertLength += hilbertLength == 0 ? 1 : 0;
						await Task.Run(() => drawHilbert());
						break;
					default:
						MessageBox.Show("Не был выбран фрактал!");
						return;
				}
				if (fractalCall != null)
				{
					try
					{
						await Task.Run(() => iterate(fractalCall, iterN, iterS));
					}
					catch (TaskCanceledException ex)
					{
						MessageBox.Show("Рисовка закончена!");
					}
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("Были неправельно введены либо количество итераций,\n" +
					"либо пауза между итерациями. Требуются целые, положительные числа!");
			}
			if (InvokeRequired)
				this.Invoke((MethodInvoker)(() =>
				{
					refreshBtn.Enabled = true;
					saveBtn.Enabled = true;
				}
				));
			else
			{
				refreshBtn.Enabled = true;
				saveBtn.Enabled = true;
			}
		}

		private Task iterate(fracFunc fractalCall, int iterNum, int iterSleepTime)
        {
            for (int i = 0; i < iterNum; i++)
            {
                if (Thread.CurrentThread.IsAlive == true)
                {
                    fractalCall.Invoke();
                    Thread.Sleep(iterSleepTime);
                }
                else break;
            }
            dragonAngles = new List<int>();
            dragonStart = new Point(this.Width / 2 - fracOptions.Width / 2,
            this.Height / 2);
            dragonIter = 0;
            return null;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
			saveBtn.Enabled = false;
			g.Clear(Color.White);
            Refresh();
            g.Dispose();
        }

        private void fracRGB_ValueChanged(object sender, EventArgs e)
        {
            fracRLabel.Text = fracR.Value.ToString();
            fracGLabel.Text = fracG.Value.ToString();
            fracBLabel.Text = fracB.Value.ToString();
        }

        private void backRGB_ValueChanged(object sender, EventArgs e)
        {
            backRLabel.Text = backR.Value.ToString();
            backGLabel.Text = backG.Value.ToString();
            backBLabel.Text = backB.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.refreshBtn.Location = new Point(fracOptions.Left, fracOptions.Bottom - 100);
            this.drawBtn.Location = new Point(refreshBtn.Left, fracOptions.Bottom - refreshBtn.Height - 100);
            this.bmp = new Bitmap(this.Width - fracOptions.Width, this.Height);
            backR.Value = 255;
            backG.Value = 255;
            backB.Value = 255;
            dragonStart = new Point(this.Width / 2 - fracOptions.Width / 2,
            this.Height / 2);
			minkowskyStart = new Point(10, (this.Height - 30) / 2);
			hilbertStart = new Point((bmp.Width + 10) / 3, 2 * (bmp.Height + 100) / 3);
			minkowskyAngle = hilbertAngle = 0;
			Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            g.Dispose();
        }

		private void saveBtn_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Bitmap Image|*.bmp";
			sfd.Title = "Сохраните фрактал в виде изображения .bmp";
			sfd.ShowDialog();
			if (sfd.FileName != "")
			{
				System.IO.FileStream fs =
					(System.IO.FileStream)sfd.OpenFile();
				this.bmp.Save(fs,System.Drawing.Imaging.ImageFormat.Bmp);
			}
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.DrawImage(bmp, fracOptions.Right, 0, bmp.Width, bmp.Height);
			g.Dispose();
		}
	}
}
