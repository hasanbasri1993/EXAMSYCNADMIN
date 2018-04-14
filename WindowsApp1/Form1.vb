Imports System
Imports System.Xml
Imports System.IO

Public Class frm_control

    Private Results As String
    Private Delegate Sub delUpdate()
    Private Finished As New delUpdate(AddressOf UpdateText)


    Private Sub btn_runvm_Click(sender As Object, e As EventArgs) Handles btn_runvm.Click
        Dim CMDThread As New Threading.Thread(AddressOf CMDAutomate)
        Dim cm = """" + vmbox_loc + "\VBoxManage" + """ startvm " + txt_vmname.Text
        CMDThread.Start(cm)
        btn_stopvm.Enabled = True
        btn_runvm.Enabled = False
        tmr_on.Enabled = True
        save(txt_vmname.Text, vmbox_loc, chrome_loc, ip_admin)
    End Sub

    Private Sub btn_stopvm_Click(sender As Object, e As EventArgs) Handles btn_stopvm.Click
        Dim CMDThread As New Threading.Thread(AddressOf CMDAutomate)
        Dim cm = """" + vmbox_loc + "\VBoxManage" + """ controlvm " + txt_vmname.Text + " acpipowerbutton"
        CMDThread.Start(cm)
        btn_stopvm.Enabled = False
        btn_runvm.Enabled = True
        btn_cek.Enabled = False
        btn_update.Enabled = False
        btn_admin.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists("ExamSycnSetting.xml") Then
            Dim document As XmlReader = New XmlTextReader("ExamSycnSetting.xml")
            While (document.Read())
                Dim type = document.NodeType
                If (type = XmlNodeType.Element) Then
                    If (document.Name = "VMNAME") Then
                        txt_vmname.Text = document.ReadInnerXml.ToString()
                    End If
                    If (document.Name = "Virtualbox") Then
                        vmbox_loc = document.ReadInnerXml.ToString()
                    End If
                    If (document.Name = "Chrome") Then
                        chrome_loc = document.ReadInnerXml.ToString()
                    End If
                    If (document.Name = "IP_ADMIN") Then
                        ip_admin = document.ReadInnerXml.ToString()
                    End If
                End If

            End While
            document.Close()
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_waktu.Text = Now
    End Sub

    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        Dim cm = """" + chrome_loc + """ --incognito --user-data-dir=$(mktemp -d) --kiosk --new-window --allow-running-insecure-content " + ip_admin + "\unbk"
        MsgBox(cm)
        Shell("CMD.exe /c " + cm)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles btn_cekupdate.Click
        Dim CMDThread As New Threading.Thread(AddressOf CMDAutomate)
        Dim cm = "net use \\" + ip_admin + "\unbk Hjve6uly /user:Administrator & pushd \\" + ip_admin + "\unbk & git status"
        CMDThread.Start(cm)
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim CMDThread As New Threading.Thread(AddressOf CMDAutomate)
        Dim cm = "net use \\" + ip_admin + "\unbk Hjve6uly /user:Administrator & pushd \\" + ip_admin + "\unbk & git pull"
        CMDThread.Start(cm)
    End Sub

    Private Sub CMDAutomate(cmds)
        Dim myprocess As New Process
        Dim StartInfo As New System.Diagnostics.ProcessStartInfo
        StartInfo.FileName = "cmd" 'starts cmd window
        StartInfo.RedirectStandardInput = True
        StartInfo.RedirectStandardOutput = True
        StartInfo.UseShellExecute = False 'required to redirect
        StartInfo.CreateNoWindow = True 'creates no cmd window
        myprocess.StartInfo = StartInfo
        myprocess.Start()
        Dim SR As System.IO.StreamReader = myprocess.StandardOutput
        Dim SW As System.IO.StreamWriter = myprocess.StandardInput
        SW.WriteLine(cmds) 'the command you wish to run.....
        SW.WriteLine("exit") 'exits command prompt window
        Results = SR.ReadToEnd  'returns results of the command window
        SW.Close()
        SR.Close()
        'invokes Finished delegate, which updates textbox with the results text
        Invoke(Finished)
    End Sub

    Private Sub UpdateText()
        txt_output.Text = Results
    End Sub

    Private Sub btn_cek_Click(sender As Object, e As EventArgs) Handles btn_cek.Click
        Me.Close()
    End Sub

    Private Sub btn_setting_Click_1(sender As Object, e As EventArgs) Handles btn_setting.Click
        frm_setting.Show()
    End Sub



    Private Sub tmr_on_Tick(sender As Object, e As EventArgs) Handles tmr_on.Tick
        If My.Computer.Network.Ping(ip_admin) Then
            btn_cekupdate.Enabled = True
            btn_update.Enabled = True
            btn_admin.Enabled = True
            tmr_on.Enabled = False
            'txt_output.Text = ip_admin
        End If
    End Sub

    Private Sub ToolStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip2.ItemClicked

    End Sub
End Class
