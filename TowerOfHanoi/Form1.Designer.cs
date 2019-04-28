namespace TowerOfHanoi
{
    partial class TowerOfHanoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TowerOfHanoi));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.NumericUpDown();
            this.playbt = new System.Windows.Forms.Button();
            this.losebt = new System.Windows.Forms.Button();
            this.demobt = new System.Windows.Forms.Button();
            this.timelabel = new System.Windows.Forms.Label();
            this.movelabel = new System.Windows.Forms.Label();
            this.rulebt = new System.Windows.Forms.Button();
            this.aboutbt = new System.Windows.Forms.Button();
            this.dia1 = new System.Windows.Forms.PictureBox();
            this.dia2 = new System.Windows.Forms.PictureBox();
            this.dia3 = new System.Windows.Forms.PictureBox();
            this.dia4 = new System.Windows.Forms.PictureBox();
            this.dia5 = new System.Windows.Forms.PictureBox();
            this.dia6 = new System.Windows.Forms.PictureBox();
            this.dia7 = new System.Windows.Forms.PictureBox();
            this.CotC = new System.Windows.Forms.PictureBox();
            this.CotB = new System.Windows.Forms.PictureBox();
            this.CotA = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.highscore = new System.Windows.Forms.Label();
            this.clrHSc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CotC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CotB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CotA)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(569, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(953, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng dĩa:";
            // 
            // level
            // 
            this.level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level.Location = new System.Drawing.Point(343, 32);
            this.level.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.level.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(43, 26);
            this.level.TabIndex = 7;
            this.level.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // playbt
            // 
            this.playbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbt.Location = new System.Drawing.Point(449, 29);
            this.playbt.Name = "playbt";
            this.playbt.Size = new System.Drawing.Size(93, 29);
            this.playbt.TabIndex = 8;
            this.playbt.Text = "Chơi";
            this.playbt.UseVisualStyleBackColor = true;
            this.playbt.Click += new System.EventHandler(this.playbt_Click);
            // 
            // losebt
            // 
            this.losebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.losebt.Location = new System.Drawing.Point(573, 29);
            this.losebt.Name = "losebt";
            this.losebt.Size = new System.Drawing.Size(93, 29);
            this.losebt.TabIndex = 9;
            this.losebt.Text = "Chịu thua";
            this.losebt.UseVisualStyleBackColor = true;
            this.losebt.Click += new System.EventHandler(this.losebt_Click);
            // 
            // demobt
            // 
            this.demobt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demobt.Location = new System.Drawing.Point(727, 29);
            this.demobt.Name = "demobt";
            this.demobt.Size = new System.Drawing.Size(93, 29);
            this.demobt.TabIndex = 10;
            this.demobt.Text = "Demo";
            this.demobt.UseVisualStyleBackColor = true;
            this.demobt.Click += new System.EventHandler(this.demobt_Click);
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.Location = new System.Drawing.Point(384, 70);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(165, 22);
            this.timelabel.TabIndex = 11;
            this.timelabel.Text = "Thời gian  00:00:00";
            // 
            // movelabel
            // 
            this.movelabel.AutoSize = true;
            this.movelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movelabel.Location = new System.Drawing.Point(599, 70);
            this.movelabel.Name = "movelabel";
            this.movelabel.Size = new System.Drawing.Size(168, 22);
            this.movelabel.TabIndex = 12;
            this.movelabel.Text = "Số lần di chuyển:  0";
            // 
            // rulebt
            // 
            this.rulebt.Image = global::TowerOfHanoi.Properties.Resources.Hint;
            this.rulebt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rulebt.Location = new System.Drawing.Point(987, 12);
            this.rulebt.Name = "rulebt";
            this.rulebt.Size = new System.Drawing.Size(75, 28);
            this.rulebt.TabIndex = 21;
            this.rulebt.Text = "Help";
            this.rulebt.UseVisualStyleBackColor = true;
            this.rulebt.Click += new System.EventHandler(this.rulebt_Click);
            // 
            // aboutbt
            // 
            this.aboutbt.Image = global::TowerOfHanoi.Properties.Resources.Info;
            this.aboutbt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutbt.Location = new System.Drawing.Point(1068, 12);
            this.aboutbt.Name = "aboutbt";
            this.aboutbt.Size = new System.Drawing.Size(75, 28);
            this.aboutbt.TabIndex = 20;
            this.aboutbt.Text = "About";
            this.aboutbt.UseVisualStyleBackColor = true;
            this.aboutbt.Click += new System.EventHandler(this.aboutbt_Click);
            // 
            // dia1
            // 
            this.dia1.BackColor = System.Drawing.Color.Transparent;
            this.dia1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dia1.Image = global::TowerOfHanoi.Properties.Resources.dia1;
            this.dia1.Location = new System.Drawing.Point(156, 146);
            this.dia1.Name = "dia1";
            this.dia1.Size = new System.Drawing.Size(72, 29);
            this.dia1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dia1.TabIndex = 19;
            this.dia1.TabStop = false;
            this.dia1.Tag = "1";
            this.dia1.Visible = false;
            // 
            // dia2
            // 
            this.dia2.BackColor = System.Drawing.Color.Transparent;
            this.dia2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dia2.Enabled = false;
            this.dia2.Image = global::TowerOfHanoi.Properties.Resources.dia2;
            this.dia2.Location = new System.Drawing.Point(134, 175);
            this.dia2.Name = "dia2";
            this.dia2.Size = new System.Drawing.Size(117, 29);
            this.dia2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dia2.TabIndex = 18;
            this.dia2.TabStop = false;
            this.dia2.Tag = "2";
            this.dia2.Visible = false;
            // 
            // dia3
            // 
            this.dia3.BackColor = System.Drawing.Color.Transparent;
            this.dia3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dia3.Enabled = false;
            this.dia3.Image = global::TowerOfHanoi.Properties.Resources.dia3;
            this.dia3.Location = new System.Drawing.Point(111, 204);
            this.dia3.Name = "dia3";
            this.dia3.Size = new System.Drawing.Size(162, 29);
            this.dia3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dia3.TabIndex = 17;
            this.dia3.TabStop = false;
            this.dia3.Tag = "3";
            this.dia3.Visible = false;
            // 
            // dia4
            // 
            this.dia4.BackColor = System.Drawing.Color.Transparent;
            this.dia4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dia4.Enabled = false;
            this.dia4.Image = global::TowerOfHanoi.Properties.Resources.dia4;
            this.dia4.Location = new System.Drawing.Point(88, 233);
            this.dia4.Name = "dia4";
            this.dia4.Size = new System.Drawing.Size(209, 29);
            this.dia4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dia4.TabIndex = 16;
            this.dia4.TabStop = false;
            this.dia4.Tag = "4";
            this.dia4.Visible = false;
            // 
            // dia5
            // 
            this.dia5.BackColor = System.Drawing.Color.Transparent;
            this.dia5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dia5.Enabled = false;
            this.dia5.Image = global::TowerOfHanoi.Properties.Resources.dia5;
            this.dia5.Location = new System.Drawing.Point(64, 262);
            this.dia5.Name = "dia5";
            this.dia5.Size = new System.Drawing.Size(257, 29);
            this.dia5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dia5.TabIndex = 15;
            this.dia5.TabStop = false;
            this.dia5.Tag = "5";
            this.dia5.Visible = false;
            // 
            // dia6
            // 
            this.dia6.BackColor = System.Drawing.Color.Transparent;
            this.dia6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dia6.Enabled = false;
            this.dia6.Image = global::TowerOfHanoi.Properties.Resources.dia6;
            this.dia6.Location = new System.Drawing.Point(44, 291);
            this.dia6.Name = "dia6";
            this.dia6.Size = new System.Drawing.Size(297, 29);
            this.dia6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dia6.TabIndex = 14;
            this.dia6.TabStop = false;
            this.dia6.Tag = "6";
            this.dia6.Visible = false;
            // 
            // dia7
            // 
            this.dia7.BackColor = System.Drawing.Color.Transparent;
            this.dia7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dia7.Enabled = false;
            this.dia7.Image = global::TowerOfHanoi.Properties.Resources.dia7;
            this.dia7.Location = new System.Drawing.Point(27, 320);
            this.dia7.Name = "dia7";
            this.dia7.Size = new System.Drawing.Size(330, 29);
            this.dia7.TabIndex = 13;
            this.dia7.TabStop = false;
            this.dia7.Tag = "7";
            this.dia7.Visible = false;
            // 
            // CotC
            // 
            this.CotC.BackColor = System.Drawing.Color.Transparent;
            this.CotC.Enabled = false;
            this.CotC.Image = global::TowerOfHanoi.Properties.Resources.cot;
            this.CotC.Location = new System.Drawing.Point(773, 131);
            this.CotC.Name = "CotC";
            this.CotC.Size = new System.Drawing.Size(379, 245);
            this.CotC.TabIndex = 2;
            this.CotC.TabStop = false;
            this.CotC.Tag = "3";
            // 
            // CotB
            // 
            this.CotB.BackColor = System.Drawing.Color.Transparent;
            this.CotB.Enabled = false;
            this.CotB.Image = global::TowerOfHanoi.Properties.Resources.cot;
            this.CotB.Location = new System.Drawing.Point(388, 131);
            this.CotB.Name = "CotB";
            this.CotB.Size = new System.Drawing.Size(379, 245);
            this.CotB.TabIndex = 1;
            this.CotB.TabStop = false;
            this.CotB.Tag = "2";
            // 
            // CotA
            // 
            this.CotA.Enabled = false;
            this.CotA.Image = global::TowerOfHanoi.Properties.Resources.cot;
            this.CotA.Location = new System.Drawing.Point(3, 131);
            this.CotA.Name = "CotA";
            this.CotA.Size = new System.Drawing.Size(379, 245);
            this.CotA.TabIndex = 0;
            this.CotA.TabStop = false;
            this.CotA.Tag = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "High Score";
            // 
            // highscore
            // 
            this.highscore.AutoSize = true;
            this.highscore.Location = new System.Drawing.Point(24, 79);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(49, 13);
            this.highscore.TabIndex = 23;
            this.highscore.Text = "              ";
            // 
            // clrHSc
            // 
            this.clrHSc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrHSc.Location = new System.Drawing.Point(44, 102);
            this.clrHSc.Name = "clrHSc";
            this.clrHSc.Size = new System.Drawing.Size(43, 23);
            this.clrHSc.TabIndex = 24;
            this.clrHSc.Text = "Clear";
            this.clrHSc.UseVisualStyleBackColor = true;
            this.clrHSc.Click += new System.EventHandler(this.clrHSc_Click);
            // 
            // TowerOfHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 409);
            this.Controls.Add(this.clrHSc);
            this.Controls.Add(this.highscore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rulebt);
            this.Controls.Add(this.aboutbt);
            this.Controls.Add(this.dia1);
            this.Controls.Add(this.dia2);
            this.Controls.Add(this.dia3);
            this.Controls.Add(this.dia4);
            this.Controls.Add(this.dia5);
            this.Controls.Add(this.dia6);
            this.Controls.Add(this.dia7);
            this.Controls.Add(this.movelabel);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.demobt);
            this.Controls.Add(this.losebt);
            this.Controls.Add(this.playbt);
            this.Controls.Add(this.level);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CotC);
            this.Controls.Add(this.CotB);
            this.Controls.Add(this.CotA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TowerOfHanoi";
            this.Text = "Tower of Hanoi";
            ((System.ComponentModel.ISupportInitialize)(this.level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dia7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CotC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CotB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CotA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox CotA;
        private System.Windows.Forms.PictureBox CotB;
        private System.Windows.Forms.PictureBox CotC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown level;
        private System.Windows.Forms.Button playbt;
        private System.Windows.Forms.Button losebt;
        private System.Windows.Forms.Button demobt;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label movelabel;
        private System.Windows.Forms.PictureBox dia7;
        private System.Windows.Forms.PictureBox dia6;
        private System.Windows.Forms.PictureBox dia5;
        private System.Windows.Forms.PictureBox dia4;
        private System.Windows.Forms.PictureBox dia3;
        private System.Windows.Forms.PictureBox dia2;
        private System.Windows.Forms.PictureBox dia1;
        private System.Windows.Forms.Button aboutbt;
        private System.Windows.Forms.Button rulebt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label highscore;
        private System.Windows.Forms.Button clrHSc;
    }
}

