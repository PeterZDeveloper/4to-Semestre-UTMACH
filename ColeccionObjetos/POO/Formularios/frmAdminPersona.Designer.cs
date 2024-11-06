namespace POO.Formularios
{
    partial class frmAdminPersona
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.examinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personasMayoresEdadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porcentajesMenoresDeEdadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porcentajeMayoresDeEdadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personasMenoresEdadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(45, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(674, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Cedula";
            this.Column1.HeaderText = "Cedula";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "Nombres";
            this.Column2.HeaderText = "Nombres";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "Apellidos";
            this.Column3.HeaderText = "Apellidos";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "FechaNacimiento";
            this.Column4.HeaderText = "FechaNaci";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "Sexo";
            this.Column5.HeaderText = "Sexo";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.DataPropertyName = "Estado";
            this.Column6.HeaderText = "Estado";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column7.DataPropertyName = "TipoSangre";
            this.Column7.HeaderText = "TipoSangre";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.DataPropertyName = "Ciudad";
            this.Column8.HeaderText = "Ciudad";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrar Personas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 292);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 292);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(343, 292);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.examinarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // examinarToolStripMenuItem
            // 
            this.examinarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personasMayoresEdadToolStripMenuItem,
            this.porcentajesMenoresDeEdadToolStripMenuItem,
            this.porcentajeMayoresDeEdadToolStripMenuItem,
            this.personasMenoresEdadToolStripMenuItem});
            this.examinarToolStripMenuItem.Name = "examinarToolStripMenuItem";
            this.examinarToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.examinarToolStripMenuItem.Text = "Examinar";
            this.examinarToolStripMenuItem.Click += new System.EventHandler(this.examinarToolStripMenuItem_Click);
            // 
            // personasMayoresEdadToolStripMenuItem
            // 
            this.personasMayoresEdadToolStripMenuItem.Name = "personasMayoresEdadToolStripMenuItem";
            this.personasMayoresEdadToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.personasMayoresEdadToolStripMenuItem.Text = "Personas mayores edad";
            this.personasMayoresEdadToolStripMenuItem.Click += new System.EventHandler(this.personasMayoresEdadToolStripMenuItem_Click);
            // 
            // porcentajesMenoresDeEdadToolStripMenuItem
            // 
            this.porcentajesMenoresDeEdadToolStripMenuItem.Name = "porcentajesMenoresDeEdadToolStripMenuItem";
            this.porcentajesMenoresDeEdadToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.porcentajesMenoresDeEdadToolStripMenuItem.Text = "% Mayores de Edad";
            this.porcentajesMenoresDeEdadToolStripMenuItem.Click += new System.EventHandler(this.porcentajesMenoresDeEdadToolStripMenuItem_Click);
            // 
            // porcentajeMayoresDeEdadToolStripMenuItem
            // 
            this.porcentajeMayoresDeEdadToolStripMenuItem.Name = "porcentajeMayoresDeEdadToolStripMenuItem";
            this.porcentajeMayoresDeEdadToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.porcentajeMayoresDeEdadToolStripMenuItem.Text = "% Menores de Edad";
            this.porcentajeMayoresDeEdadToolStripMenuItem.Click += new System.EventHandler(this.porcentajeMayoresDeEdadToolStripMenuItem_Click);
            // 
            // personasMenoresEdadToolStripMenuItem
            // 
            this.personasMenoresEdadToolStripMenuItem.Name = "personasMenoresEdadToolStripMenuItem";
            this.personasMenoresEdadToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.personasMenoresEdadToolStripMenuItem.Text = "Personas Menores edad";
            this.personasMenoresEdadToolStripMenuItem.Click += new System.EventHandler(this.personasMenoresEdadToolStripMenuItem_Click);
            // 
            // frmAdminPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 341);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAdminPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminPersona";
            this.Load += new System.EventHandler(this.frmAdminPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem examinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personasMayoresEdadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porcentajesMenoresDeEdadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porcentajeMayoresDeEdadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personasMenoresEdadToolStripMenuItem;
    }
}