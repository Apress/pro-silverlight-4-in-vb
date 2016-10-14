Partial Public Class CustomWindow
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub titleBar_MouseLeftButtonDown(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)
        Application.Current.MainWindow.DragMove()
    End Sub

    Private Sub cmdMinimize_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Application.Current.MainWindow.WindowState = WindowState.Minimized
    End Sub

    Private Sub cmdMaximize_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        If Application.Current.MainWindow.WindowState = WindowState.Normal Then
            Application.Current.MainWindow.WindowState = WindowState.Maximized
        Else
            Application.Current.MainWindow.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Application.Current.MainWindow.Close()
    End Sub

    Private Sub rect_Resize(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)
        If sender Is rect_TopLeftCorner Then
            Application.Current.MainWindow.DragResize(WindowResizeEdge.TopLeft)
        ElseIf sender Is rect_TopEdge Then
            Application.Current.MainWindow.DragResize(WindowResizeEdge.Top)
        ElseIf sender Is rect_TopRightCorner Then
            Application.Current.MainWindow.DragResize(WindowResizeEdge.TopRight)
        ElseIf sender Is rect_LeftEdge Then
            Application.Current.MainWindow.DragResize(WindowResizeEdge.Left)
        ElseIf sender Is rect_RightEdge Then
            Application.Current.MainWindow.DragResize(WindowResizeEdge.Right)
        ElseIf sender Is rect_BottomLeftCorner Then
            Application.Current.MainWindow.DragResize(WindowResizeEdge.BottomLeft)
        ElseIf sender Is rect_BottomEdge Then
            Application.Current.MainWindow.DragResize(WindowResizeEdge.Bottom)
        ElseIf sender Is rect_BottomRightCorner Then
            Application.Current.MainWindow.DragResize(WindowResizeEdge.BottomRight)
        End If
    End Sub
End Class
