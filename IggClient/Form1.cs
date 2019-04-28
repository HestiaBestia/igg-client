using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace IggClient
{
    public partial class IGGResolver : Form
    {
        string[] imagesArray;
        string[] linksArray;
        int pageNum;
        string pageNumsaved;

        public IGGResolver()
        {

            InitializeComponent();
            searchBar.Text = ("Search...");

            // Repositioning //
            hestia.Location = new Point(139, 56);
            credits1.Location = new Point(12, 69);
            credits2.Location = new Point(160, 161);
            torrentUrl.Location = new Point(34, 109);
            unresolvedBox.Location = new Point(34, 109);
            torrentLabel1.Location = new Point(31, 132);
            label1.Location = new Point(31, 132);
            resolvedBox.Location = new Point(34, 261);
            magnetLink.Location = new Point(34, 261);
            torrentLabel2.Location = new Point(31, 284);
            label2.Location = new Point(31, 284);
            openResolved.Location = new Point(465, 334);
            clientOpen.Location = new Point(465, 334);
            button1.Location = new Point(70, 334);
            magnetgrabButton.Location = new Point(70, 334);


            // Resolver Objects //
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            unresolvedBox.Visible = false;
            resolvedBox.Visible = false;
            openResolved.Visible = false;

            // Torrent Objects //
            magnetgrabButton.Visible = false;
            torrentLabel1.Visible = false;
            torrentLabel2.Visible = false;
            torrentUrl.Visible = false;
            magnetLink.Visible = false;
            clientOpen.Visible = false;

            // Credits Objects //
            hestia.Visible = true;
            credits1.Visible = true;
            credits2.Visible = true;

            // Search Objects //
            searchBar.Visible = false;
            searchbarButton.Visible = false;
            gamePicker.Visible = false;
            gameImage.Visible = false;
            hasTorrent.Visible = false;
            sendtoDirect.Visible = false;
            sendtoTorrent.Visible = false;
            nextPage.Visible = false;
            previousPage.Visible = false;
            pageNumber.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string unresolvedUrl = unresolvedBox.Text;
            string resolvedUrl = unresolvedUrl.Substring(unresolvedUrl.IndexOf('=') + 1);
            if (unresolvedBox.Text.Contains("bluemediafiles"))
            {
                resolvedBox.Text = "http" + resolvedUrl;
            }
            else
            {
                resolvedBox.Text = ("This is not a bluemediafiles link!");
            }

        }

        private void IGGResolver_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IGGResolver_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }
        Point lastPoint;
        private void IGGResolver_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void resolverButton_Click(object sender, EventArgs e)
        {
            // Resolver Objects //
            button1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            unresolvedBox.Visible = true;
            resolvedBox.Visible = true;
            openResolved.Visible = true;

            // Torrent Objects //
            magnetgrabButton.Visible = false;
            torrentLabel1.Visible = false;
            torrentLabel2.Visible = false;
            torrentUrl.Visible = false;
            magnetLink.Visible = false;
            clientOpen.Visible = false;

            // Credits Objects //
            hestia.Visible = false;
            credits1.Visible = false;
            credits2.Visible = false;

            // Search Objects //
            searchBar.Visible = false;
            searchbarButton.Visible = false;
            gamePicker.Visible = false;
            gameImage.Visible = false;
            hasTorrent.Visible = false;
            sendtoDirect.Visible = false;
            sendtoTorrent.Visible = false;
            nextPage.Visible = false;
            previousPage.Visible = false;
            pageNumber.Visible = false;
        }

        private void torrentButton_Click(object sender, EventArgs e)
        {
            // Resolver Objects //
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            unresolvedBox.Visible = false;
            resolvedBox.Visible = false;
            openResolved.Visible = false;

            // Torrent Objects //
            magnetgrabButton.Visible = true;
            torrentLabel1.Visible = true;
            torrentLabel2.Visible = true;
            torrentUrl.Visible = true;
            magnetLink.Visible = true;
            clientOpen.Visible = true;

            // Credits Objects //
            hestia.Visible = false;
            credits1.Visible = false;
            credits2.Visible = false;

            // Search Objects //
            searchBar.Visible = false;
            searchbarButton.Visible = false;
            gamePicker.Visible = false;
            gameImage.Visible = false;
            hasTorrent.Visible = false;
            sendtoDirect.Visible = false;
            sendtoTorrent.Visible = false;
            nextPage.Visible = false;
            previousPage.Visible = false;
            pageNumber.Visible = false;
        }

        private void magnetgrabButton_Click(object sender, EventArgs e)
        {
            string torrentParsing = torrentUrl.Text;

            if (torrentParsing.Contains("igg-games"))
            {
                WebRequest igggames = WebRequest.Create(torrentParsing);
                WebResponse response = igggames.GetResponse();
                using (Stream dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    string source = reader.ReadToEnd();
                    if (source.Contains("Torrent Link</a>"))
                    {
                        string[] uno = (source.Split(new string[] { "Torrent Link</a>" }, StringSplitOptions.RemoveEmptyEntries));
                        string[] dos = (uno[0].Split(new string[] { "TORRENT:" }, StringSplitOptions.RemoveEmptyEntries));
                        string[] tres = (dos[1].Split(new string[] { "html" }, StringSplitOptions.RemoveEmptyEntries));
                        string[] quatro = (tres[0].Split(new string[] { "http" }, StringSplitOptions.RemoveEmptyEntries));
                        string secondurl = ("http" + quatro[1] + "html");

                        WebRequest igggames2 = WebRequest.Create(secondurl);
                        WebResponse response2 = igggames2.GetResponse();
                        using (Stream dataStream2 = response2.GetResponseStream())
                        {
                            StreamReader reader2 = new StreamReader(dataStream2);
                            string source2 = reader2.ReadToEnd();
                            if (source2.Contains("magnet:?"))
                            {
                                string[] uno2 = (source2.Split(new string[] { "magnet:?" }, StringSplitOptions.RemoveEmptyEntries));
                                string[] dos2 = (uno2[1].Split(new string[] { "Torrent</a>" }, StringSplitOptions.RemoveEmptyEntries));
                                string[] tres2 = (dos2[0].Split(new string[] { "\">" }, StringSplitOptions.RemoveEmptyEntries));
                                magnetLink.Text = ("magnet:?" + tres2[0]);
                            }
                            else
                            {
                                magnetLink.Text = ("The magnet link was not found on the torrent page, the problem is on IGG's side.");
                            }
                        }

                    }
                    else
                    {
                        magnetLink.Text = ("Torrent link not found or invalid URL.");
                    }
                }
            }
            if (torrentParsing.Contains("pcgamestorrents"))
            {
                WebRequest pcgamestorrents = WebRequest.Create(torrentParsing);
                WebResponse response = pcgamestorrents.GetResponse();
                using (Stream dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    string source = reader.ReadToEnd();
                    if (source.Contains("magnet:?"))
                    {
                        string[] uno2 = (source.Split(new string[] { "magnet:?" }, StringSplitOptions.RemoveEmptyEntries));
                        string[] dos2 = (uno2[1].Split(new string[] { "Torrent</a>" }, StringSplitOptions.RemoveEmptyEntries));
                        string[] tres2 = (dos2[0].Split(new string[] { "\">" }, StringSplitOptions.RemoveEmptyEntries));
                        magnetLink.Text = ("magnet:?" + tres2[0]);
                    }
                    else
                    {
                        magnetLink.Text = ("The magnet link was not found on the torrent page, the problem is on IGG's side.");
                    }
                }
            }
        }

        private void clientOpen_Click(object sender, EventArgs e)
        {
            if (magnetLink.Text.Contains("magnet"))
            {
                Process.Start(magnetLink.Text);
            }
        }

        private void openResolved_Click(object sender, EventArgs e)
        {
            if (resolvedBox.Text.Contains("http"))
            {
                Process.Start(resolvedBox.Text);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            // Search Objects //
            searchBar.Visible = true;
            searchbarButton.Visible = true;
            gamePicker.Visible = true;
            gameImage.Visible = true;
            hasTorrent.Visible = true;
            sendtoDirect.Visible = true;
            sendtoTorrent.Visible = true;
            nextPage.Visible = true;
            previousPage.Visible = true;
            pageNumber.Visible = true;

            // Resolver Objects //
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            unresolvedBox.Visible = false;
            resolvedBox.Visible = false;
            openResolved.Visible = false;

            // Torrent Objects //
            magnetgrabButton.Visible = false;
            torrentLabel1.Visible = false;
            torrentLabel2.Visible = false;
            torrentUrl.Visible = false;
            magnetLink.Visible = false;
            clientOpen.Visible = false;

            // Credits Objects //
            hestia.Visible = false;
            credits1.Visible = false;
            credits2.Visible = false;
        }

        public void searchbarButton_Click(object sender, EventArgs e)
        {
            gamePicker.Items.Clear();
            string searchField = (searchBar.Text);
            string searchurlEnd = (searchField.Replace(" ", "+"));
            pageNum = 1;
            string searchUrl = ("https://igg-games.com/page/" + pageNum + "?s=" + searchurlEnd);

            WebRequest request = WebRequest.Create(searchUrl);
            WebResponse response = request.GetResponse();
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string source = reader.ReadToEnd();

                if (!source.Contains("https://igg-games.com/page/2")) {
                    pageNumber.Text = ("Page: 1 of 1");
                }
                else
                {
                    Regex pagesGrab = new Regex("(?=page/)(.*)(?=s)");
                    MatchCollection pagesGrabs = pagesGrab.Matches(source);
                    string[] pagesArray = new string[pagesGrabs.Count];
                    for (int i = 0; i < pagesGrabs.Count; i++)
                    {
                        pagesArray[i] = pagesGrabs[i].Groups[0].Value.Remove(0, 5);
                    }
                    pageNumber.Text = ("Page 1 of " + pagesArray[1].Substring(0,1));
                    pageNumsaved = pagesArray[1].Substring(0, 1);
                }

                Regex gameLink = new Regex("(?=uk-link-reset\" href=\")(.*)(?=\">)");
                MatchCollection gameLinks = gameLink.Matches(source);

                linksArray = new string[gameLinks.Count];
                for (int i = 0; i < gameLinks.Count; i++)
                {
                    linksArray[i] = gameLinks[i].Groups[0].Value.Remove(0, 21);
                }

                Regex gameImage = new Regex("(?=height=\"210\" src=\")(.*)(?=\" class)");
                MatchCollection gameImages = gameImage.Matches(source);

                imagesArray = new string[gameImages.Count];
                for (int k = 0; k < gameImages.Count; k++)
                {
                    imagesArray[k] = gameImages[k].Groups[0].Value.Remove(0, 18);
                }

                for (int p = 0; p < imagesArray.Length; p++)
                {
                    gamePicker.Items.Add(imagesArray[p].Remove(0, 49).Replace("-", " ").Replace("210x210.jpg", "").Replace("Free Download", ""));
                }

            }
        }

        public void gamePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int comboboxIndex = gamePicker.SelectedIndex;
            gameImage.ImageLocation = imagesArray[comboboxIndex];
            gameImage.SizeMode = PictureBoxSizeMode.Zoom;

            WebRequest request = WebRequest.Create(linksArray[comboboxIndex]);
            WebResponse response = request.GetResponse();
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string source = reader.ReadToEnd();

                if (source.Contains("TORRENT:</b>"))
                {
                    hasTorrent.Text = ("Has Torrent: True");
                }
                else
                {
                    hasTorrent.Text = ("Has Torrent: False");
                }
            }
        }
    
        private void sendtoTorrent_Click(object sender, EventArgs e)
        {
            int comboboxIndex = gamePicker.SelectedIndex;
            if (comboboxIndex >= 0)
            {
                torrentUrl.Text = linksArray[comboboxIndex];
                // Resolver Objects //
                button1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                unresolvedBox.Visible = false;
                resolvedBox.Visible = false;
                openResolved.Visible = false;

                // Torrent Objects //
                magnetgrabButton.Visible = true;
                torrentLabel1.Visible = true;
                torrentLabel2.Visible = true;
                torrentUrl.Visible = true;
                magnetLink.Visible = true;
                clientOpen.Visible = true;

                // Credits Objects //
                hestia.Visible = false;
                credits1.Visible = false;
                credits2.Visible = false;

                // Search Objects //
                searchBar.Visible = false;
                searchbarButton.Visible = false;
                gamePicker.Visible = false;
                gameImage.Visible = false;
                hasTorrent.Visible = false;
                sendtoDirect.Visible = false;
                sendtoTorrent.Visible = false;
                nextPage.Visible = false;
                previousPage.Visible = false;
                pageNumber.Visible = false;
            }
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            gamePicker.Items.Clear();
            string searchField = (searchBar.Text);
            string searchurlEnd = (searchField.Replace(" ", "+"));
            pageNum = pageNum + 1;
            string searchUrl = ("https://igg-games.com/page/" + pageNum + "?s=" + searchurlEnd);

            WebRequest request = WebRequest.Create(searchUrl);
            WebResponse response = request.GetResponse();
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string source = reader.ReadToEnd();

                pageNumber.Text = ("Page: " + pageNum.ToString() + " of " + pageNumsaved);

                Regex gameLink = new Regex("(?=uk-link-reset\" href=\")(.*)(?=\">)");
                MatchCollection gameLinks = gameLink.Matches(source);

                linksArray = new string[gameLinks.Count];
                for (int i = 0; i < gameLinks.Count; i++)
                {
                    linksArray[i] = gameLinks[i].Groups[0].Value.Remove(0, 21);
                }

                Regex gameImage = new Regex("(?=height=\"210\" src=\")(.*)(?=\" class)");
                MatchCollection gameImages = gameImage.Matches(source);

                imagesArray = new string[gameImages.Count];
                for (int k = 0; k < gameImages.Count; k++)
                {
                    imagesArray[k] = gameImages[k].Groups[0].Value.Remove(0, 18);
                }

                for (int p = 0; p < imagesArray.Length; p++)
                {
                    gamePicker.Items.Add(imagesArray[p].Remove(0, 49).Replace("-", " ").Replace("210x210.jpg", "").Replace("Free Download", ""));
                }

            }
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            gamePicker.Items.Clear();
            string searchField = (searchBar.Text);
            string searchurlEnd = (searchField.Replace(" ", "+"));
            pageNum = pageNum - 1;
            string searchUrl = ("https://igg-games.com/page/" + pageNum + "?s=" + searchurlEnd);

            WebRequest request = WebRequest.Create(searchUrl);
            WebResponse response = request.GetResponse();
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string source = reader.ReadToEnd();

                pageNumber.Text = ("Page: " + pageNum.ToString() + " of " + pageNumsaved);

                Regex gameLink = new Regex("(?=uk-link-reset\" href=\")(.*)(?=\">)");
                MatchCollection gameLinks = gameLink.Matches(source);

                linksArray = new string[gameLinks.Count];
                for (int i = 0; i < gameLinks.Count; i++)
                {
                    linksArray[i] = gameLinks[i].Groups[0].Value.Remove(0, 21);
                }

                Regex gameImage = new Regex("(?=height=\"210\" src=\")(.*)(?=\" class)");
                MatchCollection gameImages = gameImage.Matches(source);

                imagesArray = new string[gameImages.Count];
                for (int k = 0; k < gameImages.Count; k++)
                {
                    imagesArray[k] = gameImages[k].Groups[0].Value.Remove(0, 18);
                }

                for (int p = 0; p < imagesArray.Length; p++)
                {
                    gamePicker.Items.Add(imagesArray[p].Remove(0, 49).Replace("-", " ").Replace("210x210.jpg", "").Replace("Free Download", ""));
                }

            }
        }
    }
}
