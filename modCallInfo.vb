Module modCallInfo


    'CallList is a list of calls, each call is a list of 3 strings: Time/Date, Number/Name, Action
    Public Function GetCallList2(sourceString As String) As List(Of List(Of String))



        Dim CallList As New List(Of List(Of String))




        Dim i As Integer = sourceString.IndexOf("<td class=""time"">")
        If i < 0 Then Return CallList


        Dim i2 As Integer = sourceString.IndexOf("</td>", i)
        Dim t As String = sourceString.Substring(i, i2 - i)

        i = sourceString.IndexOf("<td class=""phoneno"">", i2)
        i2 = sourceString.IndexOf("</td>", i)

        Dim pn As String = sourceString.Substring(i, i2 - i)
        Dim DT As DateTime = Date.MinValue
        Dim time As String = GetBold(t).Trim
        Dim Datex As String = GetTxtBetween(t, "</span>", "").Trim
        Dim phone As String = GetBold(pn).Trim
        Dim Namex As String = GetTxtBetween(pn, "<i>", "</i>").Trim

        'ACTION
        i = sourceString.IndexOf("<span class=""badge", i2)
        i = sourceString.IndexOf(">", i) + 1
        i2 = sourceString.IndexOf("</span>", i)
        Dim Action As String = sourceString.Substring(i, i2 - i).Trim

        ' Messages Waiting looks like this.
        '        <div Class="container m-2">
        '  <Button id = "new-messages" type="button" Class="btn btn-secondary">
        '    <i>New Messages Waiting </i><span Class="badge badge-primary"><span id="total-unplayed">1</span>
        '  </button>
        '</div>


        Dim lst As New List(Of String)
        lst.Add(time & vbCrLf & Datex)
        lst.Add(phone & vbCrLf & Namex)
        lst.Add(Action)
        CallList.Add(lst)

        Return CallList
    End Function




    ''' <summary>
    ''' 'convert   list of strings into the class callinfo.
    ''' CallList is a list of 3 strings, Time/Date, Number/Name, Action
    ''' </summary>
    ''' <param name="callist"></param>
    ''' <returns></returns> 
    Public Function GetLastCall(callist As List(Of List(Of String))) As CallInfo

        If callist Is Nothing OrElse callist.Count = 0 Then
            Return New CallInfo
        End If


        Dim CI As New CallInfo


        Dim lst As List(Of String) = callist(0)

        'TIME
        Dim T As String = lst(0)
        Dim tt() As String = T.Split(vbLf)
        Dim time As String = tt(0).Trim



        Dim ss As String() = Split(tt(tt.Count - 1), "-")
        Dim sDate As String = ""

        If ss.Count = 3 Then

            sDate = "20" & ss(2).Trim & "-"
            Dim m As String = "01"
            Select Case ss(1)
                Case "Jan" : m = "01"
                Case "Feb" : m = "02"
                Case "Mar" : m = "03"
                Case "Apr" : m = "04"
                Case "May" : m = "05"
                Case "Jun" : m = "06"
                Case "Jul" : m = "07"
                Case "Aug" : m = "08"
                Case "Sep" : m = "09"
                Case "Oct" : m = "10"
                Case "Nov" : m = "11"
                Case "Dec" : m = "12"
            End Select
            sDate &= m & "-"
            sDate &= ss(0).Trim
            DateTime.TryParse(time & " " & sDate, CI.CallTime)

        End If
        'Name



        Dim uu() As String = Split(lst(1).Trim, vbLf)
        CI.Number = uu(0).Trim
        For i As Integer = 1 To uu.Count - 1
            Dim u As String = uu(i).Trim
            If u.Trim.Length = 0 Then Continue For
            CI.Caller &= u.Trim & vbCrLf
        Next
        CI.Caller = CI.Caller.Trim
        'If uu.Count = 3 Then
        '    CI.Caller = uu(2).Trim
        'End If

        'Action
        CI.Action = lst(2)

        Return CI

    End Function


    'Public Function GetCallList(sourceString As String) As List(Of List(Of String))



    '    Dim url As String = My.Settings.CallAttendantURL.Trim
    '    If url.Length = 0 Then Throw New Exception("Set CallAttendantURL in settings.")


    '    Dim doc As New HtmlAgilityPack.HtmlDocument
    '    doc.LoadHtml(sourceString)
    '    Dim Tbl = doc.GetElementbyId("recent-calls")
    '    'Dim tbl = doc.DocumentNode.SelectSingleNode("//recent-calls")

    '    Dim CallList As New List(Of List(Of String))

    '    For Each N In Tbl.ChildNodes

    '        If N.Name = "tbody" Then
    '            For Each N2 In N.ChildNodes

    '                If N2.Name = "tr" Then
    '                    Dim lst As New List(Of String)
    '                    For Each N3 In N2.ChildNodes

    '                        If N3.Name = "td" Then
    '                            Dim s1 As String = N3.Name
    '                            Dim s2 As String = N3.InnerHtml
    '                            Dim s3 As String = N3.InnerText
    '                            lst.Add(N3.InnerText.Trim)
    '                        End If

    '                    Next
    '                    CallList.Add(lst)
    '                End If
    '            Next

    '        End If
    '    Next
    '    Return CallList
    'End Function



    'Public Function GetLastCallx() As CallInfo


    '    Dim CI As New CallInfo



    '    Dim url As String = My.Settings.CallAttendantURL.Trim
    '    If url.Length = 0 Then Throw New Exception("Set CallAttendantURL in settings.")

    '    Dim sourceString As String = New System.Net.WebClient().DownloadString(url)
    '    If sourceString.Contains("The modem is not online.") Then Throw New Exception("The modem is not online.")

    '    Dim doc As New HtmlAgilityPack.HtmlDocument
    '    doc.LoadHtml(sourceString)
    '    Dim Tbl = doc.GetElementbyId("recent-calls")
    '    'Dim tbl = doc.DocumentNode.SelectSingleNode("//recent-calls")

    '    Dim CallList As New List(Of List(Of String))

    '    For Each N In Tbl.ChildNodes

    '        If N.Name = "tbody" Then
    '            For Each N2 In N.ChildNodes

    '                If N2.Name = "tr" Then
    '                    Dim lst As New List(Of String)
    '                    For Each N3 In N2.ChildNodes

    '                        If N3.Name = "td" Then
    '                            Dim s1 As String = N3.Name
    '                            Dim s2 As String = N3.InnerHtml
    '                            Dim s3 As String = N3.InnerText
    '                            lst.Add(N3.InnerText.Trim)
    '                        End If

    '                    Next
    '                    CallList.Add(lst)
    '                End If
    '            Next

    '        End If
    '    Next



    '    Dim j1 As Integer
    '    Dim j2 As Integer
    '    j1 = sourceString.IndexOf("<tr class=")
    '    j2 = sourceString.IndexOf("</tr>", j1)

    '    Dim RowData As String = sourceString.Substring(j1, j2 - j1)




    '    Dim i As Integer = sourceString.IndexOf("<td class=""time"">")
    '    If i < 0 Then Return Nothing

    '    Dim i2 As Integer = sourceString.IndexOf("</td>", i)
    '    Dim t As String = sourceString.Substring(i, i2 - i)

    '    i = sourceString.IndexOf("<td class=""phoneno"">", i2)
    '    i2 = sourceString.IndexOf("</td>", i)

    '    Dim pn As String = sourceString.Substring(i, i2 - i)
    '    Dim DT As DateTime = Date.MinValue
    '    Dim time As String = GetTxtBetween(t, "<b>", "</b>").Trim
    '    Dim Datex As String = GetTxtBetween(t, "</span>", "").Trim
    '    Dim ss As String() = Split(Datex, "-")
    '    Dim sDate As String = ""

    '    If ss.Count = 3 Then
    '        sDate = "20" & ss(2) & "-"
    '        Dim m As String = "01"
    '        Select Case ss(1)
    '            Case "Jan" : m = "01"
    '            Case "Feb" : m = "02"
    '            Case "Mar" : m = "03"
    '            Case "Apr" : m = "04"
    '            Case "May" : m = "05"
    '            Case "Jun" : m = "06"
    '            Case "Jul" : m = "07"
    '            Case "Aug" : m = "08"
    '            Case "Sep" : m = "09"
    '            Case "Oct" : m = "10"
    '            Case "Nov" : m = "11"
    '            Case "Dec" : m = "12"
    '        End Select
    '        sDate &= m & "-"
    '        sDate &= ss(0)
    '        DateTime.TryParse(time & " " & sDate, DT)

    '    End If

    '    Dim phone As String = GetTxtBetween(pn, "<b>", "</b>").Trim
    '    Dim Namex As String = GetTxtBetween(pn, "<i>", "</i>").Trim

    '    CI.Caller = Namex
    '    CI.Number = phone


    '    Dim Sout As String = ""
    '    If DT > Date.MinValue Then
    '        CI.CallTime = DT
    '    End If


    '    Return CI


    'End Function




    Private Function GetBold(txt As String) As String
        Return GetTxtBetween(txt, "<b>", "</b>")

    End Function
    Private Function GetTxtBetween(txt As String, txtStart As String, txtEnd As String) As String
        Dim i As Integer = txt.IndexOf(txtStart)
        If i < 0 Then Return ""
        If txtEnd.Length = 0 Then
            Return txt.Substring(i + txtStart.Length)
        End If

        Dim i2 As Integer = txt.IndexOf(txtEnd)
        If i2 < 0 Then Return ""

        Return txt.Substring(i + txtStart.Length, i2 - i - txtStart.Length)



    End Function

End Module
