Namespace Wizards
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CustomWinFormsControl
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
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
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.LocationButton = New System.Windows.Forms.Button()
            Me.TextBoxA = New System.Windows.Forms.TextBox()
            Me.TextBoxB = New System.Windows.Forms.TextBox()
            Me.Errors = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.Errors, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 4
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.TableLayoutPanel1.Controls.Add(Me.LocationButton, 3, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBoxA, 2, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBoxB, 2, 2)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 4
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(663, 376)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'LocationButton
            '
            Me.LocationButton.Location = New System.Drawing.Point(585, 3)
            Me.LocationButton.Name = "LocationButton"
            Me.LocationButton.Size = New System.Drawing.Size(75, 23)
            Me.LocationButton.TabIndex = 2
            Me.LocationButton.Text = "Browse"
            Me.LocationButton.UseVisualStyleBackColor = True
            '
            'TextBoxA
            '
            Me.TextBoxA.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TextBoxA.Location = New System.Drawing.Point(3, 3)
            Me.TextBoxA.Name = "TextBoxA"
            Me.TextBoxA.ReadOnly = True
            Me.TextBoxA.Size = New System.Drawing.Size(576, 20)
            Me.TextBoxA.TabIndex = 1
            '
            'TextBoxB
            '
            Me.TextBoxB.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TextBoxB.Location = New System.Drawing.Point(3, 32)
            Me.TextBoxB.Name = "TextBoxB"
            Me.TextBoxB.ReadOnly = True
            Me.TextBoxB.Size = New System.Drawing.Size(576, 20)
            Me.TextBoxB.TabIndex = 3
            '
            'Errors
            '
            Me.Errors.ContainerControl = Me
            '
            'CustomWinFormsControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Name = "CustomWinFormsControl"
            Me.Size = New System.Drawing.Size(663, 376)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            CType(Me.Errors, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents LocationButton As System.Windows.Forms.Button
        Friend WithEvents TextBoxA As System.Windows.Forms.TextBox
        Friend WithEvents TextBoxB As System.Windows.Forms.TextBox
        Friend WithEvents Errors As System.Windows.Forms.ErrorProvider

    End Class
End Namespace