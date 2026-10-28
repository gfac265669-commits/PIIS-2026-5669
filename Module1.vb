Module Module1

    Sub Main()
        Dim m%, n%, i%, S#
        Console.Write("vuvedete m")
        m = Console.ReadLine()


        Console.Write("vuvedete n")
        n = Console.ReadLine()
        Console.Write("vuvedete e")
        i = Console.ReadLine()
        Console.Write("vuvedete s")
        s = Console.ReadLine()
        For i = m To n
            s = s + Math.Sqrt(i)

        Next
    End Sub

End Module
