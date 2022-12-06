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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboComparative = New System.Windows.Forms.CheckBox()
        Me.cboLRU = New System.Windows.Forms.CheckBox()
        Me.cboOptimal = New System.Windows.Forms.CheckBox()
        Me.cboFifo = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPageFrame = New System.Windows.Forms.TextBox()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.btnSim = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.txtRefString = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblFIFOHitRatio = New System.Windows.Forms.Label()
        Me.dgvOne = New System.Windows.Forms.DataGridView()
        Me.lblFIFOHits = New System.Windows.Forms.Label()
        Me.lblFIFOFaults = New System.Windows.Forms.Label()
        Me.lblFIFOFaultRatio = New System.Windows.Forms.Label()
        Me.dgvThree = New System.Windows.Forms.DataGridView()
        Me.dgvTwo = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblLRUHitRatio = New System.Windows.Forms.Label()
        Me.lblLRUHits = New System.Windows.Forms.Label()
        Me.lblLRUFaults = New System.Windows.Forms.Label()
        Me.lblLRUFaultRatio = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblOptimalHitRatio = New System.Windows.Forms.Label()
        Me.lblOptimalHits = New System.Windows.Forms.Label()
        Me.lblOptimalFaults = New System.Windows.Forms.Label()
        Me.lblOptimalFaultRatio = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox1.Controls.Add(Me.cboComparative)
        Me.GroupBox1.Controls.Add(Me.cboLRU)
        Me.GroupBox1.Controls.Add(Me.cboOptimal)
        Me.GroupBox1.Controls.Add(Me.cboFifo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.OrangeRed
        Me.GroupBox1.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(151, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Algorithm"
        '
        'cboComparative
        '
        Me.cboComparative.AutoSize = True
        Me.cboComparative.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboComparative.ForeColor = System.Drawing.Color.RoyalBlue
        Me.cboComparative.Location = New System.Drawing.Point(18, 95)
        Me.cboComparative.Name = "cboComparative"
        Me.cboComparative.Size = New System.Drawing.Size(129, 22)
        Me.cboComparative.TabIndex = 3
        Me.cboComparative.Text = "Comparative"
        Me.cboComparative.UseVisualStyleBackColor = True
        '
        'cboLRU
        '
        Me.cboLRU.AutoSize = True
        Me.cboLRU.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLRU.ForeColor = System.Drawing.Color.RoyalBlue
        Me.cboLRU.Location = New System.Drawing.Point(18, 42)
        Me.cboLRU.Name = "cboLRU"
        Me.cboLRU.Size = New System.Drawing.Size(61, 22)
        Me.cboLRU.TabIndex = 2
        Me.cboLRU.Text = "LRU"
        Me.cboLRU.UseVisualStyleBackColor = True
        '
        'cboOptimal
        '
        Me.cboOptimal.AutoSize = True
        Me.cboOptimal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOptimal.ForeColor = System.Drawing.Color.RoyalBlue
        Me.cboOptimal.Location = New System.Drawing.Point(18, 64)
        Me.cboOptimal.Name = "cboOptimal"
        Me.cboOptimal.Size = New System.Drawing.Size(88, 22)
        Me.cboOptimal.TabIndex = 1
        Me.cboOptimal.Text = "Optimal"
        Me.cboOptimal.UseVisualStyleBackColor = True
        '
        'cboFifo
        '
        Me.cboFifo.AutoSize = True
        Me.cboFifo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFifo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.cboFifo.Location = New System.Drawing.Point(18, 20)
        Me.cboFifo.Name = "cboFifo"
        Me.cboFifo.Size = New System.Drawing.Size(65, 22)
        Me.cboFifo.TabIndex = 0
        Me.cboFifo.Text = "FIFO"
        Me.cboFifo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblLength)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtPageFrame)
        Me.Panel1.Controls.Add(Me.btnFinish)
        Me.Panel1.Controls.Add(Me.btnSim)
        Me.Panel1.Controls.Add(Me.btnGenerate)
        Me.Panel1.Controls.Add(Me.txtRefString)
        Me.Panel1.Location = New System.Drawing.Point(250, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(836, 119)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Ivory
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Button1.Location = New System.Drawing.Point(579, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 39)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "&Reset"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.Location = New System.Drawing.Point(555, 62)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(0, 15)
        Me.lblLength.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(505, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Length: "
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Ivory
        Me.btnNext.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnNext.Location = New System.Drawing.Point(363, 14)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(102, 39)
        Me.btnNext.TabIndex = 8
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(685, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Page Frames:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Reference String:"
        '
        'txtPageFrame
        '
        Me.txtPageFrame.Location = New System.Drawing.Point(688, 78)
        Me.txtPageFrame.Name = "txtPageFrame"
        Me.txtPageFrame.Size = New System.Drawing.Size(123, 20)
        Me.txtPageFrame.TabIndex = 5
        Me.txtPageFrame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnFinish
        '
        Me.btnFinish.BackColor = System.Drawing.Color.Ivory
        Me.btnFinish.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinish.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnFinish.Location = New System.Drawing.Point(471, 14)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(102, 39)
        Me.btnFinish.TabIndex = 4
        Me.btnFinish.Text = "&Finish"
        Me.btnFinish.UseVisualStyleBackColor = False
        '
        'btnSim
        '
        Me.btnSim.BackColor = System.Drawing.Color.Ivory
        Me.btnSim.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSim.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnSim.Location = New System.Drawing.Point(255, 14)
        Me.btnSim.Name = "btnSim"
        Me.btnSim.Size = New System.Drawing.Size(102, 39)
        Me.btnSim.TabIndex = 3
        Me.btnSim.Text = "&Simulate"
        Me.btnSim.UseVisualStyleBackColor = False
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.Ivory
        Me.btnGenerate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnGenerate.Location = New System.Drawing.Point(147, 14)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(102, 39)
        Me.btnGenerate.TabIndex = 1
        Me.btnGenerate.Text = "&Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'txtRefString
        '
        Me.txtRefString.Location = New System.Drawing.Point(14, 78)
        Me.txtRefString.Name = "txtRefString"
        Me.txtRefString.Size = New System.Drawing.Size(559, 20)
        Me.txtRefString.TabIndex = 0
        Me.txtRefString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.lblFIFOHitRatio)
        Me.Panel2.Controls.Add(Me.dgvOne)
        Me.Panel2.Controls.Add(Me.lblFIFOHits)
        Me.Panel2.Controls.Add(Me.lblFIFOFaults)
        Me.Panel2.Controls.Add(Me.lblFIFOFaultRatio)
        Me.Panel2.Location = New System.Drawing.Point(12, 145)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1310, 182)
        Me.Panel2.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(33, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "First-in First Out"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(1065, 125)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(55, 13)
        Me.Label25.TabIndex = 15
        Me.Label25.Text = "Hit Ratio:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(1065, 100)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(93, 13)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "No. of Page Hits:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(1065, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 13)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Fault Ratio:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(1065, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "No. of Page Faults:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(1046, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Percentages:"
        '
        'lblFIFOHitRatio
        '
        Me.lblFIFOHitRatio.AutoSize = True
        Me.lblFIFOHitRatio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFIFOHitRatio.ForeColor = System.Drawing.Color.Red
        Me.lblFIFOHitRatio.Location = New System.Drawing.Point(1187, 125)
        Me.lblFIFOHitRatio.Name = "lblFIFOHitRatio"
        Me.lblFIFOHitRatio.Size = New System.Drawing.Size(104, 13)
        Me.lblFIFOHitRatio.TabIndex = 9
        Me.lblFIFOHitRatio.Text = "No. of Page Faults:"
        Me.lblFIFOHitRatio.Visible = False
        '
        'dgvOne
        '
        Me.dgvOne.AllowUserToAddRows = False
        Me.dgvOne.AllowUserToDeleteRows = False
        Me.dgvOne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOne.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvOne.Location = New System.Drawing.Point(36, 22)
        Me.dgvOne.Name = "dgvOne"
        Me.dgvOne.ReadOnly = True
        Me.dgvOne.Size = New System.Drawing.Size(981, 144)
        Me.dgvOne.TabIndex = 0
        '
        'lblFIFOHits
        '
        Me.lblFIFOHits.AutoSize = True
        Me.lblFIFOHits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFIFOHits.ForeColor = System.Drawing.Color.Red
        Me.lblFIFOHits.Location = New System.Drawing.Point(1187, 100)
        Me.lblFIFOHits.Name = "lblFIFOHits"
        Me.lblFIFOHits.Size = New System.Drawing.Size(104, 13)
        Me.lblFIFOHits.TabIndex = 8
        Me.lblFIFOHits.Text = "No. of Page Faults:"
        Me.lblFIFOHits.Visible = False
        '
        'lblFIFOFaults
        '
        Me.lblFIFOFaults.AutoSize = True
        Me.lblFIFOFaults.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFIFOFaults.ForeColor = System.Drawing.Color.Red
        Me.lblFIFOFaults.Location = New System.Drawing.Point(1187, 50)
        Me.lblFIFOFaults.Name = "lblFIFOFaults"
        Me.lblFIFOFaults.Size = New System.Drawing.Size(104, 13)
        Me.lblFIFOFaults.TabIndex = 6
        Me.lblFIFOFaults.Text = "No. of Page Faults:"
        Me.lblFIFOFaults.Visible = False
        '
        'lblFIFOFaultRatio
        '
        Me.lblFIFOFaultRatio.AutoSize = True
        Me.lblFIFOFaultRatio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFIFOFaultRatio.ForeColor = System.Drawing.Color.Red
        Me.lblFIFOFaultRatio.Location = New System.Drawing.Point(1187, 75)
        Me.lblFIFOFaultRatio.Name = "lblFIFOFaultRatio"
        Me.lblFIFOFaultRatio.Size = New System.Drawing.Size(104, 13)
        Me.lblFIFOFaultRatio.TabIndex = 7
        Me.lblFIFOFaultRatio.Text = "No. of Page Faults:"
        Me.lblFIFOFaultRatio.Visible = False
        '
        'dgvThree
        '
        Me.dgvThree.AllowUserToAddRows = False
        Me.dgvThree.AllowUserToDeleteRows = False
        Me.dgvThree.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvThree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThree.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvThree.Location = New System.Drawing.Point(36, 26)
        Me.dgvThree.Name = "dgvThree"
        Me.dgvThree.ReadOnly = True
        Me.dgvThree.Size = New System.Drawing.Size(981, 138)
        Me.dgvThree.TabIndex = 2
        '
        'dgvTwo
        '
        Me.dgvTwo.AllowUserToAddRows = False
        Me.dgvTwo.AllowUserToDeleteRows = False
        Me.dgvTwo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvTwo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTwo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTwo.Location = New System.Drawing.Point(36, 25)
        Me.dgvTwo.Name = "dgvTwo"
        Me.dgvTwo.ReadOnly = True
        Me.dgvTwo.Size = New System.Drawing.Size(981, 138)
        Me.dgvTwo.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.lblLRUHitRatio)
        Me.Panel4.Controls.Add(Me.lblLRUHits)
        Me.Panel4.Controls.Add(Me.lblLRUFaults)
        Me.Panel4.Controls.Add(Me.lblLRUFaultRatio)
        Me.Panel4.Controls.Add(Me.Label26)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.dgvTwo)
        Me.Panel4.Location = New System.Drawing.Point(12, 333)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1310, 180)
        Me.Panel4.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(33, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Least Recently Used"
        '
        'lblLRUHitRatio
        '
        Me.lblLRUHitRatio.AutoSize = True
        Me.lblLRUHitRatio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLRUHitRatio.ForeColor = System.Drawing.Color.Red
        Me.lblLRUHitRatio.Location = New System.Drawing.Point(1187, 120)
        Me.lblLRUHitRatio.Name = "lblLRUHitRatio"
        Me.lblLRUHitRatio.Size = New System.Drawing.Size(104, 13)
        Me.lblLRUHitRatio.TabIndex = 21
        Me.lblLRUHitRatio.Text = "No. of Page Faults:"
        Me.lblLRUHitRatio.Visible = False
        '
        'lblLRUHits
        '
        Me.lblLRUHits.AutoSize = True
        Me.lblLRUHits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLRUHits.ForeColor = System.Drawing.Color.Red
        Me.lblLRUHits.Location = New System.Drawing.Point(1187, 97)
        Me.lblLRUHits.Name = "lblLRUHits"
        Me.lblLRUHits.Size = New System.Drawing.Size(104, 13)
        Me.lblLRUHits.TabIndex = 20
        Me.lblLRUHits.Text = "No. of Page Faults:"
        Me.lblLRUHits.Visible = False
        '
        'lblLRUFaults
        '
        Me.lblLRUFaults.AutoSize = True
        Me.lblLRUFaults.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLRUFaults.ForeColor = System.Drawing.Color.Red
        Me.lblLRUFaults.Location = New System.Drawing.Point(1187, 51)
        Me.lblLRUFaults.Name = "lblLRUFaults"
        Me.lblLRUFaults.Size = New System.Drawing.Size(104, 13)
        Me.lblLRUFaults.TabIndex = 18
        Me.lblLRUFaults.Text = "No. of Page Faults:"
        Me.lblLRUFaults.Visible = False
        '
        'lblLRUFaultRatio
        '
        Me.lblLRUFaultRatio.AutoSize = True
        Me.lblLRUFaultRatio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLRUFaultRatio.ForeColor = System.Drawing.Color.Red
        Me.lblLRUFaultRatio.Location = New System.Drawing.Point(1187, 74)
        Me.lblLRUFaultRatio.Name = "lblLRUFaultRatio"
        Me.lblLRUFaultRatio.Size = New System.Drawing.Size(104, 13)
        Me.lblLRUFaultRatio.TabIndex = 19
        Me.lblLRUFaultRatio.Text = "No. of Page Faults:"
        Me.lblLRUFaultRatio.Visible = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.Location = New System.Drawing.Point(1065, 120)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 13)
        Me.Label26.TabIndex = 17
        Me.Label26.Text = "Hit Ratio:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(1065, 97)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(93, 13)
        Me.Label23.TabIndex = 17
        Me.Label23.Text = "No. of Page Hits:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(1065, 74)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 13)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Fault Ratio:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(1065, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "No. of Page Faults:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(1046, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Percentages:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.lblOptimalHitRatio)
        Me.Panel5.Controls.Add(Me.lblOptimalHits)
        Me.Panel5.Controls.Add(Me.lblOptimalFaults)
        Me.Panel5.Controls.Add(Me.lblOptimalFaultRatio)
        Me.Panel5.Controls.Add(Me.Label27)
        Me.Panel5.Controls.Add(Me.Label24)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.dgvThree)
        Me.Panel5.Location = New System.Drawing.Point(12, 519)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1310, 180)
        Me.Panel5.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(33, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Optimal"
        '
        'lblOptimalHitRatio
        '
        Me.lblOptimalHitRatio.AutoSize = True
        Me.lblOptimalHitRatio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptimalHitRatio.ForeColor = System.Drawing.Color.Red
        Me.lblOptimalHitRatio.Location = New System.Drawing.Point(1187, 130)
        Me.lblOptimalHitRatio.Name = "lblOptimalHitRatio"
        Me.lblOptimalHitRatio.Size = New System.Drawing.Size(104, 13)
        Me.lblOptimalHitRatio.TabIndex = 22
        Me.lblOptimalHitRatio.Text = "No. of Page Faults:"
        Me.lblOptimalHitRatio.Visible = False
        '
        'lblOptimalHits
        '
        Me.lblOptimalHits.AutoSize = True
        Me.lblOptimalHits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptimalHits.ForeColor = System.Drawing.Color.Red
        Me.lblOptimalHits.Location = New System.Drawing.Point(1187, 105)
        Me.lblOptimalHits.Name = "lblOptimalHits"
        Me.lblOptimalHits.Size = New System.Drawing.Size(104, 13)
        Me.lblOptimalHits.TabIndex = 21
        Me.lblOptimalHits.Text = "No. of Page Faults:"
        Me.lblOptimalHits.Visible = False
        '
        'lblOptimalFaults
        '
        Me.lblOptimalFaults.AutoSize = True
        Me.lblOptimalFaults.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptimalFaults.ForeColor = System.Drawing.Color.Red
        Me.lblOptimalFaults.Location = New System.Drawing.Point(1187, 55)
        Me.lblOptimalFaults.Name = "lblOptimalFaults"
        Me.lblOptimalFaults.Size = New System.Drawing.Size(104, 13)
        Me.lblOptimalFaults.TabIndex = 19
        Me.lblOptimalFaults.Text = "No. of Page Faults:"
        Me.lblOptimalFaults.Visible = False
        '
        'lblOptimalFaultRatio
        '
        Me.lblOptimalFaultRatio.AutoSize = True
        Me.lblOptimalFaultRatio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptimalFaultRatio.ForeColor = System.Drawing.Color.Red
        Me.lblOptimalFaultRatio.Location = New System.Drawing.Point(1187, 80)
        Me.lblOptimalFaultRatio.Name = "lblOptimalFaultRatio"
        Me.lblOptimalFaultRatio.Size = New System.Drawing.Size(104, 13)
        Me.lblOptimalFaultRatio.TabIndex = 20
        Me.lblOptimalFaultRatio.Text = "No. of Page Faults:"
        Me.lblOptimalFaultRatio.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(1065, 130)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(55, 13)
        Me.Label27.TabIndex = 18
        Me.Label27.Text = "Hit Ratio:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(1065, 105)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(93, 13)
        Me.Label24.TabIndex = 18
        Me.Label24.Text = "No. of Page Hits:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(1065, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(66, 13)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Fault Ratio:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(1065, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "No. of Page Faults:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(1046, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Percentages:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.awow.My.Resources.Resources.book
        Me.PictureBox1.InitialImage = Global.awow.My.Resources.Resources.book
        Me.PictureBox1.Location = New System.Drawing.Point(1198, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.awow.My.Resources.Resources._new
        Me.ClientSize = New System.Drawing.Size(1337, 712)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Page Replacement"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTwo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboComparative As System.Windows.Forms.CheckBox
    Friend WithEvents cboLRU As System.Windows.Forms.CheckBox
    Friend WithEvents cboOptimal As System.Windows.Forms.CheckBox
    Friend WithEvents cboFifo As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtRefString As System.Windows.Forms.TextBox
    Friend WithEvents btnFinish As System.Windows.Forms.Button
    Friend WithEvents btnSim As System.Windows.Forms.Button
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPageFrame As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgvOne As System.Windows.Forms.DataGridView
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblFIFOHitRatio As System.Windows.Forms.Label
    Friend WithEvents lblFIFOHits As System.Windows.Forms.Label
    Friend WithEvents lblFIFOFaultRatio As System.Windows.Forms.Label
    Friend WithEvents lblFIFOFaults As System.Windows.Forms.Label
    Friend WithEvents dgvTwo As System.Windows.Forms.DataGridView
    Friend WithEvents dgvThree As System.Windows.Forms.DataGridView
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblLRUHitRatio As System.Windows.Forms.Label
    Friend WithEvents lblLRUHits As System.Windows.Forms.Label
    Friend WithEvents lblLRUFaults As System.Windows.Forms.Label
    Friend WithEvents lblLRUFaultRatio As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblOptimalHitRatio As System.Windows.Forms.Label
    Friend WithEvents lblOptimalHits As System.Windows.Forms.Label
    Friend WithEvents lblOptimalFaults As System.Windows.Forms.Label
    Friend WithEvents lblOptimalFaultRatio As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
