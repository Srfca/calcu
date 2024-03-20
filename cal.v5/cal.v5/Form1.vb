Public Class Form1

    Dim num1, num2 As Double
    Dim op As String

    Private Sub NumBtn(sender As Object, e As EventArgs) Handles BtnDec.Click, Btn9.Click, Btn8.Click, Btn7.Click, Btn6.Click, Btn5.Click, Btn4.Click, Btn3.Click, Btn2.Click, Btn1.Click, Btn0.Click

        Dim b As Button = sender

        If (b.Text = ".") Then

            If (Not Label2.Text.Contains(".")) Then
                Label2.Text = Label2.Text + b.Text
            End If
        Else
            Label2.Text = Label2.Text + b.Text
        End If

    End Sub

    Private Sub OpBtn(sender As Object, e As EventArgs) Handles Btnsum.Click, Btnprod.Click, Btndiv.Click, Btndiff.Click

        Dim b As Button = sender

        If (Label2.Text <> 0) Then
            Label1.Text = Label2.Text
            Label2.Text = ""
            op = b.Text
            Label2.Text = Label2.Text + "" + op
        End If

    End Sub

    Private Sub EqualBtn(sender As Object, e As EventArgs) Handles BtnEqual.Click

        Try

            If Label1.Text = ("Invalid!") Then Label1.Text = vbEmpty

            If (Label2.Text <> "" And op <> "") Then
                num1 = Val(Label1.Text) : num2 = Val(Label2.Text)

                Select Case op
                    Case "+"
                        Label2.Text = (num1 + num2)
                    Case "-"
                        Label2.Text = (num1 - num2)
                    Case "*"
                        Label2.Text = (num1 * num2)
                    Case "/"
                        If num2 = 0 Then
                            Label2.Text = ("Invalid!")
                        Else
                            Label2.Text = (num1 / num2)
                        End If

                End Select
                Label1.Text = ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click

        If (Label2.Text.Length > 0) Then
            Label2.Text = Label2.Text.Remove(Label2.Text.Length - 1, 1)
        End If

    End Sub

    Private Sub CEBtn_Click(sender As Object, e As EventArgs) Handles CEBtn.Click
        Dim f, s As String

        Label2.Text = ""
        f = Convert.ToString(num1)
        s = Convert.ToString(num2)

        f = ""
        s = ""

    End Sub

    Private Sub ClrBtn_Click(sender As Object, e As EventArgs) Handles ClrBtn.Click
        Label2.Text = ""
        Label1.Text = ""
    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click

        Dim pm As Double

        pm = Convert.ToDouble(Label2.Text)
        Label2.Text = Convert.ToString(-1 * pm)
    End Sub

End Class
