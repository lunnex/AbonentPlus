using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Abonent
{
    public partial class RequestForm : Form
    {
        private readonly MongoDB_Class mongo;
        private readonly MainForm mainForm;

        public RequestForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            mongo = mainForm.mongo;

            InitializeComponent();
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            Validate();

            if (IDtb.Text != string.Empty && !clientError.Visible && !failrueError.Visible && !incomingRequestError.Visible && !executionRequestError.Visible)
            {
                UpdateRequest();
            }

            if (IDtb.Text == string.Empty && !clientError.Visible && !failrueError.Visible && !incomingRequestError.Visible && !executionRequestError.Visible)
            {
                AddRequest();
            }
        }

        new private void Validate()
        {
            if (accountCDtb.Text == string.Empty)
            {
                clientError.Visible = true;
            }
            else
            {
                clientError.Visible = false;
            }

            if (failrueCDtb.Text == string.Empty)
            {
                failrueError.Visible = true;
            }
            else
            {
                failrueError.Visible = false;
            }

            if (incomingDatedp.Value > executionDatedp.Value)
            {
                executionRequestError.Visible = true;
                incomingRequestError.Visible = true;
            }
            else
            {
                if (incomingDatedp.Value > DateTime.Now)
                {
                    incomingRequestError.Visible = true;
                }
                else
                {
                    incomingRequestError.Visible = false;
                }

                if (executionDatedp.Value > DateTime.Now)
                {
                    executionRequestError.Visible = true;
                }
                else
                {
                    executionRequestError.Visible = false;
                }
            } 
        }

        private void AddRequest()
        {
            var request = new Class_Request();
            request = SetRequestProperties(request);
            request.Id = mongo.Load_DataRequest().OrderBy(t => t.Id).Last().Id + 1;
            mongo.Insert_Request_Information(request);

            mainForm.requestsGV.DataSource = mongo.Load_DataRequest();

            Close();
        }

        private void UpdateRequest()
        {
            var request = mongo.Load_DataRequest().Where(t => t.Id == int.Parse(IDtb.Text)).First();
            request = SetRequestProperties(request);
            mongo.Update_Request_Information(request);

            mainForm.requestsGV.DataSource = mongo.Load_DataRequest();

            Close();
        }

        private Class_Request SetRequestProperties(Class_Request request)
        {
            request.AccountCD = accountCDtb.Text;
            request.ExecutorCD = executorCDtb.Text;
            request.IncomingDate = incomingDatedp.Value;
            request.ExecutionDate = executionDatedp.Value;
            request.FailureCD = failrueCDtb.Text;
            request.Executed = check.Checked;
            return request;
        }
    }
}
