Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim n1, n2, total As Decimal

        '--Inputs
        n1 = txtInput1.Text()
        n2 = txtInput2.Text()

        '--Process
        total = n1 + n2

        '--Ouput
        txtAns.Text() = total

    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim n1, n2, total As Decimal

        '--Inputs
        n1 = txtInput1.Text()
        n2 = txtInput2.Text()

        '--Process
        total = n1 - n2

        '--Ouput
        txtAns.Text() = total

    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        Dim n1, n2, total As Decimal

        '--Inputs
        n1 = txtInput1.Text()
        n2 = txtInput2.Text()

        '--Process
        total = n1 * n2

        '--Ouput
        txtAns.Text() = total

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtInput1.Clear()
        txtInput2.Clear()
        txtAns.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click

        btnAdd_Click(sender, e)
        btnSub_Click(sender, e)
        btnMulti_Click(sender, e)

    End Sub
End Class
