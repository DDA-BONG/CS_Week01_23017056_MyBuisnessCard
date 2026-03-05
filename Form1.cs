
namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // pictureBox1에 마우스가 올라가거나 나갈 때 테두리 변경
            pictureBox1.MouseEnter += PictureBox1_MouseEnter;
            pictureBox1.MouseLeave += PictureBox1_MouseLeave;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            // 0-255 사이의 R, G, B 값을 무작위로 생성하여 배경색에 적용
            this.BackColor = Color.FromArgb(rand.Next(200), rand.Next(200), rand.Next(256));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // 클릭 시 동작이 필요하면 여기에 추가
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D; // 마우스 올리면 테두리 변화
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None; // 마우스 나가면 원래 테두리로 복원
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/DDA-BONG",
                UseShellExecute = true
            });

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.wp5271636_seven_movie_wallpapers; // 버튼 클릭 시 이미지 변경
        }
    }
}