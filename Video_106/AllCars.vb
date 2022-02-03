Namespace AllCars
    Class Car
        'Public and Private Fields
        Public color As String
        Public carName As String
        Private intSpeed As Integer
        Private intNumberOfDoors As Integer
        Private intHorsePower As Integer

        'Constructor
        Sub New()
            color = "Red"
            intSpeed = 0
            intNumberOfDoors = 5
        End Sub

        'Gets speed
        Public ReadOnly Property Speed() As Integer
            Get
                Return intSpeed
            End Get
        End Property

        'Gets and Sets the horsePower
        Public Property HorsePower() As Integer
            Get
                Return intHorsePower
            End Get
            Set(value As Integer)
                intHorsePower = value
            End Set
        End Property

        'Accelerates the car
        Public Sub Accelerate(ByVal accelerateBy As Integer)
            intSpeed += accelerateBy
        End Sub

        'Overwrite ToString
        Public Overrides Function ToString() As String
            Return "Car name: " & carName & Environment.NewLine & "Car color: " & color & Environment.NewLine & "Number of doors" & numberOfDoors & Environment.NewLine & "Car speed: " & intSpeed
        End Function

        'Gets and Sets the number of doors
        Public Property numberOfDoors() As Integer
            Get
                Return intNumberOfDoors
            End Get
            Set(value As Integer)
                If value >= 2 And value <= 5 Then
                    intNumberOfDoors = value
                Else
                    MessageBox.Show("The number of doors you have entered is not valid")
                End If
            End Set
        End Property

        'Is the car moving?
        Public Function isMoving() As Boolean
            If Speed = 0 Then
                Return False
            Else
                Return True
            End If
        End Function
    End Class

    Class SportsCar
        Inherits Car

        Private weight As Integer

        Sub New()
            color = "Red"
            numberOfDoors = 2
        End Sub

        Public Function getSportsInfo() As String
            Return "Car name: " & carName & Environment.NewLine & "Car color: " & color & Environment.NewLine & "Number of doors" & numberOfDoors & Environment.NewLine & "Car speed: " & Speed & Environment.NewLine & "Horsepower: " & HorsePower & Environment.NewLine & "Weight: " & weight
        End Function

        'Get Power to Weight Ratio
        Public Function getPowerToWeightRatio() As Double
            Return CType(HorsePower, Double) / weight
        End Function
    End Class

    Class TruckCar
        Inherits Car

        Private truckBedLength As bedLength
        Private truckCabLength As cabLength

        'Gets and Sets truckBedLength
        Public Property theBedLength() As bedLength
            Get
                Return truckBedLength
            End Get
            Set(value As bedLength)
                If value >= 0 And value <= 2 Then
                    truckBedLength = value
                End If
            End Set
        End Property

        'Gets and Sets truckCabLength
        Public Property theCabLength() As cabLength
            Get
                Return truckCabLength
            End Get
            Set(value As cabLength)
                If value >= 0 And value <= 2 Then
                    truckCabLength = value
                End If
            End Set
        End Property
    End Class

    'BedLength Enumeration: short medium long
    Enum bedLength As Integer
        ShortBed = 0
        MediumBed = 1
        LongBed = 2
    End Enum

    'CabLength Enumeration: 
    Enum cabLength
        singleCab = 0
        extendedCab = 1
        crewMax = 2
    End Enum
End Namespace