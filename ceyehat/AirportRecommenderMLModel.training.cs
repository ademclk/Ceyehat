﻿// This file was auto-generated by ML.NET Model Builder. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.LightGbm;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;
using Microsoft.ML;

namespace Ceyehat
{
    public partial class AirportRecommenderMLModel
    {
        /// <summary>
        /// Retrains model using the pipeline generated as part of the training process. For more information on how to load data, see aka.ms/loaddata.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <param name="trainData"></param>
        /// <returns></returns>
        public static ITransformer RetrainPipeline(MLContext mlContext, IDataView trainData)
        {
            var pipeline = BuildPipeline(mlContext);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.Categorical.OneHotEncoding(@"UserId", @"UserId", outputKind: OneHotEncodingEstimator.OutputKind.Indicator)
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new[] { @"UserId" }))
                                    .Append(mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: @"AirportId", inputColumnName: @"AirportId"))
                                    .Append(mlContext.MulticlassClassification.Trainers.LightGbm(new LightGbmMulticlassTrainer.Options() { NumberOfLeaves = 4, NumberOfIterations = 4, MinimumExampleCountPerLeaf = 20, LearningRate = 1, LabelColumnName = @"AirportId", FeatureColumnName = @"Features", ExampleWeightColumnName = null, Booster = new GradientBooster.Options() { SubsampleFraction = 1, FeatureFraction = 1, L1Regularization = 2E-10, L2Regularization = 1 }, MaximumBinCountPerFeature = 255 }))
                                    .Append(mlContext.Transforms.Conversion.MapKeyToValue(outputColumnName: @"PredictedLabel", inputColumnName: @"PredictedLabel"));

            return pipeline;
        }
    }
}