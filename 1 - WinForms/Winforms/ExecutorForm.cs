using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Abonent
{
    public partial class ExecutorForm : Form
    {
        private readonly MainForm mainForm;
        private readonly MongoDB_Class mongo;

        public ExecutorForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            mongo = mainForm.mongo;

            InitializeComponent();
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            Validate();

            if (idtb.Text != string.Empty && !fioError.Visible)
            {
                UpdateExecutor();
            }
            if (idtb.Text == string.Empty && !fioError.Visible)
            {
                AddExecutor();
            }
        }

        new private void Validate()
        {
            if (fiotb.Text == string.Empty)
            {
                fioError.Visible = true;
            }
            else
            {
                fioError.Visible = false;
            }
        }

        private void AddExecutor()
        {
            var executor = new Class_Executor();
            executor = SetExecutorProperties(executor);
            executor.Id = mongo.Load_DataExecutor().OrderBy(t => t.Id).Last().Id + 1;
            mongo.Insert_Executor_Information(executor);

            mainForm.executorsGV.DataSource = mongo.Load_DataExecutor();

            Close();
        }

        private void UpdateExecutor()
        {
            var executor = mongo.Load_DataExecutor().Where(t => t.Id.ToString() == idtb.Text).First();
            executor = SetExecutorProperties(executor);
            mongo.Update_Executor_Information(executor);

            mainForm.executorsGV.DataSource = mongo.Load_DataExecutor();

            Close();
        }

        private Class_Executor SetExecutorProperties(Class_Executor executor)
        {
            executor.Fio = fiotb.Text;

            return executor;
        }
    }
}
