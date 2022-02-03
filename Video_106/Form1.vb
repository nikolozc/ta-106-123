Public Class Form1

    Private defaultCar As New AllCars.Car
    Private defaultSportsCar As New AllCars.SportsCar
    Private cars As New ArrayList
    Private selectedCar As AllCars.Car

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        defaultCar.carName = "Honda CR-V"
        defaultSportsCar.carName = "Mustang GT"
        cars.Add(defaultCar)
        cars.Add(defaultSportsCar)
        addAllCars()
    End Sub

    Private Sub addAllCars()
        For Each car As AllCars.Car In cars
            listCars.Items.Add(car.carName)
        Next
    End Sub

    Private Sub showCarInfo(ByVal argCar As AllCars.Car)
        MessageBox.Show(argCar.ToString(), "Info")
    End Sub
    Private Sub btnName_Click(sender As Object, e As EventArgs) Handles btnName.Click
        defaultCar.carName = InputBox("Please enter the name of the car", "Name")
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        defaultCar.color = InputBox("Please enter the color of the car", "Name")
    End Sub

    Private Sub btnShowInfo_Click(sender As Object, e As EventArgs) Handles btnShowInfo.Click
        showCarInfo(selectedCar)
    End Sub

    Private Sub btnDoors_Click(sender As Object, e As EventArgs) Handles btnDoors.Click
        defaultCar.numberOfDoors = CType(InputBox("Please enter the number of doors"), Integer)
    End Sub

    Private Sub btnAccelerate_Click(sender As Object, e As EventArgs) Handles btnAccelerate.Click
        defaultCar.Accelerate(CType(InputBox("Please enter the speed in mph to accelerate", "Speed"), Integer))
    End Sub

    Private Sub btnPowerWeight_Click(sender As Object, e As EventArgs) Handles btnPowerWeight.Click
        MessageBox.Show(Convert.ToString(defaultSportsCar.getPowerToWeightRatio()), "P/W Ratio")
    End Sub

    Private Sub listCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listCars.SelectedIndexChanged
        If listCars.SelectedIndex <> -1 Then
            selectedCar = cars(listCars.SelectedIndex)
        End If
    End Sub
End Class
