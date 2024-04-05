Imports ControlBPM
Public Class SettingForm
    Dim ModbusNo = New Modbus
    Dim ModbusNc = New Modbus
    Dim Database = New DatabaseConnection

    Dim fullPath As String = System.AppDomain.CurrentDomain.BaseDirectory
    Dim projectFolder As String = fullPath.Replace("\Auto Screwing NO NC\bin\Debug\", "").Replace("\Auto Screwing NO NC\bin\Release\", "")
    Dim iniPath As String = projectFolder + "\config\config.INI"


    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Close()
        MainForm.Show()
    End Sub

    Private Sub btn_connect_plc_Click(sender As Object, e As EventArgs) Handles btn_connect_plc_no.Click
        Try
            ModbusNo.OpenPort(txt_ip_plc_no.Text, txt_port_plc_no.Text)
            lbl_plc_status_no.Text = "Connected"
            lbl_plc_status_no.BackColor = Color.DarkGreen
            rtb_setting.SelectionColor = Color.Black
            tempEnNo = True
            rtb_setting.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Setting] PLC NO Enabled" + Environment.NewLine)
            rtb_setting.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Setting] PLC open port success" + Environment.NewLine)
            rtb_setting.ScrollToCaret()
        Catch ex As Exception
            rtb_setting.SelectionColor = Color.Black
            rtb_setting.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Setting] PLC open port failed " + ex.Message + Environment.NewLine)
            rtb_setting.ScrollToCaret()
        End Try
    End Sub

    Private Sub btn_disconnect_plc_Click(sender As Object, e As EventArgs) Handles btn_disconnect_plc_no.Click
        Try
            ModbusNo.ClosePort()
            lbl_plc_status_no.Text = "Disconnected"
            lbl_plc_status_no.BackColor = Color.DarkRed
            rtb_setting.SelectionColor = Color.Black
            tempEnNo = False
            rtb_setting.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Setting] PLC NC Disabled" + Environment.NewLine)
            rtb_setting.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Setting] PLC close port success" + Environment.NewLine)
            rtb_setting.ScrollToCaret()
        Catch ex As Exception
            rtb_setting.SelectionColor = Color.Black
            rtb_setting.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Setting] PLC close port failed " + ex.Message + Environment.NewLine)
            rtb_setting.ScrollToCaret()
        End Try
    End Sub

    Private Sub SettingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Config
            If Database.Connect Then
                txt_hostname.Text = .dbHostName
                txt_username.Text = .dbUsername
                txt_password.Text = .dbPassword
                txt_database.Text = .dbDatabase
            Else
                End
            End If

            Try
                If .enableNo Then
                    ModbusNo.OpenPort(.addressPlcMC_NO, "502")
                    txt_ip_plc_no.Text = .addressPlcMC_NO
                    txt_port_plc_no.Text = "502"
                    lbl_plc_status_no.Text = "Connected"
                    lbl_plc_status_no.BackColor = Color.DarkGreen
                Else
                    lbl_plc_status_no.Text = "Disconnected"
                    lbl_plc_status_no.BackColor = Color.DarkRed
                End If
            Catch ex As Exception
                lbl_plc_status_no.Text = "Disconnected"
                lbl_plc_status_no.BackColor = Color.DarkRed
            End Try

            Try
                If .enableNc Then
                    ModbusNc.OpenPort(.addressPlcMC_NC, "502")
                    txt_ip_plc_nc.Text = .addressPlcMC_NC
                    txt_port_plc_nc.Text = "502"
                    lbl_plc_status_nc.Text = "Connected"
                    lbl_plc_status_nc.BackColor = Color.DarkGreen
                Else
                    lbl_plc_status_nc.Text = "Disconnected"
                    lbl_plc_status_nc.BackColor = Color.DarkRed
                End If
            Catch ex As Exception
                lbl_plc_status_nc.Text = "Disconnected"
                lbl_plc_status_nc.BackColor = Color.DarkRed
            End Try
        End With
        With Alarm
            If .PlcNc <> "" Then
                txt_alarm.Text = "ALARM : " + .PlcNc
            ElseIf .PlcNo <> "" Then
                txt_alarm.Text = "ALARM : " + .PlcNo
            Else
                txt_alarm.Text = "ALARM : . . . ."
            End If
        End With
        GetUserLevel()
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

    Private Sub btn_connect_plc_nc_Click(sender As Object, e As EventArgs) Handles btn_connect_plc_nc.Click
        Try
            ModbusNc.OpenPort(txt_ip_plc_nc.Text, txt_port_plc_nc.Text)
            lbl_plc_status_nc.Text = "Connected"
            lbl_plc_status_nc.BackColor = Color.DarkGreen
            rtb_setting.SelectionColor = Color.Black
            tempEnNc = True
            rtb_setting.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Setting] PLC NC Enabled" + Environment.NewLine)
            rtb_setting.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Setting] PLC NC open port success" + Environment.NewLine)
            rtb_setting.ScrollToCaret()
        Catch ex As Exception
            rtb_setting.SelectionColor = Color.Black
            rtb_setting.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Setting] PLC NC open port failed " + ex.Message + Environment.NewLine)
            rtb_setting.ScrollToCaret()
        End Try
    End Sub

    Private Sub btn_disconnect_plc_nc_Click(sender As Object, e As EventArgs) Handles btn_disconnect_plc_nc.Click
        Try
            ModbusNc.ClosePort()
            lbl_plc_status_nc.Text = "Disconnected"
            lbl_plc_status_nc.BackColor = Color.DarkRed
            rtb_setting.SelectionColor = Color.Black
            tempEnNc = False
            rtb_setting.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Setting] PLC NC Disabled" + Environment.NewLine)
            rtb_setting.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Setting] PLC NC close port success" + Environment.NewLine)
            rtb_setting.ScrollToCaret()
        Catch ex As Exception
            rtb_setting.SelectionColor = Color.Black
            rtb_setting.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Setting] PLC NC close port failed" + ex.Message + Environment.NewLine)
            rtb_setting.ScrollToCaret()
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        WriteINI(iniPath, "PLCMCNC", "IP", txt_ip_plc_nc.Text)
        WriteINI(iniPath, "PLCMCNO", "IP", txt_ip_plc_no.Text)
        WriteINI(iniPath, "DATABASE", "Hostame", txt_hostname.Text)
        WriteINI(iniPath, "DATABASE", "Username", txt_username.Text)
        WriteINI(iniPath, "DATABASE", "Password", txt_password.Text)
        WriteINI(iniPath, "DATABASE", "Database", txt_database.Text)
        WriteINI(iniPath, "PLCMCNC", "Enabled", tempEnNc.ToString)
        WriteINI(iniPath, "PLCMCNO", "Enabled", tempEnNo.ToString)
        rtb_setting.SelectionColor = Color.Black
        rtb_setting.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[Setting] Configuration save success" + Environment.NewLine)
        rtb_setting.ScrollToCaret()
    End Sub
End Class