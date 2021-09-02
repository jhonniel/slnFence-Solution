' Name:         Fence Project
' Purpose:      to calculate total cost for installing a fence
' Programmer:   <Jhonniel Ygay> on <Sep 25,2020>


Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim dblLength As Double

        Dim dblWidth As Double

        Dim dblRate As Double

        Dim dblPerimeter As Double

        Double.TryParse(txtLength.Text, dblLength)

        Double.TryParse(txtWidth.Text, dblWidth)

        Double.TryParse(txtCost.Text, dblRate)


        Dim rect As New Rectangle(dblLength, dblWidth)

        dblPerimeter = rect.GetPerimeter()


        lblTotal.Text = (dblRate * dblPerimeter).ToString("C2")

        txtLength.Focus()

        txtLength.SelectAll()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
