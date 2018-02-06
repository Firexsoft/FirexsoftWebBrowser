Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cnct_Click(sender As Object, e As EventArgs) Handles cnct.Click
        If Not IO.Directory.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector") Then
            IO.Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector")

        End If

        IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.pbk"), "[VPN]" & vbNewLine & "MEDIA=rastapi" & vbNewLine & "Port=VPN2-0" & vbNewLine & "Device=WAN Miniport (IKEv2)" & vbNewLine & "DEVICE=vpn" & vbNewLine & "PhoneNumber=" & host.Text)
        IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.bat"), "rasdial ""VPN"" " & username.Text & " " & password.Text & " /phonebook:" & """" & System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.pbk" & """")
        Dim connect As System.Diagnostics.Process
        connect = New System.Diagnostics.Process()
        connect.StartInfo.FileName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.bat"
        connect.StartInfo.WindowStyle = ProcessWindowStyle.Normal

        connect.Start()
        connect.WaitForExit()
        cnct.Enabled = False
        dcnct.Enabled = True
    End Sub

    Private Sub dcnct_Click(sender As Object, e As EventArgs) Handles dcnct.Click
        IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\disconnect.bat"), "rasdial/d")
        Dim connect As System.Diagnostics.Process
        connect = New System.Diagnostics.Process()
        connect.StartInfo.FileName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\disconnect.bat"
        connect.StartInfo.WindowStyle = ProcessWindowStyle.Normal

        connect.Start()
        connect.WaitForExit()
        cnct.Enabled = True
        dcnct.Enabled = False
    End Sub
End Class