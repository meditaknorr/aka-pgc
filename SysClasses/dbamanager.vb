Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Text
Imports System.Net
Imports System.Net.Sockets
Imports MySql.Data.MySqlClient
Public Class dbamanager
    Private stringConexao As String = ConfigurationManager.ConnectionStrings("Mydba.Connector").ConnectionString()
    Private conexaoMySql As MySqlConnection
    Private comandoMySQl As MySqlCommand
    Private leitor As MySqlDataReader
    Private estadoMySQL As String
    Private ServidorMySQl As String = "127.0.0.1"
    Private portaMYSQL As Integer = 3306
    Private contadorMySql As Integer
    Private contadorUser As Integer

    Public Property connectorRemoverORAdder As MySqlConnection
        Get
            Return conexaoMySql
        End Get
        Set(value As MySqlConnection)

        End Set
    End Property

    Public Sub connectorAdder()
        Try
            conexaoMySql = New MySqlConnection(stringConexao)
            conexaoMySql.Open()
        Catch ex As Exception

        End Try
    End Sub

    Private Function IsMySQLServerAvailable(ByVal server As String, ByVal Port As String) As Boolean
        Try
            Dim tcpCli1 As New TcpClient
            tcpCli1.SendTimeout = 15
            tcpCli1.Connect(server, Port)
            tcpCli1.Close()
            tcpCli1 = Nothing
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function connectorExist() As Boolean
        Return IsMySQLServerAvailable(ServidorMySQl, portaMYSQL)
    End Function

    Public Property conectorStatus As String
        Set

        End Set
        Get
            contadorMySql = 0
            Dim query As String = "Select username from users where userid = 1"
            Me.connectorAdder()

            comandoMySQl = New MySqlCommand(query, conexaoMySql)
            leitor = comandoMySQl.ExecuteReader()

            While (leitor.Read())
                contadorMySql = contadorMySql + 1
            End While

            If (contadorMySql > 0) Then
                estadoMySQL = "Connected and Running."
            Else
                estadoMySQL = "System is not Running. Please Check your internet connection."
            End If

            leitor.Close()
            Me.connectorRemoverORAdder.Close()
            Return estadoMySQL
        End Get
    End Property

    Public Function existUser(ByVal username) As Integer
        contadorUser = 0
        Dim query As String = "Select username from users where username = '" + username + "'"
        Me.connectorAdder()
        comandoMySQl = New MySqlCommand(query, conexaoMySql)
        leitor = comandoMySQl.ExecuteReader()

        While (leitor.Read())
            contadorUser = contadorUser + 1
        End While

        leitor.Close()
        Me.connectorRemoverORAdder.Close()
        Return contadorUser
    End Function

    Public Function loginStatus(ByVal username, ByVal password) As Boolean
        Dim statusLogin As Boolean = False
        If (Me.existUser(username) > 0) Then
            Dim passe As String = ""
            Dim query As String = "Select password from users where username = '" + username + "'"
            Me.connectorAdder()
            comandoMySQl = New MySqlCommand(query, conexaoMySql)
            leitor = comandoMySQl.ExecuteReader()

            While (leitor.Read())
                passe = leitor.GetString("password")
            End While

            If (VerificaHash(passe, password) = True) Then
                statusLogin = True
            Else
                statusLogin = False
            End If

            leitor.Close()
            Me.connectorRemoverORAdder.Close()


            Return statusLogin
        Else
            Return statusLogin
        End If
    End Function

    Shared Function CriaHash(userInput As String) As String

        Using hasher As MD5 = MD5.Create()
            Dim word As Byte() =
            hasher.ComputeHash(Encoding.UTF8.GetBytes(userInput))
            Return Convert.ToBase64String(word)
        End Using

    End Function

    Shared Function VerificaHash(dbhashed As String, pswInput As String) As Boolean
        Dim newHash As String = CriaHash(pswInput)
        If (newHash = dbhashed) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function getCountryCode(ByVal countryname) As Integer
        contadorUser = 0
        Dim countrycode As Integer
        Dim query As String = "Select countrycode from country where countryname = '" + countryname + "'"
        Me.connectorAdder()
        comandoMySQl = New MySqlCommand(query, conexaoMySql)
        leitor = comandoMySQl.ExecuteReader()

        While (leitor.Read())
            countrycode = leitor.GetString("countrycode")
        End While

        Return countrycode
        leitor.Close()
        Me.connectorRemoverORAdder.Close()
    End Function

    Public Function getProvinceCode(ByVal provincename) As String
        contadorUser = 0
        Dim countrycode As String
        Dim query As String = "Select provincesid from provinces where provincename = '" + provincename + "'"
        Me.connectorAdder()
        comandoMySQl = New MySqlCommand(query, conexaoMySql)
        leitor = comandoMySQl.ExecuteReader()

        While (leitor.Read())
            countrycode = leitor.GetString("provincesid")
        End While

        Return countrycode
        leitor.Close()
        Me.connectorRemoverORAdder.Close()
    End Function

    Public Function getProvince(ByVal username) As Integer
        contadorUser = 0
        Dim query As String = "Select * from country where username = '" + username + "'"
        Me.connectorAdder()
        comandoMySQl = New MySqlCommand(query, conexaoMySql)
        leitor = comandoMySQl.ExecuteReader()

        While (leitor.Read())
            contadorUser = contadorUser + 1
        End While

        leitor.Close()
        Me.connectorRemoverORAdder.Close()
        Return contadorUser
    End Function

    Public Function getUserSessionId(ByVal username) As String
        contadorUser = 0
        Dim session As String
        Dim query As String = "Select sessionid from users where username = '" + username + "'"
        Me.connectorAdder()
        comandoMySQl = New MySqlCommand(query, conexaoMySql)
        leitor = comandoMySQl.ExecuteReader()

        While (leitor.Read())
            session = leitor.GetString("sessionid")
        End While

        Return session
        leitor.Close()
        Me.connectorRemoverORAdder.Close()
    End Function

    Public Function getUserId(ByVal sessionid) As Integer
        contadorUser = 0
        Dim session As Integer
        Dim query As String = "Select userid from users where sessionid = '" + sessionid + "'"
        Me.connectorAdder()
        comandoMySQl = New MySqlCommand(query, conexaoMySql)
        leitor = comandoMySQl.ExecuteReader()

        While (leitor.Read())
            session = leitor.GetString("userid")
        End While

        Return session
        leitor.Close()
        Me.connectorRemoverORAdder.Close()
    End Function

    Public Function get4rmUsers(ByVal item As String, ByVal userid As Integer) As String
        contadorUser = 0
        Dim session As String
        Dim query As String = "Select " + item + " from users where userid = '" + userid + "'"
        Me.connectorAdder()
        comandoMySQl = New MySqlCommand(query, conexaoMySql)
        leitor = comandoMySQl.ExecuteReader()

        While (leitor.Read())
            session = leitor.GetString("'" + item + "'")
        End While

        Return session
        leitor.Close()
        Me.connectorRemoverORAdder.Close()
    End Function

    Public Function get4rmUserProfile(ByVal itemS As String, ByVal userid As Integer) As String
        contadorUser = 0
        Dim session As String
        Dim query As String = "Select " & itemS & " from userprofile where userid = " & userid
        Me.connectorAdder()
        comandoMySQl = New MySqlCommand(query, conexaoMySql)
        leitor = comandoMySQl.ExecuteReader()

        While (leitor.Read())
            session = leitor.GetString(itemS)
        End While

        Return session
        leitor.Close()
        Me.connectorRemoverORAdder.Close()
    End Function

End Class