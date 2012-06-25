Imports System.Net.NetworkInformation

Public Class Form1

    'Function ejecutar_Shell(ByVal arch_comandos As String, ByVal argumentos As String, ByRef stdOutput As String) As Integer

    '    Try

    '        Dim procID As Integer

    '        Dim newProcCmd As System.Diagnostics.Process = New System.Diagnostics.Process

    '        ' La ejecución del shell se hace en modo "Silencioso" (no se muestra la ventana)

    '        newProcCmd.StartInfo.FileName = Path.GetFullPath(arch_comandos)

    '        newProcCmd.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden

    '        'Asi no muestra la ventana negra

    '        newProcCmd.StartInfo.CreateNoWindow = True

    '        'Para poder manipular la salida indicamos que no se ejecute el shell

    '        newProcCmd.StartInfo.UseShellExecute = False

    '        newProcCmd.StartInfo.Arguments = argumentos 'Le paso los parámetros de ejecución 

    '        'Deseamos manipular la salida del proceso, para ello debemos establecer que se redirija la salida

    '        newProcCmd.StartInfo.RedirectStandardOutput = True

    '        newProcCmd.Start()

    '        procID = newProcCmd.Id

    '        newProcCmd.WaitForExit()



    '        'Debo saber si el proceso termino con exito o fallo

    '        Dim procEC As Integer = -1

    '        If newProcCmd.HasExited Then

    '            procEC = newProcCmd.ExitCode

    '        End If

    '        'Leemos la salida (objeto StreamReader)

    '        Dim sr As System.IO.StreamReader = newProcCmd.StandardOutput

    '        stdOutput = sr.ReadToEnd()

    '        sr.Close()

    '        newProcCmd.Dispose()

    '        Return procEC


    '    Catch ex As Exception
    '        MsgBox(":: Ha ocurrido un error ::" + Chr(13) + Chr(13) + "- No se pudo ejecutar el comando." + Chr(13) + Chr(13) + ex.ToString, MsgBoxStyle.Critical, "Error")
    '    End Try

    'End Function

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Shell(
        'Shell("ping 192.168.1.1 ")

        Dim TR() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()

    End Sub
End Class
