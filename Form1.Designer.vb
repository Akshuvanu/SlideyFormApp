<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCreateSubmissions = New System.Windows.Forms.Button()
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreateSubmissions
        '
        Me.btnCreateSubmissions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreateSubmissions.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCreateSubmissions.Location = New System.Drawing.Point(290, 168)
        Me.btnCreateSubmissions.Name = "btnCreateSubmissions"
        Me.btnCreateSubmissions.Size = New System.Drawing.Size(259, 73)
        Me.btnCreateSubmissions.TabIndex = 1
        Me.btnCreateSubmissions.Text = "CREATE NEW SUBMISSIONS (CTRL + N)"
        Me.btnCreateSubmissions.UseVisualStyleBackColor = False
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.Location = New System.Drawing.Point(290, 75)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(259, 68)
        Me.btnViewSubmissions.TabIndex = 2
        Me.btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        Me.btnViewSubmissions.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.Controls.Add(Me.btnCreateSubmissions)
        Me.Name = "Form1"
        Me.Text = "My App"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCreateSubmissions As Button
    Friend WithEvents btnViewSubmissions As Button
End Class
