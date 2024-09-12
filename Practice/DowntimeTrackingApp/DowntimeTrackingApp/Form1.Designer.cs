namespace DowntimeTrackingApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtEquipmentId;
        private System.Windows.Forms.TextBox txtDowntimeTypeId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtPlannedEndDate;
        private System.Windows.Forms.TextBox txtActualEndDate;
        private System.Windows.Forms.TextBox txtPlannedDowntimeHours;
        private System.Windows.Forms.TextBox txtActualDowntimeHours;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblEquipmentId;
        private System.Windows.Forms.Label lblDowntimeTypeId;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblPlannedEndDate;
        private System.Windows.Forms.Label lblActualEndDate;
        private System.Windows.Forms.Label lblPlannedDowntimeHours;
        private System.Windows.Forms.Label lblActualDowntimeHours;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblId;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEquipmentId = new System.Windows.Forms.TextBox();
            this.txtDowntimeTypeId = new System.Windows.Forms.TextBox();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtPlannedEndDate = new System.Windows.Forms.TextBox();
            this.txtActualEndDate = new System.Windows.Forms.TextBox();
            this.txtPlannedDowntimeHours = new System.Windows.Forms.TextBox();
            this.txtActualDowntimeHours = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblEquipmentId = new System.Windows.Forms.Label();
            this.lblDowntimeTypeId = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblPlannedEndDate = new System.Windows.Forms.Label();
            this.lblActualEndDate = new System.Windows.Forms.Label();
            this.lblPlannedDowntimeHours = new System.Windows.Forms.Label();
            this.lblActualDowntimeHours = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 12);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(760, 250);
            this.dgvDatos.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(12, 420);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(93, 420);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(174, 420);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(255, 420);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtEquipmentId
            // 
            this.txtEquipmentId.Location = new System.Drawing.Point(93, 268);
            this.txtEquipmentId.Name = "txtEquipmentId";
            this.txtEquipmentId.Size = new System.Drawing.Size(100, 20);
            this.txtEquipmentId.TabIndex = 5;
            // 
            // txtDowntimeTypeId
            // 
            this.txtDowntimeTypeId.Location = new System.Drawing.Point(93, 294);
            this.txtDowntimeTypeId.Name = "txtDowntimeTypeId";
            this.txtDowntimeTypeId.Size = new System.Drawing.Size(100, 20);
            this.txtDowntimeTypeId.TabIndex = 6;
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(93, 320);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeId.TabIndex = 7;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(93, 346);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(100, 20);
            this.txtStartDate.TabIndex = 8;
            // 
            // txtPlannedEndDate
            // 
            this.txtPlannedEndDate.Location = new System.Drawing.Point(93, 372);
            this.txtPlannedEndDate.Name = "txtPlannedEndDate";
            this.txtPlannedEndDate.Size = new System.Drawing.Size(100, 20);
            this.txtPlannedEndDate.TabIndex = 9;
            // 
            // txtActualEndDate
            // 
            this.txtActualEndDate.Location = new System.Drawing.Point(93, 398);
            this.txtActualEndDate.Name = "txtActualEndDate";
            this.txtActualEndDate.Size = new System.Drawing.Size(100, 20);
            this.txtActualEndDate.TabIndex = 10;
            // 
            // txtPlannedDowntimeHours
            // 
            this.txtPlannedDowntimeHours.Location = new System.Drawing.Point(254, 268);
            this.txtPlannedDowntimeHours.Name = "txtPlannedDowntimeHours";
            this.txtPlannedDowntimeHours.Size = new System.Drawing.Size(100, 20);
            this.txtPlannedDowntimeHours.TabIndex = 11;
            // 
            // txtActualDowntimeHours
            // 
            this.txtActualDowntimeHours.Location = new System.Drawing.Point(254, 294);
            this.txtActualDowntimeHours.Name = "txtActualDowntimeHours";
            this.txtActualDowntimeHours.Size = new System.Drawing.Size(100, 20);
            this.txtActualDowntimeHours.TabIndex = 12;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(254, 320);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(100, 20);
            this.txtComments.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(254, 346);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 14;
            // 
            // lblEquipmentId
            // 
            this.lblEquipmentId.AutoSize = true;
            this.lblEquipmentId.Location = new System.Drawing.Point(12, 271);
            this.lblEquipmentId.Name = "lblEquipmentId";
            this.lblEquipmentId.Size = new System.Drawing.Size(75, 13);
            this.lblEquipmentId.TabIndex = 15;
            this.lblEquipmentId.Text = "Equipment ID:";
                        // 
            // lblDowntimeTypeId
            // 
            this.lblDowntimeTypeId.AutoSize = true;
            this.lblDowntimeTypeId.Location = new System.Drawing.Point(12, 297);
            this.lblDowntimeTypeId.Name = "lblDowntimeTypeId";
            this.lblDowntimeTypeId.Size = new System.Drawing.Size(88, 13);
            this.lblDowntimeTypeId.TabIndex = 16;
            this.lblDowntimeTypeId.Text = "Downtime Type ID:";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(12, 323);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeId.TabIndex = 17;
            this.lblEmployeeId.Text = "Employee ID:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(12, 349);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 18;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblPlannedEndDate
            // 
            this.lblPlannedEndDate.AutoSize = true;
            this.lblPlannedEndDate.Location = new System.Drawing.Point(12, 375);
            this.lblPlannedEndDate.Name = "lblPlannedEndDate";
            this.lblPlannedEndDate.Size = new System.Drawing.Size(94, 13);
            this.lblPlannedEndDate.TabIndex = 19;
            this.lblPlannedEndDate.Text = "Planned End Date:";
            // 
            // lblActualEndDate
            // 
            this.lblActualEndDate.AutoSize = true;
            this.lblActualEndDate.Location = new System.Drawing.Point(12, 401);
            this.lblActualEndDate.Name = "lblActualEndDate";
            this.lblActualEndDate.Size = new System.Drawing.Size(82, 13);
            this.lblActualEndDate.TabIndex = 20;
            this.lblActualEndDate.Text = "Actual End Date:";
            // 
            // lblPlannedDowntimeHours
            // 
            this.lblPlannedDowntimeHours.AutoSize = true;
            this.lblPlannedDowntimeHours.Location = new System.Drawing.Point(200, 271);
            this.lblPlannedDowntimeHours.Name = "lblPlannedDowntimeHours";
            this.lblPlannedDowntimeHours.Size = new System.Drawing.Size(135, 13);
            this.lblPlannedDowntimeHours.TabIndex = 21;
            this.lblPlannedDowntimeHours.Text = "Planned Downtime Hours:";
            // 
            // lblActualDowntimeHours
            // 
            this.lblActualDowntimeHours.AutoSize = true;
            this.lblActualDowntimeHours.Location = new System.Drawing.Point(200, 297);
            this.lblActualDowntimeHours.Name = "lblActualDowntimeHours";
            this.lblActualDowntimeHours.Size = new System.Drawing.Size(123, 13);
            this.lblActualDowntimeHours.TabIndex = 22;
            this.lblActualDowntimeHours.Text = "Actual Downtime Hours:";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(200, 323);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(59, 13);
            this.lblComments.TabIndex = 23;
            this.lblComments.Text = "Comments:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(200, 349);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 24;
            this.lblId.Text = "Id:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblActualDowntimeHours);
            this.Controls.Add(this.lblPlannedDowntimeHours);
            this.Controls.Add(this.lblActualEndDate);
            this.Controls.Add(this.lblPlannedEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.lblDowntimeTypeId);
            this.Controls.Add(this.lblEquipmentId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtActualDowntimeHours);
            this.Controls.Add(this.txtPlannedDowntimeHours);
            this.Controls.Add(this.txtActualEndDate);
            this.Controls.Add(this.txtPlannedEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.txtDowntimeTypeId);
            this.Controls.Add(this.txtEquipmentId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvDatos);
            this.Name = "Form1";
            this.Text = "Downtime Tracking";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
