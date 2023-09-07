using System;
using CefSharp;

namespace TLabBrowser.Handler
{
    class Download : IDownloadHandler
    {
        private WaitDialog m_dialog;
        private bool m_downloading = false;

        public Download()
        {
        }

        void IDownloadHandler.OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            // 1 : ファイル保存先のパス(未指定の場合、cefsharpが自動的に設定する)
            // 2 : 保存ダイアログを表示するか(trueの場合、cefsharpが推奨した保存先をダイアログで変更することが出来る)
            callback.Continue("", true);

            // ウェイトダイアログを表示
            m_dialog = new WaitDialog(downloadItem.SuggestedFileName, (int)downloadItem.TotalBytes);
            m_dialog.Show();

            m_downloading = true;
        }

        void IDownloadHandler.OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            // ダウンロードの進行状況を更新
            if (m_downloading)
            {
                Console.WriteLine(downloadItem.ReceivedBytes.ToString() + ", " + downloadItem.TotalBytes.ToString());
                m_dialog.recieved_bytes = (int)downloadItem.ReceivedBytes;
            }

            // ダウンロードが完了していたら、ダウンロード中のフラグを falseにする
            if (downloadItem.TotalBytes - downloadItem.ReceivedBytes == 0)
            {
                m_downloading = false;
                Console.WriteLine("processed.");
            }
        }
    }
}
