Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Module ModuleConfig

    ' Stockage des paramètres chargés depuis config.ini
    Public DbServer As String
    Public DbPort As String
    Public DbName As String
    Public DbUser As String
    Public DbPassword As String
    Public AdminPassword As String

    ''' <summary>
    ''' Charge les paramètres depuis le fichier config.ini
    ''' </summary>
    Public Sub ChargerConfig()
        Dim cheminFichier As String = Path.Combine(
            Application.StartupPath, "config.ini")

        If Not File.Exists(cheminFichier) Then
            Throw New FileNotFoundException(
                "Fichier de configuration introuvable : " & cheminFichier)
        End If

        Dim lignes() As String = File.ReadAllLines(cheminFichier)
        Dim section As String = ""

        For Each ligne As String In lignes
            ' Ignorer les lignes vides et commentaires
            If ligne.Trim() = "" OrElse ligne.StartsWith(";") Then
                Continue For
            End If

            ' Détecter les sections [database], [admin]
            If ligne.StartsWith("[") AndAlso ligne.EndsWith("]") Then
                section = ligne.Trim("[", "]")
                Continue For
            End If

            ' Lire les clé=valeur
            Dim parties() As String = ligne.Split("="c)
            If parties.Length < 2 Then Continue For

            Dim cle As String = parties(0).Trim().ToLower()
            Dim valeur As String = parties(1).Trim()

            Select Case section
                Case "database"
                    Select Case cle
                        Case "server" : DbServer = valeur
                        Case "port" : DbPort = valeur
                        Case "name" : DbName = valeur
                        Case "user" : DbUser = valeur
                        Case "password" : DbPassword = valeur
                    End Select
                Case "admin"
                    If cle = "password" Then AdminPassword = valeur
            End Select
        Next
    End Sub

    ''' <summary>
    ''' Retourne le hash SHA-256 d'une chaîne en minuscules
    ''' Même algorithme que GSB-AppliFrais
    ''' </summary>
    Public Function HashSHA256(texte As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes() As Byte = sha256.ComputeHash(
                Encoding.UTF8.GetBytes(texte))
            Dim sb As New StringBuilder()
            For Each b As Byte In bytes
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function

    ''' <summary>
    ''' Retourne la chaîne de connexion MariaDB
    ''' </summary>
    Public Function GetConnectionString() As String
        Return String.Format(
        "Server={0};Port={1};Database={2};Uid={3};Pwd={4};",
        DbServer, DbPort, DbName, DbUser,
        DbPassword)
    End Function

End Module