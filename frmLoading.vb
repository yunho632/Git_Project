Public Class frmLoading

    Private Sub frmLoading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' PictureBox1.Image = Image.FromFile(Application.StartupPath + "\Loading.png")
    End Sub

    Public Sub New()
        
        'today
        'today

        ' 이 호출은 디자이너에 필요합니다.
        'InitializeComponent()
        '테스트
        'InitializeComponent().
        tablayoutLoading.Parent = PictureBox1
        lbMainTitle.Parent = tablayoutLoading
        picMaker.Image = My.Resources.MiraeVisionLogo ' Image.FromFile(Application.StartupPath + "\CI.png")
        picCustomerCI.Image = My.Resources.HanonLogo ' Image.FromFile(Application.StartupPath + "\logo.png")
    End Sub
End Class
