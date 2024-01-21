Module mdlIni

    ''' <summary>
    ''' 設定値
    ''' </summary>
    Public Structure stOption
        Dim iTime As Integer            '設定時間(秒)
        Dim iStartTime As Integer       '事前秒数
        Dim iChangeTime As Integer      '色変化する残り秒数
        Dim cBackColor As Color         '背景の色
        Dim cStartColor As Color        '事前秒数の色
        Dim cTimerColor As Color        '通常の色
        Dim cChangeColor As Color       '変更後の色
        '
        Dim iWidth As Integer           '横幅
        Dim iHeight As Integer          '高さ
        Dim iTop As Integer             '上端位置
        Dim iLeft As Integer            '左端位置
        Dim bMaximized As Boolean       '最大化
    End Structure
    Public XX_Option As stOption

    ''' <summary>
    ''' 読み or 書き
    ''' </summary>
    Public Enum EN_RW
        read
        write
    End Enum

    Private Declare Function WritePrivateProfileString _
            Lib "KERNEL32.DLL" Alias "WritePrivateProfileStringA" (
                ByVal lpAppName As String,
                ByVal lpKeyName As String,
                ByVal lpString As String,
                ByVal lpFileName As String) As Integer

    Private Declare Function GetPrivateProfileString _
            Lib "KERNEL32.DLL" Alias "GetPrivateProfileStringA" (
                ByVal lpAppName As String,
                ByVal lpKeyName As String,
                ByVal lpDefault As String,
                ByVal lpReturnedString As String,
                ByVal nSize As Integer,
                ByVal lpFileName As String) As Integer

    Private Const ZZ_SECTION = "Setting"
    Private Const ZZ_KEY_TIME = "設定秒数"
    Private Const ZZ_KEY_STARTTIME = "事前秒数"
    Private Const ZZ_KEY_CHANGETIME = "変更秒数"
    Private Const ZZ_KEY_BACKCOLOR = "背景色"
    Private Const ZZ_KEY_STARTCOLOR = "事前色"
    Private Const ZZ_KEY_TIMERCOLOR = "通常色"
    Private Const ZZ_KEY_CHANGECOLOR = "変更色"
    Private Const ZZ_KEY_WIDTH = "横幅"
    Private Const ZZ_KEY_HEIGHT = "高さ"
    Private Const ZZ_KEY_TOP = "上端"
    Private Const ZZ_KEY_LEFT = "左端"
    Private Const ZZ_KEY_MAXIMIZE = "最大化"

    '===============================================================================

    ''' <summary>
    ''' API_WriteIni
    ''' </summary>
    ''' <param name="Section"></param>
    ''' <param name="Entry"></param>
    ''' <param name="WriteData"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function API_WriteIni(Section As String, Entry As String, WriteData As String) As Long
        Dim strPath As String = System.Reflection.Assembly.GetExecutingAssembly().Location
        Dim strIniFile As String = System.IO.Path.Combine(Application.StartupPath, System.IO.Path.GetFileNameWithoutExtension(strPath) & ".ini")

        Return WritePrivateProfileString(Section, Entry, WriteData, strIniFile)
    End Function

    ''' <summary>
    ''' API_ReadINI
    ''' </summary>
    ''' <param name="Section"></param>
    ''' <param name="Entry"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function API_ReadINI(Section As String, Entry As String) As String
        Dim strPath As String = System.Reflection.Assembly.GetExecutingAssembly().Location
        Dim strIniFile As String = System.IO.Path.Combine(Application.StartupPath, System.IO.Path.GetFileNameWithoutExtension(strPath) & ".ini")

        If (System.IO.File.Exists(strIniFile) = False) Then
            Return vbNullString
        Else
            Dim strParam As String = Space(65535)
            Dim lRet As Long = GetPrivateProfileString(Section, Entry, "", strParam, 65535, strIniFile)
            Return Left(strParam, InStr(strParam, Chr(0)) - 1)
        End If
    End Function

    ''' <summary>
    ''' ini読み書き
    ''' </summary>
    ''' <param name="rw"></param>
    ''' <returns></returns>
    Public Function G_RWOption(ByVal rw As EN_RW) As Boolean
        Dim bRet As Boolean = True

        Try
            Select Case rw
                Case EN_RW.read
                    If API_ReadINI(ZZ_SECTION, ZZ_KEY_TIME) <> "" Then
                        XX_Option.iTime = API_ReadINI(ZZ_SECTION, ZZ_KEY_TIME)
                        XX_Option.iStartTime = API_ReadINI(ZZ_SECTION, ZZ_KEY_STARTTIME)
                        XX_Option.iChangeTime = API_ReadINI(ZZ_SECTION, ZZ_KEY_CHANGETIME)
                        XX_Option.cBackColor = New ColorConverter().ConvertFromString(API_ReadINI(ZZ_SECTION, ZZ_KEY_BACKCOLOR))
                        XX_Option.cStartColor = New ColorConverter().ConvertFromString(API_ReadINI(ZZ_SECTION, ZZ_KEY_STARTCOLOR))
                        XX_Option.cTimerColor = New ColorConverter().ConvertFromString(API_ReadINI(ZZ_SECTION, ZZ_KEY_TIMERCOLOR))
                        XX_Option.cChangeColor = New ColorConverter().ConvertFromString(API_ReadINI(ZZ_SECTION, ZZ_KEY_CHANGECOLOR))
                        '
                        XX_Option.iWidth = Val(API_ReadINI(ZZ_SECTION, ZZ_KEY_WIDTH))
                        XX_Option.iHeight = Val(API_ReadINI(ZZ_SECTION, ZZ_KEY_HEIGHT))
                        XX_Option.iTop = Val(API_ReadINI(ZZ_SECTION, ZZ_KEY_TOP))
                        XX_Option.iLeft = Val(API_ReadINI(ZZ_SECTION, ZZ_KEY_LEFT))
                        XX_Option.bMaximized = API_ReadINI(ZZ_SECTION, ZZ_KEY_MAXIMIZE)
                    Else
                        XX_Option.iTime = 90
                        XX_Option.iStartTime = 10
                        XX_Option.iChangeTime = 30
                        XX_Option.cBackColor = Color.White
                        XX_Option.cStartColor = Color.Blue
                        XX_Option.cTimerColor = Color.Black
                        XX_Option.cChangeColor = Color.Red
                        '
                        XX_Option.iWidth = frmMain.MinimumSize.Width
                        XX_Option.iHeight = frmMain.MinimumSize.Height
                        XX_Option.iTop = 0
                        XX_Option.iLeft = 0
                    End If
                Case EN_RW.write
                    Call API_WriteIni(ZZ_SECTION, ZZ_KEY_TIME, XX_Option.iTime.ToString)
                    Call API_WriteIni(ZZ_SECTION, ZZ_KEY_STARTTIME, XX_Option.iStartTime.ToString)
                    Call API_WriteIni(ZZ_SECTION, ZZ_KEY_CHANGETIME, XX_Option.iChangeTime.ToString)
                    Call API_WriteIni(ZZ_SECTION, ZZ_KEY_BACKCOLOR, New ColorConverter().ConvertToString(XX_Option.cBackColor))
                    Call API_WriteIni(ZZ_SECTION, ZZ_KEY_STARTCOLOR, New ColorConverter().ConvertToString(XX_Option.cStartColor))
                    Call API_WriteIni(ZZ_SECTION, ZZ_KEY_TIMERCOLOR, New ColorConverter().ConvertToString(XX_Option.cTimerColor))
                    Call API_WriteIni(ZZ_SECTION, ZZ_KEY_CHANGECOLOR, New ColorConverter().ConvertToString(XX_Option.cChangeColor))
                    Call API_WriteIni(ZZ_SECTION, ZZ_KEY_WIDTH, XX_Option.iWidth.ToString)
                    Call API_WriteIni(ZZ_SECTION, ZZ_KEY_HEIGHT, XX_Option.iHeight.ToString)
                    Call API_WriteIni(ZZ_SECTION, ZZ_KEY_TOP, XX_Option.iTop.ToString)
                    Call API_WriteIni(ZZ_SECTION, ZZ_KEY_LEFT, XX_Option.iLeft.ToString)
                    Call API_WriteIni(ZZ_SECTION, ZZ_KEY_MAXIMIZE, XX_Option.bMaximized)
            End Select
        Catch ex As Exception
            bRet = False
            MessageBox.Show(ex.Message, Reflection.MethodBase.GetCurrentMethod.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        Return bRet
    End Function
End Module
