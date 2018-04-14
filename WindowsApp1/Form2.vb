Imports System
Imports System.Xml
Imports System.IO


Public Class frm_setting

    Private Sub frm_setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_chrome.Text = chrome_loc
        txt_vmbox.Text = vmbox_loc
        txt_ip.Text = ip_admin

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        save(vmname, txt_vmbox.Text, txt_chrome.Text, txt_ip.Text)
        Me.Close()
        frm_control.Refresh()
    End Sub
End Class