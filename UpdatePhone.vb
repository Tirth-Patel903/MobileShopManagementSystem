Imports System.Data
Imports System.Data.SqlClient

Public Class UpdatePhone
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
        com = New SqlCommand(" update mobile set brand='" + TextBox1.Text + "',model='" + TextBox2.Text + "',price='" + TextBox3.Text + "',i_storage='" + ComboBox2.Text + "',ram='" + ComboBox3.Text + "',f_cam='" + TextBox4.Text + "',b_cam='" + TextBox5.Text + "',warranty='" + ComboBox5.Text + "',size='" + ComboBox4.Text + "',date='" + TextBox8.Text + "',d_id='" + TextBox6.Text + "',d_name='" + TextBox7.Text + "',quntity='" + TextBox9.Text + "'", con)
        con.Open()
        com.ExecuteNonQuery()
        MsgBox("Mobile Record updated Successfully..")
        Hide()
        con.Close()
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\documents\visual studio 2015\Projects\MobileShopManagementSystem\MobileShopManagementSystem\Mobile.mdf;Integrated Security=True")
        con.Open()

        Try
            getmob = "select brand,model,price,i_storage,ram,f_cam,b_cam,warranty,size,date,d_id,d_name,quntity from mobile where id='" & TextBox10.Text & "'"
            com = New SqlCommand(getmob, con)
            dr = com.ExecuteReader()
            If dr.Read() Then
                TextBox1.Text = dr.GetValue(0).ToString()
                TextBox2.Text = dr.GetValue(1).ToString()
                TextBox3.Text = dr.GetValue(2).ToString()
                ComboBox2.Text = dr.GetValue(3).ToString()
                ComboBox3.Text = dr.GetValue(4).ToString()
                TextBox4.Text = dr.GetValue(5).ToString()
                TextBox5.Text = dr.GetValue(6).ToString()
                ComboBox5.Text = dr.GetValue(7).ToString()
                ComboBox4.Text = dr.GetValue(8).ToString()
                TextBox8.Text = dr.GetValue(9).ToString()
                TextBox6.Text = dr.GetValue(10).ToString()
                TextBox7.Text = dr.GetValue(11).ToString()
                TextBox9.Text = dr.GetValue(12).ToString()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class