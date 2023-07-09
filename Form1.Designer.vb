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
        Me.dgrid = New System.Windows.Forms.DataGridView()
        Me.cmdRead = New System.Windows.Forms.Button()
        Me.cmdCreate = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.txtbxid = New System.Windows.Forms.TextBox()
        Me.txtbxaddress = New System.Windows.Forms.TextBox()
        Me.txtbxage = New System.Windows.Forms.TextBox()
        Me.txtbxname = New System.Windows.Forms.TextBox()
        CType(Me.dgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgrid
        '
        Me.dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrid.Location = New System.Drawing.Point(12, 12)
        Me.dgrid.Name = "dgrid"
        Me.dgrid.Size = New System.Drawing.Size(471, 248)
        Me.dgrid.TabIndex = 0
        '
        'cmdRead
        '
        Me.cmdRead.Location = New System.Drawing.Point(489, 12)
        Me.cmdRead.Name = "cmdRead"
        Me.cmdRead.Size = New System.Drawing.Size(175, 30)
        Me.cmdRead.TabIndex = 1
        Me.cmdRead.Text = "Read"
        Me.cmdRead.UseVisualStyleBackColor = True
        '
        'cmdCreate
        '
        Me.cmdCreate.Location = New System.Drawing.Point(489, 48)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(175, 30)
        Me.cmdCreate.TabIndex = 2
        Me.cmdCreate.Text = "Create"
        Me.cmdCreate.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(489, 84)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(175, 30)
        Me.cmdUpdate.TabIndex = 3
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(489, 120)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(175, 30)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'txtbxid
        '
        Me.txtbxid.Enabled = False
        Me.txtbxid.Location = New System.Drawing.Point(489, 162)
        Me.txtbxid.Name = "txtbxid"
        Me.txtbxid.Size = New System.Drawing.Size(175, 20)
        Me.txtbxid.TabIndex = 5
        '
        'txtbxaddress
        '
        Me.txtbxaddress.Location = New System.Drawing.Point(489, 240)
        Me.txtbxaddress.Name = "txtbxaddress"
        Me.txtbxaddress.Size = New System.Drawing.Size(175, 20)
        Me.txtbxaddress.TabIndex = 6
        '
        'txtbxage
        '
        Me.txtbxage.Location = New System.Drawing.Point(489, 214)
        Me.txtbxage.Name = "txtbxage"
        Me.txtbxage.Size = New System.Drawing.Size(175, 20)
        Me.txtbxage.TabIndex = 7
        '
        'txtbxname
        '
        Me.txtbxname.Location = New System.Drawing.Point(489, 188)
        Me.txtbxname.Name = "txtbxname"
        Me.txtbxname.Size = New System.Drawing.Size(175, 20)
        Me.txtbxname.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 275)
        Me.Controls.Add(Me.txtbxname)
        Me.Controls.Add(Me.txtbxage)
        Me.Controls.Add(Me.txtbxaddress)
        Me.Controls.Add(Me.txtbxid)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdCreate)
        Me.Controls.Add(Me.cmdRead)
        Me.Controls.Add(Me.dgrid)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgrid As DataGridView
    Friend WithEvents cmdRead As Button
    Friend WithEvents cmdCreate As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents txtbxid As TextBox
    Friend WithEvents txtbxaddress As TextBox
    Friend WithEvents txtbxage As TextBox
    Friend WithEvents txtbxname As TextBox
End Class
