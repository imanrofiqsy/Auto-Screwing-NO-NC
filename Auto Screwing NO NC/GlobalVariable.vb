Module GlobalVariable
    Public tempEnNc As Boolean
    Public tempEnNo As Boolean
    Public UserLevel As Integer
    Public LoadingBarValue As Integer
    Public LoadingBarMessage As String
    Public Alarm As New AlarmList
    Public Structure AlarmList
        Dim PlcNo As String
        Dim PlcNc As String
    End Structure
    Public Config As New MachineConfig
    Public Structure MachineConfig
        Dim addressPlcMC_NO As String
        Dim addressPlcMC_NC As String
        Dim enableNo As Boolean
        Dim enableNc As Boolean
        Dim dbHostName As String
        Dim dbUsername As String
        Dim dbPassword As String
        Dim dbDatabase As String
        Dim printerName As String
        Dim countNo As Integer
        Dim countNc As Integer
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
