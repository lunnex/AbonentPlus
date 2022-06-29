using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Abonent
{
    public partial class MainForm : Form
    {
        public readonly MongoDB_Class mongo;
        public MainForm()
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

        private void DeleteExcuterStrip_Click(object sender, EventArgs e)
        {
            var i = executorsGV.SelectedCells[0].OwningRow.Index;
            int id = (int)executorsGV[1, i].Value;

            mongo.Delete_Executor_Infromation(mongo.Load_DataExecutor().Where(t => t.Id == id).First());

            executorsGV.DataSource = mongo.Load_DataExecutor();
        }

        private void ChangeRequestStrip_Click(object sender, EventArgs e)
        {
            RequestForm requestForm = new RequestForm(this);

            var i = requestsGV.SelectedCells[0].OwningRow.Index;
            requestForm.IDtb.Text = requestsGV[1, i].Value.ToString();
            requestForm.accountCDtb.Text = (string)requestsGV[2, i].Value;
            requestForm.executorCDtb.Text = (string)requestsGV[3, i].Value;
            requestForm.failrueCDtb.Text = (string)requestsGV[4, i].Value;
            requestForm.incomingDatedp.Value = (DateTime)requestsGV[5, i].Value;
            try
            {
                requestForm.executionDatedp.Value = (DateTime)requestsGV[6, i].Value;
            }
            catch
            {
                requestForm.executionDatedp.Value = DateTime.Now;
            }
            requestForm.check.Checked = (bool)requestsGV[7, i].Value;

            requestForm.ShowDialog();

        }

        private void AddRequestStrip_Click(object sender, EventArgs e)
        {
            RequestForm requestForm = new RequestForm(this);
            requestForm.ShowDialog();
        }

        private void DeleteRequestStrip_Click(object sender, EventArgs e)
        {
            var i = requestsGV.SelectedCells[0].OwningRow.Index;
            int id = int.Parse(requestsGV[1, i].Value.ToString());

            mongo.Delete_Request_Infromation(mongo.Load_DataRequest().Where(t => t.Id == id).First());
            requestsGV.DataSource = mongo.Load_DataRequest();
        }

        private void DeleteAbonentStrip_Click(object sender, EventArgs e)
        {
            var i = abonentsGV.SelectedCells[0].OwningRow.Index;
            string id = abonentsGV[1, i].Value.ToString();

            mongo.Delete_Abonent_Infromation(mongo.Load_Abonent().Where(t => t.Id == id).First());
            abonentsGV.DataSource = mongo.Load_Abonent();
        }

        private void ChangeAbonentStrip_Click(object sender, EventArgs e)
        {
            AbonentForm abonentForm = new AbonentForm(this);

            var i = abonentsGV.SelectedCells[0].OwningRow.Index;
            abonentForm.IDtb.Text = abonentsGV[1, i].Value.ToString();
            abonentForm.streettb.Text = (string)abonentsGV[2, i].Value;
            abonentForm.buildingtb.Text = abonentsGV[3, i].Value.ToString();
            abonentForm.flattb.Text = abonentsGV[4, i].Value.ToString();
            abonentForm.fiotb.Text = (string)abonentsGV[5, i].Value;
            abonentForm.phonetb.Text = (string)abonentsGV[6, i].Value;

            abonentForm.ShowDialog();
        }

        private void AddAbonentStrip_Click(object sender, EventArgs e)
        {
            AbonentForm abonentForm = new AbonentForm(this);
            abonentForm.ShowDialog();
        }

        private void ChangeExcuterStrip_Click(object sender, EventArgs e)
        {
            ExecutorForm executorForm = new ExecutorForm(this);

            var i = executorsGV.SelectedCells[0].OwningRow.Index;
            executorForm.idtb.Text = executorsGV[1, i].Value.ToString();
            executorForm.fiotb.Text = executorsGV[2, i].Value.ToString();

            executorForm.ShowDialog();
        }

        private void AddExcuterStrip_Click(object sender, EventArgs e)
        {
            ExecutorForm executorForm = new ExecutorForm(this);
            executorForm.ShowDialog();
        }

        private void DoneRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var collection = mongo.Load_DataRequest().Where(t => t.Executed == true);
            SBindingList<Class_Request> doclist = MakeBindlist(collection);

            requestsGV.DataSource = doclist;
        }

        private void UndoneRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var collection = mongo.Load_DataRequest().Where(t => t.Executed == false);
            SBindingList<Class_Request> doclist = MakeBindlist(collection);

            requestsGV.DataSource = doclist;
        }

        private void AllRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            requestsGV.DataSource = mongo.Load_DataRequest();
        }

        private void WithExecutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var collection = mongo.Load_DataRequest().Where(t => t.ExecutorCD != null);
            SBindingList<Class_Request> doclist = MakeBindlist(collection);

            requestsGV.DataSource = doclist;
        }

        private void WithoutExecutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var collection = mongo.Load_DataRequest().Where(t => t.ExecutorCD is null);
            SBindingList<Class_Request> doclist = MakeBindlist(collection);

            requestsGV.DataSource = doclist;
        }

        private static SBindingList<Class_Request> MakeBindlist(System.Collections.Generic.IEnumerable<Class_Request> collection)
        {
            SBindingList<Class_Request> doclist = new SBindingList<Class_Request>();

            foreach (Class_Request stat in collection)
            {
                doclist.Add(stat);
            }

            return doclist;
        }
    }
}
