Imports System.Data.SqlClient
Public Class LogForm
    Dim Database = New DatabaseConnection
    Private Sub DateTime_Tick(sender As Object, e As EventArgs) Handles DateTime.Tick
        lbl_curr_time.Text = Date.Now.ToString("dd-MM-yyyy")
        lbl_curr_time.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Close()
        MainForm.Show()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Cursor = Cursors.WaitCursor
        Try
            If rbBydate.Checked Then
                Dim range1 As String = DateTimePickerStartDate.Value.ToString("yyyy-MM-dd 00:00:00")
                Dim range2 As String = DateTimePickerEndDate.Value.ToString("yyyy-MM-dd 23:59:59")

                If rbNO.Checked Then
                    LoadLogByDate("NO", range1, range2)
                ElseIf rbNC.Checked Then
                    LoadLogByDate("NC", range1, range2)
                End If
            ElseIf rbByREF.Checked Then
                If rbNO.Checked Then
                    LoadLogByRef("NO")
                ElseIf rbNC.Checked Then
                    LoadLogByRef("NC")
                End If
            End If
            rtb_log.SelectionColor = Color.Black
            rtb_log.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Log] Finish search log" + Environment.NewLine)
            rtb_log.ScrollToCaret()
        Catch ex As Exception
            rtb_log.SelectionColor = Color.Black
            rtb_log.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Log] Failed search log " + ex.Message + Environment.NewLine)
            rtb_log.ScrollToCaret()
        End Try
        Cursor = Cursors.Default
    End Sub
    Private Sub LoadLogByDate(type As String, range1 As String, range2 As String)
        If type = "NO" Then
            Call Database.Connect()
            Dim sc As New SqlCommand("SELECT * FROM tb_no_report WHERE [Launch Time] BETWEEN '" + range1 + "' AND '" + range2 + "'", Database.Connection)
            Dim adapter As New SqlDataAdapter(sc)
            Dim ds As New DataSet

            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        ElseIf type = "NC" Then
            Call Database.Connect()
            Dim sc As New SqlCommand("SELECT * FROM tb_nc_report WHERE [Launch Time] BETWEEN '" + range1 + "' AND '" + range2 + "'", Database.Connection)
            Dim adapter As New SqlDataAdapter(sc)
            Dim ds As New DataSet

            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        End If
    End Sub

    Private Sub LoadLogByRef(type As String)
        If type = "NO" Then
            Call Database.Connect()
            Dim sc As New SqlCommand("SELECT * FROM tb_no_report WHERE [Contact Type] = '" & txt_references.Text & "'", Database.Connection)
            Dim adapter As New SqlDataAdapter(sc)
            Dim ds As New DataSet

            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        ElseIf type = "NC" Then
            Call Database.Connect()
            Dim sc As New SqlCommand("SELECT * FROM tb_nc_report WHERE WHERE [Contact Type] = '" & txt_references.Text & "'", Database.Connection)
            Dim adapter As New SqlDataAdapter(sc)
            Dim ds As New DataSet

            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        End If
    End Sub
    Private Sub LogForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 15)
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 15)
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        GetUserLevel()

        With Alarm
            If .PlcNc <> "" Then
                txt_alarm.Text = "ALARM : " + .PlcNc
            ElseIf .PlcNo <> "" Then
                txt_alarm.Text = "ALARM : " + .PlcNo
            Else
                txt_alarm.Text = "ALARM : . . . ."
            End If
        End With
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