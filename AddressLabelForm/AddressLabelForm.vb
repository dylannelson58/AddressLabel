Option Strict On
Option Explicit On

'Dylan Nelson
'RCET0265
'Spring 2021
'Address Label Program
'https://github.com/dylannelson58

Public Class AddressLabelForm
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        ValidateFields()

        AddressLabel.Text = $"{FirstNameTextBox.Text}" & $" {LastNameTextBox.Text}" & vbNewLine &
        $"{StreetAddressTextBox.Text}" & vbNewLine &
        $"{CityTextBox.Text}, " & $"{StateTextBox.Text} " & $"{ZipTextBox.Text}"

    End Sub
    Private Sub AddressLabelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Function ValidateFields() As Boolean
        Dim problemMessage As String

        If FirstNameTextBox.Text = "" Then
            problemMessage &= "Enter First Name" & vbNewLine
        FirstNameTextBox.Focus()
        End If

        If LastNameTextBox.Text = "" Then
            problemMessage &= "Enter Last Name" & vbNewLine
            LastNameTextBox.Focus()
        End If

        If StreetAddressTextBox.Text = "" Then
            problemMessage &= "Enter Street" & vbNewLine
            StreetAddressTextBox.Focus()
        End If

        If CityTextBox.Text = "" Then
            problemMessage &= "Enter City" & vbNewLine
            CityTextBox.Focus()
        End If

        If StateTextBox.Text = "" Then
            problemMessage &= "Enter State" & vbNewLine
            StateTextBox.Focus()
        End If

        If ZipTextBox.Text = "" Then
            problemMessage &= "Enter Zip Code" & vbNewLine
            ZipTextBox.Focus()
        End If

        If problemMessage <> "" Then
            MsgBox(problemMessage)
        End If

        Return True

    End Function

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
        AddressLabel.Text = ""
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class