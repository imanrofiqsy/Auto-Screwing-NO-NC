Public Class ManualForm
    Dim codesoft = New CodeSoftLabelPrint
    Dim fullPath As String = System.AppDomain.CurrentDomain.BaseDirectory
    Dim projectFolder As String = fullPath.Replace("\Auto Screwing NO NC\bin\Debug\", "").Replace("\Auto Screwing NO NC\bin\Release\", "")
    Dim labelPath As String = projectFolder + "\label\NO_NC.lab"

    Private Sub DateTime_Tick(sender As Object, e As EventArgs) Handles DateTime.Tick
        lbl_curr_time.Text = Date.Now.ToString("dd-MM-yyyy")
        lbl_curr_time.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Hide()
        MainForm.Show()
    End Sub
    Private Sub btn_open_qr_Click(sender As Object, e As EventArgs)
        Dim OpenFile As New OpenFileDialog()
        OpenFile.Title = "Label File Location"
        OpenFile.ShowDialog()
        qr_file_location.Text = OpenFile.FileName
    End Sub

    Private Sub btn_qr_location_Click(sender As Object, e As EventArgs) Handles btn_qr_location.Click
        Dim OpenFile As New OpenFileDialog()
        OpenFile.Title = "Label File Location"
        OpenFile.ShowDialog()
        qr_file_location.Text = OpenFile.FileName
    End Sub
    Private Sub update_printer_list_QR()
        qr_printer_name.Items.Clear()
        Dim PrinterNameListQR As String()
        PrinterNameListQR = codesoft.UpdatePrinterList()
        For Each PrinterName As String In PrinterNameListQR
            qr_printer_name.Items.Add(PrinterName)
        Next
    End Sub
    Private Sub qr_UpdateVarList()
        qr_listboxVars.Items.Clear()

        If codesoft.ActiveDoc IsNot Nothing Then
            For Each aVariable As Tkx.Lppa.Variable In codesoft.ActiveDoc.Variables
                qr_listboxVars.Items.Add(aVariable.Name)
                Select Case aVariable.Name
                    Case "VarBarcodeScan"
                        aVariable.Value = ""
                        aVariable.Value = Content.BarcodeScan
                    Case "VarFam"
                        aVariable.Value = ""
                        aVariable.Value = Content.Family
                    Case "VarMaterial"
                        aVariable.Value = ""
                        aVariable.Value = Content.MaterialType
                    Case "VarQr"
                        aVariable.Value = ""
                        aVariable.Value = Content.MaterialType
                    Case "VarQty"
                        aVariable.Value = ""
                        aVariable.Value = Content.Quantity
                    Case "VarRef"
                        aVariable.Value = ""
                        aVariable.Value = Content.References
                End Select
            Next
        End If

        If qr_listboxVars.Items.Count > 0 Then
            qr_listboxVars.SelectedIndex = 0
        End If
    End Sub
    Private Sub btn_open_qr_Click_1(sender As Object, e As EventArgs) Handles btn_open_qr.Click
        If codesoft.OpenCodesoftStatus = False Then
            If String.IsNullOrEmpty(qr_file_location.Text) Then
                RTB_MAN.SelectionColor = Color.Red
                RTB_MAN.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "QR file location is empty!" + Environment.NewLine)
                RTB_MAN.ScrollToCaret()
            Else
                CheckForIllegalCrossThreadCalls = False
                codesoft.killLPPA()

                Cursor = Cursors.WaitCursor
                RTB_MAN.SelectionColor = Color.Green
                RTB_MAN.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "Opening QR file, Please Wait...." + Environment.NewLine)
                RTB_MAN.ScrollToCaret()

                codesoft.OpenCodesoft()
                codesoft.OpenDocument(qr_file_location.Text)
                update_printer_list_QR()
                codesoft.UpdateLabelPreview()
                qrPreview.Image = codesoft.pbLabelPreview.Image

                ' set the printer to be print
                codesoft.SetPrinter(qr_printer_name.Text)

                ' update list qr var
                qr_UpdateVarList()

                btn_open_qr.Enabled = False
                btn_close_qr.Enabled = True

                Cursor = Cursors.Default
                RTB_MAN.SelectionColor = Color.Green
                RTB_MAN.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "QR file successfully opened" + Environment.NewLine)
                RTB_MAN.ScrollToCaret()
            End If
        Else
            RTB_MAN.SelectionColor = Color.Yellow
            RTB_MAN.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss => ") + "QR file has been opened!" + Environment.NewLine)
            RTB_MAN.ScrollToCaret()
        End If
    End Sub

    Private Sub btn_print_qr_Click(sender As Object, e As EventArgs) Handles btn_print_qr.Click
        If codesoft.OpenCodesoftStatus Then
            If String.IsNullOrEmpty(qr_qty.Text) Then
                RTB_MAN.SelectionColor = Color.Yellow
                RTB_MAN.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "QR Qty is Null!" + Environment.NewLine)
                RTB_MAN.ScrollToCaret()
            Else
                ' print document
                codesoft.PrintLabel(Integer.Parse(qr_qty.Text))

                RTB_MAN.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "Printing QR..." + Environment.NewLine)
                RTB_MAN.ScrollToCaret()
            End If
        Else
            RTB_MAN.SelectionColor = Color.Red
            RTB_MAN.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "QR file has not been opened!" + Environment.NewLine)
            RTB_MAN.ScrollToCaret()
        End If
    End Sub

    Private Sub btn_page_setup_qr_Click(sender As Object, e As EventArgs) Handles btn_page_setup_qr.Click
        If codesoft.OpenCodesoftStatus Then
            codesoft.PageSetupDialog()
        Else
            RTB_MAN.SelectionColor = Color.Red
            RTB_MAN.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "QR file has not been opened!" + Environment.NewLine)
            RTB_MAN.ScrollToCaret()
        End If
    End Sub

    Private Sub btn_close_qr_Click(sender As Object, e As EventArgs) Handles btn_close_qr.Click
        If codesoft.OpenCodesoftStatus Then
            qrPreview.Image = Nothing
            codesoft.CloseCodesoft()

            CheckForIllegalCrossThreadCalls = False
            'codesoft.killLPPA()

            btn_open_qr.Enabled = True
            btn_close_qr.Enabled = False

            RTB_MAN.SelectionColor = Color.Green
            RTB_MAN.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "QR file successfully closed" + Environment.NewLine)
            RTB_MAN.ScrollToCaret()
        Else
            RTB_MAN.SelectionColor = Color.Red
            RTB_MAN.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "QR file has been closed!" + Environment.NewLine)
            RTB_MAN.ScrollToCaret()
        End If
    End Sub
    Private Sub Label_UpdateLabelPreview()
        If codesoft.ActiveDoc IsNot Nothing Then
            qrPreview.Image = If(codesoft.ActiveDoc IsNot Nothing, codesoft.ActiveDoc.GetPreview(True, True, 400), Nothing)
        End If
    End Sub

    Private Sub btnQrUpdateVar_Click(sender As Object, e As EventArgs) Handles btnQrUpdateVar.Click
        If codesoft.ActiveDoc IsNot Nothing Then
            Dim aVariable As Tkx.Lppa.Variable = codesoft.ActiveDoc.Variables(qr_listboxVars.Text)
            aVariable.Value = qrVarValue.Text
        End If

        Label_UpdateLabelPreview()
    End Sub

    Private Sub btn_setting_printer_qr_Click(sender As Object, e As EventArgs) Handles btn_setting_printer_qr.Click
        If codesoft.OpenCodesoftStatus Then
            codesoft.PrinterSetupDialog()
        Else
            RTB_MAN.SelectionColor = Color.Red
            RTB_MAN.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "QR file has not been opened!" + Environment.NewLine)
            RTB_MAN.ScrollToCaret()
        End If
    End Sub

    Private Sub qr_listboxVars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles qr_listboxVars.SelectedIndexChanged
        If codesoft.ActiveDoc IsNot Nothing Then
            Dim aVariable As Tkx.Lppa.Variable = codesoft.ActiveDoc.Variables(qr_listboxVars.Text)
            qrVarValue.Text = aVariable.Value
        End If
    End Sub

    Private Sub ManualForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub ManualForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        qr_file_location.Text = labelPath

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

    Private Sub showhide_qr_designer_Click(sender As Object, e As EventArgs) Handles showhide_qr_designer.Click
        If codesoft.OpenCodesoftStatus Then
            codesoft.showHideDesigner()
        End If
    End Sub
End Class