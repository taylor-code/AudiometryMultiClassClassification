using Microsoft.ML.Data;

namespace AudiometryClassificationML.Model
{
    public class HearingSetInput
    {
        [ColumnName("Type"), LoadColumn(0)]
        public string Type { get; set; }


        [ColumnName("Degree"), LoadColumn(1)]
        public string Degree { get; set; }


        [ColumnName("Config"), LoadColumn(2)]
        public string Config { get; set; }


        [ColumnName("AC_L_250"), LoadColumn(3)]
        public int AC_L_250 { get; set; }


        [ColumnName("AC_L_500"), LoadColumn(4)]
        public int AC_L_500 { get; set; }


        [ColumnName("AC_L_1000"), LoadColumn(5)]
        public int AC_L_1000 { get; set; }


        [ColumnName("AC_L_2000"), LoadColumn(6)]
        public int AC_L_2000 { get; set; }


        [ColumnName("AC_L_4000"), LoadColumn(7)]
        public int AC_L_4000 { get; set; }


        [ColumnName("AC_L_8000"), LoadColumn(8)]
        public int AC_L_8000 { get; set; }


        [ColumnName("AC_R_250"), LoadColumn(9)]
        public int AC_R_250 { get; set; }


        [ColumnName("AC_R_500"), LoadColumn(10)]
        public int AC_R_500 { get; set; }


        [ColumnName("AC_R_1000"), LoadColumn(11)]
        public int AC_R_1000 { get; set; }


        [ColumnName("AC_R_2000"), LoadColumn(12)]
        public int AC_R_2000 { get; set; }


        [ColumnName("AC_R_4000"), LoadColumn(13)]
        public int AC_R_4000 { get; set; }


        [ColumnName("AC_R_8000"), LoadColumn(14)]
        public int AC_R_8000 { get; set; }


        [ColumnName("BC_L_250"), LoadColumn(15)]
        public int BC_L_250 { get; set; }


        [ColumnName("BC_L_500"), LoadColumn(16)]
        public int BC_L_500 { get; set; }


        [ColumnName("BC_L_1000"), LoadColumn(17)]
        public int BC_L_1000 { get; set; }


        [ColumnName("BC_L_2000"), LoadColumn(18)]
        public int BC_L_2000 { get; set; }


        [ColumnName("BC_L_4000"), LoadColumn(19)]
        public int BC_L_4000 { get; set; }


        [ColumnName("BC_L_8000"), LoadColumn(20)]
        public int BC_L_8000 { get; set; }


        [ColumnName("BC_R_250"), LoadColumn(21)]
        public int BC_R_250 { get; set; }


        [ColumnName("BC_R_500"), LoadColumn(22)]
        public int BC_R_500 { get; set; }


        [ColumnName("BC_R_1000"), LoadColumn(23)]
        public int BC_R_1000 { get; set; }


        [ColumnName("BC_R_2000"), LoadColumn(24)]
        public int BC_R_2000 { get; set; }


        [ColumnName("BC_R_4000"), LoadColumn(25)]
        public int BC_R_4000 { get; set; }


        [ColumnName("BC_R_8000"), LoadColumn(26)]
        public int BC_R_8000 { get; set; }

    }
}