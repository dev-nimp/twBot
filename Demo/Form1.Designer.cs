namespace Demo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.login_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.passoword = new System.Windows.Forms.TextBox();
            this.Arana = new System.Windows.Forms.Button();
            this.Arena_count = new System.Windows.Forms.TextBox();
            this.arena_label = new System.Windows.Forms.Label();
            this.Collisey = new System.Windows.Forms.Button();
            this.Colliseu_label = new System.Windows.Forms.Label();
            this.Colliseu_count = new System.Windows.Forms.TextBox();
            this.Timeout_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeout_count = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Открыть браузер";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(38, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(248, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Авторизация";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(35, 116);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(47, 17);
            this.login_label.TabIndex = 3;
            this.login_label.Text = "Логин";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_label.Location = new System.Drawing.Point(35, 142);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(57, 17);
            this.Password_label.TabIndex = 3;
            this.Password_label.Text = "Пароль";
            // 
            // login
            // 
            this.login.Enabled = false;
            this.login.Location = new System.Drawing.Point(98, 116);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(188, 20);
            this.login.TabIndex = 4;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // passoword
            // 
            this.passoword.Enabled = false;
            this.passoword.Location = new System.Drawing.Point(98, 142);
            this.passoword.Name = "passoword";
            this.passoword.Size = new System.Drawing.Size(188, 20);
            this.passoword.TabIndex = 5;
            this.passoword.TextChanged += new System.EventHandler(this.passoword_TextChanged);
            // 
            // Arana
            // 
            this.Arana.Enabled = false;
            this.Arana.Location = new System.Drawing.Point(38, 182);
            this.Arana.Name = "Arana";
            this.Arana.Size = new System.Drawing.Size(75, 23);
            this.Arana.TabIndex = 6;
            this.Arana.Text = "Арена";
            this.Arana.UseVisualStyleBackColor = true;
            this.Arana.Click += new System.EventHandler(this.Arana_Click);
            // 
            // Arena_count
            // 
            this.Arena_count.Enabled = false;
            this.Arena_count.Location = new System.Drawing.Point(246, 185);
            this.Arena_count.Name = "Arena_count";
            this.Arena_count.Size = new System.Drawing.Size(40, 20);
            this.Arena_count.TabIndex = 7;
            this.Arena_count.Text = "1";
            // 
            // arena_label
            // 
            this.arena_label.AutoSize = true;
            this.arena_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arena_label.Location = new System.Drawing.Point(119, 185);
            this.arena_label.Name = "arena_label";
            this.arena_label.Size = new System.Drawing.Size(121, 17);
            this.arena_label.TabIndex = 8;
            this.arena_label.Text = "Количество боев";
            // 
            // Collisey
            // 
            this.Collisey.Enabled = false;
            this.Collisey.Location = new System.Drawing.Point(38, 221);
            this.Collisey.Name = "Collisey";
            this.Collisey.Size = new System.Drawing.Size(75, 23);
            this.Collisey.TabIndex = 9;
            this.Collisey.Text = "Коллизей";
            this.Collisey.UseVisualStyleBackColor = true;
            // 
            // Colliseu_label
            // 
            this.Colliseu_label.AutoSize = true;
            this.Colliseu_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Colliseu_label.Location = new System.Drawing.Point(119, 222);
            this.Colliseu_label.Name = "Colliseu_label";
            this.Colliseu_label.Size = new System.Drawing.Size(121, 17);
            this.Colliseu_label.TabIndex = 10;
            this.Colliseu_label.Text = "Количество боев";
            this.Colliseu_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Colliseu_count
            // 
            this.Colliseu_count.Enabled = false;
            this.Colliseu_count.Location = new System.Drawing.Point(246, 221);
            this.Colliseu_count.Name = "Colliseu_count";
            this.Colliseu_count.Size = new System.Drawing.Size(40, 20);
            this.Colliseu_count.TabIndex = 11;
            this.Colliseu_count.Text = "1";
            // 
            // Timeout_label
            // 
            this.Timeout_label.AutoSize = true;
            this.Timeout_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timeout_label.Location = new System.Drawing.Point(38, 264);
            this.Timeout_label.Name = "Timeout_label";
            this.Timeout_label.Size = new System.Drawing.Size(64, 17);
            this.Timeout_label.TabIndex = 12;
            this.Timeout_label.Text = "Таймаут";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(233, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "мс";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // timeout_count
            // 
            this.timeout_count.Enabled = false;
            this.timeout_count.Location = new System.Drawing.Point(122, 264);
            this.timeout_count.Name = "timeout_count";
            this.timeout_count.Size = new System.Drawing.Size(100, 20);
            this.timeout_count.TabIndex = 14;
            this.timeout_count.Text = "1000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 364);
            this.Controls.Add(this.timeout_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Timeout_label);
            this.Controls.Add(this.Colliseu_count);
            this.Controls.Add(this.Colliseu_label);
            this.Controls.Add(this.Collisey);
            this.Controls.Add(this.arena_label);
            this.Controls.Add(this.Arena_count);
            this.Controls.Add(this.Arana);
            this.Controls.Add(this.passoword);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TiWar Bot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox passoword;
        private System.Windows.Forms.Button Arana;
        private System.Windows.Forms.TextBox Arena_count;
        private System.Windows.Forms.Label arena_label;
        private System.Windows.Forms.Button Collisey;
        private System.Windows.Forms.Label Colliseu_label;
        private System.Windows.Forms.TextBox Colliseu_count;
        private System.Windows.Forms.Label Timeout_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timeout_count;
    }
}

