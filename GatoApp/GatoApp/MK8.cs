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
    public partial class MK8 : Form
    {
        Queue<Player> PlayerQueue = new Queue<Player>();
        LinkedList<Player> Playing = new LinkedList<Player>();
        public MK8()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (Playing.Count < 4)
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

            if (PlayerQueue.Size() > 0 && PlayerQueue.Size() > 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    Node<Player> TempPlayer = new Node<Player>(PlayerQueue.Peek());
                    Playing.AddBack(TempPlayer);
                    listBox1.Items.Add(TempPlayer.Item.ToString());
                    PlayerQueue.Dequeue();
                    listBox2.Items.Remove(TempPlayer.Item.ToString());
                }
            }
            else if (PlayerQueue.Size() > 0 && PlayerQueue.Size() < 4)
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
