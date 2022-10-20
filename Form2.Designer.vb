<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSheet = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.InsuranceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PolicyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpiryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsuredValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConstructionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusinessTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EarthquakeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FloodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsuranceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PolicyDataGridViewTextBoxColumn, Me.ExpiryDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.RegionDataGridViewTextBoxColumn, Me.InsuredValueDataGridViewTextBoxColumn, Me.ConstructionDataGridViewTextBoxColumn, Me.BusinessTypeDataGridViewTextBoxColumn, Me.EarthquakeDataGridViewTextBoxColumn, Me.FloodDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InsuranceBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(42, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1035, 358)
        Me.DataGridView1.TabIndex = 0
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(982, 409)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(95, 39)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(154, 417)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.ReadOnly = True
        Me.txtFileName.Size = New System.Drawing.Size(782, 22)
        Me.txtFileName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 413)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "File Name"
        '
        'cboSheet
        '
        Me.cboSheet.FormattingEnabled = True
        Me.cboSheet.Location = New System.Drawing.Point(154, 462)
        Me.cboSheet.Name = "cboSheet"
        Me.cboSheet.Size = New System.Drawing.Size(121, 24)
        Me.cboSheet.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 458)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sheet"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(302, 463)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 6
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'InsuranceBindingSource
        '
        Me.InsuranceBindingSource.DataSource = GetType(FMA.Insurance)
        '
        'PolicyDataGridViewTextBoxColumn
        '
        Me.PolicyDataGridViewTextBoxColumn.DataPropertyName = "Policy"
        Me.PolicyDataGridViewTextBoxColumn.HeaderText = "Policy"
        Me.PolicyDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PolicyDataGridViewTextBoxColumn.Name = "PolicyDataGridViewTextBoxColumn"
        Me.PolicyDataGridViewTextBoxColumn.Width = 125
        '
        'ExpiryDataGridViewTextBoxColumn
        '
        Me.ExpiryDataGridViewTextBoxColumn.DataPropertyName = "Expiry"
        Me.ExpiryDataGridViewTextBoxColumn.HeaderText = "Expiry"
        Me.ExpiryDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExpiryDataGridViewTextBoxColumn.Name = "ExpiryDataGridViewTextBoxColumn"
        Me.ExpiryDataGridViewTextBoxColumn.Width = 125
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        Me.LocationDataGridViewTextBoxColumn.Width = 125
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.Width = 125
        '
        'RegionDataGridViewTextBoxColumn
        '
        Me.RegionDataGridViewTextBoxColumn.DataPropertyName = "Region"
        Me.RegionDataGridViewTextBoxColumn.HeaderText = "Region"
        Me.RegionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RegionDataGridViewTextBoxColumn.Name = "RegionDataGridViewTextBoxColumn"
        Me.RegionDataGridViewTextBoxColumn.Width = 125
        '
        'InsuredValueDataGridViewTextBoxColumn
        '
        Me.InsuredValueDataGridViewTextBoxColumn.DataPropertyName = "InsuredValue"
        Me.InsuredValueDataGridViewTextBoxColumn.HeaderText = "InsuredValue"
        Me.InsuredValueDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InsuredValueDataGridViewTextBoxColumn.Name = "InsuredValueDataGridViewTextBoxColumn"
        Me.InsuredValueDataGridViewTextBoxColumn.Width = 125
        '
        'ConstructionDataGridViewTextBoxColumn
        '
        Me.ConstructionDataGridViewTextBoxColumn.DataPropertyName = "Construction"
        Me.ConstructionDataGridViewTextBoxColumn.HeaderText = "Construction"
        Me.ConstructionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ConstructionDataGridViewTextBoxColumn.Name = "ConstructionDataGridViewTextBoxColumn"
        Me.ConstructionDataGridViewTextBoxColumn.Width = 125
        '
        'BusinessTypeDataGridViewTextBoxColumn
        '
        Me.BusinessTypeDataGridViewTextBoxColumn.DataPropertyName = "BusinessType"
        Me.BusinessTypeDataGridViewTextBoxColumn.HeaderText = "BusinessType"
        Me.BusinessTypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BusinessTypeDataGridViewTextBoxColumn.Name = "BusinessTypeDataGridViewTextBoxColumn"
        Me.BusinessTypeDataGridViewTextBoxColumn.Width = 125
        '
        'EarthquakeDataGridViewTextBoxColumn
        '
        Me.EarthquakeDataGridViewTextBoxColumn.DataPropertyName = "Earthquake"
        Me.EarthquakeDataGridViewTextBoxColumn.HeaderText = "Earthquake"
        Me.EarthquakeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EarthquakeDataGridViewTextBoxColumn.Name = "EarthquakeDataGridViewTextBoxColumn"
        Me.EarthquakeDataGridViewTextBoxColumn.Width = 125
        '
        'FloodDataGridViewTextBoxColumn
        '
        Me.FloodDataGridViewTextBoxColumn.DataPropertyName = "Flood"
        Me.FloodDataGridViewTextBoxColumn.HeaderText = "Flood"
        Me.FloodDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FloodDataGridViewTextBoxColumn.Name = "FloodDataGridViewTextBoxColumn"
        Me.FloodDataGridViewTextBoxColumn.Width = 125
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 498)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSheet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Read excel .xls .xlsx file"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsuranceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboSheet As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnImport As Button
    Friend WithEvents PolicyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExpiryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InsuredValueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConstructionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BusinessTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EarthquakeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FloodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InsuranceBindingSource As BindingSource
End Class
