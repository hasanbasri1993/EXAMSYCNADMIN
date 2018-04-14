<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_control
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_control))
        Me.btn_runvm = New System.Windows.Forms.Button()
        Me.txt_vmname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_stopvm = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_admin = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lbl_waktu = New System.Windows.Forms.ToolStripLabel()
        Me.btn_update = New System.Windows.Forms.ToolStripButton()
        Me.btn_cekupdate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btn_cek = New System.Windows.Forms.ToolStripButton()
        Me.btn_setting = New System.Windows.Forms.ToolStripButton()
        Me.txt_output = New System.Windows.Forms.TextBox()
        Me.tmr_on = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_runvm
        '
        Me.btn_runvm.Location = New System.Drawing.Point(172, 29)
        Me.btn_runvm.Name = "btn_runvm"
        Me.btn_runvm.Size = New System.Drawing.Size(85, 20)
        Me.btn_runvm.TabIndex = 0
        Me.btn_runvm.Text = "&START"
        Me.btn_runvm.UseVisualStyleBackColor = True
        '
        'txt_vmname
        '
        Me.txt_vmname.Location = New System.Drawing.Point(41, 29)
        Me.txt_vmname.Name = "txt_vmname"
        Me.txt_vmname.Size = New System.Drawing.Size(125, 20)
        Me.txt_vmname.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "VM"
        '
        'btn_stopvm
        '
        Me.btn_stopvm.Enabled = False
        Me.btn_stopvm.Location = New System.Drawing.Point(263, 29)
        Me.btn_stopvm.Name = "btn_stopvm"
        Me.btn_stopvm.Size = New System.Drawing.Size(85, 20)
        Me.btn_stopvm.TabIndex = 12
        Me.btn_stopvm.Text = "STOP"
        Me.btn_stopvm.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btn_admin
        '
        Me.btn_admin.Enabled = False
        Me.btn_admin.Location = New System.Drawing.Point(563, 26)
        Me.btn_admin.Name = "btn_admin"
        Me.btn_admin.Size = New System.Drawing.Size(176, 23)
        Me.btn_admin.TabIndex = 14
        Me.btn_admin.Text = "Open CBT Admin"
        Me.btn_admin.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_waktu, Me.btn_update, Me.btn_cekupdate})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 544)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(753, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lbl_waktu
        '
        Me.lbl_waktu.Name = "lbl_waktu"
        Me.lbl_waktu.Size = New System.Drawing.Size(0, 22)
        '
        'btn_update
        '
        Me.btn_update.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_update.Enabled = False
        Me.btn_update.Image = CType(resources.GetObject("btn_update.Image"), System.Drawing.Image)
        Me.btn_update.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(49, 22)
        Me.btn_update.Text = "&Update"
        '
        'btn_cekupdate
        '
        Me.btn_cekupdate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_cekupdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_cekupdate.Enabled = False
        Me.btn_cekupdate.Image = CType(resources.GetObject("btn_cekupdate.Image"), System.Drawing.Image)
        Me.btn_cekupdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cekupdate.Name = "btn_cekupdate"
        Me.btn_cekupdate.Size = New System.Drawing.Size(72, 22)
        Me.btn_cekupdate.Text = "&Cek Update"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_cek, Me.btn_setting})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(753, 25)
        Me.ToolStrip2.TabIndex = 15
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btn_cek
        '
        Me.btn_cek.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_cek.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cek.Name = "btn_cek"
        Me.btn_cek.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btn_cek.RightToLeftAutoMirrorImage = True
        Me.btn_cek.Size = New System.Drawing.Size(29, 22)
        Me.btn_cek.Text = "&Exit"
        Me.btn_cek.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'btn_setting
        '
        Me.btn_setting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_setting.Image = CType(resources.GetObject("btn_setting.Image"), System.Drawing.Image)
        Me.btn_setting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_setting.Name = "btn_setting"
        Me.btn_setting.Size = New System.Drawing.Size(48, 22)
        Me.btn_setting.Text = "&Setting"
        '
        'txt_output
        '
        Me.txt_output.Location = New System.Drawing.Point(12, 78)
        Me.txt_output.Multiline = True
        Me.txt_output.Name = "txt_output"
        Me.txt_output.Size = New System.Drawing.Size(726, 444)
        Me.txt_output.TabIndex = 16
        '
        'tmr_on
        '
        Me.tmr_on.Interval = 1000
        '
        'frm_control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 569)
        Me.Controls.Add(Me.txt_output)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.btn_admin)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btn_stopvm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_vmname)
        Me.Controls.Add(Me.btn_runvm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_control"
        Me.Text = "ExamBroswer Admin - CBT NIHAI"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_runvm As Button
    Friend WithEvents txt_vmname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_stopvm As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_admin As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents lbl_waktu As ToolStripLabel
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents btn_cek As ToolStripButton
    Friend WithEvents btn_cekupdate As ToolStripButton
    Friend WithEvents txt_output As TextBox
    Friend WithEvents btn_setting As ToolStripButton
    Friend WithEvents btn_update As ToolStripButton
    Friend WithEvents tmr_on As Timer
End Class
