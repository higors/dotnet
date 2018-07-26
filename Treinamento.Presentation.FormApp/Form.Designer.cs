namespace Treinamento.Presentation.FormApp
{
    partial class Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.gbxPedido = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExcluirPedido = new System.Windows.Forms.Button();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.gbxPedidoItem = new System.Windows.Forms.GroupBox();
            this.mtbQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.lblValorItem = new System.Windows.Forms.Label();
            this.mtbValorItem = new System.Windows.Forms.MaskedTextBox();
            this.txtPedidoItem = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.mtbCodigoPedido = new System.Windows.Forms.MaskedTextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPedidoItem = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.gbxValorTotal = new System.Windows.Forms.GroupBox();
            this.mtbValorTotal = new System.Windows.Forms.MaskedTextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.gbxPedido.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbxPedidoItem.SuspendLayout();
            this.gbxValorTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AllowUserToResizeColumns = false;
            this.dgvPedidos.AllowUserToResizeRows = false;
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.EnableHeadersVisualStyles = false;
            this.dgvPedidos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPedidos.Location = new System.Drawing.Point(12, 12);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(487, 290);
            this.dgvPedidos.TabIndex = 0;
            this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPedidos_CellContentClick);
            // 
            // gbxPedido
            // 
            this.gbxPedido.Controls.Add(this.groupBox4);
            this.gbxPedido.Controls.Add(this.gbxPedidoItem);
            this.gbxPedido.Controls.Add(this.gbxValorTotal);
            this.gbxPedido.Location = new System.Drawing.Point(505, 5);
            this.gbxPedido.Name = "gbxPedido";
            this.gbxPedido.Size = new System.Drawing.Size(283, 297);
            this.gbxPedido.TabIndex = 1;
            this.gbxPedido.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExcluirPedido);
            this.groupBox4.Controls.Add(this.btnNovaVenda);
            this.groupBox4.Location = new System.Drawing.Point(6, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 49);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // btnExcluirPedido
            // 
            this.btnExcluirPedido.Location = new System.Drawing.Point(146, 16);
            this.btnExcluirPedido.Name = "btnExcluirPedido";
            this.btnExcluirPedido.Size = new System.Drawing.Size(100, 23);
            this.btnExcluirPedido.TabIndex = 1;
            this.btnExcluirPedido.Text = "Excluir Pedido";
            this.btnExcluirPedido.UseVisualStyleBackColor = true;
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(22, 16);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(100, 23);
            this.btnNovaVenda.TabIndex = 0;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.Button1_Click);
            // 
            // gbxPedidoItem
            // 
            this.gbxPedidoItem.Controls.Add(this.mtbQuantidade);
            this.gbxPedidoItem.Controls.Add(this.lblValorItem);
            this.gbxPedidoItem.Controls.Add(this.mtbValorItem);
            this.gbxPedidoItem.Controls.Add(this.txtPedidoItem);
            this.gbxPedidoItem.Controls.Add(this.dtpData);
            this.gbxPedidoItem.Controls.Add(this.mtbCodigoPedido);
            this.gbxPedidoItem.Controls.Add(this.lblQuantidade);
            this.gbxPedidoItem.Controls.Add(this.lblPedidoItem);
            this.gbxPedidoItem.Controls.Add(this.lblData);
            this.gbxPedidoItem.Controls.Add(this.lblPedido);
            this.gbxPedidoItem.Location = new System.Drawing.Point(6, 95);
            this.gbxPedidoItem.Name = "gbxPedidoItem";
            this.gbxPedidoItem.Size = new System.Drawing.Size(271, 141);
            this.gbxPedidoItem.TabIndex = 1;
            this.gbxPedidoItem.TabStop = false;
            // 
            // mtbQuantidade
            // 
            this.mtbQuantidade.Location = new System.Drawing.Point(22, 110);
            this.mtbQuantidade.Mask = "000";
            this.mtbQuantidade.Name = "mtbQuantidade";
            this.mtbQuantidade.PromptChar = '0';
            this.mtbQuantidade.Size = new System.Drawing.Size(60, 20);
            this.mtbQuantidade.TabIndex = 10;
            // 
            // lblValorItem
            // 
            this.lblValorItem.AutoSize = true;
            this.lblValorItem.Location = new System.Drawing.Point(173, 55);
            this.lblValorItem.Name = "lblValorItem";
            this.lblValorItem.Size = new System.Drawing.Size(48, 13);
            this.lblValorItem.TabIndex = 9;
            this.lblValorItem.Text = "Valor (U)";
            // 
            // mtbValorItem
            // 
            this.mtbValorItem.Enabled = false;
            this.mtbValorItem.Location = new System.Drawing.Point(176, 71);
            this.mtbValorItem.Mask = "$ 0,00";
            this.mtbValorItem.Name = "mtbValorItem";
            this.mtbValorItem.PromptChar = '0';
            this.mtbValorItem.Size = new System.Drawing.Size(70, 20);
            this.mtbValorItem.TabIndex = 8;
            // 
            // txtPedidoItem
            // 
            this.txtPedidoItem.Enabled = false;
            this.txtPedidoItem.Location = new System.Drawing.Point(22, 71);
            this.txtPedidoItem.Name = "txtPedidoItem";
            this.txtPedidoItem.Size = new System.Drawing.Size(150, 20);
            this.txtPedidoItem.TabIndex = 6;
            // 
            // dtpData
            // 
            this.dtpData.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtpData.Enabled = false;
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpData.Location = new System.Drawing.Point(88, 32);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(100, 20);
            this.dtpData.TabIndex = 5;
            // 
            // mtbCodigoPedido
            // 
            this.mtbCodigoPedido.Enabled = false;
            this.mtbCodigoPedido.Location = new System.Drawing.Point(22, 32);
            this.mtbCodigoPedido.Mask = "00000";
            this.mtbCodigoPedido.Name = "mtbCodigoPedido";
            this.mtbCodigoPedido.PromptChar = '0';
            this.mtbCodigoPedido.Size = new System.Drawing.Size(60, 20);
            this.mtbCodigoPedido.TabIndex = 4;
            this.mtbCodigoPedido.ValidatingType = typeof(int);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(19, 94);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 3;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblPedidoItem
            // 
            this.lblPedidoItem.AutoSize = true;
            this.lblPedidoItem.Location = new System.Drawing.Point(19, 55);
            this.lblPedidoItem.Name = "lblPedidoItem";
            this.lblPedidoItem.Size = new System.Drawing.Size(27, 13);
            this.lblPedidoItem.TabIndex = 2;
            this.lblPedidoItem.Text = "Item";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(85, 16);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(19, 16);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(40, 13);
            this.lblPedido.TabIndex = 0;
            this.lblPedido.Text = "Pedido";
            // 
            // gbxValorTotal
            // 
            this.gbxValorTotal.Controls.Add(this.mtbValorTotal);
            this.gbxValorTotal.Controls.Add(this.lblValorTotal);
            this.gbxValorTotal.Location = new System.Drawing.Point(6, 7);
            this.gbxValorTotal.Name = "gbxValorTotal";
            this.gbxValorTotal.Size = new System.Drawing.Size(271, 82);
            this.gbxValorTotal.TabIndex = 0;
            this.gbxValorTotal.TabStop = false;
            // 
            // mtbValorTotal
            // 
            this.mtbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbValorTotal.Location = new System.Drawing.Point(66, 44);
            this.mtbValorTotal.Mask = "$ 0,00";
            this.mtbValorTotal.Name = "mtbValorTotal";
            this.mtbValorTotal.PromptChar = '0';
            this.mtbValorTotal.ReadOnly = true;
            this.mtbValorTotal.Size = new System.Drawing.Size(150, 29);
            this.mtbValorTotal.TabIndex = 2;
            this.mtbValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(69, 16);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(144, 16);
            this.lblValorTotal.TabIndex = 0;
            this.lblValorTotal.Text = "VALOR TOTAL (R$)";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 312);
            this.Controls.Add(this.gbxPedido);
            this.Controls.Add(this.dgvPedidos);
            this.Name = "Form";
            this.Text = "Gerenciamento de Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.gbxPedido.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.gbxPedidoItem.ResumeLayout(false);
            this.gbxPedidoItem.PerformLayout();
            this.gbxValorTotal.ResumeLayout(false);
            this.gbxValorTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.GroupBox gbxPedido;
        private System.Windows.Forms.GroupBox gbxPedidoItem;
        private System.Windows.Forms.GroupBox gbxValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.MaskedTextBox mtbCodigoPedido;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblPedidoItem;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.MaskedTextBox mtbValorTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnExcluirPedido;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.MaskedTextBox mtbQuantidade;
        private System.Windows.Forms.Label lblValorItem;
        private System.Windows.Forms.MaskedTextBox mtbValorItem;
        private System.Windows.Forms.TextBox txtPedidoItem;
    }
}

