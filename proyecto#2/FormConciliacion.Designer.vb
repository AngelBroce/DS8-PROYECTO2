<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConciliacion
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
        Friend WithEvents MenuStrip1 As MenuStrip
        Friend WithEvents mnuCheques As ToolStripMenuItem
        Friend WithEvents mnuDepositos As ToolStripMenuItem
        Friend WithEvents mnuConciliacion As ToolStripMenuItem
        Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
        Friend WithEvents mnuSalir As ToolStripMenuItem

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

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        mnuCheques = New ToolStripMenuItem()
        mnuDepositos = New ToolStripMenuItem()
        mnuConciliacion = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        mnuSalir = New ToolStripMenuItem()
        GroupBox1 = New GroupBox()
        Label17 = New Label()
        Label16 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        TextBox13 = New TextBox()
        TextBox12 = New TextBox()
        TextBox11 = New TextBox()
        TextBox10 = New TextBox()
        Label12 = New Label()
        Label11 = New Label()
        TextBox9 = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        TextBox8 = New TextBox()
        TextBox7 = New TextBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label1 = New Label()
        Button1 = New Button()
        Label18 = New Label()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(18, 18)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuCheques, mnuDepositos, mnuConciliacion, ToolStripSeparator1, mnuSalir})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.Size = New Size(832, 30)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "menuStrip1"
        ' 
        ' mnuCheques
        ' 
        mnuCheques.Name = "mnuCheques"
        mnuCheques.Size = New Size(79, 24)
        mnuCheques.Text = "Cheques"
        ' 
        ' mnuDepositos
        ' 
        mnuDepositos.Name = "mnuDepositos"
        mnuDepositos.Size = New Size(90, 24)
        mnuDepositos.Text = "Depósitos"
        ' 
        ' mnuConciliacion
        ' 
        mnuConciliacion.Name = "mnuConciliacion"
        mnuConciliacion.Size = New Size(104, 24)
        mnuConciliacion.Text = "Conciliación"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 24)
        ' 
        ' mnuSalir
        ' 
        mnuSalir.Name = "mnuSalir"
        mnuSalir.Size = New Size(52, 24)
        mnuSalir.Text = "Salir"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label18)
        GroupBox1.Controls.Add(Label17)
        GroupBox1.Controls.Add(Label16)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(TextBox13)
        GroupBox1.Controls.Add(TextBox12)
        GroupBox1.Controls.Add(TextBox11)
        GroupBox1.Controls.Add(TextBox10)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(TextBox9)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBox8)
        GroupBox1.Controls.Add(TextBox7)
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(35, 159)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(763, 645)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(46, 256)
        Label17.Name = "Label17"
        Label17.Size = New Size(76, 20)
        Label17.TabIndex = 28
        Label17.Text = "SUBTOTAL"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(46, 611)
        Label16.Name = "Label16"
        Label16.Size = New Size(284, 20)
        Label16.TabIndex = 27
        Label16.Text = "SALDO CONCILIADO IGUAL A BANCO  31"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(101, 513)
        Label13.Name = "Label13"
        Label13.Size = New Size(162, 20)
        Label13.TabIndex = 26
        Label13.Text = "Cheques en Circulación"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(101, 475)
        Label14.Name = "Label14"
        Label14.Size = New Size(152, 20)
        Label14.TabIndex = 25
        Label14.Text = "Depósitos en Transito"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(62, 475)
        Label15.Name = "Label15"
        Label15.Size = New Size(39, 20)
        Label15.TabIndex = 24
        Label15.Text = "Más:"
        ' 
        ' TextBox13
        ' 
        TextBox13.Location = New Point(442, 607)
        TextBox13.Margin = New Padding(3, 4, 3, 4)
        TextBox13.Name = "TextBox13"
        TextBox13.ReadOnly = True
        TextBox13.Size = New Size(121, 27)
        TextBox13.TabIndex = 23
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(442, 548)
        TextBox12.Margin = New Padding(3, 4, 3, 4)
        TextBox12.Name = "TextBox12"
        TextBox12.ReadOnly = True
        TextBox12.Size = New Size(121, 27)
        TextBox12.TabIndex = 22
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(320, 509)
        TextBox11.Margin = New Padding(3, 4, 3, 4)
        TextBox11.Name = "TextBox11"
        TextBox11.ReadOnly = True
        TextBox11.Size = New Size(121, 27)
        TextBox11.TabIndex = 21
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(320, 471)
        TextBox10.Margin = New Padding(3, 4, 3, 4)
        TextBox10.Name = "TextBox10"
        TextBox10.ReadOnly = True
        TextBox10.Size = New Size(121, 27)
        TextBox10.TabIndex = 20
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(46, 436)
        Label12.Name = "Label12"
        Label12.Size = New Size(174, 20)
        Label12.TabIndex = 19
        Label12.Text = "SALDO EN BANCO AL 31"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(46, 376)
        Label11.Name = "Label11"
        Label11.Size = New Size(291, 20)
        Label11.TabIndex = 18
        Label11.Text = "SALDO CONCILIADO SEGÚN LIBROS AL 31"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(442, 372)
        TextBox9.Margin = New Padding(3, 4, 3, 4)
        TextBox9.Name = "TextBox9"
        TextBox9.ReadOnly = True
        TextBox9.Size = New Size(121, 27)
        TextBox9.TabIndex = 17
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(101, 299)
        Label10.Name = "Label10"
        Label10.Size = New Size(120, 20)
        Label10.TabIndex = 16
        Label10.Text = "Cheques Girados"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(46, 299)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 20)
        Label9.TabIndex = 15
        Label9.Text = "Menos:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(101, 183)
        Label8.Name = "Label8"
        Label8.Size = New Size(131, 20)
        Label8.TabIndex = 14
        Label8.Text = "Cheques Anulados"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(101, 144)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 20)
        Label7.TabIndex = 13
        Label7.Text = "Depósitos"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(57, 144)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 20)
        Label6.TabIndex = 12
        Label6.Text = "Más:"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(442, 432)
        TextBox8.Margin = New Padding(3, 4, 3, 4)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(121, 27)
        TextBox8.TabIndex = 11
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(442, 333)
        TextBox7.Margin = New Padding(3, 4, 3, 4)
        TextBox7.Name = "TextBox7"
        TextBox7.ReadOnly = True
        TextBox7.Size = New Size(121, 27)
        TextBox7.TabIndex = 10
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(320, 295)
        TextBox6.Margin = New Padding(3, 4, 3, 4)
        TextBox6.Name = "TextBox6"
        TextBox6.ReadOnly = True
        TextBox6.Size = New Size(121, 27)
        TextBox6.TabIndex = 9
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(442, 256)
        TextBox5.Margin = New Padding(3, 4, 3, 4)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(121, 27)
        TextBox5.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(442, 217)
        TextBox4.Margin = New Padding(3, 4, 3, 4)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(121, 27)
        TextBox4.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(320, 179)
        TextBox3.Margin = New Padding(3, 4, 3, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(121, 27)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(320, 140)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(121, 27)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(442, 101)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(121, 27)
        TextBox1.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(46, 101)
        Label5.Name = "Label5"
        Label5.Size = New Size(192, 20)
        Label5.TabIndex = 3
        Label5.Text = "SALDO SEGÚN LIBRO AL 31"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(208, 65)
        Label4.Name = "Label4"
        Label4.Size = New Size(191, 20)
        Label4.TabIndex = 2
        Label4.Text = "Correspondiente al mes de "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(247, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(185, 20)
        Label3.TabIndex = 1
        Label3.Text = "CONCILIACIÓN BANCARIA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(287, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 20)
        Label2.TabIndex = 0
        Label2.Text = "EMPRESA XYZ"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(35, 76)
        DateTimePicker1.Margin = New Padding(3, 4, 3, 4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(266, 27)
        DateTimePicker1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 20)
        Label1.TabIndex = 4
        Label1.Text = "Seleccione el mes y año que desea:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(355, 76)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 31)
        Button1.TabIndex = 5
        Button1.Text = "Imprimir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(46, 512)
        Label18.Name = "Label18"
        Label18.Size = New Size(56, 20)
        Label18.TabIndex = 29
        Label18.Text = "Menos:"
        ' 
        ' FormConciliacion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(832, 820)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker1)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormConciliacion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Conciliación"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
End Class
