Imports System
Imports System.Text

Module Program
    Sub Main()

        'Dim myString = "My ""so called"" life."
        'Dim myString = "What if I need" & vbNewLine & " a new line?"
        'Dim myString = "What if I need " & vbTab & "a tap in line"

        'Console.WriteLine("Hell0, {0}", "Bob")

        'Dim myString = String.Format("Hello, {0}", "Bob")

        'Dim myString = String.Format("Make: {2} {0} -- Model {1} -- Year: {2}",
        '                             "BMW",
        '                             "745li",
        '                             1995)

        'Dim myString = String.Format("{0:C}", 23.35) '{0:C} as Dollars cerrency

        'Dim myString As String = String.Format("{0:N}", 1234354778)

        'Dim myString As String = String.Format("{0:P}", 0.145)

        'Dim myString As String = String.Format("Phone (KH) : {0:(+###) ## ### ###}", 85510358336)

        'Dim myString As String = ""
        'For index = 1 To 100
        '    myString &= CStr(index) & "--"
        'Next

        'Dim myString As New StringBuilder

        'For index = 1 To 100
        '    myString.Append(CStr(index))
        '    myString.Append("--")
        'Next

        Dim myString = " Last summer we took threes across the board and this didn't. "
        'myString = myString.Substring(10,
        '                              15)

        'myString = myString.ToUpper()
        'myString = myString.ToLower()
        'myString = myString.Replace(" ", "--")
        'myString = String.Format("myString is {0} characters long. After trim {1} characters ", myString.Length, myString.Trim().Length)
        Console.WriteLine(myString)
        Console.ReadLine()



    End Sub
End Module
