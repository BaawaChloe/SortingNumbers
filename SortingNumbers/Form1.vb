Imports System.IO

Public Class Form1
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim filePath As String = "Sample.txt
"
        Using reader As New StreamReader(filePath, True)


        End Using
    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        Dim filePath As String = "Sample.txt"
        Using writer As New StreamWriter(filePath)
            writer.WriteLine()


        End Using

    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click

    End Sub
End Class
