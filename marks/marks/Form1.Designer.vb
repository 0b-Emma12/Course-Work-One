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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtEnterMarks = New TextBox()
        txtGrade = New TextBox()
        btnEvaluate = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(224, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(336, 32)
        Label1.TabIndex = 0
        Label1.Text = "GRADING SCALE CALCULATOR"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(121, 244)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 32)
        Label2.TabIndex = 1
        Label2.Text = "Grade"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(121, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 32)
        Label3.TabIndex = 2
        Label3.Text = "Enter Marks"
        ' 
        ' txtEnterMarks
        ' 
        txtEnterMarks.Location = New Point(296, 156)
        txtEnterMarks.Name = "txtEnterMarks"
        txtEnterMarks.Size = New Size(408, 39)
        txtEnterMarks.TabIndex = 3
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(296, 237)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(408, 39)
        txtGrade.TabIndex = 4
        ' 
        ' btnEvaluate
        ' 
        btnEvaluate.Location = New Point(121, 335)
        btnEvaluate.Name = "btnEvaluate"
        btnEvaluate.Size = New Size(584, 46)
        btnEvaluate.TabIndex = 5
        btnEvaluate.Text = "Evaluate"
        btnEvaluate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnEvaluate)
        Controls.Add(txtGrade)
        Controls.Add(txtEnterMarks)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Grade Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEnterMarks As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents btnEvaluate As Button

End Class
