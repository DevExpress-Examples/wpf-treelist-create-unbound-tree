﻿Imports System
Imports System.Windows
Imports DevExpress.Xpf.Grid

Namespace TreeListView_UnboundMode
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
			BuildTree()
			treeListView1.ExpandAllNodes()
		End Sub

		Private Sub BuildTree()
			Dim rootNode As TreeListNode = CreateRootNode(New ProjectObject() With {
				.Name = "Project: Stanton",
				.Executor = "Nicholas Llams"
			})
			Dim childNode As TreeListNode = CreateChildNode(rootNode, New StageObject() With {
				.Name = "Information Gathering",
				.Executor = "Ankie Galva"
			})
			CreateChildNode(childNode, New TaskObject() With {
				.Name = "Design",
				.Executor = "Reardon Felton",
				.State = "In progress"
			})
		End Sub

		Private Function CreateRootNode(ByVal dataObject As Object) As TreeListNode
			Dim rootNode As New TreeListNode(dataObject)
			treeListView1.Nodes.Add(rootNode)
			Return rootNode
		End Function

		Private Function CreateChildNode(ByVal parentNode As TreeListNode, ByVal dataObject As Object) As TreeListNode
			Dim childNode As New TreeListNode(dataObject)
			parentNode.Nodes.Add(childNode)
			Return childNode
		End Function
	End Class

	Public Class StageObject
		Public Property Name() As String
		Public Property Executor() As String
	End Class

	Public Class ProjectObject
		Public Property Name() As String
		Public Property Executor() As String
	End Class

	Public Class TaskObject
		Public Property Name() As String
		Public Property Executor() As String
		Public Property State() As String
	End Class
End Namespace
