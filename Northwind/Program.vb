Option Infer On

Public Module Program

    Public NorthWindDB As NorthwindDatabase.NorthwindDB

    Public Sub Main()

        'SETUP
        '1. Create a database called 'Northwind' for SQL Server or MySQL or if using Microsoft Access download it from http://www.microsoft.com/downloads/details.aspx?FamilyID=C6661372-8DBE-422B-8676-C632D66C529C&displaylang=EN
        '2. Uncomment the appropriate line below depending on which database system is being utilised. Adjust the server name, account and password if necessary.
        '3. Run the application, the tables and data will be automatically populated in the database

        Dim database As DatabaseObjects.Database = Nothing

        'SQL Server:
        database = New DatabaseObjects.MicrosoftSQLServerDatabase("localhost", "Northwind")

        'MySQL:
        'database = New DatabaseObjects.Database(New MySql.Data.MySqlClient.MySqlConnection("Server=localhost;Database=Northwind;Uid=root;Pwd=root;"), DatabaseObjects.Database.ConnectionType.MySQL)

        'Microsoft Access: (database is available at: http://www.microsoft.com/downloads/details.aspx?FamilyID=C6661372-8DBE-422B-8676-C632D66C529C&displaylang=EN)
        'database = New DatabaseObjects.MicrosoftAccessDatabase("C:\Program Files\Microsoft Visual Studio\VB98\nwind.mdb"))

        If database Is Nothing Then
            System.Windows.Forms.MessageBox.Show("Open the Northwind\Program.vb file to indicate which database to utilise and then try again.", "DatabaseObjects / Northwind", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            NorthwindDatabase.NorthwindImport.Installer.Run(database)
            NorthWindDB = New NorthwindDatabase.NorthwindDB(database)

            Dim frmMain As New frmMain
            frmMain.Show()
            Application.Run(frmMain)
        End If

    End Sub

End Module
