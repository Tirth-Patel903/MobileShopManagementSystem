Imports System.Data
Imports System.Data.SqlClient

Public Class Search
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim dv As DataView
    Dim str As String
    Dim mobile As Object
    Dim customer As Object
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox2.SelectedIndex = "0" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\documents\visual studio 2015\Projects\MobileShopManagementSystem\MobileShopManagementSystem\Mobile.mdf;Integrated Security=True")
                str = "SELECT * FROM customer WHERE id = '" + TextBox1.Text + "'"
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                DataGridView1.DataSource = New BindingSource(dt, mobile)
            End Using
        ElseIf ComboBox2.SelectedIndex = "1" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\documents\visual studio 2015\Projects\MobileShopManagementSystem\MobileShopManagementSystem\Mobile.mdf;Integrated Security=True")
                str = "SELECT * FROM mobile WHERE id = '" + TextBox1.Text + "'"
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                DataGridView1.DataSource = New BindingSource(dt, customer)
            End Using
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedIndex = "0" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\documents\visual studio 2015\Projects\MobileShopManagementSystem\MobileShopManagementSystem\Mobile.mdf;Integrated Security=True")
                str = "SELECT * FROM customer"
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                DataGridView1.DataSource = New BindingSource(dt, customer)
            End Using
        ElseIf ComboBox2.SelectedIndex = "1" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\documents\visual studio 2015\Projects\MobileShopManagementSystem\MobileShopManagementSystem\Mobile.mdf;Integrated Security=True")
                str = "SELECT * FROM mobile"
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                DataGridView1.DataSource = New BindingSource(dt, mobile)
            End Using
        End If
    End Sub
End Class