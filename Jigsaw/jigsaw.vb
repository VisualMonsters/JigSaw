Public Class jigsaw

    Dim random As New Random
    Private WithEvents Timer1 As New Timer With {.Interval = 10}

    'przechowuje siatkę planszy głównej
    Dim backgroundPanelsList As New List(Of Tuple(Of Panel, Integer, Integer))
    Dim backgroundColor As Color = Color.White 'kolor pól na planszy
    'przechowuje listę czarnych punktów na planszy
    Dim blackPointsPanelsList As New List(Of Tuple(Of String, Integer, Integer))

    'główna plansza gry
    Private WithEvents mainBoard As New Panel
    'panel który zawiera punkty, wzory itp
    Private WithEvents PanelTop As New Panel

    'pierwszy wzór
    Private WithEvents firstLeftTop As New Panel
    Private WithEvents firstLeftBottom As New Panel
    Private WithEvents firstRightTop As New Panel
    Private WithEvents firstRightBottom As New Panel

    'drugi wzór
    Private WithEvents secondLeftTop As New Panel
    Private WithEvents secondLeftBottom As New Panel
    Private WithEvents secondRightTop As New Panel
    Private WithEvents secondRightBottom As New Panel

    'elementy pomocnicze
    Private WithEvents hiddenLeftTop As New Panel
    Private WithEvents hiddenRightTop As New Panel
    Private WithEvents hiddenLeftBottom As New Panel
    Private WithEvents hiddenRightBottom As New Panel

    'lewel gry, odpowiada za wielkość planszy
    Private level As Integer

    Dim points As Double = 0
    Dim steps As Integer = 0

    Dim labelSteps As Label
    Dim labelPoints As Label

    Public Sub New(ByRef mainBoard As Panel,
                   ByRef PanelTop As Panel,
                   ByRef firstLeftTop As Panel,
                   ByRef firstLeftBottom As Panel,
                   ByRef firstRightTop As Panel,
                   ByRef firstRightBottom As Panel,
                   ByRef secondLeftTop As Panel,
                   ByRef secondLeftBottom As Panel,
                   ByRef secondRightTop As Panel,
                   ByRef secondRightBottom As Panel,
                   ByVal _level As Integer,
                   ByRef hiddenLeftTop As Panel,
                   ByRef hiddenRightTop As Panel,
                   ByRef hiddenLeftBottom As Panel,
                   ByRef hiddenRightBottom As Panel,
                   ByVal proc As Double,
                   ByRef points As Label,
                   ByRef steps As Label)

        _mainBoard = mainBoard
        _PanelTop = PanelTop

        _firstLeftTop = firstLeftTop
        _firstLeftBottom = firstLeftBottom
        _firstRightTop = firstRightTop
        _firstRightBottom = firstRightBottom

        _secondLeftTop = secondLeftTop
        _secondLeftBottom = secondLeftBottom
        _secondRightTop = secondRightTop
        _secondRightBottom = secondRightBottom

        _hiddenLeftTop = hiddenLeftTop
        _hiddenRightTop = hiddenRightTop
        _hiddenLeftBottom = hiddenLeftBottom
        _hiddenRightBottom = hiddenRightBottom

        labelSteps = steps
        labelPoints = points
        level = _level
        generateMainBoard(proc)

    End Sub


    Public Sub generateMainBoard(ByVal proc As Double)

        labelSteps.Text = steps.ToString
        labelPoints.Text = points.ToString

        Dim width As Integer = 3 + level
        Dim height As Integer = 3 + level

        If (PanelTop.Location.Y + PanelTop.Height + 5) + height * (50 * proc) + (48 * proc) _
            > mainBoard.Parent.Height Then
            Do
                height -= 1
                width += 1
                If (PanelTop.Location.Y + PanelTop.Height + 5) + height * (50 * proc) + (48 * proc) _
                    < mainBoard.Parent.Height Then
                    Exit Do
                End If
            Loop
        End If

        'ustawia wielkość głównej planszy do gry na postawie wysokości i szerokości
        'dodatkowo używamy procentu który może być użyteczny do jednolitego zwiększenia bądź zmniejszenia planszy
        mainBoard.Size = New Size(width * (50 * proc) + (48 * proc), height * (50 * proc) + (48 * proc))
        'Ładnie ustawi lokalizacje głównej planszy gry na środku
        mainBoard.Location = New Point((mainBoard.Parent.Width - mainBoard.Width) / 2,
                                       (mainBoard.Parent.Height - mainBoard.Height) / 2)

        'Czarne punkty na planszy
        For i As Integer = 0 To width - 1
            For j As Integer = 0 To height - 1
                Dim blackPoints As New Panel
                blackPoints.Location = New Point((45 * proc) + i * (49 * proc), (45 * proc) + j * (49 * proc))
                blackPoints.Size = New Size((10 * proc), (10 * proc))
                blackPoints.BackColor = Color.Black
                blackPoints.Cursor = Cursors.Hand
                blackPoints.Name = "panL_" + i.ToString + j.ToString
                'obsługuje kliknięcie w panel
                AddHandler blackPoints.Click, AddressOf blackPoints_Click
                'wyswietla duchy po wejściu kursorem w czarny punkt
                AddHandler blackPoints.MouseEnter, AddressOf pan_enter
                'wygasza duchy po wyjściu z punktu
                AddHandler blackPoints.MouseLeave, AddressOf pan_leave
                'dodaje nasz punkt do listy
                blackPointsPanelsList.Add(Tuple.Create(blackPoints.Name, i, j))
                'dodaje nasz czarny punkt na plansze
                mainBoard.Controls.Add(blackPoints)
            Next
        Next
        'Siatka na planszy
        For i As Integer = 0 To width
            For j As Integer = 0 To height
                Dim web As New Panel
                web.Location = New Point(1 + i * (49 * proc), 1 + j * (49 * proc))
                web.BackColor = backgroundColor
                web.Size = New Size((49 * proc), (49 * proc))
                web.Name = "pan_" + i.ToString + j.ToString
                'ten panel będzie miał wiele zastosowań, będzie wyswietlał duchy i przechowywał 
                'punkty dodane odjęte itp
                backgroundPanelsList.Add(Tuple.Create(web, i, j))
                web.BorderStyle = BorderStyle.FixedSingle
                'dodaje siatkę na planszę gry
                mainBoard.Controls.Add(web)
            Next
        Next
        'losuje wzory
        patternDrawing(firstLeftTop, firstLeftBottom, firstRightTop, firstRightBottom, 255)
        patternDrawing(secondLeftTop, secondLeftBottom, secondRightTop, secondRightBottom, 100)

    End Sub

#Region "Losowanie wzoru"
    Private Sub patternDrawing(ByRef pan1 As Panel, ByRef pan2 As Panel, ByRef pan3 As Panel,
                               ByRef pan4 As Panel, ByVal brightness As Integer)

        'zeruje kolor pól
        pan1.BackColor = backgroundColor
        pan2.BackColor = backgroundColor
        pan3.BackColor = backgroundColor
        pan4.BackColor = backgroundColor

        'Lista kolorów z których będzie układany wzór
        Dim colorsList As New List(Of Color)
        colorsList.Add(Color.FromArgb(100, 187, 132))
        colorsList.Add(Color.FromArgb(94, 193, 235))
        colorsList.Add(Color.FromArgb(217, 187, 213))
        colorsList.Add(Color.FromArgb(245, 209, 13))
        'komplikuje gre dy level/wielkość planszy jest większa
        If level > 3 Then
            colorsList.Add(Color.FromArgb(235, 131, 60))
        End If
        If level > 5 Then
            colorsList.Add(Color.FromArgb(239, 150, 144))
        End If

        'kontrola duplikatów kolorów, nie możemy dopuścić aby kolory się zduplikowały
        Dim duplicateControl As New List(Of Boolean)
        For i As Integer = 0 To 3
            duplicateControl.Add(False)
        Next

        'wybór naszego wzoru
        Select Case random.Next(0, 4)
            Case 0
                '11
                '10
                pan1.BackColor = randomChoice(duplicateControl, brightness, colorsList)
                pan2.BackColor = randomChoice(duplicateControl, brightness, colorsList)
                pan3.BackColor = randomChoice(duplicateControl, brightness, colorsList)
            Case 1
                '10
                '11
                pan1.BackColor = randomChoice(duplicateControl, brightness, colorsList)
                pan2.BackColor = randomChoice(duplicateControl, brightness, colorsList)
                pan4.BackColor = randomChoice(duplicateControl, brightness, colorsList)
            Case 2
                '01
                '11
                pan2.BackColor = randomChoice(duplicateControl, brightness, colorsList)
                pan3.BackColor = randomChoice(duplicateControl, brightness, colorsList)
                pan4.BackColor = randomChoice(duplicateControl, brightness, colorsList)
            Case 3
                '11
                '01
                pan1.BackColor = randomChoice(duplicateControl, brightness, colorsList)
                pan3.BackColor = randomChoice(duplicateControl, brightness, colorsList)
                pan4.BackColor = randomChoice(duplicateControl, brightness, colorsList)
        End Select
    End Sub

    Function randomChoice(duplicateControl As List(Of Boolean), brightness As Integer,
                          colorsList As List(Of Color)) As Color
        Do
            Dim rand As Integer = random.Next(0, colorsList.Count)
            If duplicateControl(rand) = False Then
                duplicateControl(rand) = True
                'wybiera kolor i opuszcza pętle
                Return Color.FromArgb(brightness, colorsList(rand))
            End If
        Loop
    End Function
#End Region


#Region "wizualizacja wzoru"
    Dim ghost1 As New Panel
    Dim ghost2 As New Panel
    Dim ghost3 As New Panel
    Dim ghost4 As New Panel

    'przechowuje koordynaty naszego wyboru
    Dim localization_1 As Integer
    Dim localization_2 As Integer

    Private Sub pan_enter(sender As Object, e As EventArgs)
        'wyczyść panele
        cleanGhosts()
        'przeszukuje listę czarnych punktów w poszukiwaniu tego wybranego
        For i As Integer = 0 To blackPointsPanelsList.Count - 1
            If blackPointsPanelsList(i).Item1 = DirectCast(sender, Panel).Name Then
                localization_1 = blackPointsPanelsList(i).Item2
                localization_2 = blackPointsPanelsList(i).Item3
                Exit For
            End If
        Next
        'ten element sprawdza czy ułożenie naszego elementu jest możliwe,
        'jeśli tak to przechodzi do wyświetlenia go na planszy
        If checkPossibility(localization_1, localization_2) = True Then
            'ta logika sprawdza nasz wzór w sekcji wyświetlonych elementów do ułożenia
            If Not firstLeftTop.BackColor = backgroundColor Then
                ghost1 = setColor(0, 0, localization_1, localization_2, firstLeftTop)
            End If
            If Not firstLeftBottom.BackColor = backgroundColor Then
                ghost2 = setColor(0, 1, localization_1, localization_2, firstLeftBottom)
            End If
            If Not firstRightTop.BackColor = backgroundColor Then
                ghost3 = setColor(1, 0, localization_1, localization_2, firstRightTop)
            End If
            If Not firstRightBottom.BackColor = backgroundColor Then
                ghost4 = setColor(1, 1, localization_1, localization_2, firstRightBottom)
            End If
        End If
    End Sub

    Function setColor(plusX As Integer, plusY As Integer, localization_1 As Integer,
                      localization_2 As Integer, targetPanel As Panel) As Panel
        'kiedy przechodzimy na planze, nasze elementy są wyszukiwane na liście za pomocą 
        'koordynatów naszego małego czarnego kwadratu
        For i As Integer = 0 To backgroundPanelsList.Count - 1
            If backgroundPanelsList(i).Item2 = localization_1 + plusX And
                backgroundPanelsList(i).Item3 = localization_2 + plusY Then

                backgroundPanelsList(i).Item1.BackColor = Color.FromArgb(100, targetPanel.BackColor)
                Return backgroundPanelsList(i).Item1
            End If
        Next
        Return New Panel
    End Function

    Private Sub pan_leave(sender As Object, e As EventArgs)
        cleanGhosts()
    End Sub

    Private Sub cleanGhosts()
        ghost1.BackColor = backgroundColor
        ghost2.BackColor = backgroundColor
        ghost3.BackColor = backgroundColor
        ghost4.BackColor = backgroundColor
    End Sub

#End Region

#Region "Sprawdza czy mozna wyświetlić obiekt"
    Private Function checkPossibility(ByVal localization_1 As Integer,
                                      ByVal localization_2 As Integer) As Boolean
        Dim possibility As Boolean = True

        If Not firstLeftTop.BackColor = backgroundColor Then
            possibility = test(0, 0, localization_1, localization_2, firstLeftTop)
            If Not possibility Then
                Return possibility
            End If
        End If
        If Not firstLeftBottom.BackColor = backgroundColor Then
            possibility = test(0, 1, localization_1, localization_2, firstLeftBottom)
            If Not possibility Then
                Return possibility
            End If
        End If
        If Not firstRightTop.BackColor = backgroundColor Then
            possibility = test(1, 0, localization_1, localization_2, firstRightTop)
            If Not possibility Then
                Return possibility
            End If
        End If
        If Not firstRightBottom.BackColor = backgroundColor Then
            possibility = test(1, 1, localization_1, localization_2, firstRightBottom)
            If Not possibility Then
                Return possibility
            End If
        End If
        Return possibility
    End Function

    Function test(plusX As Integer, plusY As Integer, localization_1 As Integer,
                  localization_2 As Integer, targetPanel As Panel) As Boolean

        For i As Integer = 0 To backgroundPanelsList.Count - 1
            If backgroundPanelsList(i).Item2 = localization_1 + plusX And
                backgroundPanelsList(i).Item3 = localization_2 + plusY Then
                If backgroundPanelsList(i).Item1.BackColor = backgroundColor Or
                    backgroundPanelsList(i).Item1.BackColor =
                            Color.FromArgb(100, targetPanel.BackColor) Then
                    Exit For
                Else
                    Return False
                End If
            End If
        Next
        Return True
    End Function
#End Region

#Region "efekt kliku"
    Dim occupiedFields As New List(Of Tuple(Of Panel, Color))

    Public Sub blackPoints_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'dodaj i wyświetl krok
        steps += 1
        labelSteps.Text = steps.ToString
        'ustaw lokalizacje do dalszych czynności
        For i As Integer = 0 To blackPointsPanelsList.Count - 1
            If blackPointsPanelsList(i).Item1 = DirectCast(sender, Panel).Name Then
                localization_1 = blackPointsPanelsList(i).Item2
                localization_2 = blackPointsPanelsList(i).Item3
                Exit For
            End If
        Next
        'sprawdź czy można kliknąć
        If checkPossibility(localization_1, localization_2) Then
            occupiedFields.Clear()
            If Not firstLeftTop.BackColor = backgroundColor Then
                occupiedFields.Add(setOccupiedField(0, 0, localization_1, localization_2, firstLeftTop))
            End If
            If Not firstLeftBottom.BackColor = backgroundColor Then
                occupiedFields.Add(setOccupiedField(0, 1, localization_1, localization_2, firstLeftBottom))
            End If
            If Not firstRightTop.BackColor = backgroundColor Then
                occupiedFields.Add(setOccupiedField(1, 0, localization_1, localization_2, firstRightTop))
            End If
            If Not firstRightBottom.BackColor = backgroundColor Then
                occupiedFields.Add(setOccupiedField(1, 1, localization_1, localization_2, firstRightBottom))
            End If
            'dodaj kolory na planszy
            timeCounter = 0
            Timer1.Start()
            'przesuń wzór
            movePattern()
            'dodaj nowy wzór
            patternDrawing(secondLeftTop, secondRightTop, secondLeftBottom, secondRightBottom, 100)

            ghost1 = hiddenLeftTop
            ghost2 = hiddenRightTop
            ghost3 = hiddenLeftBottom
            ghost4 = hiddenRightBottom
        End If

    End Sub

    Function setOccupiedField(plusX As Integer, plusY As Integer, localization_1 As Integer,
                              localization_2 As Integer, targetPanel As Panel) As Tuple(Of Panel, Color)
        For i As Integer = 0 To backgroundPanelsList.Count - 1
            If backgroundPanelsList(i).Item2 = localization_1 + plusX And
                backgroundPanelsList(i).Item3 = localization_2 + plusY Then
                Return Tuple.Create(backgroundPanelsList(i).Item1, targetPanel.BackColor)
                Exit For
            End If
        Next
        Return Nothing
    End Function

    Dim timeCounter As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeCounter += 50
        If timeCounter >= 255 Then
            Timer1.Stop()
            For i As Integer = 0 To occupiedFields.Count - 1
                occupiedFields(i).Item1.BackColor = occupiedFields(i).Item2
            Next
            sameColors(localization_1, localization_2)
            ' Sprawdza czy to juz koniec gry
            Dim boolList As New List(Of Boolean)

            For i As Integer = 0 To blackPointsPanelsList.Count - 1
                'dla każdego czarnego elementu sprawdzamy możliwość ułożenia wzoru
                boolList.Add(gameOver(blackPointsPanelsList(i).Item2, blackPointsPanelsList(i).Item3,
                                               firstLeftTop, firstLeftBottom, firstRightTop, firstRightBottom))
            Next
            'jesli koniec to zaczernia
            If Not boolList.Contains(True) Then
                'jeśli lista nie zawiera true (czyli możliwości ułożenia) 
                'wtedy zaczernij i zablokuj plansze
                For i As Integer = 0 To backgroundPanelsList.Count - 1
                    If backgroundPanelsList(i).Item1.BackColor = backgroundColor Then
                        backgroundPanelsList(i).Item1.BackColor = Color.Black
                    End If
                Next
                mainBoard.Enabled = False
            End If
            ''''''''''''''''''''''''''''''''
        Else
            For i As Integer = 0 To occupiedFields.Count - 1
                'odsłania ułożony element
                occupiedFields(i).Item1.Refresh()
                occupiedFields(i).Item1.BackColor = Color.FromArgb(timeCounter, occupiedFields(i).Item2)
            Next
        End If

    End Sub
#End Region


#Region "Sprawdza czy koniec gry"
    Private Function gameOver(ByVal localization_1 As Integer, ByVal localization_2 As Integer,
                              ByRef pan1 As Panel, ByRef pan2 As Panel, ByRef pan3 As Panel,
                              ByRef pan4 As Panel) As Boolean

        Dim effect As Boolean = True

        'dla każdego elementu wzoru sprawdzamy czy jest możliwość jego ułożenia w obrębie 
        'czarnego elementu 
        If Not pan1.BackColor = backgroundColor Then
            effect = possibilityTest(0, 0, localization_1, localization_2)
            'jeśli effect jest false wtedy przerywamy naszą funkcje i zwracamy,
            'że elementu nie da się ułożyć
            If Not effect Then
                Return effect
            End If
        End If
        If Not pan2.BackColor = backgroundColor Then
            effect = possibilityTest(0, 1, localization_1, localization_2)
            If Not effect Then
                Return effect
            End If
        End If
        If Not pan3.BackColor = backgroundColor Then
            effect = possibilityTest(1, 0, localization_1, localization_2)
            If Not effect Then
                Return effect
            End If
        End If
        If Not pan4.BackColor = backgroundColor Then
            effect = possibilityTest(1, 1, localization_1, localization_2)
            If Not effect Then
                Return effect
            End If
        End If
        Return effect
    End Function

    Function possibilityTest(plusX As Integer, plusY As Integer, localization_1 As Integer,
                             localization_2 As Integer) As Boolean
        For i As Integer = 0 To backgroundPanelsList.Count - 1
            If backgroundPanelsList(i).Item2 = localization_1 + plusX And
                backgroundPanelsList(i).Item3 = localization_2 + plusY Then
                If backgroundPanelsList(i).Item1.BackColor = backgroundColor Then
                Else
                    Return False
                    Exit For
                End If
            End If
        Next
        Return True
    End Function
#End Region

#Region "przesowanie paneli"
    Private Sub movePattern()
        If secondLeftTop.BackColor = backgroundColor Then
            firstLeftTop.BackColor = backgroundColor
        Else
            firstLeftTop.BackColor = Color.FromArgb(255, secondLeftTop.BackColor)
        End If

        If secondLeftBottom.BackColor = backgroundColor Then
            firstLeftBottom.BackColor = backgroundColor
        Else
            firstLeftBottom.BackColor = Color.FromArgb(255, secondLeftBottom.BackColor)
        End If

        If secondRightTop.BackColor = backgroundColor Then
            firstRightTop.BackColor = backgroundColor
        Else
            firstRightTop.BackColor = Color.FromArgb(255, secondRightTop.BackColor)
        End If

        If secondRightBottom.BackColor = backgroundColor Then
            firstRightBottom.BackColor = backgroundColor
        Else
            firstRightBottom.BackColor = Color.FromArgb(255, secondRightBottom.BackColor)
        End If
    End Sub
#End Region


#Region "ramka wzoru"
    Private Sub Panel_1_Paint(sender As Object, e As PaintEventArgs) Handles firstLeftTop.Paint
        If Not firstLeftTop.BackColor = backgroundColor Then
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.DarkGray, ButtonBorderStyle.Solid)
        End If
    End Sub
    Private Sub Panel_2_Paint(sender As Object, e As PaintEventArgs) Handles firstLeftBottom.Paint
        If Not firstLeftBottom.BackColor = backgroundColor Then
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.DarkGray, ButtonBorderStyle.Solid)
        End If
    End Sub
    Private Sub Panel_3_Paint(sender As Object, e As PaintEventArgs) Handles firstRightTop.Paint
        If Not firstRightTop.BackColor = backgroundColor Then
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.DarkGray, ButtonBorderStyle.Solid)
        End If
    End Sub
    Private Sub Panel_4_Paint(sender As Object, e As PaintEventArgs) Handles firstRightBottom.Paint
        If Not firstRightBottom.BackColor = backgroundColor Then
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.DarkGray, ButtonBorderStyle.Solid)
        End If
    End Sub
    Private Sub secondLeftTop_Paint(sender As Object, e As PaintEventArgs) Handles secondLeftTop.Paint
        If Not secondLeftTop.BackColor = backgroundColor Then
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.LightGray, ButtonBorderStyle.Solid)
        End If
    End Sub
    Private Sub secondLeftBottom_Paint(sender As Object, e As PaintEventArgs) Handles secondLeftBottom.Paint
        If Not secondLeftBottom.BackColor = backgroundColor Then
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.LightGray, ButtonBorderStyle.Solid)
        End If
    End Sub
    Private Sub secondRightTop_Paint(sender As Object, e As PaintEventArgs) Handles secondRightTop.Paint
        If Not secondRightTop.BackColor = backgroundColor Then
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.LightGray, ButtonBorderStyle.Solid)
        End If
    End Sub
    Private Sub secondRightBottom_Paint(sender As Object, e As PaintEventArgs) Handles secondRightBottom.Paint
        If Not secondRightBottom.BackColor = backgroundColor Then
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.LightGray, ButtonBorderStyle.Solid)
        End If
    End Sub
#End Region


#Region "sprawdza czy sa w poblizy takie same kolory"

    Dim clearColorList As New List(Of Panel)

    Private Sub sameColors(ByVal loc1 As Integer, ByVal loc2 As Integer)

        'Sprawdzamy każdy kwadracik ułożonego wzoru
        checkAround(loc1, loc2)
        checkAround(loc1 + 1, loc2)
        checkAround(loc1, loc2 + 1)
        checkAround(loc1 + 1, loc2 + 1)

        'zerujemy kolory z listy,
        'lista zawiera tylko te pozycje które mają być wyzerowane
        For i As Integer = 0 To clearColorList.Count - 1
            clearColorList(i).BackColor = backgroundColor
        Next

        'sprawdzi ile jest wyjątkowych niepowtarzających się elementów
        'i doda tyle punktów
        points += clearColorList.Distinct.Count()

        labelPoints.Text = Math.Floor(points).ToString
        clearColorList.Clear()
    End Sub

    Private Sub checkAround(ByVal loc1 As Integer, ByVal loc2 As Integer)
        Dim MyPanelColor As Color
        Dim myPanel As New Panel

        'określamy parametry naszego elementu który będziemy sprawdzać
        'pobieramy jego kolor i jego samego
        For i As Integer = 0 To backgroundPanelsList.Count - 1
            If backgroundPanelsList(i).Item2 = loc1 And
                backgroundPanelsList(i).Item3 = loc2 Then
                MyPanelColor = backgroundPanelsList(i).Item1.BackColor
                myPanel = backgroundPanelsList(i).Item1
                Exit For
            End If
        Next

        'następnie jeśli nasz pobrany element ma kolor tła to nic nie będziemy robić
        'ponieważ był to element pusty
        If Not MyPanelColor = backgroundColor Then
            'najpierw sprawdzamy wszystkie opcje poziomo
            For i As Integer = loc1 - 1 To loc1 + 1
                'wykluczamy element środkowy
                If Not i = loc1 Then
                    'pobieramy kolor skrajnych elementów
                    For k As Integer = 0 To backgroundPanelsList.Count - 1
                        'sprawdzamy koordynaty czy się zgadzają
                        If backgroundPanelsList(k).Item2 = i And
                            backgroundPanelsList(k).Item3 = loc2 Then
                            'jeśli natrafimy na nasz element
                            If backgroundPanelsList(k).Item1.BackColor = MyPanelColor Then
                                'jeśli koroy się zgadzają
                                'dodajemy nasz panel do wyzerowania i element skrajny
                                clearColorList.Add(myPanel)
                                clearColorList.Add(backgroundPanelsList(k).Item1)
                            End If
                            'opuszczamy tą pętle aby nie tracić czasu
                            Exit For
                        End If
                    Next
                End If
            Next
            For i As Integer = loc2 - 1 To loc2 + 1
                If Not i = loc2 Then
                    For k As Integer = 0 To backgroundPanelsList.Count - 1
                        If backgroundPanelsList(k).Item2 = loc1 And
                            backgroundPanelsList(k).Item3 = i Then
                            If backgroundPanelsList(k).Item1.BackColor = MyPanelColor Then
                                clearColorList.Add(myPanel)
                                clearColorList.Add(backgroundPanelsList(k).Item1)
                            End If
                            Exit For
                        End If
                    Next
                End If
            Next
        End If
    End Sub
#End Region

End Class