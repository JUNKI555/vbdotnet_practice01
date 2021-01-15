Imports System

Module Program
    Sub Main(args As String())
        Dim hoge As String = GetHoge()
        Dim fuga As String = GetFuga(10)
        Console.WriteLine("Hello World!:" & hoge & ":" & fuga)
    End Sub

    Function GetHoge() As String
        Return "HogeHoge"
    End Function

    Function GetFuga(ByVal y As Integer) As String
        Dim x As Integer = 13
        Dim fuga As String = "Fuga"

        if x > 10 Then
            fuga = "Fuga x > 10"
        End If

        if x < 10 Then
            fuga = "Fuga x < 10"
        End If

        if x > 10 Then
            fuga = "Fuga x > 10"
        Elseif x = 13 Then
            fuga = "Fuga x = 10"
        Else
            fuga = "Fuga x < 10"
        End If

        Console.WriteLine(fuga)

        Return fuga
    End Function
    

End Module
