using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using TLabBrowser.Handler;

namespace TLabBrowser
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser m_chromeBrowser;

        public Form1()
        {
            InitializeComponent();
            InitializeChromium();
        }

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();

            // CefSharp ２重に初期設定するとクラッシュするので、初期化チェックを忘れずにしておく
            if (Cef.IsInitialized == false)
            {
                // 受け入れる言語リストを指定する
                settings.AcceptLanguageList = "ja,en-US;q=0.9,en;q=0.8";
                Cef.Initialize(settings);
            }

            m_chromeBrowser = new ChromiumWebBrowser("https://google.com/")
            {
                Dock = DockStyle.Fill
            };

            m_chromeBrowser.DownloadHandler = new Download();
            m_chromeBrowser.AddressChanged += OnBrowserAddressChanged;

            this.BrowserPanel.Controls.Add(m_chromeBrowser);
        }

        private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => URLText.Text = args.Address);
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void BrowserPanel_Paint(object sender, PaintEventArgs e) { }

        private void GoBack_Click(object sender, EventArgs e)
        {
            if (m_chromeBrowser.CanGoBack)
                m_chromeBrowser.Back();
        }

        private void GoNext_Click(object sender, EventArgs e)
        {
            if (m_chromeBrowser.CanGoForward)
                m_chromeBrowser.Forward();
        }

        private void GoHome_Click(object sender, EventArgs e)
        {
            m_chromeBrowser.Load("https://google.com/");
        }

        private void URLText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !String.IsNullOrEmpty(URLText.Text))
            {
                if (URLText.Text.StartsWith("https://"))
                    m_chromeBrowser.Load(URLText.Text);
                else
                    m_chromeBrowser.Load("https://www.google.com/search?q=" + URLText.Text);
            }
        }
    }
}
