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

        public LoadingForm(Form _Parent)
        {
            InitializeComponent();
            Owner = _Parent;
        }

        protected override void OnShown(EventArgs e)
        {
            if(Owner != null)
            {
                Rectangle _Rectangle = Owner.RectangleToScreen(Owner.ClientRectangle);
                int _Height = _Rectangle.Top - Owner.Top;

                Width = Owner.Width;
                Height = Owner.Height - _Height;

                Left = Owner.Left;
                Top = Owner.Top + _Height;
                //Left = Owner.Left + (Owner.Width - Width) / 2;
                //Top = Owner.Top + (Owner.Height - Height) / 2;
            }
            base.OnShown(e);
        }

        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    SetForegroundWindow(Handle);
        //}

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
