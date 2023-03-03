namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string pathComuni = "C:\\Users\\emanuela.mascolo\\source\\repos\\NewRepo\\WinFormsApp1\\WinFormsApp1\\ElencoComuni.csv";
        private Dictionary<string, string> Comuni = new Dictionary<string, string>();

        Persona p = new Persona();

        public Form1()
        {
            InitializeComponent();
            CaricaComuni();
        }



        private void CaricaComuni()
        {
            using (var sr = new StreamReader(pathComuni))
            {
                while (!sr.EndOfStream)
                {
                    string[] comune = sr.ReadLine().Split(',');
                    comboBoxComune.Items.Add(comune[0]);    //nome
                    Comuni.Add(comune[0], comune[1]);   //nome, codice
                }
            }

            //var allLines = File.ReadAllLines(pathComuni);


        }

        private void buttonCF_Click(object sender, EventArgs e)
        {
            if (!ControlloDati())
            {
                return;
            }
            else
            {
                var cf = new Tecnosoftware.CodiceFiscale.CodiceFiscale(p.Cognome, p.Nome, p.DataNascita, p.CodiceComune, p.Sesso);
                MessageBox.Show(cf.estraiCF());
            }

        }

        private bool ControlloDati()
        {
            string nome = textBoxNome.Text.ToUpper();
            string cognome = textBoxCognome.Text.ToUpper();
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cognome))
            {
                MessageBox.Show("inserire nome/cognome");  //msg di errore!
                return false;
            }
            DateTime data = new DateTime();
            if(!DateTime.TryParse(dataNascitaPicker.Value.ToShortDateString(), out data))
            {
                MessageBox.Show("selezionare una data valida");  //msg di errore!
                return false;
            }
            string comune = comboBoxComune.Text;
            if (!comboBoxComune.Items.Contains(comune))
            {
                MessageBox.Show("selezionare un comune");  //msg di errore!
                return false;
            }
            string codiceComune = Comuni[comune];       //nome è la chiave
            
            string sex = radioButtonF.Checked ? "F" : "M";
            

            p = new Persona() { Nome = nome, Cognome = cognome, Sesso = sex, DataNascita = data, CodiceComune = codiceComune };
            return true;
            
        }
    }
}