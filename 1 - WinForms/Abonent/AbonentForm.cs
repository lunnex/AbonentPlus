using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Abonent
{
    public partial class AbonentForm : Form
    {
        private readonly MainForm mainForm;
        private readonly MongoDB_Class mongo;

        private const string MobilePhonePattern = "^[8]\\d{10}$";
        private const string WirePhonePattern = "^\\d{6}$";

        public AbonentForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            mongo = mainForm.mongo;

            InitializeComponent();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            Validate();

            if (IDtb.Text != string.Empty && !fioError.Visible && !streetError.Visible && !buildingError.Visible && !flatError.Visible && !fioError.Visible && !phoneError.Visible)
            {
                UpdateAbonent();
            }
            if (!fioError.Visible && !streetError.Visible && !buildingError.Visible && !flatError.Visible && !fioError.Visible && !phoneError.Visible)
            {
                AddAbonent();
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

            if(streettb.Text == string.Empty)
            {
                streetError.Visible = true;
            }
            else
            {
                streetError.Visible = false;
            }

            if(!int.TryParse(buildingtb.Text, out int i))
            {
                buildingError.Visible = true;
            }
            else
            {
                buildingError.Visible = false;
            }

            if(!int.TryParse(flattb.Text, out int k))
            {
                flatError.Visible = true;
            }
            else
            {
                flatError.Visible = false;
            }

            if (fiotb.Text == string.Empty)
            {
                fioError.Visible = true;
            }
            else
            {
                fioError.Visible = false;
            }

            if((!Regex.IsMatch(phonetb.Text, MobilePhonePattern) && phonetb.Text != string.Empty) && (!Regex.IsMatch(phonetb.Text, WirePhonePattern ) && phonetb.Text != string.Empty))
            {
                phoneError.Visible = true;
            }
            else
            {
                phoneError.Visible = false;
            }
        }

        private void AddAbonent()
        {
            var abonent = new Class_Abonent();
            abonent = SetAbonentProperties(abonent);
            abonent.Id = (int.Parse(mongo.Load_Abonent().OrderBy(t => t.Id).Last().Id) + 1).ToString("000000");
            mongo.Insert_Abonent_Information(abonent);

            mainForm.abonentsGV.DataSource = mongo.Load_Abonent();

            Close();
        }

        private void UpdateAbonent()
        {
            var abonent = mongo.Load_Abonent().Where(t => t.Id == IDtb.Text).First();
            abonent = SetAbonentProperties(abonent);
            mongo.Update_Abonent_Information(abonent);

            mainForm.abonentsGV.DataSource = mongo.Load_Abonent();

            Close();
        }

        private Class_Abonent SetAbonentProperties(Class_Abonent abonent)
        {
            abonent.StreetCD = streettb.Text;
            abonent.HouseNo = int.Parse(buildingtb.Text);
            abonent.FlatNo = int.Parse(flattb.Text);
            abonent.Fio = fiotb.Text;
            abonent.Phone = phonetb.Text;
            return abonent;
        }
    }
}
