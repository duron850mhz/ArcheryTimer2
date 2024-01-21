Imports System.ComponentModel
Imports System.IO

Public Class frmMain
    Dim LG_iCounter As Integer          '現在秒数
    Dim LG_iStartCounter As Integer     '現在事前秒数
    Dim LG_bPause As Boolean            'True=中断中
    Dim LG_Size As New SizeF()          '変更前サイズ
    Dim LG_bShown As Boolean = False    'フォーム表示後

    ''' <summary>
    ''' App.Path
    ''' </summary>
    ReadOnly LG_strAppPath As String = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)

    ''' <summary>
    ''' フォーム初期化
    ''' </summary>
    Private Sub I_FormInit()
        lblTimer.Text = I_GetTimerCaption(XX_Option.iStartTime)
        lblTimer.BackColor = XX_Option.cBackColor
        lblTimer.ForeColor = XX_Option.cStartColor
    End Sub

    ''' <summary>
    ''' 秒 → 分:秒 変換
    ''' </summary>
    ''' <param name="lTime"></param>
    ''' <returns></returns>
    Private Function I_GetTimerCaption(lTime As Long) As String
        If (lTime < 0) Then
            lTime = 0
        End If
        I_GetTimerCaption = Format$(lTime \ 60) & ":" & Format$((lTime Mod 60), "00")
    End Function

    ''' <summary>
    ''' 音を鳴らす
    '''
    ''' 0:ぴっぴー
    ''' 1:ぴっ    
    ''' </summary>
    ''' <param name="iKind"></param>
    Private Sub I_PlaySound(iKind As Integer)
        Select Case iKind
            Case 0
                Dim strm As System.IO.Stream = My.Resources.Start
                My.Computer.Audio.Play(strm, AudioPlayMode.WaitToComplete)
                strm = My.Resources.Last
                My.Computer.Audio.Play(strm, AudioPlayMode.Background)
            Case 1
                Dim strm As System.IO.Stream = My.Resources.Start
                My.Computer.Audio.Play(strm, AudioPlayMode.Background)
        End Select
    End Sub

    ''' <summary>
    ''' 中断押下
    ''' </summary>
    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        If (LG_bPause = False) Then
            Timer1.Enabled = False
            btnPause.Text = "再開"
            LG_bPause = True
        Else
            Timer1.Enabled = True
            btnPause.Text = "中断"
            LG_bPause = False
        End If
    End Sub

    ''' <summary>
    ''' 終了
    ''' </summary>
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Timer1.Enabled = False
        Me.Close()
    End Sub

    ''' <summary>
    ''' 設定
    ''' </summary>
    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        Using _frm As New frmSetting
            If _frm.ShowDialog = DialogResult.OK Then
                Call I_FormInit()
            End If
        End Using
    End Sub

    ''' <summary>
    ''' 開始
    ''' </summary>
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Call I_FormInit()

        If (LG_bPause = True) Then
            LG_bPause = False
            btnPause.Text = "中断"
        End If
        LG_iCounter = XX_Option.iTime
        LG_iStartCounter = XX_Option.iStartTime
        LG_bPause = False
        btnPause.Enabled = True
        Call I_PlaySound(0)
        Timer1.Enabled = True
        btnStop.Focus()
    End Sub

    ''' <summary>
    ''' 停止
    ''' </summary>
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Enabled = False
        If (LG_bPause = True) Then
            LG_bPause = False
            btnPause.Text = "中断"
        End If
        btnPause.Enabled = False

        If (LG_iStartCounter > 0) Then
            LG_iStartCounter = 0
        End If
        If (LG_iCounter > 0) Then
            LG_iCounter = 0
            lblTimer.Text = I_GetTimerCaption(0)
            'Call I_PlaySound(0)
        End If
    End Sub

    ''' <summary>
    ''' Form Closing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Select Case Me.WindowState
            Case FormWindowState.Normal
                XX_Option.iWidth = Me.ClientSize.Width
                XX_Option.iHeight = Me.ClientSize.Height
                XX_Option.iTop = Me.Top
                XX_Option.iLeft = Me.Left
                XX_Option.bMaximized = False
            Case FormWindowState.Minimized
                XX_Option.bMaximized = False
            Case FormWindowState.Maximized
                XX_Option.bMaximized = True
        End Select

        Call G_RWOption(EN_RW.write)
    End Sub

    ''' <summary>
    ''' Form Load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '---< Read Ini >---
        Call G_RWOption(EN_RW.read)

        '---< Init >---
        LG_bPause = False

        '---< Form Init >---
        Timer1.Enabled = False
        btnPause.Enabled = False
        Call I_FormInit()
    End Sub

    ''' <summary>
    ''' フォームサイズ変更
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If LG_bShown = True Then
            Call I_ChangeFontSize()
        End If
    End Sub

    ''' <summary>
    ''' フォーム表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LG_bShown = True

        Me.Top = XX_Option.iTop
        Me.Left = XX_Option.iLeft

        If XX_Option.iWidth >= MyBase.MinimumSize.Width Then
            If XX_Option.iHeight >= MyBase.MinimumSize.Height Then
                Me.ClientSize = New Size(XX_Option.iWidth, XX_Option.iHeight)
            End If
        End If

        If XX_Option.bMaximized = True Then
            Me.WindowState = FormWindowState.Maximized
        End If

        Call I_ChangeFontSize()
    End Sub

    ''' <summary>
    ''' 時間経過
    ''' </summary>
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (LG_iStartCounter <> 0) Then
            '事前カウント分
            LG_iStartCounter -= 1
            lblTimer.Text = I_GetTimerCaption(LG_iStartCounter)
            If (LG_iStartCounter = 0) Then
                '事前カウント終了
                Call I_PlaySound(1)
                lblTimer.Text = I_GetTimerCaption(XX_Option.iTime)
                lblTimer.ForeColor = XX_Option.cTimerColor
            End If
        Else
            '通常カウント分
            LG_iCounter -= 1
            lblTimer.Text = I_GetTimerCaption(LG_iCounter)
            If (LG_iCounter = XX_Option.iChangeTime) Then
                '色変更
                lblTimer.ForeColor = XX_Option.cChangeColor
                'Call I_PlaySound(1)
            End If
        End If

        If (LG_iCounter = 0) Then
            '通常カウント終了
            Call I_PlaySound(0)
            Timer1.Enabled = False
            btnStart.Focus()
        End If
    End Sub

    ''' <summary>
    ''' フォントサイズ変更
    ''' </summary>
    Private Sub I_ChangeFontSize()

        Dim iWidth As Integer = 0
        Dim iHeight As Integer = 0

        Do
            Dim bPlus As Boolean = True
            If LG_Size.Width > MyBase.Width Or LG_Size.Height > MyBase.Height Then
                '縮めた
                If lblTimer.Font.Size <= 1 Then
                    Exit Do
                End If
                bPlus = False
            End If
            Dim g As Graphics = lblTimer.CreateGraphics()
            iWidth = g.MeasureString(lblTimer.Text, lblTimer.Font).Width * 1.05
            iHeight = g.MeasureString(lblTimer.Text, lblTimer.Font).Height + 0

            If bPlus Then
                If (lblTimer.Width > iWidth) And (lblTimer.Height > iHeight) Then
                    lblTimer.Font = New Font(lblTimer.Font.FontFamily, lblTimer.Font.Size + 1)
                Else
                    lblTimer.Font = New Font(lblTimer.Font.FontFamily, lblTimer.Font.Size - 1)
                    LG_Size = MyBase.Size
                    Exit Do
                End If
            Else
                If (lblTimer.Width < iWidth) Or (lblTimer.Height < iHeight) Then
                    lblTimer.Font = New Font(lblTimer.Font.FontFamily, lblTimer.Font.Size - 1)
                    If lblTimer.Font.Size <= 1 Then
                        Exit Do
                    End If
                Else
                    lblTimer.Font = New Font(lblTimer.Font.FontFamily, lblTimer.Font.Size + 1)
                    LG_Size = MyBase.Size
                    Exit Do
                End If
            End If
        Loop
    End Sub
End Class
