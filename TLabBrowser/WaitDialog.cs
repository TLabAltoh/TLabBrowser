using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TLabBrowser
{
    public partial class WaitDialog : Form
    {
        // ダウンロードするファイルの名前
        private string file_name;
        // 現在までに受け取ったファイルのバイト数
        public int recieved_bytes = 0;
        // ダウンロードするファイルのサイズ(バイト)
        public int max_bytes = 0;

        public WaitDialog(string file_name, int max_bytes)
        {
            InitializeComponent();
            this.file_name = file_name;
            this.max_bytes = max_bytes;
        }

        // プログレスバーの値を更新
        private void update_progress_bar()
        {
            while (max_bytes - recieved_bytes == 0)
            {
                progressBar1.Value = recieved_bytes;
                progressBar1.Maximum = max_bytes;
            }
        }

        private void WaitDialog_Load(object sender, EventArgs e)
        {
            label1.Text = file_name + " をダウンロード中";
            Task.Factory.StartNew(update_progress_bar).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
