<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoBasic = New System.Windows.Forms.RadioButton()
        Me.rdoStandard = New System.Windows.Forms.RadioButton()
        Me.rdoPremium = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClientPurchases = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalPoints = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoPremium)
        Me.GroupBox1.Controls.Add(Me.rdoStandard)
        Me.GroupBox1.Controls.Add(Me.rdoBasic)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Membership Type:"
        '
        'rdoBasic
        '
        Me.rdoBasic.AutoSize = True
        Me.rdoBasic.Location = New System.Drawing.Point(41, 20)
        Me.rdoBasic.Name = "rdoBasic"
        Me.rdoBasic.Size = New System.Drawing.Size(51, 17)
        Me.rdoBasic.TabIndex = 0
        Me.rdoBasic.TabStop = True
        Me.rdoBasic.Text = "Basic"
        Me.rdoBasic.UseVisualStyleBackColor = True
        '
        'rdoStandard
        '
        Me.rdoStandard.AutoSize = True
        Me.rdoStandard.Location = New System.Drawing.Point(41, 45)
        Me.rdoStandard.Name = "rdoStandard"
        Me.rdoStandard.Size = New System.Drawing.Size(68, 17)
        Me.rdoStandard.TabIndex = 1
        Me.rdoStandard.TabStop = True
        Me.rdoStandard.Text = "Standard"
        Me.rdoStandard.UseVisualStyleBackColor = True
        '
        'rdoPremium
        '
        Me.rdoPremium.AutoSize = True
        Me.rdoPremium.Location = New System.Drawing.Point(41, 70)
        Me.rdoPremium.Name = "rdoPremium"
        Me.rdoPremium.Size = New System.Drawing.Size(65, 17)
        Me.rdoPremium.TabIndex = 2
        Me.rdoPremium.TabStop = True
        Me.rdoPremium.Text = "Premium"
        Me.rdoPremium.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total monthly purchases:"
        '
        'txtClientPurchases
        '
        Me.txtClientPurchases.Location = New System.Drawing.Point(292, 56)
        Me.txtClientPurchases.Name = "txtClientPurchases"
        Me.txtClientPurchases.Size = New System.Drawing.Size(136, 20)
        Me.txtClientPurchases.TabIndex = 2
        Me.txtClientPurchases.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(104, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Client reward points:"
        '
        'lblTotalPoints
        '
        Me.lblTotalPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPoints.Location = New System.Drawing.Point(212, 132)
        Me.lblTotalPoints.Name = "lblTotalPoints"
        Me.lblTotalPoints.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalPoints.TabIndex = 4
        Me.lblTotalPoints.Text = " "
        Me.lblTotalPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(131, 174)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(212, 174)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 211)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotalPoints)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtClientPurchases)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shopper Stoppers"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoPremium As RadioButton
    Friend WithEvents rdoStandard As RadioButton
    Friend WithEvents rdoBasic As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtClientPurchases As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalPoints As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
