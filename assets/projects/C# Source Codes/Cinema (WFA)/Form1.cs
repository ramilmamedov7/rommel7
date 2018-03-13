using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Reserve : Form
    {
        public Reserve()
        {
            InitializeComponent();
        }

        private List<Button> SelectedSeats = new List<Button>();

        private void AllSeatsClick(object sender, EventArgs e)
        {
            Button Seat = sender as Button;

            if (Seat.BackColor == SystemColors.ButtonHighlight)
            {
                this.SelectedSeats.Add(Seat);
                Seat.BackColor = SystemColors.ActiveCaption;
            }
            else if (Seat.BackColor == SystemColors.ActiveCaption)
            {
                this.SelectedSeats.Remove(Seat);
                Seat.BackColor = SystemColors.ButtonHighlight;
            }
            else
            {
                DialogResult result = MessageBox.Show("Əminsiniz mi?", "Bileti geri qaytarmaq", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Seat.BackColor = SystemColors.ButtonHighlight;
                }
            }
        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {
            string message = "Siz ";

            SelectedSeats.ForEach(seat =>
            {
                seat.BackColor = Color.IndianRed;
                message += "'" + seat.Text + "' - ";
            });

            message += (this.SelectedSeats.Count == 1 ? "oturacağına bilet aldınız." : "oturacağlarına bilet aldınız.");

            MessageBox.Show(message);
            SelectedSeats.Clear();
        }
    }
}
