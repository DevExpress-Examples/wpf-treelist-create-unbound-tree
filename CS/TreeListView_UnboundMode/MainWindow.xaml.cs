using System.Windows;
using DevExpress.Xpf.Grid;

namespace TreeListView_UnboundMode {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            //BuildTree();
        }

        private void BuildTree() {
            TreeListNode rootNode = CreateRootNode(new ProjectObject() { Name = "Project: Stanton", Executor = "Nicholas Llams" });
            TreeListNode childNode = CreateChildNode(rootNode, new StageObject() { Name = "Information Gathering", Executor = "Ankie Galva" });
            CreateChildNode(childNode, new TaskObject() { Name = "Design", Executor = "Reardon Felton", State = "In progress" });
        }

        private TreeListNode CreateRootNode(object dataObject) {
            TreeListNode rootNode = new TreeListNode(dataObject);
            view.Nodes.Add(rootNode);
            return rootNode;
        }

        private TreeListNode CreateChildNode(TreeListNode parentNode, object dataObject) {
            TreeListNode childNode = new TreeListNode(dataObject);
            parentNode.Nodes.Add(childNode);
            return childNode;
        }
    }

    public class ProjectObject {
        public string Name { get; set; }
        public string Executor { get; set; }
    }

    public class StageObject : ProjectObject { }

    public class TaskObject : ProjectObject {
        public string State { get; set; }
    }
}
