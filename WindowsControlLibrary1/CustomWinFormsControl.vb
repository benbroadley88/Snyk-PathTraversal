Imports System.IO


Public Class CustomWinFormsControl

#Region " .ctor "

    Public Sub New()

        InitializeComponent()
    End Sub

#End Region

#Region " Validation "

    Private Sub TriggerValidation()
        Me.ValidateChildren(ValidationConstraints.Visible)
    End Sub

#End Region

#Region " UI Handling "

    Private Sub LocationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocationButton.Click

        Dim fileDialog = New OpenFileDialog()

        If fileDialog.ShowDialog() = DialogResult.OK Then
            If TextBoxB.Text = String.Empty OrElse TextBoxB.Text.Equals(IO.Path.GetFileName(TextBoxA.Text)) Then
                TextBoxB.Text = IO.Path.GetFileName(fileDialog.FileName)
            End If

            ' Set the project folder
            TextBoxA.Text = fileDialog.FileName

            ' Trigger validation
            Me.TriggerValidation()
        End If
    End Sub

    Private Sub TextBoxA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxA.TextChanged
        Me.ValidateChildren(ValidationConstraints.Visible)
    End Sub

    Private Sub TextBoxB_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxB.TextChanged
        Me.ValidateChildren(ValidationConstraints.Visible)
    End Sub

    Private Sub TextBoxB_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBoxB.Validating
        Me.ValidateFileExists()
    End Sub

#End Region

#Region " Helpers "

    Private Sub ValidateFileExists()
        Dim fileExists As Boolean = True
        Dim filePath As String = Path.Combine(Me.TextBoxA.Text, Me.TextBoxB.Text & ".txt")

        Try
            fileExists = (Directory.Exists(Me.TextBoxA.Text) _
                        AndAlso (File.Exists(filePath) _
                        OrElse File.Exists(Path.ChangeExtension(filePath, ".html")) _
                        OrElse File.Exists(Path.ChangeExtension(filePath, ".pdf")) _
                        OrElse File.Exists(Path.ChangeExtension(filePath, ".md"))))

        Catch ex As Exception
        End Try

        If fileExists Then
            MessageBox.Show("Already Exists")
        End If
    End Sub

#End Region

End Class