<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
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
        Me.contacttracingapp = New System.Windows.Forms.Label()
        Me.female = New System.Windows.Forms.RadioButton()
        Me.lgbt = New System.Windows.Forms.RadioButton()
        Me.male = New System.Windows.Forms.RadioButton()
        Me.gendergroup = New System.Windows.Forms.GroupBox()
        Me.sub1 = New System.Windows.Forms.Button()
        Me.contactbx = New System.Windows.Forms.TextBox()
        Me.contact = New System.Windows.Forms.Label()
        Me.emailbx = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.Label()
        Me.addbx = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.Label()
        Me.namebx = New System.Windows.Forms.TextBox()
        Me.namelabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gendergroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'contacttracingapp
        '
        Me.contacttracingapp.AutoSize = True
        Me.contacttracingapp.Font = New System.Drawing.Font("Lucida Fax", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contacttracingapp.Location = New System.Drawing.Point(58, 9)
        Me.contacttracingapp.Name = "contacttracingapp"
        Me.contacttracingapp.Size = New System.Drawing.Size(414, 43)
        Me.contacttracingapp.TabIndex = 18
        Me.contacttracingapp.Text = "Contact Tracing App"
        '
        'female
        '
        Me.female.AutoSize = True
        Me.female.Location = New System.Drawing.Point(74, 19)
        Me.female.Name = "female"
        Me.female.Size = New System.Drawing.Size(59, 17)
        Me.female.TabIndex = 16
        Me.female.TabStop = True
        Me.female.Text = "Female"
        Me.female.UseVisualStyleBackColor = True
        '
        'lgbt
        '
        Me.lgbt.AutoSize = True
        Me.lgbt.Location = New System.Drawing.Point(139, 19)
        Me.lgbt.Name = "lgbt"
        Me.lgbt.Size = New System.Drawing.Size(77, 17)
        Me.lgbt.TabIndex = 17
        Me.lgbt.TabStop = True
        Me.lgbt.Text = "LGBTQIA+"
        Me.lgbt.UseVisualStyleBackColor = True
        '
        'male
        '
        Me.male.AutoSize = True
        Me.male.Location = New System.Drawing.Point(20, 19)
        Me.male.Name = "male"
        Me.male.Size = New System.Drawing.Size(48, 17)
        Me.male.TabIndex = 15
        Me.male.TabStop = True
        Me.male.Text = "Male"
        Me.male.UseVisualStyleBackColor = True
        '
        'gendergroup
        '
        Me.gendergroup.Controls.Add(Me.male)
        Me.gendergroup.Controls.Add(Me.lgbt)
        Me.gendergroup.Controls.Add(Me.female)
        Me.gendergroup.Location = New System.Drawing.Point(15, 141)
        Me.gendergroup.Name = "gendergroup"
        Me.gendergroup.Size = New System.Drawing.Size(226, 47)
        Me.gendergroup.TabIndex = 19
        Me.gendergroup.TabStop = False
        Me.gendergroup.Text = "Gender"
        '
        'sub1
        '
        Me.sub1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sub1.Location = New System.Drawing.Point(15, 194)
        Me.sub1.Name = "sub1"
        Me.sub1.Size = New System.Drawing.Size(265, 76)
        Me.sub1.TabIndex = 0
        Me.sub1.Text = "Submit"
        Me.sub1.UseVisualStyleBackColor = True
        '
        'contactbx
        '
        Me.contactbx.Location = New System.Drawing.Point(351, 63)
        Me.contactbx.Name = "contactbx"
        Me.contactbx.Size = New System.Drawing.Size(161, 20)
        Me.contactbx.TabIndex = 6
        '
        'contact
        '
        Me.contact.AutoSize = True
        Me.contact.Location = New System.Drawing.Point(298, 66)
        Me.contact.Name = "contact"
        Me.contact.Size = New System.Drawing.Size(47, 13)
        Me.contact.TabIndex = 12
        Me.contact.Text = "Contact:"
        '
        'emailbx
        '
        Me.emailbx.Location = New System.Drawing.Point(351, 106)
        Me.emailbx.Name = "emailbx"
        Me.emailbx.Size = New System.Drawing.Size(161, 20)
        Me.emailbx.TabIndex = 7
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Location = New System.Drawing.Point(306, 109)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(38, 13)
        Me.email.TabIndex = 13
        Me.email.Text = "E-mail:"
        '
        'addbx
        '
        Me.addbx.Location = New System.Drawing.Point(66, 106)
        Me.addbx.Name = "addbx"
        Me.addbx.Size = New System.Drawing.Size(211, 20)
        Me.addbx.TabIndex = 5
        '
        'address
        '
        Me.address.AutoSize = True
        Me.address.Location = New System.Drawing.Point(12, 109)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(48, 13)
        Me.address.TabIndex = 10
        Me.address.Text = "Address:"
        '
        'namebx
        '
        Me.namebx.Location = New System.Drawing.Point(66, 67)
        Me.namebx.Name = "namebx"
        Me.namebx.Size = New System.Drawing.Size(211, 20)
        Me.namebx.TabIndex = 20
        '
        'namelabel
        '
        Me.namelabel.AutoSize = True
        Me.namelabel.Location = New System.Drawing.Point(3, 70)
        Me.namelabel.Name = "namelabel"
        Me.namelabel.Size = New System.Drawing.Size(57, 13)
        Me.namelabel.TabIndex = 21
        Me.namelabel.Text = "Full Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(286, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 104)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Take care of yourself, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "always rehydrate and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "spray alcohol everytime " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you com" &
    "e home"
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 302)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.namelabel)
        Me.Controls.Add(Me.namebx)
        Me.Controls.Add(Me.contacttracingapp)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.contact)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.emailbx)
        Me.Controls.Add(Me.contactbx)
        Me.Controls.Add(Me.addbx)
        Me.Controls.Add(Me.sub1)
        Me.Controls.Add(Me.gendergroup)
        Me.Name = "form1"
        Me.Text = "Form1"
        Me.gendergroup.ResumeLayout(False)
        Me.gendergroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents contacttracingapp As Label
    Friend WithEvents female As RadioButton
    Friend WithEvents lgbt As RadioButton
    Friend WithEvents male As RadioButton
    Friend WithEvents gendergroup As GroupBox
    Friend WithEvents sub1 As Button
    Friend WithEvents contactbx As TextBox
    Friend WithEvents contact As Label
    Friend WithEvents emailbx As TextBox
    Friend WithEvents email As Label
    Friend WithEvents addbx As TextBox
    Friend WithEvents address As Label
    Friend WithEvents namebx As TextBox
    Friend WithEvents namelabel As Label
    Friend WithEvents Label1 As Label
End Class
