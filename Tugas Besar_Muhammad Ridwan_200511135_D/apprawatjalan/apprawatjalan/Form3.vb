Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Net

Public Class Form3
    Private Sub TambahData()

        ' Set the data you want to send as key-value pairs
        Dim no_recmd As String = txtNorecmd.Text
        Dim nrp As String = txtNrp.Text
        Dim nama As String = txtNama.Text
        Dim nama_dokter As String = txtDokter.Text
        Dim biaya As String = txtBiaya.ToString
        Dim hasil_diagnosa As String = txtDiagnosa.Text
        Dim harga_obat As String = txtObat.Text
        Dim total As String = txtTotal.Text

        Dim postData As String = $"no_recmd={no_recmd}&nrp={nrp}&nama={nama}&nama_dokter={nama_dokter}&biaya={biaya}hasil_diagonas={hasil_diagnosa}&harga_obat={harga_obat}&total={total}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(rawatjalan_api, "POST", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub UpdateData()

        ' Set the data you want to send as key-value pairs
        Dim no_recmd As String = txtNorecmd.Text
        Dim nrp As String = txtNrp.Text
        Dim nama As String = txtNama.Text
        Dim nama_dokter As String = txtDokter.Text
        Dim biaya As String = txtBiaya.ToString
        Dim hasil_diagnosa As String = txtDiagnosa.Text
        Dim harga_obat As String = txtObat.Text
        Dim total As String = txtTotal.Text

        Dim postData As String = $"no_recmd={no_recmd}&nrp={nrp}&nama={nama}&nama_dokter={nama_dokter}&biaya={biaya}hasil_diagonas={hasil_diagnosa}&harga_obat={harga_obat}&total={total}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(dokter_api & "?no_recmd=" & txtNorecmd.Text, "PUT", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub DeleteData()

        ' Set the data you want to send as key-value pairs
        Dim no_recmd As String = txtNorecmd.Text
        Dim nrp As String = txtNrp.Text
        Dim nama As String = txtNama.Text
        Dim nama_dokter As String = txtDokter.Text
        Dim biaya As String = txtBiaya.ToString
        Dim hasil_diagnosa As String = txtDiagnosa.Text
        Dim harga_obat As String = txtObat.Text
        Dim total As String = txtTotal.Text

        Dim postData As String = $"no_recmd={no_recmd}&nrp={nrp}&nama={nama}&nama_dokter={nama_dokter}&biaya={biaya}hasil_diagonas={hasil_diagnosa}&harga_obat={harga_obat}&total={total}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the DELETE request and get the response
            Dim responseBytes As Byte() = client.UploadData(rawatjalan_api & "?no_recmd=" & txtNorecmd.Text, "DELETE", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub GetData()
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(rawatjalan_api & "?no_recmd=" & txtNorecmd.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        rawatjalan_role = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        rawatjalan_role = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (rawatjalan_role = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of Rawatjalan) = JsonConvert.DeserializeObject(Of List(Of Rawatjalan))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As Rawatjalan In data
                            txtNorecmd.Text = mydata.no_recmd
                            txtNrp.Text = mydata.nrp
                            txtNama.Text = mydata.nama
                            txtDokter.Text = mydata.nama_dokter
                            txtBiaya.Text = mydata.biaya
                            txtDiagnosa.Text = mydata.hasil_diagnosa
                            txtObat.Text = mydata.harga_obat
                            txtTotal.Text = mydata.total
                        Next
                    End If

                End Try




            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub

    Private Sub GetClear()
        txtNorecmd.Clear()
        txtNrp.Clear()
        txtNama.Clear()
        txtDokter.Clear()
        txtBiaya.Clear()
        txtDiagnosa.Clear()
        txtObat.Clear()
        txtTotal.Clear()
        Reloaded()
        txtNrp.Focus()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (rawatjalan_role = True) Then
            TambahData()
        Else
            UpdateData()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (rawatjalan_role = False) Then
            Dim result As DialogResult = MessageBox.Show("Apakah data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteData()
            Else
                MessageBox.Show("Data batal dihapus.")
            End If
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub

    Private Sub Reloaded()

        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(rawatjalan_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of Rawatjalan) = JsonConvert.DeserializeObject(Of List(Of Rawatjalan))(response)

        ' Bind the data to the DataGridView
        dgvData.DataSource = data
    End Sub

    Private Sub txtNorecmd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNorecmd.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub
End Class