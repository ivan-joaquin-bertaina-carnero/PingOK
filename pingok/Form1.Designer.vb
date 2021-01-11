<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PingOKV10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PingAutomático = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeepAutomático = New System.Windows.Forms.ToolStripMenuItem()
        Me.Notificaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.HostnameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirecciónIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PruebasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VelocidadDeInternetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WwwgooglecomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TracerouteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RenovarIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarNavegadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "PingOK v1.0"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PingOKV10ToolStripMenuItem, Me.ToolStripMenuItem2, Me.PingAutomático, Me.BeepAutomático, Me.Notificaciones, Me.ToolStripMenuItem5, Me.HostnameToolStripMenuItem, Me.DirecciónIPToolStripMenuItem, Me.ToolStripMenuItem1, Me.OpcionesToolStripMenuItem, Me.ToolStripMenuItem4, Me.SalirToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(167, 204)
        '
        'PingOKV10ToolStripMenuItem
        '
        Me.PingOKV10ToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.PingOKV10ToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PingOKV10ToolStripMenuItem.Name = "PingOKV10ToolStripMenuItem"
        Me.PingOKV10ToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.PingOKV10ToolStripMenuItem.Text = "PingOK v1.0"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(163, 6)
        '
        'PingAutomático
        '
        Me.PingAutomático.Checked = True
        Me.PingAutomático.CheckOnClick = True
        Me.PingAutomático.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PingAutomático.Name = "PingAutomático"
        Me.PingAutomático.Size = New System.Drawing.Size(166, 22)
        Me.PingAutomático.Text = "Ping Automático"
        '
        'BeepAutomático
        '
        Me.BeepAutomático.Checked = True
        Me.BeepAutomático.CheckOnClick = True
        Me.BeepAutomático.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BeepAutomático.Name = "BeepAutomático"
        Me.BeepAutomático.Size = New System.Drawing.Size(166, 22)
        Me.BeepAutomático.Text = "Beep Automático"
        '
        'Notificaciones
        '
        Me.Notificaciones.Checked = True
        Me.Notificaciones.CheckOnClick = True
        Me.Notificaciones.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Notificaciones.Name = "Notificaciones"
        Me.Notificaciones.Size = New System.Drawing.Size(166, 22)
        Me.Notificaciones.Text = "Notificaciones"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(163, 6)
        '
        'HostnameToolStripMenuItem
        '
        Me.HostnameToolStripMenuItem.Name = "HostnameToolStripMenuItem"
        Me.HostnameToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.HostnameToolStripMenuItem.Text = "hostname"
        '
        'DirecciónIPToolStripMenuItem
        '
        Me.DirecciónIPToolStripMenuItem.Name = "DirecciónIPToolStripMenuItem"
        Me.DirecciónIPToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.DirecciónIPToolStripMenuItem.Text = "dirección IP"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(163, 6)
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PruebasToolStripMenuItem, Me.ToolStripMenuItem3, Me.RenovarIPToolStripMenuItem, Me.CerrarNavegadoresToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'PruebasToolStripMenuItem
        '
        Me.PruebasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VelocidadDeInternetToolStripMenuItem, Me.WwwgooglecomToolStripMenuItem, Me.TracerouteToolStripMenuItem})
        Me.PruebasToolStripMenuItem.Name = "PruebasToolStripMenuItem"
        Me.PruebasToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.PruebasToolStripMenuItem.Text = "Pruebas específicas"
        '
        'VelocidadDeInternetToolStripMenuItem
        '
        Me.VelocidadDeInternetToolStripMenuItem.Name = "VelocidadDeInternetToolStripMenuItem"
        Me.VelocidadDeInternetToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.VelocidadDeInternetToolStripMenuItem.Text = "Velocidad de internet"
        '
        'WwwgooglecomToolStripMenuItem
        '
        Me.WwwgooglecomToolStripMenuItem.Name = "WwwgooglecomToolStripMenuItem"
        Me.WwwgooglecomToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.WwwgooglecomToolStripMenuItem.Text = "-> PING (www.google.com)"
        '
        'TracerouteToolStripMenuItem
        '
        Me.TracerouteToolStripMenuItem.Name = "TracerouteToolStripMenuItem"
        Me.TracerouteToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.TracerouteToolStripMenuItem.Text = "-> TRACERT (www.google.com)"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(202, 6)
        '
        'RenovarIPToolStripMenuItem
        '
        Me.RenovarIPToolStripMenuItem.Name = "RenovarIPToolStripMenuItem"
        Me.RenovarIPToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.RenovarIPToolStripMenuItem.Text = "Renovar dirección IP"
        '
        'CerrarNavegadoresToolStripMenuItem
        '
        Me.CerrarNavegadoresToolStripMenuItem.Name = "CerrarNavegadoresToolStripMenuItem"
        Me.CerrarNavegadoresToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.CerrarNavegadoresToolStripMenuItem.Text = "Cerrar Navegadores Web"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1500
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(624, 308)
        Me.ListBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(306, 52)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "EXPORTAR HISTORIAL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(330, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(306, 52)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "CERRAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(163, 6)
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Opacity = 0.8R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PingOK"
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HostnameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DirecciónIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PingOKV10ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PruebasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VelocidadDeInternetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WwwgooglecomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TracerouteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RenovarIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarNavegadoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PingAutomático As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeepAutomático As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Notificaciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator

End Class
