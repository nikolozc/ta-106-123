Namespace AllCars
    Class Car
        Implements IDisposable

        'Public and Private Fields
        Public color As String
        Public carName As String
        Private intSpeed As Integer
        Private intNumberOfDoors As Integer
        Private intHorsePower As Integer
        Private disposedValue As Boolean

        'Constructor
        Sub New()
            color = "Red"
            intSpeed = 0
            intNumberOfDoors = 5
            intHorsePower = 250
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

        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    ' TODO: dispose managed state (managed objects)
                End If

                ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
                ' TODO: set large fields to null
                disposedValue = True
            End If
        End Sub

        ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
        ' Protected Overrides Sub Finalize()
        '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
        '     Dispose(disposing:=False)
        '     MyBase.Finalize()
        ' End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
            Dispose(disposing:=True)
            GC.SuppressFinalize(Me)
        End Sub
    End Class

    Class SportsCar
        Inherits Car

        Public weight As Integer

        Sub New()
            color = "Red"
            numberOfDoors = 2
            weight = 1000
        End Sub

        Public Function getSportsInfo() As String
            Return "Car name: " & carName & Environment.NewLine & "Car color: " & color & Environment.NewLine & "Number of doors" & numberOfDoors & Environment.NewLine & "Car speed: " & Speed & Environment.NewLine & "Horsepower: " & HorsePower & Environment.NewLine & "Weight: " & weight
        End Function

        'Get Power to Weight Ratio
        Public Function getPowerToWeightRatio() As Double
            Return HorsePower / weight
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

        'Gives the information about the truck
        Public Function getTruckInfo() As String
            Return "Car name: " & carName & Environment.NewLine & "Car color: " & color & Environment.NewLine & "Number of doors" & numberOfDoors & Environment.NewLine & "Car speed: " & Speed & Environment.NewLine & "Cab Size: " & truckCabLength & Environment.NewLine & "Bed Length: " & truckBedLength
        End Function
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