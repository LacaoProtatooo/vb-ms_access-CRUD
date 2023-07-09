Imports System.Data.OleDb

Public Class Form1
    Dim dset As New DataSet
    Dim comm As New OleDbCommand
    Dim da As New OleDbDataAdapter(comm)
    Dim dt As New DataTable

    Private Sub getcontent()
        aid = txtbxid.Text
        aname = txtbxname.Text
        aage = txtbxage.Text
        aadress = txtbxaddress.Text

    End Sub

    Private Sub populate()
        ' Loads the Updated Data when Operations was used.

        da = New OleDbDataAdapter("Select * from ppltbl", conn)
        dset = New DataSet
        da.Fill(dset, "ppltbl")
        dgrid.DataSource = dset.Tables("ppltbl").DefaultView

    End Sub

    Private Sub cmdRead_Click(sender As Object, e As EventArgs) Handles cmdRead.Click
        populate()
    End Sub

    Private Sub cmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click
        conn.Open()

        getcontent()
        Dim cconf As Boolean = True
        If (aname = "" And aage = "" And aadress = "") Then
            MessageBox.Show("No Data Added !")
            cconf = False
        End If

        If (cconf = True) Then
            Try
                connect()

                'Same Operation
                'comm = conn.CreateCommand
                'comm.CommandType = CommandType.Text
                'comm.CommandText = "INSERT INTO ppltbl(Name,Age,Address) VALUES('" + aname + "','" + aage + "','" + aadress + "')"
                'comm.ExecuteNonQuery()

                comm.Connection = conn
                comm.CommandText = "INSERT INTO ppltbl(Name,Age,Address) VALUES('" + aname + "','" + aage + "','" + aadress + "')"
                comm.ExecuteNonQuery()

                populate()
                MessageBox.Show("Content Added.")
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("An Error Occured.")
            End Try
        End If
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        getcontent()

        Try
            connect()
            comm.Connection = conn
            comm.CommandText = "UPDATE ppltbl SET [Name]='" + aname + "',[Age]='" + aage + "',[Address]='" + aadress + "' WHERE ID = " + aid + ""
            comm.ExecuteNonQuery()
            populate()
            MessageBox.Show("Content Updated.")
        Catch ex As Exception
            MessageBox.Show("An Error Occured.")
        End Try

        conn.Close()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        getcontent()

        Try
            connect()
            comm.Connection = conn
            comm.CommandText = "DELETE FROM ppltbl WHERE ID=" + aid + ""
            comm.ExecuteNonQuery()
            populate()
            MessageBox.Show("Content Deleted.")
        Catch ex As Exception
            MessageBox.Show("An Error Occured.")
        End Try
    End Sub

    Private Sub dgrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrid.CellClick
        txtbxid.Text = dgrid.Rows(e.RowIndex).Cells(0).Value.ToString
        txtbxname.Text = dgrid.Rows(e.RowIndex).Cells(1).Value.ToString
        txtbxage.Text = dgrid.Rows(e.RowIndex).Cells(2).Value.ToString
        txtbxaddress.Text = dgrid.Rows(e.RowIndex).Cells(3).Value.ToString

        getcontent()
    End Sub
End Class
