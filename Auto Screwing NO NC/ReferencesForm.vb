Imports System.Data.SqlClient
Public Class ReferencesForm
    Dim Database = New DatabaseConnection
    Private Sub DateTime_Tick(sender As Object, e As EventArgs) Handles DateTime.Tick
        lbl_curr_time.Text = Date.Now.ToString("dd-MM-yyyy")
        lbl_curr_time.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Hide()
        MainForm.Show()
    End Sub

    Private Sub ReferencesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 12)
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 12)
        Try
            LoadRef()
            rtb_references.SelectionColor = Color.Black
            rtb_references.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[References] Finish load references" + Environment.NewLine)
            rtb_references.ScrollToCaret()
        Catch ex As Exception
            rtb_references.SelectionColor = Color.Red
            rtb_references.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[References] Failed load references " + ex.Message + Environment.NewLine)
            rtb_references.ScrollToCaret()
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Call Database.Connect()
            Dim sc As New SqlCommand("SELECT * FROM tb_references WHERE [Barcode Scan]='" & DataGridView1.CurrentCell.Value & "'", Database.Connection)
            Dim rd As SqlDataReader = sc.ExecuteReader
            rd.Read()

            txt_barcode_scan.Text = DataGridView1.CurrentCell.Value
            txt_material_type.Text = rd.Item("Material Type")
            txt_references.Text = rd.Item("References")
            txt_family.Text = rd.Item("Family")
            rtb_references.SelectionColor = Color.Black
            rtb_references.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[References] Finish load references" + Environment.NewLine)
            rtb_references.ScrollToCaret()
        Catch ex As Exception
            rtb_references.SelectionColor = Color.Red
            rtb_references.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[References] Failed load references " + ex.Message + Environment.NewLine)
            rtb_references.ScrollToCaret()
        End Try
    End Sub
    Private Sub LoadRef()
        Call Database.Connect()
        Dim sc As New SqlCommand("SELECT * FROM tb_references", Database.Connection)
        Dim adapter As New SqlDataAdapter(sc)
        Dim ds As New DataSet

        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_barcode_scan.Text <> "" And txt_family.Text <> "" And txt_material_type.Text <> "" And txt_references.Text <> "" Then
            Try
                Call Database.Connect()
                Dim sc As New SqlCommand("INSERT INTO tb_references ([Barcode Scan], [Material Type], [References], [Family]) VALUES('" & txt_barcode_scan.Text & "', '" & txt_material_type.Text & "', '" & txt_references.Text & "', '" & txt_family.Text & "')", Database.Connection)
                Dim adapter As New SqlDataAdapter(sc)
                adapter.SelectCommand.ExecuteNonQuery()
                LoadRef()
                rtb_references.SelectionColor = Color.Black
                rtb_references.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[References] Finish add references " + Environment.NewLine)
                rtb_references.ScrollToCaret()
            Catch ex As Exception
                rtb_references.SelectionColor = Color.Red
                rtb_references.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[References] Failed add references " + ex.Message + Environment.NewLine)
                rtb_references.ScrollToCaret()
            End Try
        Else
            rtb_references.SelectionColor = Color.Red
            rtb_references.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[References] Failed, Please fill all field! " + Environment.NewLine)
            rtb_references.ScrollToCaret()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If txt_barcode_scan.Text <> "" Then
            Try
                Call Database.Connect()
                Dim sc As New SqlCommand("DELETE FROM tb_references WHERE [Barcode Scan] = '" & txt_barcode_scan.Text & "'", Database.Connection)
                Dim adapter As New SqlDataAdapter(sc)
                adapter.SelectCommand.ExecuteNonQuery()
                LoadRef()
                rtb_references.SelectionColor = Color.Black
                rtb_references.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[References] Finish delete references " + Environment.NewLine)
                rtb_references.ScrollToCaret()
            Catch ex As Exception
                rtb_references.SelectionColor = Color.Red
                rtb_references.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[References] Failed delete references " + ex.Message + Environment.NewLine)
                rtb_references.ScrollToCaret()
            End Try
        Else
            rtb_references.SelectionColor = Color.Red
            rtb_references.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[References] Failed, Please fill Barcode Scan! " + Environment.NewLine)
            rtb_references.ScrollToCaret()
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If txt_barcode_scan.Text <> "" And txt_family.Text <> "" And txt_material_type.Text <> "" And txt_references.Text <> "" Then
            Try
                Call Database.Connect()
                Dim sc As New SqlCommand("UPDATE tb_references SET [Family] = '" & txt_family.Text & "', [Material Type] = '" & txt_material_type.Text & "', [References] = '" & txt_references.Text & "' WHERE [Barcode Scan] = '" & txt_barcode_scan.Text & "'", Database.Connection)
                Dim adapter As New SqlDataAdapter(sc)
                adapter.SelectCommand.ExecuteNonQuery()
                LoadRef()
                rtb_references.SelectionColor = Color.Black
                rtb_references.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[References] Finish update references " + Environment.NewLine)
                rtb_references.ScrollToCaret()
            Catch ex As Exception
                rtb_references.SelectionColor = Color.Red
                rtb_references.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[References] Failed update references " + ex.Message + Environment.NewLine)
                rtb_references.ScrollToCaret()
            End Try
        Else
            rtb_references.SelectionColor = Color.Red
            rtb_references.AppendText(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss ") + "[References] Failed, Please fill all field! " + Environment.NewLine)
            rtb_references.ScrollToCaret()
        End If
    End Sub
End Class