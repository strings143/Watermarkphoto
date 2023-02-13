namespace pvd_camera
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.image = new AForge.Controls.VideoSourcePlayer();
            this.open_btn = new System.Windows.Forms.Button();
            this.take_photo = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
            this.file_name = new System.Windows.Forms.Label();
            this.file_name_value = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.size = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paint = new System.Windows.Forms.Button();
            this.paiint_name = new System.Windows.Forms.Label();
            this.paint_size = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.left_num = new System.Windows.Forms.NumericUpDown();
            this.right_num = new System.Windows.Forms.NumericUpDown();
            this.up_num = new System.Windows.Forms.NumericUpDown();
            this.down_num = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.size_up = new System.Windows.Forms.NumericUpDown();
            this.size_down = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.left_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.down_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_down)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.Linen;
            this.image.BorderColor = System.Drawing.Color.Maroon;
            this.image.Location = new System.Drawing.Point(26, 27);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(650, 650);
            this.image.TabIndex = 0;
            this.image.Text = "image";
            this.image.VideoSource = null;
            // 
            // open_btn
            // 
            this.open_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.open_btn.BackColor = System.Drawing.Color.Thistle;
            this.open_btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.open_btn.ForeColor = System.Drawing.Color.MediumPurple;
            this.open_btn.Location = new System.Drawing.Point(682, 641);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(93, 36);
            this.open_btn.TabIndex = 1;
            this.open_btn.Text = "開啟相機";
            this.open_btn.UseVisualStyleBackColor = false;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // take_photo
            // 
            this.take_photo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.take_photo.Location = new System.Drawing.Point(590, 721);
            this.take_photo.Name = "take_photo";
            this.take_photo.Size = new System.Drawing.Size(75, 35);
            this.take_photo.TabIndex = 2;
            this.take_photo.Text = "拍照";
            this.take_photo.UseVisualStyleBackColor = true;
            this.take_photo.Click += new System.EventHandler(this.take_photo_Click);
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Font = new System.Drawing.Font("微軟正黑體", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.path.Location = new System.Drawing.Point(49, 691);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(91, 24);
            this.path.TabIndex = 4;
            this.path.Text = "檔案位置:";
            // 
            // select
            // 
            this.select.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.select.Location = new System.Drawing.Point(590, 683);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(118, 32);
            this.select.TabIndex = 5;
            this.select.Text = "選擇資料夾";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // file_name
            // 
            this.file_name.AutoSize = true;
            this.file_name.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.file_name.ForeColor = System.Drawing.Color.DarkRed;
            this.file_name.Location = new System.Drawing.Point(20, 726);
            this.file_name.Name = "file_name";
            this.file_name.Size = new System.Drawing.Size(130, 35);
            this.file_name.TabIndex = 6;
            this.file_name.Text = "檔案名稱:";
            // 
            // file_name_value
            // 
            this.file_name_value.BackColor = System.Drawing.Color.Snow;
            this.file_name_value.Font = new System.Drawing.Font("標楷體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.file_name_value.Location = new System.Drawing.Point(156, 726);
            this.file_name_value.Multiline = true;
            this.file_name_value.Name = "file_name_value";
            this.file_name_value.Size = new System.Drawing.Size(404, 30);
            this.file_name_value.TabIndex = 7;
            // 
            // number
            // 
            this.number.BackColor = System.Drawing.Color.Snow;
            this.number.Font = new System.Drawing.Font("標楷體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number.Location = new System.Drawing.Point(764, 70);
            this.number.Multiline = true;
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(297, 34);
            this.number.TabIndex = 8;
            // 
            // size
            // 
            this.size.BackColor = System.Drawing.Color.Snow;
            this.size.Font = new System.Drawing.Font("標楷體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.size.Location = new System.Drawing.Point(764, 296);
            this.size.Multiline = true;
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(297, 39);
            this.size.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(723, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "產品編號:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(729, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 40);
            this.label2.TabIndex = 11;
            this.label2.Text = "尺寸:";
            // 
            // paint
            // 
            this.paint.BackColor = System.Drawing.Color.Thistle;
            this.paint.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.paint.ForeColor = System.Drawing.Color.MediumPurple;
            this.paint.Location = new System.Drawing.Point(978, 413);
            this.paint.Name = "paint";
            this.paint.Size = new System.Drawing.Size(89, 46);
            this.paint.TabIndex = 12;
            this.paint.Text = "確認";
            this.paint.UseVisualStyleBackColor = false;
            this.paint.Click += new System.EventHandler(this.paint_Click);
            // 
            // paiint_name
            // 
            this.paiint_name.AutoSize = true;
            this.paiint_name.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.paiint_name.ForeColor = System.Drawing.Color.Red;
            this.paiint_name.Location = new System.Drawing.Point(41, 66);
            this.paiint_name.Name = "paiint_name";
            this.paiint_name.Size = new System.Drawing.Size(0, 13);
            this.paiint_name.TabIndex = 13;
            // 
            // paint_size
            // 
            this.paint_size.AutoSize = true;
            this.paint_size.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.paint_size.ForeColor = System.Drawing.Color.Red;
            this.paint_size.Location = new System.Drawing.Point(41, 91);
            this.paint_size.Name = "paint_size";
            this.paint_size.Size = new System.Drawing.Size(0, 13);
            this.paint_size.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(769, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 35);
            this.label3.TabIndex = 15;
            this.label3.Text = "左:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(923, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 35);
            this.label4.TabIndex = 16;
            this.label4.Text = "右:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(769, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 35);
            this.label5.TabIndex = 17;
            this.label5.Text = "上:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(923, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 35);
            this.label6.TabIndex = 18;
            this.label6.Text = "下:";
            // 
            // left_num
            // 
            this.left_num.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.left_num.Location = new System.Drawing.Point(824, 136);
            this.left_num.Name = "left_num";
            this.left_num.Size = new System.Drawing.Size(68, 25);
            this.left_num.TabIndex = 19;
            // 
            // right_num
            // 
            this.right_num.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.right_num.Location = new System.Drawing.Point(978, 136);
            this.right_num.Name = "right_num";
            this.right_num.Size = new System.Drawing.Size(69, 25);
            this.right_num.TabIndex = 20;
            // 
            // up_num
            // 
            this.up_num.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.up_num.Location = new System.Drawing.Point(824, 183);
            this.up_num.Name = "up_num";
            this.up_num.Size = new System.Drawing.Size(68, 25);
            this.up_num.TabIndex = 21;
            // 
            // down_num
            // 
            this.down_num.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.down_num.Location = new System.Drawing.Point(978, 185);
            this.down_num.Name = "down_num";
            this.down_num.Size = new System.Drawing.Size(69, 25);
            this.down_num.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(769, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 35);
            this.label7.TabIndex = 23;
            this.label7.Text = "上:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(923, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 35);
            this.label8.TabIndex = 24;
            this.label8.Text = "下:";
            // 
            // size_up
            // 
            this.size_up.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.size_up.Location = new System.Drawing.Point(824, 345);
            this.size_up.Name = "size_up";
            this.size_up.Size = new System.Drawing.Size(68, 25);
            this.size_up.TabIndex = 25;
            // 
            // size_down
            // 
            this.size_down.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.size_down.Location = new System.Drawing.Point(978, 345);
            this.size_down.Name = "size_down";
            this.size_down.Size = new System.Drawing.Size(69, 25);
            this.size_down.TabIndex = 26;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(682, 603);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(359, 32);
            this.comboBox1.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1129, 770);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.size_down);
            this.Controls.Add(this.size_up);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.down_num);
            this.Controls.Add(this.up_num);
            this.Controls.Add(this.right_num);
            this.Controls.Add(this.left_num);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.paint_size);
            this.Controls.Add(this.paiint_name);
            this.Controls.Add(this.paint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.size);
            this.Controls.Add(this.number);
            this.Controls.Add(this.file_name_value);
            this.Controls.Add(this.file_name);
            this.Controls.Add(this.select);
            this.Controls.Add(this.path);
            this.Controls.Add(this.take_photo);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.image);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.SlateBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "滿益金拍攝軟體";
            this.TransparencyKey = System.Drawing.Color.Purple;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.left_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.down_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_down)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer image;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Button take_photo;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Label file_name;
        private System.Windows.Forms.TextBox file_name_value;
        public System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button paint;
        private System.Windows.Forms.Label paiint_name;
        private System.Windows.Forms.Label paint_size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown left_num;
        private System.Windows.Forms.NumericUpDown right_num;
        private System.Windows.Forms.NumericUpDown up_num;
        private System.Windows.Forms.NumericUpDown down_num;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown size_up;
        private System.Windows.Forms.NumericUpDown size_down;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

