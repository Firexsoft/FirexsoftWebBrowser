Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.GoHome()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser1.Stop()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.ScriptErrorsSuppressed = True
        Dim reader As New IO.StreamReader(Application.StartupPath & "\History.txt")
        While reader.Peek >= 0
            ListBox1.Items.Add(reader.ReadLine)
        End While
        reader.Close()

        For Each x In My.Settings.Bookmarks : BookmarksDropDownButton.DropDownItems.Add(x) : Next
        OpenBookmarksInNewWindowToolStripMenuItem.Checked = My.Settings.NewWindow
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim myform1 As New Form1
        myform1.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

    End Sub

    Private Sub tmrStatus_Tick(sender As Object, e As EventArgs) Handles tmrStatus.Tick
        Label2.Text = WebBrowser1.StatusText.ToString
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If My.Settings.SE = "Google" Then
            WebBrowser1.Navigate(My.Settings.Google + TextBox2.Text)
        ElseIf My.Settings.SE = "Bing" Then
            WebBrowser1.Navigate(My.Settings.Bing + TextBox2.Text)
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.Click
        If TextBox2.Text = "" Then
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form2.Show()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub
    Private Sub WebBrowser1_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Text = WebBrowser1.Url.ToString
        Dim writer As New IO.StreamWriter(Application.StartupPath & "\History.txt")
        For Each Item As String In ListBox1.Items
            writer.WriteLine(Item)
        Next
        writer.Close()
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim myform3 As New Form3
        myform3.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Form4.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_ItemClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        WebBrowser1.Navigate(ListBox1.SelectedItem)
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        ListBox1.Items.Clear()
        Dim writer As New IO.StreamWriter(Application.StartupPath & "\History.txt")
        For Each Item As String In ListBox1.Items
            writer.WriteLine(Item)
        Next
        writer.Close()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub WebBrowser1_DocumentCompleted_1(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub WebBrowser1_DocumentTitleChanged(sender As Object, e As EventArgs) Handles WebBrowser1.DocumentTitleChanged
        Me.Text = WebBrowser1.DocumentTitle & " - Web Browser"
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.NewWindow = OpenBookmarksInNewWindowToolStripMenuItem.Checked
    End Sub

    Private Sub BookmarksDropDownButton_Click(sender As Object, e As EventArgs) Handles BookmarksDropDownButton.Click
        ToolStripSeparator2.Visible = Not (My.Settings.Bookmarks.Count = 0)
        BookmarkThisPageToolStripMenuItem.Enabled = Not (My.Settings.Bookmarks.Contains(WebBrowser1.Url.ToString))
    End Sub

    Private Sub BookmarksDropDownButton_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles BookmarksDropDownButton.DropDownItemClicked
        Select Case e.ClickedItem.Name
            Case "BookmarkThisPageToolStripMenuItem"
                Try
                    My.Settings.Bookmarks.Add(WebBrowser1.Url.AbsoluteUri)
                    BookmarksDropDownButton.DropDownItems.Add(WebBrowser1.Url.AbsoluteUri)
                    My.Settings.Save() : My.Settings.Reload()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "EditBookmarksToolStripMenuItem"
                FrmEdit.ShowDialog()
            Case "AddBookmarkToolStripMenuItem"
                Dim Bookmark As String = InputBox("Location of WebSite",
                "Add Custom Bookmark", "http://www.")
                If Not Bookmark = "" Then
                    My.Settings.Bookmarks.Add(Bookmark)
                    BookmarksDropDownButton.DropDownItems.Add(Bookmark)
                    My.Settings.Save() : My.Settings.Reload()
                End If
            Case "OpenBookmarksInNewWindowToolStripMenuItem" 'Do Nothing (Case Else won't work if this case isn't put)
            Case "ToolStripSeparator1" 'Ditto Above
            Case "ToolStripSeparator2" 'Ditto 2 Above
            Case Else
                WebBrowser1.Navigate(e.ClickedItem.Text, OpenBookmarksInNewWindowToolStripMenuItem.Checked)
        End Select
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If ListBox1.SelectedItems.Count > 0 Then
            For n As Integer = ListBox1.SelectedItems.Count - 1 To 0 Step -1
                ListBox1.Items.Remove(ListBox1.SelectedItems(n))
                Dim writer As New IO.StreamWriter(Application.StartupPath & "\History.txt")
                For Each Item As String In ListBox1.Items
                    writer.WriteLine(Item)
                Next
                writer.Close()
            Next n
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
End Class