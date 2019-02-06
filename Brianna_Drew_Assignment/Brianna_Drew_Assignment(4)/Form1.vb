'
' This is a form that reads and sorts a .txt file.
'
' Written by: Brianna Drew (0622446) - March 2018
'
' Purpose: To read a text file from computer, read each line into program, bubble sort each line into either ascending or descending order (alphabetically).
'
' Parameters: None.
'
' Subroutine Required: The form itself loading has a subroutine as well as each button on the form has it's own subroutine. There is also a subroutine
'                      called from either the "Ascending Order" or "Descending Order" button click subroutines to add the items to the desgnated list
'                      box after they have been bubble sorted.
'
' Modifications: - March 11/18 - Program started, entire program written other than the comments.
'                - March 27/18 - Comments added.
'                - March 31/18 - Re-did bubble sorts to be "true" bubble sort, comments updated.
'                - April 4/18 - Final comments added.

Public Class Form1


    ' This section of code defines the variables required (at class-level).
    Dim NameLine(0 To 100) As String ' Definition for variable (string array) that will hold each line read from the text file (up to 100 items).
    Dim counter As Integer = 99 ' Definition for variable that will count how many lines are being read from the text file.


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This subroutine runs when the form (program) first loads.

        AscendButton.Enabled = False ' The button to sort the items read in from the text file in ascending order is disabled to start because the file
        ' has not been read in yet.
        DescendButton.Enabled = False ' The button to sort the items read in from the text file in descending order is disabled to start because the file
        ' has not been read in yet.

    End Sub


    Private Sub ReadButton_Click(sender As Object, e As EventArgs) Handles ReadButton.Click
        ' This subroutine runs when the "Read in names.txt" button is clicked.

        UnsortedList.Items.Clear() ' Clear the list box that holds the unsorted items read from the text file.

        counter = 0 ' Initialize the counter variable to 0 for this specific subroutine.
        Dim Filename As String ' Definition for variable that will hold the location of the text file.
        Dim End_of_File = -1 ' Definition for variable that holds the how many items in the text file remain when nothing actually remains (when it
        ' reaches the end of the text file).
        Dim Good_Filename As Boolean ' Definition for variable that will hold whether or not the file name exists.
        Dim InputFile As System.IO.StreamReader ' Defintion for variable that will hold the text file to be read.

        Filename = "C:\\Brianna_Drew_Assignment(4)\names.txt" ' Specifying the the location of the text file and assigning the path to the appropriate
        ' variable.
        Good_Filename = System.IO.File.Exists(Filename) ' Checking to see if the file name (path) exists, and will return a boolean as the result and
        ' assign it to the appropriate variable.

        If (Not Good_Filename) Then ' If the file given does not exist, then...
            UnsortedList.Items.Add("The selected file does not exist:") ' Add an error message to the Unsorted list box.
            UnsortedList.Items.Add("Name: " & Filename) ' Show the name (path) of the file given in the Unsorted list box.
        End If

        InputFile = My.Computer.FileSystem.OpenTextFileReader("C:\\Brianna_Drew_Assignment(4)\names.txt") ' Open the specified file and name it under 
        ' the variable "InputFile".

        Do While InputFile.Peek <> End_of_File ' Run the following code until there is no lines of text remaining in the text file.
            NameLine(counter) = InputFile.ReadLine ' Assign the current line from the text file to the counter index in the NameLine array.
            UnsortedList.Items.Add(NameLine(counter)) ' Add the item from the array to the Unsorted list box.
            counter = counter + 1 ' Add 1 to the counter (so the next line in the file can be assigned to the next place in the NameLine array).
        Loop

        AscendButton.Enabled = True ' Enable the "Ascending Order" button now that there are items read from text file to be able to be sorted.
        DescendButton.Enabled = True ' Enable the "Descending Order" button now that there are items read from text file to be able to be sorted.

        InputFile.Close() ' Close the text file.

    End Sub


    Private Sub AscendButton_Click(sender As Object, e As EventArgs) Handles AscendButton.Click
        ' This subroutine runs when the "Ascending Order" button is clicked.

        Dim k, j As Integer
        Dim tempname As String

        ''''BUBBLE SORT''''
        For k = 2 To counter ' Go through the all the items in the NameLine array the appropriate number of times...
            For j = 0 To (counter - k) ' Go through all the items in the NameLine array and...
                If NameLine(j) > NameLine(j + 1) Then ' If the current item in the array is alphabetically greater than the following item, then...
                    tempname = NameLine(j + 1) ' Assign the item following the current item in the array to a "temporary" variable.
                    NameLine(j + 1) = NameLine(j) ' Assign the current item in the array to the original place of the item that was following the current
                    ' item in the array.
                    NameLine(j) = tempname ' Assign the item that was following the current item (now in the temporary variable) to the place in the array
                    ' in which the current item was.
                    ' Basically, if the name is "greater" than the name after it (alphabetically), they switch places in the array.
                End If
            Next j
        Next k

        DisplayNames() ' Call the DisplayNames subroutine to add the sorted items to the Sorted list box.

    End Sub


    Private Sub DescendButton_Click(sender As Object, e As EventArgs) Handles DescendButton.Click
        ' This subroutine runs when the "Descending Order" button is clicked.

        Dim k, j As Integer ' Definition for variables that will serve as other counters (to be starting points in the following for loops).
        Dim tempname As String

        ''''BUBBLE SORT''''
        For k = 1 To counter ' Go through the all the items in the NameLine array the appropriate number of times...
            For j = 0 To (counter - k) ' Go through all the items in the NameLine array and...
                If NameLine(j) < NameLine(j + 1) Then ' If the current item in the array is alphabetically less than the following item, then...
                    tempname = NameLine(j) ' Assign the current item in the array to a "temporary" variable.
                    NameLine(j) = NameLine(j + 1) ' Assign the item that was following the current item in the array to the original place of the current
                    ' item in the array.
                    NameLine(j + 1) = tempname ' Assign the current item (now in the temporary variable) to the place in the array in which the item
                    ' following the current item was.
                    ' Basically, if the name is "less" than the name after it (alphabetically), they switch places in the array. 
                End If
            Next j
        Next k

        DisplayNames() ' Call the DisplayNames subroutine to add the sorted items to the Sorted list box.

    End Sub

    Sub DisplayNames()
        ' This subroutine runs when it is called by either the AscendButton_Click method or the DescendButton_Click method to add the items to the 
        ' sorted list box after they have been sorted alphabetically via bubble sort.

        SortedList.Items.Clear() ' Clear the list box that holds the items read from the text file after they have been sorted.

        Dim counter1 As Integer ' Definition for variable that will serve as another counter (to be a starting point in the following for loop).

        For counter1 = 0 To (counter - 1) ' Go through all the items in the NameLine array and...
            SortedList.Items.Add(NameLine(counter1)) ' add them each to the Sorted 
        Next

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' This subroutine runs when the "Exit" button is clicked.

        Me.Close() ' Closes the program.

    End Sub


End Class
