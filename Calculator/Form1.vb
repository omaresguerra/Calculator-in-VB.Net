Public Class frmCalculator
    Dim iFirstNumber As Double
    Dim sOperator As String

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        txtNum.Text += "0"
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtNum.Text = ""
        iFirstNumber = 0
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        txtNum.Text += "1"
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        txtNum.Text += "2"

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        iFirstNumber = Val(txtNum.Text)
        sOperator = "+"
        txtNum.Text = ""
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        txtNum.Text += "3"
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        txtNum.Text += "4"
    End Sub
    Private Sub btnPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPeriod.Click
        txtNum.Text += "."
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        txtNum.Text += "5"
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        txtNum.Text += "6"
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        txtNum.Text += "7"
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        txtNum.Text += "8"
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        txtNum.Text += "9"
    End Sub

    Private Sub btnSubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubtract.Click
        iFirstNumber = Val(txtNum.Text)
        sOperator = "-"
        txtNum.Text = ""
    End Sub

    Private Sub btnMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiply.Click
        iFirstNumber = Val(txtNum.Text)
        sOperator = "*"
        txtNum.Text = ""
    End Sub

    Private Sub btnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivide.Click
        iFirstNumber = Val(txtNum.Text)
        sOperator = "/"
        txtNum.Text = ""
    End Sub

    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        iFirstNumber = Val(txtNum.Text)
        sOperator = "%"
        txtNum.Text = ""
    End Sub

    Private Sub btnIntegerDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntegerDiv.Click
        iFirstNumber = Val(txtNum.Text)
        sOperator = "\"
        txtNum.Text = ""
    End Sub
    Private Sub btnSquare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSquare.Click
        iFirstNumber = Val(txtNum.Text)
        sOperator = "^"
        txtNum.Text = ""
    End Sub

    Private Sub btnEquals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquals.Click
        btn0.Enabled = True
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
        btnAdd.Enabled = True
        btnSquare.Enabled = True
        btnMod.Enabled = True
        btnSubtract.Enabled = True
        btnDivide.Enabled = True
        btnMultiply.Enabled = True
        btnSquareBy2.Enabled = True
        btnIntegerDiv.Enabled = True
        btnPeriod.Enabled = True
        btnClear.Enabled = True

        Select Case sOperator
            Case "+"
                txtNum.Text = iFirstNumber + Val(txtNum.Text)
            Case "-"
                txtNum.Text = iFirstNumber - Val(txtNum.Text)
            Case "*"
                txtNum.Text = iFirstNumber * Val(txtNum.Text)
            Case "%"
                txtNum.Text = iFirstNumber Mod Val(txtNum.Text)
            Case "/"
                txtNum.Text = iFirstNumber / Val(txtNum.Text)
            Case "\"
                txtNum.Text = iFirstNumber \ Val(txtNum.Text)
            Case "^"
                txtNum.Text = iFirstNumber ^ Val(txtNum.Text)
            Case "x^2"
                txtNum.Text = iFirstNumber ^ 2
        End Select
    End Sub

    Private Sub btnSquareBy2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSquareBy2.Click
        iFirstNumber = Val(txtNum.Text)
        sOperator = "x^2"
        txtNum.Text += "^2"
        btn0.Enabled = False
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
        btnAdd.Enabled = False
        btnSquare.Enabled = False
        btnMod.Enabled = False
        btnSubtract.Enabled = False
        btnDivide.Enabled = False
        btnMultiply.Enabled = False
        btnSquareBy2.Enabled = False
        btnIntegerDiv.Enabled = False
        btnPeriod.Enabled = False
        btnClear.Enabled = False
    End Sub
End Class
