<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnAlarm = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnZero = New System.Windows.Forms.Button()
        Me.BtnMinus1 = New System.Windows.Forms.Button()
        Me.BtnInstructions = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnFind = New System.Windows.Forms.Button()
        Me.textboxCOM = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(619, 53)
        Me.BtnStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(140, 77)
        Me.BtnStart.TabIndex = 0
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 361)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "現在時間"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(194, 153)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(580, 78)
        Me.TextBox2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "COM Port"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "條碼設定"
        '
        'BtnAlarm
        '
        Me.BtnAlarm.Location = New System.Drawing.Point(948, 53)
        Me.BtnAlarm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAlarm.Name = "BtnAlarm"
        Me.BtnAlarm.Size = New System.Drawing.Size(209, 77)
        Me.BtnAlarm.TabIndex = 9
        Me.BtnAlarm.Text = "解除錯誤警告"
        Me.BtnAlarm.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 450)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "產品條碼"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "上次時間"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(944, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "產品數量:"
        '
        'BtnZero
        '
        Me.BtnZero.Location = New System.Drawing.Point(948, 376)
        Me.BtnZero.Name = "BtnZero"
        Me.BtnZero.Size = New System.Drawing.Size(137, 51)
        Me.BtnZero.TabIndex = 13
        Me.BtnZero.Text = "數量歸0"
        Me.BtnZero.UseVisualStyleBackColor = True
        '
        'BtnMinus1
        '
        Me.BtnMinus1.Location = New System.Drawing.Point(948, 456)
        Me.BtnMinus1.Name = "BtnMinus1"
        Me.BtnMinus1.Size = New System.Drawing.Size(137, 56)
        Me.BtnMinus1.TabIndex = 14
        Me.BtnMinus1.Text = "數量減1"
        Me.BtnMinus1.UseVisualStyleBackColor = True
        '
        'BtnInstructions
        '
        Me.BtnInstructions.Location = New System.Drawing.Point(1027, 600)
        Me.BtnInstructions.Name = "BtnInstructions"
        Me.BtnInstructions.Size = New System.Drawing.Size(209, 74)
        Me.BtnInstructions.TabIndex = 15
        Me.BtnInstructions.Text = "系統操作說明"
        Me.BtnInstructions.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 600)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(938, 96)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "如發生任何異常請點擊[解除錯誤警告]，方可繼續，如果還是無法恢復請重新開啟本程式" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "如果有問題需要協助請找 張老師(分機742) 或 明叡(分機743)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("新細明體", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label8.Location = New System.Drawing.Point(195, 422)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(579, 90)
        Me.Label8.TabIndex = 39
        '
        'BtnFind
        '
        Me.BtnFind.Location = New System.Drawing.Point(323, 40)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(99, 49)
        Me.BtnFind.TabIndex = 41
        Me.BtnFind.Text = "尋找"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'textboxCOM
        '
        Me.textboxCOM.Location = New System.Drawing.Point(184, 50)
        Me.textboxCOM.Name = "textboxCOM"
        Me.textboxCOM.Size = New System.Drawing.Size(122, 35)
        Me.textboxCOM.TabIndex = 42
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1291, 699)
        Me.Controls.Add(Me.textboxCOM)
        Me.Controls.Add(Me.BtnFind)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnInstructions)
        Me.Controls.Add(Me.BtnMinus1)
        Me.Controls.Add(Me.BtnZero)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnAlarm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnStart)
        Me.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Xenon1900條碼閱讀機"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents BtnStart As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAlarm As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnZero As Button
    Friend WithEvents BtnMinus1 As Button
    Friend WithEvents BtnInstructions As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnFind As Button
    Friend WithEvents textboxCOM As TextBox
    Friend WithEvents Timer1 As Timer
End Class
