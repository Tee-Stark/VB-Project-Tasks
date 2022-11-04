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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblForm
        '
        Me.lblForm.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblForm.Location = New System.Drawing.Point(196, 76)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(466, 51)
        Me.lblForm.TabIndex = 0
        Me.lblForm.Text = "Quadratic Equation Solver"
        Me.lblForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(21, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(665, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To solve for ax^2 +  bx + c = 0, you are required to input the values of a, b, an" &
    "d c below."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(25, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter the value of A:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(25, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter the value of B:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(25, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Enter the value of C:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(12, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 37)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Results:"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(149, 160)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(287, 23)
        Me.txtA.TabIndex = 7
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(149, 190)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(287, 23)
        Me.txtB.TabIndex = 8
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(149, 221)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(287, 23)
        Me.txtC.TabIndex = 9
        '
        'calcButton
        '
        Me.calcButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.calcButton.Location = New System.Drawing.Point(236, 250)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(200, 50)
        Me.calcButton.TabIndex = 10
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'x1Label
        '
        Me.x1Label.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.x1Label.Location = New System.Drawing.Point(21, 355)
        Me.x1Label.Name = "x1Label"
        Me.x1Label.Size = New System.Drawing.Size(106, 15)
        Me.x1Label.TabIndex = 11
        Me.x1Label.Text = "X1:"
        '
        'lblX1
        '
        Me.lblX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblX1.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblX1.Location = New System.Drawing.Point(126, 352)
        Me.lblX1.Name = "lblX1"
        Me.lblX1.Size = New System.Drawing.Size(152, 23)
        Me.lblX1.TabIndex = 12
        '
        'x2Label
        '
        Me.x2Label.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.x2Label.Location = New System.Drawing.Point(21, 390)
        Me.x2Label.Name = "x2Label"
        Me.x2Label.Size = New System.Drawing.Size(25, 15)
        Me.x2Label.TabIndex = 14
        Me.x2Label.Text = "X2:"
        '
        'lblX2
        '
        Me.lblX2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblX2.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblX2.Location = New System.Drawing.Point(126, 382)
        Me.lblX2.Name = "lblX2"
        Me.lblX2.Size = New System.Drawing.Size(150, 23)
        Me.lblX2.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(21, 423)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Real Part:"
        '
        'lblReal
        '
        Me.lblReal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReal.Location = New System.Drawing.Point(126, 413)
        Me.lblReal.Name = "lblReal"
        Me.lblReal.Size = New System.Drawing.Size(150, 23)
        Me.lblReal.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(20, 451)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Imaginary Part:"
        '
        'lblImag
        '
        Me.lblImag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImag.Location = New System.Drawing.Point(126, 444)
        Me.lblImag.Name = "lblImag"
        Me.lblImag.Size = New System.Drawing.Size(150, 24)
        Me.lblImag.TabIndex = 19
        '
        'Xlabel
        '
        Me.Xlabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Xlabel.Location = New System.Drawing.Point(20, 324)
        Me.Xlabel.Name = "Xlabel"
        Me.Xlabel.Size = New System.Drawing.Size(100, 23)
        Me.Xlabel.TabIndex = 20
        Me.Xlabel.Text = "X:"
        '
        'lblX
        '
        Me.lblX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblX.Location = New System.Drawing.Point(126, 324)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(150, 23)
        Me.lblX.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(264, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(297, 21)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "NAME: OMOLANA TIMILEHIN EZEKIEL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(264, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(231, 21)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "MATRIC NUMBER: 210806079"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(264, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(347, 21)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "DEPARTMENT: MATHEMATICS (INDUSTRIAL)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 473)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
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
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
