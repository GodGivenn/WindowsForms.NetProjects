using System.Data.SqlClient;

namespace Nr1_ManagerAngajati
{
    public partial class Form1 : Form
    {
        private AngajatRepo angajatRepo = new AngajatRepo();
        private List<Angajat> angajati;
        public Form1()
        {
            InitializeComponent();

            BuildTree();
        }
        private void BuildTree()
        {
            angajati = angajatRepo.GetAngajati();
            var manager = angajati.First(x => x.CodManager == null); //LINQ cauta pe primul si se opreste, merge daca e doar unul, daca nu e, FirstOrDefault->null, la noi exceptie
            
            var node = new TreeNode(manager.Nume);
            node.Tag = manager;

            angajatiTreeView.Nodes.Add(node);

        }
    }
}