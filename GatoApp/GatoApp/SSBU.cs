using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatoApp
{
    public partial class SSBU : Form
    {
        Queue<Player> PlayerQueue = new Queue<Player>();
        LinkedList<Player> Playing = new LinkedList<Player>();
        public SSBU()
        {
            InitializeComponent();
        }

        private void HasController_CheckedChanged(object sender, EventArgs e)
        {
            if (HasController.Checked)
            {

            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (Playing.Count < 8)
            {
                string name = textBox1.Text;
                bool check = HasController.Checked;
                int place = Playing.Count + 1;
                Player temp = new Player(name, place, check);
                Node<Player> newNode = new Node<Player>(temp);
                Playing.AddBack(newNode);
                listBox1.Items.Add(temp.ToString());
            }
            else
            {
                string name = textBox1.Text;
                bool check = HasController.Checked;
                int place = PlayerQueue.Size() + 1;
                Player temp = new Player(name, place, check);
                Node<Player> newNode = new Node<Player>(temp);
                PlayerQueue.Enqueue(newNode);
                listBox2.Items.Add(temp.ToString());
            }

            textBox1.ResetText();

        }

        private void Reset_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            if (PlayerQueue.Size() > 0 && PlayerQueue.Size() > 8)
            {
                for (int i = 0; i < 8; i++)
                {
                    Node<Player> TempPlayer = new Node<Player>(PlayerQueue.Peek());
                    Playing.AddBack(TempPlayer);
                    listBox1.Items.Add(TempPlayer.Item.ToString());
                    PlayerQueue.Dequeue();
                    listBox2.Items.Remove(TempPlayer.Item.ToString());
                }
            }
            else if (PlayerQueue.Size() > 0 && PlayerQueue.Size() < 8)
            {
                for (int i = 0; i < PlayerQueue.Size(); i++)
                {
                    Node<Player> TempPlayer = new Node<Player>(PlayerQueue.Peek());
                    Playing.AddBack(TempPlayer);
                    listBox1.Items.Add(TempPlayer.Item.ToString());
                    PlayerQueue.Dequeue();
                    listBox2.Items.Remove(TempPlayer.Item.ToString());
                }
            }

        }
    }
}
