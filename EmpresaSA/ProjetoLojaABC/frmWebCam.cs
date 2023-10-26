using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace ProjetoLojaABC
{
    public partial class frmWebCam : Form
    {
        private bool DeviceExist = false; //verificar se tem dispositivo
        private FilterInfoCollection videoDevices; //verficar o tipo de filtragem (foco ou não)
        private VideoCaptureDevice videoSource = null; // capturar imagem

        public frmWebCam()
        {
            InitializeComponent();
        }

        private void video_NewFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pctCapturaImagem.Image = img;
        }

        private void frmWebCam_Load(object sender, EventArgs e)
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                cbbDispositivo.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
                foreach (FilterInfo device in videoDevices)
                {
                    cbbDispositivo.Items.Add(device.Name);
                }
                cbbDispositivo.SelectedIndex = 0;
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
                cbbDispositivo.Items.Add("Nenhum dispositivo esncontrado!");
            }
        }

        private void btnCaptura_Click(object sender, EventArgs e)
        {
            if (btnCaptura.Text == "Captura")
            {
                if (DeviceExist)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[cbbDispositivo.SelectedIndex].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);

                    //Encerrar sinal da camera
                    if (!(videoSource == null))
                        if (videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource = null;
                        }
                    videoSource.DesiredFrameSize = new Size(160, 120);
                    videoSource.DesiredFrameRate = 10;
                    videoSource.Start();

                    btnCaptura.Text = "Gravar";
                }
                else 
                {
                    MessageBox.Show("Nenhum dispositivo encontrado!");
                }
            }
            else 
            {
       
                if (videoSource.IsRunning)
                {
                    //Encerrar o sinal da camera
                    //Note que esse bloco de código se repetiu, vc pode criar um método para ele.
                    if (!(videoSource == null))
                        if (videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource = null;

                            //Salvar imagem
                            sfdSalvarImagem.Filter = "JPEG(*.jpg;*.jpeg;*.jpeg;*.jfif)| *.jpg;*.jpeg;*.jpeg;*.jfif";
                            DialogResult res = sfdSalvarImagem.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                pctCapturaImagem.Image.Save(sfdSalvarImagem.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            }
                         }
                }
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarIMG = new OpenFileDialog();
            BuscarIMG.InitialDirectory = ("Documentos\\imagens\\");
            BuscarIMG.FileName = "Imagem";
            BuscarIMG.Title = "Procurar Imagem";
            BuscarIMG.Filter = ("*jpg|*.jpg|*png|*.png|*bmp|*.bmp|*tif|*.tif");
            BuscarIMG.ShowDialog();
            pctCapturaImagem.ImageLocation = (BuscarIMG.FileName);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pctCapturaImagem.Image = null;
        }
    }
}
