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
        Queue<Player> Playing = new Queue<Player>();
        public MK8()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (Playing.Size() < 4)
            {
                string name = textBox1.Text;
                bool check = HasController.Checked;
                int place = Playing.Size() + 1;
                Player temp = new Player(name, place, check);
                Node<Player> newNode = new Node<Player>(temp);
                Playing.Enqueue(newNode);
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
            for (int i = 0; i < 8; i++)
            {
                Playing.Dequeue();
            }

            if (PlayerQueue.Size() > 0 && PlayerQueue.Size() > 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    Node<Player> TempPlayer = new Node<Player>(PlayerQueue.Peek());
                    Playing.Enqueue(TempPlayer);
                    listBox1.Items.Add(TempPlayer.Item.ToString());
                    PlayerQueue.Dequeue();
                    listBox2.Items.Remove(TempPlayer.Item.ToString());
                }
            }
            else if (PlayerQueue.Size() > 0 && PlayerQueue.Size() < 4)
            {
                int queueSize = PlayerQueue.Size();
                for (int i = 0; i < queueSize; i++)
                {
                    Node<Player> TempPlayer = new Node<Player>(PlayerQueue.Peek());
                    Playing.Enqueue(TempPlayer);
                    listBox1.Items.Add(TempPlayer.Item.ToString());
                    PlayerQueue.Dequeue();
                    listBox2.Items.Remove(TempPlayer.Item.ToString());
                }
            }
        }
    }
}
