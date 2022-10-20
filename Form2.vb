Imports System.Data.SqlClient
Imports System.IO
Imports ExcelDataReader
Imports Z.Dapper.Plus

Public Class Form2
    Dim tables As DataTableCollection

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx"}
            If ofd.ShowDialog() = DialogResult.OK Then
                txtFileName.Text = ofd.FileName
                Using stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read)
                    Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                        Dim result As DataSet = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                            .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                            .UseHeaderRow = True}})
                        tables = result.Tables
                        cboSheet.Items.Clear()
                        For Each table As DataTable In tables
                            cboSheet.Items.Add(table.TableName)
                        Next

                    End Using

                End Using

            End If



        End Using

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cboSheet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSheet.SelectedIndexChanged
        Dim dt As DataTable = tables(cboSheet.SelectedItem.ToString())
        '  DataGridView1.DataSource = dt
        If dt IsNot Nothing Then
            Dim list As List(Of Insurance) = New List(Of Insurance)()
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim insurance As Insurance = New Insurance()
                insurance.Policy = dt.Rows(i)("Policy").ToString()
                insurance.Expiry = dt.Rows(i)("Expiry").ToString()
                insurance.Location = dt.Rows(i)("Location").ToString()
                insurance.State = dt.Rows(i)("State").ToString()
                insurance.Region = dt.Rows(i)("Region").ToString()
                insurance.InsuredValue = dt.Rows(i)("InsuredValue").ToString()
                insurance.Construction = dt.Rows(i)("Construction").ToString()
                insurance.BusinessType = dt.Rows(i)("BusinessType").ToString()
                insurance.Earthquake = dt.Rows(i)("Earthquake").ToString()
                insurance.Flood = dt.Rows(i)("Flood").ToString()
                list.Add(insurance)

            Next
            InsuranceBindingSource.DataSource = list




        End If


    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Try
            Dim list As List(Of Insurance) = TryCast(InsuranceBindingSource.DataSource, List(Of Insurance))
            If list IsNot Nothing Then
                DapperPlusManager.Entity(Of Insurance).Table("insurance")
                Using db As IDbConnection = New SqlConnection("Server=LAPTOP-53UNUI6G;Database=FMA;Integrated Security=True")
                    db.BulkInsert(list)
                End Using
                MessageBox.Show("Finished !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class