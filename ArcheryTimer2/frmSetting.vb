Imports System.ComponentModel

Public Class frmSetting
    ''' <summary>
    ''' 取消
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' 色選択
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor0.Click,
                                                                         btnColor1.Click,
                                                                         btnColor2.Click,
                                                                         btnColor3.Click
        Dim lblTarget As New Label
        Select Case True
            Case sender Is btnColor0
                lblTarget = lblColor0
            Case sender Is btnColor1
                lblTarget = lblColor1
            Case sender Is btnColor2
                lblTarget = lblColor2
            Case sender Is btnColor3
                lblTarget = lblColor3
        End Select

        Using cd As New ColorDialog()
            cd.Color = lblTarget.BackColor
            If cd.ShowDialog() = DialogResult.OK Then
                lblTarget.BackColor = cd.Color
            End If
        End Using
    End Sub

    ''' <summary>
    ''' 初期設定
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTime0.Text = XX_Option.iStartTime
        txtTime1.Text = XX_Option.iTime
        txtTime2.Text = XX_Option.iChangeTime
        lblColor0.BackColor = XX_Option.cBackColor
        lblColor1.BackColor = XX_Option.cStartColor
        lblColor2.BackColor = XX_Option.cTimerColor
        lblColor3.BackColor = XX_Option.cChangeColor
    End Sub

    ''' <summary>
    ''' 登録
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmSetting_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.DialogResult = DialogResult.OK Then
            XX_Option.iStartTime = Val(txtTime0.Text)
            XX_Option.iTime = Val(txtTime1.Text)
            XX_Option.iChangeTime = Val(txtTime2.Text)
            XX_Option.cBackColor = lblColor0.BackColor
            XX_Option.cStartColor = lblColor1.BackColor
            XX_Option.cTimerColor = lblColor2.BackColor
            XX_Option.cChangeColor = lblColor3.BackColor
            Call G_RWOption(EN_RW.write)
        End If
    End Sub

    Private Sub txtTime_Validating(sender As Object, e As CancelEventArgs) Handles txtTime0.Validating,
                                                                                   txtTime1.Validating,
                                                                                   txtTime2.Validating
        Dim strMsg As String = ""
        Dim bRet As Boolean = True

        Dim txtTarget As New TextBox
        Select Case True
            Case sender Is txtTime0
                txtTarget = txtTime0
            Case sender Is txtTime1
                txtTarget = txtTime1
            Case sender Is txtTime2
                txtTarget = txtTime2
        End Select

        '---< Init >---
        If (txtTarget.Text = "") Then
            strMsg = "秒数を入力してください"
            txtTarget.Focus()
            bRet = False
        End If

        If (bRet = True) Then
            If (IsNumeric(txtTarget.Text) = False) Then
                strMsg = "数値のみ入力可能です"
                txtTarget.Focus()
                bRet = False
            End If
        End If

        If (bRet = True) Then
            If (Val(txtTarget.Text) > 599) Then
                strMsg = "9分59秒以上は設定できません"
                txtTarget.Focus()
                bRet = False
            End If
        End If

        If (bRet = False) Then
            MessageBox.Show(strMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub
End Class