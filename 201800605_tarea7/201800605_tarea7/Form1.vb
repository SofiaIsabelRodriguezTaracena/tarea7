Public Class Form1
    Private Sub ButtonSALIR_Click(sender As Object, e As EventArgs) Handles ButtonSALIR.Click
        If MsgBox("¿DESEA SALIR?", vbYesNo) = vbYes Then
            End
        End If
    End Sub

    Private Sub ButtonCALCULAR_Click(sender As Object, e As EventArgs) Handles ButtonCALCULAR.Click

        If ComboBox1.SelectedIndex = -1 Or ComboBoxcomo.SelectedIndex = -1 Then
            MsgBox(" Seleccione todos los campos por favor")
            Exit Sub
        End If

        If contador < 10 Then

            Nombre(contador) = TextBoxNOMBRE.Text
            Nombredelpaquete(contador) = ComboBox1.SelectedItem
            valordelpaquete(contador) = TextBoxVALOR.Text
            pagoparcial(contador) = pagoparcial
            valorimpuesto(contador) = valorimpuesto
            pagototal(contador) = pagototal

            Select Case Nombredelpaquete(contador)
                Case "Documentos"
                    Select Case Nombredelpaquete(contador)
                        Case "moto"
                            valorimpuesto(contador) = valorimpuesto

                    End Select
            End Select

            ListBox1.Items.Add(Nombre(contador))
            ListBox2.Items.Add(Nombredelpaquete(contador))
            ListBox3.Items.Add(valordelpaquete(contador))

            ListBox4.Items.Add(pagoparcial(contador))

            ListBox5.Items.Add(valorimpuesto(contador))
            ListBox6.Items.Add(pagototal(contador))





        Else
            MsgBox("Se llegó al limite perdon :( ")
        End If




    End Sub

    Private Sub ListBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox5.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Limpiar()
    End Sub
End Class
