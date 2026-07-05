Module ThemeManager
  
    Public Sub SetProjectTheme(ByVal frm As Form, ByVal isDark As Boolean)
        If isDark Then
            frm.BackColor = Color.FromArgb(45, 45, 48)
        Else
            frm.BackColor = SystemColors.Control
        End If
    End Sub
End Module