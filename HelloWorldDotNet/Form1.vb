Public Class Form1
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        TextBox1.Text = e.Start.ToString


    End Sub
End Class
