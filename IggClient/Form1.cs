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

namespace IggClient
{
    public partial class IGGResolver : Form
    {
        public IGGResolver()
        {
            InitializeComponent();

            // Repositioning //
            hestia.Location = new Point(139, 56);
            credits1.Location = new Point(12, 69);
            credits2.Location = new Point(160, 161);

            // Resolver Objects //
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            unresolvedBox.Visible = false;
            resolvedBox.Visible = false;

            // Torrent Objects //
            magnetgrabButton.Visible = false;
            torrentLabel1.Visible = false;
            torrentLabel2.Visible = false;
            torrentUrl.Visible = false;
            magnetLink.Visible = false;

            // Credits Objects //
            hestia.Visible = true;
            credits1.Visible = true;
            credits2.Visible = true;
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

            // Torrent Objects //
            magnetgrabButton.Visible = false;
            torrentLabel1.Visible = false;
            torrentLabel2.Visible = false;
            torrentUrl.Visible = false;
            magnetLink.Visible = false;

            // Credits Objects //
            hestia.Visible = false;
            credits1.Visible = false;
            credits2.Visible = false;
        }

        private void torrentButton_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            unresolvedBox.Visible = false;
            resolvedBox.Visible = false;

            // Torrent Objects //
            magnetgrabButton.Visible = true;
            torrentLabel1.Visible = true;
            torrentLabel2.Visible = true;
            torrentUrl.Visible = true;
            magnetLink.Visible = true;

            // Credits Objects //
            hestia.Visible = false;
            credits1.Visible = false;
            credits2.Visible = false;
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
    }
}
