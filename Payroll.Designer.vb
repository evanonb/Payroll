<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payroll
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
        Me.lblHeader1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHeader2 = New System.Windows.Forms.Label()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btmComputeTaxes = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.lblFederalTax = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblNetPaycheckIncome = New System.Windows.Forms.Label()
        Me.lblFicaOutput = New System.Windows.Forms.Label()
        Me.lblFederalOutput = New System.Windows.Forms.Label()
        Me.lblStateOutput = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader1
        '
        Me.lblHeader1.AutoSize = True
        Me.lblHeader1.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader1.Font = New System.Drawing.Font("Elephant", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader1.ForeColor = System.Drawing.Color.DimGray
        Me.lblHeader1.Location = New System.Drawing.Point(489, 64)
        Me.lblHeader1.Name = "lblHeader1"
        Me.lblHeader1.Size = New System.Drawing.Size(387, 51)
        Me.lblHeader1.TabIndex = 0
        Me.lblHeader1.Text = "Payroll Calculator"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Payroll.My.Resources.Resources.payroll
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(409, 275)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblHeader2
        '
        Me.lblHeader2.AutoSize = True
        Me.lblHeader2.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader2.Font = New System.Drawing.Font("Elephant", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader2.ForeColor = System.Drawing.Color.DimGray
        Me.lblHeader2.Location = New System.Drawing.Point(526, 179)
        Me.lblHeader2.Name = "lblHeader2"
        Me.lblHeader2.Size = New System.Drawing.Size(307, 35)
        Me.lblHeader2.TabIndex = 2
        Me.lblHeader2.Text = "Paycheck Calculation"
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.BackColor = System.Drawing.Color.Transparent
        Me.lblInput.Font = New System.Drawing.Font("Elephant", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInput.ForeColor = System.Drawing.Color.DimGray
        Me.lblInput.Location = New System.Drawing.Point(201, 320)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(249, 35)
        Me.lblInput.TabIndex = 3
        Me.lblInput.Text = "Enter Gross Pay:"
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(498, 318)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 38)
        Me.txtInput.TabIndex = 4
        '
        'btmComputeTaxes
        '
        Me.btmComputeTaxes.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btmComputeTaxes.Font = New System.Drawing.Font("Elephant", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmComputeTaxes.Location = New System.Drawing.Point(97, 388)
        Me.btmComputeTaxes.Name = "btmComputeTaxes"
        Me.btmComputeTaxes.Size = New System.Drawing.Size(200, 60)
        Me.btmComputeTaxes.TabIndex = 5
        Me.btmComputeTaxes.Text = "Compute Taxes"
        Me.btmComputeTaxes.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnExit.Font = New System.Drawing.Font("Elephant", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(647, 388)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(200, 60)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Elephant", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(372, 388)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(200, 60)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblFICA
        '
        Me.lblFICA.AutoSize = True
        Me.lblFICA.BackColor = System.Drawing.Color.Transparent
        Me.lblFICA.Font = New System.Drawing.Font("Elephant", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICA.ForeColor = System.Drawing.Color.DimGray
        Me.lblFICA.Location = New System.Drawing.Point(92, 480)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(72, 25)
        Me.lblFICA.TabIndex = 8
        Me.lblFICA.Text = "FICA:"
        '
        'lblFederalTax
        '
        Me.lblFederalTax.AutoSize = True
        Me.lblFederalTax.BackColor = System.Drawing.Color.Transparent
        Me.lblFederalTax.Font = New System.Drawing.Font("Elephant", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalTax.ForeColor = System.Drawing.Color.DimGray
        Me.lblFederalTax.Location = New System.Drawing.Point(367, 480)
        Me.lblFederalTax.Name = "lblFederalTax"
        Me.lblFederalTax.Size = New System.Drawing.Size(133, 25)
        Me.lblFederalTax.TabIndex = 9
        Me.lblFederalTax.Text = "Federal Tax:"
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.BackColor = System.Drawing.Color.Transparent
        Me.lblStateTax.Font = New System.Drawing.Font("Elephant", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTax.ForeColor = System.Drawing.Color.DimGray
        Me.lblStateTax.Location = New System.Drawing.Point(642, 480)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(109, 25)
        Me.lblStateTax.TabIndex = 10
        Me.lblStateTax.Text = "State Tax:"
        '
        'lblNetPaycheckIncome
        '
        Me.lblNetPaycheckIncome.AutoSize = True
        Me.lblNetPaycheckIncome.BackColor = System.Drawing.Color.Transparent
        Me.lblNetPaycheckIncome.Font = New System.Drawing.Font("Elephant", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPaycheckIncome.ForeColor = System.Drawing.Color.DimGray
        Me.lblNetPaycheckIncome.Location = New System.Drawing.Point(158, 557)
        Me.lblNetPaycheckIncome.Name = "lblNetPaycheckIncome"
        Me.lblNetPaycheckIncome.Size = New System.Drawing.Size(316, 35)
        Me.lblNetPaycheckIncome.TabIndex = 11
        Me.lblNetPaycheckIncome.Text = "Net Paycheck Income:"
        '
        'lblFicaOutput
        '
        Me.lblFicaOutput.AutoSize = True
        Me.lblFicaOutput.BackColor = System.Drawing.Color.Transparent
        Me.lblFicaOutput.Font = New System.Drawing.Font("Elephant", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFicaOutput.ForeColor = System.Drawing.Color.DimGray
        Me.lblFicaOutput.Location = New System.Drawing.Point(170, 480)
        Me.lblFicaOutput.Name = "lblFicaOutput"
        Me.lblFicaOutput.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFicaOutput.Size = New System.Drawing.Size(0, 25)
        Me.lblFicaOutput.TabIndex = 12
        '
        'lblFederalOutput
        '
        Me.lblFederalOutput.AutoSize = True
        Me.lblFederalOutput.BackColor = System.Drawing.Color.Transparent
        Me.lblFederalOutput.Font = New System.Drawing.Font("Elephant", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalOutput.ForeColor = System.Drawing.Color.DimGray
        Me.lblFederalOutput.Location = New System.Drawing.Point(506, 480)
        Me.lblFederalOutput.Name = "lblFederalOutput"
        Me.lblFederalOutput.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFederalOutput.Size = New System.Drawing.Size(0, 25)
        Me.lblFederalOutput.TabIndex = 13
        '
        'lblStateOutput
        '
        Me.lblStateOutput.AutoSize = True
        Me.lblStateOutput.BackColor = System.Drawing.Color.Transparent
        Me.lblStateOutput.Font = New System.Drawing.Font("Elephant", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateOutput.ForeColor = System.Drawing.Color.DimGray
        Me.lblStateOutput.Location = New System.Drawing.Point(757, 480)
        Me.lblStateOutput.Name = "lblStateOutput"
        Me.lblStateOutput.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStateOutput.Size = New System.Drawing.Size(0, 25)
        Me.lblStateOutput.TabIndex = 14
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.BackColor = System.Drawing.Color.Transparent
        Me.lblOutput.Font = New System.Drawing.Font("Elephant", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.ForeColor = System.Drawing.Color.DimGray
        Me.lblOutput.Location = New System.Drawing.Point(681, 557)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 35)
        Me.lblOutput.TabIndex = 15
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(945, 650)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblStateOutput)
        Me.Controls.Add(Me.lblFederalOutput)
        Me.Controls.Add(Me.lblFicaOutput)
        Me.Controls.Add(Me.lblNetPaycheckIncome)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblFederalTax)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btmComputeTaxes)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.lblHeader2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblHeader1)
        Me.Name = "Payroll"
        Me.Text = "Payroll Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHeader2 As Label
    Friend WithEvents lblInput As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btmComputeTaxes As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblFederalTax As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblNetPaycheckIncome As Label
    Friend WithEvents lblFicaOutput As Label
    Friend WithEvents lblFederalOutput As Label
    Friend WithEvents lblStateOutput As Label
    Friend WithEvents lblOutput As Label
End Class
