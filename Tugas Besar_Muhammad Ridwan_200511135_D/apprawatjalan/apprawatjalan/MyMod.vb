Module MyMod
    Public api_folder As String = "apprawatjalan"
    Public users_api As String = "http://f0833868.xsph.ru/" & api_folder & "/users_api.php"
    Public pasien_api As String = "http://f0833868.xsph.ru/" & api_folder & "/pasien_api.php"
    Public rawatjalan_api As String = "http://f0833868.xsph.ru/" & api_folder & "/rawatjalan_api.php"
    Public dokter_api As String = "http://f0833868.xsph.ru/" & api_folder & "/dokter_api.php"
    Public dokter_role As Boolean = False
    Public Dashboard As New Form1
    Public PasienForm As New Form2
    Public RawatjalanForm As New Form3
    Public DokterForm As New Form4
    Public LoginForm As New Login
    Public pasien_role As Boolean = False
    Public rawatjalan_role As Boolean = False
    Public login_valid As Boolean = False

End Module
