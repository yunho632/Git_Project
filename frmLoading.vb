Public Class frmLoading

    Private Sub frmLoading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' PictureBox1.Image = Image.FromFile(Application.StartupPath + "\Loading.png")
    End Sub

    Public Sub New()

         InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        tablayoutLoading.Parent = PictureBox1
        lbMainTitle.Parent = tablayoutLoading
        picMaker.Image = Image.FromFile(Application.StartupPath + "\CI.png")
        picCustomerCI.Image = Image.FromFile(Application.StartupPath + "\logo.png")
    End Sub
End Class
