Imports System.IO
Imports System.Linq

Public Class Form1
    Dim filePath As String = "numbers.txt"

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        Dim number As Integer = nudInput.Value

        Using writer As StreamWriter = New StreamWriter(filePath, True)
            writer.WriteLine(number)
        End Using

        MessageBox.Show("Number saved successfully to numbers.txt.")
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        If Not File.Exists(filePath) Then
            MessageBox.Show("File not found. Please write numbers first.")
            Return
        End If

        ListBox1.Items.Clear()

        Dim lines() As String = File.ReadAllLines(filePath)
        For Each line In lines
            ListBox1.Items.Add(line)
        Next
    End Sub


    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        If Not File.Exists(filePath) Then
            MessageBox.Show("File not found. Please write numbers first.")
            Return
        End If

        Dim numbers = File.ReadAllLines(filePath).Select(Function(n) Convert.ToInt32(n)).ToList()

        Dim sortedNumbers = numbers.OrderBy(Function(n) n).ToList()

        ListBox1.Items.Clear()
        For Each num In sortedNumbers
            ListBox1.Items.Add(num)
        Next

        MessageBox.Show("Numbers sorted successfully.")

    End Sub
End Class
