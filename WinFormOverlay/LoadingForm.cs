using System;
using System.Windows.Forms;

namespace WinFormOverlay
{
    public partial class LoadingForm : Form
    {
        public static LoadingForm Current { get; set; } = null;

        public LoadingForm(Form _Parent)
        {
            
            InitializeComponent();

            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Text = string.Empty;
            Owner = _Parent;

            Left = _Parent.Left + (_Parent.Width - Width) / 2;
            Top = _Parent.Top + (_Parent.Height - Height) / 2;

            _Parent.LocationChanged += (_Sender, _Event) =>
            {
                BringToFront();
                Left = _Parent.Left + (_Parent.Width - Width) / 2;
                Top = _Parent.Top + (_Parent.Height - Height) / 2;
            };
        }

        protected override void OnShown(EventArgs e)
        {
            if(Owner != null)
            {
                Left = Owner.Left + (Owner.Width - Width) / 2;
                Top = Owner.Top + (Owner.Height - Height) / 2;
            }
            base.OnShown(e);
        }

        public static void Start(Form _Parent)
        {
            Current = new LoadingForm(_Parent);
            Current.Show();
        }

        public static void Stop()
        {
            Current?.Close();
            Current = null;
        }
    }
}
