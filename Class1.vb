Imports Microsoft.Win32
Imports System
Imports System.ServiceProcess
Imports System.IO
Imports System.Threading
Imports System.Diagnostics.Eventing.Reader
Imports System.Management

Module Module1
    Public Sub startService(ByVal PC As String)
        Dim obj As ManagementObject
        Dim inParam, outParam As ManagementBaseObject
        Dim result As Integer
        Dim serviceController As ServiceController
        obj = New ManagementObject("\\" & PC & "\root\cimv2:Win32_Service.Name='RemoteRegistry'")

        'Change the Start Mode to Manual
        If obj("StartMode").ToString = "Disabled" Then
            inParam = obj.GetMethodParameters("ChangeStartMode")
            inParam("StartMode") = "Manual"
            outParam = obj.InvokeMethod("ChangeStartMode", inParam, Nothing)
            result = Convert.ToInt32(outParam("returnValue"))

            If result <> 0 Then
                Throw New Exception("ChangeStartMode method error " & result)
            End If
        End If

        'Start the service
        If obj("State").ToString <> "Running" Then
            serviceController = New ServiceController("RemoteRegistry", PC)
            serviceController.Start()
            serviceController.WaitForStatus(ServiceControllerStatus.Running) 'To prevent not running stopService
        End If
    End Sub

    Public Sub editRegistry(ByVal PC As String)
        Dim inputRegistry As RegistryKey
        inputRegistry = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, PC)
        'IPChecksumOffloadIPv4 location
        inputRegistry = inputRegistry.OpenSubKey("SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0001", True)
        inputRegistry.SetValue("*IPChecksumOffloadIPv4", "0")
    End Sub

    Public Sub stopService(ByVal PC As String)
        Dim obj As ManagementObject
        Dim inParam, outParam As ManagementBaseObject
        Dim result As Integer
        Dim serviceController As ServiceController
        obj = New ManagementObject("\\" & PC & "\root\cimv2:Win32_Service.Name='RemoteRegistry'")

        'Change the Start Mode to Disabled
        If obj("StartMode").ToString = "Manual" Then
            inParam = obj.GetMethodParameters("ChangeStartMode")
            inParam("StartMode") = "Disabled"
            outParam = obj.InvokeMethod("ChangeStartMode", inParam, Nothing)
            result = Convert.ToInt32(outParam("returnValue"))

            If result <> 0 Then
                Throw New Exception("ChangeStartMode method error " & result)
            End If
        End If

        'Change status to stop
        serviceController = New ServiceController("RemoteRegistry", PC)
        serviceController.Stop()
        serviceController.WaitForStatus(ServiceControllerStatus.Stopped)
    End Sub
End Module