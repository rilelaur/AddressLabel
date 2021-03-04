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

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        DisplayLabel.Text = FirstNameTextBox.Text
    End Sub

End Class
