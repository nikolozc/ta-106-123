Public Class Form1

    Private defaultCar As New AllCars.Car
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        defaultCar.color = "Red"
        MsgBox(defaultCar.color)
    End Sub

    Private Sub btnName_Click(sender As Object, e As EventArgs) Handles btnName.Click
        defaultCar.carName = InputBox("Please enter the name of the car", "Name")
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        defaultCar.color = InputBox("Please enter the color of the car", "Name")
    End Sub

    Private Sub btnShowInfo_Click(sender As Object, e As EventArgs) Handles btnShowInfo.Click
        MessageBox.Show(defaultCar.ToString(), "Info")
    End Sub
End Class
