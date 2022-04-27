Imports System.IO
Imports System.Text

Public Class Form1
    'Derek Bradshaw
    '10/9/21
    'CPT 341 VB.NET NJIT Fall 2021 Semester 2021

    'to get the test from the content field. 
    'Returns as a String
    Private Function getUserContents()
        Dim userInput As String = ""
        Try 'storing UserInput as String
            userInput = txtContents.Text
        Catch
            'Creates pop-up to tell user error
            MessageBox.Show("Error", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSearchTerm.Clear()
        End Try
        Return userInput

    End Function
    '
    Private Function Cipher(ch As Char, key As Integer) As Char
        If Not Char.IsLetter(ch) Then
            Return ch
        End If

        Dim offset As Integer = Convert.ToInt32(If(Char.IsUpper(ch), "A"c, "a"c))
        Return ChrW((((Convert.ToInt32(ch) + key) - offset) Mod 26) + offset)
    End Function

    Private Function Encipher(input As String, key As Integer) As String
        Dim output As String = ""

        For Each ch As Char In input
            output += Cipher(ch, key)
        Next

        Return output
    End Function

    Private Function Decipher(input As String, key As Integer) As String
        Return Encipher(input, 26 - key)
    End Function

    'Counting the words
    Private Sub btnCountWords_Click(sender As Object, e As EventArgs) Handles btnCountWords.Click
        Dim userInput As String = getUserContents()
        Dim NumberOfWords As Integer
        'Count the number of spaces with test after each one
        NumberOfWords = UBound(Split(Trim(Replace(userInput, Space(2), Space(1))))) + 1
        'set the text box to the number
        txtNumWords.Text = NumberOfWords.ToString()
    End Sub

    'Counting the charachters - Spaces do count
    Private Sub btnCountChars_Click(sender As Object, e As EventArgs) Handles btnCountChars.Click
        Dim userInput As String = getUserContents()
        Dim NumberOfChars As Integer
        'Count the number of charachters
        NumberOfChars = userInput.Length
        'set the text box to the number
        TxtNumChars.Text = NumberOfChars.ToString()
    End Sub

    'Encrypt the text
    Private Sub OptionEncrpyt_Click(sender As Object, e As EventArgs) Handles OptionEncrpyt.Click
        Dim keyShift As Integer
        Dim userInput As String = getUserContents()
        Try 'storing Key as Int
            keyShift = CInt(txtKey.Text)
        Catch
            'Creates pop-up to tell user error
            MessageBox.Show("Key Should Only Contain Numbers", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtKey.Clear()
        End Try

        'Shift the charachters
        txtShifted.Text = Encipher(userInput, keyShift)
    End Sub

    'Decrypt the text
    Private Sub OptionDecrypt_Click(sender As Object, e As EventArgs) Handles OptionDecrypt.Click
        Dim keyShift As Integer
        Dim userInput As String = getUserContents()
        Try 'storing Key as Int
            keyShift = CInt(txtKey.Text)
        Catch
            'Creates pop-up to tell user error
            MessageBox.Show("Key Should Only Contain Numbers", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtKey.Clear()
        End Try

        'Shift the charachters
        txtShifted.Text = Decipher(userInput, keyShift)
    End Sub

    Private Sub OptionExit_Click(sender As Object, e As EventArgs) Handles OptionExit.Click
        Me.Close()
    End Sub

    'read in the .txt file
    Private Sub OptionOpenFile_Click(sender As Object, e As EventArgs) Handles OptionOpenFile.Click
        ' Call ShowDialog.
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then
            ' Get the file name.
            Dim path As String = OpenFileDialog1.FileName
            Try
                ' Read in text.
                txtContents.Text = File.ReadAllText(path)
            Catch
                'Creates pop-up to tell user error
                MessageBox.Show("File Read Error", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnSearchWord_Click(sender As Object, e As EventArgs) Handles btnSearchWord.Click
        txtContents.Find(txtSearchTerm.Text, RichTextBoxFinds.WholeWord)
        txtContents.SelectionBackColor = Color.LawnGreen

        txtStringIndex.Text = txtContents.Text.IndexOf(txtSearchTerm.Text)

        Dim CurrentChar As String

        For i = 0 To txtSearchTerm.Text.Length - 1
            CurrentChar = txtSearchTerm.Text.Substring(i, 1)
        Next

        'Update ANSI Number field

        Dim ANSIConv As New StringBuilder
        For Each c As String In txtSearchTerm.Text.ToCharArray()
            ANSIConv.Append(Asc(c).ToString() + " ")
        Next
        txtAnsiNum.Text = ANSIConv.ToString()

    End Sub

    Private Sub btnFindNext_Click(sender As Object, e As EventArgs) Handles btnFindNext.Click
        txtStringIndex.Text = txtContents.Text.IndexOf(txtSearchTerm.Text, CInt(txtStringIndex.Text + 1))
        Try
            txtContents.Find(txtSearchTerm.Text, CInt(txtStringIndex.Text), RichTextBoxFinds.WholeWord)
        Catch
        End Try
        txtContents.SelectionBackColor = Color.LawnGreen

        If txtStringIndex.Text = "-1" Then
            txtStringIndex.Text = "End of Search"
            MessageBox.Show("End of search", "CPT 341 Fall 2021-Project 2")
        End If



    End Sub


End Class


