'Program Title:   Page Replacement Algorithm Simulator
'Programmers:     Marino, Adrian D.
'                 Ricafrente, Lyndie
'                 Santiago, Christian
'Date: December 6, 2019

Public Class Form1
    Dim ctrl As Integer = 0
    Dim rowcount As Integer = 0
    Dim victim As Integer
    Dim fctr(6), con(6) As Integer
    Dim temp(6) As Integer
    Dim hit As Boolean

    Private Sub cleartables()
        txtRefString.ReadOnly = False
        txtPageFrame.ReadOnly = False
        cboComparative.Enabled = True
        cboFifo.Enabled = True
        cboLRU.Enabled = True
        cboOptimal.Enabled = True
        dgvOne.Rows.Clear()
        dgvOne.Columns.Clear()
        dgvOne.DataSource = Nothing
        dgvTwo.Rows.Clear()
        dgvTwo.Columns.Clear()
        dgvTwo.DataSource = Nothing
        dgvThree.Rows.Clear()
        dgvThree.Columns.Clear()
        dgvThree.DataSource = Nothing
        Label13.Visible = False
        Label16.Visible = False
        Label19.Visible = False
        Label22.Visible = False
        Label25.Visible = False
        lblFIFOFaultRatio.Visible = False
        lblFIFOFaults.Visible = False
        lblFIFOHitRatio.Visible = False
        lblFIFOHits.Visible = False
        Label14.Visible = False
        Label17.Visible = False
        Label20.Visible = False
        Label23.Visible = False
        Label26.Visible = False
        lblLRUFaults.Visible = False
        lblLRUFaultRatio.Visible = False
        lblLRUHitRatio.Visible = False
        lblLRUHits.Visible = False
        Label15.Visible = False
        Label18.Visible = False
        Label21.Visible = False
        Label24.Visible = False
        Label27.Visible = False
        lblOptimalFaultRatio.Visible = False
        lblOptimalFaults.Visible = False
        lblOptimalHitRatio.Visible = False
        lblOptimalHits.Visible = False
    End Sub
    Private Sub addFIFOtable()
        Dim length As Integer = txtRefString.TextLength
        Dim pflength As Integer = Integer.Parse(txtPageFrame.Text)
        Dim s As String = txtRefString.Text
        Dim c As Char
        For ctr = 0 To length
            If ctr = 0 Then
                dgvOne.Columns.Add(ctr, "PF")
            Else
                c = GetChar(s, ctr)
                dgvOne.Columns.Add(ctr, c)
            End If
        Next
        For ctr = 1 To pflength
            dgvOne.Rows.Add()
            dgvOne.Rows(ctr - 1).Cells(0).Value = ctr
        Next
        dgvOne.Rows.Add()
        dgvOne.Rows(Val(txtPageFrame.Text)).Cells(0).Value = "R"
        btnSim.Enabled = False
        btnNext.Enabled = True
        btnFinish.Enabled = True
    End Sub

    Private Sub addLRUtable()
        Dim length As Integer = txtRefString.TextLength
        Dim pflength As Integer = Integer.Parse(txtPageFrame.Text)
        Dim s As String = txtRefString.Text
        Dim c As Char
        For ctr = 0 To length
            If ctr = 0 Then
                dgvTwo.Columns.Add(ctr, "PF")
            Else
                c = GetChar(s, ctr)
                dgvTwo.Columns.Add(ctr, c)
            End If
        Next
        For ctr = 1 To pflength
            dgvTwo.Rows.Add()
            dgvTwo.Rows(ctr - 1).Cells(0).Value = ctr
        Next
        dgvTwo.Rows.Add()
        dgvTwo.Rows(Val(txtPageFrame.Text)).Cells(0).Value = "R"
        btnSim.Enabled = False
        btnNext.Enabled = True
        btnFinish.Enabled = True
    End Sub

    Private Sub addOptimaltable()
        Dim length As Integer = txtRefString.TextLength
        Dim pflength As Integer = Integer.Parse(txtPageFrame.Text)
        Dim s As String = txtRefString.Text
        Dim c As Char
        For ctr = 0 To length
            If ctr = 0 Then
                dgvThree.Columns.Add(ctr, "PF")
            Else
                c = GetChar(s, ctr)
                dgvThree.Columns.Add(ctr, c)
            End If
        Next
        For ctr = 1 To pflength
            dgvThree.Rows.Add()
            dgvThree.Rows(ctr - 1).Cells(0).Value = ctr
        Next
        dgvThree.Rows.Add()
        dgvThree.Rows(Val(txtPageFrame.Text)).Cells(0).Value = "R"
        btnSim.Enabled = False
        btnNext.Enabled = True
        btnFinish.Enabled = True
    End Sub

    Private Sub ref()
        ctrl = 0
        For ctr As Integer = 0 To 5
            fctr(ctr) = 0
            con(ctr) = 0
            temp(ctr) = 0
        Next
        victim = 0
        rowcount = 0
    End Sub

    Private Sub refreshlist()
        txtRefString.Clear()
        btnSim.Enabled = False
        btnNext.Enabled = False
        btnFinish.Enabled = False
        ctrl = 0
        For ctr As Integer = 0 To 5
            fctr(ctr) = 0
            con(ctr) = 0
            temp(ctr) = 0
        Next
        victim = 0
        rowcount = 0
        lblFIFOFaultRatio.Visible = False
        lblFIFOFaults.Visible = False
        lblFIFOHitRatio.Visible = False
        lblFIFOHits.Visible = False
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        ctrl = 0
        refreshlist()
        cleartables()
        Dim rn, rl, rp As New Random
        Dim length As Integer = (rl.Next(8, 20))
        For ctr = 0 To length
            txtRefString.Text += (rn.Next(0, 9)).ToString
        Next
        txtPageFrame.Text = (rp.Next(3, 6))
        btnSim.Enabled = True
    End Sub

    Private Sub btnSim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSim.Click
        If cboComparative.Checked = True And (((cboFifo.Checked = True) And (cboLRU.Checked = True)) Or ((cboFifo.Checked = True) And (cboOptimal.Checked = True)) Or ((cboOptimal.Checked = True) And (cboLRU.Checked = True))) Then

            If cboFifo.Checked = True Then
                addFIFOtable()
            End If
            If cboLRU.Checked = True Then
                addLRUtable()
            End If
            If cboOptimal.Checked = True Then
                addOptimaltable()
            End If
            txtRefString.ReadOnly = True
            txtPageFrame.ReadOnly = True
            btnNext.Enabled = False
            cboComparative.Enabled = False
            cboFifo.Enabled = False
            cboLRU.Enabled = False
            cboOptimal.Enabled = False
            btnGenerate.Enabled = False


        ElseIf Not cboComparative.Checked = True And (((cboFifo.Checked = True) And (cboLRU.Checked = True)) Or ((cboFifo.Checked = True) And (cboOptimal.Checked = True)) Or ((cboOptimal.Checked = True) And (cboLRU.Checked = True))) Then
            MessageBox.Show("Check comparative to simulate 2 or more algorithm at once!", "System message")
        ElseIf cboFifo.Checked = True And cboComparative.Checked = False Then
            addFIFOtable()
            txtRefString.ReadOnly = True
            txtPageFrame.ReadOnly = True
            cboComparative.Enabled = False
            cboFifo.Enabled = False
            cboLRU.Enabled = False
            cboOptimal.Enabled = False

            btnGenerate.Enabled = False
        ElseIf cboLRU.Checked = True And cboComparative.Checked = False Then
            addLRUtable()
            txtRefString.ReadOnly = True
            txtPageFrame.ReadOnly = True
            cboComparative.Enabled = False
            cboFifo.Enabled = False
            cboLRU.Enabled = False
            cboOptimal.Enabled = False
            btnGenerate.Enabled = False
        ElseIf cboOptimal.Checked = True And cboComparative.Checked = False Then
            addOptimaltable()
            txtRefString.ReadOnly = True
            txtPageFrame.ReadOnly = True
            cboComparative.Enabled = False
            cboFifo.Enabled = False
            cboLRU.Enabled = False
            cboOptimal.Enabled = False
            btnGenerate.Enabled = False
        ElseIf cboComparative.Checked = False And cboFifo.Checked = False And cboLRU.Checked = False And cboOptimal.Checked = False Then
            MessageBox.Show("Must check an algorithm to simulate!", "System message")
        Else

            MessageBox.Show("Must check 2 or more algorithms for comparative!", "System message")
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshlist()
        cleartables()
    End Sub
    Private Sub fifodone()
        For counteryawa As Integer = ctrl To txtRefString.TextLength - 1
            ctrl += 1
            If rowcount >= Integer.Parse(txtPageFrame.Text) Then
                If Not dgvOne.Rows(0).Cells(1).Value Is Nothing Then
                    For ctr As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                        If Not dgvOne.Rows(ctr).Cells(ctrl - 1).Value Is Nothing Then
                            If dgvOne.Rows(ctr).Cells(ctrl - 1).Value = Integer.Parse(dgvOne.Columns(ctrl).HeaderText) Then
                                hit = True
                                dgvOne.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "H"
                                For ctr1 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                                    dgvOne.Rows(ctr1).Cells(ctrl).Value = dgvOne.Rows(ctr1).Cells(ctrl - 1).Value
                                    fctr(ctr1) += 1
                                Next
                                dgvOne.Columns(ctrl).DefaultCellStyle.BackColor = Color.Yellow
                                Exit For
                            End If
                        End If
                        hit = False
                    Next
                End If
                If hit = False Then
                    For ctr2 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                        If fctr(ctr2) = fctr.Max() Then
                            victim = ctr2
                        End If
                    Next
                    dgvOne.Rows(victim).Cells(ctrl - 1).Style.BackColor = Color.Red
                    dgvOne.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "F"
                    For ctr1 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1

                        dgvOne.Rows(ctr1).Cells(ctrl).Value = dgvOne.Rows(ctr1).Cells(ctrl - 1).Value
                        If ctr1 = victim Then
                            dgvOne.Rows(victim).Cells(ctrl).Value = Integer.Parse(dgvOne.Columns(ctrl).HeaderText)
                            Continue For
                        End If
                        fctr(ctr1) += 1
                    Next
                    fctr(victim) = 0
                End If


            Else
                If rowcount = 0 Then
                    rowcount += 1
                End If
                hit = False
                If Not dgvOne.Rows(0).Cells(1).Value Is Nothing Then
                    For ctr As Integer = 0 To rowcount - 1
                        If dgvOne.Rows(ctr).Cells(ctrl - 1).Value = Integer.Parse(dgvOne.Columns(ctrl).HeaderText) Then
                            dgvOne.Columns(ctrl).DefaultCellStyle.BackColor = Color.Yellow
                            hit = True
                            dgvOne.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "H"
                            Exit For
                        End If
                        If ctr = rowcount - 1 And hit = False Then
                            rowcount += 1
                            hit = False
                            Exit For
                        End If

                    Next
                End If
                If dgvOne.Rows(0).Cells(1).Value Is Nothing Then
                    dgvOne.Rows(0).Cells(1).Value = Integer.Parse(dgvOne.Columns(1).HeaderText)
                    fctr(0) += 1
                    dgvOne.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "F"
                ElseIf hit = True Then
                    For counter1 As Integer = 0 To rowcount - 1
                        dgvOne.Rows(counter1).Cells(ctrl).Value = dgvOne.Rows(counter1).Cells(ctrl - 1).Value
                        fctr(counter1) += 1
                    Next
                    dgvOne.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "H"
                Else
                    Dim counter1 As Integer
                    For counter1 = 0 To rowcount - 2
                        dgvOne.Rows(counter1).Cells(ctrl).Value = dgvOne.Rows(counter1).Cells(ctrl - 1).Value
                        fctr(counter1) += 1
                    Next
                    dgvOne.Rows(counter1).Cells(ctrl).Value = Integer.Parse(dgvOne.Columns(ctrl).HeaderText)
                    fctr(counter1) += 1
                    dgvOne.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "F"
                End If

            End If


            If ctrl = txtRefString.TextLength Then
                btnNext.Enabled = False
                btnFinish.Enabled = False
                Dim hitctr As Double = 0
                For cr As Integer = 0 To txtRefString.TextLength
                    If dgvOne.Columns(cr).DefaultCellStyle.BackColor = Color.Yellow Then
                        hitctr += 1
                    End If
                Next
                lblFIFOHits.Text = hitctr
                lblFIFOHitRatio.Text = Format(((hitctr / txtRefString.TextLength) * 100), "0.00")
                lblFIFOHitRatio.Text += " %"
                lblFIFOFaults.Text = txtRefString.TextLength - hitctr
                lblFIFOFaultRatio.Text = Format((100 - ((hitctr / txtRefString.TextLength) * 100)), "0.00")
                lblFIFOFaultRatio.Text += " %"
                Label13.Visible = True
                Label16.Visible = True
                Label19.Visible = True
                Label22.Visible = True
                Label25.Visible = True
                lblFIFOFaultRatio.Visible = True
                lblFIFOFaults.Visible = True
                lblFIFOHitRatio.Visible = True
                lblFIFOHits.Visible = True
            End If
        Next
    End Sub
    Private Sub fifoonce()
        ctrl += 1
        If rowcount >= Integer.Parse(txtPageFrame.Text) Then
            If Not dgvOne.Rows(0).Cells(1).Value Is Nothing Then
                For ctr As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                    If Not dgvOne.Rows(ctr).Cells(ctrl - 1).Value Is Nothing Then
                        If dgvOne.Rows(ctr).Cells(ctrl - 1).Value = Integer.Parse(dgvOne.Columns(ctrl).HeaderText) Then
                            MessageBox.Show("Page Hit", "System message")
                            dgvOne.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "H"
                            hit = True
                            For ctr1 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                                dgvOne.Rows(ctr1).Cells(ctrl).Value = dgvOne.Rows(ctr1).Cells(ctrl - 1).Value
                                fctr(ctr1) += 1
                            Next
                            dgvOne.Columns(ctrl).DefaultCellStyle.BackColor = Color.Yellow
                            Exit For

                        End If
                    End If
                    hit = False
                Next
            End If
            If hit = False Then
                For ctr2 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                    If fctr(ctr2) = fctr.Max() Then
                        victim = ctr2
                    End If
                Next
                MessageBox.Show(dgvOne.Rows(victim).Cells(ctrl - 1).Value.ToString + " is the victim page.", "System message")
                dgvOne.Rows(victim).Cells(ctrl - 1).Style.BackColor = Color.Red
                dgvOne.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "F"
                For ctr1 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1

                    dgvOne.Rows(ctr1).Cells(ctrl).Value = dgvOne.Rows(ctr1).Cells(ctrl - 1).Value
                    If ctr1 = victim Then
                        dgvOne.Rows(victim).Cells(ctrl).Value = Integer.Parse(dgvOne.Columns(ctrl).HeaderText)
                        Continue For
                    End If
                    fctr(ctr1) += 1
                Next
                fctr(victim) = 0
            End If


        Else
            If rowcount = 0 Then
                rowcount += 1
            End If
            hit = False
            If Not dgvOne.Rows(0).Cells(1).Value Is Nothing Then
                For ctr As Integer = 0 To rowcount - 1
                    If dgvOne.Rows(ctr).Cells(ctrl - 1).Value = Integer.Parse(dgvOne.Columns(ctrl).HeaderText) Then
                        MessageBox.Show("Page Hit", "System message")
                        dgvOne.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "H"
                        dgvOne.Columns(ctrl).DefaultCellStyle.BackColor = Color.Yellow
                        hit = True
                        Exit For
                    End If
                    If ctr = rowcount - 1 And hit = False Then
                        rowcount += 1
                        hit = False
                        Exit For
                    End If

                Next
            End If
            If dgvOne.Rows(0).Cells(1).Value Is Nothing Then
                dgvOne.Rows(0).Cells(1).Value = Integer.Parse(dgvOne.Columns(1).HeaderText)
                fctr(0) += 1
                dgvOne.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "F"
            ElseIf hit = True Then
                For counter1 As Integer = 0 To rowcount - 1
                    dgvOne.Rows(counter1).Cells(ctrl).Value = dgvOne.Rows(counter1).Cells(ctrl - 1).Value
                    fctr(counter1) += 1
                Next
                dgvOne.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "H"
            Else
                Dim counter1 As Integer
                For counter1 = 0 To rowcount - 2
                    dgvOne.Rows(counter1).Cells(ctrl).Value = dgvOne.Rows(counter1).Cells(ctrl - 1).Value
                    fctr(counter1) += 1
                Next
                dgvOne.Rows(counter1).Cells(ctrl).Value = Integer.Parse(dgvOne.Columns(ctrl).HeaderText)
                fctr(counter1) += 1
                dgvOne.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "F"
            End If

        End If


        If ctrl = txtRefString.TextLength Then
            btnNext.Enabled = False
            btnFinish.Enabled = False
            Dim hitctr As Integer = 0
            For cr As Integer = 0 To txtRefString.TextLength
                If dgvOne.Columns(cr).DefaultCellStyle.BackColor = Color.Yellow Then
                    hitctr += 1
                End If
            Next
            lblFIFOHits.Text = hitctr
            lblFIFOHitRatio.Text = Format(((hitctr / txtRefString.TextLength) * 100), "0.00")
            lblFIFOHitRatio.Text += " %"
            lblFIFOFaults.Text = txtRefString.TextLength - hitctr
            lblFIFOFaultRatio.Text = Format((100 - ((hitctr / txtRefString.TextLength) * 100)), "0.00")
            lblFIFOFaultRatio.Text += " %"
            Label13.Visible = True
            Label16.Visible = True
            Label19.Visible = True
            Label22.Visible = True
            Label25.Visible = True
            lblFIFOFaultRatio.Visible = True
            lblFIFOFaults.Visible = True
            lblFIFOHitRatio.Visible = True
            lblFIFOHits.Visible = True
        End If
    End Sub

    Private Sub lruonce()
        ctrl += 1
        If rowcount >= Integer.Parse(txtPageFrame.Text) Then
            If Not dgvTwo.Rows(0).Cells(1).Value Is Nothing Then
                For ctr As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                    If Not dgvTwo.Rows(ctr).Cells(ctrl - 1).Value Is Nothing Then
                        If dgvTwo.Rows(ctr).Cells(ctrl - 1).Value = Integer.Parse(dgvTwo.Columns(ctrl).HeaderText) Then
                            MessageBox.Show("Page Hit", "System message")
                            dgvTwo.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "H"
                            hit = True
                            For ctr1 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                                dgvTwo.Rows(ctr1).Cells(ctrl).Value = dgvTwo.Rows(ctr1).Cells(ctrl - 1).Value
                                fctr(ctr1) += 1
                            Next
                            fctr(ctr) = 0
                            dgvTwo.Columns(ctrl).DefaultCellStyle.BackColor = Color.Yellow
                            Exit For

                        End If
                    End If
                    hit = False
                Next
            End If
            If hit = False Then
                For ctr2 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                    If fctr(ctr2) = fctr.Max() Then
                        victim = ctr2
                    End If
                Next
                For ctr2 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1

                Next
                MessageBox.Show(dgvTwo.Rows(victim).Cells(ctrl - 1).Value.ToString + " is the victim page.", "System message")
                dgvTwo.Rows(victim).Cells(ctrl - 1).Style.BackColor = Color.Red
                dgvTwo.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "F"
                For ctr1 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1

                    dgvTwo.Rows(ctr1).Cells(ctrl).Value = dgvTwo.Rows(ctr1).Cells(ctrl - 1).Value
                    If ctr1 = victim Then
                        dgvTwo.Rows(victim).Cells(ctrl).Value = Integer.Parse(dgvTwo.Columns(ctrl).HeaderText)
                        Continue For
                    End If
                    fctr(ctr1) += 1
                Next
                fctr(victim) = 0
            End If


        Else
            If rowcount = 0 Then
                rowcount += 1
            End If
            hit = False
            If Not dgvTwo.Rows(0).Cells(1).Value Is Nothing Then
                For ctr As Integer = 0 To rowcount - 1
                    If dgvTwo.Rows(ctr).Cells(ctrl - 1).Value = Integer.Parse(dgvTwo.Columns(ctrl).HeaderText) Then
                        MessageBox.Show("Page Hit", "System message")
                        dgvTwo.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "H"
                        dgvTwo.Columns(ctrl).DefaultCellStyle.BackColor = Color.Yellow
                        hit = True
                        Exit For
                    End If
                    If ctr = rowcount - 1 And hit = False Then
                        rowcount += 1
                        hit = False
                        Exit For
                    End If

                Next
            End If
            If dgvTwo.Rows(0).Cells(1).Value Is Nothing Then
                dgvTwo.Rows(0).Cells(1).Value = Integer.Parse(dgvTwo.Columns(1).HeaderText)
                fctr(0) += 1
                dgvTwo.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "F"
            ElseIf hit = True Then
                For counter1 As Integer = 0 To rowcount - 1
                    dgvTwo.Rows(counter1).Cells(ctrl).Value = dgvTwo.Rows(counter1).Cells(ctrl - 1).Value
                    fctr(counter1) += 1
                    If dgvTwo.Rows(counter1).Cells(ctrl - 1).Value = Integer.Parse(dgvTwo.Columns(ctrl).HeaderText) Then
                        fctr(counter1) = 1
                    End If
                Next
                dgvTwo.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "H"
            Else
                Dim counter1 As Integer
                For counter1 = 0 To rowcount - 2
                    dgvTwo.Rows(counter1).Cells(ctrl).Value = dgvTwo.Rows(counter1).Cells(ctrl - 1).Value
                    fctr(counter1) += 1
                Next
                dgvTwo.Rows(counter1).Cells(ctrl).Value = Integer.Parse(dgvTwo.Columns(ctrl).HeaderText)
                fctr(counter1) += 1
                dgvTwo.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "F"
            End If

        End If


        If ctrl = txtRefString.TextLength Then
            btnNext.Enabled = False
            btnFinish.Enabled = False
            Dim hitctr As Integer = 0
            For cr As Integer = 0 To txtRefString.TextLength
                If dgvTwo.Columns(cr).DefaultCellStyle.BackColor = Color.Yellow Then
                    hitctr += 1
                End If
            Next
            lblLRUHits.Text = hitctr
            lblLRUHitRatio.Text = Format(((hitctr / txtRefString.TextLength) * 100), "0.00")
            lblLRUHitRatio.Text += " %"
            lblLRUFaults.Text = txtRefString.TextLength - hitctr
            lblLRUFaultRatio.Text = Format((100 - ((hitctr / txtRefString.TextLength) * 100)), "0.00")
            lblLRUFaultRatio.Text += " %"
            Label14.Visible = True
            Label17.Visible = True
            Label20.Visible = True
            Label23.Visible = True
            Label26.Visible = True
            lblLRUFaults.Visible = True
            lblLRUFaultRatio.Visible = True
            lblLRUHitRatio.Visible = True
            lblLRUHits.Visible = True
        End If
    End Sub

    Private Sub lrudone()
        For counteryawa As Integer = ctrl To txtRefString.TextLength - 1
            ctrl += 1
            If rowcount >= Integer.Parse(txtPageFrame.Text) Then
                If Not dgvTwo.Rows(0).Cells(1).Value Is Nothing Then
                    For ctr As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                        If Not dgvTwo.Rows(ctr).Cells(ctrl - 1).Value Is Nothing Then
                            If dgvTwo.Rows(ctr).Cells(ctrl - 1).Value = Integer.Parse(dgvTwo.Columns(ctrl).HeaderText) Then
                                hit = True
                                dgvTwo.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "H"
                                For ctr1 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                                    dgvTwo.Rows(ctr1).Cells(ctrl).Value = dgvTwo.Rows(ctr1).Cells(ctrl - 1).Value
                                    fctr(ctr1) += 1
                                Next
                                fctr(ctr) = 0
                                dgvTwo.Columns(ctrl).DefaultCellStyle.BackColor = Color.Yellow
                                Exit For
                            End If
                        End If
                        hit = False
                    Next
                End If
                If hit = False Then
                    For ctr2 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                        If fctr(ctr2) = fctr.Max() Then
                            victim = ctr2
                        End If
                    Next
                    dgvTwo.Rows(victim).Cells(ctrl - 1).Style.BackColor = Color.Red
                    dgvTwo.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "F"
                    For ctr1 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1

                        dgvTwo.Rows(ctr1).Cells(ctrl).Value = dgvTwo.Rows(ctr1).Cells(ctrl - 1).Value
                        If ctr1 = victim Then
                            dgvTwo.Rows(victim).Cells(ctrl).Value = Integer.Parse(dgvTwo.Columns(ctrl).HeaderText)
                            Continue For
                        End If
                        fctr(ctr1) += 1
                    Next
                    fctr(victim) = 0
                End If


            Else
                If rowcount = 0 Then
                    rowcount += 1
                End If
                hit = False
                If Not dgvTwo.Rows(0).Cells(1).Value Is Nothing Then
                    For ctr As Integer = 0 To rowcount - 1
                        If dgvTwo.Rows(ctr).Cells(ctrl - 1).Value = Integer.Parse(dgvTwo.Columns(ctrl).HeaderText) Then
                            dgvTwo.Columns(ctrl).DefaultCellStyle.BackColor = Color.Yellow
                            hit = True
                            dgvTwo.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "H"
                            Exit For
                        End If
                        If ctr = rowcount - 1 And hit = False Then
                            rowcount += 1
                            hit = False
                            Exit For
                        End If

                    Next
                End If
                If dgvTwo.Rows(0).Cells(1).Value Is Nothing Then
                    dgvTwo.Rows(0).Cells(1).Value = Integer.Parse(dgvTwo.Columns(1).HeaderText)
                    fctr(0) += 1
                    dgvTwo.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "F"
                ElseIf hit = True Then
                    For counter1 As Integer = 0 To rowcount - 1
                        dgvTwo.Rows(counter1).Cells(ctrl).Value = dgvTwo.Rows(counter1).Cells(ctrl - 1).Value
                        fctr(counter1) += 1
                        If dgvTwo.Rows(counter1).Cells(ctrl - 1).Value = Integer.Parse(dgvTwo.Columns(ctrl).HeaderText) Then
                            fctr(counter1) = 1
                        End If
                    Next
                    dgvTwo.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "H"
                Else
                    Dim counter1 As Integer
                    For counter1 = 0 To rowcount - 2
                        dgvTwo.Rows(counter1).Cells(ctrl).Value = dgvTwo.Rows(counter1).Cells(ctrl - 1).Value
                        fctr(counter1) += 1
                    Next
                    dgvTwo.Rows(counter1).Cells(ctrl).Value = Integer.Parse(dgvTwo.Columns(ctrl).HeaderText)
                    fctr(counter1) += 1
                    dgvTwo.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "F"
                End If

            End If


            If ctrl = txtRefString.TextLength Then
                btnNext.Enabled = False
                btnFinish.Enabled = False
                Dim hitctr As Double = 0
                For cr As Integer = 0 To txtRefString.TextLength
                    If dgvTwo.Columns(cr).DefaultCellStyle.BackColor = Color.Yellow Then
                        hitctr += 1
                    End If
                Next
                lblLRUHits.Text = hitctr
                lblLRUHitRatio.Text = Format(((hitctr / txtRefString.TextLength) * 100), "0.00")
                lblLRUHitRatio.Text += " %"
                lblLRUFaults.Text = txtRefString.TextLength - hitctr
                lblLRUFaultRatio.Text = Format((100 - ((hitctr / txtRefString.TextLength) * 100)), "0.00")
                lblLRUFaultRatio.Text += " %"
                Label14.Visible = True
                Label17.Visible = True
                Label20.Visible = True
                Label23.Visible = True
                Label26.Visible = True
                lblLRUFaults.Visible = True
                lblLRUFaultRatio.Visible = True
                lblLRUHitRatio.Visible = True
                lblLRUHits.Visible = True
            End If
        Next
    End Sub

    Private Sub optimalonce()

        ctrl += 1
        If rowcount >= Integer.Parse(txtPageFrame.Text) Then
            If Not dgvThree.Rows(0).Cells(1).Value Is Nothing Then
                For ctr As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                    If Not dgvThree.Rows(ctr).Cells(ctrl - 1).Value Is Nothing Then
                        If dgvThree.Rows(ctr).Cells(ctrl - 1).Value = Integer.Parse(dgvThree.Columns(ctrl).HeaderText) Then
                            MessageBox.Show("Page Hit", "System message")
                            dgvThree.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "H"
                            hit = True
                            For ctr1 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                                dgvThree.Rows(ctr1).Cells(ctrl).Value = dgvThree.Rows(ctr1).Cells(ctrl - 1).Value
                                fctr(ctr1) += 1
                            Next
                            dgvThree.Columns(ctrl).DefaultCellStyle.BackColor = Color.Yellow
                            Exit For

                        End If
                    End If
                    hit = False
                Next
            End If
            If hit = False Then
                Dim multi As Boolean = False
                Dim counter2 As Integer
                For counter As Integer = 0 To Val(txtPageFrame.Text) - 1
                    For counter2 = ctrl To txtRefString.TextLength
                        If dgvThree.Rows(counter).Cells(ctrl - 1).Value = Integer.Parse(dgvThree.Columns(counter2).HeaderText) Then
                            con(counter) = counter2
                            Exit For
                        End If
                        If counter2 = txtRefString.TextLength Then
                            con(counter) = txtRefString.TextLength + 1
                            Exit For
                        End If
                    Next
                Next
                For counter As Integer = 0 To Val(txtPageFrame.Text) - 2
                    For counter1 As Integer = counter + 1 To Val(txtPageFrame.Text) - 1
                        If con(counter) = con(counter1) Then
                            multi = True
                        End If
                    Next
                Next
                If multi = True Then
                    For ctr2 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                        If fctr(ctr2) = fctr.Max() And con(ctr2) = txtRefString.TextLength + 1 Then
                            victim = ctr2
                            Exit For

                        ElseIf ctr2 = Integer.Parse(txtPageFrame.Text) - 1 Then
                            For ct As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                                temp(ct) = fctr(ct)
                            Next
                            For i As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 2
                                For j As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 2 - i
                                    If (temp(j) > temp(j + 1)) Then
                                        Dim tempo As Integer = temp(j)
                                        temp(j) = temp(j + 1)
                                        temp(j + 1) = tempo
                                    End If
                                Next
                            Next
                            Dim temp2 As Integer = -1
                            For ct As Integer = Integer.Parse(txtPageFrame.Text) - 1 To 0 Step -1
                                For ct1 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                                    If temp(ct) = fctr(ct1) Then
                                        temp2 = ct1
                                        Exit For
                                    End If
                                Next
                                If con(temp2) = txtRefString.TextLength + 1 Then
                                    victim = temp2
                                    Exit For
                                End If
                            Next

                        End If

                    Next
                ElseIf ctrl = txtRefString.TextLength Then
                    For count As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                        If fctr(count) = fctr.Max() Then
                            victim = count
                        End If
                    Next
                Else
                    For ctr2 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                        If con(ctr2) = con.Max() Then
                            victim = ctr2
                        End If
                    Next

                End If
                MessageBox.Show(dgvThree.Rows(victim).Cells(ctrl - 1).Value.ToString + " is the victim page.", "System message")
                dgvThree.Rows(victim).Cells(ctrl - 1).Style.BackColor = Color.Red
                dgvThree.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "F"
                For ctr1 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                    dgvThree.Rows(ctr1).Cells(ctrl).Value = dgvThree.Rows(ctr1).Cells(ctrl - 1).Value
                    If ctr1 = victim Then
                        dgvThree.Rows(victim).Cells(ctrl).Value = Integer.Parse(dgvThree.Columns(ctrl).HeaderText)
                        Continue For
                    End If
                    fctr(ctr1) += 1
                Next
                fctr(victim) = 0
            End If


        Else
            If rowcount = 0 Then
                rowcount += 1
            End If
            hit = False
            If Not dgvThree.Rows(0).Cells(1).Value Is Nothing Then
                For ctr As Integer = 0 To rowcount - 1
                    If dgvThree.Rows(ctr).Cells(ctrl - 1).Value = Integer.Parse(dgvThree.Columns(ctrl).HeaderText) Then
                        MessageBox.Show("Page Hit", "System message")
                        dgvThree.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "H"
                        dgvThree.Columns(ctrl).DefaultCellStyle.BackColor = Color.Yellow
                        hit = True
                        Exit For
                    End If
                    If ctr = rowcount - 1 And hit = False Then
                        rowcount += 1
                        hit = False
                        Exit For
                    End If

                Next
            End If
            If dgvThree.Rows(0).Cells(1).Value Is Nothing Then
                dgvThree.Rows(0).Cells(1).Value = Integer.Parse(dgvThree.Columns(1).HeaderText)
                fctr(0) += 1
                dgvThree.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "F"
            ElseIf hit = True Then
                For counter1 As Integer = 0 To rowcount - 1
                    dgvThree.Rows(counter1).Cells(ctrl).Value = dgvThree.Rows(counter1).Cells(ctrl - 1).Value
                    fctr(counter1) += 1
                Next
                dgvThree.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "H"
            Else
                Dim counter1 As Integer
                For counter1 = 0 To rowcount - 2
                    dgvThree.Rows(counter1).Cells(ctrl).Value = dgvThree.Rows(counter1).Cells(ctrl - 1).Value
                    fctr(counter1) += 1
                Next
                dgvThree.Rows(counter1).Cells(ctrl).Value = Integer.Parse(dgvThree.Columns(ctrl).HeaderText)
                fctr(counter1) += 1
                dgvThree.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "F"
            End If

        End If


        If ctrl = txtRefString.TextLength Then
            btnNext.Enabled = False
            btnFinish.Enabled = False
            Dim hitctr As Integer = 0
            For cr As Integer = 0 To txtRefString.TextLength
                If dgvThree.Columns(cr).DefaultCellStyle.BackColor = Color.Yellow Then
                    hitctr += 1
                End If
            Next
            lblOptimalHits.Text = hitctr
            lblOptimalHitRatio.Text = Format(((hitctr / txtRefString.TextLength) * 100), "0.00")
            lblOptimalHitRatio.Text += " %"
            lblOptimalFaults.Text = txtRefString.TextLength - hitctr
            lblOptimalFaultRatio.Text = Format((100 - ((hitctr / txtRefString.TextLength) * 100)), "0.00")
            lblOptimalFaultRatio.Text += " %"
            Label15.Visible = True
            Label18.Visible = True
            Label21.Visible = True
            Label24.Visible = True
            Label27.Visible = True
            lblOptimalFaultRatio.Visible = True
            lblOptimalFaults.Visible = True
            lblOptimalHitRatio.Visible = True
            lblOptimalHits.Visible = True
        End If


    End Sub

    Private Sub optimaldone()
        For counteryawa As Integer = ctrl To txtRefString.TextLength - 1
            ctrl += 1
            If rowcount >= Integer.Parse(txtPageFrame.Text) Then
                If Not dgvThree.Rows(0).Cells(1).Value Is Nothing Then
                    For ctr As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                        If Not dgvThree.Rows(ctr).Cells(ctrl - 1).Value Is Nothing Then
                            If dgvThree.Rows(ctr).Cells(ctrl - 1).Value = Integer.Parse(dgvThree.Columns(ctrl).HeaderText) Then
                                dgvThree.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "H"
                                hit = True
                                For ctr1 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                                    dgvThree.Rows(ctr1).Cells(ctrl).Value = dgvThree.Rows(ctr1).Cells(ctrl - 1).Value
                                    fctr(ctr1) += 1
                                Next
                                dgvThree.Columns(ctrl).DefaultCellStyle.BackColor = Color.Yellow
                                Exit For

                            End If
                        End If
                        hit = False
                    Next
                End If
                If hit = False Then
                    Dim multi As Boolean = False
                    Dim counter2 As Integer
                    For counter As Integer = 0 To Val(txtPageFrame.Text) - 1
                        For counter2 = ctrl To txtRefString.TextLength
                            If dgvThree.Rows(counter).Cells(ctrl - 1).Value = Integer.Parse(dgvThree.Columns(counter2).HeaderText) Then
                                con(counter) = counter2
                                Exit For
                            End If
                            If counter2 = txtRefString.TextLength Then
                                con(counter) = txtRefString.TextLength + 1
                                Exit For
                            End If
                        Next
                    Next
                    For counter As Integer = 0 To Val(txtPageFrame.Text) - 2
                        For counter1 As Integer = counter + 1 To Val(txtPageFrame.Text) - 1
                            If con(counter) = con(counter1) Then
                                multi = True
                            End If
                        Next
                    Next
                    If multi = True Then
                        For ctr2 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                            If fctr(ctr2) = fctr.Max() And con(ctr2) = txtRefString.TextLength + 1 Then
                                victim = ctr2
                                Exit For

                            ElseIf ctr2 = Integer.Parse(txtPageFrame.Text) - 1 Then
                                For ct As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                                    temp(ct) = fctr(ct)
                                Next
                                For i As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 2
                                    For j As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 2 - i
                                        If (temp(j) > temp(j + 1)) Then
                                            Dim tempo As Integer = temp(j)
                                            temp(j) = temp(j + 1)
                                            temp(j + 1) = tempo
                                        End If
                                    Next
                                Next
                                Dim temp2 As Integer = -1
                                For ct As Integer = Integer.Parse(txtPageFrame.Text) - 1 To 0 Step -1
                                    For ct1 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                                        If temp(ct) = fctr(ct1) Then
                                            temp2 = ct1
                                            Exit For
                                        End If
                                    Next
                                    If con(temp2) = txtRefString.TextLength + 1 Then
                                        victim = temp2
                                        Exit For
                                    End If
                                Next

                            End If

                        Next
                    ElseIf ctrl = txtRefString.TextLength Then
                        For count As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                            If fctr(count) = fctr.Max() Then
                                victim = count
                            End If
                        Next
                    Else
                        For ctr2 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1
                            If con(ctr2) = con.Max() Then
                                victim = ctr2
                            End If
                        Next

                    End If
                    dgvThree.Rows(victim).Cells(ctrl - 1).Style.BackColor = Color.Red
                    dgvThree.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "F"
                    For ctr1 As Integer = 0 To Integer.Parse(txtPageFrame.Text) - 1

                        dgvThree.Rows(ctr1).Cells(ctrl).Value = dgvThree.Rows(ctr1).Cells(ctrl - 1).Value
                        If ctr1 = victim Then
                            dgvThree.Rows(victim).Cells(ctrl).Value = Integer.Parse(dgvThree.Columns(ctrl).HeaderText)
                            Continue For
                        End If
                        fctr(ctr1) += 1
                    Next
                    fctr(victim) = 0
                End If


            Else
                If rowcount = 0 Then
                    rowcount += 1
                End If
                hit = False
                If Not dgvThree.Rows(0).Cells(1).Value Is Nothing Then
                    For ctr As Integer = 0 To rowcount - 1
                        If dgvThree.Rows(ctr).Cells(ctrl - 1).Value = Integer.Parse(dgvThree.Columns(ctrl).HeaderText) Then
                            dgvThree.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "H"
                            dgvThree.Columns(ctrl).DefaultCellStyle.BackColor = Color.Yellow
                            hit = True
                            Exit For
                        End If
                        If ctr = rowcount - 1 And hit = False Then
                            rowcount += 1
                            hit = False
                            Exit For
                        End If

                    Next
                End If
                If dgvThree.Rows(0).Cells(1).Value Is Nothing Then
                    dgvThree.Rows(0).Cells(1).Value = Integer.Parse(dgvThree.Columns(1).HeaderText)
                    fctr(0) += 1
                    dgvThree.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "F"
                ElseIf hit = True Then
                    For counter1 As Integer = 0 To rowcount - 1
                        dgvThree.Rows(counter1).Cells(ctrl).Value = dgvThree.Rows(counter1).Cells(ctrl - 1).Value
                        fctr(counter1) += 1
                    Next
                    dgvThree.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "H"
                Else
                    Dim counter1 As Integer
                    For counter1 = 0 To rowcount - 2
                        dgvThree.Rows(counter1).Cells(ctrl).Value = dgvThree.Rows(counter1).Cells(ctrl - 1).Value
                        fctr(counter1) += 1
                    Next
                    dgvThree.Rows(counter1).Cells(ctrl).Value = Integer.Parse(dgvThree.Columns(ctrl).HeaderText)
                    fctr(counter1) += 1
                    dgvThree.Rows(Val(txtPageFrame.Text)).Cells(ctrl).Value = "F"
                End If

            End If


            If ctrl = txtRefString.TextLength Then
                btnNext.Enabled = False
                btnFinish.Enabled = False
                Dim hitctr As Integer = 0
                For cr As Integer = 0 To txtRefString.TextLength
                    If dgvThree.Columns(cr).DefaultCellStyle.BackColor = Color.Yellow Then
                        hitctr += 1
                    End If
                Next
                lblOptimalHits.Text = hitctr
                lblOptimalHitRatio.Text = Format(((hitctr / txtRefString.TextLength) * 100), "0.00")
                lblOptimalHitRatio.Text += " %"
                lblOptimalFaults.Text = txtRefString.TextLength - hitctr
                lblOptimalFaultRatio.Text = Format((100 - ((hitctr / txtRefString.TextLength) * 100)), "0.00")
                lblOptimalFaultRatio.Text += " %"
                Label15.Visible = True
                Label18.Visible = True
                Label21.Visible = True
                Label24.Visible = True
                Label27.Visible = True
                lblOptimalFaultRatio.Visible = True
                lblOptimalFaults.Visible = True
                lblOptimalHitRatio.Visible = True
                lblOptimalHits.Visible = True
            End If

        Next
    End Sub


    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If cboFifo.Checked = True Then
            fifoonce()
        End If

        If cboLRU.Checked = True Then
            lruonce()
        End If

        If cboOptimal.Checked = True Then
            optimalonce()
        End If
    End Sub

    Private Sub btnFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinish.Click
        If cboFifo.Checked = True Then
            ref()
            fifodone()
        End If

        If cboLRU.Checked = True Then
            ref()
            lrudone()
        End If

        If cboOptimal.Checked = True Then
            ref()
            optimaldone()
        End If
    End Sub

    Private Sub txtRefString_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRefString.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Invalid character!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub



    Private Sub txtRefString_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRefString.TextChanged
        If Not txtRefString.Text = "" Then
            lblLength.Text = txtRefString.TextLength
        Else
            lblLength.Text = ""
        End If
        If txtRefString.TextLength > 7 And txtPageFrame.Text <> "" Then
            btnSim.Enabled = True
        Else
            btnSim.Enabled = False
        End If
    End Sub

    Private Sub txtPageFrame_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPageFrame.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Invalid character!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtPageFrame_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPageFrame.LostFocus
        If Val(txtPageFrame.Text) < 2 Or Val(txtPageFrame.Text) > 6 Then
            MessageBox.Show("Invalid number of page frames")
            txtPageFrame.Text = ""
        End If
    End Sub





    Private Sub cboLRU_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboLRU.CheckedChanged
        If cboLRU.Checked = True Then
            cboLRU.ForeColor = Color.LightSkyBlue
        Else
            cboLRU.ForeColor = Color.RoyalBlue

        End If
    End Sub

    Private Sub cboComparative_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboComparative.CheckedChanged
        If cboComparative.Checked = True Then
            cboComparative.ForeColor = Color.LightSkyBlue
        Else
            cboComparative.ForeColor = Color.RoyalBlue

        End If
    End Sub

    Private Sub cboFifo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboFifo.CheckedChanged
        If cboFifo.Checked = True Then
            cboFifo.ForeColor = Color.LightSkyBlue
        Else
            cboFifo.ForeColor = Color.RoyalBlue

        End If
    End Sub

    Private Sub cboOptimal_CheckedChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles cboOptimal.CheckedChanged
        If cboOptimal.Checked = True Then
            cboOptimal.ForeColor = Color.LightSkyBlue
        Else
            cboOptimal.ForeColor = Color.RoyalBlue

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        cleartables()
        refreshlist()
        cboComparative.Checked = False
        cboLRU.Checked = False
        cboFifo.Checked = False
        cboOptimal.Checked = False
        lblLength.Text = ""
        txtPageFrame.Clear()
        txtRefString.Clear()
        btnGenerate.Enabled = True


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form2.Show()
    End Sub

    Private Sub txtPageFrame_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPageFrame.TextChanged
        If txtRefString.TextLength > 7 And txtPageFrame.Text <> "" And (Val(txtPageFrame.Text) <= 6 And Val(txtPageFrame.Text) > 0) Then
            btnSim.Enabled = True
        Else
            btnSim.Enabled = False
        End If
    End Sub
End Class
