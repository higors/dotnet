namespace Treinamento.Presentation.FormApp
{
    partial class FormVenda
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
            this.gbxPedido = new System.Windows.Forms.GroupBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtPedidoItem = new System.Windows.Forms.TextBox();
            this.mtbValorItem = new System.Windows.Forms.MaskedTextBox();
            this.mtbQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.mtbCodigoPedido = new System.Windows.Forms.MaskedTextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblPedidoItem = new System.Windows.Forms.Label();
            this.lblValorItem = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblCodigoPedido = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.pnlPedido = new System.Windows.Forms.Panel();
            this.lblPedido = new System.Windows.Forms.Label();
            this.gbxPedido.SuspendLayout();
            this.pnlPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPedido
            // 
            this.gbxPedido.Controls.Add(this.txtVendedor);
            this.gbxPedido.Controls.Add(this.label1);
            this.gbxPedido.Controls.Add(this.btnCancelar);
            this.gbxPedido.Controls.Add(this.btnConfirmar);
            this.gbxPedido.Controls.Add(this.txtPedidoItem);
            this.gbxPedido.Controls.Add(this.mtbValorItem);
            this.gbxPedido.Controls.Add(this.mtbQuantidade);
            this.gbxPedido.Controls.Add(this.mtbCodigoPedido);
            this.gbxPedido.Controls.Add(this.dtpData);
            this.gbxPedido.Controls.Add(this.lblPedidoItem);
            this.gbxPedido.Controls.Add(this.lblValorItem);
            this.gbxPedido.Controls.Add(this.lblQuantidade);
            this.gbxPedido.Controls.Add(this.lblCodigoPedido);
            this.gbxPedido.Controls.Add(this.lblData);
            this.gbxPedido.Controls.Add(this.pnlPedido);
            this.gbxPedido.Location = new System.Drawing.Point(12, 12);
            this.gbxPedido.Name = "gbxPedido";
            this.gbxPedido.Size = new System.Drawing.Size(189, 267);
            this.gbxPedido.TabIndex = 0;
            this.gbxPedido.TabStop = false;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(12, 205);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(168, 20);
            this.txtVendedor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Vendedor";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(103, 231);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(6, 231);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(80, 30);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // txtPedidoItem
            // 
            this.txtPedidoItem.Location = new System.Drawing.Point(12, 125);
            this.txtPedidoItem.Name = "txtPedidoItem";
            this.txtPedidoItem.Size = new System.Drawing.Size(168, 20);
            this.txtPedidoItem.TabIndex = 2;
            // 
            // mtbValorItem
            // 
            this.mtbValorItem.Location = new System.Drawing.Point(12, 164);
            this.mtbValorItem.Name = "mtbValorItem";
            this.mtbValorItem.PromptChar = '0';
            this.mtbValorItem.Size = new System.Drawing.Size(71, 20);
            this.mtbValorItem.TabIndex = 3;
            // 
            // mtbQuantidade
            // 
            this.mtbQuantidade.Location = new System.Drawing.Point(89, 164);
            this.mtbQuantidade.Name = "mtbQuantidade";
            this.mtbQuantidade.PromptChar = '0';
            this.mtbQuantidade.Size = new System.Drawing.Size(91, 20);
            this.mtbQuantidade.TabIndex = 4;
            // 
            // mtbCodigoPedido
            // 
            this.mtbCodigoPedido.Enabled = false;
            this.mtbCodigoPedido.Location = new System.Drawing.Point(12, 86);
            this.mtbCodigoPedido.Mask = "00000";
            this.mtbCodigoPedido.Name = "mtbCodigoPedido";
            this.mtbCodigoPedido.PromptChar = '0';
            this.mtbCodigoPedido.Size = new System.Drawing.Size(71, 20);
            this.mtbCodigoPedido.TabIndex = 0;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(89, 86);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(91, 20);
            this.dtpData.TabIndex = 1;
            // 
            // lblPedidoItem
            // 
            this.lblPedidoItem.AutoSize = true;
            this.lblPedidoItem.Location = new System.Drawing.Point(9, 109);
            this.lblPedidoItem.Name = "lblPedidoItem";
            this.lblPedidoItem.Size = new System.Drawing.Size(27, 13);
            this.lblPedidoItem.TabIndex = 5;
            this.lblPedidoItem.Text = "Item";
            // 
            // lblValorItem
            // 
            this.lblValorItem.AutoSize = true;
            this.lblValorItem.Location = new System.Drawing.Point(9, 148);
            this.lblValorItem.Name = "lblValorItem";
            this.lblValorItem.Size = new System.Drawing.Size(48, 13);
            this.lblValorItem.TabIndex = 4;
            this.lblValorItem.Text = "Valor (U)";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(86, 148);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 3;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblCodigoPedido
            // 
            this.lblCodigoPedido.AutoSize = true;
            this.lblCodigoPedido.Location = new System.Drawing.Point(9, 70);
            this.lblCodigoPedido.Name = "lblCodigoPedido";
            this.lblCodigoPedido.Size = new System.Drawing.Size(60, 13);
            this.lblCodigoPedido.TabIndex = 2;
            this.lblCodigoPedido.Text = "No. Pedido";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(86, 70);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data";
            // 
            // pnlPedido
            // 
            this.pnlPedido.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPedido.Controls.Add(this.lblPedido);
            this.pnlPedido.Location = new System.Drawing.Point(12, 19);
            this.pnlPedido.Name = "pnlPedido";
            this.pnlPedido.Size = new System.Drawing.Size(168, 40);
            this.pnlPedido.TabIndex = 0;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(48, 9);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(64, 20);
            this.lblPedido.TabIndex = 11;
            this.lblPedido.Text = "Pedido";
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 291);
            this.Controls.Add(this.gbxPedido);
            this.Name = "FormVenda";
            this.Text = "FormVenda";
            this.gbxPedido.ResumeLayout(false);
            this.gbxPedido.PerformLayout();
            this.pnlPedido.ResumeLayout(false);
            this.pnlPedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPedido;
        private System.Windows.Forms.TextBox txtPedidoItem;
        private System.Windows.Forms.MaskedTextBox mtbValorItem;
        private System.Windows.Forms.MaskedTextBox mtbQuantidade;
        private System.Windows.Forms.MaskedTextBox mtbCodigoPedido;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblPedidoItem;
        private System.Windows.Forms.Label lblValorItem;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblCodigoPedido;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel pnlPedido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label label1;
    }
}