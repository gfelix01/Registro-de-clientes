namespace Entidad
{
    partial class Entidades
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entidades));
            this.LBNombre = new System.Windows.Forms.Label();
            this.LBApellidos = new System.Windows.Forms.Label();
            this.LBNacimiento = new System.Windows.Forms.Label();
            this.LBEdad = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBEdad = new System.Windows.Forms.TextBox();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.Cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.TBFecha = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBNombre
            // 
            this.LBNombre.AutoSize = true;
            this.LBNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LBNombre.Location = new System.Drawing.Point(13, 41);
            this.LBNombre.Name = "LBNombre";
            this.LBNombre.Size = new System.Drawing.Size(65, 20);
            this.LBNombre.TabIndex = 0;
            this.LBNombre.Text = "Nombre";
            // 
            // LBApellidos
            // 
            this.LBApellidos.AutoSize = true;
            this.LBApellidos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LBApellidos.Location = new System.Drawing.Point(8, 83);
            this.LBApellidos.Name = "LBApellidos";
            this.LBApellidos.Size = new System.Drawing.Size(78, 21);
            this.LBApellidos.TabIndex = 1;
            this.LBApellidos.Text = "Apellidos";
            // 
            // LBNacimiento
            // 
            this.LBNacimiento.AutoSize = true;
            this.LBNacimiento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LBNacimiento.Location = new System.Drawing.Point(7, 121);
            this.LBNacimiento.Name = "LBNacimiento";
            this.LBNacimiento.Size = new System.Drawing.Size(143, 21);
            this.LBNacimiento.TabIndex = 2;
            this.LBNacimiento.Text = "Fecha_nacimiento ";
            // 
            // LBEdad
            // 
            this.LBEdad.AutoSize = true;
            this.LBEdad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LBEdad.Location = new System.Drawing.Point(8, 160);
            this.LBEdad.Name = "LBEdad";
            this.LBEdad.Size = new System.Drawing.Size(45, 21);
            this.LBEdad.TabIndex = 3;
            this.LBEdad.Text = "Edad";
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(84, 38);
            this.TBNombre.Multiline = true;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(245, 23);
            this.TBNombre.TabIndex = 4;
            this.TBNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(84, 85);
            this.TBApellido.Multiline = true;
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(245, 23);
            this.TBApellido.TabIndex = 5;
            // 
            // TBEdad
            // 
            this.TBEdad.Location = new System.Drawing.Point(67, 162);
            this.TBEdad.Name = "TBEdad";
            this.TBEdad.Size = new System.Drawing.Size(83, 23);
            this.TBEdad.TabIndex = 7;
            this.TBEdad.TextChanged += new System.EventHandler(this.TBEdad_TextChanged);
            // 
            // Datos
            // 
            this.Datos.AllowUserToDeleteRows = false;
            this.Datos.AllowUserToOrderColumns = true;
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cnombre,
            this.Capellidos,
            this.Cfecha,
            this.Cedad});
            this.Datos.Location = new System.Drawing.Point(369, 97);
            this.Datos.Name = "Datos";
            this.Datos.RowTemplate.Height = 25;
            this.Datos.Size = new System.Drawing.Size(512, 264);
            this.Datos.TabIndex = 10;
            this.Datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datos_CellContentClick);
            // 
            // Cnombre
            // 
            this.Cnombre.HeaderText = "Nombre";
            this.Cnombre.Name = "Cnombre";
            this.Cnombre.ReadOnly = true;
            // 
            // Capellidos
            // 
            this.Capellidos.HeaderText = "Apellidos";
            this.Capellidos.Name = "Capellidos";
            this.Capellidos.ReadOnly = true;
            // 
            // Cfecha
            // 
            this.Cfecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cfecha.HeaderText = "Fecha_nacimiento";
            this.Cfecha.Name = "Cfecha";
            this.Cfecha.ReadOnly = true;
            // 
            // Cedad
            // 
            this.Cedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cedad.HeaderText = "Edad";
            this.Cedad.Name = "Cedad";
            this.Cedad.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Titulo.Location = new System.Drawing.Point(471, 24);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(190, 21);
            this.Titulo.TabIndex = 11;
            this.Titulo.Text = "Informacion del Cliente";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 20;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(162, 268);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(85, 48);
            this.iconButton1.TabIndex = 14;
            this.iconButton1.Text = "INGRESAR";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Robot;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 20;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton3.Location = new System.Drawing.Point(13, 268);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(82, 48);
            this.iconButton3.TabIndex = 16;
            this.iconButton3.Text = "SALIR";
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // TBFecha
            // 
            this.TBFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TBFecha.Location = new System.Drawing.Point(141, 121);
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.Size = new System.Drawing.Size(213, 23);
            this.TBFecha.TabIndex = 17;
            this.TBFecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Entidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBFecha);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.TBEdad);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.LBEdad);
            this.Controls.Add(this.LBNacimiento);
            this.Controls.Add(this.LBApellidos);
            this.Controls.Add(this.LBNombre);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entidades";
            this.Text = "REGISTRO";
            this.Load += new System.EventHandler(this.Entidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LBNombre;
        private Label LBApellidos;
        private Label LBNacimiento;
        private Label LBEdad;
        private TextBox TBNombre;
        private TextBox TBApellido;
        private TextBox TBEdad;
        private DataGridView Datos;
        private Label Titulo;
        private DataGridViewTextBoxColumn Cnombre;
        private DataGridViewTextBoxColumn Capellidos;
        private DataGridViewTextBoxColumn Cfecha;
        private DataGridViewTextBoxColumn Cedad;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private DateTimePicker TBFecha;
        private Button button1;
        private ErrorProvider errorProvider1;
        private FileSystemWatcher fileSystemWatcher1;
    }
}