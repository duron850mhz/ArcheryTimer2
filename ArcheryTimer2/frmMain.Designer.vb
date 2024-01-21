<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.btnSetting = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblTimer
        '
        Me.lblTimer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTimer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(12, 9)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(760, 483)
        Me.lblTimer.TabIndex = 0
        Me.lblTimer.Text = "9:99"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTimer.UseMnemonic = False
        '
        'btnSetting
        '
        Me.btnSetting.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSetting.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSetting.Location = New System.Drawing.Point(12, 495)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(130, 54)
        Me.btnSetting.TabIndex = 5
        Me.btnSetting.Text = "設定"
        Me.btnSetting.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStart.Location = New System.Drawing.Point(234, 495)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(130, 54)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "開始"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPause.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnPause.Location = New System.Drawing.Point(370, 495)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(130, 54)
        Me.btnPause.TabIndex = 2
        Me.btnPause.Text = "中断"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStop.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStop.Location = New System.Drawing.Point(506, 495)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(130, 54)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "停止"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(642, 495)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(130, 54)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "終了"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnSetting)
        Me.Controls.Add(Me.lblTimer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ArcheryTimer2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTimer As Label
    Friend WithEvents btnSetting As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents Timer1 As Timer
End Class
