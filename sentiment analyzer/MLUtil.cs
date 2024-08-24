using Microsoft.ML;
using static Microsoft.ML.DataOperationsCatalog;
using sentiment_analyzer;
using Microsoft.ML.Trainers;

namespace sentiment_analyzer
{
    public static class MLUtil
    {
        private static MLContext mlContext;
        private static ITransformer mlModel;
        
        private static String metricesResults;
        private static String modelPath;
        private static String datasetPath;

        static MLUtil() {
            mlContext = new MLContext();

            modelPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MLModel.bin").ToString();
            datasetPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dataset","sentiment_dataset.csv").ToString();
            
            metricesResults ="";
            LoadModelFromPath();
        }
        
        public static void LoadModelFromPath() {
            if (File.Exists(modelPath))
            {
                DataViewSchema modelSchema;
                mlModel = mlContext.Model.Load(modelPath, out modelSchema);
            }
        }

        public static bool DoesModelExists() {
            return mlModel != null;
        }

        public static void SetModelPath(String path) {
            modelPath = path;
        }

        public static void SetDatasetPath(String path)
        {
            datasetPath = path;
        }

        public static String GetModelPath()
        {
            return modelPath;
        }

        public static String GetDatasetPath()
        {
            return datasetPath;
        }

        public static String GetMetrices() {
            return metricesResults;
        }

        public static int Predict(String sentence)
        {
            SentimentData sampleStatement = new SentimentData
            {
                SentimentText = sentence
            };

            var predictionEngine = mlContext.Model.CreatePredictionEngine<SentimentData, SentimentPrediction>(mlModel);
            var prediction = predictionEngine.Predict(sampleStatement);

            return (prediction.Prediction?1:0);
        }

        public static void TrainAndBuildModel()
        {
            TrainTestData dataset = LoadData(datasetPath);

            ITransformer model = BuildAndTrainModel(dataset.TrainSet);
            mlModel = model;
            modelPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MLModel.bin");

            EvaluateModel(dataset.TestSet);
            SaveModel(dataset.TrainSet.Schema);
        }

        private static TrainTestData LoadData(String path)
        {
            IDataView dataView = mlContext.Data.LoadFromTextFile<SentimentData>(path, hasHeader: false, separatorChar: ',');
            TrainTestData splitDataView = mlContext.Data.TrainTestSplit(dataView, testFraction: 0.20);

            return splitDataView;
        }

        private static ITransformer BuildAndTrainModel(IDataView TrainSet)
        {
            var estimator = mlContext.Transforms.Text.FeaturizeText(outputColumnName: "Features", inputColumnName: nameof(SentimentData.SentimentText));

            var options = new SdcaLogisticRegressionBinaryTrainer.Options()
            {
                LabelColumnName = "Label",
                FeatureColumnName = "Features",
                MaximumNumberOfIterations = 1000,
                BiasLearningRate = 0.01f
            };

            var TrainerEstimator = estimator.Append(mlContext.BinaryClassification.Trainers.SdcaLogisticRegression(options));
            ITransformer model = TrainerEstimator.Fit(TrainSet);
            
            return model;
        }

        private static void EvaluateModel(IDataView TestSet)
        {
            var prediction = mlModel.Transform(TestSet);
            var metrics = mlContext.BinaryClassification.Evaluate(prediction,labelColumnName: "Label");
           
            metricesResults = "Results:\n";
            metricesResults += "Training & Model Building Finished Successfully!\n";
            metricesResults += "Accuracy: " + string.Format("{0:P2}", metrics.Accuracy) +"\n";
            metricesResults += "Precision: " + string.Format("{0:P2}", metrics.PositivePrecision) + "\n";
            metricesResults += "Recall: " + string.Format("{0:P2}", metrics.PositiveRecall) + "\n";
            metricesResults += "F1 Score: " + string.Format("{0:P2}", metrics.F1Score) + "\n";
        }

        private static void SaveModel(DataViewSchema trainingDataViewSchema)
        {
            mlContext.Model.Save(mlModel, trainingDataViewSchema, modelPath);
        }

    }
}
