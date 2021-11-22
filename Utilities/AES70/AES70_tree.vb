
Imports System.Xml
Imports System.IO



Public Class Rootobject
	Public Property noNamespaceSchemaLocation As String
	Public Property Root As Root
	Public Property Managers As Managers
	Public Property BlockMembers As Blockmembers
End Class

Public Class Root
	Public Property Label As String
	Public Property Name As String
	Public Property ClassID As String
	Public Property Versions() As Version
	Public Property Methods() As Method
	Public Property Events As Events
End Class

Public Class Events
	Public Property _Event As _Event
End Class

Public Class _Event
	Public Property Name As String
	Public Property Index As String
End Class

Public Class Version
	Public Property OcaVersion As String
	Public Property ClassVersion As String
End Class

Public Class Method
	Public Property Name As String
	Public Property Index As String
	Public Property AvailableSince As String
End Class

Public Class Managers
	Public Property Label As String
	Public Property Manager() As Manager
End Class

Public Class Manager
	Public Property Name As String
	Public Property ClassID As String
	Public Property ObjNumber As String
	Public Property Methods As Object
	Public Property Mandatory As Mandatory
	Public Property Events As Object
	Public Property AvailableSince As String
End Class

Public Class Mandatory
	Public Property OcaVersion As String
	Public Property Mandatory As String
	Public Property DeviceType As String
End Class

Public Class Blockmembers
	Public Property Label As String
	Public Property ObjectNumberLowerLimit As String
	Public Property ObjectNumberUpperLimit As String
	Public Property BlockMember() As Blockmember
End Class

Public Class Blockmember
	Public Property Name As String
	Public Property ClassID As String
	Public Property Methods As Object
	Public Property AvailableSince As String
	Public Property Versions As Versions
	Public Property DeprecatedSince As String
	Public Property Events As Object
	Public Property Mandatory As Object
End Class

Public Class Versions
	Public Property Version As Version1
End Class

Public Class Version1
	Public Property OcaVersion As String
	Public Property ClassVersion As String
End Class


'Public Class Rootobject
'	Public Property Name As String
'	Public Property ClassID As String
'	Public Property Methods As Methods
'End Class

'Public Class Methods
'	Public Property Method As Method
'End Class

'Public Class Method
'	Public Property Name As String
'	Public Property Index As String
'End Class




Public Class AES70_tree

	Private Sub AddNode(ByVal inXmlNode As XmlNode, ByVal inTreeNode As TreeNode)
		Dim xNode As XmlNode
		Dim tNode As TreeNode
		Dim nodeList As XmlNodeList
		Dim i As Integer
		If inXmlNode.HasChildNodes Then
			nodeList = inXmlNode.ChildNodes
			For i = 0 To nodeList.Count - 1
				xNode = inXmlNode.ChildNodes(i)
				inTreeNode.Nodes.Add(New TreeNode(xNode.Name))
				tNode = inTreeNode.Nodes(i)
				AddNode(xNode, tNode)
			Next
		Else
			inTreeNode.Text = inXmlNode.InnerText.ToString
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		Dim xmldoc As New XmlDataDocument()
		Dim xmlnode As XmlNode
		Dim fs As New FileStream("D:\i=AES70_ClassMembers.xml", FileMode.Open, FileAccess.Read)
		xmldoc.Load(fs)
		xmlnode = xmldoc.ChildNodes(1)
		inTreeNode.Nodes.Clear()
		inTreeNode.Nodes.Add(New TreeNode(xmldoc.DocumentElement.Name))
		Dim tNode As TreeNode
		tNode = inTreeNode.Nodes(0)
		AddNode(xmlnode, tNode)
	End Sub

	Private Sub AES70_tree_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class




