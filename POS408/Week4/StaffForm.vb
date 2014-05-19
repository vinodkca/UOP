Public Class StaffForm

    Private Sub SaleStaffBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SaleStaffBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub StaffForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CompanyDataSet1.SaleStaff' table. You can move, or remove it, as needed.
        Me.SaleStaffTableAdapter1.Fill(Me.CompanyDataSet1.SaleStaff)

    End Sub
End Class