Module Module1


    Public Const camion = 50
    Public Const moto = 15
    Public Const impuestodoc = 0.015
    Public Const impuestoropa = 0.6
    Public Const impuestopere = 0.55
    Public Const impuestoplas = 0.45
    Public Const impuestolociones = 0.02


    Public Nombre(10)
    Public Nombredelpaquete(10)
    Public valordelpaquete(10)
    Public pagoparcial(10)
    Public valorimpuesto(10)
    Public pagototal(10)
    Public contador


    Dim impuestobasedoc = 0
    Dim impuestobaseropa = 0
    Dim impuestobasepede = 0
    Dim impuestobaseplas = 0
    Dim impuestobaseloc = 0



    Sub Limpiar()

        Form1.TextBoxNOMBRE.Clear()
        Form1.TextBoxPESO.Clear()
        Form1.TextBoxVALOR.Clear()

    End Sub

    Function calcularimpuestodoc(base As Double) As Double
        impuestobasedoc = (base * 0.015)
        Return Math.Round(impuestobasedoc, 2)
    End Function

    Function calcularimpuestoropa(base As Double) As Double
        impuestobaseropa = (base * 0.06)
        Return Math.Round(impuestobaseropa, 2)
    End Function

    Function calcularimpuestopede(base As Double) As Double
        impuestobasepede = (base * 0.055)
        Return Math.Round(impuestobasepede, 2)
    End Function

    Function calcularimpuestoplas(base As Double) As Double
        impuestobaseplas = (base * 0.045)
        Return Math.Round(impuestobaseplas, 2)
    End Function

    Function calcularimpuestoloc(base As Double) As Double
        impuestobaseloc = (base * 0.02)
        Return Math.Round(impuestobaseloc, 2)
    End Function


End Module
