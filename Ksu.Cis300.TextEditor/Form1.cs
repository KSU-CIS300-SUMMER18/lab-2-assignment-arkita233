/* form1.cs
 * Modifier: Sixiang Zhang 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.TextEditor
{
    /// <summary>
    /// A GUI for a program that opens an empty window.
    /// </summary>
    public partial class TextEditor : Form
    {
        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public TextEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        ///the method for opening file and show the message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = uxOpenFileDialog.FileName;
                // Process the file
                MessageBox.Show(" " + filename + "can't be opened");
            }
        }
        /// <summary>
        /// method for saving the file and show the message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSaveAs_Click(object sender, EventArgs e)
        {
            if (uxSaveFileDialog.ShowDialog() == DialogResult.OK)
            {

                string filename = uxSaveFileDialog.FileName;

                MessageBox.Show(" " +filename + "can't be written");
                // Process the file

            }
        }
    }
}
