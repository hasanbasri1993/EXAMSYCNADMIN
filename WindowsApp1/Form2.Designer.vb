<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_setting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_setting))
        Me.txt_vmbox = New System.Windows.Forms.TextBox()
        Me.txt_chrome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_ip = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_vmbox
        '
        Me.txt_vmbox.Location = New System.Drawing.Point(143, 27)
        Me.txt_vmbox.Name = "txt_vmbox"
        Me.txt_vmbox.Size = New System.Drawing.Size(307, 20)
        Me.txt_vmbox.TabIndex = 0
        '
        'txt_chrome
        '
        Me.txt_chrome.Location = New System.Drawing.Point(143, 53)
        Me.txt_chrome.Name = "txt_chrome"
        Me.txt_chrome.Size = New System.Drawing.Size(307, 20)
        Me.txt_chrome.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Virtual Box Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Google Location"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(143, 105)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(306, 33)
        Me.btn_save.TabIndex = 5
        Me.btn_save.Text = "&Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "IP Server VHD"
        '
        'txt_ip
        '
        Me.txt_ip.Location = New System.Drawing.Point(143, 79)
        Me.txt_ip.Name = "txt_ip"
        Me.txt_ip.Size = New System.Drawing.Size(307, 20)
        Me.txt_ip.TabIndex = 6
        '
        'frm_setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 151)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_ip)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_chrome)
        Me.Controls.Add(Me.txt_vmbox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_setting"
        Me.Text = "Setting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_vmbox As TextBox
    Friend WithEvents txt_chrome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_ip As TextBox
End Class
