Imports System.Buffers

Public Class Form1
    Public Const Regpath = "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers"
    Public Const SRegpath = "SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str, str1 As String
        str = TextBox1.Text
        str1 = str.Substring(str.Length - 3, 3)
        If str1 = "exe" Then
            My.Computer.Registry.SetValue(Regpath, TextBox1.Text, "RUNASINVOKER")
            MsgBox("设置" + TextBox1.Text + "成功")
            ListView1.Clear()
            Call loadlistview()
        Else
            MsgBox("您所选文件的并非可执行程序，请重新选择")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'listview的初始化
        ListView1.View = View.Details '不加这句添加不了
        ListView1.GridLines = True  '格子
        ListView1.FullRowSelect = True '整行选
        ListView1.Columns.Clear()   '清空
        Call loadlistview()
    End Sub
    Public Sub AutoCtlSize(ByVal inObj As Control)     '自动调整控件大小 
        If inObj Is Nothing Then
            Exit Sub
        End If

        Dim DeskTopSize As Size = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim FormSize = Me.Size

        If ((inObj.Name.IndexOf("ListView") <> -1)) Then
            inObj.Size = New Size(Int(FormSize.Width - 70), Int(FormSize.Height - 200))
        End If
        If ((inObj.Name.IndexOf("TextBox") <> -1)) Then
            inObj.Size = New Size(Int(FormSize.Width - 200), inObj.Height)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str, str1 As String
        str = TextBox1.Text
        str1 = str.Substring(str.Length - 3, 3)
        If str1 = "exe" Then
            My.Computer.Registry.SetValue(Regpath, TextBox1.Text, "~ RUNASADMIN")
            MsgBox("设置" + TextBox1.Text + "成功")
            ListView1.Clear()
            Call loadlistview()
        Else
            MsgBox("您所选文件的并非可执行程序，请重新选择")
        End If
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim i As Integer
        i = Me.ListView1.SelectedIndices(0)
        If ((MsgBox("确认是否删除" + ListView1.Items(i).SubItems(0).Text, vbYesNo, "UAC-Control")) = 6) Then
            'Debug.Print(ListView1.Items(i).SubItems(0).Text)
            My.Computer.Registry.CurrentUser.OpenSubKey(SRegpath, True).DeleteValue(ListView1.Items(i).SubItems(0).Text, False)
        End If
        ListView1.Clear()
        Call loadlistview()
    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim str As String = InputBox("输入项值", "UAC-Control", 1)
        Dim i As Integer = Me.ListView1.SelectedIndices(0)
        If (str <> "") Then
            My.Computer.Registry.SetValue(Regpath, ListView1.Items(i).SubItems(0).Text, str)
            MsgBox("修改项" + ListView1.Items(i).SubItems(0).Text + "值成功！")
        End If
        ListView1.Clear()
        Call loadlistview()
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Call AutoCtlSize(Me.ListView1)
        Call AutoCtlSize(Me.TextBox1)
        If ListView1.Columns.Count > 0 Then
            ListView1.Columns(0).Width = ListView1.ClientSize.Width - ListView1.Columns(1).Width - ListView1.Columns(2).Width
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'ListView1.Columns.Clear()
        ListView1.Clear()
        Call loadlistview()
    End Sub
    Private Sub loadlistview()
        Dim dic As Dictionary(Of String, String) = New Dictionary(Of String, String)
        dic.Add("WIN", "WINDOWS旧版兼容模式")
        dic.Add("RUNASADMIN", "管理员权限运行")
        dic.Add("HIGHDPIAWARE", "高DPI感知")
        dic.Add("RUNASINVOKER", "以普通权限运行")

        ' ListView表头
        ListView1.Columns.Add("程序位置", ListView1.ClientSize.Width - 350, HorizontalAlignment.Left)
        ListView1.Columns.Add("键值", 170, HorizontalAlignment.Left)
        ListView1.Columns.Add("状态", 180, HorizontalAlignment.Left)

        Dim num, i As Integer
        Dim keyname() As String
        Dim readValue
        Dim trykey As String = ""
        num = My.Computer.Registry.CurrentUser.OpenSubKey(SRegpath).GetValueNames.Count
        Label2.Text = "总共：" + Str(num) + "项"
        ReDim keyname(num)
        keyname = My.Computer.Registry.CurrentUser.OpenSubKey(SRegpath).GetValueNames
        For i = 0 To (num - 1)
            Dim item As New ListViewItem()
            item.Text = keyname(i)
            readValue = My.Computer.Registry.GetValue(Regpath, keyname(i), Nothing)
            item.SubItems.Add(readValue)
            readValue = Replace(readValue, " ", "")
            readValue = Replace(readValue, "~", "")
            readValue = Replace(readValue, "^", "")
            If InStr(1, readValue, "WIN", CompareMethod.Text) > 0 Then
                item.SubItems.Add("WINDOWS旧版兼容模式")
            Else
                dic.TryGetValue(readValue, trykey)
                If (trykey <> "") Then
                    item.SubItems.Add(trykey)
                Else
                    item.SubItems.Add("未知")
                End If
            End If
            ListView1.Items.Add(item)
        Next i
        If ListView1.Columns.Count > 0 Then
            ListView1.Columns(0).Width = ListView1.ClientSize.Width - ListView1.Columns(1).Width - ListView1.Columns(2).Width
        End If
    End Sub

End Class
