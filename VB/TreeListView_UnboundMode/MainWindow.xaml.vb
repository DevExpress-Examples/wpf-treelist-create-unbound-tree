Imports System.Windows
Imports DevExpress.Xpf.Grid

Namespace TreeListView_UnboundMode

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        'BuildTree();
        End Sub

        Private Sub BuildTree()
            Dim rootNode As TreeListNode = CreateRootNode(New ProjectObject() With {.Name = "Project: Stanton", .Executor = "Nicholas Llams"})
            Dim childNode As TreeListNode = CreateChildNode(rootNode, New StageObject() With {.Name = "Information Gathering", .Executor = "Ankie Galva"})
            CreateChildNode(childNode, New TaskObject() With {.Name = "Design", .Executor = "Reardon Felton", .State = "In progress"})
        End Sub

        Private Function CreateRootNode(ByVal dataObject As Object) As TreeListNode
            Dim rootNode As TreeListNode = New TreeListNode(dataObject)
            Me.view.Nodes.Add(rootNode)
            Return rootNode
        End Function

        Private Function CreateChildNode(ByVal parentNode As TreeListNode, ByVal dataObject As Object) As TreeListNode
            Dim childNode As TreeListNode = New TreeListNode(dataObject)
            parentNode.Nodes.Add(childNode)
            Return childNode
        End Function
    End Class

    Public Class ProjectObject

        Public Property Name As String

        Public Property Executor As String
    End Class

    Public Class StageObject
        Inherits ProjectObject

    End Class

    Public Class TaskObject
        Inherits ProjectObject

        Public Property State As String
    End Class
End Namespace
