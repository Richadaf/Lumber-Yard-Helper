Public Class frmLumberyard

    Private Sub frmLumberyard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblType.Text = Nothing
        lblBoardF.Text = Nothing
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim sngThickness, sngLength, sngwidth As Single
        Dim strClassification As String 'For the Return value of Function CutClassification
        Dim sngBoardF
        sngThickness = Val(TxtThickness.Text)
        sngLength = Val(txtLength.Text)
        sngwidth = Val(txtWidth.Text)
        'Adjust Function Return data Type

        lblType.Text = "Type: " & cutClassification(sngThickness, sngLength, sngwidth, strClassification)
        lblBoardF.Text = "Board Feet: " & BoardFeet(sngThickness, sngLength, sngwidth, sngBoardF)


    End Sub
    Function BoardFeet(ByVal sngThickness As Single, ByVal sngLength As Single, ByVal sngwidth As Single, ByVal sngboardFeet As Single)
        sngThickness = Val(TxtThickness.Text)
        sngLength = Val(txtLength.Text)
        sngwidth = Val(txtWidth.Text)

        sngboardFeet = ((sngThickness * (sngLength * 12) * sngwidth) / (12 * 12 * 1))


        Return sngboardFeet

    End Function
    Function cutClassification(ByVal sngThickness As Single, _
                                 ByVal sngLength As Single, ByVal sngWidth As Single, ByVal strClassification As String)

        sngThickness = Val(TxtThickness.Text)
        sngLength = Val(txtLength.Text)
        sngWidth = Val(txtWidth.Text)

        If sngThickness <= 1 Then
            strClassification = "Board"
            PictureBox1.Image = Image.FromFile("Board.jpg")
        ElseIf sngThickness >= 2 Or sngThickness <= 3 Then
            strClassification = "Lumber"
            PictureBox1.Image = Image.FromFile("Lumber.jpg")
        ElseIf sngThickness > 4 Then
            strClassification = "Timber"
            PictureBox1.Image = Image.FromFile("Timber.jpg")
        End If
        Return strClassification
    End Function



End Class
