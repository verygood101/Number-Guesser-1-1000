<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblGuess = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnLower = New System.Windows.Forms.Button()
        Me.btnHigher = New System.Windows.Forms.Button()
        Me.btnCorrect = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 22.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(290, 111)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(668, 78)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Number Guessing Game"
        '
        'lblGuess
        '
        Me.lblGuess.AutoSize = True
        Me.lblGuess.Font = New System.Drawing.Font("Segoe UI", 19.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGuess.Location = New System.Drawing.Point(397, 258)
        Me.lblGuess.Name = "lblGuess"
        Me.lblGuess.Size = New System.Drawing.Size(451, 71)
        Me.lblGuess.TabIndex = 1
        Me.lblGuess.Text = "Click Start to Play!"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(548, 378)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(173, 73)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start!"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnLower
        '
        Me.btnLower.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLower.Location = New System.Drawing.Point(371, 464)
        Me.btnLower.Name = "btnLower"
        Me.btnLower.Size = New System.Drawing.Size(208, 107)
        Me.btnLower.TabIndex = 3
        Me.btnLower.Text = "Lower"
        Me.btnLower.UseVisualStyleBackColor = False
        '
        'btnHigher
        '
        Me.btnHigher.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnHigher.Location = New System.Drawing.Point(675, 464)
        Me.btnHigher.Name = "btnHigher"
        Me.btnHigher.Size = New System.Drawing.Size(208, 107)
        Me.btnHigher.TabIndex = 4
        Me.btnHigher.Text = "Higher"
        Me.btnHigher.UseVisualStyleBackColor = False
        '
        'btnCorrect
        '
        Me.btnCorrect.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCorrect.Location = New System.Drawing.Point(548, 605)
        Me.btnCorrect.Name = "btnCorrect"
        Me.btnCorrect.Size = New System.Drawing.Size(173, 73)
        Me.btnCorrect.TabIndex = 5
        Me.btnCorrect.Text = "Correct!"
        Me.btnCorrect.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Location = New System.Drawing.Point(1033, 669)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(173, 73)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Segoe UI", 22.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblScore.Location = New System.Drawing.Point(1124, 26)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(65, 78)
        Me.lblScore.TabIndex = 7
        Me.lblScore.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 784)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCorrect)
        Me.Controls.Add(Me.btnHigher)
        Me.Controls.Add(Me.btnLower)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblGuess)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Number Guessing Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblGuess As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnLower As Button
    Friend WithEvents btnHigher As Button
    Friend WithEvents btnCorrect As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblScore As Label
End Class
