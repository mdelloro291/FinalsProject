<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransactionsForm
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
        Me.components = New System.ComponentModel.Container()
        Me.tblProductList = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectFinalsDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectFinalsDataSet = New FinalsApplication.ProjectFinalsDataSet()
        Me.TblProductTableAdapter = New FinalsApplication.ProjectFinalsDataSetTableAdapters.tblProductTableAdapter()
        Me.ProjectFinalsDataSet1 = New FinalsApplication.ProjectFinalsDataSet()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.TblProductBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnDecrease = New System.Windows.Forms.Button()
        Me.btnIncrease = New System.Windows.Forms.Button()
        Me.tblCart = New System.Windows.Forms.DataGridView()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.btnUpdateQty = New System.Windows.Forms.Button()
        CType(Me.tblProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectFinalsDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectFinalsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectFinalsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblProductList
        '
        Me.tblProductList.AllowUserToAddRows = False
        Me.tblProductList.AllowUserToDeleteRows = False
        Me.tblProductList.AllowUserToResizeRows = False
        Me.tblProductList.AutoGenerateColumns = False
        Me.tblProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblProductList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ProductDescDataGridViewTextBoxColumn, Me.ProductPriceDataGridViewTextBoxColumn, Me.ProductStockDataGridViewTextBoxColumn})
        Me.tblProductList.DataSource = Me.TblProductBindingSource
        Me.tblProductList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.tblProductList.Location = New System.Drawing.Point(12, 12)
        Me.tblProductList.MultiSelect = False
        Me.tblProductList.Name = "tblProductList"
        Me.tblProductList.ReadOnly = True
        Me.tblProductList.RowTemplate.Height = 24
        Me.tblProductList.RowTemplate.ReadOnly = True
        Me.tblProductList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblProductList.ShowEditingIcon = False
        Me.tblProductList.Size = New System.Drawing.Size(608, 291)
        Me.tblProductList.TabIndex = 0
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "productID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "productName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductDescDataGridViewTextBoxColumn
        '
        Me.ProductDescDataGridViewTextBoxColumn.DataPropertyName = "productDesc"
        Me.ProductDescDataGridViewTextBoxColumn.HeaderText = "Product Description"
        Me.ProductDescDataGridViewTextBoxColumn.Name = "ProductDescDataGridViewTextBoxColumn"
        Me.ProductDescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductPriceDataGridViewTextBoxColumn
        '
        Me.ProductPriceDataGridViewTextBoxColumn.DataPropertyName = "productPrice"
        Me.ProductPriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.ProductPriceDataGridViewTextBoxColumn.Name = "ProductPriceDataGridViewTextBoxColumn"
        Me.ProductPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductStockDataGridViewTextBoxColumn
        '
        Me.ProductStockDataGridViewTextBoxColumn.DataPropertyName = "productStock"
        Me.ProductStockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.ProductStockDataGridViewTextBoxColumn.Name = "ProductStockDataGridViewTextBoxColumn"
        Me.ProductStockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblProductBindingSource
        '
        Me.TblProductBindingSource.DataMember = "tblProduct"
        Me.TblProductBindingSource.DataSource = Me.ProjectFinalsDataSetBindingSource
        '
        'ProjectFinalsDataSetBindingSource
        '
        Me.ProjectFinalsDataSetBindingSource.DataSource = Me.ProjectFinalsDataSet
        Me.ProjectFinalsDataSetBindingSource.Position = 0
        '
        'ProjectFinalsDataSet
        '
        Me.ProjectFinalsDataSet.DataSetName = "ProjectFinalsDataSet"
        Me.ProjectFinalsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblProductTableAdapter
        '
        Me.TblProductTableAdapter.ClearBeforeFill = True
        '
        'ProjectFinalsDataSet1
        '
        Me.ProjectFinalsDataSet1.DataSetName = "ProjectFinalsDataSet"
        Me.ProjectFinalsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(626, 89)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(194, 58)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "&Add To Cart"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(627, 376)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(194, 58)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'TblProductBindingSource1
        '
        Me.TblProductBindingSource1.DataMember = "tblProduct"
        Me.TblProductBindingSource1.DataSource = Me.ProjectFinalsDataSetBindingSource
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Courier New", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(691, 23)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ReadOnly = True
        Me.txtQuantity.Size = New System.Drawing.Size(64, 56)
        Me.txtQuantity.TabIndex = 3
        Me.txtQuantity.Text = "0"
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDecrease
        '
        Me.btnDecrease.Location = New System.Drawing.Point(627, 23)
        Me.btnDecrease.Name = "btnDecrease"
        Me.btnDecrease.Size = New System.Drawing.Size(58, 60)
        Me.btnDecrease.TabIndex = 4
        Me.btnDecrease.Text = "-"
        Me.btnDecrease.UseVisualStyleBackColor = True
        '
        'btnIncrease
        '
        Me.btnIncrease.Location = New System.Drawing.Point(762, 23)
        Me.btnIncrease.Name = "btnIncrease"
        Me.btnIncrease.Size = New System.Drawing.Size(58, 60)
        Me.btnIncrease.TabIndex = 5
        Me.btnIncrease.Text = "+"
        Me.btnIncrease.UseVisualStyleBackColor = True
        '
        'tblCart
        '
        Me.tblCart.AllowUserToAddRows = False
        Me.tblCart.AllowUserToDeleteRows = False
        Me.tblCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblCart.Location = New System.Drawing.Point(12, 309)
        Me.tblCart.MultiSelect = False
        Me.tblCart.Name = "tblCart"
        Me.tblCart.RowTemplate.Height = 24
        Me.tblCart.RowTemplate.ReadOnly = True
        Me.tblCart.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblCart.Size = New System.Drawing.Size(608, 189)
        Me.tblCart.TabIndex = 6
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Location = New System.Drawing.Point(626, 440)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(194, 58)
        Me.btnCheckOut.TabIndex = 9
        Me.btnCheckOut.Text = "&Check Out"
        Me.btnCheckOut.UseVisualStyleBackColor = True
        '
        'btnUpdateQty
        '
        Me.btnUpdateQty.Location = New System.Drawing.Point(626, 309)
        Me.btnUpdateQty.Name = "btnUpdateQty"
        Me.btnUpdateQty.Size = New System.Drawing.Size(194, 58)
        Me.btnUpdateQty.TabIndex = 10
        Me.btnUpdateQty.Text = "&Update Quantity"
        Me.btnUpdateQty.UseVisualStyleBackColor = True
        '
        'TransactionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 510)
        Me.Controls.Add(Me.btnUpdateQty)
        Me.Controls.Add(Me.btnCheckOut)
        Me.Controls.Add(Me.tblCart)
        Me.Controls.Add(Me.btnIncrease)
        Me.Controls.Add(Me.btnDecrease)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.tblProductList)
        Me.Name = "TransactionsForm"
        Me.Text = "Transactions"
        CType(Me.tblProductList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectFinalsDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectFinalsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectFinalsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tblProductList As DataGridView
    Friend WithEvents ProjectFinalsDataSetBindingSource As BindingSource
    Friend WithEvents ProjectFinalsDataSet As ProjectFinalsDataSet
    Friend WithEvents TblProductBindingSource As BindingSource
    Friend WithEvents TblProductTableAdapter As ProjectFinalsDataSetTableAdapters.tblProductTableAdapter
    Friend WithEvents ProjectFinalsDataSet1 As ProjectFinalsDataSet
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents TblProductBindingSource1 As BindingSource
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnDecrease As Button
    Friend WithEvents btnIncrease As Button
    Friend WithEvents tblCart As DataGridView
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDescDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductStockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents btnUpdateQty As Button
End Class
