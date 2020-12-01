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
using Emgu.CV.Cvb;


namespace Segmentación_de_colores__HSV_
{
    public partial class FormPrincipal : Form
    {

        Image<Hsv, byte> img;
        Image<Gray, byte> imgHue;
        Image<Gray, byte> imgSat;
        Image<Gray, byte> imgVal;
        Image<Gray, byte> imgHueIntervalo;       
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
                    pictureOmin.Image = img.ToBitmap();
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
            imgHueIntervalo = img[0];

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

        #region ScrollIntervalo
        private void trackInter1_Scroll(object sender, EventArgs e)
        {
            if(trackInter1.Value>trackInter2.Value)
            {
                lbIntervalo.Text = "[-,-]";
            }else
            {
                lbIntervalo.Text = "[" + trackInter1.Value.ToString() + " , " + trackInter2.Value.ToString() + "]";
            }
            
        }

        private void trackInter2_Scroll(object sender, EventArgs e)
        {
            if (trackInter1.Value > trackInter2.Value)
            {
                lbIntervalo.Text = "[-,-]";
            }
            else
            {
                lbIntervalo.Text = "[" + trackInter1.Value.ToString() + " , " + trackInter2.Value.ToString() + "]";
            }

        }
        #endregion

        #region HUEnizar

        private void HUEnizar()
        {
            double aux = 0;
            double aux2 = 0;
            double aux1 = 0;
            aux2 = trackInter2.Value;
            aux2 = aux2 * 0.5;
            aux1 = trackInter1.Value;
            aux1 = aux1 * 0.5;
            

            if (img != null)
            {
                for (int i = 0; i < img.Height; i++)
                {
                    for (int j = 0; j < img.Width; j++)
                    {
                        aux = img[i, j].Hue;
                        if (aux < aux2 & aux > aux1)
                        {

                            imgHueIntervalo[i, j] = new Gray(aux);
                        }
                        else
                        {
                            if (img[i, j].Satuation == 255 & aux == 0 & aux1==0)
                            {
                                imgHueIntervalo[i, j] = new Gray(0);
                            }
                            else
                            {
                                imgHueIntervalo[i, j] = new Gray(255);
                            }

                        }

                    }
                }
                pictureBoxOrigin.Image = imgHueIntervalo.ToBitmap();

            }
            else
            {
                importar();
            }
        }

        #endregion

        #region HUE BOTÓN
        private void btnHue_Click(object sender, EventArgs e)
        {           
            HUEnizar();
            btnORG.Enabled = true;
            btnHue.Enabled = false;
        }

        #endregion

        #region BlobsDetection
        private void btnBlobs_Click(object sender, EventArgs e)
        {
           

            /*CvBlobs imageblob = new CvBlobs();
            CvBlobDetector detector = new CvBlobDetector();
            uint numBlobs = 0;
            imgHueIntervalo = imgHueIntervalo.ThresholdBinaryInv(new Gray((int)numericFil1.Value), new Gray((int)numericFil2.Value));
            pictureBoxOrigin.Image = imgHueIntervalo.ToBitmap();            
            numBlobs = detector.Detect(imgHueIntervalo, imageblob);
            Image<Bgr, byte> blobImg = detector.DrawBlobs(imgHueIntervalo,imageblob,CvBlobDetector.BlobRenderType.BoundingBox,.1);
            pictureBoxOrigin.Image = blobImg.ToBitmap();*/




        }
        #endregion

        #region Binarizar
        private Image<Gray,byte> binarizar(Image<Gray,byte> imgBin)
        {
            HUEnizar();
            Image<Gray, byte> imgBinResult = new Image<Gray, byte>(img.Width, img.Height);
            imgBinResult = imgBin.ThresholdBinaryInv(new Gray((int)numericFil1.Value), new Gray((int)numericFil2.Value));
            return imgBinResult;
        }
        #endregion

        #region Borde
        private void btnBorde_Click(object sender, EventArgs e)
        {
            if(img!=null)
            {
                pictureBoxOrigin.Image = binarizar(imgHueIntervalo).ToBitmap(); ;
            }else
            {
                importar();
            }
            
        }
        #endregion

        private void btnORG_Click(object sender, EventArgs e)
        {
            pictureBoxOrigin.Image = img.ToBitmap();
            btnORG.Enabled = false;
            btnHue.Enabled = true;
        }
    }
}
