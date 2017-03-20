<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pubTable
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pubTable))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PubIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublishersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactsDataSet = New Sem2_WA.ContactsDataSet()
        Me.PublishersTableAdapter = New Sem2_WA.ContactsDataSetTableAdapters.PublishersTableAdapter()
        Me.TableAdapterManager = New Sem2_WA.ContactsDataSetTableAdapters.TableAdapterManager()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        NameLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PublishersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(3, 91)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PubIDDataGridViewTextBoxColumn, Me.CompanyNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.ZipDataGridViewTextBoxColumn, Me.TelephoneDataGridViewTextBoxColumn, Me.FaxDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PublishersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(176, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(480, 241)
        Me.DataGridView1.TabIndex = 0
        '
        'PubIDDataGridViewTextBoxColumn
        '
        Me.PubIDDataGridViewTextBoxColumn.DataPropertyName = "PubID"
        Me.PubIDDataGridViewTextBoxColumn.HeaderText = "PubID"
        Me.PubIDDataGridViewTextBoxColumn.Name = "PubIDDataGridViewTextBoxColumn"
        '
        'CompanyNameDataGridViewTextBoxColumn
        '
        Me.CompanyNameDataGridViewTextBoxColumn.DataPropertyName = "Company Name"
        Me.CompanyNameDataGridViewTextBoxColumn.HeaderText = "Company Name"
        Me.CompanyNameDataGridViewTextBoxColumn.Name = "CompanyNameDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        '
        'ZipDataGridViewTextBoxColumn
        '
        Me.ZipDataGridViewTextBoxColumn.DataPropertyName = "Zip"
        Me.ZipDataGridViewTextBoxColumn.HeaderText = "Zip"
        Me.ZipDataGridViewTextBoxColumn.Name = "ZipDataGridViewTextBoxColumn"
        '
        'TelephoneDataGridViewTextBoxColumn
        '
        Me.TelephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.HeaderText = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.Name = "TelephoneDataGridViewTextBoxColumn"
        '
        'FaxDataGridViewTextBoxColumn
        '
        Me.FaxDataGridViewTextBoxColumn.DataPropertyName = "Fax"
        Me.FaxDataGridViewTextBoxColumn.HeaderText = "Fax"
        Me.FaxDataGridViewTextBoxColumn.Name = "FaxDataGridViewTextBoxColumn"
        '
        'PublishersBindingSource
        '
        Me.PublishersBindingSource.DataMember = "Publishers"
        Me.PublishersBindingSource.DataSource = Me.ContactsDataSet
        '
        'ContactsDataSet
        '
        Me.ContactsDataSet.DataSetName = "ContactsDataSet"
        Me.ContactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PublishersTableAdapter
        '
        Me.PublishersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PublishersTableAdapter = Me.PublishersTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sem2_WA.ContactsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NameComboBox
        '
        Me.NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Name", True))
        Me.NameComboBox.DataSource = Me.PublishersBindingSource
        Me.NameComboBox.DisplayMember = "Name"
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(47, 88)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NameComboBox.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sem2_WA.My.Resources.Resources.book_border
        Me.PictureBox1.Location = New System.Drawing.Point(-7, 338)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(694, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Sem2_WA.My.Resources.Resources.book2
        Me.PictureBox2.Location = New System.Drawing.Point(585, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(71, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'pubTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 357)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameComboBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pubTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Publisher's Table"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PublishersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ContactsDataSet As ContactsDataSet
    Friend WithEvents PublishersBindingSource As BindingSource
    Friend WithEvents PublishersTableAdapter As ContactsDataSetTableAdapters.PublishersTableAdapter
    Friend WithEvents FaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompanyNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PubIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As ContactsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NameComboBox As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
