<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_curr_time = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.DateTime = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_qr_nc = New System.Windows.Forms.TextBox()
        Me.txt_qty_nc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb_mat_nc = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rtb_status_nc = New System.Windows.Forms.RichTextBox()
        Me.btn_start_nc = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_qr_no = New System.Windows.Forms.TextBox()
        Me.txt_qty_no = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_mat_no = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rtb_status_no = New System.Windows.Forms.RichTextBox()
        Me.btn_start_no = New System.Windows.Forms.Button()
        Me.btn_st6 = New System.Windows.Forms.Button()
        Me.btn_setting = New System.Windows.Forms.Button()
        Me.btn_st5 = New System.Windows.Forms.Button()
        Me.btn_log = New System.Windows.Forms.Button()
        Me.btn_st4 = New System.Windows.Forms.Button()
        Me.btn_alarm = New System.Windows.Forms.Button()
        Me.btn_st3 = New System.Windows.Forms.Button()
        Me.btn_references = New System.Windows.Forms.Button()
        Me.btn_st2 = New System.Windows.Forms.Button()
        Me.btn_manual = New System.Windows.Forms.Button()
        Me.btn_st1 = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.pb_status_bar = New System.Windows.Forms.PictureBox()
        Me.pb_status_mc = New System.Windows.Forms.PictureBox()
        Me.pb_logo = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pb_status_bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_status_mc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'DateTime
        '
        Me.DateTime.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(138, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1074, 546)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_qr_nc)
        Me.GroupBox4.Controls.Add(Me.txt_qty_nc)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.cb_mat_nc)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.btn_start_nc)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(548, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(520, 521)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "NC"
        '
        'txt_qr_nc
        '
        Me.txt_qr_nc.Location = New System.Drawing.Point(235, 199)
        Me.txt_qr_nc.Name = "txt_qr_nc"
        Me.txt_qr_nc.Size = New System.Drawing.Size(216, 38)
        Me.txt_qr_nc.TabIndex = 19
        '
        'txt_qty_nc
        '
        Me.txt_qty_nc.Location = New System.Drawing.Point(235, 133)
        Me.txt_qty_nc.Name = "txt_qty_nc"
        Me.txt_qty_nc.Size = New System.Drawing.Size(127, 38)
        Me.txt_qty_nc.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(97, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 31)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "QR Code"
        '
        'cb_mat_nc
        '
        Me.cb_mat_nc.FormattingEnabled = True
        Me.cb_mat_nc.Items.AddRange(New Object() {"SSAM", "BLR"})
        Me.cb_mat_nc.Location = New System.Drawing.Point(235, 68)
        Me.cb_mat_nc.Name = "cb_mat_nc"
        Me.cb_mat_nc.Size = New System.Drawing.Size(216, 39)
        Me.cb_mat_nc.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(97, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 31)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Quantity"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(97, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 31)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Material"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rtb_status_nc)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(26, 370)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(459, 127)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Status"
        '
        'rtb_status_nc
        '
        Me.rtb_status_nc.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb_status_nc.Location = New System.Drawing.Point(6, 25)
        Me.rtb_status_nc.Name = "rtb_status_nc"
        Me.rtb_status_nc.Size = New System.Drawing.Size(447, 96)
        Me.rtb_status_nc.TabIndex = 0
        Me.rtb_status_nc.Text = ""
        '
        'btn_start_nc
        '
        Me.btn_start_nc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_start_nc.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start_nc.Image = Global.MASTER.My.Resources.Resources.icons8_run_command_50
        Me.btn_start_nc.Location = New System.Drawing.Point(365, 270)
        Me.btn_start_nc.Name = "btn_start_nc"
        Me.btn_start_nc.Size = New System.Drawing.Size(120, 85)
        Me.btn_start_nc.TabIndex = 14
        Me.btn_start_nc.Text = "Start"
        Me.btn_start_nc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_start_nc.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_qr_no)
        Me.GroupBox2.Controls.Add(Me.txt_qty_no)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cb_mat_no)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.btn_start_no)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(520, 521)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "NO"
        '
        'txt_qr_no
        '
        Me.txt_qr_no.Location = New System.Drawing.Point(235, 199)
        Me.txt_qr_no.Name = "txt_qr_no"
        Me.txt_qr_no.Size = New System.Drawing.Size(216, 38)
        Me.txt_qr_no.TabIndex = 19
        '
        'txt_qty_no
        '
        Me.txt_qty_no.Location = New System.Drawing.Point(235, 133)
        Me.txt_qty_no.Name = "txt_qty_no"
        Me.txt_qty_no.Size = New System.Drawing.Size(127, 38)
        Me.txt_qty_no.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 31)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "QR Code"
        '
        'cb_mat_no
        '
        Me.cb_mat_no.FormattingEnabled = True
        Me.cb_mat_no.Items.AddRange(New Object() {"SSAM", "BLR"})
        Me.cb_mat_no.Location = New System.Drawing.Point(235, 68)
        Me.cb_mat_no.Name = "cb_mat_no"
        Me.cb_mat_no.Size = New System.Drawing.Size(216, 39)
        Me.cb_mat_no.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(97, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 31)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 31)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Material"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rtb_status_no)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(26, 370)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(459, 127)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Status"
        '
        'rtb_status_no
        '
        Me.rtb_status_no.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb_status_no.Location = New System.Drawing.Point(6, 25)
        Me.rtb_status_no.Name = "rtb_status_no"
        Me.rtb_status_no.Size = New System.Drawing.Size(447, 96)
        Me.rtb_status_no.TabIndex = 0
        Me.rtb_status_no.Text = ""
        '
        'btn_start_no
        '
        Me.btn_start_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_start_no.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start_no.Image = Global.MASTER.My.Resources.Resources.icons8_run_command_50
        Me.btn_start_no.Location = New System.Drawing.Point(365, 270)
        Me.btn_start_no.Name = "btn_start_no"
        Me.btn_start_no.Size = New System.Drawing.Size(120, 85)
        Me.btn_start_no.TabIndex = 14
        Me.btn_start_no.Text = "Start"
        Me.btn_start_no.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_start_no.UseVisualStyleBackColor = True
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
        Me.btn_st6.Visible = False
        '
        'btn_setting
        '
        Me.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_setting.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_setting.Image = Global.MASTER.My.Resources.Resources.icons8_setting_50
        Me.btn_setting.Location = New System.Drawing.Point(12, 624)
        Me.btn_setting.Name = "btn_setting"
        Me.btn_setting.Size = New System.Drawing.Size(120, 85)
        Me.btn_setting.TabIndex = 23
        Me.btn_setting.Text = "Setting"
        Me.btn_setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_setting.UseVisualStyleBackColor = True
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
        Me.btn_st5.Visible = False
        '
        'btn_log
        '
        Me.btn_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_log.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_log.Image = Global.MASTER.My.Resources.Resources.icons8_log_50
        Me.btn_log.Location = New System.Drawing.Point(12, 533)
        Me.btn_log.Name = "btn_log"
        Me.btn_log.Size = New System.Drawing.Size(120, 85)
        Me.btn_log.TabIndex = 21
        Me.btn_log.Text = "Log"
        Me.btn_log.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_log.UseVisualStyleBackColor = True
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
        Me.btn_st4.Visible = False
        '
        'btn_alarm
        '
        Me.btn_alarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_alarm.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_alarm.Image = Global.MASTER.My.Resources.Resources.icons8_siren_50
        Me.btn_alarm.Location = New System.Drawing.Point(12, 442)
        Me.btn_alarm.Name = "btn_alarm"
        Me.btn_alarm.Size = New System.Drawing.Size(120, 85)
        Me.btn_alarm.TabIndex = 19
        Me.btn_alarm.Text = "Alarm"
        Me.btn_alarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_alarm.UseVisualStyleBackColor = True
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
        Me.btn_st3.Visible = False
        '
        'btn_references
        '
        Me.btn_references.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_references.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_references.Image = Global.MASTER.My.Resources.Resources.icons8_open_book_50
        Me.btn_references.Location = New System.Drawing.Point(12, 351)
        Me.btn_references.Name = "btn_references"
        Me.btn_references.Size = New System.Drawing.Size(120, 85)
        Me.btn_references.TabIndex = 17
        Me.btn_references.Text = "References"
        Me.btn_references.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_references.UseVisualStyleBackColor = True
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
        Me.btn_st2.Visible = False
        '
        'btn_manual
        '
        Me.btn_manual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_manual.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manual.Image = Global.MASTER.My.Resources.Resources.icons8_manual_50
        Me.btn_manual.Location = New System.Drawing.Point(12, 260)
        Me.btn_manual.Name = "btn_manual"
        Me.btn_manual.Size = New System.Drawing.Size(120, 85)
        Me.btn_manual.TabIndex = 25
        Me.btn_manual.Text = "Manual"
        Me.btn_manual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_manual.UseVisualStyleBackColor = True
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
        Me.btn_st1.Visible = False
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
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_st6)
        Me.Controls.Add(Me.btn_setting)
        Me.Controls.Add(Me.btn_st5)
        Me.Controls.Add(Me.btn_log)
        Me.Controls.Add(Me.btn_st4)
        Me.Controls.Add(Me.btn_alarm)
        Me.Controls.Add(Me.btn_st3)
        Me.Controls.Add(Me.btn_references)
        Me.Controls.Add(Me.btn_st2)
        Me.Controls.Add(Me.btn_manual)
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
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Screwing NO NC"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.pb_status_bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_status_mc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_st6 As Button
    Friend WithEvents btn_setting As Button
    Friend WithEvents btn_st5 As Button
    Friend WithEvents btn_log As Button
    Friend WithEvents btn_st4 As Button
    Friend WithEvents btn_alarm As Button
    Friend WithEvents btn_st3 As Button
    Friend WithEvents btn_references As Button
    Friend WithEvents btn_st2 As Button
    Friend WithEvents btn_manual As Button
    Friend WithEvents btn_st1 As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents btn_login As Button
    Friend WithEvents lbl_date As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_curr_time As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_user As Label
    Friend WithEvents DateTime As Timer
    Friend WithEvents pb_status_bar As PictureBox
    Friend WithEvents pb_status_mc As PictureBox
    Friend WithEvents pb_logo As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_qr_nc As TextBox
    Friend WithEvents txt_qty_nc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cb_mat_nc As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rtb_status_nc As RichTextBox
    Friend WithEvents btn_start_nc As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_qr_no As TextBox
    Friend WithEvents txt_qty_no As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_mat_no As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rtb_status_no As RichTextBox
    Friend WithEvents btn_start_no As Button
End Class
