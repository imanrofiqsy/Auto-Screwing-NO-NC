Imports System.IO
Imports TKX.Lppa
Imports System.Drawing.Imaging

Public Class CodeSoftLabelPrint
    'Init Variable
    Private PrinterApp As TKX.Lppa.Application = Nothing
    Public ActiveDoc As TKX.Lppa.Document = Nothing
    Public pbLabelPreview As New PictureBox

    Dim _opened As Boolean

    Public Sub OpenCodesoft()
        PrinterApp = New TKX.Lppa.Application()
        PrinterApp.PreloadUI()
        _opened = True
    End Sub

    Public Function OpenCodesoftStatus() As Boolean
        Return _opened
    End Function

    Public Sub CloseCodesoft()
        _opened = False

        If ActiveDoc IsNot Nothing Then
            ActiveDoc.Close(False)
        End If

        If PrinterApp IsNot Nothing Then
            If PrinterApp.Documents IsNot Nothing Then
                PrinterApp.Documents.CloseAll(False)
            End If
            PrinterApp.Quit()
        End If
    End Sub

    Public Sub OpenDocument(location As String)
        ActiveDoc = PrinterApp.Documents.Open(location, False)
    End Sub

    Public Function UpdatePrinterList() As String()
        Dim AllPrintersName As String()
        AllPrintersName = PrinterApp.PrinterSystem.PrintersNames(KindOfPrinters.AllPrinters)
        Return AllPrintersName
    End Function

    Public Sub SetPrinter(PrinterName As String)
        If ActiveDoc IsNot Nothing Then
            ActiveDoc.Printer.SwitchTo(PrinterName)
        End If
    End Sub

    Public Sub PrinterSetupDialog()
        If PrinterApp IsNot Nothing Then
            PrinterApp.Dialogs(DialogType.PrinterSetup).Show(CInt(mainForm.Handle))
        End If
    End Sub

    Public Sub PageSetupDialog()
        If PrinterApp IsNot Nothing Then
            PrinterApp.Dialogs(DialogType.PageSetup).Show(CInt(mainForm.Handle))
        End If
    End Sub

    Public Sub PrintLabel(Qty As Integer)
        If ActiveDoc IsNot Nothing Then
            ActiveDoc.FullClippingMode = True
            If ActiveDoc IsNot Nothing Then
                ActiveDoc.PrintDocument(Qty)
            End If
        End If
    End Sub

    Public Sub UpdateLabelPreview()
        If ActiveDoc IsNot Nothing Then
            pbLabelPreview.Image = If(ActiveDoc IsNot Nothing, ActiveDoc.GetPreview(True, True, 400), Nothing)
        End If
    End Sub

    Public Sub killLPPA()
        For Each p As Process In System.Diagnostics.Process.GetProcessesByName("Lppa")
            p.Kill()
        Next
    End Sub

    Public Sub showHideDesigner()
        PrinterApp.Visible = Not PrinterApp.Visible
    End Sub

    'tambahan
    Public Sub qr_UpdateVarList()
        If ActiveDoc IsNot Nothing Then
            For Each aVariable As Tkx.Lppa.Variable In ActiveDoc.Variables
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
    End Sub

End Class
