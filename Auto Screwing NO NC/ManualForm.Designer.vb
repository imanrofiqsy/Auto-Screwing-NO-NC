<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManualForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManualForm))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.DateTime = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_curr_time = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.btn_st6 = New System.Windows.Forms.Button()
        Me.btn_st5 = New System.Windows.Forms.Button()
        Me.btn_st4 = New System.Windows.Forms.Button()
        Me.btn_st3 = New System.Windows.Forms.Button()
        Me.btn_st2 = New System.Windows.Forms.Button()
        Me.btn_st1 = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.pb_status_bar = New System.Windows.Forms.PictureBox()
        Me.pb_status_mc = New System.Windows.Forms.PictureBox()
        Me.pb_logo = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RTB_MAN = New System.Windows.Forms.RichTextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.qr_listboxVars = New System.Windows.Forms.ListBox()
        Me.btnQrUpdateVar = New System.Windows.Forms.Button()
        Me.btn_open_qr = New System.Windows.Forms.Button()
        Me.qrVarValue = New System.Windows.Forms.TextBox()
        Me.btn_close_qr = New System.Windows.Forms.Button()
        Me.btn_page_setup_qr = New System.Windows.Forms.Button()
        Me.btn_print_qr = New System.Windows.Forms.Button()
        Me.showhide_qr_designer = New System.Windows.Forms.Button()
        Me.qrPreview = New System.Windows.Forms.PictureBox()
        Me.btn_qr_location = New System.Windows.Forms.Button()
        Me.btn_find = New System.Windows.Forms.Button()
        Me.btn_setting_printer_qr = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.qr_printer_name = New System.Windows.Forms.ComboBox()
        Me.qr_qty = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.qr_file_location = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.pb_status_bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_status_mc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        CType(Me.qrPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TextBox1.TabIndex = 26
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
        Me.lbl_date.TabIndex = 12
        Me.lbl_date.Text = "31-12-2000"
        '
        'DateTime
        '
        Me.DateTime.Enabled = True
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
        Me.Label2.TabIndex = 11
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
        Me.lbl_curr_time.TabIndex = 10
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
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "MANUAL"
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(1192, 20)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(146, 75)
        Me.lbl_user.TabIndex = 8
        Me.lbl_user.Text = "ENG"
        '
        'btn_st6
        '
        Me.btn_st6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_st6.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st6.Image = CType(resources.GetObject("btn_st6.Image"), System.Drawing.Image)
        Me.btn_st6.Location = New System.Drawing.Point(1218, 624)
        Me.btn_st6.Name = "btn_st6"
        Me.btn_st6.Size = New System.Drawing.Size(120, 85)
        Me.btn_st6.TabIndex = 24
        Me.btn_st6.Text = "ST6"
        Me.btn_st6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_st6.UseVisualStyleBackColor = True
        '
        'btn_st5
        '
        Me.btn_st5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_st5.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st5.Image = CType(resources.GetObject("btn_st5.Image"), System.Drawing.Image)
        Me.btn_st5.Location = New System.Drawing.Point(1218, 533)
        Me.btn_st5.Name = "btn_st5"
        Me.btn_st5.Size = New System.Drawing.Size(120, 85)
        Me.btn_st5.TabIndex = 22
        Me.btn_st5.Text = "ST5"
        Me.btn_st5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_st5.UseVisualStyleBackColor = True
        '
        'btn_st4
        '
        Me.btn_st4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_st4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st4.Image = CType(resources.GetObject("btn_st4.Image"), System.Drawing.Image)
        Me.btn_st4.Location = New System.Drawing.Point(1218, 442)
        Me.btn_st4.Name = "btn_st4"
        Me.btn_st4.Size = New System.Drawing.Size(120, 85)
        Me.btn_st4.TabIndex = 20
        Me.btn_st4.Text = "ST4"
        Me.btn_st4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_st4.UseVisualStyleBackColor = True
        '
        'btn_st3
        '
        Me.btn_st3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_st3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st3.Image = CType(resources.GetObject("btn_st3.Image"), System.Drawing.Image)
        Me.btn_st3.Location = New System.Drawing.Point(1218, 351)
        Me.btn_st3.Name = "btn_st3"
        Me.btn_st3.Size = New System.Drawing.Size(120, 85)
        Me.btn_st3.TabIndex = 18
        Me.btn_st3.Text = "ST3"
        Me.btn_st3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_st3.UseVisualStyleBackColor = True
        '
        'btn_st2
        '
        Me.btn_st2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_st2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st2.Image = CType(resources.GetObject("btn_st2.Image"), System.Drawing.Image)
        Me.btn_st2.Location = New System.Drawing.Point(1218, 260)
        Me.btn_st2.Name = "btn_st2"
        Me.btn_st2.Size = New System.Drawing.Size(120, 85)
        Me.btn_st2.TabIndex = 16
        Me.btn_st2.Text = "ST2"
        Me.btn_st2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_st2.UseVisualStyleBackColor = True
        '
        'btn_st1
        '
        Me.btn_st1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_st1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st1.Image = CType(resources.GetObject("btn_st1.Image"), System.Drawing.Image)
        Me.btn_st1.Location = New System.Drawing.Point(1218, 169)
        Me.btn_st1.Name = "btn_st1"
        Me.btn_st1.Size = New System.Drawing.Size(120, 85)
        Me.btn_st1.TabIndex = 15
        Me.btn_st1.Text = "ST1"
        Me.btn_st1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_st1.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.Image = Global.MASTER.My.Resources.Resources.icons8_home_50
        Me.btn_home.Location = New System.Drawing.Point(12, 169)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(120, 85)
        Me.btn_home.TabIndex = 14
        Me.btn_home.Text = "Home"
        Me.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'btn_login
        '
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Image = Global.MASTER.My.Resources.Resources.icons8_change_user_50
        Me.btn_login.Location = New System.Drawing.Point(1101, 20)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(85, 85)
        Me.btn_login.TabIndex = 13
        Me.btn_login.Text = "Login"
        Me.btn_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'pb_status_bar
        '
        Me.pb_status_bar.BackColor = System.Drawing.Color.LimeGreen
        Me.pb_status_bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_status_bar.Location = New System.Drawing.Point(425, 20)
        Me.pb_status_bar.Name = "pb_status_bar"
        Me.pb_status_bar.Size = New System.Drawing.Size(500, 85)
        Me.pb_status_bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_status_bar.TabIndex = 7
        Me.pb_status_bar.TabStop = False
        '
        'pb_status_mc
        '
        Me.pb_status_mc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_status_mc.Image = Global.MASTER.My.Resources.Resources.mark_ok
        Me.pb_status_mc.Location = New System.Drawing.Point(967, 20)
        Me.pb_status_mc.Name = "pb_status_mc"
        Me.pb_status_mc.Size = New System.Drawing.Size(85, 85)
        Me.pb_status_mc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_status_mc.TabIndex = 6
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
        Me.pb_logo.TabIndex = 5
        Me.pb_logo.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Location = New System.Drawing.Point(138, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1074, 546)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.RTB_MAN)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(16, 370)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(787, 160)
        Me.GroupBox6.TabIndex = 136
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Status"
        '
        'RTB_MAN
        '
        Me.RTB_MAN.BackColor = System.Drawing.SystemColors.Info
        Me.RTB_MAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTB_MAN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RTB_MAN.Location = New System.Drawing.Point(6, 25)
        Me.RTB_MAN.Name = "RTB_MAN"
        Me.RTB_MAN.ReadOnly = True
        Me.RTB_MAN.Size = New System.Drawing.Size(775, 121)
        Me.RTB_MAN.TabIndex = 0
        Me.RTB_MAN.Text = ""
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.White
        Me.GroupBox8.Controls.Add(Me.GroupBox15)
        Me.GroupBox8.Controls.Add(Me.showhide_qr_designer)
        Me.GroupBox8.Controls.Add(Me.qrPreview)
        Me.GroupBox8.Controls.Add(Me.btn_qr_location)
        Me.GroupBox8.Controls.Add(Me.btn_find)
        Me.GroupBox8.Controls.Add(Me.btn_setting_printer_qr)
        Me.GroupBox8.Controls.Add(Me.Label11)
        Me.GroupBox8.Controls.Add(Me.qr_printer_name)
        Me.GroupBox8.Controls.Add(Me.qr_qty)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Controls.Add(Me.qr_file_location)
        Me.GroupBox8.Controls.Add(Me.Label16)
        Me.GroupBox8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Black
        Me.GroupBox8.Location = New System.Drawing.Point(16, 23)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(787, 341)
        Me.GroupBox8.TabIndex = 135
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Printer QR Code"
        '
        'GroupBox15
        '
        Me.GroupBox15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox15.Controls.Add(Me.qr_listboxVars)
        Me.GroupBox15.Controls.Add(Me.btnQrUpdateVar)
        Me.GroupBox15.Controls.Add(Me.btn_open_qr)
        Me.GroupBox15.Controls.Add(Me.qrVarValue)
        Me.GroupBox15.Controls.Add(Me.btn_close_qr)
        Me.GroupBox15.Controls.Add(Me.btn_page_setup_qr)
        Me.GroupBox15.Controls.Add(Me.btn_print_qr)
        Me.GroupBox15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox15.Location = New System.Drawing.Point(405, 28)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(377, 182)
        Me.GroupBox15.TabIndex = 26
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Variables settings"
        '
        'qr_listboxVars
        '
        Me.qr_listboxVars.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qr_listboxVars.ForeColor = System.Drawing.SystemColors.ControlText
        Me.qr_listboxVars.ItemHeight = 18
        Me.qr_listboxVars.Location = New System.Drawing.Point(11, 28)
        Me.qr_listboxVars.Name = "qr_listboxVars"
        Me.qr_listboxVars.Size = New System.Drawing.Size(239, 112)
        Me.qr_listboxVars.TabIndex = 9
        '
        'btnQrUpdateVar
        '
        Me.btnQrUpdateVar.BackColor = System.Drawing.Color.White
        Me.btnQrUpdateVar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQrUpdateVar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnQrUpdateVar.Location = New System.Drawing.Point(263, 146)
        Me.btnQrUpdateVar.Name = "btnQrUpdateVar"
        Me.btnQrUpdateVar.Size = New System.Drawing.Size(108, 30)
        Me.btnQrUpdateVar.TabIndex = 13
        Me.btnQrUpdateVar.Text = "Update"
        Me.btnQrUpdateVar.UseVisualStyleBackColor = False
        '
        'btn_open_qr
        '
        Me.btn_open_qr.BackColor = System.Drawing.Color.White
        Me.btn_open_qr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_open_qr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_open_qr.Location = New System.Drawing.Point(263, 18)
        Me.btn_open_qr.Name = "btn_open_qr"
        Me.btn_open_qr.Size = New System.Drawing.Size(108, 30)
        Me.btn_open_qr.TabIndex = 16
        Me.btn_open_qr.Text = "Open"
        Me.btn_open_qr.UseVisualStyleBackColor = False
        '
        'qrVarValue
        '
        Me.qrVarValue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qrVarValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.qrVarValue.Location = New System.Drawing.Point(11, 150)
        Me.qrVarValue.Name = "qrVarValue"
        Me.qrVarValue.Size = New System.Drawing.Size(239, 26)
        Me.qrVarValue.TabIndex = 12
        '
        'btn_close_qr
        '
        Me.btn_close_qr.BackColor = System.Drawing.Color.White
        Me.btn_close_qr.Enabled = False
        Me.btn_close_qr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close_qr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_close_qr.Location = New System.Drawing.Point(263, 114)
        Me.btn_close_qr.Name = "btn_close_qr"
        Me.btn_close_qr.Size = New System.Drawing.Size(108, 30)
        Me.btn_close_qr.TabIndex = 15
        Me.btn_close_qr.Text = "Close"
        Me.btn_close_qr.UseVisualStyleBackColor = False
        '
        'btn_page_setup_qr
        '
        Me.btn_page_setup_qr.BackColor = System.Drawing.Color.White
        Me.btn_page_setup_qr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_page_setup_qr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_page_setup_qr.Location = New System.Drawing.Point(263, 82)
        Me.btn_page_setup_qr.Name = "btn_page_setup_qr"
        Me.btn_page_setup_qr.Size = New System.Drawing.Size(108, 30)
        Me.btn_page_setup_qr.TabIndex = 8
        Me.btn_page_setup_qr.Text = "Page Setup"
        Me.btn_page_setup_qr.UseVisualStyleBackColor = False
        '
        'btn_print_qr
        '
        Me.btn_print_qr.BackColor = System.Drawing.Color.White
        Me.btn_print_qr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print_qr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_print_qr.Location = New System.Drawing.Point(263, 50)
        Me.btn_print_qr.Name = "btn_print_qr"
        Me.btn_print_qr.Size = New System.Drawing.Size(108, 30)
        Me.btn_print_qr.TabIndex = 7
        Me.btn_print_qr.Text = "Print"
        Me.btn_print_qr.UseVisualStyleBackColor = False
        '
        'showhide_qr_designer
        '
        Me.showhide_qr_designer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showhide_qr_designer.BackColor = System.Drawing.Color.White
        Me.showhide_qr_designer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.showhide_qr_designer.Location = New System.Drawing.Point(404, 293)
        Me.showhide_qr_designer.Name = "showhide_qr_designer"
        Me.showhide_qr_designer.Size = New System.Drawing.Size(377, 31)
        Me.showhide_qr_designer.TabIndex = 17
        Me.showhide_qr_designer.Text = "Show / Hide Designer"
        Me.showhide_qr_designer.UseVisualStyleBackColor = False
        '
        'qrPreview
        '
        Me.qrPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.qrPreview.Location = New System.Drawing.Point(22, 63)
        Me.qrPreview.Name = "qrPreview"
        Me.qrPreview.Size = New System.Drawing.Size(377, 261)
        Me.qrPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.qrPreview.TabIndex = 14
        Me.qrPreview.TabStop = False
        '
        'btn_qr_location
        '
        Me.btn_qr_location.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_qr_location.Location = New System.Drawing.Point(359, 31)
        Me.btn_qr_location.Name = "btn_qr_location"
        Me.btn_qr_location.Size = New System.Drawing.Size(40, 26)
        Me.btn_qr_location.TabIndex = 13
        Me.btn_qr_location.Text = "..."
        Me.btn_qr_location.UseVisualStyleBackColor = True
        '
        'btn_find
        '
        Me.btn_find.BackColor = System.Drawing.Color.White
        Me.btn_find.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_find.Location = New System.Drawing.Point(668, 219)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(114, 35)
        Me.btn_find.TabIndex = 12
        Me.btn_find.Text = "Find"
        Me.btn_find.UseVisualStyleBackColor = False
        '
        'btn_setting_printer_qr
        '
        Me.btn_setting_printer_qr.BackColor = System.Drawing.Color.White
        Me.btn_setting_printer_qr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_setting_printer_qr.Location = New System.Drawing.Point(667, 257)
        Me.btn_setting_printer_qr.Name = "btn_setting_printer_qr"
        Me.btn_setting_printer_qr.Size = New System.Drawing.Size(114, 35)
        Me.btn_setting_printer_qr.TabIndex = 12
        Me.btn_setting_printer_qr.Text = "Settings"
        Me.btn_setting_printer_qr.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(401, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 18)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Printer"
        '
        'qr_printer_name
        '
        Me.qr_printer_name.BackColor = System.Drawing.Color.White
        Me.qr_printer_name.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qr_printer_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.qr_printer_name.FormattingEnabled = True
        Me.qr_printer_name.Location = New System.Drawing.Point(405, 266)
        Me.qr_printer_name.Name = "qr_printer_name"
        Me.qr_printer_name.Size = New System.Drawing.Size(156, 26)
        Me.qr_printer_name.TabIndex = 10
        '
        'qr_qty
        '
        Me.qr_qty.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qr_qty.Location = New System.Drawing.Point(582, 264)
        Me.qr_qty.Name = "qr_qty"
        Me.qr_qty.Size = New System.Drawing.Size(72, 26)
        Me.qr_qty.TabIndex = 6
        Me.qr_qty.Text = "1"
        Me.qr_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(578, 241)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 18)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Label Qty"
        '
        'qr_file_location
        '
        Me.qr_file_location.BackColor = System.Drawing.Color.White
        Me.qr_file_location.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qr_file_location.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.qr_file_location.Location = New System.Drawing.Point(123, 31)
        Me.qr_file_location.Name = "qr_file_location"
        Me.qr_file_location.Size = New System.Drawing.Size(230, 26)
        Me.qr_file_location.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 18)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "File Location"
        '
        'ManualForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_st6)
        Me.Controls.Add(Me.btn_st5)
        Me.Controls.Add(Me.btn_st4)
        Me.Controls.Add(Me.btn_st3)
        Me.Controls.Add(Me.btn_st2)
        Me.Controls.Add(Me.btn_st1)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_curr_time)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.pb_status_bar)
        Me.Controls.Add(Me.pb_status_mc)
        Me.Controls.Add(Me.pb_logo)
        Me.Name = "ManualForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project Title"
        CType(Me.pb_status_bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_status_mc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        CType(Me.qrPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_st6 As Button
    Friend WithEvents btn_st5 As Button
    Friend WithEvents btn_st4 As Button
    Friend WithEvents btn_st3 As Button
    Friend WithEvents btn_st2 As Button
    Friend WithEvents btn_st1 As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents btn_login As Button
    Friend WithEvents lbl_date As Label
    Friend WithEvents DateTime As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_curr_time As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_user As Label
    Friend WithEvents pb_status_bar As PictureBox
    Friend WithEvents pb_status_mc As PictureBox
    Friend WithEvents pb_logo As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents RTB_MAN As RichTextBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents qr_listboxVars As ListBox
    Friend WithEvents btnQrUpdateVar As Button
    Friend WithEvents btn_open_qr As Button
    Friend WithEvents qrVarValue As TextBox
    Friend WithEvents btn_close_qr As Button
    Friend WithEvents btn_page_setup_qr As Button
    Friend WithEvents btn_print_qr As Button
    Friend WithEvents showhide_qr_designer As Button
    Friend WithEvents qrPreview As PictureBox
    Friend WithEvents btn_qr_location As Button
    Friend WithEvents btn_find As Button
    Friend WithEvents btn_setting_printer_qr As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents qr_printer_name As ComboBox
    Friend WithEvents qr_qty As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents qr_file_location As TextBox
    Friend WithEvents Label16 As Label
End Class
