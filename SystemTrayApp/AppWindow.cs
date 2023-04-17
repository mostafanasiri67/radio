using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SystemTrayApp
{
    public partial class AppWindow : Form
    {
        private About about;
        private readonly Config setting;
        public AppWindow()
        {
            InitializeComponent();
            this.CenterToScreen();

            // To provide your own custom icon image, go to:
            //   1. Project > Properties... > Resources
            //   2. Change the resource filter to icons
            //   3. Remove the Default resource and add your own
            //   4. Modify the next line to Properties.Resources.<YourResource>
            this.Icon = Properties.Resources.Default;
            //this.SystemTrayIcon.Icon = Properties.Resources.Default;
            this.notifyIcon1.Icon = Properties.Resources.Default;

            // Change the Text property to the name of your application
            //this.SystemTrayIcon.Text = "رادیو";
            this.notifyIcon1.Text = "رادیو";
            //this.SystemTrayIcon.Visible = true;

            // Modify the right-click menu of your system tray icon here
            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add("نمایش پنجره", ShowApp);
            menu.MenuItems.Add("درباره ما", AboutForm);
            menu.MenuItems.Add("خروج", ContextMenuExit);
            this.notifyIcon1.ContextMenu = menu;

            this.Resize += WindowResize;
            this.FormClosing += WindowClosing;



            string text = Properties.Resources.config;
            setting = JsonConvert.DeserializeObject<Config>(text);


        }
        private void AboutForm(object sender, EventArgs e)
        {
            about = new About();
            about.Show();
        }
        private void ShowApp(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        private void SystemTrayIconDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ContextMenuExit(object sender, EventArgs e)
        {
            this.SystemTrayIcon.Visible = false;
            Application.Exit();
            Environment.Exit(0);
        }

        private void WindowResize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "رادیو اینترنتی";
                notifyIcon1.BalloonTipText = "برای باز کردن روی آیکن برنامه کلیک کنید";
                notifyIcon1.ShowBalloonTip(1000);
                this.Hide();
            }
        }

        private void WindowClosing(object sender, FormClosingEventArgs e)
        {
            this.SystemTrayIcon.Visible = false;
            Application.Exit();
            Environment.Exit(0);
        }


        private string getImage(string uri)
        {
            string url = "";
            string html;
            using (WebClient client = new WebClient())
            {
                html = client.DownloadString(uri);
            }
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            foreach (HtmlNode img in doc.DocumentNode.SelectNodes("//img"))
            {
                url = (img.GetAttributeValue("src", null));
            }
            return url;
        }
        private void getContent(string uri, string audio, string radioName)
        {

            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<link href='" + setting.videoCss + "' rel='stylesheet'>";
            html += "<script src='" + setting.videojs + "'></script>";
            //html += "<script src='https://unpkg.com/videojs-contrib-hls/dist/videojs-contrib-hls.js'></script>";
            html += "<video width='330' height='30' id='my_video' class='video-js vjs-default-skin vjs-big-play-centered' controls preload='auto' data-setup='{ \"inactivityTimeout\": 0 }' autoplay>";
            html += "<source src='" + audio + "' type='application/x-mpegURL'>";
            html += "</video>";
            html += "<script>";
            html += "var player = videojs('my_video');";
            html += "player.play();";
            html += "</script>";
            html += "</body></html>";
            this.webBrowser1.DocumentText = html;
            byte[] bytes = new Byte[64];
            var content = "رادیو";
            var image = "";
            try
            {
                bytes = Encoding.Default.GetBytes(getutf8(uri));
                content = Encoding.UTF8.GetString(bytes);
                image = getImage(uri);
            }
            catch (Exception)
            {
                MessageBox.Show("ایران صدا در دسترس نیست!");
            }

            string view = "<html><head>";
            view += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/><meta http-equiv='Content-Type' content='text/html;charset=utf-8'><meta charset='utf-8'/>";
            view += "<style>body{font-size:12px; font-family: Tahoma;}</style></head>";
            view += "<body style='overflow:hidden'><img style='width:100%' heigth='290' src='" + image + "'></img>";
            view += "<h4 style='text-align:right'>" + radioName + "</h4>";
            view += "<div style='text-align:right'>" + content + "</div>";
            view += "</body></html>";
            this.webBrowser2.DocumentText = view;
            notifyIcon1.Visible = true;
            this.Text = radioName;
            notifyIcon1.BalloonTipTitle = radioName;
            notifyIcon1.BalloonTipText = " شما در حال گوش کردن " + radioName + " هستید";
            notifyIcon1.ShowBalloonTip(1000);
        }


        private string getutf8(string uri)
        {
            string url = "";
            string html;
            using (WebClient client = new WebClient())
            {
                html = client.DownloadString(uri);
            }
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            var divs = doc.DocumentNode.SelectNodes("//div[contains(@class,'Content-box')]");
            foreach (HtmlNode node in divs)
            {
                url = node.InnerHtml;
            }
            return url;
        }
        private void javan_Click(object sender, EventArgs e)
        {
            getContent("http://player.iranseda.ir/live-player/getchannelcurrentprogdata/?ch=13", "http://s2.cdn1.iranseda.ir:1935/liveedge/radio-javan/chunklist_w719407684.m3u8", "رادیو جوان");

        }

        private void ava_Click(object sender, EventArgs e)
        {
            getContent("http://player.iranseda.ir/live-player/getchannelcurrentprogdata/?ch=21", "http://s2.cdn1.iranseda.ir:1935/liveedge/radio-avaa/chunklist_w1225145865.m3u8", "رادیو آوا");
        }

        private void iran_Click(object sender, EventArgs e)
        {
            getContent("http://player.iranseda.ir/live-player/getchannelcurrentprogdata/?ch=11", "http://s3.cdn1.iranseda.ir:1935/liveedge/radio-iran/chunklist_w609486865.m3u8", "رادیو ایران");

        }

        private void payam_Click(object sender, EventArgs e)
        {
            getContent("http://player.iranseda.ir/live-player/getchannelcurrentprogdata/?ch=12", "http://s1.cdn1.iranseda.ir:1935/liveedge/radio-payam/chunklist_w1221806736.m3u8", "رادیو پیام");

        }

        private void namayesh_Click(object sender, EventArgs e)
        {
            getContent("http://player.iranseda.ir/live-player/getchannelcurrentprogdata/?ch=22", "http://s1.cdn1.iranseda.ir:1935/liveedge/radio-namayesh/chunklist_w644193615.m3u8", "رادیو نمایش");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void farhang_Click(object sender, EventArgs e)
        {
            getContent("http://player.iranseda.ir/live-player/getchannelcurrentprogdata/?ch=16", "http://altcdn.iranseda.ir:1935/channel-live/smil:r-farhang/chunklist_b307200_slFa.m3u8", "رادیو فرهنگ");
        }

        private void salamat_Click(object sender, EventArgs e)
        {
            getContent("http://player.iranseda.ir/live-player/getchannelcurrentprogdata/?ch=17", "http://s1.cdn1.iranseda.ir:1935/liveedge/radio-salamat/chunklist_w1421201930.m3u8", "رادیو سلامت");
        }

        private void goftogo_Click(object sender, EventArgs e)
        {
            getContent("http://player.iranseda.ir/live-player/getchannelcurrentprogdata/?ch=29", "http://s1.cdn1.iranseda.ir:1935/liveedge/radio-goftego/chunklist_w937675949.m3u8", "رادیو گفت و گو");
        }

        private void varzesh_Click(object sender, EventArgs e)
        {
            getContent("http://player.iranseda.ir/live-player/getchannelcurrentprogdata/?ch=18", "http://s3.cdn1.iranseda.ir:1935/liveedge/radio-varzesh/chunklist_w1277672068.m3u8", "رادیو ورزش");
        }

        private void eghtesad_Click(object sender, EventArgs e)
        {
            getContent("http://player.iranseda.ir/live-player/getchannelcurrentprogdata/?ch=19", "http://s2.cdn1.iranseda.ir:1935/liveedge/radio-eghtesad/chunklist_w380853663.m3u8", "رادیو اقتصاد");

        }


        public class Config{
            public string videojs { get; set; }
            public string videoCss { get; set; }

        }
    }
}
