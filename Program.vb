Imports System

Module Program
    Sub Main(args As String())
        Dim hoge As String = GetHoge()
        Console.WriteLine("Hello World!:" & hoge)
    End Sub

    Function GetHoge() As String
        Return "HogeHoge"
    End Function
    
End Module
