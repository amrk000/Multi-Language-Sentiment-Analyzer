using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sentiment_analyzer
{
    public partial class FormSettings : Form
    {
     
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            modelPath.Text = MLUtil.GetModelPath();
            updateModelStatus();
        }

        private void updateModelStatus() {
            if (MLUtil.DoesModelExists()) {
                modelStatus.Text = "✔Found";
                modelStatus.ForeColor = Color.LightGreen;
            }
            else {
                modelStatus.Text = "❌Not Found";
                modelStatus.ForeColor = Color.Red;
            }
           
        }

        private void trainModel_Click(object sender, EventArgs e)
        {
            loadDatasetDialog.Title = "Select Training Dataset";
            loadDatasetDialog.Filter = "CSV files|*.csv";
            loadDatasetDialog.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dataset");
            loadDatasetDialog.ShowDialog();
        }

        private void loadDatasetDialog_FileOk(object sender, CancelEventArgs e)
        {
            String path = loadDatasetDialog.FileName;
            mlTrainingResults.Text += "DataSet: " + path + "\n\n";
            MLUtil.SetDatasetPath(path);

            trainingBackgroundWorker.RunWorkerAsync();
            loadModel.Visible = false;
            exportModel.Visible = false;
            trainModel.Visible = false;
            mlTrainingResults.Text += "Model Training Started ...\n\n";
        }
        
        private void trainingBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                MLUtil.TrainAndBuildModel();
            }
            catch (Exception exception){
                MessageBox.Show("Dataset schema should be:\n- text,label (integer 0 or 1)\n- with no headers\n- columns sperated with: ,","Error Can't Read Dataset");
            }
        }

        private void trainingBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            mlTrainingResults.Text += MLUtil.GetMetrices()+ "\n";
            modelPath.Text = MLUtil.GetModelPath();
            updateModelStatus();
            loadModel.Visible = true;
            exportModel.Visible = true;
            trainModel.Visible = true;
        }

        private void loadModel_Click(object sender, EventArgs e)
        {
            loadModelDialog.Title = "Load Pre-Built ML Model";
            loadModelDialog.Filter = "ML Model files|*bin";
            loadModelDialog.ShowDialog();
        }

        private void loadModelDialog_FileOk(object sender, CancelEventArgs e)
        {
            String path = loadModelDialog.FileName;
            mlTrainingResults.Text += "ML Model: " + path + "\n\n";
            modelPath.Text = path;
            
            MLUtil.SetModelPath(path);
            try
            {
                MLUtil.LoadModelFromPath();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Not compatible model file", "Invalid ML Model");
            }
            updateModelStatus();
        }

        private void exportModel_Click(object sender, EventArgs e)
        {
            if (!MLUtil.DoesModelExists())
            {
                MessageBox.Show("Train and build model using dataset first", "ML Model Not Found !");
                return;
            }

            exportModelDialog.Title = "Load Pre-Built ML Model";
            exportModelDialog.FileName = "MLModel.bin";
            exportModelDialog.Filter = "ML Model files|*bin";
            exportModelDialog.ShowDialog();
        }

        private void exportModelDialog_FileOk(object sender, CancelEventArgs e)
        {
            File.Copy(MLUtil.GetModelPath(), exportModelDialog.FileName,true);
            
            mlTrainingResults.Text += "ML Model Exported To: " + exportModelDialog.FileName + "\n\n";
        }

    }
}
