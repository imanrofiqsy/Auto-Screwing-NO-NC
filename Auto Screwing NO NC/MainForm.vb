Imports ControlBPM
Imports System.Threading
Imports System.Data.SqlClient
Imports System.IO
Public Class MainForm
    Dim ModbusNO = New Modbus
    Dim ModbusNC = New Modbus
    Dim Database = New DatabaseConnection
    Dim CodeSoftNO = New CodeSoftLabelPrint
    Dim CodeSoftNC = New CodeSoftLabelPrint

    Dim fullPath As String = System.AppDomain.CurrentDomain.BaseDirectory
    Dim projectFolder As String = fullPath.Replace("\Auto Screwing NO NC\bin\Debug\", "").Replace("\Auto Screwing NO NC\bin\Release\", "")
    Dim iniPath As String = projectFolder + "\config\config.INI"
    Dim labelPathNO As String = projectFolder + "\label\NO.lab"
    Dim labelPathNC As String = projectFolder + "\label\NC.lab"

    Dim ThreadLoadingBar As Thread
    Dim ThreadNO As Thread
    Dim ThreadNC As Thread

    Private Sub initLoadingBar()
        ThreadLoadingBar = New Thread(New ThreadStart(AddressOf ProcessLoad))
        ThreadLoadingBar.Start()
    End Sub
    Private Sub ProcessLoad()
        Do
            LoadingForm.ShowDialog()
        Loop
    End Sub
    Private Sub UpdateLoadingBar(value As Integer, msg As String)
        LoadingBarValue = value
        LoadingBarMessage = msg
    End Sub
    Private Sub killLoadingBar()
        ThreadLoadingBar.Abort()
    End Sub
    Private Sub DateTime_Tick(sender As Object, e As EventArgs) Handles DateTime.Tick
        lbl_curr_time.Text = Date.Now.ToString("dd-MM-yyyy")
        lbl_curr_time.Text = Date.Now.ToString("hh:mm:ss")
    End Sub
    Private Sub btn_manual_Click(sender As Object, e As EventArgs) Handles btn_manual.Click
        Hide()
        ManualForm.Show()
    End Sub
    Private Sub btn_references_Click(sender As Object, e As EventArgs) Handles btn_references.Click
        Hide()
        ReferencesForm.Show()
    End Sub
    Private Sub btn_alarm_Click(sender As Object, e As EventArgs) Handles btn_alarm.Click
        Hide()
        AlarmForm.Show()
    End Sub
    Private Sub btn_log_Click(sender As Object, e As EventArgs) Handles btn_log.Click
        Hide()
        LogForm.Show()
    End Sub
    Private Sub btn_setting_Click(sender As Object, e As EventArgs) Handles btn_setting.Click
        Hide()
        SettingForm.ShowDialog()
        Try
            With Config
                .addressPlcMC_NC = ReadINI(iniPath, "PLCMCNC", "IP")
                .addressPlcMC_NO = ReadINI(iniPath, "PLCMCNO", "IP")
                .dbHostName = ReadINI(iniPath, "DATABASE", "Hostname")
                .dbUsername = ReadINI(iniPath, "DATABASE", "Username")
                .dbPassword = ReadINI(iniPath, "DATABASE", "Password")
                .dbDatabase = ReadINI(iniPath, "DATABASE", "Database")
                .printerName = ReadINI(iniPath, "PRINTER", "Printername")
                ModbusNO.OpenPort(.addressPlcMC_NO, "502")
                ModbusNC.OpenPort(.addressPlcMC_NC, "502")
                Thread.Sleep(100)
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GetUserLevel()
        If UserLevel = 1 Then
            lbl_user.Text = "ADM"
            btn_setting.Enabled = True
            btn_manual.Enabled = True
            btn_references.Enabled = True
            btn_alarm.Enabled = True
            btn_log.Enabled = True
        ElseIf UserLevel = 2 Then
            lbl_user.Text = "ENG"
            btn_setting.Enabled = True
            btn_manual.Enabled = True
            btn_references.Enabled = True
            btn_alarm.Enabled = True
            btn_log.Enabled = True
        ElseIf UserLevel = 3 Then
            lbl_user.Text = "OPE"
            btn_setting.Enabled = False
            btn_manual.Enabled = False
            btn_references.Enabled = False
            btn_alarm.Enabled = False
            btn_log.Enabled = False
        ElseIf UserLevel = 4 Then
            lbl_user.Text = "QUA"
            btn_setting.Enabled = False
            btn_manual.Enabled = False
            btn_references.Enabled = False
            btn_alarm.Enabled = False
            btn_log.Enabled = False
        End If
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Hide()
            initLoadingBar()

            UpdateLoadingBar(40, "Loading?? 2...")
            With Config
                .addressPlcMC_NC = ReadINI(iniPath, "PLCMCNC", "IP")
                .addressPlcMC_NO = ReadINI(iniPath, "PLCMCNO", "IP")
                .dbHostName = ReadINI(iniPath, "DATABASE", "Hostname")
                .dbUsername = ReadINI(iniPath, "DATABASE", "Username")
                .dbPassword = ReadINI(iniPath, "DATABASE", "Password")
                .dbDatabase = ReadINI(iniPath, "DATABASE", "Database")
                .printerName = ReadINI(iniPath, "PRINTER", "Printername")
                .countNc = ReadINI(iniPath, "STATUSNC", "CounterProduct")
                .countNo = ReadINI(iniPath, "STATUSNO", "CounterProduct")
                ModbusNO.OpenPort(.addressPlcMC_NO, "502")
                ModbusNC.OpenPort(.addressPlcMC_NC, "502")
                UpdateLoadingBar(20, "Connecting to PLC...")
            End With
            Thread.Sleep(500)

            With Content
                .BarcodeScan = ReadINI(iniPath, "LABEL", "BarcodeScan")
                .Family = ReadINI(iniPath, "LABEL", "Family")
                .MaterialType = ReadINI(iniPath, "LABEL", "Material")
                .Quantity = ReadINI(iniPath, "LABEL", "Qty")
                .References = ReadINI(iniPath, "LABEL", "Qty")
            End With

            UpdateLoadingBar(60, "Opening Codesoft label print...")
            CodeSoftNO.killLPPA()
            CodeSoftNO.OpenCodesoft()
            CodeSoftNO.OpenDocument(labelPathNO)
            CodeSoftNO.SetPrinter(Config.printerName)
            CodeSoftNC.OpenCodesoft()
            CodeSoftNC.OpenDocument(labelPathNC)
            CodeSoftNC.SetPrinter(Config.printerName)
            Thread.Sleep(500)

            ThreadNO = New Thread(AddressOf NO_Thread)
            ThreadNO.Start()
            ThreadNC = New Thread(AddressOf NC_Thread)
            ThreadNC.Start()
            UpdateLoadingBar(80, "Creating Multithreading...")
            Thread.Sleep(500)

            UpdateLoadingBar(100, "Loading App GUI...")
            Thread.Sleep(500)

            killLoadingBar()
            Cursor = Cursors.Default
            LoginForm.TopMost = True
            LoginForm.ShowDialog()
            Thread.Sleep(100)
            GetUserLevel()
        Catch ex As Exception
            UpdateLoadingBar(LoadingBarValue, "Error!!, " + ex.Message + ", Application is closing")
            Thread.Sleep(2000)
            End
        End Try

    End Sub
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Hide()
        LoginForm.ShowDialog()
        GetUserLevel()
    End Sub
    Private Sub SaveDataLogNo()
        StartDate.Value = Date.Today
        EndDate.Value = Date.Today
        Dim _start As String = StartDate.Value.ToString("yyyy-MM-dd 00:00:00")
        Dim _end As String = EndDate.Value.ToString("yyyy-MM-dd 23:59:59")
        Try
            Call Database.Connect()
            Dim sc As New SqlCommand("SELECT * FROM tb_no_report WHERE [Launch Time] BETWEEN '" + _start + "' AND '" + _end + "'", Database.Connection)
            Dim adapter As New SqlDataAdapter(sc)
            Dim ds As New DataSet

            adapter.Fill(ds)
            dgv_temp.DataSource = ds.Tables(0)
            dgv_temp.ClearSelection()

            Dim logFileName = $"Log_NO_{Date.Now.ToString("yyyyMMdd")}.csv"
            Dim strFile As String = projectFolder & "\log\NO\" & logFileName

            If dgv_temp.Rows.Count > 0 Then
                Dim value As String = ""
                Dim dr As New DataGridViewRow()

                Dim swOut As StreamWriter = File.CreateText(strFile)

                'write header rows to csv
                For i As Integer = 0 To dgv_temp.Columns.Count - 1
                    If i > 0 Then
                        swOut.Write(";")
                    End If
                    swOut.Write(dgv_temp.Columns(i).HeaderText)
                Next

                swOut.WriteLine()

                'write DataGridView rows to csv
                For j As Integer = 0 To dgv_temp.Rows.Count - 1
                    If j > 0 Then
                        swOut.WriteLine()
                    End If

                    dr = dgv_temp.Rows(j)

                    For i As Integer = 0 To dgv_temp.Columns.Count - 1
                        If i > 0 Then
                            swOut.Write(";")
                        End If
                        If IsDBNull(dr.Cells(i).Value) Then
                            value = "0"
                        Else
                            value = CStr(dr.Cells(i).Value)
                        End If
                        swOut.Write(value)
                    Next
                Next
                swOut.Close()
            End If
        Catch ex As Exception
            Console.WriteLine("Error Save Datalog" + ex.Message)
        End Try
    End Sub
    Private Sub SaveDataLogNc()
        StartDate.Value = Date.Today
        EndDate.Value = Date.Today
        Dim _start As String = StartDate.Value.ToString("yyyy-MM-dd 00:00:00")
        Dim _end As String = EndDate.Value.ToString("yyyy-MM-dd 23:59:59")
        Try
            Call Database.Connect()
            Dim sc As New SqlCommand("SELECT * FROM tb_nc_report WHERE [Launch Time] BETWEEN '" + _start + "' AND '" + _end + "'", Database.Connection)
            Dim adapter As New SqlDataAdapter(sc)
            Dim ds As New DataSet

            adapter.Fill(ds)
            dgv_temp.DataSource = ds.Tables(0)
            dgv_temp.ClearSelection()

            Dim logFileName = $"Log_NC_{Date.Now.ToString("yyyyMMdd")}.csv"
            Dim strFile As String = projectFolder & "\log\NC\" & logFileName

            If dgv_temp.Rows.Count > 0 Then
                Dim value As String = ""
                Dim dr As New DataGridViewRow()

                Dim swOut As StreamWriter = File.CreateText(strFile)

                'write header rows to csv
                For i As Integer = 0 To dgv_temp.Columns.Count - 1
                    If i > 0 Then
                        swOut.Write(";")
                    End If
                    swOut.Write(dgv_temp.Columns(i).HeaderText)
                Next

                swOut.WriteLine()

                'write DataGridView rows to csv
                For j As Integer = 0 To dgv_temp.Rows.Count - 1
                    If j > 0 Then
                        swOut.WriteLine()
                    End If

                    dr = dgv_temp.Rows(j)

                    For i As Integer = 0 To dgv_temp.Columns.Count - 1
                        If i > 0 Then
                            swOut.Write(";")
                        End If
                        If IsDBNull(dr.Cells(i).Value) Then
                            value = "0"
                        Else
                            value = CStr(dr.Cells(i).Value)
                        End If
                        swOut.Write(value)
                    Next
                Next
                swOut.Close()
            End If
        Catch ex As Exception
            Console.WriteLine("Error Save Datalog" + ex.Message)
        End Try
    End Sub
    Private Sub btn_start_no_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_start_no.MouseDown
        Try
            If cb_mat_no.Text <> "" And Val(txt_qty_no.Text) > 0 And ModbusNO.GetState("Idle") Then
                Call Database.Connect()
                Dim sc As New SqlCommand("SELECT * FROM tb_references WHERE [Barcode Scan]='NO Contact " & cb_mat_no.Text & "'", Database.Connection)
                Dim rd As SqlDataReader = sc.ExecuteReader
                rd.Read()

                txt_qr_no.Text = rd.Item("Material Type")

                With Content
                    .BarcodeScan = rd.Item("Barcode Scan")
                    .Family = rd.Item("Family")
                    .MaterialType = rd.Item("Material Type")
                    .Quantity = txt_qty_no.Text
                    .References = rd.Item("References")

                    CodeSoftNO.qr_UpdateVarList()

                    ModbusNO.SetState("Data Available")
                    Thread.Sleep(10)
                    ModbusNO.SetState("Start")

                    Config.countNo += 1
                    Dim sc_2 As New SqlCommand("INSERT INTO tb_no_report ([ID], [Contact Type], [Material Type], [Quantity], [Launch Time]) VALUES(" & Config.countNo & ", '" & .BarcodeScan & "', '" & .MaterialType & "', '" & .Quantity & "', '" & Date.Now.ToString("yyyy-MM-dd HH:mm:ss") & "')", Database.Connection)
                    Dim adapter As New SqlDataAdapter(sc_2)
                    adapter.SelectCommand.ExecuteNonQuery()

                    SaveDataLogNo()
                End With

                rtb_status_no.SelectionColor = Color.Black
                rtb_status_no.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Status] Finish get qr content, record material and quantity to database and send data to PLC." + Environment.NewLine)
                rtb_status_no.ScrollToCaret()
            Else
                rtb_status_no.SelectionColor = Color.Red
                rtb_status_no.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Status] Error, material or quantity not valid or machine is not Idle." + Environment.NewLine)
                rtb_status_no.ScrollToCaret()
            End If
        Catch ex As Exception
            rtb_status_no.SelectionColor = Color.Red
            rtb_status_no.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Status] Error, " + ex.Message + Environment.NewLine)
            rtb_status_no.ScrollToCaret()
        End Try
    End Sub
    Private Sub btn_start_no_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_start_no.MouseUp

    End Sub
    Public Sub NO_Thread()
        Do
            Try
                If ModbusNO.GetState("Start Print") Then
                    'CodeSoftNO.PrintLabel(Integer.Parse("1")) 'bypass print
                    ModbusNO.SetState("Finish Print")
                    Invoke(Sub()
                               rtb_status_no.SelectionColor = Color.Black
                               rtb_status_no.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Status] Finish print label." + Environment.NewLine)
                               rtb_status_no.ScrollToCaret()
                           End Sub)
                    Call Database.Connect()
                    Dim sc_2 As New SqlCommand("UPDATE tb_no_report SET [Finish Time] = '" & Date.Now.ToString("yyyy-MM-dd HH:mm:ss") & "' WHERE [ID] = " & Config.countNo & "", Database.Connection)
                    Dim adapter As New SqlDataAdapter(sc_2)
                    adapter.SelectCommand.ExecuteNonQuery()
                    Invoke(Sub()
                               SaveDataLogNo()
                               WriteINI(iniPath, "STATUSNO", "CounterProduct", Config.countNo)
                           End Sub)
                End If
            Catch ex As Exception

            End Try
            Thread.Sleep(500)
        Loop
    End Sub
    Public Sub NC_Thread()
        Do
            Try
                If ModbusNC.GetState("Start Print") Then
                    'CodeSoftNC.PrintLabel(Integer.Parse("1")) 'bypass print
                    ModbusNC.SetState("Finish Print")
                    Invoke(Sub()
                               rtb_status_nc.SelectionColor = Color.Black
                               rtb_status_nc.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Status] Finish print label." + Environment.NewLine)
                               rtb_status_nc.ScrollToCaret()
                           End Sub)
                    Call Database.Connect()
                    Dim sc_2 As New SqlCommand("UPDATE tb_nc_report SET [Finish Time] = '" & Date.Now.ToString("yyyy-MM-dd HH:mm:ss") & "' WHERE [ID] = " & Config.countNc & "", Database.Connection)
                    Dim adapter As New SqlDataAdapter(sc_2)
                    adapter.SelectCommand.ExecuteNonQuery()
                    Invoke(Sub()
                               SaveDataLogNc()
                               WriteINI(iniPath, "STATUSNC", "CounterProduct", Config.countNc)
                           End Sub)
                End If
            Catch ex As Exception

            End Try
            Thread.Sleep(500)
        Loop
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ThreadNO.IsAlive Then
            ThreadNO.Abort()
        End If
        If ThreadNC.IsAlive Then
            ThreadNC.Abort()
        End If
        CodeSoftNO.CloseCodesoft()
        CodeSoftNC.CloseCodesoft()
    End Sub

    Private Sub btn_start_nc_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_start_nc.MouseDown
        Try
            If cb_mat_nc.Text <> "" And Val(txt_qty_nc.Text) > 0 And ModbusNC.GetState("Idle") Then
                Call Database.Connect()
                Dim sc As New SqlCommand("SELECT * FROM tb_references WHERE [Barcode Scan]='NO Contact " & cb_mat_nc.Text & "'", Database.Connection)
                Dim rd As SqlDataReader = sc.ExecuteReader
                rd.Read()

                txt_qr_nc.Text = rd.Item("Material Type")

                With Content
                    .BarcodeScan = rd.Item("Barcode Scan")
                    .Family = rd.Item("Family")
                    .MaterialType = rd.Item("Material Type")
                    .Quantity = txt_qty_nc.Text
                    .References = rd.Item("References")

                    CodeSoftNC.qr_UpdateVarList()

                    ModbusNC.SetState("Data Available")
                    Thread.Sleep(10)
                    ModbusNC.SetState("Start")

                    Config.countNc += 1
                    Dim sc_2 As New SqlCommand("INSERT INTO tb_nc_report ([ID], [Contact Type], [Material Type], [Quantity], [Launch Time]) VALUES(" & Config.countNc & ", 'NC', '" & .MaterialType & "', '" & .Quantity & "', '" & Date.Now.ToString("yyyy-MM-dd HH:mm:ss") & "')", Database.Connection)
                    Dim adapter As New SqlDataAdapter(sc_2)
                    adapter.SelectCommand.ExecuteNonQuery()
                End With

                SaveDataLogNc()

                rtb_status_nc.SelectionColor = Color.Black
                rtb_status_nc.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Status] Finish get qr content, record material and quantity to database and send data to PLC." + Environment.NewLine)
                rtb_status_nc.ScrollToCaret()
            Else
                rtb_status_nc.SelectionColor = Color.Red
                rtb_status_nc.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Status] Error, material or quantity not valid or machine is not Idle." + Environment.NewLine)
                rtb_status_nc.ScrollToCaret()
            End If
        Catch ex As Exception
            rtb_status_nc.SelectionColor = Color.Red
            rtb_status_nc.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Status] Error, " + ex.Message + Environment.NewLine)
            rtb_status_nc.ScrollToCaret()
        End Try
    End Sub

    Private Sub btn_start_nc_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_start_nc.MouseUp

    End Sub

    Private Sub cb_mat_no_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_mat_no.SelectedIndexChanged
        Try
            ModbusNO.SetMaterial(cb_mat_no.Text)
            rtb_status_no.SelectionColor = Color.Black
            rtb_status_no.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Status] Finish send product type." + Environment.NewLine)
            rtb_status_no.ScrollToCaret()
        Catch ex As Exception
            rtb_status_no.SelectionColor = Color.Red
            rtb_status_no.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Status] Failed send product type." + Environment.NewLine)
            rtb_status_no.ScrollToCaret()
        End Try
    End Sub

    Private Sub cb_mat_nc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_mat_nc.SelectedIndexChanged
        Try
            ModbusNC.SetMaterial(cb_mat_nc.Text)
            rtb_status_nc.SelectionColor = Color.Black
            rtb_status_nc.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Status] Finish send product type." + Environment.NewLine)
            rtb_status_nc.ScrollToCaret()
        Catch ex As Exception
            rtb_status_nc.SelectionColor = Color.Red
            rtb_status_nc.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Status] Failed send product type." + Environment.NewLine)
            rtb_status_nc.ScrollToCaret()
        End Try
    End Sub

    Private Sub txt_qty_no_TextChanged(sender As Object, e As EventArgs) Handles txt_qty_no.TextChanged
        If Val(txt_qty_no.Text) > 0 And txt_qty_no.Text.Length = 4 Then
            Try
                ModbusNO.SetQuantity(Val(txt_qty_no.Text))
                rtb_status_no.SelectionColor = Color.Black
                rtb_status_no.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Status] Finish send quantity." + Environment.NewLine)
                rtb_status_no.ScrollToCaret()
            Catch ex As Exception
                rtb_status_no.SelectionColor = Color.Red
                rtb_status_no.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Status] Failed send quantity. " + ex.Message + Environment.NewLine)
                rtb_status_no.ScrollToCaret()
            End Try
        End If
    End Sub

    Private Sub txt_qty_nc_TextChanged(sender As Object, e As EventArgs) Handles txt_qty_nc.TextChanged
        If Val(txt_qty_nc.Text) > 0 And txt_qty_nc.Text.Length = 4 Then
            Try
                ModbusNO.SetQuantity(Val(txt_qty_nc.Text))
                rtb_status_nc.SelectionColor = Color.Black
                rtb_status_nc.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Status] Finish send quantity." + Environment.NewLine)
                rtb_status_nc.ScrollToCaret()
            Catch ex As Exception
                rtb_status_nc.SelectionColor = Color.Red
                rtb_status_nc.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Status] Failed send quantity. " + ex.Message + Environment.NewLine)
                rtb_status_nc.ScrollToCaret()
            End Try
        End If
    End Sub
End Class
