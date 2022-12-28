Imports Microsoft.Win32
Public Class Form1
    Private Sub buChangeRegistry_Click(sender As Object, e As EventArgs) Handles buChangeRegistry.Click
        'Dim strPcName As String = tbPcName.Text 'remote input control
        Dim inputRegistry As RegistryKey

        'local PC
        inputRegistry = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0001", True)

        'Below 2 for remote pc, but remoteRegistry in service.msc has to be enabled.
        'inputRegistry = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, "AMMVWCZD81T3-L")
        'inputRegistry = inputRegistry.OpenSubKey("SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0001", True)
        inputRegistry.SetValue("*IPChecksumOffloadIPv4", "0")
    End Sub
End Class
