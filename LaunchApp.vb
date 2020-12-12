Imports System.Threading

Public Module LaunchApp

    'There shall be only one.
    '
    <STAThread>
    Public Sub Main()
        Application.EnableVisualStyles()

        Dim instanceCountOne As Boolean = False

        Using mtex As Mutex = New Mutex(True, "ShowCall", instanceCountOne)
            If instanceCountOne Then
                Application.EnableVisualStyles()
                Application.SetCompatibleTextRenderingDefault(False)
                Application.Run(New AppContext)
                mtex.ReleaseMutex()
            Else
                MessageBox.Show("ShowCall is already running")
            End If
        End Using


    End Sub





End Module