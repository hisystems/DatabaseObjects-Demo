Option Infer On

Public Module Program

    Public NorthWindDB As NorthwindDatabase.NorthwindDB

    Public Sub Main()

        NorthWindDB = New NorthwindDatabase.NorthwindDB(New DatabaseObjects.MicrosoftSQLServerDatabase("localhost", "Northwind"))
        'NorthWindDB = New NorthwindDatabase.NorthwindDB(New DatabaseObjects.MySQLDatabase("localhost", "Northwind", "root", String.Empty))
        'Microsoft Access Northwind database is available at: http://www.microsoft.com/downloads/details.aspx?FamilyID=C6661372-8DBE-422B-8676-C632D66C529C&displaylang=EN
        NorthWindDB = New NorthwindDatabase.NorthwindDB(New DatabaseObjects.MicrosoftAccessDatabase("C:\Program Files\Microsoft Visual Studio\VB98\nwind.mdb"))

        Dim frmMain As New frmMain
        frmMain.Show()
        Application.Run(frmMain)

    End Sub

End Module
