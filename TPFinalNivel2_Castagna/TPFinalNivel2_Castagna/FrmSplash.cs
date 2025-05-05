using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoGestion2025
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
            ConfigureForm();
            AddGradientBackground();
            AddMessageLabel();
            AddLogo();
            AddLoadingIndicator();
            StartCloseTimer();
        }

        private void ConfigureForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.Size = new Size(600, 400);
            this.DoubleBuffered = true;
        }

        private void AddGradientBackground()
        {
            this.Paint += (sender, e) =>
            {
                using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    this.ClientRectangle,
                    Color.FromArgb(70, 130, 180), // SteelBlue
                    Color.FromArgb(176, 226, 255), // LightBlue
                    45f))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            };
        }

        private void AddMessageLabel()
        {
            Label lblMensaje = new Label();
            lblMensaje.Text = "Gracias a MaxiPrograma por la oportunidad de desarrollar esta aplicación.\n\n¡Me divertí mucho en el desarrollo! 😊";
            lblMensaje.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblMensaje.ForeColor = Color.White;
            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.AutoSize = false;
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            lblMensaje.Dock = DockStyle.Fill;
            lblMensaje.Padding = new Padding(20);

            this.Controls.Add(lblMensaje);
        }

        private void AddLogo()
        {
            PictureBox logo = new PictureBox();
            logo.Size = new Size(100, 100);
            logo.Location = new Point((this.Width - 100) / 2, 30);
            logo.BackColor = Color.Transparent;

            // Logo placeholder (reemplazar con tu imagen)
            logo.Paint += (sender, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillEllipse(Brushes.White, 0, 0, logo.Width, logo.Height);
                using (var font = new Font("Segoe UI", 16, FontStyle.Bold))
                {
                    e.Graphics.DrawString("MP", font, Brushes.SteelBlue,
                        new RectangleF(0, 0, logo.Width, logo.Height),
                        new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                }
            };

            this.Controls.Add(logo);
            logo.BringToFront();
        }

        private void AddLoadingIndicator()
        {
            ProgressBar progress = new ProgressBar();
            progress.Style = ProgressBarStyle.Marquee;
            progress.MarqueeAnimationSpeed = 30;
            progress.Size = new Size(300, 10);
            progress.Location = new Point((this.Width - 300) / 2, this.Height - 50);
            progress.ForeColor = Color.SteelBlue;
            progress.BackColor = Color.White;

            this.Controls.Add(progress);
        }

        private void StartCloseTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 250; 
            timer.Tick += (s, e) => { this.Close(); };
            timer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Borde redondeado
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radius = 20;
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);
            }

            // Borde sutil
            using (var pen = new Pen(Color.FromArgb(100, Color.White), 2))
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(1, 1, this.Width - 3, this.Height - 3));
            }
        }
    }
}