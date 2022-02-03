Public Class Form1

    Private defaultCar As New AllCars.Car
    Private defaultSportsCar As New AllCars.SportsCar
    Private cars As New ArrayList
    Private selectedCar As AllCars.Car

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboCarTypes.SelectedIndex = 0
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
        cars(listCars.SelectedIndex).carName = InputBox("Please enter the name of the car" & Environment.NewLine & "Cars old name: " & cars(listCars.SelectedIndex).carName, "Name")
        listCars.Items(listCars.SelectedIndex) = cars(listCars.SelectedIndex).carName
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        cars(listCars.SelectedIndex).color = InputBox("Please enter the color of the car" & Environment.NewLine & "Cars old color: " & cars(listCars.SelectedIndex).color, "Color")
    End Sub

    Private Sub btnShowInfo_Click(sender As Object, e As EventArgs) Handles btnShowInfo.Click
        showCarInfo(cars(listCars.SelectedIndex))
    End Sub

    Private Sub btnDoors_Click(sender As Object, e As EventArgs) Handles btnDoors.Click
        cars(listCars.SelectedIndex).numberOfDoors = CType(InputBox("Please enter the number of doors", "Doors"), Integer)
    End Sub

    Private Sub btnAccelerate_Click(sender As Object, e As EventArgs) Handles btnAccelerate.Click
        cars(listCars.SelectedIndex).Accelerate(CType(InputBox("Please enter the speed in mph to accelerate", "Speed"), Integer))
    End Sub

    Private Sub btnPowerWeight_Click(sender As Object, e As EventArgs) Handles btnPowerWeight.Click
        MessageBox.Show(Convert.ToString(cars(listCars.SelectedIndex).getPowerToWeightRatio()), "P/W Ratio")
    End Sub

    Private Sub listCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listCars.SelectedIndexChanged
        If listCars.SelectedIndex <> -1 Then
            cars(listCars.SelectedIndex) = cars(listCars.SelectedIndex)
        End If
    End Sub

    Private Sub btnNewCar_Click(sender As Object, e As EventArgs) Handles btnNewCar.Click
        createCar()
    End Sub
    Private Sub createCar()
        Dim addNewCar As New NewCar
        addNewCar.vehicleType = comboCarTypes.SelectedItem
        addNewCar.ShowDialog()
        Dim newCar1
        If addNewCar.boolCreate Then
            If comboCarTypes.SelectedIndex = 0 Then
                newCar1 = New AllCars.Car
            ElseIf comboCarTypes.SelectedIndex = 1 Then
                newCar1 = New AllCars.TruckCar
            ElseIf comboCarTypes.SelectedIndex = 2 Then
                newCar1 = New AllCars.SportsCar
            End If
            Using newCar1
                With newCar1
                    .carName = addNewCar.carName
                    .color = addNewCar.carColor
                    .HorsePower = addNewCar.carHorse
                    .numberOfDoors = addNewCar.carDoors
                End With
                cars.Add(newCar1)
                listCars.Items.Add(newCar1.carName)
            End Using
        End If
    End Sub
End Class
