Imports System.Data
Imports System.Data.SqlClient

Public Class SellMobile
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim getmob As String


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\documents\visual studio 2015\Projects\MobileShopManagementSystem\MobileShopManagementSystem\Mobile.mdf;Integrated Security=True")


        com = New SqlCommand("insert into customer(name,mobile,addr,date,m_id,brand,model,price,warranty,d_id)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & Label7.Text & "','" & Label10.Text & "','" & Label14.Text & "','" & Label15.Text & "','" & Label16.Text & "')", con)
        con.Open()
        com.ExecuteNonQuery()
        MsgBox("Mobile Infromation Inserted Successfullyy..")
        Hide()
        con.Close()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        Label7.Text = ""
        Label10.Text = ""
        Label14.Text = ""
        Label15.Text = ""
        Label16.Text = ""
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\documents\visual studio 2015\Projects\MobileShopManagementSystem\MobileShopManagementSystem\Mobile.mdf;Integrated Security=True")
        con.Open()

        Try
            getmob = "select brand,model,price,warranty,d_id from mobile where id='" & TextBox5.Text & "'"
            com = New SqlCommand(getmob, con)
            dr = com.ExecuteReader()
            If dr.Read() Then
                Label7.Text = dr.GetValue(0).ToString()
                Label10.Text = dr.GetValue(1).ToString()
                Label14.Text = dr.GetValue(2).ToString()
                Label15.Text = dr.GetValue(3).ToString()
                Label16.Text = dr.GetValue(4).ToString()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class