<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReferencesForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rtb_references = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.txt_family = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_references = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.txt_material_type = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.txt_barcode_scan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_curr_time = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.pb_status_bar = New System.Windows.Forms.PictureBox()
        Me.pb_status_mc = New System.Windows.Forms.PictureBox()
        Me.pb_logo = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_status_bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_status_mc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTime
        '
        Me.DateTime.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(138, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1200, 546)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rtb_references)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 401)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(275, 139)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Status"
        '
        'rtb_references
        '
        Me.rtb_references.Location = New System.Drawing.Point(6, 25)
        Me.rtb_references.Name = "rtb_references"
        Me.rtb_references.Size = New System.Drawing.Size(263, 109)
        Me.rtb_references.TabIndex = 0
        Me.rtb_references.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_delete)
        Me.GroupBox2.Controls.Add(Me.btn_update)
        Me.GroupBox2.Controls.Add(Me.btn_add)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Controls.Add(Me.txt_family)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox10)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt_references)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.txt_material_type)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.txt_barcode_scan)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 376)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reference Control"
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(207, 325)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(62, 35)
        Me.btn_delete.TabIndex = 13
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(106, 325)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(62, 35)
        Me.btn_update.TabIndex = 13
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(3, 325)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(62, 35)
        Me.btn_add.TabIndex = 13
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(135, 249)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(134, 26)
        Me.TextBox9.TabIndex = 6
        Me.TextBox9.Visible = False
        '
        'txt_family
        '
        Me.txt_family.Location = New System.Drawing.Point(135, 120)
        Me.txt_family.Name = "txt_family"
        Me.txt_family.Size = New System.Drawing.Size(134, 26)
        Me.txt_family.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 252)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Label3"
        Me.Label10.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Family"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(135, 281)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(134, 26)
        Me.TextBox10.TabIndex = 7
        Me.TextBox10.Visible = False
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(135, 217)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(134, 26)
        Me.TextBox8.TabIndex = 7
        Me.TextBox8.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 284)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 20)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Label3"
        Me.Label11.Visible = False
        '
        'txt_references
        '
        Me.txt_references.Location = New System.Drawing.Point(135, 88)
        Me.txt_references.Name = "txt_references"
        Me.txt_references.Size = New System.Drawing.Size(134, 26)
        Me.txt_references.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 20)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Label3"
        Me.Label9.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "References"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(135, 185)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(134, 26)
        Me.TextBox7.TabIndex = 8
        Me.TextBox7.Visible = False
        '
        'txt_material_type
        '
        Me.txt_material_type.Location = New System.Drawing.Point(135, 56)
        Me.txt_material_type.Name = "txt_material_type"
        Me.txt_material_type.Size = New System.Drawing.Size(134, 26)
        Me.txt_material_type.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Label3"
        Me.Label8.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Material Type"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(135, 153)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(134, 26)
        Me.TextBox6.TabIndex = 9
        Me.TextBox6.Visible = False
        '
        'txt_barcode_scan
        '
        Me.txt_barcode_scan.Location = New System.Drawing.Point(135, 24)
        Me.txt_barcode_scan.Name = "txt_barcode_scan"
        Me.txt_barcode_scan.Size = New System.Drawing.Size(134, 26)
        Me.txt_barcode_scan.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Label3"
        Me.Label7.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Barcode Scan"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(287, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(907, 521)
        Me.DataGridView1.TabIndex = 0
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
        Me.TextBox1.TabIndex = 49
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
        Me.lbl_date.TabIndex = 35
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
        Me.Label2.TabIndex = 34
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
        Me.lbl_curr_time.TabIndex = 33
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
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "MANUAL"
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(1192, 20)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(146, 75)
        Me.lbl_user.TabIndex = 31
        Me.lbl_user.Text = "ENG"
        '
        'btn_home
        '
        Me.btn_home.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.Image = Global.MASTER.My.Resources.Resources.icons8_home_50
        Me.btn_home.Location = New System.Drawing.Point(12, 169)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(120, 85)
        Me.btn_home.TabIndex = 37
        Me.btn_home.Text = "Home"
        Me.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'btn_login
        '
        Me.btn_login.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Image = Global.MASTER.My.Resources.Resources.icons8_change_user_50
        Me.btn_login.Location = New System.Drawing.Point(1101, 20)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(85, 85)
        Me.btn_login.TabIndex = 36
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
        Me.pb_status_bar.TabIndex = 30
        Me.pb_status_bar.TabStop = False
        '
        'pb_status_mc
        '
        Me.pb_status_mc.Image = Global.MASTER.My.Resources.Resources.mark_ok
        Me.pb_status_mc.Location = New System.Drawing.Point(967, 20)
        Me.pb_status_mc.Name = "pb_status_mc"
        Me.pb_status_mc.Size = New System.Drawing.Size(85, 85)
        Me.pb_status_mc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_status_mc.TabIndex = 29
        Me.pb_status_mc.TabStop = False
        '
        'pb_logo
        '
        Me.pb_logo.Image = Global.MASTER.My.Resources.Resources.GUI___Sch
        Me.pb_logo.Location = New System.Drawing.Point(12, 20)
        Me.pb_logo.Name = "pb_logo"
        Me.pb_logo.Size = New System.Drawing.Size(250, 85)
        Me.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_logo.TabIndex = 28
        Me.pb_logo.TabStop = False
        '
        'ReferencesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
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
        Me.Name = "ReferencesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReferencesForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_status_bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_status_mc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTime As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_home As Button
    Friend WithEvents btn_login As Button
    Friend WithEvents lbl_date As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_curr_time As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_user As Label
    Friend WithEvents pb_status_bar As PictureBox
    Friend WithEvents pb_status_mc As PictureBox
    Friend WithEvents pb_logo As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents txt_family As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents txt_references As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents txt_material_type As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents txt_barcode_scan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rtb_references As RichTextBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label11 As Label
End Class
