
namespace WVision
{
    partial class Form_CameraConfig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.ColumnHeader_Contrast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHeader_Brightness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHeader_Exposure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHeader_VideoFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHeader_Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHeader_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHeader_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Camera_Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView_Camera = new System.Windows.Forms.DataGridView();
            this.gbMakeFifo = new System.Windows.Forms.GroupBox();
            this.txtSelectVF = new System.Windows.Forms.TextBox();
            this.txtSelectFG = new System.Windows.Forms.TextBox();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.cbVideoFormat = new System.Windows.Forms.ComboBox();
            this.button_AddCamera = new System.Windows.Forms.Button();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.gbUseVProAcqApi = new System.Windows.Forms.GroupBox();
            this.lblContrast = new System.Windows.Forms.TextBox();
            this.lblBrightness = new System.Windows.Forms.TextBox();
            this.lblExposure = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_RemoveCamera = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Camera)).BeginInit();
            this.gbMakeFifo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.gbUseVProAcqApi.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(37, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 41);
            this.label2.TabIndex = 11;
            this.label2.Text = "1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColumnHeader_Contrast
            // 
            this.ColumnHeader_Contrast.FillWeight = 102.3017F;
            this.ColumnHeader_Contrast.HeaderText = "Contrast";
            this.ColumnHeader_Contrast.Name = "ColumnHeader_Contrast";
            // 
            // ColumnHeader_Brightness
            // 
            this.ColumnHeader_Brightness.FillWeight = 102.3017F;
            this.ColumnHeader_Brightness.HeaderText = "Brightness";
            this.ColumnHeader_Brightness.Name = "ColumnHeader_Brightness";
            // 
            // ColumnHeader_Exposure
            // 
            this.ColumnHeader_Exposure.FillWeight = 102.3017F;
            this.ColumnHeader_Exposure.HeaderText = "Exposure";
            this.ColumnHeader_Exposure.Name = "ColumnHeader_Exposure";
            // 
            // ColumnHeader_VideoFormat
            // 
            this.ColumnHeader_VideoFormat.FillWeight = 102.3017F;
            this.ColumnHeader_VideoFormat.HeaderText = "VideoFormat";
            this.ColumnHeader_VideoFormat.Name = "ColumnHeader_VideoFormat";
            // 
            // ColumnHeader_Serial
            // 
            this.ColumnHeader_Serial.FillWeight = 102.3017F;
            this.ColumnHeader_Serial.HeaderText = "Serial";
            this.ColumnHeader_Serial.Name = "ColumnHeader_Serial";
            // 
            // ColumnHeader_Name
            // 
            this.ColumnHeader_Name.FillWeight = 102.3017F;
            this.ColumnHeader_Name.HeaderText = "Name";
            this.ColumnHeader_Name.Name = "ColumnHeader_Name";
            // 
            // ColumnHeader_Type
            // 
            this.ColumnHeader_Type.FillWeight = 102.3017F;
            this.ColumnHeader_Type.HeaderText = "Type";
            this.ColumnHeader_Type.Name = "ColumnHeader_Type";
            this.ColumnHeader_Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Camera_Index
            // 
            this.Camera_Index.FillWeight = 61.37055F;
            this.Camera_Index.HeaderText = "No";
            this.Camera_Index.Name = "Camera_Index";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "CAM NO";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(83, 201);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 21);
            this.numericUpDown1.TabIndex = 11;
            // 
            // dataGridView_Camera
            // 
            this.dataGridView_Camera.AllowUserToAddRows = false;
            this.dataGridView_Camera.AllowUserToDeleteRows = false;
            this.dataGridView_Camera.AllowUserToResizeColumns = false;
            this.dataGridView_Camera.AllowUserToResizeRows = false;
            this.dataGridView_Camera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Camera.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Camera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Camera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Camera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Camera_Index,
            this.ColumnHeader_Type,
            this.ColumnHeader_Name,
            this.ColumnHeader_Serial,
            this.ColumnHeader_VideoFormat,
            this.ColumnHeader_Exposure,
            this.ColumnHeader_Brightness,
            this.ColumnHeader_Contrast});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Camera.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Camera.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView_Camera.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Camera.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_Camera.Name = "dataGridView_Camera";
            this.dataGridView_Camera.RowHeadersVisible = false;
            this.dataGridView_Camera.RowTemplate.Height = 23;
            this.dataGridView_Camera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Camera.Size = new System.Drawing.Size(879, 164);
            this.dataGridView_Camera.TabIndex = 122;
            // 
            // gbMakeFifo
            // 
            this.gbMakeFifo.Controls.Add(this.txtSelectVF);
            this.gbMakeFifo.Controls.Add(this.txtSelectFG);
            this.gbMakeFifo.Controls.Add(this.cbCamera);
            this.gbMakeFifo.Controls.Add(this.cbVideoFormat);
            this.gbMakeFifo.Location = new System.Drawing.Point(164, 184);
            this.gbMakeFifo.Name = "gbMakeFifo";
            this.gbMakeFifo.Size = new System.Drawing.Size(364, 164);
            this.gbMakeFifo.TabIndex = 8;
            this.gbMakeFifo.TabStop = false;
            this.gbMakeFifo.Text = "Construct an Acquisition Fifo";
            // 
            // txtSelectVF
            // 
            this.txtSelectVF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSelectVF.Location = new System.Drawing.Point(13, 76);
            this.txtSelectVF.Name = "txtSelectVF";
            this.txtSelectVF.ReadOnly = true;
            this.txtSelectVF.Size = new System.Drawing.Size(144, 14);
            this.txtSelectVF.TabIndex = 10;
            this.txtSelectVF.Text = "Video Format:";
            // 
            // txtSelectFG
            // 
            this.txtSelectFG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSelectFG.Location = new System.Drawing.Point(13, 27);
            this.txtSelectFG.Name = "txtSelectFG";
            this.txtSelectFG.ReadOnly = true;
            this.txtSelectFG.Size = new System.Drawing.Size(120, 14);
            this.txtSelectFG.TabIndex = 9;
            this.txtSelectFG.Text = "Camera:";
            // 
            // cbCamera
            // 
            this.cbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamera.DropDownWidth = 269;
            this.cbCamera.Location = new System.Drawing.Point(13, 47);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(323, 20);
            this.cbCamera.TabIndex = 8;
            // 
            // cbVideoFormat
            // 
            this.cbVideoFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoFormat.DropDownWidth = 269;
            this.cbVideoFormat.Location = new System.Drawing.Point(13, 94);
            this.cbVideoFormat.Name = "cbVideoFormat";
            this.cbVideoFormat.Size = new System.Drawing.Size(323, 20);
            this.cbVideoFormat.TabIndex = 2;
            // 
            // button_AddCamera
            // 
            this.button_AddCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_AddCamera.Location = new System.Drawing.Point(770, 403);
            this.button_AddCamera.Name = "button_AddCamera";
            this.button_AddCamera.Size = new System.Drawing.Size(87, 35);
            this.button_AddCamera.TabIndex = 121;
            this.button_AddCamera.Text = "Add";
            this.button_AddCamera.UseVisualStyleBackColor = true;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(129, 68);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(55, 21);
            this.numericUpDown4.TabIndex = 8;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(129, 122);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(55, 21);
            this.numericUpDown3.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(129, 17);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(55, 21);
            this.numericUpDown2.TabIndex = 8;
            // 
            // gbUseVProAcqApi
            // 
            this.gbUseVProAcqApi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbUseVProAcqApi.Controls.Add(this.numericUpDown4);
            this.gbUseVProAcqApi.Controls.Add(this.numericUpDown3);
            this.gbUseVProAcqApi.Controls.Add(this.numericUpDown2);
            this.gbUseVProAcqApi.Controls.Add(this.lblContrast);
            this.gbUseVProAcqApi.Controls.Add(this.lblBrightness);
            this.gbUseVProAcqApi.Controls.Add(this.lblExposure);
            this.gbUseVProAcqApi.Enabled = false;
            this.gbUseVProAcqApi.Location = new System.Drawing.Point(561, 184);
            this.gbUseVProAcqApi.Name = "gbUseVProAcqApi";
            this.gbUseVProAcqApi.Size = new System.Drawing.Size(268, 164);
            this.gbUseVProAcqApi.TabIndex = 18;
            this.gbUseVProAcqApi.TabStop = false;
            this.gbUseVProAcqApi.Text = "Set Acquisition Properties";
            // 
            // lblContrast
            // 
            this.lblContrast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblContrast.Location = new System.Drawing.Point(13, 124);
            this.lblContrast.Name = "lblContrast";
            this.lblContrast.ReadOnly = true;
            this.lblContrast.Size = new System.Drawing.Size(63, 14);
            this.lblContrast.TabIndex = 7;
            this.lblContrast.Text = "Contrast";
            // 
            // lblBrightness
            // 
            this.lblBrightness.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblBrightness.Location = new System.Drawing.Point(13, 75);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.ReadOnly = true;
            this.lblBrightness.Size = new System.Drawing.Size(62, 14);
            this.lblBrightness.TabIndex = 7;
            this.lblBrightness.Text = "Brightness";
            this.lblBrightness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblExposure
            // 
            this.lblExposure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblExposure.Location = new System.Drawing.Point(13, 19);
            this.lblExposure.Name = "lblExposure";
            this.lblExposure.ReadOnly = true;
            this.lblExposure.Size = new System.Drawing.Size(89, 14);
            this.lblExposure.TabIndex = 7;
            this.lblExposure.Text = "Exposure (ms)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.gbUseVProAcqApi);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.dataGridView_Camera);
            this.panel3.Controls.Add(this.gbMakeFifo);
            this.panel3.Controls.Add(this.button_AddCamera);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button_RemoveCamera);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(879, 450);
            this.panel3.TabIndex = 19;
            // 
            // button_RemoveCamera
            // 
            this.button_RemoveCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_RemoveCamera.Location = new System.Drawing.Point(472, 403);
            this.button_RemoveCamera.Name = "button_RemoveCamera";
            this.button_RemoveCamera.Size = new System.Drawing.Size(87, 35);
            this.button_RemoveCamera.TabIndex = 121;
            this.button_RemoveCamera.Text = "Remove";
            this.button_RemoveCamera.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(658, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 121;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form_CameraConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.panel3);
            this.Name = "Form_CameraConfig";
            this.Text = "Form_CameraConfig";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Camera)).EndInit();
            this.gbMakeFifo.ResumeLayout(false);
            this.gbMakeFifo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.gbUseVProAcqApi.ResumeLayout(false);
            this.gbUseVProAcqApi.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHeader_Contrast;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHeader_Brightness;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHeader_Exposure;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHeader_VideoFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHeader_Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHeader_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHeader_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Camera_Index;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView_Camera;
        internal System.Windows.Forms.GroupBox gbMakeFifo;
        internal System.Windows.Forms.TextBox txtSelectVF;
        internal System.Windows.Forms.TextBox txtSelectFG;
        internal System.Windows.Forms.ComboBox cbCamera;
        internal System.Windows.Forms.ComboBox cbVideoFormat;
        private System.Windows.Forms.Button button_AddCamera;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        internal System.Windows.Forms.GroupBox gbUseVProAcqApi;
        internal System.Windows.Forms.TextBox lblContrast;
        internal System.Windows.Forms.TextBox lblBrightness;
        internal System.Windows.Forms.TextBox lblExposure;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_RemoveCamera;
        private System.Windows.Forms.Button button1;
    }
}