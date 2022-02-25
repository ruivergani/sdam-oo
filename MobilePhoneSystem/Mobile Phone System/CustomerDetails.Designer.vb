<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerDetails))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCustomerDetails = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(306, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Details"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(624, 49)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(135, 33)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "RETURN MENU"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.Location = New System.Drawing.Point(281, 272)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(136, 29)
        Me.txtMobileNo.TabIndex = 16
        Me.txtMobileNo.Text = "071234-456789"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(101, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Mobile Number"
        '
        'txtPostCode
        '
        Me.txtPostCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostCode.Location = New System.Drawing.Point(281, 222)
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(123, 29)
        Me.txtPostCode.TabIndex = 14
        Me.txtPostCode.Text = "KT1 2AQ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(101, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "PostCode"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(281, 172)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(259, 29)
        Me.txtAddress.TabIndex = 12
        Me.txtAddress.Text = "Kingston College"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(101, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Addresss"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(281, 123)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(179, 27)
        Me.txtName.TabIndex = 10
        Me.txtName.Text = "Abrar Hamid"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(101, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Customer Name"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Window
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(99, 322)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(692, 148)
        Me.ListView1.TabIndex = 17
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer Name"
        Me.ColumnHeader1.Width = 168
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Address"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 208
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PostCode"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 99
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Mobile Number"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 213
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCustomer.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCustomer.ForeColor = System.Drawing.Color.White
        Me.btnAddCustomer.Location = New System.Drawing.Point(642, 114)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(149, 45)
        Me.btnAddCustomer.TabIndex = 18
        Me.btnAddCustomer.Text = "ADD CUSTOMER"
        Me.btnAddCustomer.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(410, 492)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 42)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(254, 492)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(130, 42)
        Me.btnEdit.TabIndex = 20
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(99, 492)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(130, 42)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCustomerDetails)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtMobileNo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnAddCustomer)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.txtPostCode)
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.lblSubtitle)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(877, 606)
        Me.Panel1.TabIndex = 22
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Italic)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.lblSubtitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSubtitle.Location = New System.Drawing.Point(240, 577)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(359, 20)
        Me.lblSubtitle.TabIndex = 2
        Me.lblSubtitle.Text = "Mobile Phone System @ 2021 - Developed by Rui Neto"
        Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(244, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(765, 49)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 33)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCustomerDetails
        '
        Me.btnCustomerDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnCustomerDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomerDetails.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerDetails.ForeColor = System.Drawing.Color.White
        Me.btnCustomerDetails.Location = New System.Drawing.Point(600, 489)
        Me.btnCustomerDetails.Name = "btnCustomerDetails"
        Me.btnCustomerDetails.Size = New System.Drawing.Size(191, 45)
        Me.btnCustomerDetails.TabIndex = 23
        Me.btnCustomerDetails.Text = "STATEMENT DETAILS"
        Me.btnCustomerDetails.UseVisualStyleBackColor = False
        '
        'CustomerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(901, 630)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CustomerDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPostCode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCustomerDetails As Button
End Class
