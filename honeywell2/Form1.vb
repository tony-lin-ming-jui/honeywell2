Imports System.IO.Ports
Imports System.Text.RegularExpressions

Public Class Form1
    Dim strSerialRead As String
    Dim blnRun As Boolean = True
    Dim time As String
    Dim cnt As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = "產品數量: " & cnt
        Label8.Text = ""
        BtnAlarm.Enabled = False
        TextBox2.Focus()
    End Sub
    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim sp As SerialPort = CType(sender, SerialPort)
        Dim strTemp As String

        strTemp = sp.ReadExisting() '讀到serialport的文字'
        ''''''''strTemp = sp.ReadLine()
        If blnRun Then 'and Button1.Text = "Stop"  //發生錯誤時用來關掉這裡讓條碼不讀取

            '''''''strTemp = sp.ReadExisting()
            strSerialRead = strTemp

        End If
    End Sub

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        Try
            Dim wmi As Object = GetObject("winmgmts:\\.\root\cimv2")
            Dim devices As Object = wmi.ExecQuery("Select DeviceID, Name from Win32_PnPEntity")
            Dim strDeviceId As String
            textboxCOM.Text = "N/A"
            For Each d As Object In devices
                strDeviceId = IIf(IsDBNull(d.DeviceID), "N/A", d.DeviceID)
                If Strings.InStr(strDeviceId, "VID_0C2E&PID_090A") > 0 Then
                    If Strings.InStr(d.Name, "(") > 0 Then
                        Dim rm As MatchCollection
                        rm = Regex.Matches(d.Name, "\b(COM\w+)\b")
                        textboxCOM.Text = rm(0).Value
                        Try
                            SerialControl()
                        Catch ex As Exception
                            MsgBox("條碼槍COM Port 錯誤或未連接設備", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")

                            SerialPort1.Close()
                            strSerialRead = ""

                            Exit Sub
                        End Try
                        strSerialRead = ""
                        Timer1.Enabled = True
                    End If
                End If
            Next
        Catch ex As Exception
            'MsgBox(ex.ToString)
            textboxCOM.Text = "N/A"
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If strSerialRead <> "" Then
            TextBox2.Text = strSerialRead
            strSerialRead = ""
        End If
    End Sub
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Dim ask As Integer
        If TextBox2.Text <> "" Then
            Try
                If BtnStart.Text = "Start" Then
                    BtnStart.Text = "Stop"

                    Timer1.Enabled = False

                    TextBox2.Enabled = False
                    textboxCOM.Enabled = False
                    BtnFind.Enabled = False

                    SerialControl()
                    Timer2.Enabled = True
                    strSerialRead = ""
                    'TextBox1.Text = ""
                    Label8.Text = ""
                    Me.BackColor = Color.FromKnownColor(KnownColor.Control) '設定成沒有顏色'
                Else
                    ask = MsgBox("確定要停止?(數量計算將歸0重新計算)", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "提醒")
                    If ask = 1 Then
                        BtStop()
                        strSerialRead = ""
                        Label8.Text = ""
                        Me.BackColor = Color.FromKnownColor(KnownColor.Control)
                        cnt = 0
                        Label6.Text = "產品數量: " & cnt
                        TextBox2.Focus()
                        SerialControl()

                    End If
                End If
            Catch ex As Exception
                'MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")  '可以改如果comport錯誤想要輸入的文字  有兩種情況 空白和COM錯誤 先別改這個除非能判斷'
                MsgBox("COM Port 錯誤或未連接設備", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
                SerialPort1.Close()
                BtStop()
            End Try
        Else
            MsgBox("請輸入條碼", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "警告")
        End If

    End Sub
    Sub SerialControl()
        SerialPort1.Close()
        SerialPort1.PortName = textboxCOM.Text
        SerialPort1.Open()
        SerialPort1.DiscardInBuffer()
        SerialPort1.DiscardOutBuffer()
    End Sub
    Sub BtStop()
        BtnStart.Text = "Start"
        TextBox2.Enabled = True
        textboxCOM.Enabled = True
        BtnFind.Enabled = True
        Timer2.Enabled = False
        Timer1.Enabled = True
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If strSerialRead <> "" Then
            If strSerialRead = TextBox2.Text Then
                ReadBarCode(1)
            Else
                '錯誤'
                Console.Beep(1000, 500)
                ReadBarCode(0)
            End If
            strSerialRead = ""
        End If
    End Sub
    Sub ReadBarCode(same As Integer)
        Label5.Text = ""
        Label5.Text = "上次條碼讀取時間: " & time
        time = Now.ToString("yyyy-MM-dd HH:mm:ss.fff")
        Label1.Text = "本次條碼讀取時間: " & time
        Label8.Text = strSerialRead
        strSerialRead = ""
        If same = 1 Then
            Me.BackColor = Color.FromArgb(0, 255, 0)
            cnt = cnt + 1
            Label6.Text = "產品數量: " & cnt
        ElseIf same = 0 Then
            Me.BackColor = Color.FromArgb(255, 0, 0)
            BtnStart.Enabled = False
            BtnAlarm.Enabled = True
            BtnZero.Enabled = False
            BtnMinus1.Enabled = False
            blnRun = False
            MsgBox("產品條碼與設定條碼不相同" + vbCrLf + "請點擊解除錯誤警告按鈕解除錯誤", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "錯誤")
        End If
    End Sub
    Private Sub BtnAlarm_Click(sender As Object, e As EventArgs) Handles BtnAlarm.Click
        blnRun = True
        Me.BackColor = Color.FromKnownColor(KnownColor.Control)
        strSerialRead = ""
        'TextBox1.Text = ""
        Label8.Text = ""
        BtnStart.Enabled = True
        BtnAlarm.Enabled = False
        BtnZero.Enabled = True
        BtnMinus1.Enabled = True
    End Sub

    Private Sub BtnZero_Click(sender As Object, e As EventArgs) Handles BtnZero.Click
        cnt = 0
        Label6.Text = "產品數量: " & cnt
    End Sub

    Private Sub BtnMinus1_Click(sender As Object, e As EventArgs) Handles BtnMinus1.Click
        cnt = cnt - 1
        If cnt < 0 Then
            cnt = 0
        End If
        Label6.Text = "產品數量: " & cnt
    End Sub

    Private Sub BtnInstructions_Click(sender As Object, e As EventArgs) Handles BtnInstructions.Click
        Form2.Show()
    End Sub
End Class
