<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1Home))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMenuTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.btnStatementDetails = New System.Windows.Forms.Button()
        Me.btnCustomerDetails = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblMenuTitle)
        Me.Panel1.Controls.Add(Me.lblSubtitle)
        Me.Panel1.Controls.Add(Me.btnStatementDetails)
        Me.Panel1.Controls.Add(Me.btnCustomerDetails)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'lblMenuTitle
        '
        resources.ApplyResources(Me.lblMenuTitle, "lblMenuTitle")
        Me.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.lblMenuTitle.Name = "lblMenuTitle"
        '
        'lblSubtitle
        '
        resources.ApplyResources(Me.lblSubtitle, "lblSubtitle")
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.lblSubtitle.Name = "lblSubtitle"
        '
        'btnStatementDetails
        '
        Me.btnStatementDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btnStatementDetails.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnStatementDetails, "btnStatementDetails")
        Me.btnStatementDetails.ForeColor = System.Drawing.Color.White
        Me.btnStatementDetails.Name = "btnStatementDetails"
        Me.btnStatementDetails.UseVisualStyleBackColor = False
        '
        'btnCustomerDetails
        '
        Me.btnCustomerDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btnCustomerDetails.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnCustomerDetails, "btnCustomerDetails")
        Me.btnCustomerDetails.ForeColor = System.Drawing.Color.White
        Me.btnCustomerDetails.Name = "btnCustomerDetails"
        Me.btnCustomerDetails.UseVisualStyleBackColor = False
        '
        'Form1Home
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1Home"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblMenuTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents btnStatementDetails As Button
    Friend WithEvents btnCustomerDetails As Button
End Class
