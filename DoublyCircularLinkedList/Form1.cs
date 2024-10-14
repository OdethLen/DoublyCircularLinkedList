using System.Collections.Generic;
using System.Xml.Linq;

namespace DoublyCircularLinkedList
{
    public partial class Form1 : Form
    {
        DoublyCircularLL dcll = new DoublyCircularLL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dcll.Contains(int.Parse(txtValue.Text)))
            {
                MessageBox.Show("The value already exists ");
                return;
            }
            Node node = new Node(int.Parse(txtValue.Text));
            dcll.Add(node);
            MessageBox.Show(dcll.ToString());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dcll.Contains(int.Parse(txtValue.Text)))
            {
                dcll.Remove(int.Parse(txtValue.Text));
                MessageBox.Show(dcll.ToString());
            }

            else
            {
                MessageBox.Show("Value "+txtValue.Text+ " does not exist in the doubly circular linked list");
            }

        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            if (dcll.Contains(int.Parse(txtValue.Text)))
            {
                MessageBox.Show("Value " +txtValue.Text+  " exists in the doubly circular linked list");
            }
            else
            {
                MessageBox.Show("Value "+txtValue.Text+ " does not exist in the doubly circular linked list");
            }
        }
    }
}
