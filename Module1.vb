Module Module1

    Sub Main()
        '1.Деклариране на променливи и константи
        Dim R As Double, S As Double, P As Double
        Const Pi As Double = 3.14159
        '2.Входни данни
        Console.Write("Vuvedete radius na kruga")
        R = Console.ReadLine()
        '3.Изчиислителна част
        'Лице
        S = Pi * R ^ 2
        'Периметър
        P = 2 * Pi * R
        '4.Извеждане на резултата
        Console.WriteLine("Liceto S =" & S)
        Console.WriteLine("perimetura p =" & P)
        Console.ReadKey()

    End Sub

End Module
