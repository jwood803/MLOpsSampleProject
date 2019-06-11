//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace HousingML.Model.DataModels
{
    public class ModelInput
    {
        [ColumnName("longitude"), LoadColumn(0)]
        public float Longitude { get; set; }


        [ColumnName("latitude"), LoadColumn(1)]
        public float Latitude { get; set; }


        [ColumnName("housing_median_age"), LoadColumn(2)]
        public float Housing_median_age { get; set; }


        [ColumnName("total_rooms"), LoadColumn(3)]
        public float Total_rooms { get; set; }


        [ColumnName("total_bedrooms"), LoadColumn(4)]
        public float Total_bedrooms { get; set; }


        [ColumnName("population"), LoadColumn(5)]
        public float Population { get; set; }


        [ColumnName("households"), LoadColumn(6)]
        public float Households { get; set; }


        [ColumnName("median_income"), LoadColumn(7)]
        public float Median_income { get; set; }


        [ColumnName("median_house_value"), LoadColumn(8)]
        public float Median_house_value { get; set; }


        [ColumnName("ocean_proximity"), LoadColumn(9)]
        public string Ocean_proximity { get; set; }


    }
}
