namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<string, Premier> premiers = new Dictionary<string, Premier>();

        public Form1()
        {
            InitializeComponent();
            InitializeGui();
        }

        void InitializeGui()
        {

            List<Premier> premierList = Premier.GetPremiers();

            foreach (Premier premier in premierList)
            {
                string key = premier.GenerateKey();
                premiers[key] = premier;
            }


            lstPremier.DataSource = new List<string>(premiers.Keys);
            lstPremier.SelectedValueChanged += new EventHandler(lstPremier_SelectedValueChanged);
        }

        void UpdateGui(string key)
        {
            Premier premier = premiers[key];
            lblName.Text = premier.Name;
            lblLife.Text = premier.Life;
            lblTerm.Text = premier.Start + " - " + premier.End;
            picPremier.Image = Image.FromFile("images\\" + key.ToLower() + ".jpg");

        }

        private void lstPremier_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstPremier.SelectedValue != null)
            {
                UpdateGui(lstPremier.SelectedValue.ToString());
            }
        }

    }

}

