namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string pathFolder = "C:\\Users\\emanuela.mascolo\\source\\repos\\NewRepo\\WinFormsApp1-codice fiscale\\WinFormsApp1\\Model\\";
        private string pathComuni = "ElencoComuni.csv";
        private string pathStorico = "Storico.csv";
        
        //bisogna prima cercare se qualcuno ha già implementato la soluzione 

        public Form1()
        {
            InitializeComponent();
            CaricaComuni();
        }



        private void CaricaComuni()
        {
            var listaComuni = new List<Comune>();
            var allLines = File.ReadAllLines(Path.Combine(pathFolder, pathComuni));
            foreach (var line in allLines)
            {
                var split = line.Split(',');
                listaComuni.Add(new Comune(split[0], split[1]));
            }

            comboBoxComune.DataSource = listaComuni;
            comboBoxComune.DisplayMember = "Nome";

        }

        private void buttonCF_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var cognome = textBoxCognome.Text;
            var dataNascita = dataNascitaPicker.Value;

            //button radio
            var sex = radioButtonF.Checked ? "F" : "M";     //controlla se F altrimenti mette M
            var codiceComune = (Comune)comboBoxComune.SelectedItem;

            //utilizzo la libreria già esistente!
            var calculator = new Tecnosoftware.CodiceFiscale.CodiceFiscale(cognome, nome, dataNascita, codiceComune.Codice, sex);
            MessageBox.Show(calculator.estraiCF());

            //Aggiungo il CF in un file (storico)
            File.WriteAllText(Path.Combine(pathFolder, pathStorico), calculator.estraiCF());
        }
    }
}