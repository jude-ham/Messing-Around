﻿Public Class Form1
    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        Dim Hours As Integer
        Dim Rate As Single
        Dim Total As Single

        Hours = Val(txthours.Text)
        Rate = Val(txtrate.Text)

        Total = Hours * Rate

        lbltotal.Text = "£" & Total
    End Sub

    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        Dim Price As Single
        Dim Discount As Boolean
        Dim FinalPrice As Single

        Price = Val(txtprice.Text)
        If CheckBox1.Checked Then
            Discount = True
        Else
            Discount = False
        End If

        If Discount = True Then
            FinalPrice = Price * 0.8
        Else
            FinalPrice = Price
        End If
        lblfinalprice.Text = "£" & FinalPrice
    End Sub

    Private Sub btnfigureout_Click(sender As Object, e As EventArgs) Handles btnfigureout.Click
        Dim Base As Single
        Dim Height As Single
        Dim Area As Single

        Base = Val(txtbase.Text)
        Height = Val(txtheight.Text)

        Area = 0.5 * Base * Height

        lblarea.Text = Area & "cm²"
    End Sub
End Class
