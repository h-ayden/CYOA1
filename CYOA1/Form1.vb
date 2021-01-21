Public Class Form1
    Dim intPage As Integer
    Dim sngMoney As Single
    Dim intSnickers As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intPage = 1
        lblStory.Text = "You have to go to the Science Fair today. your partner is already there waiting fo you."
        btnOption1.Text = "Go meet them"
        btnOption2.Text = "Go get a snack"
        sngMoney = 3.45
        lblMoney.Text = "Money: $" & sngMoney
        intSnickers = 0

        picImage.Image = My.Resources.scienceFair
    End Sub

    Private Sub btnOption1_Click(sender As Object, e As EventArgs) Handles btnOption1.Click
        If intPage = 1 Or intPage = 10 Then
            intPage = 2
            lblStory.Text = "They are REALLY stressed out."
            btnOption1.Text = "Leave"
            btnOption2.Visible = True
            If intSnickers = 0 Then
                btnOption2.Text = "Try to calm them"
            ElseIf intSnickers = 1 Then
                btnOption2.Text = "give them Snickers"

                picImage.Image = My.Resources.scienceFair
            End If

        ElseIf intPage = 2 Then
            intPage = 4
            lblStory.Text = "You are a bad friend!"
            btnOption1.Text = "Play Again"
            btnOption2.Visible = False
            picImage.Image = My.Resources.scienceFair

        ElseIf intPage = 3 Then
            intPage = 10
            lblStory.Text = "You bought that Snickers!"
            btnOption1.Text = "Continue..."
            btnOption2.Visible = False
            sngMoney = sngMoney - 2.3
            lblMoney.Text = "Money: $" & sngMoney

            picImage.Image = My.Resources.snickers

        ElseIf intPage = 4 Or intPage = 5 Or intPage = 6 Then
            intPage = 1
            lblStory.Text = "you have to go to the Science Fair today. your partner is already there waiting fo you."
            btnOption1.Text = "Go meet them"
            btnOption2.Visible = True
            btnOption2.Text = "Go get a snack"
            sngMoney = 3.45
            lblMoney.Text = "Money: $" & sngMoney
            intSnickers = 0

            picImage.Image = My.Resources.scienceFair
        End If

    End Sub

    Private Sub btnOption2_Click(sender As Object, e As EventArgs) Handles btnOption2.Click
        Randomize()
        Dim intChance As Integer

        If intPage = 1 Then
            intPage = 3
            lblStory.Text = "A Snickers bar cost $2.30."
            btnOption1.Text = "Buy the Snickers"
            btnOption2.Visible = True
            btnOption2.Text = "Go meet your friend"

            picImage.Image = My.Resources.snickers

        ElseIf intPage = 2 Then
            intChance = Int(Rnd() * 100) + 1

            If (intChance < 51) And (intSnickers = 0) Then
                intPage = 5
                lblStory.Text = "You fail! They don't like you anymore."
                btnOption1.Text = "Play Again"
                btnOption2.Visible = False

                picImage.Image = My.Resources.scienceFair

            Else : intPage = 6
                lblStory.Text = "Your friend calms down. You win the Science Fair!"
                btnOption1.Text = "Play Again"
                btnOption2.Visible = False

                picImage.Image = My.Resources.scienceFair

            End If

        ElseIf intPage = 3 Then
            intPage = 2
            lblStory.Text = "They are REALLY stressed out."
            btnOption1.Text = "Leave"
            btnOption2.Visible = True
            btnOption2.Text = "Try to calm them"

            picImage.Image = My.Resources.scienceFair

        End If

    End Sub

    Private Sub picImage_Click(sender As Object, e As EventArgs) Handles picImage.Click

    End Sub
End Class
