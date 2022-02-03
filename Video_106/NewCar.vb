Public Class NewCar

    Public carName As String
    Public carColor As String
    Public carDoors As Integer
    Public carHorse As String
    Public boolCreate As Boolean = False
    Public vehicleType As String

    Private Sub txtCarName_TextChanged(sender As Object, e As EventArgs) Handles txtCarName.TextChanged
        carName = txtCarName.Text
    End Sub

    Private Sub txtCarColor_TextChanged(sender As Object, e As EventArgs) Handles txtCarColor.TextChanged
        carColor = txtCarColor.Text
    End Sub

    Private Sub numerDoors_ValueChanged(sender As Object, e As EventArgs) Handles numerDoors.ValueChanged
        carDoors = numerDoors.Value
    End Sub

    Private Sub txtCarHorsePower_TextChanged(sender As Object, e As EventArgs) Handles txtCarHorsePower.TextChanged
        carHorse = txtCarHorsePower.Text
    End Sub

    Private Sub btnAddCar_Click(sender As Object, e As EventArgs) Handles btnAddCar.Click
        boolCreate = True
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class