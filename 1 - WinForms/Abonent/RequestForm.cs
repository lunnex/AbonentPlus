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
    public partial class RequestForm : Form
    {
        private readonly MongoDB_Class mongo;
        private readonly Form1 mainForm;

        public RequestForm(Form1 mainForm)
        {
            mongo = new MongoDB_Class();
            this.mainForm = mainForm;

            InitializeComponent();
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            var request = mongo.Load_DataRequest().Where(t => t.Id == int.Parse(IDtb.Text)).First();
            request.AccountCD = AccountCDtb.Text;
            request.ExecutorCD = executorCDtb.Text;
            request.IncomingDate = incomingDatedp.Value;
            request.ExecutionDate = executionDatedp.Value;
            request.FailureCD = failrueCDtb.Text;
            request.Executed = check.Checked;
            mongo.Update_Request_Information(request);

            mainForm.requestsGV.DataSource = mongo.Load_DataRequest();

            this.Dispose();
        }
    }
}
