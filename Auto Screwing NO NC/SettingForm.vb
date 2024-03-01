Public Class SettingForm
    Dim ModbusNo = New Modbus
    Dim Database = New DatabaseConnection
    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Hide()
        MainForm.Show()
    End Sub

    Private Sub btn_connect_plc_Click(sender As Object, e As EventArgs) Handles btn_connect_plc_no.Click
        Try
            ModbusNo.OpenPort(txt_IP_PLC_NO.Text, txt_Port_PLC_NO.Text)
            lbl_plc_status.Text = "Connected"
            lbl_plc_status.BackColor = Color.DarkGreen
            rtb_setting.SelectionColor = Color.Black
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
            lbl_plc_status.Text = "Disconnected"
            lbl_plc_status.BackColor = Color.DarkRed
            rtb_setting.SelectionColor = Color.Black
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
                ModbusNo.OpenPort(.addressPlcMC_NO, "502")
                txt_IP_PLC_NO.Text = .addressPlcMC_NO
                txt_Port_PLC_NO.Text = "502"
                lbl_plc_status.Text = "Connected"
                lbl_plc_status.BackColor = Color.DarkGreen
            Catch ex As Exception
                lbl_plc_status.Text = "Disconnected"
                lbl_plc_status.BackColor = Color.DarkRed
            End Try
        End With
    End Sub
End Class