Public Class Form1

    Dim op1 As Double
    Dim operate As Char
    Dim op2 As Double
    Dim evaluated As Boolean

    Private Sub Form_Load() Handles MyBase.Load
        Me.KeyPreview = True
        evaluated = True
    End Sub

    Private Sub Form_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyClass.KeyPress

        Select Case e.KeyChar
            Case "+"
                op1 = TextBox1.Text
                operate = "+"
                prevCalc.Text = TextBox1.Text + " +"
                TextBox1.Text = ""
                evaluated = False
            Case "-"
                op1 = TextBox1.Text
                operate = "-"
                prevCalc.Text = TextBox1.Text + " -"
                TextBox1.Text = ""
                evaluated = False
            Case "*"
                op1 = TextBox1.Text
                operate = "*"
                prevCalc.Text = TextBox1.Text + " *"
                TextBox1.Text = ""
                evaluated = False
            Case "/"
                op1 = TextBox1.Text
                operate = "/"
                prevCalc.Text = TextBox1.Text + " /"
                TextBox1.Text = ""
                evaluated = False
        End Select

        If evaluated = False Then
            Select Case e.KeyChar
                Case "1"
                    TextBox1.Text = TextBox1.Text + "1"
                Case "2"
                    TextBox1.Text = TextBox1.Text + "2"
                Case "3"
                    TextBox1.Text = TextBox1.Text + "3"
                Case "4"
                    TextBox1.Text = TextBox1.Text + "4"
                Case "5"
                    TextBox1.Text = TextBox1.Text + "5"
                Case "6"
                    TextBox1.Text = TextBox1.Text + "6"
                Case "7"
                    TextBox1.Text = TextBox1.Text + "7"
                Case "8"
                    TextBox1.Text = TextBox1.Text + "8"
                Case "9"
                    TextBox1.Text = TextBox1.Text + "9"
                Case "0"
                    TextBox1.Text = TextBox1.Text + "0"
                Case "."
                    TextBox1.Text = TextBox1.Text + "."
            End Select
        End If

        If evaluated = True Then
            Select Case e.KeyChar
                Case "1"
                    prevCalc.Text = TextBox1.Text
                    TextBox1.Text = "1"
                    evaluated = False
                Case "2"
                    prevCalc.Text = TextBox1.Text
                    TextBox1.Text = "2"
                    evaluated = False
                Case "3"
                    prevCalc.Text = TextBox1.Text
                    TextBox1.Text = "3"
                    evaluated = False
                Case "4"
                    prevCalc.Text = TextBox1.Text
                    TextBox1.Text = "4"
                    evaluated = False
                Case "5"
                    prevCalc.Text = TextBox1.Text
                    TextBox1.Text = "5"
                    evaluated = False
                Case "6"
                    prevCalc.Text = TextBox1.Text
                    TextBox1.Text = "6"
                    evaluated = False
                Case "7"
                    prevCalc.Text = TextBox1.Text
                    TextBox1.Text = "7"
                    evaluated = False
                Case "8"
                    prevCalc.Text = TextBox1.Text
                    TextBox1.Text = "8"
                    evaluated = False
                Case "9"
                    prevCalc.Text = TextBox1.Text
                    TextBox1.Text = "9"
                    evaluated = False
                Case "0"
                    prevCalc.Text = TextBox1.Text
                    TextBox1.Text = "0"
                    evaluated = False
                Case "."
                    prevCalc.Text = TextBox1.Text
                    TextBox1.Text = "0."
                    evaluated = False
            End Select
        End If



    End Sub


    Private Sub eql_Click(sender As Object, e As EventArgs) Handles eqBtn.Click
        Dim solution As Integer
        op2 = TextBox1.Text

        Select Case operate
            Case "+"
                prevCalc.Text = op1.ToString + " + " + op2.ToString
                TextBox1.Text = op1 + op2
                evaluated = True
            Case "-"
                prevCalc.Text = op1.ToString + " - " + op2.ToString
                TextBox1.Text = op1 - op2
                evaluated = True
            Case "*"
                prevCalc.Text = op1.ToString + " * " + op2.ToString
                TextBox1.Text = op1 * op2
                evaluated = True
            Case "/"
                prevCalc.Text = op1.ToString + " / " + op2.ToString
                TextBox1.Text = op1 / op2
                evaluated = True

        End Select
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        If evaluated = False Then
            TextBox1.Text = TextBox1.Text + "1"
        ElseIf evaluated = True Then
            prevCalc.Text = TextBox1.Text
            TextBox1.Text = "1"
            evaluated = False
        End If

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles signBtn.Click
        Dim currentNum As Double
        If TextBox1.Text IsNot "" Then
            currentNum = CDbl(TextBox1.Text)
        End If


        If currentNum < 0 Then
            currentNum = currentNum + (2 * Math.Abs(currentNum))
        ElseIf currentNum > 0 Then
            currentNum = currentNum - (2 * currentNum)
        End If

        TextBox1.Text = currentNum

    End Sub

    Private Sub clrBtn_Click(sender As Object, e As EventArgs) Handles clrBtn.Click
        op1 = 0
        op2 = 0
        operate = ""
        TextBox1.Text = 0
        prevCalc.Text = ""
        evaluated = True
    End Sub

    Private Sub bkBtn_Click(sender As Object, e As EventArgs) Handles bkBtn.Click
        Try
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        Catch exception As System.ArgumentOutOfRangeException
            MsgBox("Nothing to delete...")
        End Try

    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        If evaluated = False Then
            TextBox1.Text = TextBox1.Text + "2"
        ElseIf evaluated = True Then
            prevCalc.Text = TextBox1.Text
            TextBox1.Text = "2"
            evaluated = False
        End If
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        If evaluated = False Then
            TextBox1.Text = TextBox1.Text + "3"
        ElseIf evaluated = True Then
            prevCalc.Text = TextBox1.Text
            TextBox1.Text = "3"
            evaluated = False
        End If
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        If evaluated = False Then
            TextBox1.Text = TextBox1.Text + "4"
        ElseIf evaluated = True Then
            prevCalc.Text = TextBox1.Text
            TextBox1.Text = "4"
            evaluated = False
        End If
    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        If evaluated = False Then
            TextBox1.Text = TextBox1.Text + "5"
        ElseIf evaluated = True Then
            prevCalc.Text = TextBox1.Text
            TextBox1.Text = "5"
            evaluated = False
        End If
    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        If evaluated = False Then
            TextBox1.Text = TextBox1.Text + "6"
        ElseIf evaluated = True Then
            prevCalc.Text = TextBox1.Text
            TextBox1.Text = "6"
            evaluated = False
        End If
    End Sub

    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click
        If evaluated = False Then
            TextBox1.Text = TextBox1.Text + "7"
        ElseIf evaluated = True Then
            prevCalc.Text = TextBox1.Text
            TextBox1.Text = "7"
            evaluated = False
        End If
    End Sub

    Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click
        If evaluated = False Then
            TextBox1.Text = TextBox1.Text + "8"
        ElseIf evaluated = True Then
            prevCalc.Text = TextBox1.Text
            TextBox1.Text = "8"
            evaluated = False
        End If
    End Sub

    Private Sub b9_Click(sender As Object, e As EventArgs) Handles b9.Click
        If evaluated = False Then
            TextBox1.Text = TextBox1.Text + "9"
        ElseIf evaluated = True Then
            prevCalc.Text = TextBox1.Text
            TextBox1.Text = "9"
            evaluated = False
        End If
    End Sub

    Private Sub b0_Click(sender As Object, e As EventArgs) Handles b0.Click
        If evaluated = False Then
            TextBox1.Text = TextBox1.Text + "0"
        ElseIf evaluated = True Then
            prevCalc.Text = TextBox1.Text
            TextBox1.Text = "0"
            evaluated = False
        End If
    End Sub

    Private Sub bDot_Click(sender As Object, e As EventArgs) Handles bDot.Click
        If evaluated = False Then
            TextBox1.Text = TextBox1.Text + "."
        ElseIf evaluated = True Then
            prevCalc.Text = TextBox1.Text
            TextBox1.Text = "0."
            evaluated = False
        End If
    End Sub

    Private Sub bPlus_Click(sender As Object, e As EventArgs) Handles bPlus.Click
        op1 = TextBox1.Text
        operate = "+"
        prevCalc.Text = TextBox1.Text + " +"
        TextBox1.Text = ""
        evaluated = False
    End Sub

    Private Sub bMinus_Click(sender As Object, e As EventArgs) Handles bMinus.Click
        op1 = TextBox1.Text
        operate = "-"
        prevCalc.Text = TextBox1.Text + " -"
        TextBox1.Text = ""
        evaluated = False
    End Sub

    Private Sub bMult_Click(sender As Object, e As EventArgs) Handles bMult.Click
        op1 = TextBox1.Text
        operate = "*"
        prevCalc.Text = TextBox1.Text + " *"
        TextBox1.Text = ""
        evaluated = False
    End Sub

    Private Sub bDiv_Click(sender As Object, e As EventArgs) Handles bDiv.Click
        op1 = TextBox1.Text
        operate = "/"
        prevCalc.Text = TextBox1.Text + " /"
        TextBox1.Text = ""
        evaluated = False
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Application.Exit()

    End Sub
End Class
