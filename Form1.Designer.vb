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
        Me.lblForm = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.x1Label = New System.Windows.Forms.Label()
        Me.lblX1 = New System.Windows.Forms.Label()
        Me.x2Label = New System.Windows.Forms.Label()
        Me.lblX2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblReal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblImag = New System.Windows.Forms.Label()
        Me.Xlabel = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblForm
        '
        Me.lblForm.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblForm.Location = New System.Drawing.Point(12, 5)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(466, 51)
        Me.lblForm.TabIndex = 0
        Me.lblForm.Text = "Quadratic Equation Solver"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(21, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(415, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "You are required to input the values of a, b, and c below."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(25, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter the value of A:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(25, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter the value of B:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(25, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Enter the value of C:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(12, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 37)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Results:"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(149, 105)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(287, 23)
        Me.txtA.TabIndex = 7
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(149, 135)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(287, 23)
        Me.txtB.TabIndex = 8
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(149, 166)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(287, 23)
        Me.txtC.TabIndex = 9
        '
        'calcButton
        '
        Me.calcButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.calcButton.Location = New System.Drawing.Point(25, 222)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(140, 25)
        Me.calcButton.TabIndex = 10
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'x1Label
        '
        Me.x1Label.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.x1Label.Location = New System.Drawing.Point(21, 329)
        Me.x1Label.Name = "x1Label"
        Me.x1Label.Size = New System.Drawing.Size(106, 15)
        Me.x1Label.TabIndex = 11
        Me.x1Label.Text = "X1:"
        '
        'lblX1
        '
        Me.lblX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblX1.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblX1.Location = New System.Drawing.Point(126, 326)
        Me.lblX1.Name = "lblX1"
        Me.lblX1.Size = New System.Drawing.Size(152, 23)
        Me.lblX1.TabIndex = 12
        '
        'x2Label
        '
        Me.x2Label.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.x2Label.Location = New System.Drawing.Point(21, 364)
        Me.x2Label.Name = "x2Label"
        Me.x2Label.Size = New System.Drawing.Size(25, 15)
        Me.x2Label.TabIndex = 14
        Me.x2Label.Text = "X2:"
        '
        'lblX2
        '
        Me.lblX2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblX2.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblX2.Location = New System.Drawing.Point(126, 356)
        Me.lblX2.Name = "lblX2"
        Me.lblX2.Size = New System.Drawing.Size(150, 23)
        Me.lblX2.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(21, 397)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Real Part:"
        '
        'lblReal
        '
        Me.lblReal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReal.Location = New System.Drawing.Point(126, 387)
        Me.lblReal.Name = "lblReal"
        Me.lblReal.Size = New System.Drawing.Size(150, 23)
        Me.lblReal.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(20, 425)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Imaginary Part:"
        '
        'lblImag
        '
        Me.lblImag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImag.Location = New System.Drawing.Point(126, 418)
        Me.lblImag.Name = "lblImag"
        Me.lblImag.Size = New System.Drawing.Size(150, 24)
        Me.lblImag.TabIndex = 19
        '
        'Xlabel
        '
        Me.Xlabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Xlabel.Location = New System.Drawing.Point(20, 298)
        Me.Xlabel.Name = "Xlabel"
        Me.Xlabel.Size = New System.Drawing.Size(100, 23)
        Me.Xlabel.TabIndex = 20
        Me.Xlabel.Text = "X:"
        '
        'lblX
        '
        Me.lblX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblX.Location = New System.Drawing.Point(126, 298)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(150, 23)
        Me.lblX.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.Xlabel)
        Me.Controls.Add(Me.lblImag)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblReal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblX2)
        Me.Controls.Add(Me.x2Label)
        Me.Controls.Add(Me.lblX1)
        Me.Controls.Add(Me.x1Label)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblForm)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblForm As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents calcButton As Button
    Friend WithEvents x1Label As Label
    Friend WithEvents lblX1 As Label
    Friend WithEvents x2Label As Label
    Friend WithEvents lblX2 As Label
    Public WithEvents Label6 As Label
    Friend WithEvents lblReal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblImag As Label
    Friend WithEvents Xlabel As Label
    Friend WithEvents lblX As Label
End Class
