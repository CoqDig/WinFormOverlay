using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormOverlay
{
    public partial class LoadingForm : Form
    {
        public static LoadingForm Current { get; set; } = null;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        private const int WM_NCHITTEST = 0x0084;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;

        public LoadingForm(Form _Parent)
        {
            InitializeComponent();
            //Opacity = 0.75;
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Text = string.Empty;
            Owner = _Parent;

            _Parent.LocationChanged += (_Sender, _Event) =>
            {
                BringToFront();
                Left = _Parent.Left + (_Parent.Width - Width) / 2;
                Top = _Parent.Top + (_Parent.Height - Height) / 2;
                //if (Owner != null)
                //{
                //    Rectangle _Rectangle = Owner.RectangleToScreen(Owner.ClientRectangle);
                //    int _Height = _Rectangle.Top - Owner.Top;

                //    Width = Owner.Width;
                //    Height = Owner.Height - _Height;

                //    Left = Owner.Left;
                //    Top = Owner.Top + _Height;
                //}
            };
        }

        //protected override void WndProc(ref Message m)
        //{
        //    base.WndProc(ref m);
        //    switch (m.Msg)
        //    {
        //        case WM_NCHITTEST:
        //            if (m.Result == (IntPtr)HTCLIENT)
        //            {
        //                m.Result = (IntPtr)HTCAPTION;
        //            }
        //            break;
        //    }
        //}
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.Style |= 0x40000;
        //        return cp;
        //    }
        //}

        //protected override void WndProc(ref Message message)
        //{
        //    base.WndProc(ref message);

        //    if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT) message.Result = (IntPtr)HTCAPTION;
        //}

        protected override void OnShown(EventArgs e)
        {
            //if(Owner != null)
            //{
            //    Rectangle _Rectangle = Owner.RectangleToScreen(Owner.ClientRectangle);
            //    int _Height = _Rectangle.Top - Owner.Top;

            //    Width = Owner.Width;
            //    Height = Owner.Height - _Height;

            //    Left = Owner.Left;
            //    Top = Owner.Top + _Height;
            //}
            if(Owner != null)
            {
                Left = Owner.Left + (Owner.Width - Width) / 2;
                Top = Owner.Top + (Owner.Height - Height) / 2;
            }
            base.OnShown(e);
        }

        public void SetParent(Form _Parent)
        {
            //Rectangle _Rectangle = _Parent.RectangleToScreen(_Parent.ClientRectangle);
            //int _Height = _Rectangle.Top - _Parent.Top;
            //Width = _Parent.Width;
            //Height = _Parent.Height - _Height;

            _Parent.LocationChanged += (sender, e) =>
            {
                BringToFront();
                Form Win = sender as Form;
                Left = Win.Left + (Win.Width - Width) / 2;
                Top = Win.Top + (Win.Height - Height) / 2;
            };

            _Parent.MouseClick += (_Sender, _Event) =>
            {
                 BringToFront();
            };

            _Parent.MouseUp += (_Sender, _Event) =>
            {
                BringToFront();
            };

            _Parent.MouseDown += (_Sender, _Event) =>
            {
                BringToFront();
            };

            _Parent.MouseCaptureChanged += (_Sender, _Event) =>
            {
                BringToFront();
            };

            _Parent.ResizeEnd += (_Sender, _Event) =>
            {
                BringToFront();
            }; 
        }

        public static void Start(Form _Parent)
        {
            Current = new LoadingForm(_Parent);
            //Current.SetParent(_Parent);
            Current.Show();
        }

        public static void Stop()
        {
            Current?.Close();
            Current = null;
        }
    }
}
