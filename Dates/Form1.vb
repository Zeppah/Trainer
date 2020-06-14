Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '**************************
        '***** Date Data Type *****
        '**************************

        'A variable or constant of the Date data type holds both the date and the time
        Dim zerodate, firstdate, seconddate As Date

        'The default date is 1/1/0001 12:00:00 AM
        Label0.Text = zerodate.ToString

        'Date literals have to be surrounded by #'s.
        'The format is either month-day-year, or year/month/day
        'You can use either "/" or "-" as seperators (only). And, they have to be the same.
        'The display will be month/day/year 12:00:00 AM
        firstdate = #05-15-1955#
        seconddate = #1955-05-15#
        Label1.Text = firstdate.ToString
        Label2.Text = seconddate.ToString

        'To convert a Date literal to the format of your locale, 
        'or to a custom format, supply the literal to the Format function, 
        'specifying either a predefined Or user-defined date format. 
        'The following example demonstrates this.
        Dim datestrings As String
        datestrings = Format(#5/15/1955#, "dddd, d MMM yyyy")
        Label6.Text = datestrings

        'Alternatively, you can use one of the overloaded constructors of the DateTime structure 
        'to assemble a date and time value. The following example creates a value to represent 
        'May 31, 1993 at 12:14 in the afternoon.
        Dim dateInMay As New System.DateTime(1955, 5, 15, 5, 0, 0)
        Label9.Text = dateInMay.ToString

        'You can specify the time value in either 12-hour or 24-hour format, 
        'for example #1:15:30 PM# or #13:15:30#. However, if you do not specify
        'either the minutes Or the seconds, you must specify AM Or PM.
        Dim time1, time2 As Date
        time1 = #1:15:30 PM#
        time2 = #13:15:30#
        Label11.Text = time1.ToString
        Label13.Text = time2.ToString

        'If you do not include a date in a date/time literal, Visual Basic sets the date part 
        'of the value to January 1, 0001. If you do not include a time in a date/time literal, 
        'Visual Basic sets the time part of the value to the start of the day, that is, 
        'midnight (0:00:00).

        'If you convert a Date value to the String type, Visual Basic renders the date according 
        'to the short date format specified by the run-time locale, and it renders the time 
        'according to the time format (either 12-hour or 24-hour) specified by the run-time locale.

        '*****************************
        '***** DateAndTime Class *****
        '*****************************

        'The DateAndTime module contains the procedures and properties used in date and time operations.

        '***** PROPERTIES ***** There are six properties

        ' DateAndTime.DateString Property
        ' Returns Or sets a string value representing the current date according to your system.
        Label15.Text = DateString

        ' DateAndTime.TimeString Property
        ' Returns Or sets a string value representing the current time of day according to your system.
        Label22.Text = TimeString

        ' DateAndTime.Now Property
        ' Returns a value containing the current date and time according to your system.
        Label19.Text = Now.ToString

        ' DateAndTime.TimeOfDay Property
        ' Returns Or sets a Date value containing the current time of day according to your system.
        Label23.Text = TimeOfDay.ToString

        ' DateAndTime.Timer Property
        ' Returns a Double value representing the number of seconds elapsed since midnight.

        ' NOTE: The Timer property returns both the seconds and the milliseconds since the 
        ' most recent midnight. The seconds are in the integral part of the return value,
        ' and the milliseconds are in the fractional part.
        Label27.Text = Microsoft.VisualBasic.DateAndTime.Timer.ToString

        ' DateAndTime.Today Property
        ' Returns or sets a Date value containing the current date according to your system.
        Label25.Text = Today.ToString

        '***** METHODS ***** There are 24 Mehthods




    End Sub

    Private Sub DateAdd_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' DateAndTime.DateAdd Method: DateAdd(DateInterval, Double, DateTime) 
        ' Returns a Date value containing a date and time value to which a 
        ' specified time interval has been added.

        'The Interval argument can have one of the following settings.

        'Enumeration value 	    String 	    Unit of time interval to add

        'DateInterval.Day           d 	    Day; truncated to integral value
        'DateInterval.DayOfYear     y 	    Day; truncated to integral value
        'DateInterval.Hour          h 	    Hour; rounded to nearest millisecond
        'DateInterval.Minute        n 	    Minute; rounded to nearest millisecond
        'DateInterval.Month         m 	    Month; truncated to integral value
        'DateInterval.Quarter       q 	    Quarter; truncated to integral value
        'DateInterval.Second        s 	    Second; rounded to nearest millisecond
        'DateInterval.Weekday       w 	    Day; truncated to integral value
        'DateInterval.WeekOfYear    ww 	    Week; truncated to integral value
        'DateInterval.Year          yyyy 	Year; truncated to integral value

        Dim dateEntered As String =
        InputBox("Enter a date", DefaultResponse:=Date.Now.ToShortDateString)
        Dim monthsEntered As String =
        InputBox("Enter number of months to add", DefaultResponse:="12")

        Dim dateValue As Date = Date.Parse(dateEntered)
        Dim monthsValue As Integer = Integer.Parse(monthsEntered)

        ' Add the months to the date.
        Dim newDate As Date = DateAdd(DateInterval.Month, monthsValue, dateValue)

        ' This statement has a string interval argument, and
        ' is equivalent to the above statement.
        'Dim newDate As Date = DateAdd("m", monthsValue, dateValue)

        MessageBox.Show("New date: " & newDate.ToShortDateString)

    End Sub

    Private Sub DateAdd2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'DateAdd(String, Double, Object)

        Dim dateEntered As String =
        InputBox("Enter a date", DefaultResponse:=Date.Now.ToShortDateString)
        Dim monthsEntered As String =
        InputBox("Enter number of months to add", DefaultResponse:="12")

        Dim dateValue As Date = Date.Parse(dateEntered)
        Dim monthsValue As Integer = Integer.Parse(monthsEntered)

        ' Add the months to the date.
        Dim newDate As Date = DateAdd(DateInterval.Month, monthsValue, dateValue)

        ' This statement has a string interval argument, and
        ' is equivalent to the above statement.
        ' Dim newDate As Date = DateAdd("m", monthsValue, dateValue)

        MessageBox.Show("New date: " & newDate.ToShortDateString)
    End Sub

    Private Sub DateDiff_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'DateDiff(DateInterval.Day, date1, date2)

        'See line 106 for Interval settings...

        'The DayOfWeek argument can have one of the following settings.

        'Enumeration value 	        Value 	Description

        'FirstDayOfWeek.System      0 	    First day of week specified in system settings
        'FirstDayOfWeek.Sunday      1 	    Sunday (default)
        'FirstDayOfWeek.Monday      2 	    Monday (complies With ISO standard 8601, section 3.17)
        'FirstDayOfWeek.Tuesday     3 	    Tuesday
        'FirstDayOfWeek.Wednesday   4 	    Wednesday
        'FirstDayOfWeek.Thursday    5 	    Thursday
        'FirstDayOfWeek.Friday      6 	    Friday
        'FirstDayOfWeek.Saturday    7 	    Saturday

        'The WeekOfYear argument can have one of the following settings.

        'Enumeration value 	            Value 	Description

        'FirstWeekOfYear.System         0 	First week of year specified in system settings
        'FirstWeekOfYear.Jan1           1 	Week in which January 1 occurs (default)
        'FirstWeekOfYear.FirstFourDays  2 	Week that has at least four days In the New year (complies With ISO standard 8601, section 3.17)
        'FirstWeekOfYear.FirstFullWeek  3 	First full week in the New year


        Dim date2Entered As String = InputBox("Enter a date")

        Try
            Dim date2 As Date = Date.Parse(date2Entered)
            Dim date1 As Date = Now

            ' Determine the number of days between the two dates.
            Dim days As Long = DateDiff(DateInterval.Day, date1, date2)

            ' This statement has a string interval argument, and
            ' is equivalent to the above statement.
            'Dim days As Long = DateDiff("d", date1, date2)

            MessageBox.Show("Days from today: " & days.ToString)
        Catch ex As Exception
            MessageBox.Show("Invalid Date: " & ex.Message)
        End Try
    End Sub

    Private Sub DateDiff2(sender As Object, e As EventArgs) Handles Button4.Click
        'DateDiff(String, Object, Object, FirstDayOfWeek, FirstWeekOfYear) 

        Dim date2Entered As String = InputBox("Enter a date")

        Try
            Dim date2 As Date = Date.Parse(date2Entered)
            Dim date1 As Date = Now

            ' Determine the number of days between the two dates.
            Dim days As Long = DateDiff(DateInterval.Day, date1, date2)

            ' This statement has a string interval argument, and
            ' is equivalent to the above statement.
            'Dim days As Long = DateDiff("d", date1, date2)

            MessageBox.Show("Days from today: " & days.ToString)
        Catch ex As Exception
            MessageBox.Show("Invalid Date: " & ex.Message)
        End Try
    End Sub

    Private Sub DatePart_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'DatePart(DateInterval, DateTime, FirstDayOfWeek, FirstWeekOfYear) 

        'Returns an integer value containing the specified component of a given Date value.

        Dim DateString, Msg As String
        Dim ActualDate As Date
        ' Enter February 12, 2008, or 2/12/2008.
        DateString = InputBox("Enter a date:")
        ActualDate = CDate(DateString)

        ' The first two examples use enumeration values for the interval.
        Msg = "Quarter: " & DatePart(DateInterval.Quarter, ActualDate)
        ' The quarter is 1.
        MsgBox(Msg)
        Msg = "The day of the month: " & DatePart(DateInterval.Day, ActualDate)
        ' The day of the month is 12.
        MsgBox(Msg)

        ' The next two examples use string values for the interval parameter.
        Msg = "The week of the year: " & DatePart("ww", ActualDate)
        ' The week of the year is 7.
        MsgBox(Msg)
        Msg = "The day of the week: " & DatePart("w", ActualDate)
        ' The day of the week is 3 (Tuesday).
        MsgBox(Msg)
    End Sub

    Private Sub DatePart2_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'DatePart(String, Object, FirstDayOfWeek, FirstWeekOfYear) 

        Dim DateString, Msg As String
        Dim ActualDate As Date
        ' Enter February 12, 2008, or 2/12/2008.
        DateString = InputBox("Enter a date:")
        ActualDate = CDate(DateString)

        ' The first two examples use enumeration values for the interval.
        Msg = "Quarter: " & DatePart(DateInterval.Quarter, ActualDate)
        ' The quarter is 1.
        MsgBox(Msg)
        Msg = "The day of the month: " & DatePart(DateInterval.Day, ActualDate)
        ' The day of the month is 12.
        MsgBox(Msg)

        ' The next two examples use string values for the interval parameter.
        Msg = "The week of the year: " & DatePart("ww", ActualDate)
        ' The week of the year is 7.
        MsgBox(Msg)
        Msg = "The day of the week: " & DatePart("w", ActualDate)
        ' The day of the week is 3 (Tuesday).
        MsgBox(Msg)
    End Sub

    Private Sub DateSerial_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'DateSerial(Int32, Int32, Int32)

        'Returns a Date value representing a specified year, month, and day,
        'With the time information Set To midnight (00:00:00).

        ' DateSerial returns the date for a specified year, month, and day.
        Dim aDate As Date
        ' Variable aDate contains the date for February 12, 1969.
        aDate = DateSerial(1994, 1, 23)
        MsgBox(aDate)

        ' The following example uses DateSerial to determine and display
        ' the last day of the previous month.
        ' First, establish a starting date.
        Dim startDate = #1/23/1994#
        ' The 0 for the day represents the last day of the previous month.
        Dim endOfLastMonth = DateSerial(startDate.Year, startDate.Month, 0)
        MsgBox("Last day in the previous month: " & endOfLastMonth)

        ' The following example finds and displays the day of the week that the 
        ' 15th day of the following month will fall on.

        'The following code only works for console.writeline so I commented it out:

        'Dim fifteenthsDay = DateSerial(Today.Year, Today.Month + 1, 15)
        'Console.WriteLine("The 15th of next month is a {0}", fifteenthsDay.DayOfWeek)
    End Sub

    Private Sub DateValue_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'DateValue(String)
        'Returns a Date value containing the date information represented by a string, 
        'with the time information set to midnight (00:00:00).

        Dim oldDate As Date
        oldDate = DateValue("May 15, 1955")
        Label29.Text = oldDate.ToString
    End Sub

    Private Sub DayDateTime_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'Day(DateTime)

        'Returns an integer value from 1 through 31 representing the day of the month.

        Dim oldDate As Date
        Dim oldDay As Integer
        ' Assign a date using standard short format.
        oldDate = #5/15/1955#
        oldDay = Microsoft.VisualBasic.DateAndTime.Day(oldDate)
        ' oldDay now contains 12.
        Label30.Text = "from 5/15/1955 it is:" & oldDay.ToString
    End Sub

    Private Sub EqualsObject_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'Equals(Object)
        'Determines whether the specified object is equal to the current object.

        Dim objA, objB, objC As Object
        objA = My.User
        objB = New ApplicationServices.User
        objC = My.User
        MsgBox("objA different from objB? " & CStr(objA IsNot objB))
        MsgBox("objA identical to objC? " & CStr(objA Is objC))
    End Sub

    Private Sub GetType_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'GetType(object)
        'Gets the Type of the current instance.

        ' The following statement returns the Type object for Integer.
        MsgBox(GetType(Integer).ToString())
        ' The following statement returns the Type object for one-dimensional string arrays.
        MsgBox(GetType(String()).ToString())
    End Sub

    Private Sub HourDateTime_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'Hour(DateTime)
        'Returns an integer value from 0 through 23 representing the hour of the day.

        Dim someTime As Date
        Dim someHour As Integer
        someTime = #5:00:00 AM#
        someHour = Hour(someTime)
        ' someHour now contains 5.
        Label31.Text = someHour.ToString
    End Sub
End Class
