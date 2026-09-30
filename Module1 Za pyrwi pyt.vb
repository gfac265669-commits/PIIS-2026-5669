Module Module1

    Sub Main()
        Dim y#, x#, a#
        Console.Write("Vuvedete stoinost za x:")
        x = Console.ReadLine()
        Console.Write("Vuvedete stoinost za a:")
        a = Console.ReadLine()
        If x > a Then y = (x ^ 2 + 1) / 2 Else y = (x ^ 4 + 1) / 4
        Console.WriteLine("y=" & y)
        Console.ReadKey()
    End Sub

End Module
