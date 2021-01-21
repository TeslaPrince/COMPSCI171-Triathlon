Public Class btnClear
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Const bikeC As Integer = 200
        Const runC As Integer = 745
        Const swimC As Integer = 275
        Const calorieC As Integer = 3500
        Dim fmt As String = "{0,-15}{1,-21:N}{2,19:N}"
        Dim bike As Double
        Dim run As Double
        Dim swim As Double
        Dim total As Double
        Dim weight As Double
        Dim bikeB As Double
        Dim runB As Double
        Dim swimB As Double
        bike = CInt(txtBike.Text)
        run = CInt(txtRun.Text)
        swim = CInt(txtSwim.Text)
        bikeB = bike * bikeC
        runB = run * runC
        swimB = swim * swimC
        total = bikeB + runB + swimB
        weight = total / calorieC
        ListBox1.Items.Add(String.Format(fmt, "Activity", "Number of Hours", "Calories Burned"))
        ListBox1.Items.Add(String.Format(fmt, "Bicycling", bike, bikeB))
        ListBox1.Items.Add(String.Format(fmt, "Running", run, runB))
        ListBox1.Items.Add(String.Format(fmt, "Swimming", swim, swimB))
        ListBox1.Items.Add(String.Format(fmt, "", "", "__________"))
        ListBox1.Items.Add(String.Format(fmt, "Total", "", total))
        ListBox1.Items.Add(String.Format(fmt, "You lost:", "", weight))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtBike.Text = ""
        txtRun.Text = ""
        txtSwim.Text = ""
        ListBox1.Items.Clear()
    End Sub
End Class
