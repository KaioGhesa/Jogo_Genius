namespace JogoGenius
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btVerde = new Button();
            btAmarelo = new Button();
            btVermelho = new Button();
            btAzul = new Button();
            lbNivel2 = new Label();
            lbNivel1 = new Label();
            btIniciar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // btVerde
            // 
            resources.ApplyResources(btVerde, "btVerde");
            btVerde.Name = "btVerde";
            btVerde.UseVisualStyleBackColor = true;
            btVerde.Click += bt_Click;
            // 
            // btAmarelo
            // 
            resources.ApplyResources(btAmarelo, "btAmarelo");
            btAmarelo.Name = "btAmarelo";
            btAmarelo.UseVisualStyleBackColor = true;
            btAmarelo.Click += bt_Click;
            // 
            // btVermelho
            // 
            resources.ApplyResources(btVermelho, "btVermelho");
            btVermelho.Name = "btVermelho";
            btVermelho.UseVisualStyleBackColor = true;
            btVermelho.Click += bt_Click;
            // 
            // btAzul
            // 
            resources.ApplyResources(btAzul, "btAzul");
            btAzul.Name = "btAzul";
            btAzul.UseVisualStyleBackColor = true;
            btAzul.Click += bt_Click;
            // 
            // lbNivel2
            // 
            resources.ApplyResources(lbNivel2, "lbNivel2");
            lbNivel2.Name = "lbNivel2";
            lbNivel2.Click += label2_Click;
            // 
            // lbNivel1
            // 
            resources.ApplyResources(lbNivel1, "lbNivel1");
            lbNivel1.Name = "lbNivel1";
            lbNivel1.Click += label3_Click;
            // 
            // btIniciar
            // 
            resources.ApplyResources(btIniciar, "btIniciar");
            btIniciar.Name = "btIniciar";
            btIniciar.UseVisualStyleBackColor = true;
            btIniciar.Click += btIniciar_Click;
            // 
            // timer1
            // 
            timer1.Interval = 250;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btIniciar);
            Controls.Add(lbNivel1);
            Controls.Add(lbNivel2);
            Controls.Add(btAzul);
            Controls.Add(btVermelho);
            Controls.Add(btAmarelo);
            Controls.Add(btVerde);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btVerde;
        private Button btAmarelo;
        private Button btVermelho;
        private Button btAzul;
        private Label lbNivel2;
        private Label lbNivel1;
        private Button btIniciar;
        private System.Windows.Forms.Timer timer1;
    }
}
