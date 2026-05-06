namespace First_Program
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
            btnVerMensaje = new Button();
            SuspendLayout();
            // 
            // btnVerMensaje
            // 
            btnVerMensaje.Location = new Point(88, 154);
            btnVerMensaje.Name = "btnVerMensaje";
            btnVerMensaje.Size = new Size(185, 55);
            btnVerMensaje.TabIndex = 0;
            btnVerMensaje.Text = "VER MENSAJE";
            btnVerMensaje.UseVisualStyleBackColor = true;
            btnVerMensaje.Click += btnVerMensaje_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 245);
            Controls.Add(btnVerMensaje);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVerMensaje;
    }
}
