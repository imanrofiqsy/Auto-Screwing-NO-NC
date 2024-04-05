Imports EasyModbus
Public Class Modbus
    Dim modbusClient As ModbusClient
    Dim ConnectionError As Boolean
    Public Sub OpenPort(IP As String, PORT As String)
        modbusClient = New ModbusClient(IP, Val(PORT))
        modbusClient.Connect()
    End Sub
    Public Sub ClosePort()
        modbusClient.Disconnect()
    End Sub
    Public Function _ConnectionError() As Boolean
        Return ConnectionError
    End Function
    Public Sub WriteBit(addr As Integer, bit As Integer, val As Integer)
        Dim address_val() As Integer
        address_val = modbusClient.ReadHoldingRegisters(addr, 1)

        Dim binaryString As String = Convert.ToString(address_val(0), 2).PadLeft(16, "0"c)
        binaryString = binaryString.Reverse.ToArray
        Dim temp(16)
        Dim temp_str As String
        For i As Integer = 0 To binaryString.Length - 1
            If i = bit Then
                temp(i) = val
            Else
                If binaryString(i) = "1" Then
                    temp(i) = 1
                Else
                    temp(i) = 0
                End If
            End If
            temp_str = temp_str + temp(i).ToString
        Next
        temp_str = temp_str.Reverse.ToArray
        Dim integer_val As Integer = Convert.ToInt16(temp_str.ToString, 2)

        modbusClient.WriteSingleRegister(addr, integer_val)
    End Sub
    Public Function ReadBit(addr As Integer, bit As Integer) As Integer
        Dim address_val() As Integer
        address_val = modbusClient.ReadHoldingRegisters(addr, 1)

        Dim binaryString As String = Convert.ToString(address_val(0), 2).PadLeft(16, "0"c)
        binaryString = binaryString.Reverse.ToArray
        For i As Integer = 0 To binaryString.Length - 1
            If i = bit Then
                Return Val(binaryString(i))
            End If
        Next
    End Function
    Public Function ReadDoubleInteger(addr As Integer) As Integer
        Dim address_val() As Integer
        Dim result As Integer

        address_val = modbusClient.ReadHoldingRegisters(addr, 2)
        result = (CInt(address_val(0)) And &HFFFF) Or (CInt(address_val(1)) << 16)
        Return result
    End Function
    Public Sub WriteDoubleInteger(addr As Integer, val As Int32)
        Dim values(1) As Int32
        values(0) = CInt((val >> 16) And &HFFFF)
        values(1) = CInt(val And &HFFFF)
        Dim result(1) As Integer
        result(0) = values(1)
        result(1) = values(0)
        modbusClient.WriteMultipleRegisters(addr, result)
    End Sub
    'tambahan
    Public Sub SetMaterial(type As String)
        If type = "SSAM" Then
            modbusClient.WriteSingleRegister(5000, 11)
        ElseIf type = "BLR" Then
            modbusClient.WriteSingleRegister(5000, 12)
        End If
    End Sub
    Public Sub SetQuantity(qty As Integer)
        modbusClient.WriteSingleRegister(5001, qty)
    End Sub
    Public Sub SetState(condition As String)
        Dim state As Integer
        If condition = "Data Available" Then
            state = 555
        ElseIf condition = "Start" Then
            state = 666
        ElseIf condition = "Finish Print" Then
            state = 555
        End If
        modbusClient.WriteSingleRegister(5002, state)
    End Sub
    Public Function GetState(condition As String) As Boolean
        Dim state() As Integer
        state = modbusClient.ReadHoldingRegisters(5002, 1)

        If state(0) = -30208 Then
            ConnectionError = True
            Return False
        Else
            ConnectionError = False
        End If

        If condition = "Start Print" Then
            If state(0) = 777 Then
                Return True
            End If
        ElseIf condition = "Idle" Then
            If state(0) <> 666 Then
                Return True
            End If
        End If
        Return False
    End Function
End Class
