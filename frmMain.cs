using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;
using MtgDb.Info.Driver;
using MtgDb.Info;
using System.Net;
using System.IO;

namespace DeckCreator
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Db db = new Db();
                
                Card[] searchResults =  db.Search(txtSearch.Text);
                tpSearch.Controls.Clear();


                foreach (Card card in searchResults)
                {
                    CardView cardView = new CardView();
                    cardView.Card = card;

                    tpSearch.Controls.Add(cardView);

                    cardView.Render();
                }
            }
        }

    }
}
