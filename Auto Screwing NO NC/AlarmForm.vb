Public Class AlarmForm
    Dim IndexAlarm As Integer = 0
    Private Sub DateTime_Tick(sender As Object, e As EventArgs) Handles DateTime.Tick
        lbl_curr_time.Text = Date.Now.ToString("dd-MM-yyyy")
        lbl_curr_time.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Close()
        MainForm.Show()
    End Sub

    Private Sub AlarmForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetUserLevel()
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 20)
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 20)
        DataGridView1.DefaultCellStyle.BackColor = Color.DarkRed
        DataGridView1.DefaultCellStyle.ForeColor = Color.White
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim TableAlarm As New DataTable("Alarm")
        TableAlarm.Columns.Add("Alarm List", GetType(String))

        With Alarm
            If .PlcNc <> "" Then
                txt_alarm.Text = "Alarm : " + .PlcNc
                AddDataRow(TableAlarm, .PlcNc)
            End If

            If .PlcNo <> "" Then
                txt_alarm.Text = "Alarm : " + .PlcNo
                AddDataRow(TableAlarm, .PlcNo)
            End If
        End With

        DataGridView1.DataSource = TableAlarm
    End Sub
    Private Sub AddDataRow(Table As DataTable, List As String)
        Dim TableRow As DataRow = Table.NewRow
        TableRow("Alarm List") = List
        Table.Rows.Add(TableRow)
    End Sub
    Private Sub GetUserLevel()
        If UserLevel = 1 Then
            lbl_user.Text = "ADM"
        ElseIf UserLevel = 2 Then
            lbl_user.Text = "ENG"
        ElseIf UserLevel = 3 Then
            lbl_user.Text = "OPE"
        ElseIf UserLevel = 4 Then
            lbl_user.Text = "QUA"
        End If
    End Sub
End Class