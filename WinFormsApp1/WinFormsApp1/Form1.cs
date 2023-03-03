namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string pathComuni = "C:\\Users\\emanuela.mascolo\\Desktop\\Academy\\1. esercizi\\WinFormsApp1\\WinFormsApp1\\ElencoComuni.csv";
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
                    comboBoxComune.Items.Add(comune[0]);
                    Comuni.Add(comune[1], comune[0]);   //codice, nome
                }
            }
        }

        private void buttonCF_Click(object sender, EventArgs e)
        {
            ControlloDati();
        }

        private void ControlloDati()
        {
            string nome = textBoxNome.Text.ToUpper();
            string cognome = textBoxCognome.Text.ToUpper();
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cognome))
            {
                MessageBox.Show("inserire nome/cognome");  //msg di errore!
                return;
            }
            DateOnly data = new DateOnly();
            if(!DateOnly.TryParse(dataNascitaPicker.Value.ToShortDateString(), out data))
            {
                MessageBox.Show("selezionare una data valida");  //msg di errore!
                return;
            }
            string comune = comboBoxComune.Text;
            if (!comboBoxComune.Items.Contains(comune))
            {
                MessageBox.Show("selezionare un comune");  //msg di errore!
                return;
            }
            string maschio = radioButtonM.Text;
            string femmina = radioButtonF.Text;
            if(string.IsNullOrEmpty(maschio) || string.IsNullOrEmpty(femmina))
            {
                MessageBox.Show("selezionare il genere");
                return;
            }

            p = new Persona() { Nome = nome, Cognome = cognome, DataNascita = data};

            
        }
    }
}