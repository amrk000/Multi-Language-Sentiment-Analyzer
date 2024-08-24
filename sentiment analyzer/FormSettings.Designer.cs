namespace sentiment_analyzer
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.modelStatus = new System.Windows.Forms.Label();
            this.exportModel = new System.Windows.Forms.Button();
            this.trainModel = new System.Windows.Forms.Button();
            this.loadModel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.modelPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadDatasetDialog = new System.Windows.Forms.OpenFileDialog();
            this.mlTrainingResults = new System.Windows.Forms.RichTextBox();
            this.loadModelDialog = new System.Windows.Forms.OpenFileDialog();
            this.exportModelDialog = new System.Windows.Forms.SaveFileDialog();
            this.trainingBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.modelStatus);
            this.panel1.Controls.Add(this.exportModel);
            this.panel1.Controls.Add(this.trainModel);
            this.panel1.Controls.Add(this.loadModel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.modelPath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 222);
            this.panel1.TabIndex = 0;
            // 
            // modelStatus
            // 
            this.modelStatus.AutoSize = true;
            this.modelStatus.BackColor = System.Drawing.Color.Transparent;
            this.modelStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelStatus.ForeColor = System.Drawing.Color.Silver;
            this.modelStatus.Location = new System.Drawing.Point(124, 89);
            this.modelStatus.Name = "modelStatus";
            this.modelStatus.Size = new System.Drawing.Size(121, 25);
            this.modelStatus.TabIndex = 6;
            this.modelStatus.Text = "Model Status";
            // 
            // exportModel
            // 
            this.exportModel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exportModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportModel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exportModel.ForeColor = System.Drawing.Color.White;
            this.exportModel.Location = new System.Drawing.Point(188, 160);
            this.exportModel.Name = "exportModel";
            this.exportModel.Size = new System.Drawing.Size(166, 42);
            this.exportModel.TabIndex = 5;
            this.exportModel.Text = "Export ";
            this.exportModel.UseVisualStyleBackColor = true;
            this.exportModel.Click += new System.EventHandler(this.exportModel_Click);
            // 
            // trainModel
            // 
            this.trainModel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.trainModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainModel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trainModel.ForeColor = System.Drawing.Color.White;
            this.trainModel.Location = new System.Drawing.Point(359, 160);
            this.trainModel.Name = "trainModel";
            this.trainModel.Size = new System.Drawing.Size(166, 42);
            this.trainModel.TabIndex = 4;
            this.trainModel.Text = "Train Model";
            this.trainModel.UseVisualStyleBackColor = true;
            this.trainModel.Click += new System.EventHandler(this.trainModel_Click);
            // 
            // loadModel
            // 
            this.loadModel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loadModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadModel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadModel.ForeColor = System.Drawing.Color.White;
            this.loadModel.Location = new System.Drawing.Point(16, 160);
            this.loadModel.Name = "loadModel";
            this.loadModel.Size = new System.Drawing.Size(166, 42);
            this.loadModel.TabIndex = 3;
            this.loadModel.Text = "Load";
            this.loadModel.UseVisualStyleBackColor = true;
            this.loadModel.Click += new System.EventHandler(this.loadModel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "ML Model:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modelPath
            // 
            this.modelPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelPath.Location = new System.Drawing.Point(15, 121);
            this.modelPath.Name = "modelPath";
            this.modelPath.ReadOnly = true;
            this.modelPath.Size = new System.Drawing.Size(511, 23);
            this.modelPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "ML Model Settings";
            // 
            // loadDatasetDialog
            // 
            this.loadDatasetDialog.FileName = "sentiment_dataset";
            this.loadDatasetDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.loadDatasetDialog_FileOk);
            // 
            // mlTrainingResults
            // 
            this.mlTrainingResults.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mlTrainingResults.Location = new System.Drawing.Point(0, 220);
            this.mlTrainingResults.Name = "mlTrainingResults";
            this.mlTrainingResults.ReadOnly = true;
            this.mlTrainingResults.Size = new System.Drawing.Size(537, 289);
            this.mlTrainingResults.TabIndex = 1;
            this.mlTrainingResults.Text = "";
            // 
            // loadModelDialog
            // 
            this.loadModelDialog.FileName = "Load Pre-Built ML Model";
            this.loadModelDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.loadModelDialog_FileOk);
            // 
            // exportModelDialog
            // 
            this.exportModelDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.exportModelDialog_FileOk);
            // 
            // trainingBackgroundWorker
            // 
            this.trainingBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.trainingBackgroundWorker_DoWork);
            this.trainingBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.trainingBackgroundWorker_RunWorkerCompleted);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 507);
            this.Controls.Add(this.mlTrainingResults);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button loadModel;
        private Label label2;
        private TextBox modelPath;
        private Button exportModel;
        private Button trainModel;
        private Label modelStatus;
        private OpenFileDialog loadDatasetDialog;
        private RichTextBox mlTrainingResults;
        private OpenFileDialog loadModelDialog;
        private SaveFileDialog exportModelDialog;
        private System.ComponentModel.BackgroundWorker trainingBackgroundWorker;
    }
}