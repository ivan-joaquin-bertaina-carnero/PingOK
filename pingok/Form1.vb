Imports System.Environment
Imports System.Net

Public Class Form1

    Dim estado As Integer
    Dim hostname As String = Dns.GetHostName()
    Dim dirIP As String = CType(Dns.GetHostByName(hostname).AddressList.GetValue(0), IPAddress).ToString
    Function Obtener_datos_RED()
        hostname = Dns.GetHostName()
        dirIP = CType(Dns.GetHostByName(hostname).AddressList.GetValue(0), IPAddress).ToString
        Return dirIP
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Me.HostnameToolStripMenuItem.Text = hostname
        Me.DirecciónIPToolStripMenuItem.Text = Obtener_datos_RED()

        If My.Computer.Network.IsAvailable Then
            Try
                If My.Computer.Network.Ping("www.google.com", 1000) Then
                    NotifyIcon1.Icon = New Icon("C:\Users\Usuario\Desktop\PruebaDeConexión\íconos\green.ico")
                    If estado Then
                        NotifyIcon1.BalloonTipText = "La prueba de conexión fue satisfactoria, disfrutá de Internet!"
                        NotifyIcon1.BalloonTipTitle = "TODO FUNCIONA OK!!!"
                        NotifyIcon1.ShowBalloonTip(10)
                        estado = 0
                    End If
                Else
                    estado = 0
                    NotifyIcon1.Icon = New Icon("C:\Users\Usuario\Desktop\PruebaDeConexión\íconos\red.ico")
                    If My.Computer.Network.Ping("8.8.8.8", 250) Then
                        NotifyIcon1.BalloonTipText = "Se detectó un problema en los DNS!"
                        NotifyIcon1.BalloonTipTitle = "ALGO ANDA MAL!!!"
                        NotifyIcon1.ShowBalloonTip(10)
                        estado = 1
                    Else
                        NotifyIcon1.BalloonTipText = "Internet parece tener microcortes / perdida de paquetes!"
                        NotifyIcon1.BalloonTipTitle = "ALGO ANDA MAL!!!"
                        NotifyIcon1.ShowBalloonTip(10)
                        estado = 1
                    End If
                End If
            Catch ex As Exception
                NotifyIcon1.Icon = New Icon("C:\Users\Usuario\Desktop\PruebaDeConexión\íconos\red.ico")
                NotifyIcon1.BalloonTipText = "Problema en el MODEM del ISP!"
                NotifyIcon1.BalloonTipTitle = "NO HAY CONEXIÓN A INTERNET!!!"
                NotifyIcon1.ShowBalloonTip(10)
                estado = 1
            End Try

        Else
            NotifyIcon1.Icon = New Icon("C:\Users\Usuario\Desktop\PruebaDeConexión\íconos\red.ico")
            NotifyIcon1.BalloonTipText = "No hay ninguna conexion de red activa!!!"
            NotifyIcon1.BalloonTipTitle = "PROBLEMA GRAVE!!!"
            NotifyIcon1.ShowBalloonTip(10)
            estado = 1
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        NotifyIcon1.BalloonTipText = "Comprobando conexión a Internet!!!"
        NotifyIcon1.BalloonTipTitle = "INFORMACIÓN!!!"
        NotifyIcon1.ShowBalloonTip(10)
        estado = 1
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
