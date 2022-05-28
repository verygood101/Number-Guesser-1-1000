Public Class Form1
    ' declares the guess and the minimum and maximum of for the computer's guesses, as well as the no. of guesses.
    Dim intguess As Integer
    Dim max As Integer = 1000
    Dim min As Integer = 1
    Dim intNoofGuess As Integer = 0

    ' exits application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    'makes the first guess, only if max is greater than min, else displays an error.
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If max > min Then
            makeGuess()
        Else
            MsgBox("Error with maximum and minimum!")
        End If
    End Sub

    ' when the user inputs that the computer's guess is higher than user's number (by pressing 'lower'), changes the value of max
    Private Sub btnLower_Click(sender As Object, e As EventArgs) Handles btnLower.Click
        max = intguess
        makeGuess()
    End Sub

    ' when the user inputs that the computer's guess is lower than user's number (by pressing 'higher'), changes the value of min
    Private Sub btnHigher_Click(sender As Object, e As EventArgs) Handles btnHigher.Click
        min = intguess
        makeGuess()
    End Sub

    ' when user inputs that the computer's answer is correct
    Private Sub btnCorrect_Click(sender As Object, e As EventArgs) Handles btnCorrect.Click
        MsgBox($"Your number was {intguess}! That took {intNoofGuess} guesses!")
    End Sub


    ' this is a function that makes the computer's guess, as well as updating the label for the guess.
    Private Sub makeGuess()
        intguess = CInt((max - min) / 2 + min) ' the reason that max-min/2 + min is added is due to binary search. This is the algorithm used.
        lblGuess.Text = $"Is your number: {intguess}" 'notice how max and min change throughout the code - each time a 
        intNoofGuess = intNoofGuess + 1 ' guess happens, max and min are changed so that the computer doesn't guess that
        lblScore.Text = intNoofGuess 'number again
    End Sub


End Class
