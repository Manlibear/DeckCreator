using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MtgDb.Info;
using System.Net;
using System.IO;
using MetroFramework.Controls;

namespace DeckCreator
{
    public partial class CardView : MetroUserControl
    {
        public Card Card { get; set; }

        public CardView()
        {
            InitializeComponent();
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.UseCustomBackColor = true;
            this.BackColor = Color.Black;
            this.Margin = new Padding(10, 10, 10, 10);
            lblCardName.UseCustomBackColor = true;
            lblCardName.BackColor = Color.Black;
           
        }

        public void Render()
        {
            lblCardName.Text = Card.Name;
            pcbCardImage.Image = GetImageFromUrl(Card.ImageHiRes);

        }

        public static Image GetImageFromUrl(string url)
        {
            using (var webClient = new WebClient())
            {
                return ByteArrayToImage(webClient.DownloadData(url));
            }
        }

        public static Image ByteArrayToImage(byte[] fileBytes)
        {
            using (var stream = new MemoryStream(fileBytes))
            {
                return Image.FromStream(stream);
            }
        }
    }
}
