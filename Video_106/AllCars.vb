Namespace AllCars
    Class Car
        'Public and Private Fields
        Public color As String
        Public carName As String
        Private intSpeed As Integer

        'Gets speed
        Public ReadOnly Property Speed() As Integer
            Get
                Return intSpeed
            End Get
        End Property

        'Accelerates the car
        Public Sub Accelerate(ByVal accelerateBy As Integer)
            intSpeed += accelerateBy
        End Sub

        'Overwrite ToString
        Public Overrides Function ToString() As String
            Return "Car name: " & carName & Environment.NewLine & "Car color: " & color & Environment.NewLine & "Car speed: " & intSpeed
        End Function

    End Class
End Namespace