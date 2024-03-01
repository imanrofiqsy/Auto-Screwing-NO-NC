<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DateTime = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_curr_time = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.rtb_setting = New System.Windows.Forms.RichTextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_disconnect_plc_nc = New System.Windows.Forms.Button()
        Me.btn_connect_plc_nc = New System.Windows.Forms.Button()
        Me.txt_port_plc_nc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_ip_plc_nc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_plc_status = New System.Windows.Forms.Label()
        Me.btn_disconnect_plc_no = New System.Windows.Forms.Button()
        Me.btn_connect_plc_no = New System.Windows.Forms.Button()
        Me.txt_Port_PLC_NO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_IP_PLC_NO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.pb_status_mc = New System.Windows.Forms.PictureBox()
        Me.pb_logo = New System.Windows.Forms.PictureBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.pb_status_bar = New System.Windows.Forms.PictureBox()
        Me.txt_database = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_hostname = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pb_status_mc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_status_bar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTime
        '
        Me.DateTime.Enabled = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkRed
        Me.TextBox1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(12, 121)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1326, 30)
        Me.TextBox1.TabIndex = 85
        Me.TextBox1.Text = "ALARM : . . . . . . . . "
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.LimeGreen
        Me.lbl_date.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.White
        Me.lbl_date.Location = New System.Drawing.Point(788, 64)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(124, 31)
        Me.lbl_date.TabIndex = 82
        Me.lbl_date.Text = "31-12-2000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LimeGreen
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(435, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 31)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "STOPPED"
        '
        'lbl_curr_time
        '
        Me.lbl_curr_time.AutoSize = True
        Me.lbl_curr_time.BackColor = System.Drawing.Color.LimeGreen
        Me.lbl_curr_time.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_curr_time.ForeColor = System.Drawing.Color.White
        Me.lbl_curr_time.Location = New System.Drawing.Point(812, 29)
        Me.lbl_curr_time.Name = "lbl_curr_time"
        Me.lbl_curr_time.Size = New System.Drawing.Size(100, 31)
        Me.lbl_curr_time.TabIndex = 80
        Me.lbl_curr_time.Text = "23:59:59"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LimeGreen
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(435, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 31)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "MANUAL"
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(1192, 20)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(146, 75)
        Me.lbl_user.TabIndex = 78
        Me.lbl_user.Text = "ENG"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(138, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1200, 546)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.rtb_setting)
        Me.GroupBox7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(76, 320)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(418, 178)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Status"
        '
        'rtb_setting
        '
        Me.rtb_setting.Location = New System.Drawing.Point(8, 25)
        Me.rtb_setting.Name = "rtb_setting"
        Me.rtb_setting.Size = New System.Drawing.Size(402, 138)
        Me.rtb_setting.TabIndex = 0
        Me.rtb_setting.Text = ""
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txt_database)
        Me.GroupBox6.Controls.Add(Me.txt_username)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.txt_password)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.txt_hostname)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(712, 88)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(247, 186)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Database"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Controls.Add(Me.Button6)
        Me.GroupBox5.Controls.Add(Me.TextBox6)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.TextBox7)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(500, 88)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(206, 186)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Instrument"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.DarkRed
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(10, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(179, 23)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Closed"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(101, 107)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(88, 34)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(10, 107)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 34)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Open"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(62, 65)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(127, 26)
        Me.TextBox6.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Port"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(62, 33)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(127, 26)
        Me.TextBox7.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 20)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Baud"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.btn_disconnect_plc_nc)
        Me.GroupBox3.Controls.Add(Me.btn_connect_plc_nc)
        Me.GroupBox3.Controls.Add(Me.txt_port_plc_nc)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txt_ip_plc_nc)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(288, 88)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(206, 186)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PLC NC"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DarkRed
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(10, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Disconnected"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_disconnect_plc_nc
        '
        Me.btn_disconnect_plc_nc.Location = New System.Drawing.Point(101, 107)
        Me.btn_disconnect_plc_nc.Name = "btn_disconnect_plc_nc"
        Me.btn_disconnect_plc_nc.Size = New System.Drawing.Size(88, 34)
        Me.btn_disconnect_plc_nc.TabIndex = 2
        Me.btn_disconnect_plc_nc.Text = "Disconnect"
        Me.btn_disconnect_plc_nc.UseVisualStyleBackColor = True
        '
        'btn_connect_plc_nc
        '
        Me.btn_connect_plc_nc.Location = New System.Drawing.Point(10, 107)
        Me.btn_connect_plc_nc.Name = "btn_connect_plc_nc"
        Me.btn_connect_plc_nc.Size = New System.Drawing.Size(75, 34)
        Me.btn_connect_plc_nc.TabIndex = 2
        Me.btn_connect_plc_nc.Text = "Connect"
        Me.btn_connect_plc_nc.UseVisualStyleBackColor = True
        '
        'txt_port_plc_nc
        '
        Me.txt_port_plc_nc.Location = New System.Drawing.Point(62, 65)
        Me.txt_port_plc_nc.Name = "txt_port_plc_nc"
        Me.txt_port_plc_nc.Size = New System.Drawing.Size(127, 26)
        Me.txt_port_plc_nc.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Port"
        '
        'txt_ip_plc_nc
        '
        Me.txt_ip_plc_nc.Location = New System.Drawing.Point(62, 33)
        Me.txt_ip_plc_nc.Name = "txt_ip_plc_nc"
        Me.txt_ip_plc_nc.Size = New System.Drawing.Size(127, 26)
        Me.txt_ip_plc_nc.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "IP"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_plc_status)
        Me.GroupBox2.Controls.Add(Me.btn_disconnect_plc_no)
        Me.GroupBox2.Controls.Add(Me.btn_connect_plc_no)
        Me.GroupBox2.Controls.Add(Me.txt_Port_PLC_NO)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_IP_PLC_NO)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(76, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(206, 186)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PLC NO"
        '
        'lbl_plc_status
        '
        Me.lbl_plc_status.BackColor = System.Drawing.Color.DarkRed
        Me.lbl_plc_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_plc_status.ForeColor = System.Drawing.Color.White
        Me.lbl_plc_status.Location = New System.Drawing.Point(10, 153)
        Me.lbl_plc_status.Name = "lbl_plc_status"
        Me.lbl_plc_status.Size = New System.Drawing.Size(179, 23)
        Me.lbl_plc_status.TabIndex = 3
        Me.lbl_plc_status.Text = "Disconnected"
        Me.lbl_plc_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_disconnect_plc_no
        '
        Me.btn_disconnect_plc_no.Location = New System.Drawing.Point(101, 107)
        Me.btn_disconnect_plc_no.Name = "btn_disconnect_plc_no"
        Me.btn_disconnect_plc_no.Size = New System.Drawing.Size(88, 34)
        Me.btn_disconnect_plc_no.TabIndex = 2
        Me.btn_disconnect_plc_no.Text = "Disconnect"
        Me.btn_disconnect_plc_no.UseVisualStyleBackColor = True
        '
        'btn_connect_plc_no
        '
        Me.btn_connect_plc_no.Location = New System.Drawing.Point(10, 107)
        Me.btn_connect_plc_no.Name = "btn_connect_plc_no"
        Me.btn_connect_plc_no.Size = New System.Drawing.Size(75, 34)
        Me.btn_connect_plc_no.TabIndex = 2
        Me.btn_connect_plc_no.Text = "Connect"
        Me.btn_connect_plc_no.UseVisualStyleBackColor = True
        '
        'txt_Port_PLC_NO
        '
        Me.txt_Port_PLC_NO.Location = New System.Drawing.Point(62, 65)
        Me.txt_Port_PLC_NO.Name = "txt_Port_PLC_NO"
        Me.txt_Port_PLC_NO.Size = New System.Drawing.Size(127, 26)
        Me.txt_Port_PLC_NO.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Port"
        '
        'txt_IP_PLC_NO
        '
        Me.txt_IP_PLC_NO.Location = New System.Drawing.Point(62, 33)
        Me.txt_IP_PLC_NO.Name = "txt_IP_PLC_NO"
        Me.txt_IP_PLC_NO.Size = New System.Drawing.Size(127, 26)
        Me.txt_IP_PLC_NO.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "IP"
        '
        'btn_login
        '
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Image = Global.MASTER.My.Resources.Resources.icons8_change_user_50
        Me.btn_login.Location = New System.Drawing.Point(1101, 20)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(85, 85)
        Me.btn_login.TabIndex = 83
        Me.btn_login.Text = "Login"
        Me.btn_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'pb_status_mc
        '
        Me.pb_status_mc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_status_mc.Image = Global.MASTER.My.Resources.Resources.mark_ok
        Me.pb_status_mc.Location = New System.Drawing.Point(967, 20)
        Me.pb_status_mc.Name = "pb_status_mc"
        Me.pb_status_mc.Size = New System.Drawing.Size(85, 85)
        Me.pb_status_mc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_status_mc.TabIndex = 76
        Me.pb_status_mc.TabStop = False
        '
        'pb_logo
        '
        Me.pb_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_logo.Image = Global.MASTER.My.Resources.Resources.logo_sanindo_tekno_batam
        Me.pb_logo.Location = New System.Drawing.Point(12, 20)
        Me.pb_logo.Name = "pb_logo"
        Me.pb_logo.Size = New System.Drawing.Size(250, 85)
        Me.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_logo.TabIndex = 75
        Me.pb_logo.TabStop = False
        '
        'btn_save
        '
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Image = Global.MASTER.My.Resources.Resources.icons8_save_50
        Me.btn_save.Location = New System.Drawing.Point(12, 260)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(120, 85)
        Me.btn_save.TabIndex = 84
        Me.btn_save.Text = "Save"
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.Image = Global.MASTER.My.Resources.Resources.icons8_home_50
        Me.btn_home.Location = New System.Drawing.Point(12, 169)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(120, 85)
        Me.btn_home.TabIndex = 84
        Me.btn_home.Text = "Home"
        Me.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'pb_status_bar
        '
        Me.pb_status_bar.BackColor = System.Drawing.Color.LimeGreen
        Me.pb_status_bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_status_bar.Location = New System.Drawing.Point(425, 20)
        Me.pb_status_bar.Name = "pb_status_bar"
        Me.pb_status_bar.Size = New System.Drawing.Size(500, 85)
        Me.pb_status_bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_status_bar.TabIndex = 77
        Me.pb_status_bar.TabStop = False
        '
        'txt_database
        '
        Me.txt_database.Location = New System.Drawing.Point(104, 128)
        Me.txt_database.Name = "txt_database"
        Me.txt_database.Size = New System.Drawing.Size(127, 26)
        Me.txt_database.TabIndex = 6
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(104, 64)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(127, 26)
        Me.txt_username.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Database"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 20)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Username"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(104, 96)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(127, 26)
        Me.txt_password.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Password"
        '
        'txt_hostname
        '
        Me.txt_hostname.Location = New System.Drawing.Point(104, 32)
        Me.txt_hostname.Name = "txt_hostname"
        Me.txt_hostname.Size = New System.Drawing.Size(127, 26)
        Me.txt_hostname.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 20)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Hostname"
        '
        'SettingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.pb_status_mc)
        Me.Controls.Add(Me.pb_logo)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_curr_time)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pb_status_bar)
        Me.Name = "SettingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SettingForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pb_status_mc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_status_bar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_login As Button
    Friend WithEvents pb_status_mc As PictureBox
    Friend WithEvents pb_logo As PictureBox
    Friend WithEvents pb_status_bar As PictureBox
    Friend WithEvents DateTime As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbl_date As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_curr_time As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_user As Label
    Friend WithEvents btn_home As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_port_plc_nc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_ip_plc_nc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_plc_status As Label
    Friend WithEvents txt_Port_PLC_NO As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_IP_PLC_NO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents rtb_setting As RichTextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents btn_disconnect_plc_nc As Button
    Friend WithEvents btn_connect_plc_nc As Button
    Friend WithEvents btn_disconnect_plc_no As Button
    Friend WithEvents btn_connect_plc_no As Button
    Friend WithEvents txt_database As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_hostname As TextBox
    Friend WithEvents Label17 As Label
End Class
