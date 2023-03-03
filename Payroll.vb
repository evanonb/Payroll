Public Class Payroll
    Const _cdecFica As Decimal = 0.0765D
    Const _cdecFederal As Decimal = 0.22D
    Const _cdecState As Decimal = 0.04D

    Private Sub btmComputeTaxes_Click(sender As Object, e As EventArgs) Handles btmComputeTaxes.Click
        ' This event handler calculates the FICA, Federal Tax, and State Tax on gross pay that
        ' the user inputs. It then displays all three of these amounts and the gross pay
        ' amount minus these amount to find the total paycheck income

        txtInput.Focus()

        Dim strIncome As String
        Dim decIncome As Decimal
        Dim decFica As Decimal
        Dim decFederal As Decimal
        Dim decState As Decimal
        Dim decNet As Decimal

        strIncome = txtInput.Text
        decIncome = Convert.ToDecimal(strIncome)

        decFica = decIncome * _cdecFica
        lblFicaOutput.Text = decFica.ToString("C")

        decFederal = decIncome * _cdecFederal
        lblFederalOutput.Text = decFederal.ToString("C")

        decState = decIncome * _cdecState
        lblStateOutput.Text = decState.ToString("C")

        decNet = decIncome - decFica - decFederal - decState
        lblOutput.Text = decNet.ToString("C")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Text = ""
        lblFicaOutput.Text = ""
        lblFederalOutput.Text = ""
        lblStateOutput.Text = ""
        lblOutput.Text = ""
        txtInput.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
