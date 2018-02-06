<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.host = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.cnct = New System.Windows.Forms.Button()
        Me.dcnct = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Host:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password:"
        '
        'host
        '
        Me.host.Location = New System.Drawing.Point(80, 14)
        Me.host.Name = "host"
        Me.host.Size = New System.Drawing.Size(314, 20)
        Me.host.TabIndex = 3
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(130, 39)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(265, 20)
        Me.username.TabIndex = 4
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(130, 64)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(265, 20)
        Me.password.TabIndex = 5
        '
        'cnct
        '
        Me.cnct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cnct.Location = New System.Drawing.Point(17, 117)
        Me.cnct.Name = "cnct"
        Me.cnct.Size = New System.Drawing.Size(377, 41)
        Me.cnct.TabIndex = 6
        Me.cnct.Text = "Connect"
        Me.cnct.UseVisualStyleBackColor = True
        '
        'dcnct
        '
        Me.dcnct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dcnct.Location = New System.Drawing.Point(17, 160)
        Me.dcnct.Name = "dcnct"
        Me.dcnct.Size = New System.Drawing.Size(377, 41)
        Me.dcnct.TabIndex = 7
        Me.dcnct.Text = "Disconnect"
        Me.dcnct.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 213)
        Me.Controls.Add(Me.dcnct)
        Me.Controls.Add(Me.cnct)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.host)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VPN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents host As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents cnct As Button
    Friend WithEvents dcnct As Button
End Class
