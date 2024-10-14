Public Class Form1
    ' 

    ' Ubicación:         NUC University  

    ' Resinto:           Bayamón 

    ' Proyecto Final:    Pizzeria 

    ' Hecho por:         Emmanuel G. Negrón 

    ' NO. ESTUDIANTE:    1908397157 

    ' Curso:             PROG - 2280L 

    ' Fecha:             10/03/2024 

    ' Profesor:          Milton Rojas 

    ' Narrativa:         PGM DE PIZZERIA



    Dim QTY As Integer = 0
    Dim itemlist As Integer = 0
    Const taxEstatal As Double = 0.07
    Public totalnet, totaltax, totalall, itemprice, totalsale As Double




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buttonsalida.Click
        End
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim checknum As Integer = CInt(Int((9999 * Rnd()) + 1000))
        Dim server As String = "NUC"

        RichTextBoxCHECKNUM.Text = checknum
        RichTextBoxserver.Text = server
        RichTextBoxdate.Text = TimeOfDay


        RichTextBoxQTY1.Text = ""
        RichTextBoxITEM1.Text = ""
        RichTextBoxPRICE1.Text = ""

        RichTextBoxQTY2.Text = ""
        RichTextBoxITEM2.Text = ""
        RichTextBoxPRICE2.Text = ""

        RichTextBoxQTY3.Text = ""
        RichTextBoxITEM3.Text = ""
        RichTextBoxPRICE3.Text = ""

        RichTextBoxQTY4.Text = ""
        RichTextBoxITEM4.Text = ""
        RichTextBoxPRICE4.Text = ""

        RichTextBoxQTY5.Text = ""
        RichTextBoxITEM5.Text = ""
        RichTextBoxPRICE5.Text = ""

        RichTextBoxQTY6.Text = ""
        RichTextBoxITEM6.Text = ""
        RichTextBoxPRICE6.Text = ""

        RichTextBoxtax.Text = ""
        RichTextBoxtotal.Text = ""

        totalsale = totalall + totalsale

        itemlist = 0
        totalnet = 0
        totaltax = 0
        totalall = 0

    End Sub




    'PIZZA MENU OPTIONS: 
    Private Sub ButtonPIZZA_Click(sender As Object, e As EventArgs) Handles ButtonPIZZA.Click
        itemlist = itemlist + 1



        'SMALL PIZZAS ==============================================================================


        'ITEM 1 SMALL
        If (RadioButtonsmall.Checked And itemlist = 1) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Pepperoni Pizza small"
                RichTextBoxPRICE1.Text = FormatCurrency("9.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Ham Pizza small"
                RichTextBoxPRICE1.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Chorizo Pizza small"
                RichTextBoxPRICE1.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Veggie Pizza small"
                RichTextBoxPRICE1.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Meat Pizza small"
                RichTextBoxPRICE1.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)

                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Sausage Pizza small"
                RichTextBoxPRICE1.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If




        'ITEM 2 SMALL

        If (RadioButtonsmall.Checked And itemlist = 2) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Pepperoni Pizza small"
                RichTextBoxPRICE2.Text = FormatCurrency("9.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)


                'Calculation

                ' Calculation
                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Ham Pizza small"
                RichTextBoxPRICE2.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Chorizo Pizza small"
                RichTextBoxPRICE2.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Veggie Pizza small"
                RichTextBoxPRICE2.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Meat Pizza small"
                RichTextBoxPRICE2.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Sausage Pizza small"
                RichTextBoxPRICE2.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If




        'ITEM 3 SMALL

        If (RadioButtonsmall.Checked And itemlist = 3) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Pepperoni Pizza small"
                RichTextBoxPRICE3.Text = FormatCurrency("9.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)


                'Calculation

                ' Calculation
                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Ham Pizza small"
                RichTextBoxPRICE3.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Chorizo Pizza small"
                RichTextBoxPRICE3.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Veggie Pizza small"
                RichTextBoxPRICE3.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Meat Pizza small"
                RichTextBoxPRICE3.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Sausage Pizza small"
                RichTextBoxPRICE3.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If



        'ITEM 4 SMALL


        If (RadioButtonsmall.Checked And itemlist = 4) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Pepperoni Pizza small"
                RichTextBoxPRICE4.Text = FormatCurrency("9.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Ham Pizza small"
                RichTextBoxPRICE4.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Chorizo Pizza small"
                RichTextBoxPRICE4.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Veggie Pizza small"
                RichTextBoxPRICE4.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Meat Pizza small"
                RichTextBoxPRICE4.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Sausage Pizza small"
                RichTextBoxPRICE4.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'ITEM 5 SMALL

        If (RadioButtonsmall.Checked And itemlist = 5) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Pepperoni Pizza small"
                RichTextBoxPRICE5.Text = FormatCurrency("9.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Ham Pizza small"
                RichTextBoxPRICE5.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Chorizo Pizza small"
                RichTextBoxPRICE5.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Veggie Pizza small"
                RichTextBoxPRICE5.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Meat Pizza small"
                RichTextBoxPRICE5.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Sausage Pizza small"
                RichTextBoxPRICE5.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'ITEM 6 SMALL

        If (RadioButtonsmall.Checked And itemlist = 6) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Pepperoni Pizza small"
                RichTextBoxPRICE6.Text = FormatCurrency("9.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Ham Pizza small"
                RichTextBoxPRICE6.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Chorizo Pizza small"
                RichTextBoxPRICE6.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Veggie Pizza small"
                RichTextBoxPRICE6.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Meat Pizza small"
                RichTextBoxPRICE6.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Sausage Pizza small"
                RichTextBoxPRICE6.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'END SMALL PIZZA ==============================================================================


        'MEDIUM PIZZA ==============================================================================

        'ITEM 1 Medium
        If (RadioButtonmedium.Checked And itemlist = 1) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Pepperoni Pizza Medium"
                RichTextBoxPRICE1.Text = FormatCurrency("10.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall)

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Ham Pizza Medium"
                RichTextBoxPRICE1.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Chorizo Pizza Medium"
                RichTextBoxPRICE1.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Veggie Pizza Medium"
                RichTextBoxPRICE1.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Meat Pizza Medium"
                RichTextBoxPRICE1.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)

                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Sausage Pizza Medium"
                RichTextBoxPRICE1.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If




        'ITEM 2 medium

        If (RadioButtonmedium.Checked And itemlist = 2) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Pepperoni Pizza Medium"
                RichTextBoxPRICE2.Text = FormatCurrency("10.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)


                'Calculation

                ' Calculation
                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Ham Pizza Medium"
                RichTextBoxPRICE2.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Chorizo Pizza Medium"
                RichTextBoxPRICE2.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Veggie Pizza Medium"
                RichTextBoxPRICE2.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Meat Pizza Medium"
                RichTextBoxPRICE2.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Sausage Pizza Medium"
                RichTextBoxPRICE2.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If




        'ITEM 3 MEDIUM

        If (RadioButtonmedium.Checked And itemlist = 3) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Pepperoni Pizza Medium"
                RichTextBoxPRICE3.Text = FormatCurrency("10.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)


                'Calculation

                ' Calculation
                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Ham Pizza Medium"
                RichTextBoxPRICE3.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Chorizo Pizza Medium"
                RichTextBoxPRICE3.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Veggie Pizza Medium"
                RichTextBoxPRICE3.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Meat Pizza Medium"
                RichTextBoxPRICE3.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Sausage Pizza Medium"
                RichTextBoxPRICE3.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If



        'ITEM 4 MEDIUM


        If (RadioButtonmedium.Checked And itemlist = 4) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Pepperoni Pizza Medium"
                RichTextBoxPRICE4.Text = FormatCurrency("10.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Ham Pizza Medium"
                RichTextBoxPRICE4.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Chorizo Pizza Medium"
                RichTextBoxPRICE4.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Veggie Pizza Medium"
                RichTextBoxPRICE4.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Meat Pizza Medium"
                RichTextBoxPRICE4.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Sausage Pizza Medium"
                RichTextBoxPRICE4.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'ITEM 5 MEDIUM

        If (RadioButtonmedium.Checked And itemlist = 5) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Pepperoni Pizza Medium"
                RichTextBoxPRICE5.Text = FormatCurrency("10.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Ham Pizza Medium"
                RichTextBoxPRICE5.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Chorizo Pizza Medium"
                RichTextBoxPRICE5.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Veggie Pizza Medium"
                RichTextBoxPRICE5.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Meat Pizza Medium"
                RichTextBoxPRICE5.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Sausage Pizza Medium"
                RichTextBoxPRICE5.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'ITEM 6 MEDIUM

        If (RadioButtonmedium.Checked And itemlist = 6) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Pepperoni Pizza Medium"
                RichTextBoxPRICE6.Text = FormatCurrency("10.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Ham Pizza Medium"
                RichTextBoxPRICE6.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Chorizo Pizza Medium"
                RichTextBoxPRICE6.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Veggie Pizza Medium"
                RichTextBoxPRICE6.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Meat Pizza Medium"
                RichTextBoxPRICE6.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Sausage Pizza Medium"
                RichTextBoxPRICE6.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If





        'Large PIZZA ==============================================================================

        'ITEM 1 Large
        If (RadioButtonlarge.Checked And itemlist = 1) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Pepperoni Pizza Large"
                RichTextBoxPRICE1.Text = FormatCurrency("12.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Ham Pizza Large"
                RichTextBoxPRICE1.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Chorizo Pizza Large"
                RichTextBoxPRICE1.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Veggie Pizza Large"
                RichTextBoxPRICE1.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Meat Pizza Large"
                RichTextBoxPRICE1.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)

                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Sausage Pizza Large"
                RichTextBoxPRICE1.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If




        'ITEM 2 large

        If (RadioButtonlarge.Checked And itemlist = 2) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Pepperoni Pizza Large"
                RichTextBoxPRICE2.Text = FormatCurrency("12.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)


                'Calculation

                ' Calculation
                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Ham Pizza Large"
                RichTextBoxPRICE2.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Chorizo Pizza Large"
                RichTextBoxPRICE2.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Veggie Pizza Large"
                RichTextBoxPRICE2.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Meat Pizza Large"
                RichTextBoxPRICE2.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Sausage Pizza Large"
                RichTextBoxPRICE2.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If




        'ITEM 3 large

        If (RadioButtonlarge.Checked And itemlist = 3) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Pepperoni Pizza Large"
                RichTextBoxPRICE3.Text = FormatCurrency("12.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)


                'Calculation

                ' Calculation
                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Ham Pizza Large"
                RichTextBoxPRICE3.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Chorizo Pizza Large"
                RichTextBoxPRICE3.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Veggie Pizza Large"
                RichTextBoxPRICE3.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Meat Pizza Large"
                RichTextBoxPRICE3.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Sausage Pizza Large"
                RichTextBoxPRICE3.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If



        'ITEM 4 large


        If (RadioButtonlarge.Checked And itemlist = 4) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Pepperoni Pizza Large"
                RichTextBoxPRICE4.Text = FormatCurrency("12.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Ham Pizza Large"
                RichTextBoxPRICE4.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Chorizo Pizza Large"
                RichTextBoxPRICE4.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Veggie Pizza Large"
                RichTextBoxPRICE4.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Meat Pizza Large"
                RichTextBoxPRICE4.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Sausage Pizza Large"
                RichTextBoxPRICE4.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'ITEM 5 Large

        If (RadioButtonlarge.Checked And itemlist = 5) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Pepperoni Pizza Large"
                RichTextBoxPRICE5.Text = FormatCurrency("12.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Ham Pizza Large"
                RichTextBoxPRICE5.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Chorizo Pizza Large"
                RichTextBoxPRICE5.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Veggie Pizza Large"
                RichTextBoxPRICE5.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Meat Pizza Large"
                RichTextBoxPRICE5.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Sausage Pizza Large"
                RichTextBoxPRICE5.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'ITEM 6 LARGE

        If (RadioButtonlarge.Checked And itemlist = 6) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Pepperoni Pizza Large"
                RichTextBoxPRICE6.Text = FormatCurrency("12.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Ham Pizza Large"
                RichTextBoxPRICE6.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Chorizo Pizza Large"
                RichTextBoxPRICE6.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Veggie Pizza Large"
                RichTextBoxPRICE6.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Meat Pizza Large"
                RichTextBoxPRICE6.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Sausage Pizza Large"
                RichTextBoxPRICE6.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'END LARGE PIZZA ==============================================================================


        'XTLarge PIZZA ==============================================================================

        'ITEM 1 XTLarge
        If (RadioButtonxllarge.Checked And itemlist = 1) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Pepperoni Pizza XTLarge"
                RichTextBoxPRICE1.Text = FormatCurrency("15.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Ham Pizza XTLarge"
                RichTextBoxPRICE1.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Chorizo Pizza XTLarge"
                RichTextBoxPRICE1.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Veggie Pizza XTLarge"
                RichTextBoxPRICE1.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Meat Pizza XTLarge"
                RichTextBoxPRICE1.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)

                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Sausage Pizza XTLarge"
                RichTextBoxPRICE1.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If




        'ITEM 2 XTlarge

        If (RadioButtonxllarge.Checked And itemlist = 2) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Pepperoni Pizza XTLarge"
                RichTextBoxPRICE2.Text = FormatCurrency("15.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)


                'Calculation

                ' Calculation
                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Ham Pizza XTLarge"
                RichTextBoxPRICE2.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Chorizo Pizza XTLarge"
                RichTextBoxPRICE2.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Veggie Pizza XTLarge"
                RichTextBoxPRICE2.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Meat Pizza XTLarge"
                RichTextBoxPRICE2.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Sausage Pizza XTLarge"
                RichTextBoxPRICE2.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If




        'ITEM 3 XTlarge

        If (RadioButtonxllarge.Checked And itemlist = 3) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Pepperoni Pizza XTLarge"
                RichTextBoxPRICE3.Text = FormatCurrency("15.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)


                'Calculation

                ' Calculation
                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Ham Pizza XTLarge"
                RichTextBoxPRICE3.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Chorizo Pizza XTLarge"
                RichTextBoxPRICE3.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Veggie Pizza XTLarge"
                RichTextBoxPRICE3.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Meat Pizza XTLarge"
                RichTextBoxPRICE3.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Sausage Pizza XTLarge"
                RichTextBoxPRICE3.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If



        'ITEM 4 XTlarge


        If (RadioButtonxllarge.Checked And itemlist = 4) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Pepperoni Pizza XTLarge"
                RichTextBoxPRICE4.Text = FormatCurrency("15.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Ham Pizza XTLarge"
                RichTextBoxPRICE4.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Chorizo Pizza XTLarge"
                RichTextBoxPRICE4.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Veggie Pizza XTLarge"
                RichTextBoxPRICE4.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Meat Pizza XTLarge"
                RichTextBoxPRICE4.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Sausage Pizza XTLarge"
                RichTextBoxPRICE4.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'ITEM 5 XTLarge

        If (RadioButtonxllarge.Checked And itemlist = 5) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Pepperoni Pizza XTLarge"
                RichTextBoxPRICE5.Text = FormatCurrency("15.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Ham Pizza XTLarge"
                RichTextBoxPRICE5.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Chorizo Pizza XTLarge"
                RichTextBoxPRICE5.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Veggie Pizza XTLarge"
                RichTextBoxPRICE5.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Meat Pizza XTLarge"
                RichTextBoxPRICE5.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Sausage Pizza XTLarge"
                RichTextBoxPRICE5.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'ITEM 6 XTLARGE

        If (RadioButtonxllarge.Checked And itemlist = 6) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Pepperoni Pizza XTLarge"
                RichTextBoxPRICE6.Text = FormatCurrency("15.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Ham Pizza XTLarge"
                RichTextBoxPRICE6.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Chorizo Pizza XTLarge"
                RichTextBoxPRICE6.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Veggie Pizza XTLarge"
                RichTextBoxPRICE6.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Meat Pizza XTLarge"
                RichTextBoxPRICE6.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Sausage Pizza XTLarge"
                RichTextBoxPRICE6.Text = FormatCurrency("15.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'END XTLARGE PIZZA ==============================================================================


        'Sportman PIZZA ==============================================================================

        'ITEM 1 Sportman
        If (RadioButtonsportman.Checked And itemlist = 1) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Pepperoni Pizza Sportman"
                RichTextBoxPRICE1.Text = FormatCurrency("20.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Ham Pizza Sportman"
                RichTextBoxPRICE1.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Chorizo Pizza Sportman"
                RichTextBoxPRICE1.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Veggie Pizza Sportman"
                RichTextBoxPRICE1.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Meat Pizza Sportman"
                RichTextBoxPRICE1.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)

                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Sausage Pizza Sportman"
                RichTextBoxPRICE1.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If




        'ITEM 2 Sportman

        If (RadioButtonsportman.Checked And itemlist = 2) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Pepperoni Pizza Sportman"
                RichTextBoxPRICE2.Text = FormatCurrency("20.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)


                'Calculation

                ' Calculation
                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Ham Pizza Sportman"
                RichTextBoxPRICE2.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Chorizo Pizza Sportman"
                RichTextBoxPRICE2.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Veggie Pizza Sportman"
                RichTextBoxPRICE2.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Meat Pizza Sportman"
                RichTextBoxPRICE2.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Sausage Pizza Sportman"
                RichTextBoxPRICE2.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If




        'ITEM 3 Sportman

        If (RadioButtonsportman.Checked And itemlist = 3) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Pepperoni Pizza Sportman"
                RichTextBoxPRICE3.Text = FormatCurrency("20.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)


                'Calculation

                ' Calculation
                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Ham Pizza Sportman"
                RichTextBoxPRICE3.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Chorizo Pizza Sportman"
                RichTextBoxPRICE3.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Veggie Pizza Sportman"
                RichTextBoxPRICE3.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Meat Pizza Sportman"
                RichTextBoxPRICE3.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Sausage Pizza Sportman"
                RichTextBoxPRICE3.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If



        'ITEM 4 Sportman


        If (RadioButtonsportman.Checked And itemlist = 4) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Pepperoni Pizza Sportman"
                RichTextBoxPRICE4.Text = FormatCurrency("20.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Ham Pizza Sportman"
                RichTextBoxPRICE4.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Chorizo Pizza Sportman"
                RichTextBoxPRICE4.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Veggie Pizza Sportman"
                RichTextBoxPRICE4.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Meat Pizza Sportman"
                RichTextBoxPRICE4.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Sausage Pizza Sportman"
                RichTextBoxPRICE4.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'ITEM 5 Sportman

        If (RadioButtonsportman.Checked And itemlist = 5) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Pepperoni Pizza Sportman"
                RichTextBoxPRICE5.Text = FormatCurrency("20.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Ham Pizza Sportman"
                RichTextBoxPRICE5.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Chorizo Pizza Sportman"
                RichTextBoxPRICE5.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Veggie Pizza Sportman"
                RichTextBoxPRICE5.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Meat Pizza Sportman"
                RichTextBoxPRICE5.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Sausage Pizza Sportman"
                RichTextBoxPRICE5.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'ITEM 6 Sportman

        If (RadioButtonsportman.Checked And itemlist = 6) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Pepperoni Pizza Sportman"
                RichTextBoxPRICE6.Text = FormatCurrency("20.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Ham Pizza Sportman"
                RichTextBoxPRICE6.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Chorizo Pizza Sportman"
                RichTextBoxPRICE6.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Veggie Pizza Sportman"
                RichTextBoxPRICE6.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Meat Pizza Sportman"
                RichTextBoxPRICE6.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Sausage Pizza Sportman"
                RichTextBoxPRICE6.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'END sportman PIZZA ==============================================================================


        'Superman PIZZA ==============================================================================

        'ITEM 1 Sportman
        If (RadioButtonsuperman.Checked And itemlist = 1) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Pepperoni Pizza Superman"
                RichTextBoxPRICE1.Text = FormatCurrency("39.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Ham Pizza Superman"
                RichTextBoxPRICE1.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Chorizo Pizza Superman"
                RichTextBoxPRICE1.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Veggie Pizza Superman"
                RichTextBoxPRICE1.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Meat Pizza Superman"
                RichTextBoxPRICE1.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)

                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtypizza.Text
                RichTextBoxITEM1.Text = "Sausage Pizza Superman"
                RichTextBoxPRICE1.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If




        'ITEM 2 Superman

        If (RadioButtonsuperman.Checked And itemlist = 2) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Pepperoni Pizza Superman"
                RichTextBoxPRICE2.Text = FormatCurrency("39.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)


                'Calculation

                ' Calculation
                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Ham Pizza Superman"
                RichTextBoxPRICE2.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Chorizo Pizza Superman"
                RichTextBoxPRICE2.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Veggie Pizza Superman"
                RichTextBoxPRICE2.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Meat Pizza Superman"
                RichTextBoxPRICE2.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtypizza.Text
                RichTextBoxITEM2.Text = "Sausage Pizza Superman"
                RichTextBoxPRICE2.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If




        'ITEM 3 Superman

        If (RadioButtonsuperman.Checked And itemlist = 3) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Pepperoni Pizza Superman"
                RichTextBoxPRICE3.Text = FormatCurrency("39.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)


                'Calculation

                ' Calculation
                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Ham Pizza Superman"
                RichTextBoxPRICE3.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Chorizo Pizza Superman"
                RichTextBoxPRICE3.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Veggie Pizza Superman"
                RichTextBoxPRICE3.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Meat Pizza Superman"
                RichTextBoxPRICE3.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtypizza.Text
                RichTextBoxITEM3.Text = "Sausage Pizza Superman"
                RichTextBoxPRICE3.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If



        'ITEM 4 Superman


        If (RadioButtonsuperman.Checked And itemlist = 4) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Pepperoni Pizza Superman"
                RichTextBoxPRICE4.Text = FormatCurrency("39.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Ham Pizza Superman"
                RichTextBoxPRICE4.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Chorizo Pizza Superman"
                RichTextBoxPRICE4.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Veggie Pizza Superman"
                RichTextBoxPRICE4.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Meat Pizza Superman"
                RichTextBoxPRICE4.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY4.Text = TextBoxqtypizza.Text
                RichTextBoxITEM4.Text = "Sausage Pizza Superman"
                RichTextBoxPRICE4.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE4.Text)
                QTY = CInt(RichTextBoxQTY4.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'ITEM 5 Superman

        If (RadioButtonsuperman.Checked And itemlist = 5) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Pepperoni Pizza Superman"
                RichTextBoxPRICE5.Text = FormatCurrency("39.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Ham Pizza Superman"
                RichTextBoxPRICE5.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Chorizo Pizza Superman"
                RichTextBoxPRICE5.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Veggie Pizza Superman"
                RichTextBoxPRICE5.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Meat Pizza Superman"
                RichTextBoxPRICE5.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY5.Text = TextBoxqtypizza.Text
                RichTextBoxITEM5.Text = "Sausage Pizza Superman"
                RichTextBoxPRICE5.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE5.Text)
                QTY = CInt(RichTextBoxQTY5.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'ITEM 6 Superman

        If (RadioButtonsuperman.Checked And itemlist = 6) Then


            If (RadioButtonpepperoni.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Pepperoni Pizza Superman"
                RichTextBoxPRICE6.Text = FormatCurrency("39.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)




            ElseIf (RadioButtonham.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Ham Pizza Superman"
                RichTextBoxPRICE6.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonchorizo.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Chorizo Pizza Superman"
                RichTextBoxPRICE6.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonveggies.Checked) Then


                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Veggie Pizza Superman"
                RichTextBoxPRICE6.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmeat.Checked) Then


                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Meat Pizza Superman"
                RichTextBoxPRICE6.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsausage.Checked) Then

                RichTextBoxQTY6.Text = TextBoxqtypizza.Text
                RichTextBoxITEM6.Text = "Sausage Pizza Superman"
                RichTextBoxPRICE6.Text = FormatCurrency("39.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE6.Text)
                QTY = CInt(RichTextBoxQTY6.Text)


                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'END superman PIZZA ==============================================================================
    End Sub

    Private Sub ButtonSIDES_Click(sender As Object, e As EventArgs) Handles ButtonSIDES.Click
        itemlist = itemlist + 1


        'ITEM 1 
        If (itemlist = 1) Then


            If (RadioButtonmozzarella.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtyside.Text
                RichTextBoxITEM1.Text = "Mozzarella Sticks"
                RichTextBoxPRICE1.Text = FormatCurrency("9.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtongarlicb.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtyside.Text
                RichTextBoxITEM1.Text = "Garlic bread"
                RichTextBoxPRICE1.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonempanada.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtyside.Text
                RichTextBoxITEM1.Text = "Empanadas"
                RichTextBoxPRICE1.Text = FormatCurrency("11.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonwings.Checked) Then


                RichTextBoxQTY1.Text = TextBoxqtyside.Text
                RichTextBoxITEM1.Text = "Wings"
                RichTextBoxPRICE1.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonhwings.Checked) Then


                RichTextBoxQTY1.Text = TextBoxqtyside.Text
                RichTextBoxITEM1.Text = "Hot wings"
                RichTextBoxPRICE1.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)

                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsampler.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtyside.Text
                RichTextBoxITEM1.Text = "Sampler"
                RichTextBoxPRICE1.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'ITEM 2 
        If (itemlist = 2) Then


            If (RadioButtonmozzarella.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtyside.Text
                RichTextBoxITEM2.Text = "Mozzarella Sticks"
                RichTextBoxPRICE2.Text = FormatCurrency("9.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtongarlicb.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtyside.Text
                RichTextBoxITEM2.Text = "Garlic bread"
                RichTextBoxPRICE2.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonempanada.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtyside.Text
                RichTextBoxITEM2.Text = "Empanadas"
                RichTextBoxPRICE2.Text = FormatCurrency("11.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonwings.Checked) Then


                RichTextBoxQTY2.Text = TextBoxqtyside.Text
                RichTextBoxITEM2.Text = "Wings"
                RichTextBoxPRICE2.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonhwings.Checked) Then


                RichTextBoxQTY2.Text = TextBoxqtyside.Text
                RichTextBoxITEM2.Text = "Hot wings"
                RichTextBoxPRICE2.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsampler.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtyside.Text
                RichTextBoxITEM2.Text = "Sampler"
                RichTextBoxPRICE2.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'ITEM 3 
        If (itemlist = 3) Then


            If (RadioButtonmozzarella.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtyside.Text
                RichTextBoxITEM3.Text = "Mozzarella Sticks"
                RichTextBoxPRICE3.Text = FormatCurrency("9.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtongarlicb.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtyside.Text
                RichTextBoxITEM3.Text = "Garlic bread"
                RichTextBoxPRICE3.Text = FormatCurrency("10.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonempanada.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtyside.Text
                RichTextBoxITEM3.Text = "Empanadas"
                RichTextBoxPRICE3.Text = FormatCurrency("11.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonwings.Checked) Then


                RichTextBoxQTY3.Text = TextBoxqtyside.Text
                RichTextBoxITEM3.Text = "Wings"
                RichTextBoxPRICE3.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonhwings.Checked) Then


                RichTextBoxQTY3.Text = TextBoxqtyside.Text
                RichTextBoxITEM3.Text = "Hot wings"
                RichTextBoxPRICE3.Text = FormatCurrency("12.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonsampler.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtyside.Text
                RichTextBoxITEM3.Text = "Sampler"
                RichTextBoxPRICE3.Text = FormatCurrency("20.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

    End Sub

    Private Sub ButtonDESSERTS_Click(sender As Object, e As EventArgs) Handles ButtonDESSERTS.Click

        itemlist = itemlist + 1


        'ITEM 1 dessert
        If (itemlist = 1) Then


            If (RadioButtontreslech.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtydessert.Text
                RichTextBoxITEM1.Text = "Tres Leches"
                RichTextBoxPRICE1.Text = FormatCurrency("2.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonvflan.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtydessert.Text
                RichTextBoxITEM1.Text = "Vanilla Flan"
                RichTextBoxPRICE1.Text = FormatCurrency("3.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtoncflan.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtydessert.Text
                RichTextBoxITEM1.Text = "Cheese Flan"
                RichTextBoxPRICE1.Text = FormatCurrency("4.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonccake.Checked) Then


                RichTextBoxQTY1.Text = TextBoxqtydessert.Text
                RichTextBoxITEM1.Text = "Cheesecake"
                RichTextBoxPRICE1.Text = FormatCurrency("5.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonicecream.Checked) Then


                RichTextBoxQTY1.Text = TextBoxqtydessert.Text
                RichTextBoxITEM1.Text = "Ice cream"
                RichTextBoxPRICE1.Text = FormatCurrency("5.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)

                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonicecreamc.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtydessert.Text
                RichTextBoxITEM1.Text = "Ice cream & cake"
                RichTextBoxPRICE1.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'ITEM 2 dessert
        If (itemlist = 2) Then


            If (RadioButtontreslech.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtydessert.Text
                RichTextBoxITEM2.Text = "Tres Leches"
                RichTextBoxPRICE2.Text = FormatCurrency("2.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonvflan.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtydessert.Text
                RichTextBoxITEM2.Text = "Vanilla Flan"
                RichTextBoxPRICE2.Text = FormatCurrency("3.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtoncflan.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtydessert.Text
                RichTextBoxITEM2.Text = "Cheese Flan"
                RichTextBoxPRICE2.Text = FormatCurrency("4.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonccake.Checked) Then


                RichTextBoxQTY2.Text = TextBoxqtydessert.Text
                RichTextBoxITEM2.Text = "Cheesecake"
                RichTextBoxPRICE2.Text = FormatCurrency("5.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonicecream.Checked) Then


                RichTextBoxQTY2.Text = TextBoxqtydessert.Text
                RichTextBoxITEM2.Text = "Ice cream"
                RichTextBoxPRICE2.Text = FormatCurrency("5.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonicecreamc.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtydessert.Text
                RichTextBoxITEM2.Text = "Ice cream & cake"
                RichTextBoxPRICE2.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'ITEM 3 dessert
        If (itemlist = 3) Then


            If (RadioButtontreslech.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtydessert.Text
                RichTextBoxITEM3.Text = "Tres Leches"
                RichTextBoxPRICE3.Text = FormatCurrency("2.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtonvflan.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtydessert.Text
                RichTextBoxITEM3.Text = "Vanilla Flan"
                RichTextBoxPRICE3.Text = FormatCurrency("3.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButtoncflan.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtydessert.Text
                RichTextBoxITEM3.Text = "Cheese Flan"
                RichTextBoxPRICE3.Text = FormatCurrency("4.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonccake.Checked) Then


                RichTextBoxQTY3.Text = TextBoxqtydessert.Text
                RichTextBoxITEM3.Text = "Cheesecake"
                RichTextBoxPRICE3.Text = FormatCurrency("5.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonicecream.Checked) Then


                RichTextBoxQTY3.Text = TextBoxqtydessert.Text
                RichTextBoxITEM3.Text = "Ice cream"
                RichTextBoxPRICE3.Text = FormatCurrency("5.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonicecreamc.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtydessert.Text
                RichTextBoxITEM3.Text = "Ice cream & cake"
                RichTextBoxPRICE3.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

    End Sub



    'drink s
    Private Sub ButtonDRINKS_Click(sender As Object, e As EventArgs) Handles ButtonDRINKS.Click
        itemlist = itemlist + 1

        'ITEM 1 drinks
        If (itemlist = 1) Then


            If (RadioButtonwater.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtydrinks.Text
                RichTextBoxITEM1.Text = "Water bottle"
                RichTextBoxPRICE1.Text = FormatCurrency("1.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButton16oz.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtydrinks.Text
                RichTextBoxITEM1.Text = "16oz drink"
                RichTextBoxPRICE1.Text = FormatCurrency("1.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButton32oz.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtydrinks.Text
                RichTextBoxITEM1.Text = "32oz drink"
                RichTextBoxPRICE1.Text = FormatCurrency("2.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonbeer.Checked) Then


                RichTextBoxQTY1.Text = TextBoxqtydrinks.Text
                RichTextBoxITEM1.Text = "Beer"
                RichTextBoxPRICE1.Text = FormatCurrency("2.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmix8oz.Checked) Then


                RichTextBoxQTY1.Text = TextBoxqtydrinks.Text
                RichTextBoxITEM1.Text = "Mix drink 8oz"
                RichTextBoxPRICE1.Text = FormatCurrency("7.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)

                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmix12oz.Checked) Then

                RichTextBoxQTY1.Text = TextBoxqtydrinks.Text
                RichTextBoxITEM1.Text = "Mix drink 12oz"
                RichTextBoxPRICE1.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE1.Text)
                QTY = CInt(RichTextBoxQTY1.Text)
                'Calculation

                totalnet = (QTY * itemprice)
                totaltax = (taxEstatal * totalnet)
                totalall = (totalnet + totalall) + totaltax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'ITEM 2 drinks
        If (itemlist = 2) Then


            If (RadioButtonwater.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtydrinks.Text
                RichTextBoxITEM2.Text = "Water bottle"
                RichTextBoxPRICE2.Text = FormatCurrency("1.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButton16oz.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtydrinks.Text
                RichTextBoxITEM2.Text = "16oz drink"
                RichTextBoxPRICE2.Text = FormatCurrency("1.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButton32oz.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtydrinks.Text
                RichTextBoxITEM2.Text = "32oz drink"
                RichTextBoxPRICE2.Text = FormatCurrency("2.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonbeer.Checked) Then


                RichTextBoxQTY2.Text = TextBoxqtydrinks.Text
                RichTextBoxITEM2.Text = "Beer"
                RichTextBoxPRICE2.Text = FormatCurrency("2.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmix8oz.Checked) Then


                RichTextBoxQTY2.Text = TextBoxqtydrinks.Text
                RichTextBoxITEM2.Text = "Mix drink 8oz"
                RichTextBoxPRICE2.Text = FormatCurrency("7.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmix12oz.Checked) Then

                RichTextBoxQTY2.Text = TextBoxqtydrinks.Text
                RichTextBoxITEM2.Text = "Mix drink 12oz"
                RichTextBoxPRICE2.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE2.Text)
                QTY = CInt(RichTextBoxQTY2.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If

        'ITEM 3 drinks
        If (itemlist = 3) Then


            If (RadioButtonwater.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtydrinks.Text
                RichTextBoxITEM3.Text = "Water bottle"
                RichTextBoxPRICE3.Text = FormatCurrency("1.99")

                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButton16oz.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtydrinks.Text
                RichTextBoxITEM3.Text = "16oz drink"
                RichTextBoxPRICE3.Text = FormatCurrency("1.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)



            ElseIf (RadioButton32oz.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtydrinks.Text
                RichTextBoxITEM3.Text = "32oz drink"
                RichTextBoxPRICE3.Text = FormatCurrency("2.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonbeer.Checked) Then


                RichTextBoxQTY3.Text = TextBoxqtydrinks.Text
                RichTextBoxITEM3.Text = "Beer"
                RichTextBoxPRICE3.Text = FormatCurrency("2.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmix8oz.Checked) Then


                RichTextBoxQTY3.Text = TextBoxqtydrinks.Text
                RichTextBoxITEM3.Text = "Mix drink 8oz"
                RichTextBoxPRICE3.Text = FormatCurrency("7.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)

                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)

            ElseIf (RadioButtonmix12oz.Checked) Then

                RichTextBoxQTY3.Text = TextBoxqtydrinks.Text
                RichTextBoxITEM3.Text = "Mix drink 12oz"
                RichTextBoxPRICE3.Text = FormatCurrency("9.99")


                'Convertion

                itemprice = CDbl(RichTextBoxPRICE3.Text)
                QTY = CInt(RichTextBoxQTY3.Text)
                'Calculation

                totalnet = totalnet + (QTY * itemprice) ' Accumulate the net price
                totaltax = totaltax + (taxEstatal * (QTY * itemprice)) ' Accumulate the tax
                totalall = totalnet + totaltax ' Grand total after tax

                RichTextBoxtax.Text = FormatCurrency(totaltax)
                RichTextBoxtotal.Text = FormatCurrency(totalall)


            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub
End Class
