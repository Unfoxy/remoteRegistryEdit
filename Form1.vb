Imports Microsoft.Win32
Imports System
Imports System.ServiceProcess
Imports System.IO
Imports System.Threading
Imports System.Net.NetworkInformation

Public Class Form1
    Private Sub buChangeRegistry_Click(sender As Object, e As EventArgs) Handles buChangeRegistry.Click
        Dim pc As String = tbPcName.Text
        Try
            startService(pc)
            editRegistry(pc)
            stopService(pc)
            MessageBox.Show(pc.ToUpper & " registry edit success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Invalid PC name: " & "'" & pc & "'" & vbCrLf & "or " & "'" & pc & "'" & " is Offline", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
