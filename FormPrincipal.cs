using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;


namespace Segmentación_de_colores__HSV_
{
    public partial class FormPrincipal : Form
    {

        Image<Hsv, byte> img;
        Image<Gray, byte> imgHue;
        Image<Gray, byte> imgSat;
        Image<Gray, byte> imgVal;
        bool modHue;
        bool modSat;
        bool modVal;


        #region InicializarComponentes
        public FormPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region Importar
        private void importar()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if(ofd.ShowDialog()==DialogResult.OK)
                {
                    img = new Image<Hsv, byte>(ofd.FileName);

                    pictureBoxOrigin.Image = img.ToBitmap();
                    iniciarMiniaturasHSV();
                }
            }catch(Exception)
            {
                MessageBox.Show("Formato de imagen no reconocido", "Archivo no válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
                importar();
        }
        #endregion

        #region Iniciarminiaturas

        private void iniciarMiniaturasHSV()
        {
            imgHue = img[0];
            imgSat = img[1];
            imgVal = img[2];

            pictureBoxHue.Image = imgHue.Bitmap;
            pictureBoxSat.Image = imgSat.Bitmap;
            pictureBoxVal.Image = imgVal.Bitmap;
        }
        #endregion

        #region ActualizarMiniaturasHSV

        private void actualizarMinuaturas()
        {
            if (modHue == true)
            {               
                for (int i = 0; i < img.Height; i++)
                {
                    for (int j = 0; j < img.Width; j++)
                    {
                        if (img[i, j].Hue <= (trackHueMax.Value))
                        {
                            imgHue[i, j] = new Gray(img[i, j].Hue);
                        }
                        else
                        {
                            imgHue[i, j] = new Gray(0);
                        }
                    }

                }
                modHue = false;
                pictureBoxHue.Image = imgHue.ToBitmap();
            }
            if (modSat == true)
            {
                MessageBox.Show("Sat");
                for (int i = 0; i < img.Height; i++)
                {
                    for (int j = 0; j < img.Width; j++)
                    {
                        if (img[i, j].Satuation <= trackSatMax.Value)
                        {
                            imgSat[i, j] = new Gray(img[i, j].Satuation);
                        }else
                        {
                            imgSat[i, j] = new Gray(0);
                        }
                    }

                }
                modSat = false;
                pictureBoxSat.Image = imgSat.ToBitmap();
            }

            if (modVal == true)
            {
                MessageBox.Show("Val");
                for (int i = 0; i < img.Height; i++)
                {
                    for (int j = 0; j < img.Width; j++)
                    {
                        if (img[i, j].Value <= trackValMac.Value)
                        {
                            imgVal[i, j] = new Gray(img[i, j].Value);
                        }
                        else
                        {
                            imgVal[i, j] = new Gray(0);
                        }
                    }

                }
                modVal = false;
                pictureBoxVal.Image = imgVal.ToBitmap();
            }
        }


        #endregion

        #region BotonHSV
        private void btnActuHsv_Click(object sender, EventArgs e)
        {
            if(img!=null)
            {
                actualizarMinuaturas();
            }else
            {
                importar();
            }
            
        }
        #endregion

        #region MetodoTrackChange

        private void trackHueMax_ValueChanged(object sender, EventArgs e)
        {
            modHue = true;
        }

        private void trackSatMax_ValueChanged(object sender, EventArgs e)
        {
            modSat = true;
        }

        private void trackValMac_ValueChanged(object sender, EventArgs e)
        {
            modVal = true;
        }

        private void trackHueMax_Scroll(object sender, EventArgs e)
        {
            lbHue.Text = trackHueMax.Value.ToString();
        }

        private void trackSatMax_Scroll(object sender, EventArgs e)
        {
            lbSat.Text = trackSatMax.Value.ToString();
        }

        private void trackValMac_Scroll(object sender, EventArgs e)
        {
            lbVal.Text = trackValMac.Value.ToString();
        }
        #endregion




    }
}
