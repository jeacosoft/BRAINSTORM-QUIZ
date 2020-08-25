Imports System.Data.SQLite
Public Class Form1
    Dim value As Integer = 30
    Dim accum As Integer = 1
    Dim n As Integer = 2
    Dim value2 As Integer = 10
    Private timeleft As Integer = 90
    Private randomizer As New Random


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Interval = 1000
        Timer2.Stop()
        GunaButtonRESUME.Visible = False
        GunaButtonPAUSE.Visible = False


        GunaRadioButtonA.Visible = False
        GunaRadioButtonB.Visible = False
        GunaRadioButtonC.Visible = False
        GunaRadioButtonD.Visible = False


    End Sub

    Private Sub GunaRadioButtonA_CheckedChanged(sender As Object, e As EventArgs) Handles GunaRadioButtonA.CheckedChanged
        'GunaTextBoxSCO.Text += 2







        Try
            Select Case GunaTextBoxQST.Text


                Case 1 And GunaRadioButtonA.Checked = True


                    GunaTextBoxSCO.Text = n

                Case 2 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 5 And GunaRadioButtonA.Checked = True

                    GunaTextBoxSCO.Text = n


                Case 8 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 10 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 20 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 22 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n

                Case 24 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 25 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 26 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 27 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 30 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n

                Case 33 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n

                Case 34 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n

                Case 44 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 46 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 47 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 49 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 52 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n

                Case 54 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 64 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n

                Case 66 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 69 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n

                Case 70 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 81 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 90 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 92 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 104 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 108 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 110 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 112 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 116 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 117 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
                Case 119 And GunaRadioButtonA.Checked = True
                    GunaTextBoxSCO.Text = n
            End Select
            n += 1
        Catch ex As Exception
        End Try
        Try


            If GunaRadioButtonA.Checked = False Then
                n -= 1
            End If
        Catch ex As Exception

        End Try

        If GunaRadioButtonA.Checked = True Or GunaRadioButtonB.Checked = True Or GunaRadioButtonC.Checked = True Or GunaRadioButtonD.Checked = True Then

            GunaRadioButtonD.Enabled = False
            GunaRadioButtonB.Enabled = False
            GunaRadioButtonC.Enabled = False
            

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' Dim anser As DialogResult = MessageBox.Show("Restart Game?")



        Try



            If timeleftlabel.Text = 0 Then
                Timer1.Enabled = False
                Timer2.Stop()
                MsgBox("Quiz is Over")
                value = 30
                GunaButton4.Text = "REPEAT"
                GunaButton4.Enabled = True
                   

                ' timeleftlabel.Text = timeleft & "seconds"
            Else
                timeleftlabel.Text = timeleftlabel.Text - 1



            End If
            '' If anser.OK Then
            ''Timer1.Start()

            ''Timer2.Start()

            '' Else

            '' End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ''2410
        If value = 2410 Then
            Timer2.Stop()



        Else
            value += 1

        End If
        Select Case value
            Case 31
                QUESTIONS.Labelsub.Show()

                Labelsub.Text = QUESTIONS.Labelsub.Text

                QUESTIONS.LabelTN1.Show()
            GunaTextBoxQST.Text = QUESTIONS.LabelNo1.Text
            GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN1.Text
            GunaRadioButtonA.Text = QUESTIONS.LabelOPT1.Text
            GunaRadioButtonB.Text = QUESTIONS.LabelOPT2.Text
            GunaRadioButtonC.Text = QUESTIONS.LabelOPT3.Text
            GunaRadioButtonD.Text = QUESTIONS.LabelOPT4.Text
            Case 50
                ' QUESTIONS.LabelTN1.Hide()
                QUESTIONS.LabelTN2.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN2.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo2.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT2_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT2_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT2_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT2_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

            Case 70


                QUESTIONS.LabelTN3.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN3.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo3.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT3_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT3_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT3_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT3_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

            Case 90


                QUESTIONS.LabelTN4.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN4.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo4.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT4_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT4_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT4_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT4_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False


                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 110


                QUESTIONS.LabelTN5.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN5.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo5.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT5_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT5_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT5_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT5_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 130


                QUESTIONS.LabelTN6.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN6.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo6.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT6_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT6_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT6_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT6_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 150


                QUESTIONS.LabelTN7.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN7.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo7.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT7_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT7_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT7_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT7_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False


                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 170


                QUESTIONS.LabelTN8.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN8.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo8.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT8_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT8_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT8_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT8_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False


                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 190


                QUESTIONS.LabelTN9.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN9.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo9.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT9_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT9_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT9_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT9_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 210


                QUESTIONS.LabelTN10.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN10.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo10.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT10_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT10_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT10_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT10_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 230


                QUESTIONS.LabelTN11.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN11.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo11.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT11_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT11_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT11_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT11_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 250


                QUESTIONS.LabelTN12.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN12.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo12.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT12_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT12_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT12_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT12_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 270


                QUESTIONS.LabelTN13.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN13.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo13.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT13_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT13_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT13_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT13_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 290


                QUESTIONS.LabelTN14.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN14.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo14.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT14_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT14_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT14_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT14_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 310


                QUESTIONS.LabelTN15.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN15.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo15.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT15_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT15_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT15_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT15_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 330


                QUESTIONS.LabelTN16.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN16.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo16.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT16_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT16_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT16_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT16_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 350


                QUESTIONS.LabelTN17.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN17.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo17.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT17_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT17_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT17_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT17_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False


                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 370


                QUESTIONS.LabelTN18.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN18.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo18.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT18_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT18_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT18_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT18_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 390


                QUESTIONS.LabelTN19.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN19.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo19.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT19_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT19_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT19_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT19_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 410


                QUESTIONS.LabelTN20.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN20.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo20.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT20_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT20_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT20_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT20_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 430


                QUESTIONS.LabelTN21.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN21.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo21.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT21_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT21_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT21_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT21_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 450


                QUESTIONS.LabelTN22.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN22.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo22.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT22_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT22_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT22_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT22_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 470


                QUESTIONS.LabelTN23.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN23.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo23.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT23_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT23_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT23_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT23_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 490


                QUESTIONS.LabelTN24.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN24.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo24.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT24_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT24_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT24_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT24_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 510


                QUESTIONS.LabelTN25.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN25.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo25.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT25_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT25_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT25_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT25_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 530


                QUESTIONS.LabelTN26.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN26.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo26.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT26_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT26_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT26_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT26_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 550


                QUESTIONS.LabelTN27.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN27.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo27.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT27_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT27_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT27_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT27_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 570


                QUESTIONS.LabelTN28.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN28.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo28.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT28_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT28_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT28_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT28_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 590


                QUESTIONS.LabelTN29.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN29.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo29.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT29_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT29_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT29_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT29_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 610


                QUESTIONS.LabelTN30.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN30.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo30.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT30_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT30_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT30_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT30_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 630


                QUESTIONS.LabelTN31.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN31.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo31.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT31_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT31_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT31_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT31_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False


                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 650


                QUESTIONS.LabelTN32.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN32.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo32.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT32_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT32_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT32_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT32_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 670


                QUESTIONS.LabelTN33.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN33.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo33.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT33_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT33_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT33_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT33_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 690


                QUESTIONS.LabelTN34.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN34.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo34.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT34_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT34_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT34_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT34_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
            Case 710


                QUESTIONS.LabelTN35.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN35.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo35.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT35_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT35_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT35_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT35_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True


            Case 730
                QUESTIONS.Labelsub2.Show()

                Labelsub.Text = QUESTIONS.Labelsub2.Text

                QUESTIONS.LabelTN36.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN36.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo36.Text

                        GunaRadioButtonA.Text = QUESTIONS.LabelOPT36_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.LabelOPT36_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.LabelOPT36_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.LabelOPT36_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()

            Case 750


                QUESTIONS.LabelTN37.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN37.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo37.Text

                        GunaRadioButtonA.Text = QUESTIONS.LabelOPT37_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.LabelOPT37_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.LabelOPT37_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.LabelOPT37_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 770


                QUESTIONS.LabelTN38.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN38.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo38.Text

                        GunaRadioButtonA.Text = QUESTIONS.LabelOPT38_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.LabelOPT38_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.LabelOPT38_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.LabelOPT38_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 790


                QUESTIONS.LabelTN39.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN39.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo39.Text

                        GunaRadioButtonA.Text = QUESTIONS.LabelOPT39_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.LabelOPT39_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.LabelOPT39_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.LabelOPT39_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 810


                QUESTIONS.LabelTN40.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN40.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo40.Text

                        GunaRadioButtonA.Text = QUESTIONS.LabelOPT40_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.LabelOPT40_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.LabelOPT40_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.LabelOPT40_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 830


                QUESTIONS.LabelTN41.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN41.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo41.Text

                        GunaRadioButtonA.Text = QUESTIONS.LabelOPT41_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.LabelOPT41_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.LabelOPT41_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.LabelOPT41_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 850


                QUESTIONS.LabelTN42.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN42.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo42.Text

                        GunaRadioButtonA.Text = QUESTIONS.LabelOPT42_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.LabelOPT42_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.LabelOPT42_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.LabelOPT42_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 870


                QUESTIONS.LabelTN43.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN43.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo43.Text

                        GunaRadioButtonA.Text = QUESTIONS.LabelOPT43_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.LabelOPT43_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.LabelOPT43_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.LabelOPT43_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 890


                QUESTIONS.LabelTN44.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN44.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo44.Text

                        GunaRadioButtonA.Text = QUESTIONS.LabelOPT44_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.LabelOPT44_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.LabelOPT44_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.LabelOPT44_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True


                        GunaRadioButtonD.Hide()
            Case 910


                QUESTIONS.LabelTN45.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN45.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo45.Text

                        GunaRadioButtonA.Text = QUESTIONS.LabelOPT45_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.LabelOPT45_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.LabelOPT45_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.LabelOPT45_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 930


                QUESTIONS.LabelTN46.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN46.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo46.Text

                        GunaRadioButtonA.Text = QUESTIONS.LabelOPT46_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.LabelOPT46_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.LabelOPT46_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.LabelOPT46_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 950


                QUESTIONS.LabelTN47.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN47.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo47.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT47_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT47_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT47_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT47_3.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 970


                QUESTIONS.LabelTN48.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN48.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo48.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT48_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT48_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT48_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT48_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True


                        GunaRadioButtonD.Hide()
            Case 990


                QUESTIONS.LabelTN49.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN49.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo49.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT49_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT49_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT49_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT49_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 1010


                QUESTIONS.LabelTN50.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN50.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo50.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT50_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT50_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT50_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT50_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 1030


                QUESTIONS.LabelTN51.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN51.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo51.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT51_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT51_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT51_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT51_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 1050


                QUESTIONS.LabelTN52.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN52.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo52.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT52_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT52_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT52_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT52_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 1070


                QUESTIONS.LabelTN53.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN53.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo53.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT53_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT53_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT53_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT53_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 1090


                QUESTIONS.LabelTN54.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN54.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo54.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT54_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT54_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT54_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT54_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 1110


                QUESTIONS.LabelTN55.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN55.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo55.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT55_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT55_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT55_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT55_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 1130


                QUESTIONS.LabelTN56.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN56.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo56.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT56_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT56_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT56_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT56_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 1150


                QUESTIONS.LabelTN57.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN57.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo57.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT57_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT57_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT57_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT57_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 1170


                QUESTIONS.LabelTN58.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN58.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo58.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT58_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT58_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT58_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT58_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 1190


                QUESTIONS.LabelTN59.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN59.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo59.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT59_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT59_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT59_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT59_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 1210


                QUESTIONS.LabelTN60.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN60.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo60.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT60_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT60_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT60_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT60_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()

            Case 1230



                QUESTIONS.LabelTN61.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN61.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo61.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT61_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT61_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT61_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT61_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 1250



                QUESTIONS.LabelTN62.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN62.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo62.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT62_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT62_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT62_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT62_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 1270



                QUESTIONS.LabelTN63.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN63.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo63.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT63_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT63_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT63_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT63_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 1290



                QUESTIONS.LabelTN64.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN64.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo64.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT64_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT64_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT64_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT64_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True


                        GunaRadioButtonD.Hide()
            Case 1310



                QUESTIONS.LabelTN65.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN65.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo61.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT65_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT65_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT65_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT65_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 1330



                QUESTIONS.LabelTN66.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN66.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo66.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT66_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT66_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT66_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT66_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 1350



                QUESTIONS.LabelTN67.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN67.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo67.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT67_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT67_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT67_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT67_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 1370



                QUESTIONS.LabelTN68.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN68.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo68.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT68_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT68_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT68_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT68_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True


                        GunaRadioButtonD.Hide()
            Case 1390



                QUESTIONS.LabelTN69.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN69.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo69.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT69_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT69_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT69_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT69_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                        GunaRadioButtonD.Hide()
            Case 1410



                QUESTIONS.LabelTN70.Show()
                        GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN70.Text
                        GunaTextBoxQST.Text = QUESTIONS.LabelNo70.Text

                        GunaRadioButtonA.Text = QUESTIONS.Label6LabelOPT70_1.Text
                        GunaRadioButtonB.Text = QUESTIONS.Label6LabelOPT70_2.Text
                        GunaRadioButtonC.Text = QUESTIONS.Label6LabelOPT70_3.Text
                        GunaRadioButtonD.Text = QUESTIONS.Label6LabelOPT70_4.Text

                        GunaRadioButtonA.Checked = False
                        GunaRadioButtonB.Checked = False
                        GunaRadioButtonC.Checked = False
                        GunaRadioButtonD.Checked = False

                        GunaRadioButtonD.Enabled = True
                        GunaRadioButtonB.Enabled = True
                        GunaRadioButtonC.Enabled = True
                        GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Hide()

            Case 1430
                QUESTIONS.Labelsub3.Show()

                Labelsub.Text = QUESTIONS.Labelsub3.Text

                QUESTIONS.LabelTN71.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN71.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo71.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT71_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT71_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT71_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT71_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True


                GunaRadioButtonD.Show()

            Case 1450
                QUESTIONS.LabelTN73.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN73.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo73.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT73_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT73_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT73_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT73_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

            Case 1470
                QUESTIONS.LabelTN74.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN74.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo74.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT74_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT74_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT74_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT74_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
                GunaRadioButtonD.Show()
            Case 1490
                QUESTIONS.LabelTN75.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN75.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo75.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT75_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT75_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT75_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT75_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

            Case 1510
                QUESTIONS.LabelTN76.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN76.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo76.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT76_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT76_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT76_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT76_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

            Case 1530
                QUESTIONS.LabelTN77.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN77.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo77.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT77_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT77_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT77_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT77_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
                GunaRadioButtonD.Show()
            Case 1550
                QUESTIONS.LabelTN78.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN78.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo78.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT7_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT78_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT78_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT78_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True


            Case 1570
                QUESTIONS.LabelTN79.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN79.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo74.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT79_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT79_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT79_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT79_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True


            Case 1590
                QUESTIONS.LabelTN80.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN80.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo80.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT80_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT80_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT80_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT80_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
                GunaRadioButtonD.Show()
            Case 1610
                QUESTIONS.LabelTN81.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN81.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo81.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT81_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT81_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT81_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT81_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True


            Case 1630
                QUESTIONS.LabelTN82.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN82.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo82.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT82_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT82_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT82_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT82_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

            Case 1650
                QUESTIONS.LabelTN83.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN83.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo83.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT83_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT83_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT83_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT83_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
                GunaRadioButtonD.Show()
            Case 1670
                QUESTIONS.LabelTN84.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN84.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo84.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT84_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT84_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT84_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT84_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

            Case 1690
                QUESTIONS.LabelTN85.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN85.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo83.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT85_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT85_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT85_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT85_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
                GunaRadioButtonD.Show()
            Case 1710
                QUESTIONS.LabelTN86.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN86.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo86.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT86_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT86_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT86_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT86_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
                GunaRadioButtonD.Show()
            Case 1730
                QUESTIONS.LabelTN87.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN87.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo87.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT87_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT87_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT87_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT87_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
                GunaRadioButtonD.Show()
            Case 1750
                QUESTIONS.LabelTN88.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN88.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo88.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT88_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT88_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT88_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT88_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
                GunaRadioButtonD.Show()
            Case 1770
                QUESTIONS.LabelTN89.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN89.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo89.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT89_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT89_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT89_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT89_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
                GunaRadioButtonD.Show()
            Case 1790
                QUESTIONS.LabelTN90.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN90.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo90.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT90_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT90_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT90_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT90_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()
            Case 1810
                QUESTIONS.LabelTN91.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN91.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo90.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT91_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT91_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT91_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT91_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
                GunaRadioButtonD.Show()
            Case 1830
                QUESTIONS.LabelTN92.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN92.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo92.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT92_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT92_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT92_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT92_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
                GunaRadioButtonD.Show()
            Case 1850
                QUESTIONS.LabelTN93.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN93.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo93.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT93_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT93_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT93_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT93_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
                GunaRadioButtonD.Show()
            Case 1870
                QUESTIONS.LabelTN94.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN94.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo94.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT94_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT94_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT94_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT94_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
                GunaRadioButtonD.Show()
            Case 1890
                QUESTIONS.LabelTN95.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN95.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo95.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT95_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT95_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT95_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT95_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
                GunaRadioButtonD.Show()
            Case 1910
                QUESTIONS.LabelTN96.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN96.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo96.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT96_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT96_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT96_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT96_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
                GunaRadioButtonD.Show()
            Case 1930
                QUESTIONS.LabelTN97.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN97.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo97.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT97_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT97_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT97_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT97_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
                GunaRadioButtonD.Show()

            Case 1950
                QUESTIONS.LabelTN98.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN98.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo98.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT98_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT98_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT98_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT98_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True
                GunaRadioButtonD.Show()
            Case 1970
                QUESTIONS.LabelTN99.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN99.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo99.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT99_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT99_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT99_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT99_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()

            Case 1990
                QUESTIONS.LabelTN100.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN100.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo100.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT100_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT100_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT100_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT100_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()




            Case 2010

                QUESTIONS.LabelSUB4.Show()

                Labelsub.Text = QUESTIONS.LabelSUB4.Text
                QUESTIONS.LabelTN101.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN101.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo101.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT101_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT101_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT101_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT101_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()


            Case 2030
                QUESTIONS.LabelTN102.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN102.Text
                GunaTextBoxQST.Text = QUESTIONS.Label102.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT102_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT102_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT102_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT102_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()



            Case 2050
                QUESTIONS.LabelTN103.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN103.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo103.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT103_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT103_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT103_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT103_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()



            Case 2070
                QUESTIONS.LabelTN104.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN104.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo104.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT104_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT104_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT104_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT104_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()


            Case 2090
                QUESTIONS.LabelTN105.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN105.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo105.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT105_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT105_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT105_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT105_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()



            Case 2110
                QUESTIONS.LabelTN106.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN106.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo106.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT106_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT106_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT106_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT106_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()



            Case 2130
                QUESTIONS.LabelTN107.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN107.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo107.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT107_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT107_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT107_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT107_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()

            Case 2150
                QUESTIONS.LabelTN108.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN108.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo108.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT108_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT108_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT108_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT108_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()

            Case 2170
                QUESTIONS.LabelTN109.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN109.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo109.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT109_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT109_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT109_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT109_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()

            Case 2190
                QUESTIONS.LabelTN110.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN110.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo110.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT110_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT110_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT110_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT110_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()

            Case 2210
                QUESTIONS.LabelTN111.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN111.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo111.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT111_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT111_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT111_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT111_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()
            Case 2230
                QUESTIONS.LabelTN112.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN112.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo112.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT112_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT112_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT112_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT112_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()

            Case 2250
                QUESTIONS.LabelTN113.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN113.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo113.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT113_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT113_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT113_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT113_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()

            Case 2270
                QUESTIONS.LabelTN114.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN114.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo114.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT114_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT114_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT114_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT114_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()

            Case 2290
                QUESTIONS.LabelTN115.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN115.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo115.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT115_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT115_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT115_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT115_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()

            Case 2310
                QUESTIONS.LabelTN116.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN116.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo116.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT116_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT116_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT116_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT116_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()


            Case 2330
                QUESTIONS.LabelTN117.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN117.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo117.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT117_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT117_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT117_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT117_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()

            Case 2350
                QUESTIONS.LabelTN118.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN118.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo118.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT118_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT118_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT118_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT118_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()


            Case 2370
                QUESTIONS.LabelTN119.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN119.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo119.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT119_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT119_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT119_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT119_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()

            Case 2390
                QUESTIONS.LabelTN120.Show()
                GunaTextBoxQTNDIP.Text = QUESTIONS.LabelTN120.Text
                GunaTextBoxQST.Text = QUESTIONS.LabelNo120.Text

                GunaRadioButtonA.Text = QUESTIONS.LabelOPT120_1.Text
                GunaRadioButtonB.Text = QUESTIONS.LabelOPT120_2.Text
                GunaRadioButtonC.Text = QUESTIONS.LabelOPT120_3.Text
                GunaRadioButtonD.Text = QUESTIONS.LabelOPT120_4.Text

                GunaRadioButtonA.Checked = False
                GunaRadioButtonB.Checked = False
                GunaRadioButtonC.Checked = False
                GunaRadioButtonD.Checked = False

                GunaRadioButtonD.Enabled = True
                GunaRadioButtonB.Enabled = True
                GunaRadioButtonC.Enabled = True
                GunaRadioButtonA.Enabled = True

                GunaRadioButtonD.Show()

        End Select
        If value = 1205 Then
            MsgBox("You have 20Mins left")

        ElseIf value = 301 Then
            MsgBox("You have 5Mins left")


        End If




    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Public Function getTime(Time As Integer) As String
        Dim Hrs As Integer
        Dim Min As Integer
        Dim Sec As Integer
        'Second
        Sec = Time Mod 60
        'Minutes
        Min = ((Time - Sec) / 60) Mod 60
        'Hours
        Hrs = ((Time - (Sec + (Min * 60))) / 3600) Mod 60

        Return Format(Hrs, "00") & ":" & Format(Min, "00") & ":" & Format(Sec, "00")

    End Function




    Private Sub ButtonSTP_Click(sender As Object, e As EventArgs)
        ' Timer2.Enabled = False
        ' Timer1.Enabled = False

    End Sub

    Private Sub ButtonPREV_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ButtonNXT_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GunaRadioButtonB_CheckedChanged(sender As Object, e As EventArgs) Handles GunaRadioButtonB.CheckedChanged
        Try

            Select Case GunaTextBoxQST.Text
                Case 4 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 11 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 14 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 15 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 17 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 23 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 28 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 35 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 36 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 39 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 40 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 43 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 45 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 48 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 50 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 51 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 56 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 58 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 59 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 61 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 62 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 67 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 68 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 69 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 75 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 77 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 82 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 83 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 84 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 86 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 88 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 89 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 91 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 101 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 105 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 111 And GunaRadioButtonB.Checked = True

                    GunaTextBoxSCO.Text = n















            End Select
            n += 1
        Catch ex As Exception

        End Try
        Try

                If GunaRadioButtonB.Checked = False Then
                n -= 1
            End If
            Catch ex As Exception

            End Try


        If GunaRadioButtonA.Checked = True Or GunaRadioButtonB.Checked = True Or GunaRadioButtonC.Checked = True Or GunaRadioButtonD.Checked = True Then

            GunaRadioButtonD.Enabled = False

            GunaRadioButtonC.Enabled = False
            GunaRadioButtonA.Enabled = False

        End If


    End Sub

    Private Sub GunaRadioButtonC_CheckedChanged(sender As Object, e As EventArgs) Handles GunaRadioButtonC.CheckedChanged



        Try


            Select Case GunaTextBoxQST.Text
                Case 3 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 6 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 7 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 12 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 16 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 18 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 19 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 21 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 29 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 31 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 37 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 38 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 41 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 42 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 53 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 55 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 57 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 60 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 63 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 65 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 73 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 74 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 76 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 78 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 85 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 87 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 93 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 106 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 113 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 114 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 120 And GunaRadioButtonC.Checked = True

                    GunaTextBoxSCO.Text = n









            End Select
            n += 1
        Catch
        End Try


        Try


            If GunaRadioButtonC.Checked = False Then
                n -= 1
            End If
        Catch ex As Exception

        End Try
        If GunaRadioButtonA.Checked = True Or GunaRadioButtonB.Checked = True Or GunaRadioButtonC.Checked = True Or GunaRadioButtonD.Checked = True Then

            GunaRadioButtonD.Enabled = False
            GunaRadioButtonB.Enabled = False

            GunaRadioButtonA.Enabled = False

        End If

    End Sub

    Private Sub GunaRadioButtonD_CheckedChanged(sender As Object, e As EventArgs) Handles GunaRadioButtonD.CheckedChanged

        Try
            Select Case GunaTextBoxQST.Text
                Case 9 And GunaRadioButtonD.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 13 And GunaRadioButtonD.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 71 And GunaRadioButtonD.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 72 And GunaRadioButtonD.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 79 And GunaRadioButtonD.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 80 And GunaRadioButtonD.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 100 And GunaRadioButtonD.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 102 And GunaRadioButtonD.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 103 And GunaRadioButtonD.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 107 And GunaRadioButtonD.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 109 And GunaRadioButtonD.Checked = True

                    GunaTextBoxSCO.Text = n

                Case 115 And GunaRadioButtonD.Checked = True

                    GunaTextBoxSCO.Text = n
                Case 118 And GunaRadioButtonD.Checked = True

                    GunaTextBoxSCO.Text = n









            End Select

            n += 1

        Catch ex As Exception

        End Try

        Try


            If GunaRadioButtonD.Checked = False Then
                n -= 1
            End If
        Catch ex As Exception

        End Try
        If GunaRadioButtonA.Checked = True Or GunaRadioButtonB.Checked = True Or GunaRadioButtonC.Checked = True Or GunaRadioButtonD.Checked = True Then


            GunaRadioButtonB.Enabled = False
            GunaRadioButtonC.Enabled = False
            GunaRadioButtonA.Enabled = False

        End If

    End Sub

    Private Sub ButtonSXT_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ButtonHELP_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub GunaButtonPAUSE_Click(sender As Object, e As EventArgs) Handles GunaButtonPAUSE.Click
        ' Timer1.Enabled = False
        Timer2.Enabled = False
        GunaButtonRESUME.Visible = True
        GunaButtonRESUME.Enabled = True
        GunaButtonPAUSE.Hide()

    End Sub

    Private Sub GunaButtonRESUME_Click(sender As Object, e As EventArgs) Handles GunaButtonRESUME.Click
        Timer1.Start()
        Timer2.Start()
        GunaButtonRESUME.Hide()
        GunaButtonPAUSE.Show()



    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        If GunaButton4.Text = "START" Then
            Timer1.Interval = 1000
            timeleftlabel.Text = "2410" '2410
            Timer2.Interval = 1000
            Timer2.Start()
            Timer1.Start()
            Label4.Visible = True
            ' ButtonNXT.Visible = True
            GunaButtonPAUSE.Visible = True
            GunaButtonRESUME.Enabled = False
            GunaButtonPAUSE.Enabled = True


            GunaRadioButtonA.Visible = True
            GunaRadioButtonB.Visible = True
            GunaRadioButtonC.Visible = True
            GunaRadioButtonD.Visible = True
            GunaButton4.Enabled = False
            GunaButton4.Text = "Good Luck!!"
        ElseIf GunaButton4.Text = "REPEAT" Then

            Timer1.Interval = 1000
            timeleftlabel.Text = "2410" '2410
            Timer2.Interval = 1000
            value = 30
            Timer2.Start()
            Timer1.Start()
            Label4.Visible = True
            ' ButtonNXT.Visible = True
            GunaButtonPAUSE.Visible = True
            GunaButtonRESUME.Enabled = False
            GunaButtonPAUSE.Enabled = True


            GunaRadioButtonA.Visible = True
            GunaRadioButtonB.Visible = True
            GunaRadioButtonC.Visible = True
            GunaRadioButtonD.Visible = True
            GunaButton4.Enabled = False
            GunaButton4.Text = "Good Luck!!"

        End If



    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        timeleftlabel.Text = "2410" '2410
        value = 30

        GunaTextBoxSCO.Text = "0"
        GunaRadioButtonA.Enabled = True
        GunaRadioButtonB.Enabled = True
        GunaRadioButtonC.Enabled = True
        GunaRadioButtonD.Enabled = True


        GunaRadioButtonA.Checked = False
        GunaRadioButtonB.Checked = False
        GunaRadioButtonC.Checked = False
        GunaRadioButtonD.Checked = False
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Timer1.Stop()
        Timer2.Stop()

        Dim ask As DialogResult
        ask = MessageBox.Show("Are you Sure you want to exit the Quiz", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        If ask = DialogResult.Cancel Then
            Timer1.Start()
            Timer2.Start()
        Else
            Application.Exit()
        End If

    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        MsgBox("This App is designed to help student study privately and to enhance their abilities in various academic field,for more enquiries please contact us jeacosoft@gmail.com or Contact Us on : +2348085189422, WhatsApp : +2347034965611", MsgBoxStyle.MsgBoxHelp)

    End Sub


End Class
