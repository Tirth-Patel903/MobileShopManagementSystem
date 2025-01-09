Imports System.Data
Imports System.Data.SqlClient

Public Class InsertMobile
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dr As SqlDataReader

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        ComboBox2.Text = "--Select--"
        ComboBox3.Text = "--Select--"
        ComboBox4.Text = "--Select--"
        ComboBox5.Text = "--Select--"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\documents\visual studio 2015\Projects\MobileShopManagementSystem\MobileShopManagementSystem\Mobile.mdf;Integrated Security=True")


        com = New SqlCommand("insert into mobile(brand,model,price,i_storage,ram,f_cam,b_cam,warranty,size,date,d_id,d_name,quntity)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox5.Text & "','" & ComboBox4.Text & "','" & TextBox8.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox9.Text & "')", con)
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
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        ComboBox2.Text = "--Select--"
        ComboBox3.Text = "--Select--"
        ComboBox4.Text = "--Select--"
        ComboBox5.Text = "--Select--"
    End Sub
End Class