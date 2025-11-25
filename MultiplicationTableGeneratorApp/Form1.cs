using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MultiplicationTableGeneratorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblInstructions_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int size = (int)nudDimensions.Value;

            // Set monospace font for proper alignment
            lbTable.Font = new Font("Consolas", 11);

            // Clear existing items
            lbTable.Items.Clear();

            // Determine column width based on largest number (size * size)
            int maxNumber = size * size;
            int columnWidth = maxNumber.ToString().Length + 1;

            // Add header row
            string header = "×".PadLeft(columnWidth) + " ";
            for (int i = 1; i <= size; i++)
            {
                header += i.ToString().PadLeft(columnWidth) + " ";
            }
            lbTable.Items.Add(header);

            // Add separator line
            string separator = new string('-', header.Length);
            lbTable.Items.Add(separator);

            // Add rows with multiplication values
            for (int row = 1; row <= size; row++)
            {
                string line = row.ToString().PadLeft(columnWidth) + " ";

                for (int col = 1; col <= size; col++)
                {
                    line += (row * col).ToString().PadLeft(columnWidth) + " ";
                }

                lbTable.Items.Add(line);

                // Add empty line between rows
                if (row < size)
                {
                    lbTable.Items.Add("");
                }
            }

        }
    }
}