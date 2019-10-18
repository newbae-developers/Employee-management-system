Imports MySql.Data.MySqlClient
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents addempePanel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents submit_to_dbbtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents phone_TextBox As TextBox
    Friend WithEvents email_textbox As TextBox
    Friend WithEvents Currentadd_textbox As TextBox
    Friend WithEvents dep_TextBox As TextBox
    Friend WithEvents firstN_TextBox2 As TextBox
    Friend WithEvents id_TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LastN_TextBox As TextBox
    Friend WithEvents Empedetails_Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents FirstNameFRMsearch_textbox As TextBox
    Friend WithEvents IDFRMsearch_txtbox As TextBox
    Friend WithEvents searchFRMsearch As Button
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBoxclose As PictureBox
    Friend WithEvents DataGridView1 As DataGridView

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.empdetailsbtn = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.addempePanel1 = New System.Windows.Forms.Panel()
        Me.phone_TextBox = New System.Windows.Forms.TextBox()
        Me.email_textbox = New System.Windows.Forms.TextBox()
        Me.Currentadd_textbox = New System.Windows.Forms.TextBox()
        Me.dep_TextBox = New System.Windows.Forms.TextBox()
        Me.LastN_TextBox = New System.Windows.Forms.TextBox()
        Me.firstN_TextBox2 = New System.Windows.Forms.TextBox()
        Me.id_TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.submit_to_dbbtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Empedetails_Panel2 = New System.Windows.Forms.Panel()
        Me.searchFRMsearch = New System.Windows.Forms.Button()
        Me.FirstNameFRMsearch_textbox = New System.Windows.Forms.TextBox()
        Me.IDFRMsearch_txtbox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.PictureBoxclose = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.addempePanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Empedetails_Panel2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.PictureBoxclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(0, -4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(216, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add Employee"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 224)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(216, 50)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Leave Management"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(-2, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(216, 50)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Report"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'empdetailsbtn
        '
        Me.empdetailsbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empdetailsbtn.Location = New System.Drawing.Point(0, 56)
        Me.empdetailsbtn.Name = "empdetailsbtn"
        Me.empdetailsbtn.Size = New System.Drawing.Size(216, 50)
        Me.empdetailsbtn.TabIndex = 4
        Me.empdetailsbtn.Text = "Employee Details"
        Me.empdetailsbtn.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(-2, 168)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(216, 50)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Holiday Management"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.empdetailsbtn)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 274)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(247, -15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(547, 272)
        Me.Panel1.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft YaHei Light", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Red
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(537, 313)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(263, 25)
        Me.DateTimePicker1.TabIndex = 7
        '
        'addempePanel1
        '
        Me.addempePanel1.Controls.Add(Me.phone_TextBox)
        Me.addempePanel1.Controls.Add(Me.email_textbox)
        Me.addempePanel1.Controls.Add(Me.Currentadd_textbox)
        Me.addempePanel1.Controls.Add(Me.dep_TextBox)
        Me.addempePanel1.Controls.Add(Me.LastN_TextBox)
        Me.addempePanel1.Controls.Add(Me.firstN_TextBox2)
        Me.addempePanel1.Controls.Add(Me.id_TextBox1)
        Me.addempePanel1.Controls.Add(Me.Label8)
        Me.addempePanel1.Controls.Add(Me.submit_to_dbbtn)
        Me.addempePanel1.Controls.Add(Me.Label7)
        Me.addempePanel1.Controls.Add(Me.Label6)
        Me.addempePanel1.Controls.Add(Me.Label5)
        Me.addempePanel1.Controls.Add(Me.Label4)
        Me.addempePanel1.Controls.Add(Me.Label3)
        Me.addempePanel1.Controls.Add(Me.Label2)
        Me.addempePanel1.Controls.Add(Me.Label1)
        Me.addempePanel1.Controls.Add(Me.PictureBox1)
        Me.addempePanel1.Location = New System.Drawing.Point(249, 51)
        Me.addempePanel1.Name = "addempePanel1"
        Me.addempePanel1.Size = New System.Drawing.Size(547, 267)
        Me.addempePanel1.TabIndex = 8
        '
        'phone_TextBox
        '
        Me.phone_TextBox.Location = New System.Drawing.Point(123, 200)
        Me.phone_TextBox.Name = "phone_TextBox"
        Me.phone_TextBox.Size = New System.Drawing.Size(216, 20)
        Me.phone_TextBox.TabIndex = 22
        '
        'email_textbox
        '
        Me.email_textbox.Location = New System.Drawing.Point(123, 173)
        Me.email_textbox.Name = "email_textbox"
        Me.email_textbox.Size = New System.Drawing.Size(216, 20)
        Me.email_textbox.TabIndex = 21
        '
        'Currentadd_textbox
        '
        Me.Currentadd_textbox.Location = New System.Drawing.Point(123, 144)
        Me.Currentadd_textbox.Name = "Currentadd_textbox"
        Me.Currentadd_textbox.Size = New System.Drawing.Size(216, 20)
        Me.Currentadd_textbox.TabIndex = 20
        '
        'dep_TextBox
        '
        Me.dep_TextBox.Location = New System.Drawing.Point(123, 116)
        Me.dep_TextBox.Name = "dep_TextBox"
        Me.dep_TextBox.Size = New System.Drawing.Size(216, 20)
        Me.dep_TextBox.TabIndex = 19
        '
        'LastN_TextBox
        '
        Me.LastN_TextBox.Location = New System.Drawing.Point(123, 90)
        Me.LastN_TextBox.Name = "LastN_TextBox"
        Me.LastN_TextBox.Size = New System.Drawing.Size(216, 20)
        Me.LastN_TextBox.TabIndex = 18
        '
        'firstN_TextBox2
        '
        Me.firstN_TextBox2.Location = New System.Drawing.Point(123, 66)
        Me.firstN_TextBox2.Name = "firstN_TextBox2"
        Me.firstN_TextBox2.Size = New System.Drawing.Size(216, 20)
        Me.firstN_TextBox2.TabIndex = 17
        '
        'id_TextBox1
        '
        Me.id_TextBox1.Location = New System.Drawing.Point(123, 40)
        Me.id_TextBox1.Name = "id_TextBox1"
        Me.id_TextBox1.Size = New System.Drawing.Size(109, 20)
        Me.id_TextBox1.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "ID"
        '
        'submit_to_dbbtn
        '
        Me.submit_to_dbbtn.Location = New System.Drawing.Point(216, 226)
        Me.submit_to_dbbtn.Name = "submit_to_dbbtn"
        Me.submit_to_dbbtn.Size = New System.Drawing.Size(75, 23)
        Me.submit_to_dbbtn.TabIndex = 12
        Me.submit_to_dbbtn.Text = "Submit"
        Me.submit_to_dbbtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Phone no"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Current Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Add Employee Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(413, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 122)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Empedetails_Panel2
        '
        Me.Empedetails_Panel2.Controls.Add(Me.DataGridView1)
        Me.Empedetails_Panel2.Controls.Add(Me.searchFRMsearch)
        Me.Empedetails_Panel2.Controls.Add(Me.FirstNameFRMsearch_textbox)
        Me.Empedetails_Panel2.Controls.Add(Me.IDFRMsearch_txtbox)
        Me.Empedetails_Panel2.Controls.Add(Me.Label11)
        Me.Empedetails_Panel2.Controls.Add(Me.Label10)
        Me.Empedetails_Panel2.Controls.Add(Me.Label9)
        Me.Empedetails_Panel2.Location = New System.Drawing.Point(246, 51)
        Me.Empedetails_Panel2.Name = "Empedetails_Panel2"
        Me.Empedetails_Panel2.Size = New System.Drawing.Size(554, 264)
        Me.Empedetails_Panel2.TabIndex = 9
        '
        'searchFRMsearch
        '
        Me.searchFRMsearch.Location = New System.Drawing.Point(200, 124)
        Me.searchFRMsearch.Name = "searchFRMsearch"
        Me.searchFRMsearch.Size = New System.Drawing.Size(75, 23)
        Me.searchFRMsearch.TabIndex = 5
        Me.searchFRMsearch.Text = "Search"
        Me.searchFRMsearch.UseVisualStyleBackColor = True
        '
        'FirstNameFRMsearch_textbox
        '
        Me.FirstNameFRMsearch_textbox.Location = New System.Drawing.Point(147, 82)
        Me.FirstNameFRMsearch_textbox.Name = "FirstNameFRMsearch_textbox"
        Me.FirstNameFRMsearch_textbox.Size = New System.Drawing.Size(192, 20)
        Me.FirstNameFRMsearch_textbox.TabIndex = 4
        '
        'IDFRMsearch_txtbox
        '
        Me.IDFRMsearch_txtbox.Location = New System.Drawing.Point(147, 47)
        Me.IDFRMsearch_txtbox.Name = "IDFRMsearch_txtbox"
        Me.IDFRMsearch_txtbox.Size = New System.Drawing.Size(192, 20)
        Me.IDFRMsearch_txtbox.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(46, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 18)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 18)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "First Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(172, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Employee Details"
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 33)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(504, 0)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Help"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 33)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(504, 0)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "About Us"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 33)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(504, 0)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Report"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(504, 0)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Administrator"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.TabControl2)
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(504, 0)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Modules"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Controls.Add(Me.TabPage8)
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(200, 100)
        Me.TabControl2.TabIndex = 1
        '
        'TabPage7
        '
        Me.TabPage7.Location = New System.Drawing.Point(4, 33)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(192, 63)
        Me.TabPage7.TabIndex = 0
        Me.TabPage7.Text = "TabPage7"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.Location = New System.Drawing.Point(4, 33)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(192, 63)
        Me.TabPage8.TabIndex = 1
        Me.TabPage8.Text = "TabPage8"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(242, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(512, 30)
        Me.TabControl1.TabIndex = 0
        '
        'PictureBoxclose
        '
        Me.PictureBoxclose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxclose.ErrorImage = Nothing
        Me.PictureBoxclose.Image = CType(resources.GetObject("PictureBoxclose.Image"), System.Drawing.Image)
        Me.PictureBoxclose.InitialImage = Nothing
        Me.PictureBoxclose.Location = New System.Drawing.Point(760, 4)
        Me.PictureBoxclose.Name = "PictureBoxclose"
        Me.PictureBoxclose.Size = New System.Drawing.Size(36, 34)
        Me.PictureBoxclose.TabIndex = 10
        Me.PictureBoxclose.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 153)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(537, 108)
        Me.DataGridView1.TabIndex = 6
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(800, 341)
        Me.Controls.Add(Me.PictureBoxclose)
        Me.Controls.Add(Me.Empedetails_Panel2)
        Me.Controls.Add(Me.addempePanel1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attandance System"
        Me.GroupBox1.ResumeLayout(False)
        Me.addempePanel1.ResumeLayout(False)
        Me.addempePanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Empedetails_Panel2.ResumeLayout(False)
        Me.Empedetails_Panel2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        CType(Me.PictureBoxclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents empdetailsbtn As Button
    Friend WithEvents Button5 As Button

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        addempePanel1.Visible = False
        Empedetails_Panel2.Visible = False

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        addempePanel1.Visible = False
        Empedetails_Panel2.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles empdetailsbtn.Click
        addempePanel1.Visible = False
        Empedetails_Panel2.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addempePanel1.Visible = True
        Empedetails_Panel2.Visible = False


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles addempePanel1.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles id_TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        addempePanel1.Visible = False
        Empedetails_Panel2.Visible = False
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles FirstNameFRMsearch_textbox.TextChanged

    End Sub

    Private Sub IDFRMsearch_txtbox_TextChanged(sender As Object, e As EventArgs) Handles IDFRMsearch_txtbox.TextChanged

    End Sub

    Private Sub SearchFRMsearch_Click(sender As Object, e As EventArgs) Handles searchFRMsearch.Click, searchFRMsearch.MouseHover
        Dim connection As New MySqlConnection("Server=localhost;uid=root;database=user_databasefor_login_form")
        ' create a command to insert
        Dim command As New MySqlCommand("Update() `Empployee` Set `ID`=[value-1],`First Name`=[value-2],`Last Name`=[value-3],
            `Department`=[value-4],`Current address`=[value-5],`Email`=[value-6],`Phone no`=[value-7],`Gender`=[value-8] WHERE 1", connection)

        ' add Parameters to the command
        command.Parameters.Add("@Eid", MySqlDbType.VarChar).Value = id_TextBox1.Text
        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = firstN_TextBox2.Text
        command.Parameters.Add("@last", MySqlDbType.VarChar).Value = LastN_TextBox.Text
        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email_textbox.Text
        command.Parameters.Add("@depart", MySqlDbType.VarChar).Value = dep_TextBox.Text
        command.Parameters.Add("@currentaddr", MySqlDbType.VarChar).Value = Currentadd_textbox.Text
        command.Parameters.Add("@phoneno", MySqlDbType.VarChar).Value = phone_TextBox.Text
        'command.Parameters.Add("@gend", MySqlDbType.VarChar).Value = email_textbox.Text



        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Data Updated")

        Else
            MessageBox.Show("Data Not Updated")
        End If


        connection.Close()
    End Sub


    Private Sub EmpedetailsPanel2_Paint(sender As Object, e As PaintEventArgs) Handles Empedetails_Panel2.Paint

    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles submit_to_dbbtn.Click

        Dim connection As New MySqlConnection("Server=localhost;uid=root;database=user_databasefor_login_form")
        ' create a command to insert
        Dim command As New MySqlCommand("INSERT INTO `employee`(`ID`, `First Name`, `Last Name`,`Department`,`Current address`,`Email`,`Phone no`) VALUES (@Eid,@fn,@last,@depart,@Currentaddr,@email,@phono)", connection)

        ' add Parameters to the command
        command.Parameters.Add("@Eid", MySqlDbType.VarChar).Value = id_TextBox1.Text
        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = firstN_TextBox2.Text
        command.Parameters.Add("@last", MySqlDbType.VarChar).Value = LastN_TextBox.Text
        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email_textbox.Text
        command.Parameters.Add("@depart", MySqlDbType.VarChar).Value = dep_TextBox.Text
        command.Parameters.Add("@currentaddr", MySqlDbType.VarChar).Value = Currentadd_textbox.Text
        command.Parameters.Add("@phono", MySqlDbType.VarChar).Value = phone_TextBox.Text
        'command.Parameters.Add("@gend", MySqlDbType.VarChar).Value = email_textbox.Text



        connection.Open()
        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Data Inserted")

        Else

            MessageBox.Show("ERROR")

        End If

        connection.Close()
    End Sub

    Private Sub Phone_TextBox_TextChanged(sender As Object, e As EventArgs) Handles phone_TextBox.TextChanged

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBoxclose_Click(sender As Object, e As EventArgs) Handles PictureBoxclose.Click
        Me.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub FirstN_TextBox2_TextChanged(sender As Object, e As EventArgs) Handles firstN_TextBox2.TextChanged

    End Sub

    Private Sub LastN_TextBox_TextChanged(sender As Object, e As EventArgs) Handles LastN_TextBox.TextChanged

    End Sub

    Private Sub Dep_TextBox_TextChanged(sender As Object, e As EventArgs) Handles dep_TextBox.TextChanged

    End Sub

    Private Sub Email_textbox_TextChanged(sender As Object, e As EventArgs) Handles email_textbox.TextChanged

    End Sub

    Private Sub Currentadd_textbox_TextChanged(sender As Object, e As EventArgs) Handles Currentadd_textbox.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
