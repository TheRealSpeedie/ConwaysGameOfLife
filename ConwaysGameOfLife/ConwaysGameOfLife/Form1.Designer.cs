namespace ConwaysGameOfLife
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_generation = new System.Windows.Forms.Label();
            this.lbl_amountAliveCells = new System.Windows.Forms.Label();
            this.lbl_changedCells = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_template_gun = new System.Windows.Forms.Button();
            this.btn_template_blink = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_template_glider = new System.Windows.Forms.Button();
            this.btn_template_block = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_step = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_random = new System.Windows.Forms.Button();
            this.trackbar_speed = new System.Windows.Forms.TrackBar();
            this.panel_field = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_field, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1183, 836);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.lbl_generation, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_amountAliveCells, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbl_changedCells, 1, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(13, 605);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(342, 218);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(18, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "STATS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.label5.Location = new System.Drawing.Point(18, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "🔄 Generation:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.label6.Location = new System.Drawing.Point(18, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "💚 Alive:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.label7.Location = new System.Drawing.Point(18, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "👥 Rate of change:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_generation
            // 
            this.lbl_generation.AutoSize = true;
            this.lbl_generation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_generation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_generation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.lbl_generation.Location = new System.Drawing.Point(174, 40);
            this.lbl_generation.Name = "lbl_generation";
            this.lbl_generation.Size = new System.Drawing.Size(150, 25);
            this.lbl_generation.TabIndex = 16;
            this.lbl_generation.Text = "0";
            this.lbl_generation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_amountAliveCells
            // 
            this.lbl_amountAliveCells.AutoSize = true;
            this.lbl_amountAliveCells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_amountAliveCells.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amountAliveCells.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(150)))));
            this.lbl_amountAliveCells.Location = new System.Drawing.Point(174, 65);
            this.lbl_amountAliveCells.Name = "lbl_amountAliveCells";
            this.lbl_amountAliveCells.Size = new System.Drawing.Size(150, 25);
            this.lbl_amountAliveCells.TabIndex = 17;
            this.lbl_amountAliveCells.Text = "0";
            this.lbl_amountAliveCells.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_changedCells
            // 
            this.lbl_changedCells.AutoSize = true;
            this.lbl_changedCells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_changedCells.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_changedCells.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.lbl_changedCells.Location = new System.Drawing.Point(174, 90);
            this.lbl_changedCells.Name = "lbl_changedCells";
            this.lbl_changedCells.Size = new System.Drawing.Size(150, 25);
            this.lbl_changedCells.TabIndex = 18;
            this.lbl_changedCells.Text = "0";
            this.lbl_changedCells.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btn_template_gun, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btn_template_blink, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_template_glider, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_template_block, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 309);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(342, 290);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btn_template_gun
            // 
            this.btn_template_gun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.btn_template_gun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_template_gun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.btn_template_gun.FlatAppearance.BorderSize = 2;
            this.btn_template_gun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.btn_template_gun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(60)))), ((int)(((byte)(140)))));
            this.btn_template_gun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_template_gun.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_template_gun.ForeColor = System.Drawing.Color.White;
            this.btn_template_gun.Location = new System.Drawing.Point(18, 133);
            this.btn_template_gun.Name = "btn_template_gun";
            this.btn_template_gun.Size = new System.Drawing.Size(306, 34);
            this.btn_template_gun.TabIndex = 10;
            this.btn_template_gun.Text = "🔫 GLIDER GUN";
            this.btn_template_gun.UseVisualStyleBackColor = false;
            this.btn_template_gun.Click += new System.EventHandler(this.btn_template_gun_Click);
            // 
            // btn_template_blink
            // 
            this.btn_template_blink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.btn_template_blink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_template_blink.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btn_template_blink.FlatAppearance.BorderSize = 2;
            this.btn_template_blink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.btn_template_blink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_template_blink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_template_blink.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_template_blink.ForeColor = System.Drawing.Color.White;
            this.btn_template_blink.Location = new System.Drawing.Point(18, 93);
            this.btn_template_blink.Name = "btn_template_blink";
            this.btn_template_blink.Size = new System.Drawing.Size(306, 34);
            this.btn_template_blink.TabIndex = 9;
            this.btn_template_blink.Text = "💫 BLINKER";
            this.btn_template_blink.UseVisualStyleBackColor = false;
            this.btn_template_blink.Click += new System.EventHandler(this.btn_template_blink_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(18, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "TEMPLATES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_template_glider
            // 
            this.btn_template_glider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(50)))), ((int)(((byte)(140)))));
            this.btn_template_glider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_template_glider.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.btn_template_glider.FlatAppearance.BorderSize = 2;
            this.btn_template_glider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(30)))), ((int)(((byte)(120)))));
            this.btn_template_glider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btn_template_glider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_template_glider.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_template_glider.ForeColor = System.Drawing.Color.White;
            this.btn_template_glider.Location = new System.Drawing.Point(18, 53);
            this.btn_template_glider.Name = "btn_template_glider";
            this.btn_template_glider.Size = new System.Drawing.Size(306, 34);
            this.btn_template_glider.TabIndex = 8;
            this.btn_template_glider.Text = "✈️ GLIDER";
            this.btn_template_glider.UseVisualStyleBackColor = false;
            this.btn_template_glider.Click += new System.EventHandler(this.btn_template_glider_Click);
            // 
            // btn_template_block
            // 
            this.btn_template_block.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.btn_template_block.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_template_block.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(140)))));
            this.btn_template_block.FlatAppearance.BorderSize = 2;
            this.btn_template_block.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.btn_template_block.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.btn_template_block.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_template_block.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_template_block.ForeColor = System.Drawing.Color.White;
            this.btn_template_block.Location = new System.Drawing.Point(18, 173);
            this.btn_template_block.Name = "btn_template_block";
            this.btn_template_block.Size = new System.Drawing.Size(306, 34);
            this.btn_template_block.TabIndex = 11;
            this.btn_template_block.Text = "⬛ BLOCK";
            this.btn_template_block.UseVisualStyleBackColor = false;
            this.btn_template_block.Click += new System.EventHandler(this.btn_template_block_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn_start, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_step, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_reset, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_random, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.trackbar_speed, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(342, 290);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROLS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(18, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "⚡ SPEED";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(180)))));
            this.btn_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(220)))));
            this.btn_start.FlatAppearance.BorderSize = 2;
            this.btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(160)))));
            this.btn_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Location = new System.Drawing.Point(18, 53);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(150, 34);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "▶ START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_step
            // 
            this.btn_step.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.btn_step.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_step.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btn_step.FlatAppearance.BorderSize = 2;
            this.btn_step.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(140)))));
            this.btn_step.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.btn_step.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_step.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_step.ForeColor = System.Drawing.Color.White;
            this.btn_step.Location = new System.Drawing.Point(174, 53);
            this.btn_step.Name = "btn_step";
            this.btn_step.Size = new System.Drawing.Size(150, 34);
            this.btn_step.TabIndex = 3;
            this.btn_step.Text = "⏭ STEP";
            this.btn_step.UseVisualStyleBackColor = false;
            this.btn_step.Click += new System.EventHandler(this.btn_step_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btn_reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.btn_reset.FlatAppearance.BorderSize = 2;
            this.btn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.btn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(18, 93);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(150, 34);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "🗑 EMPTY";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_random
            // 
            this.btn_random.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(140)))));
            this.btn_random.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_random.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
            this.btn_random.FlatAppearance.BorderSize = 2;
            this.btn_random.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.btn_random.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(160)))));
            this.btn_random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_random.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_random.ForeColor = System.Drawing.Color.White;
            this.btn_random.Location = new System.Drawing.Point(174, 93);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(150, 34);
            this.btn_random.TabIndex = 5;
            this.btn_random.Text = "🎲 RANDOM";
            this.btn_random.UseVisualStyleBackColor = false;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // trackbar_speed
            // 
            this.trackbar_speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.tableLayoutPanel2.SetColumnSpan(this.trackbar_speed, 2);
            this.trackbar_speed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackbar_speed.LargeChange = 2;
            this.trackbar_speed.Location = new System.Drawing.Point(18, 168);
            this.trackbar_speed.Name = "trackbar_speed";
            this.trackbar_speed.Size = new System.Drawing.Size(306, 44);
            this.trackbar_speed.TabIndex = 6;
            this.trackbar_speed.ValueChanged += new System.EventHandler(this.trackbar_speed_ValueChanged);
            // 
            // panel_field
            // 
            this.panel_field.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_field.Location = new System.Drawing.Point(361, 13);
            this.panel_field.Name = "panel_field";
            this.tableLayoutPanel1.SetRowSpan(this.panel_field, 3);
            this.panel_field.Size = new System.Drawing.Size(809, 810);
            this.panel_field.TabIndex = 2;
            this.panel_field.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_field_Paint);
            this.panel_field.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_field_MouseClick);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1183, 836);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Conway\'s Game of Life - Speedie\'s Edition";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_speed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_step;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.TrackBar trackbar_speed;
        private System.Windows.Forms.Button btn_template_block;
        private System.Windows.Forms.Button btn_template_gun;
        private System.Windows.Forms.Button btn_template_blink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_template_glider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_generation;
        private System.Windows.Forms.Label lbl_amountAliveCells;
        private System.Windows.Forms.Label lbl_changedCells;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel_field;
    }
}



