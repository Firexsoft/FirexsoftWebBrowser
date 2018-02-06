Public Class FrmEdit
    Private Sub FrmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        For Each x In My.Settings.Bookmarks
            ListBox1.Items.Add(x)
        Next
        Me.Text = "Total Count: " & My.Settings.Bookmarks.Count
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox1.KeyDown
        If e.KeyCode = Keys.Delete Then
            btnRemove.PerformClick()
        ElseIf e.KeyCode = Keys.A Then
            btnAdd.PerformClick()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Bookmark As String = InputBox("Location of WebSite", "Add Custom Bookmark", "http://www.")
        If Not Bookmark = "" Then
            My.Settings.Bookmarks.Add(Bookmark)
            Form1.BookmarksDropDownButton.DropDownItems.Add(Bookmark)
            ListBox1.Items.Add(Bookmark)
            My.Settings.Save() : My.Settings.Reload()
            Me.Text = "Total Count: " & My.Settings.Bookmarks.Count
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If Not (ListBox1.Items.Count = 0) And Not (ListBox1.SelectedIndices.Count = 0) Then
            Dim SI As Integer = ListBox1.SelectedIndex
            ListBox1.Items.RemoveAt(SI)
            My.Settings.Bookmarks.RemoveAt(SI)
            Form1.BookmarksDropDownButton.DropDownItems.RemoveAt(SI + 6)
            My.Settings.Save() : My.Settings.Reload()
            Me.Text = "Total Count: " & My.Settings.Bookmarks.Count
        End If
    End Sub

    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
        If Not (ListBox1.Items.Count = 0) Then
            If MessageBox.Show("Are you sure you want to remove all bookmarks?",
                        "Clear Bookmarks", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question) _
                         = Windows.Forms.DialogResult.Yes Then
                Do : Form1.BookmarksDropDownButton.DropDownItems.RemoveAt(6)
                Loop Until (Form1.BookmarksDropDownButton.DropDownItems.Count = 6)
                ListBox1.Items.Clear()
                My.Settings.Bookmarks.Clear()
                My.Settings.Save() : My.Settings.Reload()
                Me.Text = "Total Count: 0"
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class