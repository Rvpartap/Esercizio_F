Imports System

Module Program
    Sub Main()
        Dim scelta As String = "Si"
        While scelta = "Si" Or scelta = "SI" Or scelta = "si"
            Console.Clear()
            Dim numero As Integer
            Dim pari As String
            Dim dispari As String
            Console.WriteLine("Inserisci un numero: ")
            numero = Console.ReadLine()
            If numero Mod 2 = 0 Then
                Console.WriteLine("Il numero " & numero & " è pari.")
            Else
                Console.WriteLine("Il numero " & numero & " è dispari.")
            End If
            Console.WriteLine("Vuoi Continuare? Si o No?")
            scelta = Console.ReadLine()
        End While
    End Sub
End Module
