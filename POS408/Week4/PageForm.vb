Public Class PageForm

    Private Sub SaleStaffBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleStaffBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.SaleStaffBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CompanyDataSet)
            MsgBox("Update successful")

        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

    Private Sub PageForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CompanyDataSet.SaleStaff' table. You can move, or remove it, as needed.
        Me.SaleStaffTableAdapter.Fill(Me.CompanyDataSet.SaleStaff)

    End Sub
End Class