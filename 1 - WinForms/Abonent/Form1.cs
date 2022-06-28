using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abonent
{
    public partial class Form1 : Form
    {
        private readonly MongoDB_Class mongo;
        public Form1()
        {
            InitializeComponent();

            mongo = new MongoDB_Class();

            requestsGV.DataSource = mongo.Load_DataRequest();
            abonentsGV.DataSource = mongo.Load_Abonent();
            executorsGV.DataSource = mongo.Load_DataExecutor();

            executorsGV.ContextMenuStrip = executorStrip;
            abonentsGV.ContextMenuStrip = abonentStrip;
            requestsGV.ContextMenuStrip = requestsStrip;
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = executorsGV.SelectedCells[0].OwningRow.Index;
            var id = executorsGV[0, i].Value;

            //mongo.Delete_Executor_Infromation();
            
        }

        private void изменитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RequestForm requestForm = new RequestForm(this);

            var i = executorsGV.SelectedCells[0].OwningRow.Index;
            int id = (int)requestsGV[1, i].Value;
            string accountCD = (string)requestsGV[2, i].Value;
            string executorCD = (string)requestsGV[3, i].Value;
            string failrueCD = (string)requestsGV[4, i].Value;
            DateTime incomingDate = (DateTime)requestsGV[5, i].Value;
            DateTime executionDate = (DateTime)requestsGV[6, i].Value;
            bool isChecked = (bool)requestsGV[7, i].Value;

            requestForm.IDtb.Text = id.ToString();
            requestForm.AccountCDtb.Text = accountCD;
            requestForm.executorCDtb.Text = executorCD;
            requestForm.failrueCDtb.Text = failrueCD;
            requestForm.incomingDatedp.Value = incomingDate;
            requestForm.executionDatedp.Value = executionDate;
            requestForm.check.Checked = isChecked;

            requestForm.ShowDialog();

        }
    }
}
