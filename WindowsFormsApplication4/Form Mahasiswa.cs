using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        private BindingList<Mahasiswa> _mhs; //variabel binding

        public Form1()
        {
            InitializeComponent();
            _mhs = new BindingList<Mahasiswa>();

            dataGridMHS.DataSource = _mhs;
            ClearDatagrid();
        }
        /// <summary>
        /// Menngosongkan datagrid
        /// </summary>
        private void ClearDatagrid()
        {
            dataGridMHS.Rows.Clear(); //Mengosongkan datagrid
        }

        /// <summary>
        /// Button yang akan menambahkan item
        /// </summary>
        /// <param name="sender">l</param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            addDataToList();
         }

       
        /// <summary>
        /// Button untuk menghapus item yang dipilih
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            deleteByRow();
        }

        /// <summary>
        /// Method untuk menambahkan item yang sebelumnya telah diisikan pada text box
        /// </summary>
        private void addDataToList()
        {
            if (textNIM.Text != null && textNama.Text != null)
            {
                int nim = Convert.ToInt32(textNIM.Text);
                _mhs.Add(new Mahasiswa(nim, textNama.Text));
            }
        }

        /// <summary>
        /// Method untuk menghapus item pada row yang pilih
        /// </summary>
        private void deleteByRow()
        {
            foreach (DataGridViewRow item in this.dataGridMHS.SelectedRows)
            {
                dataGridMHS.Rows.RemoveAt(item.Index);
            }
        }
    }
}
