Module Module1

    Sub Main()
        '1.Деклариране на променливи и константи
        Dim V1, T1, V2, T2, V, T As Single
        '2.Входни данни
        Console.Write("Vuvedete V1")
        V1 = Console.ReadLine()
        Console.Write("Vuvedete T1")
        T1 = Console.ReadLine()
        Console.Write("Vuvedete V2")
        V2 = Console.ReadLine()
        Console.Write("Vuvedete T2")
        T2 = Console.ReadLine()
        '3.Изчислителна част
        V = V1 + V2
        T = (V1 * T1 + V2 * T2) / V
        '4.Извеждане на резултати
        Console.WriteLine("Noviq obem V = " & V)
        Console.WriteLine("Novata plutnost T = " & T)
        Console.ReadKey()


    End Sub

End Module
