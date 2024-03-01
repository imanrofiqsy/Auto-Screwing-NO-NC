Module GlobalVariable
    Public UserLevel As Integer
    Public LoadingBarValue As Integer
    Public LoadingBarMessage As String
    Public Config As New MachineConfig
    Public Structure MachineConfig
        Dim addressPlcMC_NO As String
        Dim addressPlcMC_NC As String
        Dim dbHostName As String
        Dim dbUsername As String
        Dim dbPassword As String
        Dim dbDatabase As String
        Dim printerName As String
    End Structure

    Public Content As New labelConfig
    Public Structure labelConfig
        Dim BarcodeScan As String
        Dim MaterialType As String
        Dim References As String
        Dim Family As String
        Dim Quantity As String
    End Structure
    Public Enum MainSequence
        INIT
        LAUNCH
        PRINT
        FINISH
    End Enum
End Module
