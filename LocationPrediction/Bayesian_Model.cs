using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using Smile;
namespace LocationPrediction
{
    class Bayesian_Model
    {
        String GeNIeFile;
        //String DatasetFile;
        int WindowSize;
        string Est_x, Est_y;
        public Bayesian_Model(String GeNIeFile, int WindowSize) {
            this.GeNIeFile = GeNIeFile;            
            this.WindowSize = WindowSize;
        }

        public String InferenceWithBayesianNetwork(String degrees , String signal_strength) {
            int outcomeindex;
            Network net = new Network();
            net.ReadFile("signal_list_equalWidthDiscretize_GTT_K2.xdsl");
            // Updating the network:
            net.UpdateBeliefs();

            //setting evidences to degrees
            net.SetEvidence("degrees", degrees);//*******************************************

            //setting evidences to signal strength
            net.SetEvidence("signal_strength", signal_strength);//**********************************************

            //updating network
            net.UpdateBeliefs();

            //get beliefs for x node
            net.GetNode("x");
            double max = 0;
            int buffer_x = 0;
            String[] X_OutcomeIds = net.GetOutcomeIds("x");
            double[] aValues_x = net.GetNodeValue("x");
            double temp_x = aValues_x[2];//random value for comparison
            for (outcomeindex = 0; outcomeindex < X_OutcomeIds.Length; outcomeindex++)
            {
                if (temp_x >= aValues_x[outcomeindex])
                {
                    max = temp_x;
                }
                else
                {
                    temp_x = aValues_x[outcomeindex];
                    buffer_x = outcomeindex;
                }
                //System.out.println("\t" + X_0_OutcomeIds[outcomeindex] + " , " + aValues_x_0[outcomeindex]);
            }

            // Get Beliefs for y_0 Node
            net.GetNode("y");
            int buffer_y = 0;
            String[] Y_OutcomeIds = net.GetOutcomeIds("y");
            double[] aValues_y = net.GetNodeValue("y");
            double temp_y = aValues_y[2];//random value for comparison
            for (outcomeindex = 0; outcomeindex < Y_OutcomeIds.Length; outcomeindex++)
            {
                if (temp_y >= aValues_y[outcomeindex])
                {
                    max = temp_y;
                }
                else
                {
                    temp_y = aValues_y[outcomeindex];
                    buffer_y = outcomeindex;
                }
                //System.out.println("\t" + Y_0_OutcomeIds[outcomeindex] + " , " + aValues_y_0[outcomeindex]);
            }
            Est_x = X_OutcomeIds[buffer_x];
            Est_y = Y_OutcomeIds[buffer_y];

            return Est_x +","+ Est_y;
        
        }//oxi

        public String InfereceWithBayesianNetworkWindowing36forX(String degrees0, String degrees1, String degrees2, String degrees3, String degrees4, String degrees5, String degrees6, String degrees7, String degrees8, String degrees9, String degrees10, String degrees11, String degrees12, String degrees13,
            String degrees14, String degrees15, String degrees16, String degrees17, String degrees18, String degrees19, String degrees20, String degrees21, String degrees22, String degrees23, String degrees24, String degrees25, String degrees26, String degrees27, String degrees28, String degrees29, String degrees30,
            String degrees31, String degrees32, String degrees33, String degrees34, String degrees35,String signal_strength0, String signal_strength1, String signal_strength2, String signal_strength3, String signal_strength4, String signal_strength5, String signal_strength6, String signal_strength7, String signal_strength8,
            String signal_strength9, String signal_strength10, String signal_strength11,String signal_strength12, String signal_strength13, String signal_strength14, String signal_strength15, String signal_strength16, String signal_strength17, String signal_strength18, String signal_strength19, String signal_strength20,
            String signal_strength21, String signal_strength22, String signal_strength23, String signal_strength24, String signal_strength25, String signal_strength26, String signal_strength27, String signal_strength28, String signal_strength29, String signal_strength30, String signal_strength31, String signal_strength32,
            String signal_strength33, String signal_strength34, String signal_strength35)
        {

            int outcomeindex;
            Network net = new Network();
            net.ReadFile("winxy36discX.xdsl");
            // Updating the network:
            net.UpdateBeliefs();

            //setting evidences to degrees
            net.SetEvidence("degrees_0", degrees0);
            net.SetEvidence("degrees_1", degrees1);
            net.SetEvidence("degrees_2", degrees2);
            net.SetEvidence("degrees_3", degrees3);
            net.SetEvidence("degrees_4", degrees4);
            net.SetEvidence("degrees_5", degrees5);
            net.SetEvidence("degrees_6", degrees6);
            net.SetEvidence("degrees_7", degrees7);
            net.SetEvidence("degrees_8", degrees8);
            net.SetEvidence("degrees_9", degrees9);
            net.SetEvidence("degrees_10", degrees10);
            net.SetEvidence("degrees_11", degrees11);
            net.SetEvidence("degrees_12", degrees12);
            net.SetEvidence("degrees_13", degrees13);
            net.SetEvidence("degrees_14", degrees14);
            net.SetEvidence("degrees_15", degrees15);
            net.SetEvidence("degrees_16", degrees16);
            net.SetEvidence("degrees_17", degrees17);
            net.SetEvidence("degrees_18", degrees18);
            net.SetEvidence("degrees_19", degrees19);
            net.SetEvidence("degrees_20", degrees20);
            net.SetEvidence("degrees_21", degrees21);
            net.SetEvidence("degrees_22", degrees22);
            net.SetEvidence("degrees_23", degrees23);
            net.SetEvidence("degrees_24", degrees24);
            net.SetEvidence("degrees_25", degrees25);
            net.SetEvidence("degrees_26", degrees26);
            net.SetEvidence("degrees_27", degrees27);
            net.SetEvidence("degrees_28", degrees28);
            net.SetEvidence("degrees_29", degrees29);
            net.SetEvidence("degrees_30", degrees30);
            net.SetEvidence("degrees_31", degrees31);
            net.SetEvidence("degrees_32", degrees32);
            net.SetEvidence("degrees_33", degrees33);
            net.SetEvidence("degrees_34", degrees34);
            net.SetEvidence("degrees_35", degrees35);

            //setting evidences to signal strength
            net.SetEvidence("signal_strength_0", signal_strength0);//**********************************************
            net.SetEvidence("signal_strength_1", signal_strength1);
            net.SetEvidence("signal_strength_2", signal_strength2);
            net.SetEvidence("signal_strength_3", signal_strength3);
            net.SetEvidence("signal_strength_4", signal_strength4);
            net.SetEvidence("signal_strength_5", signal_strength5);
            net.SetEvidence("signal_strength_6", signal_strength6);
            net.SetEvidence("signal_strength_7", signal_strength7);
            net.SetEvidence("signal_strength_8", signal_strength8);
            net.SetEvidence("signal_strength_9", signal_strength9);
            net.SetEvidence("signal_strength_10", signal_strength10);
            net.SetEvidence("signal_strength_11", signal_strength11);
            net.SetEvidence("signal_strength_12", signal_strength12);
            net.SetEvidence("signal_strength_13", signal_strength13);
            net.SetEvidence("signal_strength_14", signal_strength14);
            net.SetEvidence("signal_strength_15", signal_strength15);
            net.SetEvidence("signal_strength_16", signal_strength16);
            net.SetEvidence("signal_strength_17", signal_strength17);
            net.SetEvidence("signal_strength_18", signal_strength18);
            net.SetEvidence("signal_strength_19", signal_strength19);
            net.SetEvidence("signal_strength_20", signal_strength20);
            net.SetEvidence("signal_strength_21", signal_strength21);
            net.SetEvidence("signal_strength_22", signal_strength22);
            net.SetEvidence("signal_strength_23", signal_strength23);
            net.SetEvidence("signal_strength_24", signal_strength24);
            net.SetEvidence("signal_strength_25", signal_strength25);
            net.SetEvidence("signal_strength_26", signal_strength26);
            net.SetEvidence("signal_strength_27", signal_strength27);
            net.SetEvidence("signal_strength_28", signal_strength28);
            net.SetEvidence("signal_strength_29", signal_strength29);
            net.SetEvidence("signal_strength_30", signal_strength30);
            net.SetEvidence("signal_strength_31", signal_strength31);
            net.SetEvidence("signal_strength_32", signal_strength32);
            net.SetEvidence("signal_strength_33", signal_strength33);
            net.SetEvidence("signal_strength_34", signal_strength34);
            net.SetEvidence("signal_strength_35", signal_strength35);
            
            //updating network
            net.UpdateBeliefs();

            //get beliefs for x node
            net.GetNode("x");
            double max = 0;
            int buffer_x = 0;
            String[] X_OutcomeIds = net.GetOutcomeIds("x");
            double[] aValues_x = net.GetNodeValue("x");
            double temp_x = aValues_x[2];//random value for comparison
            for (outcomeindex = 0; outcomeindex < X_OutcomeIds.Length; outcomeindex++)
            {
                if (temp_x >= aValues_x[outcomeindex])
                {
                    max = temp_x;
                }
                else
                {
                    temp_x = aValues_x[outcomeindex];
                    buffer_x = outcomeindex;
                }
                //System.out.println("\t" + X_0_OutcomeIds[outcomeindex] + " , " + aValues_x_0[outcomeindex]);
            }           
            Est_x = X_OutcomeIds[buffer_x];
            return Est_x ;
        
        }

        public String InfereceWithBayesianNetworkWindowing36forY(String degrees0, String degrees1, String degrees2, String degrees3, String degrees4, String degrees5, String degrees6, String degrees7, String degrees8, String degrees9, String degrees10, String degrees11, String degrees12, String degrees13,
            String degrees14, String degrees15, String degrees16, String degrees17, String degrees18, String degrees19, String degrees20, String degrees21, String degrees22, String degrees23, String degrees24, String degrees25, String degrees26, String degrees27, String degrees28, String degrees29, String degrees30,
            String degrees31, String degrees32, String degrees33, String degrees34, String degrees35, String signal_strength0, String signal_strength1, String signal_strength2, String signal_strength3, String signal_strength4, String signal_strength5, String signal_strength6, String signal_strength7, String signal_strength8,
            String signal_strength9, String signal_strength10, String signal_strength11, String signal_strength12, String signal_strength13, String signal_strength14, String signal_strength15, String signal_strength16, String signal_strength17, String signal_strength18, String signal_strength19, String signal_strength20,
            String signal_strength21, String signal_strength22, String signal_strength23, String signal_strength24, String signal_strength25, String signal_strength26, String signal_strength27, String signal_strength28, String signal_strength29, String signal_strength30, String signal_strength31, String signal_strength32,
            String signal_strength33, String signal_strength34, String signal_strength35)
        {

            int outcomeindex;
            Network net = new Network();
            net.ReadFile("winxy36discY.xdsl");
            // Updating the network:
            net.UpdateBeliefs();

            //setting evidences to degrees
            net.SetEvidence("degrees_0", degrees0);
            net.SetEvidence("degrees_1", degrees1);
            net.SetEvidence("degrees_2", degrees2);
            net.SetEvidence("degrees_3", degrees3);
            net.SetEvidence("degrees_4", degrees4);
            net.SetEvidence("degrees_5", degrees5);
            net.SetEvidence("degrees_6", degrees6);
            net.SetEvidence("degrees_7", degrees7);
            net.SetEvidence("degrees_8", degrees8);
            net.SetEvidence("degrees_9", degrees9);
            net.SetEvidence("degrees_10", degrees10);
            net.SetEvidence("degrees_11", degrees11);
            net.SetEvidence("degrees_12", degrees12);
            net.SetEvidence("degrees_13", degrees13);
            net.SetEvidence("degrees_14", degrees14);
            net.SetEvidence("degrees_15", degrees15);
            net.SetEvidence("degrees_16", degrees16);
            net.SetEvidence("degrees_17", degrees17);
            net.SetEvidence("degrees_18", degrees18);
            net.SetEvidence("degrees_19", degrees19);
            net.SetEvidence("degrees_20", degrees20);
            net.SetEvidence("degrees_21", degrees21);
            net.SetEvidence("degrees_22", degrees22);
            net.SetEvidence("degrees_23", degrees23);
            net.SetEvidence("degrees_24", degrees24);
            net.SetEvidence("degrees_25", degrees25);
            net.SetEvidence("degrees_26", degrees26);
            net.SetEvidence("degrees_27", degrees27);
            net.SetEvidence("degrees_28", degrees28);
            net.SetEvidence("degrees_29", degrees29);
            net.SetEvidence("degrees_30", degrees30);
            net.SetEvidence("degrees_31", degrees31);
            net.SetEvidence("degrees_32", degrees32);
            net.SetEvidence("degrees_33", degrees33);
            net.SetEvidence("degrees_34", degrees34);
            net.SetEvidence("degrees_35", degrees35);

            //setting evidences to signal strength
            net.SetEvidence("signal_strength_0", signal_strength0);//**********************************************
            net.SetEvidence("signal_strength_1", signal_strength1);
            net.SetEvidence("signal_strength_2", signal_strength2);
            net.SetEvidence("signal_strength_3", signal_strength3);
            net.SetEvidence("signal_strength_4", signal_strength4);
            net.SetEvidence("signal_strength_5", signal_strength5);
            net.SetEvidence("signal_strength_6", signal_strength6);
            net.SetEvidence("signal_strength_7", signal_strength7);
            net.SetEvidence("signal_strength_8", signal_strength8);
            net.SetEvidence("signal_strength_9", signal_strength9);
            net.SetEvidence("signal_strength_10", signal_strength10);
            net.SetEvidence("signal_strength_11", signal_strength11);
            net.SetEvidence("signal_strength_12", signal_strength12);
            net.SetEvidence("signal_strength_13", signal_strength13);
            net.SetEvidence("signal_strength_14", signal_strength14);
            net.SetEvidence("signal_strength_15", signal_strength15);
            net.SetEvidence("signal_strength_16", signal_strength16);
            net.SetEvidence("signal_strength_17", signal_strength17);
            net.SetEvidence("signal_strength_18", signal_strength18);
            net.SetEvidence("signal_strength_19", signal_strength19);
            net.SetEvidence("signal_strength_20", signal_strength20);
            net.SetEvidence("signal_strength_21", signal_strength21);
            net.SetEvidence("signal_strength_22", signal_strength22);
            net.SetEvidence("signal_strength_23", signal_strength23);
            net.SetEvidence("signal_strength_24", signal_strength24);
            net.SetEvidence("signal_strength_25", signal_strength25);
            net.SetEvidence("signal_strength_26", signal_strength26);
            net.SetEvidence("signal_strength_27", signal_strength27);
            net.SetEvidence("signal_strength_28", signal_strength28);
            net.SetEvidence("signal_strength_29", signal_strength29);
            net.SetEvidence("signal_strength_30", signal_strength30);
            net.SetEvidence("signal_strength_31", signal_strength31);
            net.SetEvidence("signal_strength_32", signal_strength32);
            net.SetEvidence("signal_strength_33", signal_strength33);
            net.SetEvidence("signal_strength_34", signal_strength34);
            net.SetEvidence("signal_strength_35", signal_strength35);
            
            //updating network
            net.UpdateBeliefs();

            // Get Beliefs for y_0 Node
            net.GetNode("y");
            double max = 0;
            int buffer_y = 0;
            String[] Y_OutcomeIds = net.GetOutcomeIds("y");
            double[] aValues_y = net.GetNodeValue("y");
            double temp_y = aValues_y[2];//random value for comparison
            for (outcomeindex = 0; outcomeindex < Y_OutcomeIds.Length; outcomeindex++)
            {
                if (temp_y >= aValues_y[outcomeindex])
                {
                    max = temp_y;
                }
                else
                {
                    temp_y = aValues_y[outcomeindex];
                    buffer_y = outcomeindex;
                }
                //System.out.println("\t" + Y_0_OutcomeIds[outcomeindex] + " , " + aValues_y_0[outcomeindex]);
            }
            Est_y = Y_OutcomeIds[buffer_y];
            return Est_y;

        }
    }
}
