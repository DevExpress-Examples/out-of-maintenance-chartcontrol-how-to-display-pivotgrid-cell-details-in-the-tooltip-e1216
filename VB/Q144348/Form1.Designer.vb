Namespace Q144348
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.nwindDataSet = New Q144348.nwindDataSet()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			Me.salesPersonTableAdapter = New Q144348.nwindDataSetTableAdapters.SalesPersonTableAdapter()
			Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataSource = Me.bindingSource1
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCountry, Me.fieldOrderDate, Me.fieldExtendedPrice})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(747, 294)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataMember = "SalesPerson"
			Me.bindingSource1.DataSource = Me.nwindDataSet
			' 
			' salesPersonTableAdapter
			' 
			Me.salesPersonTableAdapter.ClearBeforeFill = True
			' 
			' fieldCountry
			' 
			Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCountry.AreaIndex = 0
			Me.fieldCountry.FieldName = "Country"
			Me.fieldCountry.Name = "fieldCountry"
			' 
			' fieldOrderDate
			' 
			Me.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderDate.AreaIndex = 0
			Me.fieldOrderDate.Caption = "Year"
			Me.fieldOrderDate.FieldName = "OrderDate"
			Me.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldOrderDate.Name = "fieldOrderDate"
			' 
			' fieldExtendedPrice
			' 
			Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice.AreaIndex = 0
			Me.fieldExtendedPrice.FieldName = "Extended Price"
			Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
			' 
			' chartControl1
			' 
			Me.chartControl1.DataSource = Me.pivotGridControl1
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Location = New System.Drawing.Point(0, 294)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.SeriesDataMember = "Series"
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
			Me.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
			Me.chartControl1.Size = New System.Drawing.Size(747, 295)
			Me.toolTipController1.SetSuperTip(Me.chartControl1, Nothing)
			Me.chartControl1.TabIndex = 1
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.chartControl1.ObjectHotTracked += new DevExpress.XtraCharts.HotTrackEventHandler(this.chartControl1_ObjectHotTracked);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(747, 589)
			Me.Controls.Add(Me.chartControl1)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private nwindDataSet As nwindDataSet
		Private bindingSource1 As System.Windows.Forms.BindingSource
		Private salesPersonTableAdapter As Q144348.nwindDataSetTableAdapters.SalesPersonTableAdapter
		Private fieldCountry As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderDate As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField
		Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
		Private toolTipController1 As DevExpress.Utils.ToolTipController
	End Class
End Namespace

