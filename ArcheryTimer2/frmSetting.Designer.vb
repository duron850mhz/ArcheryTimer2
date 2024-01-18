<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetting))
        Me.gbTime = New System.Windows.Forms.GroupBox()
        Me.lblTime2 = New System.Windows.Forms.Label()
        Me.lblTime5 = New System.Windows.Forms.Label()
        Me.txtTime2 = New System.Windows.Forms.TextBox()
        Me.lblTime1 = New System.Windows.Forms.Label()
        Me.lblTime4 = New System.Windows.Forms.Label()
        Me.txtTime1 = New System.Windows.Forms.TextBox()
        Me.lblTime0 = New System.Windows.Forms.Label()
        Me.lblTime3 = New System.Windows.Forms.Label()
        Me.txtTime0 = New System.Windows.Forms.TextBox()
        Me.gbColor = New System.Windows.Forms.GroupBox()
        Me.lblColor3 = New System.Windows.Forms.Label()
        Me.btnColor3 = New System.Windows.Forms.Button()
        Me.lblColor2 = New System.Windows.Forms.Label()
        Me.btnColor2 = New System.Windows.Forms.Button()
        Me.lblColor1 = New System.Windows.Forms.Label()
        Me.btnColor1 = New System.Windows.Forms.Button()
        Me.lblColor0 = New System.Windows.Forms.Label()
        Me.btnColor0 = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gbTime.SuspendLayout()
        Me.gbColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbTime
        '
        Me.gbTime.Controls.Add(Me.lblTime2)
        Me.gbTime.Controls.Add(Me.lblTime5)
        Me.gbTime.Controls.Add(Me.txtTime2)
        Me.gbTime.Controls.Add(Me.lblTime1)
        Me.gbTime.Controls.Add(Me.lblTime4)
        Me.gbTime.Controls.Add(Me.txtTime1)
        Me.gbTime.Controls.Add(Me.lblTime0)
        Me.gbTime.Controls.Add(Me.lblTime3)
        Me.gbTime.Controls.Add(Me.txtTime0)
        Me.gbTime.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbTime.Location = New System.Drawing.Point(12, 8)
        Me.gbTime.Name = "gbTime"
        Me.gbTime.Size = New System.Drawing.Size(210, 135)
        Me.gbTime.TabIndex = 0
        Me.gbTime.TabStop = False
        Me.gbTime.Text = "時間設定"
        '
        'lblTime2
        '
        Me.lblTime2.AutoSize = True
        Me.lblTime2.Location = New System.Drawing.Point(25, 85)
        Me.lblTime2.Name = "lblTime2"
        Me.lblTime2.Size = New System.Drawing.Size(72, 16)
        Me.lblTime2.TabIndex = 6
        Me.lblTime2.Text = "変更秒数"
        '
        'lblTime5
        '
        Me.lblTime5.AutoSize = True
        Me.lblTime5.Location = New System.Drawing.Point(173, 85)
        Me.lblTime5.Name = "lblTime5"
        Me.lblTime5.Size = New System.Drawing.Size(24, 16)
        Me.lblTime5.TabIndex = 8
        Me.lblTime5.Text = "秒"
        '
        'txtTime2
        '
        Me.txtTime2.Location = New System.Drawing.Point(102, 82)
        Me.txtTime2.Name = "txtTime2"
        Me.txtTime2.Size = New System.Drawing.Size(66, 23)
        Me.txtTime2.TabIndex = 7
        Me.txtTime2.Text = "10"
        Me.txtTime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTime1
        '
        Me.lblTime1.AutoSize = True
        Me.lblTime1.Location = New System.Drawing.Point(25, 56)
        Me.lblTime1.Name = "lblTime1"
        Me.lblTime1.Size = New System.Drawing.Size(72, 16)
        Me.lblTime1.TabIndex = 3
        Me.lblTime1.Text = "設定秒数"
        '
        'lblTime4
        '
        Me.lblTime4.AutoSize = True
        Me.lblTime4.Location = New System.Drawing.Point(173, 56)
        Me.lblTime4.Name = "lblTime4"
        Me.lblTime4.Size = New System.Drawing.Size(24, 16)
        Me.lblTime4.TabIndex = 5
        Me.lblTime4.Text = "秒"
        '
        'txtTime1
        '
        Me.txtTime1.Location = New System.Drawing.Point(102, 53)
        Me.txtTime1.Name = "txtTime1"
        Me.txtTime1.Size = New System.Drawing.Size(66, 23)
        Me.txtTime1.TabIndex = 4
        Me.txtTime1.Text = "10"
        Me.txtTime1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTime0
        '
        Me.lblTime0.AutoSize = True
        Me.lblTime0.Location = New System.Drawing.Point(25, 27)
        Me.lblTime0.Name = "lblTime0"
        Me.lblTime0.Size = New System.Drawing.Size(72, 16)
        Me.lblTime0.TabIndex = 0
        Me.lblTime0.Text = "事前秒数"
        '
        'lblTime3
        '
        Me.lblTime3.AutoSize = True
        Me.lblTime3.Location = New System.Drawing.Point(173, 27)
        Me.lblTime3.Name = "lblTime3"
        Me.lblTime3.Size = New System.Drawing.Size(24, 16)
        Me.lblTime3.TabIndex = 2
        Me.lblTime3.Text = "秒"
        '
        'txtTime0
        '
        Me.txtTime0.Location = New System.Drawing.Point(102, 24)
        Me.txtTime0.Name = "txtTime0"
        Me.txtTime0.Size = New System.Drawing.Size(66, 23)
        Me.txtTime0.TabIndex = 1
        Me.txtTime0.Text = "10"
        Me.txtTime0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbColor
        '
        Me.gbColor.Controls.Add(Me.lblColor3)
        Me.gbColor.Controls.Add(Me.btnColor3)
        Me.gbColor.Controls.Add(Me.lblColor2)
        Me.gbColor.Controls.Add(Me.btnColor2)
        Me.gbColor.Controls.Add(Me.lblColor1)
        Me.gbColor.Controls.Add(Me.btnColor1)
        Me.gbColor.Controls.Add(Me.lblColor0)
        Me.gbColor.Controls.Add(Me.btnColor0)
        Me.gbColor.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbColor.Location = New System.Drawing.Point(12, 149)
        Me.gbColor.Name = "gbColor"
        Me.gbColor.Size = New System.Drawing.Size(210, 185)
        Me.gbColor.TabIndex = 1
        Me.gbColor.TabStop = False
        Me.gbColor.Text = "表示色設定"
        '
        'lblColor3
        '
        Me.lblColor3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblColor3.Location = New System.Drawing.Point(98, 130)
        Me.lblColor3.Name = "lblColor3"
        Me.lblColor3.Size = New System.Drawing.Size(94, 30)
        Me.lblColor3.TabIndex = 7
        '
        'btnColor3
        '
        Me.btnColor3.Location = New System.Drawing.Point(20, 130)
        Me.btnColor3.Name = "btnColor3"
        Me.btnColor3.Size = New System.Drawing.Size(72, 30)
        Me.btnColor3.TabIndex = 6
        Me.btnColor3.Text = "変更色"
        Me.btnColor3.UseVisualStyleBackColor = True
        '
        'lblColor2
        '
        Me.lblColor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblColor2.Location = New System.Drawing.Point(98, 94)
        Me.lblColor2.Name = "lblColor2"
        Me.lblColor2.Size = New System.Drawing.Size(94, 30)
        Me.lblColor2.TabIndex = 5
        '
        'btnColor2
        '
        Me.btnColor2.Location = New System.Drawing.Point(20, 94)
        Me.btnColor2.Name = "btnColor2"
        Me.btnColor2.Size = New System.Drawing.Size(72, 30)
        Me.btnColor2.TabIndex = 4
        Me.btnColor2.Text = "通常色"
        Me.btnColor2.UseVisualStyleBackColor = True
        '
        'lblColor1
        '
        Me.lblColor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblColor1.Location = New System.Drawing.Point(98, 58)
        Me.lblColor1.Name = "lblColor1"
        Me.lblColor1.Size = New System.Drawing.Size(94, 30)
        Me.lblColor1.TabIndex = 3
        '
        'btnColor1
        '
        Me.btnColor1.Location = New System.Drawing.Point(20, 58)
        Me.btnColor1.Name = "btnColor1"
        Me.btnColor1.Size = New System.Drawing.Size(72, 30)
        Me.btnColor1.TabIndex = 2
        Me.btnColor1.Text = "事前色"
        Me.btnColor1.UseVisualStyleBackColor = True
        '
        'lblColor0
        '
        Me.lblColor0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblColor0.Location = New System.Drawing.Point(98, 22)
        Me.lblColor0.Name = "lblColor0"
        Me.lblColor0.Size = New System.Drawing.Size(94, 30)
        Me.lblColor0.TabIndex = 1
        '
        'btnColor0
        '
        Me.btnColor0.Location = New System.Drawing.Point(20, 22)
        Me.btnColor0.Name = "btnColor0"
        Me.btnColor0.Size = New System.Drawing.Size(72, 30)
        Me.btnColor0.TabIndex = 0
        Me.btnColor0.Text = "背景色"
        Me.btnColor0.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnOk.Location = New System.Drawing.Point(145, 338)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(81, 33)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "登録"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(12, 338)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(81, 33)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(238, 383)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.gbColor)
        Me.Controls.Add(Me.gbTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSetting"
        Me.Text = "動作設定"
        Me.gbTime.ResumeLayout(False)
        Me.gbTime.PerformLayout()
        Me.gbColor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbTime As GroupBox
    Friend WithEvents gbColor As GroupBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTime2 As Label
    Friend WithEvents lblTime5 As Label
    Friend WithEvents txtTime2 As TextBox
    Friend WithEvents lblTime1 As Label
    Friend WithEvents lblTime4 As Label
    Friend WithEvents txtTime1 As TextBox
    Friend WithEvents lblTime0 As Label
    Friend WithEvents lblTime3 As Label
    Friend WithEvents txtTime0 As TextBox
    Friend WithEvents lblColor3 As Label
    Friend WithEvents btnColor3 As Button
    Friend WithEvents lblColor2 As Label
    Friend WithEvents btnColor2 As Button
    Friend WithEvents lblColor1 As Label
    Friend WithEvents btnColor1 As Button
    Friend WithEvents lblColor0 As Label
    Friend WithEvents btnColor0 As Button
End Class
