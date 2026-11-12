
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Khai báo các Control
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;

        private DateTimePicker dtpBirthDate;

        private RadioButton rdoMale;
        private RadioButton rdoFemale;

        private CheckBox chkTerms;

        private Button btnRegister;
        private Button btnReset;

        private System.Windows.Forms.ErrorProvider epCheck;

        public Form1()
        {
            // Không cần gọi InitializeComponent()
            CreateInterface();
        }

        private void CreateInterface()
        {
            // Cấu hình Form
            this.Text = "Đăng ký tài khoản";
            this.Size = new Size(1000, 780);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(240, 244, 250);
            this.Font = new Font("Segoe UI", 10);

            // ErrorProvider
            epCheck = new System.Windows.Forms.ErrorProvider();
            epCheck.ContainerControl = this;
            epCheck.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            // Khung chính
            Panel mainPanel = new Panel();
            mainPanel.Size = new Size(760, 690);
            mainPanel.Location = new Point(112, 25);
            mainPanel.BackColor = Color.White;
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(mainPanel);

            // Header
            Panel header = new Panel();
            header.Size = new Size(758, 125);
            header.Location = new Point(0, 0);
            header.BackColor = Color.FromArgb(35, 91, 165);
            mainPanel.Controls.Add(header);

            Label lblTitle = new Label();
            lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN";
            lblTitle.Font = new Font("Segoe UI", 23, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(180, 25);
            header.Controls.Add(lblTitle);

            Label lblSubtitle = new Label();
            lblSubtitle.Text = "Tạo tài khoản mới để bắt đầu sử dụng dịch vụ";
            lblSubtitle.Font = new Font("Segoe UI", 10);
            lblSubtitle.ForeColor = Color.FromArgb(220, 235, 255);
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(195, 75);
            header.Controls.Add(lblSubtitle);

            // Phần thông tin cá nhân
            Label lblAccount = new Label();
            lblAccount.Text = "THÔNG TIN TÀI KHOẢN";
            lblAccount.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblAccount.ForeColor = Color.FromArgb(35, 91, 165);
            lblAccount.AutoSize = true;
            lblAccount.Location = new Point(65, 150);
            mainPanel.Controls.Add(lblAccount);

            // Tên đăng nhập
            AddLabel(mainPanel, "Tên đăng nhập", 65, 195);

            txtUsername = AddTextBox(mainPanel, 65, 220, 625);
            txtUsername.PlaceholderText = "Nhập tên đăng nhập";

            // Mật khẩu
            AddLabel(mainPanel, "Mật khẩu", 65, 275);

            txtPassword = AddTextBox(mainPanel, 65, 300, 625);
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.PlaceholderText = "Nhập mật khẩu";

            // Xác nhận mật khẩu
            AddLabel(mainPanel, "Xác nhận mật khẩu", 65, 355);

            txtConfirmPassword = AddTextBox(mainPanel, 65, 380, 625);
            txtConfirmPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.PlaceholderText = "Nhập lại mật khẩu";

            // Thông tin bổ sung
            Label lblExtra = new Label();
            lblExtra.Text = "THÔNG TIN BỔ SUNG";
            lblExtra.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblExtra.ForeColor = Color.FromArgb(35, 91, 165);
            lblExtra.AutoSize = true;
            lblExtra.Location = new Point(65, 435);
            mainPanel.Controls.Add(lblExtra);

            // Ngày sinh
            AddLabel(mainPanel, "Ngày sinh", 65, 475);

            dtpBirthDate = new DateTimePicker();
            dtpBirthDate.Location = new Point(65, 500);
            dtpBirthDate.Size = new Size(280, 32);
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.MaxDate = DateTime.Today;
            dtpBirthDate.MinDate = new DateTime(1900, 1, 1);
            dtpBirthDate.Value = DateTime.Today.AddYears(-18);
            mainPanel.Controls.Add(dtpBirthDate);

            // Giới tính
            AddLabel(mainPanel, "Giới tính", 405, 475);

            rdoMale = new RadioButton();
            rdoMale.Text = "Nam";
            rdoMale.Location = new Point(405, 505);
            rdoMale.AutoSize = true;
            rdoMale.Checked = true;
            mainPanel.Controls.Add(rdoMale);

            rdoFemale = new RadioButton();
            rdoFemale.Text = "Nữ";
            rdoFemale.Location = new Point(500, 505);
            rdoFemale.AutoSize = true;
            mainPanel.Controls.Add(rdoFemale);

            // Điều khoản dịch vụ
            chkTerms = new CheckBox();
            chkTerms.Text = "Tôi đã đọc và đồng ý với Điều khoản dịch vụ";
            chkTerms.Location = new Point(65, 555);
            chkTerms.AutoSize = true;
            chkTerms.Font = new Font("Segoe UI", 10);
            mainPanel.Controls.Add(chkTerms);

            // Nút Đăng ký
            btnRegister = new Button();
            btnRegister.Text = "ĐĂNG KÝ";
            btnRegister.Location = new Point(180, 610);
            btnRegister.Size = new Size(180, 45);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.BackColor = Color.FromArgb(35, 91, 165);
            btnRegister.ForeColor = Color.White;
            btnRegister.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Click += BtnRegister_Click;
            mainPanel.Controls.Add(btnRegister);

            // Nút Làm mới
            btnReset = new Button();
            btnReset.Text = "LÀM MỚI";
            btnReset.Location = new Point(400, 610);
            btnReset.Size = new Size(180, 45);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.FlatAppearance.BorderSize = 1;
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(35, 91, 165);
            btnReset.BackColor = Color.White;
            btnReset.ForeColor = Color.FromArgb(35, 91, 165);
            btnReset.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnReset.Cursor = Cursors.Hand;
            btnReset.Click += BtnReset_Click;
            mainPanel.Controls.Add(btnReset);
        }

        // Hàm tạo Label
        private void AddLabel(Control parent, string text, int x, int y)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.Location = new Point(x, y);
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(55, 65, 81);
            parent.Controls.Add(lbl);
        }

        // Hàm tạo TextBox
        private TextBox AddTextBox(Control parent, int x, int y, int width)
        {
            TextBox txt = new TextBox();
            txt.Location = new Point(x, y);
            txt.Size = new Size(width, 32);
            txt.Font = new Font("Segoe UI", 11);
            txt.BorderStyle = BorderStyle.FixedSingle;
            parent.Controls.Add(txt);

            return txt;
        }

        // Xử lý nút Đăng ký
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Xóa thông báo lỗi cũ
            epCheck.Clear();

            bool isValid = true;

            // Kiểm tra tên đăng nhập
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                epCheck.SetError(txtUsername,
                    "Tên đăng nhập không được để trống!");
                isValid = false;
            }

            // Kiểm tra mật khẩu
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                epCheck.SetError(txtPassword,
                    "Mật khẩu không được để trống!");
                isValid = false;
            }

            // Kiểm tra xác nhận mật khẩu
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                epCheck.SetError(txtConfirmPassword,
                    "Vui lòng xác nhận mật khẩu!");
                isValid = false;
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                epCheck.SetError(txtConfirmPassword,
                    "Mật khẩu xác nhận không khớp!");
                isValid = false;
            }

            // Tính tuổi
            DateTime today = DateTime.Today;
            DateTime birthDate = dtpBirthDate.Value;

            int age = today.Year - birthDate.Year;

            if (birthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            // Kiểm tra độ tuổi
            if (age < 18)
            {
                epCheck.SetError(dtpBirthDate,
                    "Người đăng ký phải đủ 18 tuổi!");
                isValid = false;
            }

            // Kiểm tra điều khoản
            if (!chkTerms.Checked)
            {
                epCheck.SetError(chkTerms,
                    "Bạn phải đồng ý với điều khoản dịch vụ!");
                isValid = false;
            }

            // Nếu dữ liệu không hợp lệ
            if (!isValid)
            {
                MessageBox.Show(
                    "Vui lòng kiểm tra lại thông tin đăng ký!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Nếu tất cả dữ liệu hợp lệ
            string gender = rdoMale.Checked ? "Nam" : "Nữ";

            MessageBox.Show(
                "ĐĂNG KÝ TÀI KHOẢN THÀNH CÔNG!\n\n" +
                "Tên đăng nhập: " + txtUsername.Text + "\n" +
                "Ngày sinh: " + dtpBirthDate.Value.ToString("dd/MM/yyyy") + "\n" +
                "Tuổi: " + age + "\n" +
                "Giới tính: " + gender,
                "Đăng ký thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // Xử lý nút Làm mới
        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();

            dtpBirthDate.Value = DateTime.Today.AddYears(-18);

            rdoMale.Checked = true;
            chkTerms.Checked = false;

            epCheck.Clear();

            txtUsername.Focus();
        }
    }
}
