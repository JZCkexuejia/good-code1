<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAddRow = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtColMin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtColMax = New System.Windows.Forms.TextBox()
        Me.btnAddColumns = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConnStr = New System.Windows.Forms.TextBox()
        Me.btnModifyConnStr = New System.Windows.Forms.Button()
        Me.txtTableName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(100, 61)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(121, 25)
        Me.txtName.TabIndex = 1
        '
        'btnAddRow
        '
        Me.btnAddRow.Location = New System.Drawing.Point(227, 61)
        Me.btnAddRow.Name = "btnAddRow"
        Me.btnAddRow.Size = New System.Drawing.Size(94, 23)
        Me.btnAddRow.TabIndex = 2
        Me.btnAddRow.Text = "Add Row"
        Me.btnAddRow.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(361, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Columns_Min"
        '
        'txtColMin
        '
        Me.txtColMin.Location = New System.Drawing.Point(473, 41)
        Me.txtColMin.Name = "txtColMin"
        Me.txtColMin.Size = New System.Drawing.Size(121, 25)
        Me.txtColMin.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(361, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Columns_Max"
        '
        'txtColMax
        '
        Me.txtColMax.Location = New System.Drawing.Point(473, 76)
        Me.txtColMax.Name = "txtColMax"
        Me.txtColMax.Size = New System.Drawing.Size(121, 25)
        Me.txtColMax.TabIndex = 6
        '
        'btnAddColumns
        '
        Me.btnAddColumns.Location = New System.Drawing.Point(600, 41)
        Me.btnAddColumns.Name = "btnAddColumns"
        Me.btnAddColumns.Size = New System.Drawing.Size(94, 60)
        Me.btnAddColumns.TabIndex = 7
        Me.btnAddColumns.Text = "Add Columns"
        Me.btnAddColumns.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 113)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 27
        Me.dgv.Size = New System.Drawing.Size(1148, 589)
        Me.dgv.TabIndex = 8
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(744, 52)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 41)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "Refresh View"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ConnectionString"
        '
        'txtConnStr
        '
        Me.txtConnStr.Location = New System.Drawing.Point(173, 10)
        Me.txtConnStr.Name = "txtConnStr"
        Me.txtConnStr.Size = New System.Drawing.Size(521, 25)
        Me.txtConnStr.TabIndex = 11
        Me.txtConnStr.Text = "Server=127.0.0.1;Database=DuvetDB;User Id=sa;Password=Aa123;"
        '
        'btnModifyConnStr
        '
        Me.btnModifyConnStr.Location = New System.Drawing.Point(932, 13)
        Me.btnModifyConnStr.Name = "btnModifyConnStr"
        Me.btnModifyConnStr.Size = New System.Drawing.Size(75, 23)
        Me.btnModifyConnStr.TabIndex = 12
        Me.btnModifyConnStr.Text = "Modify"
        Me.btnModifyConnStr.UseVisualStyleBackColor = True
        '
        'txtTableName
        '
        Me.txtTableName.Location = New System.Drawing.Point(791, 10)
        Me.txtTableName.Name = "txtTableName"
        Me.txtTableName.Size = New System.Drawing.Size(135, 25)
        Me.txtTableName.TabIndex = 14
        Me.txtTableName.Text = "T_Duvet_Test"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(706, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "TableName"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 710)
        Me.Controls.Add(Me.txtTableName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnModifyConnStr)
        Me.Controls.Add(Me.txtConnStr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btnAddColumns)
        Me.Controls.Add(Me.txtColMax)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtColMin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAddRow)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMain"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnAddRow As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtColMin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtColMax As TextBox
    Friend WithEvents btnAddColumns As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtConnStr As TextBox
    Friend WithEvents btnModifyConnStr As Button
    Friend WithEvents txtTableName As TextBox
    Friend WithEvents Label5 As Label
End Class
