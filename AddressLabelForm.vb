'Laura Riley
'RCET 0265
'Spring 2021
'Address Label Program
'https://github.com/rilelaur/AddressLabel.git

Public Class AddressLabelForm
    'Exits the program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'Clears all textboxes and the display label
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        StreetAddressTextBox.Clear()
        CityTextBox.Clear()
        StateTextBox.Clear()
        ZipTextBox.Clear()

        DisplayLabel.Text = ""
    End Sub

    'Displays the label, but if any of the boxes are empty or simply a space it will prompt the user to add
    'what is missing
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        DisplayLabel.Text = FirstNameTextBox.Text & " " & LastNameTextBox.Text &
            vbCrLf & StreetAddressTextBox.Text & vbCrLf & CityTextBox.Text & ", " &
            StateTextBox.Text & " " & ZipTextBox.Text

        If FirstNameTextBox.Text = "" Or FirstNameTextBox.Text = " " Then
            MsgBox("Please enter your first name.")
        ElseIf LastNameTextBox.Text = "" Or LastNameTextBox.Text = " " Then
            MsgBox("Please enter your last name.")
        ElseIf StreetAddressTextBox.Text = "" Or StreetAddressTextBox.Text = " " Then
            MsgBox("Please enter your street address.")
        ElseIf CityTextBox.Text = "" Or CityTextBox.Text = " " Then
            MsgBox("Please enter your city name.")
        ElseIf StateTextBox.Text = "" Or StateTextBox.Text = " " Then
            MsgBox("Please enter your state.")
        ElseIf ZipTextBox.Text = "" Or ZipTextBox.Text = " " Then
            MsgBox("Please enter your first name.")
        End If
    End Sub

End Class
