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
        If estado Then
            Me.Hide()
        End If

        Me.HostnameToolStripMenuItem.Text = hostname
        Me.DirecciónIPToolStripMenuItem.Text = Obtener_datos_RED()

        If My.Computer.Network.IsAvailable Then
            Try
                If My.Computer.Network.Ping("www.google.com", 1000) Then
                    NotifyIcon1.Icon = New Icon("C:\PingOK\iconos\green.ico")
                    If estado Then
                        NotifyIcon1.BalloonTipText = "La prueba de conexión fue satisfactoria, disfrutá de Internet!"
                        NotifyIcon1.BalloonTipTitle = "TODO FUNCIONA OK!!!"
                        If Notificaciones.Checked Then
                            NotifyIcon1.ShowBalloonTip(10)
                        End If

                        estado = 0
                        ListBox1.Items.Add(Date.Now + " -> TODO FUNCIONA OK!!!")
                    End If
                Else
                    estado = 0
                    NotifyIcon1.Icon = New Icon("C:\PingOK\iconos\red.ico")
                    If My.Computer.Network.Ping("8.8.8.8", 250) Then
                        NotifyIcon1.BalloonTipText = "Se detectó un problema en los DNS!"
                        NotifyIcon1.BalloonTipTitle = "ALGO ANDA MAL!!!"
                        If Notificaciones.Checked Then
                            NotifyIcon1.ShowBalloonTip(10)
                        End If
                        estado = 1
                        ListBox1.Items.Add(Date.Now + " -> ALGO ANDA MAL!!! - Se detectó un problema en los DNS!")
                    Else
                        NotifyIcon1.BalloonTipText = "Internet parece tener microcortes / perdida de paquetes!"
                        NotifyIcon1.BalloonTipTitle = "ALGO ANDA MAL!!!"
                        If Notificaciones.Checked Then
                            NotifyIcon1.ShowBalloonTip(10)
                        End If
                        estado = 1
                        ListBox1.Items.Add(Date.Now + " -> ALGO ANDA MAL!!! - Internet parece tener microcortes / perdida de paquetes!")
                    End If
                End If
            Catch ex As Exception
                NotifyIcon1.Icon = New Icon("C:\PingOK\iconos\red.ico")
                NotifyIcon1.BalloonTipText = "Problema en el MODEM del ISP!"
                NotifyIcon1.BalloonTipTitle = "NO HAY CONEXIÓN A INTERNET!!!"
                If Notificaciones.Checked Then
                    NotifyIcon1.ShowBalloonTip(10)
                End If
                estado = 1
                ListBox1.Items.Add(Date.Now + " -> NO HAY CONEXIÓN A INTERNET!!! - Problema en el MODEM del ISP!")
                If BeepAutomático.Checked Then
                    System.Media.SystemSounds.Beep.Play()
                End If

            End Try

        Else
            NotifyIcon1.Icon = New Icon("C:\PingOK\iconos\red.ico")
            NotifyIcon1.BalloonTipText = "No hay ninguna conexion de red activa!!!"
            NotifyIcon1.BalloonTipTitle = "PROBLEMA GRAVE!!!"
            If Notificaciones.Checked Then
                NotifyIcon1.ShowBalloonTip(10)
            End If
            estado = 1
            ListBox1.Items.Add(Date.Now + " -> PROBLEMA GRAVE!!! - No hay ninguna conexion de red activa!!!")
            If BeepAutomático.Checked Then
                System.Media.SystemSounds.Beep.Play()
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Add(Date.Now + " -> PingOK iniciado.")
        NotifyIcon1.BalloonTipText = "Comprobando conexión a Internet!!!"
        NotifyIcon1.BalloonTipTitle = "INFORMACIÓN!!!"
        If Notificaciones.Checked Then
            NotifyIcon1.ShowBalloonTip(10)
        End If
        estado = 1

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub VelocidadDeInternetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VelocidadDeInternetToolStripMenuItem.Click
        Process.Start("Chrome", "fast.com")
    End Sub

    Private Sub TracerouteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TracerouteToolStripMenuItem.Click
        Shell("tracert www.google.com", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub WwwgooglecomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WwwgooglecomToolStripMenuItem.Click
        Shell("ping www.google.com -t", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub RenovarIPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenovarIPToolStripMenuItem.Click
        Shell("ipconfig /release", AppWinStyle.Hide)
        System.Threading.Thread.Sleep(3000)
        Shell("ipconfig /renew", AppWinStyle.Hide)
    End Sub

    Private Sub CerrarNavegadoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarNavegadoresToolStripMenuItem.Click
        Shell("taskkill /IM chrome.exe", AppWinStyle.Hide)
        System.Threading.Thread.Sleep(100)
        Shell("taskkill /IM iexplore.exe", AppWinStyle.Hide)
        System.Threading.Thread.Sleep(100)
        Shell("taskkill /IM firefox.exe", AppWinStyle.Hide)
        System.Threading.Thread.Sleep(100)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Enabled = True
        Me.Hide()
    End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        Timer1.Enabled = False
        Me.Show()
    End Sub


    Private Sub PingAutomático_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PingAutomático.Click
        If PingAutomático.Checked Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub


End Class
