Public Class Loja


    Dim Gjarperi(1000) As PictureBox

    Dim ushqimi As New PictureBox

    Dim gj As Integer = -1

    Dim Gj_BG As Drawing.Image = My.Resources.SnakeBody

    Dim U_BG As Drawing.Image = My.Resources.ushqimi

    Dim horiz As Integer = 10

    Dim ran As New Random

    Dim vert As Integer = 0

    Dim piketTotale As Integer = 0


    Sub koka()
        gj += 1
        Gjarperi(gj) = New PictureBox
        With Gjarperi(gj)
            .Height = 10
            .Width = 10
            .BackgroundImage = Gj_BG
            .Top = Fusha.Height / 2
            .Left = Fusha.Height / 2
            .BorderStyle = BorderStyle.None
        End With
        Me.Controls.Add(Gjarperi(gj))
        Gjarperi(gj).BringToFront()
    End Sub

    Sub Zgjatim()
        gj += 1
        Gjarperi(gj) = New PictureBox
        With Gjarperi(gj)
            .Height = 10
            .Width = 10
            .BackgroundImage = Gj_BG
            .Top = Gjarperi(gj - 1).Top + vert
            .Left = Gjarperi(gj - 1).Left + horiz
            .BorderStyle = BorderStyle.None
        End With
        Me.Controls.Add(Gjarperi(gj))
        Gjarperi(gj).BringToFront()



    End Sub

    Private Sub Loja_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                If (vert <> 0) Then
                    horiz = 10
                    vert = 0
                End If

                e.Handled = True
            Case Keys.Left
                If (vert <> 0) Then
                    horiz = -10
                    vert = 0
                End If

                e.Handled = True
            Case Keys.Up
                If (horiz <> 0) Then
                    horiz = 0
                    vert = -10
                End If
                e.Handled = True
            Case Keys.Down
                If (horiz <> 0) Then
                    horiz = 0
                    vert = 10
                End If
                e.Handled = True
        End Select
    End Sub

    Private Sub Loja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timeri.Start()
        koka()
        krijo_ushqimi()
   
    End Sub

    Private Sub Timeri_Tick(sender As Object, e As EventArgs) Handles Timeri.Tick
        Kontrollo_murin()
        KontrolloLojen()

        For i = gj To 1 Step -1
            Gjarperi(i).Top = Gjarperi(i - 1).Top
            Gjarperi(i).Left = Gjarperi(i - 1).Left
        Next

        Gjarperi(0).Top += vert
        Gjarperi(0).Left += horiz

    End Sub

    Sub Kontrollo_murin()

        If Gjarperi(0).Top < Fusha.Top + 10 And vert = -10 Then
            Gjarperi(0).Top = Fusha.Bottom - 10
        End If

        If Gjarperi(0).Top > Fusha.Bottom - 20 And vert = 10 Then

            Gjarperi(0).Top = Fusha.Top
        End If

        If Gjarperi(0).Left < Fusha.Left + 10 And horiz = -10 Then
            Gjarperi(0).Left = Fusha.Right - 10
        End If

        If Gjarperi(0).Left > Fusha.Right - 20 And horiz = 10 Then
            Gjarperi(0).Left = Fusha.Left
        End If

    End Sub

    Sub krijo_ushqimi()
        With ushqimi
            .Height = 10
            .Width = 10
            .Top = ran.Next(Fusha.Top, Fusha.Bottom - 10)
            .Left = ran.Next(Fusha.Left, Fusha.Right - 10)
            .BackgroundImage = U_BG
        End With
        Me.Controls.Add(ushqimi)
        ushqimi.BringToFront()
        piket.Text = piketTotale.ToString
    End Sub

    Sub KontrolloLojen()

        
        If (Gjarperi(0).Bounds.IntersectsWith(ushqimi.Bounds)) Then
            ushqimi.Top = ran.Next(Fusha.Top, Fusha.Bottom - 10)
            ushqimi.Left = ran.Next(Fusha.Left, Fusha.Right - 10)
            piketTotale = piketTotale + 1
            piket.Text = piketTotale.ToString
            Zgjatim()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Restart()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

End Class
