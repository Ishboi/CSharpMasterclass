using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Diagnostics;

namespace WPFTaskE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static readonly DependencyProperty HtmlProperty = DependencyProperty.RegisterAttached(
            "Html",
            typeof(string),
            typeof(MainWindow),
            new FrameworkPropertyMetadata(OnHtmlChanged));

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            { 
                Debug.WriteLine($"Thread Nr {Thread.CurrentThread.ManagedThreadId}");
                HttpClient webClient = new HttpClient();
                webClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/xhtml+xml,application/xml");
                webClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate");
                webClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:19.0) Gecko/20100101 Firefox/19.0");
                webClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Charset", "ISO-8859-1");

                //header manipulation solution according to answer by saman shariat
                // https://www.udemy.com/course/complete-csharp-masterclass/learn/lecture/10736712#questions/7362414
                string html = webClient.GetStringAsync("http://ipv4.download.thinkbroadband.com/20MB.zip").Result;

                MyButton.Dispatcher.Invoke(() =>
                {
                    Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId} owns MyButton");
                    MyButton.Content = "Done";
                });

            });

        }

        private async void MyButton_Click2(object sender, RoutedEventArgs e)
        {
            string myHtml = "Bla";

            Debug.WriteLine($"Thread Nr {Thread.CurrentThread.ManagedThreadId} before await task");
            await Task.Run(async() =>
            {
                Debug.WriteLine($"Thread Nr {Thread.CurrentThread.ManagedThreadId} during await task");
                HttpClient webClient = new HttpClient();
                //webClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/xhtml+xml,application/xml");
                //webClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate");
                //webClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:19.0) Gecko/20100101 Firefox/19.0");
                //webClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Charset", "ISO-8859-1");

                //header manipulation solution according to answer by saman shariat in 4 lines above, it's needed for downloads
                // https://www.udemy.com/course/complete-csharp-masterclass/learn/lecture/10736712#questions/7362414
                //this below was to download a file
                //string html = webClient.GetStringAsync("http://ipv4.download.thinkbroadband.com/20MB.zip").Result;
                string html = webClient.GetStringAsync("https://google.com").Result;
                myHtml = html;
            });

            Debug.WriteLine($"Thread Nr {Thread.CurrentThread.ManagedThreadId} after wait task");

            MyButton.Content = "Done Downloading";
            MyWebBrowser.SetValue(HtmlProperty, myHtml);
        }

        static void OnHtmlChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            WebBrowser webBrowser = dependencyObject as WebBrowser;
            if (webBrowser != null)
                webBrowser.NavigateToString(e.NewValue as string);
        }
    }
}
