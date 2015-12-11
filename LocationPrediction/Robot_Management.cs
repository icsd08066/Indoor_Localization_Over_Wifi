using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace LocationPrediction
{
    class Robot_Management
    {
        PC_BOT.M3 m31;
        String RotateText;
        String VelocityText;
        private int Power = 100;

        public Robot_Management(PC_BOT.M3 m31, String RotateText , String VelocityText)
        {
            this.m31 = m31;
            this.RotateText = RotateText;
            this.VelocityText = VelocityText;

        }

        public void Rotate(String textBoxRotate, String VelocityText )
        {
            try
            {
                int degrees = 9;
                int Vel = Convert.ToInt32(VelocityText);

                //The call to Rotate() takes 4 parameters.
                //1) the number of degrees to rotate (rotate x degrees)
                //2) The rotation velocity (mm/s)
                //3) The power setting (by default 100)
                //4) The direction (Clockwise or Anticlockwise)
                m31.Rotate(degrees, Vel, Power, PC_BOT.M3.rotate.Clockwise);
            }
            catch (Exception ex)
            {
                //We have a problem, so we will send out an error message.
                m31.SendMessage(ex.Message, PC_BOT.PCBOTEventArgs.messageType.error);
            }
        }
        //function to stop M3 Bot
        public void Stop(object sender, EventArgs e)
        {
            m31.Stop();
        }

        public void m31_PositionEvent(object sender, PC_BOT.PCBOTPositionEventArgs e)
        {
            m31.SendMessage("Done", PC_BOT.PCBOTEventArgs.messageType.information);
        }

    }
}
