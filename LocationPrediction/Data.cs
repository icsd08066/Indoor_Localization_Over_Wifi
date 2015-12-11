using System;
using System.Collections;
using System.Collections.Generic;
//using System.Linq;
using System.Text;


namespace LocationPrediction
{
    class Data
    {

        ArrayList x_list = new ArrayList();
        ArrayList y_list = new ArrayList();
        ArrayList SS_list = new ArrayList();
        ArrayList AoA_list = new ArrayList();
        public Data()
        {
            Create_X_list_Discretized_Equal_20(x_list);
            Create_Y_list_Discretized_Equal_20(y_list);
            Create_SS_list_Discretized_Equal_20(SS_list);
            Create_AoA_list_Discretized(AoA_list);
        }

        public void Create_X_list_Discretized_Equal_20(ArrayList x_list)
        {
            //ArrayList<String> x_list = new ArrayList<String>();
            x_list.Add("X01_bellow_n1141");
            x_list.Add("X02_n1141_n1092");
            x_list.Add("X03_n1092_n1043");
            x_list.Add("X05_n994_n945");
            x_list.Add("X06_n945_n896");
            x_list.Add("X08_n847_n798");
            x_list.Add("X09_n798_n749");
            x_list.Add("X11_n700_n651");
            x_list.Add("X12_n651_n602");
            x_list.Add("X13_n602_n553");
            x_list.Add("X15_n504_n455");
            x_list.Add("X16_n455_n406");
            x_list.Add("X18_n357_n308");
            x_list.Add("X19_n308_n259");
            x_list.Add("X20_n259_up");
        }

        public void Create_Y_list_Discretized_Equal_20(ArrayList y_list)
        {
            //ArrayList<String> y_list = new ArrayList<String>();
            y_list.Add("Y01_below_129");
            y_list.Add("Y02_129_189");
            y_list.Add("Y03_189_248");
            y_list.Add("Y04_248_308");
            y_list.Add("Y05_308_367");
            y_list.Add("Y06_367_427");
            y_list.Add("Y08_486_546");
            y_list.Add("Y09_546_605");
            y_list.Add("Y10_605_665");
            y_list.Add("Y11_665_724");
            y_list.Add("Y12_724_784");
            y_list.Add("Y13_784_843");
            y_list.Add("Y15_903_962");
            y_list.Add("Y16_962_1022");
            y_list.Add("Y17_1022_1081");
            y_list.Add("Y18_1081_1141");
            y_list.Add("Y19_1141_1200");
            y_list.Add("Y20_1200_up");
        }

        public void Create_SS_list_Discretized_Equal_20(ArrayList SS_list)
        {
            SS_list.Add("S01_below_n67");
            SS_list.Add("S02_n67_n64");
            SS_list.Add("S03_n64_n61");
            SS_list.Add("S04_n61_n58");
            SS_list.Add("S05_n58_n56");
            SS_list.Add("S06_n56_n53");
            SS_list.Add("S07_n53_n50");
            SS_list.Add("S08_n50_n47");
            SS_list.Add("S09_n47_n44");
            SS_list.Add("S10_n44_n42");
            SS_list.Add("S11_n42_n39");
            SS_list.Add("S12_n39_n36");
            SS_list.Add("S13_n36_n33");
            SS_list.Add("S14_n33_n30");
            SS_list.Add("S15_n30_n28");
            SS_list.Add("S16_n28_n25");
            SS_list.Add("S17_n25_n22");
            SS_list.Add("S18_n22_n19");
            SS_list.Add("S19_n19_n16");
            SS_list.Add("S20_n16_up");
        }

        public void Create_AoA_list_Discretized(ArrayList AoA_list)
        {
            AoA_list.Add("D01_below_5");
            AoA_list.Add("D02_5_15");
            AoA_list.Add("D03_15_25");
            AoA_list.Add("D04_25_35");
            AoA_list.Add("D05_35_45");
            AoA_list.Add("D06_45_55");
            AoA_list.Add("D07_55_65");
            AoA_list.Add("D08_65_75");
            AoA_list.Add("D09_75_85");
            AoA_list.Add("D10_85_95");
            AoA_list.Add("D11_95_105");
            AoA_list.Add("D12_105_115");
            AoA_list.Add("D13_115_125");
            AoA_list.Add("D14_125_135");
            AoA_list.Add("D15_135_145");
            AoA_list.Add("D16_145_155");
            AoA_list.Add("D17_155_165");
            AoA_list.Add("D18_165_175");
            AoA_list.Add("D19_175_185");
            AoA_list.Add("D20_185_195");
            AoA_list.Add("D21_195_205");
            AoA_list.Add("D22_205_215");
            AoA_list.Add("D23_215_225");
            AoA_list.Add("D24_225_235");
            AoA_list.Add("D25_235_245");
            AoA_list.Add("D26_245_255");
            AoA_list.Add("D27_255_265");
            AoA_list.Add("D28_265_275");
            AoA_list.Add("D29_275_285");
            AoA_list.Add("D30_285_295");
            AoA_list.Add("D31_295_305");
            AoA_list.Add("D32_305_315");
            AoA_list.Add("D33_315_325");
            AoA_list.Add("D34_325_335");
            AoA_list.Add("D35_335_345");
            AoA_list.Add("D36_345_up");
        }

        public String check_x(String Est_x, String row)
        {
            //find what row is from x_list
            int row_index = x_list.IndexOf(row);
            //System.out.println("Found row : " + row + (row_index == -1 ? false : true) + ", in position : " + row_index);

            if (Est_x.Equals(row) || Est_x.Equals(x_row_correction(row_index - 3)) || Est_x.Equals(x_row_correction(row_index - 2)) || Est_x.Equals(x_row_correction(row_index - 1))
                    || Est_x.Equals(x_row_correction(row_index + 1)) || Est_x.Equals(x_row_correction(row_index + 2)) || Est_x.Equals(x_row_correction(row_index + 3)))
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }

        public String check_y(String Est_y, String row)
        {
            //find what row is from x_list
            int row_index = y_list.IndexOf(row);
            //System.out.println(y_list.size());

            if (Est_y.Equals(row) || Est_y.Equals(y_row_correction(row_index - 3)) || Est_y.Equals(y_list.Equals(y_row_correction(row_index - 2))) || Est_y.Equals(y_row_correction(row_index - 1))
                    || Est_y.Equals(y_row_correction(row_index + 1)) || Est_y.Equals(y_row_correction(row_index + 2)) || Est_y.Equals(y_row_correction(row_index + 3)))
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }

        public int y_row_correction(int row)
        {
            int row_index = y_list.IndexOf(row);
            if (row_index == -1 || row_index == -2 || row_index == -3)
            {
                return 0;
            }
            else if (row_index == 18 || row_index == 19 || row_index == 20)
            {
                return y_list.Count - 1;
            }
            return 0;
        }

        public int x_row_correction(int row)
        {
            int row_index = x_list.IndexOf(row);
            if (row_index == -1 || row_index == -2 || row_index == -3)
            {
                return 0;
            }
            else if (row_index == 18 || row_index == 19 || row_index == 20)
            {
                return x_list.Count - 1;
            }
            return 0;
        }

        public String find_SS(String Signal_Stength) { 
            Double SS = Convert.ToDouble(Signal_Stength);
            if (SS< -67.2) {
                return SS_list[0] as String;
            }else if((SS>= -67.2)&& (SS< -64.4)){
                return SS_list[1] as String;
            }
            else if ((SS >= -64.4) && (SS < -61.6))
            {
                return SS_list[2] as String;
            }
            else if ((SS >= -61.6) && (SS < -58.8))
            {
                return SS_list[3] as String;
            }
            else if ((SS >= -58.8) && (SS < -56))
            {
                return SS_list[4] as String;
            }
            else if ((SS >= -56) && (SS < -53.2))
            {
                return SS_list[5] as String;
            }else if ((SS >= -53.2) && (SS < -50.4))
            {
                return SS_list[6] as String;
            }
            else if ((SS >= -50.4) && (SS < -47.6))
            {
                return SS_list[7] as String;
            }
            else if ((SS >= -47.6) && (SS < -44.8))
            {
                return SS_list[8] as String;
            }
            else if ((SS >= -44.8) && (SS < -42))
            {
                return SS_list[9] as String;
            }
            else if ((SS >= -42) && (SS < -39.2))
            {
                return SS_list[10] as String;
            }
            else if ((SS >= -39.2) && (SS < -36.4))
            {
                return SS_list[11] as String;
            }
            else if ((SS >= -36.4) && (SS < -33.6))
            {
                return SS_list[12] as String;
            }
            else if ((SS >= -33.6) && (SS < -30.8))
            {
                return SS_list[13] as String;
            }
            else if ((SS >= -30.8) && (SS < -28))
            {
                return SS_list[14] as String;
            }
            else if ((SS >= -28) && (SS < -25.2))
            {
                return SS_list[15] as String;
            }
            else if ((SS >= -25.2) && (SS < -22.4))
            {
                return SS_list[16] as String;
            }
            else if ((SS >= -22.4) && (SS < -19.6))
            {
                return SS_list[17] as String;
            }
            else if ((SS >= -19.6) && (SS < -16.8))
            {
                return SS_list[18] as String;
            }
            else 
            {
                return SS_list[19] as String;
            }
        
        }

        public String find_AoA(string degrees) {
            int AoA = Convert.ToInt32(degrees);
            if (AoA < 5)
            {
                return AoA_list[0] as String;
            }
            else if ((AoA >= 5) && (AoA < 15))
            {
                return AoA_list[1] as String;
            }
            else if ((AoA >=15) && (AoA < 25))
            {
                return AoA_list[2] as String;
            }
            else if ((AoA >= 25) && (AoA < 35))
            {
                return AoA_list[3] as String;
            }
            else if ((AoA >= 35) && (AoA < 45))
            {
                return AoA_list[4] as String;
            }
            else if ((AoA >= 45) && (AoA < 55))
            {
                return AoA_list[5] as String;
            }
            else if ((AoA >= 55) && (AoA < 65))
            {
                return AoA_list[6] as String;
            }
            else if ((AoA >= 65) && (AoA < 75))
            {
                return AoA_list[7] as String;
            }
            else if ((AoA >= 75) && (AoA < 85))
            {
                return AoA_list[8] as String;
            }
            else if ((AoA >= 85) && (AoA < 95))
            {
                return AoA_list[9] as String;
            }
            else if ((AoA >= 95) && (AoA < 105))
            {
                return AoA_list[10] as String;
            }
            else if ((AoA >= 105) && (AoA < 115))
            {
                return AoA_list[11] as String;
            }
            else if ((AoA >= 115) && (AoA < 125))
            {
                return AoA_list[12] as String;
            }
            else if ((AoA >= 125) && (AoA < 135))
            {
                return AoA_list[13] as String;
            }
            else if ((AoA >= 135) && (AoA < 145))
            {
                return AoA_list[14] as String;
            }
            else if ((AoA >= 145) && (AoA < 155))
            {
                return AoA_list[15] as String;
            }
            else if ((AoA >= 155) && (AoA < 165))
            {
                return AoA_list[16] as String;
            }
            else if ((AoA >= 165) && (AoA < 175))
            {
                return AoA_list[17] as String;
            }
            else if ((AoA >= 175) && (AoA < 185))
            {
                return AoA_list[18] as String;
            }
            else if ((AoA >= 185) && (AoA < 195))
            {
                return AoA_list[19] as String;
            }
            else if ((AoA >= 195) && (AoA < 205))
            {
                return AoA_list[20] as String;
            }
            else if ((AoA >= 205) && (AoA < 215))
            {
                return AoA_list[21] as String;
            }
            else if ((AoA >= 215) && (AoA < 225))
            {
                return AoA_list[22] as String;
            }else if ((AoA >= 225) && (AoA < 235))
            {
                return AoA_list[23] as String;
            }
            else if ((AoA >= 235) && (AoA < 245))
            {
                return AoA_list[24] as String;
            }
            else if ((AoA >= 245) && (AoA < 255))
            {
                return AoA_list[25] as String;
            }
            else if ((AoA >= 255) && (AoA < 265))
            {
                return AoA_list[26] as String;
            }
            else if ((AoA >= 265) && (AoA < 275))
            {
                return AoA_list[27] as String;
            }
            else if ((AoA >= 275) && (AoA < 285))
            {
                return AoA_list[28] as String;
            }
            else if ((AoA >= 285) && (AoA < 295))
            {
                return AoA_list[29] as String;
            }
            else if ((AoA >= 295) && (AoA < 305))
            {
                return AoA_list[30] as String;
            }
            else if ((AoA >= 305) && (AoA < 315))
            {
                return AoA_list[31] as String;
            }
            else if ((AoA >= 315) && (AoA < 325))
            {
                return AoA_list[32] as String;
            }
            else if ((AoA >= 325) && (AoA < 335))
            {
                return AoA_list[33] as String;
            }
            else if ((AoA >= 335) && (AoA < 345))
            {
                return AoA_list[34] as String;
            }
            else 
            {
                return AoA_list[35] as String;
            }
        }

        public int returnX(String x)
        {
            if (x.Equals(x_list[14])) {
                return -210;
            }
            else if (x.Equals(x_list[13]))
            {
                return -280;
            }
            else if (x.Equals(x_list[12]))
            {
                return -350;
            }
            else if (x.Equals(x_list[11]))
            {
                return -420;
            }
            else if (x.Equals(x_list[10]))
            {
                return -490;
            }
            else if (x.Equals(x_list[9]))
            {
                return -560;
            }
            else if (x.Equals(x_list[8]))
            {
                return -630;
            }
            else if (x.Equals(x_list[7]))
            {
                return -700;
            }
            else if (x.Equals(x_list[6]))
            {
                return -770;
            }
            else if (x.Equals(x_list[5]))
            {
                return -840;
            }
            else if (x.Equals(x_list[4]))
            {
                return -910;
            }
            else if (x.Equals(x_list[3]))
            {
                return -980;
            }
            else if (x.Equals(x_list[2]))
            {
                return -1050;
            }
            else if (x.Equals(x_list[1]))
            {
                return -1120;
            }
            else if (x.Equals(x_list[0]))
            {
                return -1190;
            }
            else
            {
                return 0;
            }
        }

        public int returnY(String y)
        {
            if (y.Equals(y_list[17]))
            {
                return 1260;
            }
            else if (y.Equals(y_list[16]))
            {
                return 1190;
            }
            else if (y.Equals(y_list[15]))
            {
                return 1120;
            }
            else if (y.Equals(y_list[14]))
            {
                return 1050;
            }
            else if (y.Equals(y_list[13]))
            {
                return 980;
            }
            else if (y.Equals(y_list[12]))
            {
                return 910;
            }
            else if (y.Equals(y_list[11]))
            {
                return 840;
            }
            else if (y.Equals(y_list[10]))
            {
                return 770;
            }
            else if (y.Equals(y_list[9]))
            {
                return 700;
            }
            else if (y.Equals(y_list[8]))
            {
                return 630;
            }
            else if (y.Equals(y_list[7]))
            {
                return 560;
            }
            else if (y.Equals(y_list[6]))
            {
                return 490;
            }
            else if (y.Equals(y_list[5]))
            {
                return 420;
            }
            else if (y.Equals(y_list[4]))
            {
                return 350;
            }
            else if (y.Equals(y_list[3]))
            {
                return 280;
            }
            else if (y.Equals(y_list[2]))
            {
                return 210;
            }
            else if (y.Equals(y_list[1]))
            {
                return 140;
            }
            else if (y.Equals(y_list[0]))
            {
                return 70;
            }
            
            else
            {
                return 0;
            }
        }
    }
}
