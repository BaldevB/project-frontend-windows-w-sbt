<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherRegisterInputInstIdForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbInstId1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbInstId2 = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.bwTeacherRegister = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 33)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Teacher - Register"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(239, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Enter your Institution code"
        '
        'tbInstId1
        '
        Me.tbInstId1.Font = New System.Drawing.Font("Bahnschrift", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInstId1.Location = New System.Drawing.Point(230, 256)
        Me.tbInstId1.MaxLength = 3
        Me.tbInstId1.Name = "tbInstId1"
        Me.tbInstId1.Size = New System.Drawing.Size(69, 42)
        Me.tbInstId1.TabIndex = 19
        Me.tbInstId1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(305, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 33)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "-"
        '
        'tbInstId2
        '
        Me.tbInstId2.Font = New System.Drawing.Font("Bahnschrift", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInstId2.Location = New System.Drawing.Point(339, 256)
        Me.tbInstId2.MaxLength = 3
        Me.tbInstId2.Name = "tbInstId2"
        Me.tbInstId2.Size = New System.Drawing.Size(69, 42)
        Me.tbInstId2.TabIndex = 21
        Me.tbInstId2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(258, 304)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(122, 31)
        Me.btnRegister.TabIndex = 24
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'bwTeacherRegister
        '
        '
        'TeacherRegisterInputInstIdForm
        '
        Me.AcceptButton = Me.btnRegister
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 571)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.tbInstId2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbInstId1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "TeacherRegisterInputInstIdForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project - Register as a Teacher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbInstId1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbInstId2 As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents bwTeacherRegister As System.ComponentModel.BackgroundWorker
End Class
