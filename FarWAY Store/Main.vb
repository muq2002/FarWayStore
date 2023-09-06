Public Class Main


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CloseBTN.Click
        Application.Exit()
    End Sub

    Private Sub MinBTN_Click(sender As Object, e As EventArgs) Handles MinBTN.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Minimized
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub MainBTN_Click(sender As Object, e As EventArgs) Handles MainBTN.Click
        Dim Check = Me.Controls.Find("UCMain1", True)
        Dim User As New UCMain
        If Check.Length = -1 Then
            User.Dock = DockStyle.Fill
            User.Name = "UCMain1"
            Contianer.Controls.Add(User)
        Else
            User.BringToFront()
        End If
    End Sub

    Private Sub SellingBTN_Click(sender As Object, e As EventArgs) Handles SellingBTN.Click
        Dim Check = Me.Controls.Find("Selling1", True)
        Dim User As New Selling
        If Check.Length = -1 Then
            User.Dock = DockStyle.Fill
            User.Name = "Selling1"
            Contianer.Controls.Add(User)
        Else
            User.BringToFront()
        End If
    End Sub

    Private Sub DebtBTN_Click(sender As Object, e As EventArgs) Handles DebtBTN.Click
        Dim Check = Me.Controls.Find("Debt1", True)
        Dim User As New Debt
        If Check.Length = -1 Then
            User.Dock = DockStyle.Fill
            User.Name = "Debt1"
            Contianer.Controls.Add(User)
        Else
            User.BringToFront()
        End If
    End Sub

    Private Sub StaticsBTN_Click(sender As Object, e As EventArgs) Handles StaticsBTN.Click
        Dim Check = Me.Controls.Find("Statics1", True)
        Dim User As New Statics
        If Check.Length = -1 Then
            User.Dock = DockStyle.Fill
            User.Name = "Statics1"
            Contianer.Controls.Add(User)
        Else
            User.BringToFront()
        End If
    End Sub

    Private Sub SettingBTN_Click(sender As Object, e As EventArgs) Handles SettingBTN.Click
        Dim Check = Me.Controls.Find("Setting1", True)
        Dim User As New Setting
        If Check.Length = -1 Then
            User.Dock = DockStyle.Fill
            User.Name = "Setting1"
            Contianer.Controls.Add(User)
        Else
            User.BringToFront()
        End If
    End Sub

    Private Sub ProductTBN_Click(sender As Object, e As EventArgs) Handles ProductTBN.Click
        Dim Check = Me.Controls.Find("Products1", True)
        Dim User As New Products
        If Check.Length = -1 Then
            User.Dock = DockStyle.Fill
            User.Name = "Products1"
            Contianer.Controls.Add(User)
        Else
            User.BringToFront()
        End If
    End Sub
End Class
