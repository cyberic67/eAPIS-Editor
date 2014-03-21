Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient


Public Class APIS_DataProvider

    Private m_Password As String
    Private m_UserName As String

    Public Sub ReadFOAMS_LegData()

        'Dim l_Doc As New XmlDocument
        Dim l_QueryString As String
        'Dim l_connection As SqlConnection
        'Dim l_connectString As String
        Dim l_connectBuilder As SqlConnectionStringBuilder
        Dim l_count As Long


        'Get the query string from the XML Dataconfig file

        l_QueryString = My.Settings.outboundLegList

        l_connectBuilder = New SqlConnectionStringBuilder

        With l_connectBuilder
            '.DataSource = "STL-468\SQLEXPRESSFOAMS"
            '.IntegratedSecurity = True
            .DataSource = My.Settings.server_address
            .IntegratedSecurity = False
            .InitialCatalog = My.Settings.initial_catalog
            .Pooling = True
            .UserID = m_UserName
            .Password = m_Password

        End With


        Using l_connection = New SqlConnection(l_connectBuilder.ConnectionString)

            Dim l_command As New SqlCommand(l_QueryString, l_connection)

            l_connection.Open()

            Dim l_reader As SqlDataReader = l_command.ExecuteReader

            l_count = 0
            While l_reader.Read

                Console.WriteLine(String.Format("{0}, {1}, {2}", _
                  l_reader(0), l_reader(1), l_reader(2)))
                l_count += 1

            End While

            l_reader.Close()
            Console.WriteLine(String.Format("Record Count:{0}", (l_count.ToString)))

        End Using
        'Create a DataReader

        'Create the SQL querys to retrieve the following data

        '   -LegData
        '   -CrewData
        '   -AircraftData
        '   -PaxData

        'Read the data

        'Write the data to the XML file

        'Return the XML file



    End Sub

    Public Sub SetCredential(ByVal userName As String, ByVal password As String)

        m_UserName = Trim(userName)
        m_Password = Trim(password)

    End Sub

End Class
