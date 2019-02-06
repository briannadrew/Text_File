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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.UnsortedList = New System.Windows.Forms.ListBox()
        Me.SortedList = New System.Windows.Forms.ListBox()
        Me.ReadButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.AscendButton = New System.Windows.Forms.Button()
        Me.DescendButton = New System.Windows.Forms.Button()
        Me.UnsortedLabel = New System.Windows.Forms.Label()
        Me.SortedLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UnsortedList
        '
        Me.UnsortedList.BackColor = System.Drawing.Color.Black
        Me.UnsortedList.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnsortedList.ForeColor = System.Drawing.Color.White
        Me.UnsortedList.FormattingEnabled = True
        Me.UnsortedList.ItemHeight = 20
        Me.UnsortedList.Location = New System.Drawing.Point(48, 60)
        Me.UnsortedList.Name = "UnsortedList"
        Me.UnsortedList.Size = New System.Drawing.Size(487, 624)
        Me.UnsortedList.TabIndex = 0
        '
        'SortedList
        '
        Me.SortedList.BackColor = System.Drawing.Color.Black
        Me.SortedList.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SortedList.ForeColor = System.Drawing.Color.White
        Me.SortedList.FormattingEnabled = True
        Me.SortedList.ItemHeight = 20
        Me.SortedList.Location = New System.Drawing.Point(869, 60)
        Me.SortedList.Name = "SortedList"
        Me.SortedList.Size = New System.Drawing.Size(487, 624)
        Me.SortedList.TabIndex = 1
        '
        'ReadButton
        '
        Me.ReadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReadButton.ForeColor = System.Drawing.Color.Blue
        Me.ReadButton.Location = New System.Drawing.Point(156, 706)
        Me.ReadButton.Name = "ReadButton"
        Me.ReadButton.Size = New System.Drawing.Size(236, 37)
        Me.ReadButton.TabIndex = 2
        Me.ReadButton.Text = "Read in names.txt"
        Me.ReadButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.Blue
        Me.ExitButton.Location = New System.Drawing.Point(1006, 706)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(223, 37)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'AscendButton
        '
        Me.AscendButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AscendButton.ForeColor = System.Drawing.Color.Blue
        Me.AscendButton.Location = New System.Drawing.Point(590, 221)
        Me.AscendButton.Name = "AscendButton"
        Me.AscendButton.Size = New System.Drawing.Size(223, 103)
        Me.AscendButton.TabIndex = 4
        Me.AscendButton.Text = "Ascending Order"
        Me.AscendButton.UseVisualStyleBackColor = True
        '
        'DescendButton
        '
        Me.DescendButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescendButton.ForeColor = System.Drawing.Color.Blue
        Me.DescendButton.Location = New System.Drawing.Point(590, 433)
        Me.DescendButton.Name = "DescendButton"
        Me.DescendButton.Size = New System.Drawing.Size(223, 103)
        Me.DescendButton.TabIndex = 5
        Me.DescendButton.Text = "Descending Order"
        Me.DescendButton.UseVisualStyleBackColor = True
        '
        'UnsortedLabel
        '
        Me.UnsortedLabel.AutoSize = True
        Me.UnsortedLabel.BackColor = System.Drawing.Color.Transparent
        Me.UnsortedLabel.Font = New System.Drawing.Font("Courier New", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnsortedLabel.ForeColor = System.Drawing.Color.Red
        Me.UnsortedLabel.Location = New System.Drawing.Point(43, 18)
        Me.UnsortedLabel.Name = "UnsortedLabel"
        Me.UnsortedLabel.Size = New System.Drawing.Size(418, 29)
        Me.UnsortedLabel.TabIndex = 6
        Me.UnsortedLabel.Text = "Original Text File Content:"
        '
        'SortedLabel
        '
        Me.SortedLabel.AutoSize = True
        Me.SortedLabel.BackColor = System.Drawing.Color.Transparent
        Me.SortedLabel.Font = New System.Drawing.Font("Courier New", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SortedLabel.ForeColor = System.Drawing.Color.Red
        Me.SortedLabel.Location = New System.Drawing.Point(864, 18)
        Me.SortedLabel.Name = "SortedLabel"
        Me.SortedLabel.Size = New System.Drawing.Size(388, 29)
        Me.SortedLabel.TabIndex = 7
        Me.SortedLabel.Text = "Sorted Text File Content:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Brianna_Drew_Assignment_4_.My.Resources.Resources._1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1405, 755)
        Me.Controls.Add(Me.SortedLabel)
        Me.Controls.Add(Me.UnsortedLabel)
        Me.Controls.Add(Me.DescendButton)
        Me.Controls.Add(Me.AscendButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ReadButton)
        Me.Controls.Add(Me.SortedList)
        Me.Controls.Add(Me.UnsortedList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Text File Read & Sort"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UnsortedList As ListBox
    Friend WithEvents SortedList As ListBox
    Friend WithEvents ReadButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents AscendButton As Button
    Friend WithEvents DescendButton As Button
    Friend WithEvents UnsortedLabel As Label
    Friend WithEvents SortedLabel As Label
End Class
