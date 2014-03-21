Public Class frmAPIS
    Private mAPIS_DataProvider As New APIS_DataProvider
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'Ask the user to provides his credential
        Dim l_LoginForm As New LoginForm1

        l_LoginForm.ShowDialog()

        If l_LoginForm.DialogResult = Windows.Forms.DialogResult.OK Then

            mAPIS_DataProvider.SetCredential(l_LoginForm.UsernameTextBox.Text, l_LoginForm.PasswordTextBox.Text)

            LoginForm1.Dispose()
        Else

        End If

        'MsgBox(l_LoginForm)




    End Sub




    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSelectFromFOAMS.Click
        mAPIS_DataProvider.ReadFOAMS_LegData()
    End Sub

    
    Private Sub txtNOAAircraftTailNumber_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNOAAircraftTailNumber.Validating

        Me.txtNOAAircraftTailNumber.Text = Replace(Me.txtNOAAircraftTailNumber.Text, "-", String.Empty)




    End Sub



    Private Sub txtNOADepCity_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNOADepCity.Validated

        If Len(Me.txtNOADepCity.Text) > 0 Then
            ' Clear the error, if any, in the error provider.
            ErrorProvider1.SetError(Me.txtNOADepCity, String.Empty)
        Else
            ' Set the error if the name is not valid.
            ErrorProvider1.SetError(Me.txtNOADepCountry, "City Name is required.")
        End If


    End Sub
End Class
