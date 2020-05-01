Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim vote As String
        vote = InputBox("Vote A for Dog, B for Cat, C for Fish, D is for Bird and E to Exit")


        'x is counter, votes is entry 
        Dim Dog, Cat, Fish, Bird As Integer
        Dim Finish As Boolean
        Finish = False


        Do
            vote = vote
        Loop Until (Finish = True)


        'Casting Vote 
        If (vote = "A") Then
            'Vote is for Dog
            Dog = Dog + 1
        ElseIf (vote = "B") Then
            'Vote is for Cat
            Cat = Cat + 1
        ElseIf (vote = "C") Then
            'Vote is for Fish
            Fish = Fish + 1
        ElseIf (vote = "D") Then
            'Vote is for Bird
            Bird = Bird + 1
        ElseIf (vote = "E") Then
            Finish = True
        Else
            MessageBox.Show("A, B, C, D")
        End If

        lstout.items.add("Votes for Dog Equals  " & Dog)
        lstout.items.add("Votes for Cat Equals  " & Cat)
        lstout.items.add("Votes for Fish Equals " & Fish)
        lstout.items.add("Votes for Bird Equals " & Bird)

        Lstout.items.add("  ")


        'Tallying Vote
        If (Dog > Cat) And (Dog > Bird) And (Dog > Fish) Then
            lstout.items.add("Dog is the Winner ")
            picDog.visible = True
        End If
        If (Cat > Dog) And (Cat > Bird) And (Cat > Fish) Then
            lstout.Items.Add("Cat is the Winner")
            picCat.visible = True
        End If
        If (Bird > Dog) And (Bird > Cat) And (Bird > Fish) Then
            lstout.Items.Add("Fish is the Winner")
            picBird.Visible = False
        End If
        If (Fish > Dog) And (Fish > Cat) And (Fish > Bird) Then
            lstout.Items.Add("Fish is the Winner")
            picFish.visible = True
        End If


        lstout.Items.Add("The Winner Is ")




    End Sub
End Class
