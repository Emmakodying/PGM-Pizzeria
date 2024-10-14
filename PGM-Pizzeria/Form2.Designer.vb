<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        label1 = New Label()
        TextBoxusername = New TextBox()
        TextBoxpassword = New TextBox()
        Labelusername = New Label()
        Labelpassword = New Label()
        Buttonlogin = New Button()
        TextBoxtotalsale = New TextBox()
        Labeltotalsale = New Label()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(134, 9)
        label1.Name = "label1"
        label1.Size = New Size(131, 19)
        label1.TabIndex = 0
        label1.Text = "Manager screen"
        ' 
        ' TextBoxusername
        ' 
        TextBoxusername.Location = New Point(154, 75)
        TextBoxusername.Name = "TextBoxusername"
        TextBoxusername.Size = New Size(100, 23)
        TextBoxusername.TabIndex = 1
        ' 
        ' TextBoxpassword
        ' 
        TextBoxpassword.Location = New Point(154, 118)
        TextBoxpassword.Name = "TextBoxpassword"
        TextBoxpassword.Size = New Size(100, 23)
        TextBoxpassword.TabIndex = 2
        ' 
        ' Labelusername
        ' 
        Labelusername.AutoSize = True
        Labelusername.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelusername.Location = New Point(12, 75)
        Labelusername.Name = "Labelusername"
        Labelusername.Size = New Size(93, 19)
        Labelusername.TabIndex = 3
        Labelusername.Text = "Username:"
        ' 
        ' Labelpassword
        ' 
        Labelpassword.AutoSize = True
        Labelpassword.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelpassword.Location = New Point(13, 118)
        Labelpassword.Name = "Labelpassword"
        Labelpassword.Size = New Size(92, 19)
        Labelpassword.TabIndex = 4
        Labelpassword.Text = "Password:"
        ' 
        ' Buttonlogin
        ' 
        Buttonlogin.Location = New Point(167, 161)
        Buttonlogin.Name = "Buttonlogin"
        Buttonlogin.Size = New Size(75, 23)
        Buttonlogin.TabIndex = 5
        Buttonlogin.Text = "Login"
        Buttonlogin.UseVisualStyleBackColor = True
        ' 
        ' TextBoxtotalsale
        ' 
        TextBoxtotalsale.Location = New Point(154, 75)
        TextBoxtotalsale.Name = "TextBoxtotalsale"
        TextBoxtotalsale.ReadOnly = True
        TextBoxtotalsale.Size = New Size(100, 23)
        TextBoxtotalsale.TabIndex = 6
        TextBoxtotalsale.Visible = False
        ' 
        ' Labeltotalsale
        ' 
        Labeltotalsale.AutoSize = True
        Labeltotalsale.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labeltotalsale.Location = New Point(13, 75)
        Labeltotalsale.Name = "Labeltotalsale"
        Labeltotalsale.Size = New Size(87, 19)
        Labeltotalsale.TabIndex = 7
        Labeltotalsale.Text = "Total sale:"
        Labeltotalsale.Visible = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(421, 216)
        Controls.Add(Labeltotalsale)
        Controls.Add(TextBoxtotalsale)
        Controls.Add(Buttonlogin)
        Controls.Add(Labelpassword)
        Controls.Add(Labelusername)
        Controls.Add(TextBoxpassword)
        Controls.Add(TextBoxusername)
        Controls.Add(label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents TextBoxusername As TextBox
    Friend WithEvents TextBoxpassword As TextBox
    Friend WithEvents Labelusername As Label
    Friend WithEvents Labelpassword As Label
    Friend WithEvents Buttonlogin As Button
    Friend WithEvents TextBoxtotalsale As TextBox
    Friend WithEvents Labeltotalsale As Label
End Class
