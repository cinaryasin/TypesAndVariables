using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();

        }

        private void GenerateButtons()
        {
            //Dama tahtasını butonla oluşturabilmek için öncelikle bir array da 8*8 liste haline getirdik.
            Button[,] buttons = new Button[8, 8];
            //butonların soldan ve yukarıdan hizalanmalarının belirlenmesi için left ve top değişkenleri oluşturduk.
            int left = 0;
            int top = 0;
            //listeyi döngüye bağlamak ve hepsini ayrı ayrı yazdırmak için 2 tane döngü oluşturduk.
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {//ilk döngümüzde i ile butonun satırlarını dolaştık
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {//ikinci döngüde j ile sütunları dolaştık
                    buttons[i, j] = new Button();//butonları tanımladık
                    buttons[i, j].Width = 50;//butona genişlik verdik
                    buttons[i, j].Height = 50;//butona yükseklik verdik
                    buttons[i, j].Left = left;//ilk butonu sola yerleştirdik
                    left += 50;//ve sırasıyla gelecek olan butonları soldan 50 artırarak devam ettik.
                    buttons[i, j].Top = top;//yükseklik değişkenini butona tanımladık ve onlarıda her satırda vereceğiz
                    //buton rengi için if bloğu çalıştırdık
                    if ((i + j) % 2 == 0)
                    {
                        // i ve j nin toplamının 2 ye bölümünden kalanı 0 olanların arka planını siyah yaptık
                        buttons[i, j].BackColor = Color.Black;

                    }
                    else
                    {
                        // i ve j nin toplamının 2 ye bölümünden kalanı 0 olmayanların yani tek sayı olanların arka planını beyaz yaptık
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);//butonları form uygulamasına yansıtmak için kullanıyoruz.
                }
                left = 0;//sütun dolaştıktan sonra tekrarda butonu diğer satıra geçerken sola yasladık
                top += 50;//ve diğer satıra geçerken yukardan 50 birim artırarak aşağı gelmesini sağladık.
            }
        }//Buttonlardan Dama Tahtası Yapma Windows Form Uygulaması
    }
}
