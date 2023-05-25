<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Button1 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        OpenFileDialog1 = New OpenFileDialog()
        Button2 = New Button()
        ListView1 = New ListView()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ToolStripMenuItem1 = New ToolStripMenuItem()
        Button3 = New Button()
        Button4 = New Button()
        Label2 = New Label()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(45, 85)
        Button1.Name = "Button1"
        Button1.Size = New Size(91, 31)
        Button1.TabIndex = 0
        Button1.Text = "选择程序"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 20)
        Label1.TabIndex = 1
        Label1.Text = "应用程序位置："
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(144, 27)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(550, 27)
        TextBox1.TabIndex = 3
        TextBox1.Text = "c:\to\path\exam.ple"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(161, 86)
        Button2.Name = "Button2"
        Button2.Size = New Size(162, 29)
        Button2.TabIndex = 4
        Button2.Text = "永久以普通权限启动"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.ContextMenuStrip = ContextMenuStrip1
        ListView1.Location = New Point(35, 135)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(739, 286)
        ListView1.TabIndex = 6
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, ToolStripMenuItem2})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(211, 80)
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(210, 24)
        ToolStripMenuItem1.Text = "删除项"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(352, 85)
        Button3.Name = "Button3"
        Button3.Size = New Size(175, 29)
        Button3.TabIndex = 7
        Button3.Text = "永久以管理员权限启动"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(554, 85)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 8
        Button4.Text = "刷新列表"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(678, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 20)
        Label2.TabIndex = 9
        Label2.Text = "总共：N项"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(210, 24)
        ToolStripMenuItem2.Text = "手动修改项值"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(791, 449)
        Controls.Add(Label2)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(ListView1)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "UAC-Control"
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
End Class
