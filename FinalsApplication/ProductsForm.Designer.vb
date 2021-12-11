<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsForm
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
        Me.ProjectFinalsDataSet = New FinalsApplication.ProjectFinalsDataSet()
        Me.TblProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProductTableAdapter = New FinalsApplication.ProjectFinalsDataSetTableAdapters.tblProductTableAdapter()
        Me.ChangeWindows = New System.Windows.Forms.Button()
        CType(Me.ProjectFinalsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProjectFinalsDataSet
        '
        Me.ProjectFinalsDataSet.DataSetName = "ProjectFinalsDataSet"
        Me.ProjectFinalsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblProductBindingSource
        '
        Me.TblProductBindingSource.DataMember = "tblProduct"
        Me.TblProductBindingSource.DataSource = Me.ProjectFinalsDataSet
        '
        'TblProductTableAdapter
        '
        Me.TblProductTableAdapter.ClearBeforeFill = True
        '
        'ChangeWindows
        '
        Me.ChangeWindows.Location = New System.Drawing.Point(359, 275)
        Me.ChangeWindows.Name = "ChangeWindows"
        Me.ChangeWindows.Size = New System.Drawing.Size(139, 107)
        Me.ChangeWindows.TabIndex = 0
        Me.ChangeWindows.Text = "Change Window"
        Me.ChangeWindows.UseVisualStyleBackColor = True
        '
        'ProductsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 489)
        Me.Controls.Add(Me.ChangeWindows)
        Me.Name = "ProductsForm"
        Me.Text = "Products"
        CType(Me.ProjectFinalsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProjectFinalsDataSet As ProjectFinalsDataSet
    Friend WithEvents TblProductBindingSource As BindingSource
    Friend WithEvents TblProductTableAdapter As ProjectFinalsDataSetTableAdapters.tblProductTableAdapter
    Friend WithEvents ChangeWindows As Button
End Class
