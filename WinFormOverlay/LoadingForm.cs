using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormOverlay
{
    public partial class LoadingForm : Form
    {
        public static LoadingForm Current { get; set; } = null;

        public LoadingForm(Form _Parent)
        {
            
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Owner = _Parent;
            //Opacity = 0.8;
            BackColor = Color.Transparent;
            TransparencyKey = Color.Transparent;
            //BackColor = Color.FromArgb(25, Color.Black);

            _Parent.LocationChanged += (_Sender, _Event) =>
            {
                BringToFront();
                if (Owner != null)
                {
                    Rectangle _Rectangle = Owner.RectangleToScreen(Owner.ClientRectangle);
                    int _Height = _Rectangle.Top - Owner.Top;

                    Width = Owner.Width - 16;
                    Height = Owner.Height - _Height - 7;

                    Left = Owner.Left + 8;
                    Top = Owner.Top + _Height;
                }
            };
        }

        protected override void OnShown(EventArgs e)
        {
            if(Owner != null)
            {
                Rectangle _Rectangle = Owner.RectangleToScreen(Owner.ClientRectangle);
                int _Height = _Rectangle.Top - Owner.Top;

                Width = Owner.Width - 16;
                Height = Owner.Height - _Height - 7;
               
                Left = Owner.Left + 8;
                Top = Owner.Top + _Height;
            }
            base.OnShown(e);
        }

        public static void Start(Form _Parent)
        {
            Current = new LoadingForm(_Parent);
            Current.Show(_Parent);
        }

        public static void Stop()
        {
            Current?.Close();
            Current = null;
        }
    }
}
