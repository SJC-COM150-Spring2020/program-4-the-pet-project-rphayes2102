Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim vote As String
        vote = InputBox("Vote for your Pet")

        Dim animals As String
        Dim votes As Integer

        'x will be index value
        Dim vote As Integer
        For x = 0 To 1
            vote(x) = CInt(InputBox("You have voted"))

        Next
        Dim animals As String = ("Dog, Cat, Bird, Fish")

        'Casting Vote 
        If vote Is LblDog Then
            txt1.Text = "1 & You Voted Dog "
        End If
        If vote Is lblCat Then
            txt2.Text = "1 & You Voted Cat "
        End If
        If vote Is lblBird Then
            txt3.Text = "1 & You Voted Bird"
        End If
        If vote Is lblFish Then
            txt4.Text = "1 & You Voted Fish"
        End If

        MessageBox.Show("The Winner Is ")




    End Sub
End Class
