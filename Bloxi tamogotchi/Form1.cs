using Bloxi_tamogotchi.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http.Headers;


namespace Bloxi_tamogotchi
{
    

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Visible = false;
            label3.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            textBox1.Visible = false;
            
        }
        int madnessW = 0;
        int stopX = 0;
        public static async void expact(int madnessW, int stop, PictureBox pictbox1, PictureBox pictbox2)
        {
            if (stop == 1)
            {
                madnessW = 0;
                while (madnessW < 120)
                {
                    await Task.Delay(1000);
                    madnessW++;
                }
                pictbox1.Image = Bloxi_tamogotchi.Properties.Resources._2;
                pictbox2.Image = Bloxi_tamogotchi.Properties.Resources._0;
                while (madnessW < 125)
                {
                    await Task.Delay(1000);
                    madnessW++;
                }
                if (madnessW == 125)
                {
                    Application.Exit();
                }
                else
                {
                    pictbox2.Image = Bloxi_tamogotchi.Properties.Resources.questioner;
                    pictbox1.Image = Bloxi_tamogotchi.Properties.Resources._0;
                }
            }
            else
            {
                madnessW = 100;
            }
        }

        public static void mady(int madness)
        {
            if (madness >= 5)
            {
                Application.Exit();
            }
        }

        public static void kd2(Label label)
        {
            label.Text = "чем?";
        }
        public static void kd(Label label)
        {
            label.Text = "кнопки действий";
        }

        int madness = 0;

        public static void madlab(int madness, Label lab)
        {
            lab.Text = madness.ToString();
        }

        public static void mad(int madness, PictureBox pictBox)
        {
            if (madness == 1)
            {
                pictBox.Image = Bloxi_tamogotchi.Properties.Resources._1;
            }
            else if (madness == 2)
            {
                pictBox.Image = Bloxi_tamogotchi.Properties.Resources._2;
            }
            else if (madness == 3)
            {
                pictBox.Image = Bloxi_tamogotchi.Properties.Resources._3;
            }
            else if (madness == 4)
            {
                pictBox.Image = Bloxi_tamogotchi.Properties.Resources._4;
            }
            else if (madness == 0)
            {
                pictBox.Image = Bloxi_tamogotchi.Properties.Resources._0;
            }
            else
            {
                Random rnd = new Random();
                int did = rnd.Next(0, 50);
                if (did == 0)
                {
                    pictBox.Image = Bloxi_tamogotchi.Properties.Resources._0;
                }
                else if (did == 1)
                {
                    pictBox.Image = Bloxi_tamogotchi.Properties.Resources._1;
                }
                else if (did == 2)
                {
                    pictBox.Image = Bloxi_tamogotchi.Properties.Resources._2;
                }
                else if (did == 3)
                {
                    pictBox.Image = Bloxi_tamogotchi.Properties.Resources._3;
                }
                else if (did == 4)
                {
                    pictBox.Image = Bloxi_tamogotchi.Properties.Resources._4;
                }
                else if (did == 5)
                {
                    pictBox.Image = Bloxi_tamogotchi.Properties.Resources.calm;
                }
                else if (did == 6)
                {
                    pictBox.Image = Bloxi_tamogotchi.Properties.Resources.cool;
                }
                else if (did == 7)
                {
                    pictBox.Image = Bloxi_tamogotchi.Properties.Resources.evade;
                }
                else if (did == 8)
                {
                    pictBox.Image = Bloxi_tamogotchi.Properties.Resources.foresinght;
                }
                else if (did == 9)
                {
                    pictBox.Image = Bloxi_tamogotchi.Properties.Resources.insult;
                }
                else if (did == 10)
                {
                    pictBox.Image = Bloxi_tamogotchi.Properties.Resources.offended;
                }
                else if (did == 6)
                {
                    pictBox.Image = Bloxi_tamogotchi.Properties.Resources.puke;
                }
                else if (did == 11)
                {
                    pictBox.Image = Bloxi_tamogotchi.Properties.Resources.questioner;
                }
                else if (did == 12)
                {
                    pictBox.Image = Bloxi_tamogotchi.Properties.Resources.radid;
                }
                else if (did == 13)
                {
                    pictBox.Image = Bloxi_tamogotchi.Properties.Resources.restrain;
                }
                else if (did == 14)
                {
                    pictBox.Image = Bloxi_tamogotchi.Properties.Resources.smil;
                }
                else if (did == 15)
                {
                    pictBox.Image = Bloxi_tamogotchi.Properties.Resources.tansed;
                }
                else if (did > 15)
                {
                    pictBox.Image = Bloxi_tamogotchi.Properties.Resources._0;
                }
                else
                {
                    pictBox.Image = Bloxi_tamogotchi.Properties.Resources.error;
                }
            }
        }


        public static void foodfalse(int madness, Label l2, Label l3, PictureBox p1, PictureBox p2, Button b1, Button b2, Button b3, Button b4, Button b5, Button b6, Button b7, Button b8, Button b9, Button b10, Button b11, TextBox tb)
        {
            kd(l2);
            l3.Visible = false;
            l2.Visible = true;

            b1.Visible = true;
            b2.Visible = true;
            b3.Visible = true;
            b4.Visible = true;
            b5.Visible = true;
            b6.Visible = true;

            b7.Visible = false;
            b8.Visible = false;
            b9.Visible = false;
            b10.Visible = false;
            b11.Visible = false;

            tb.Visible = false;

            mad(madness, p2);
            p1.Visible = true;
            p2.Visible = false;
        }

        private async void label2_Click(object sender, EventArgs e)
        {
            label2.Text = ("ЭТО НЕ КНОПКА!!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            madness = madness + 1;
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.tansed;
            using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.ne_trogay_menya))
            {
                new SoundPlayer(stream).Play();
            }
            MessageBox.Show("не трогай меня....");
            mady(madness);
            madlab(madness, label1);
            mad(madness, pictureBox1);

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "ударить";
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.tansed;
 
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            kd(label2);
            mad(madness, pictureBox1);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Random randit = new Random();
            int rano = randit.Next(1, 6);

            if(rano == 1)
            {
                using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.hit))
                {
                    SoundPlayer player = new SoundPlayer(stream);
                    player.Play();
                }
            }
            else if (rano == 2)
            {
                using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.hit1))
                {
                    new SoundPlayer(stream).Play();
                }
            }
            else if (rano == 3)
            {
                using(MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.hit2))
                {
                    new SoundPlayer (stream).Play();
                }
            }
            else if (rano == 4)
            {
                using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.hit3))
                {
                    new SoundPlayer(stream).Play();
                }
            }
            else
            {
                using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.hit4))
                {
                    new SoundPlayer(stream).Play();
                }
            }


            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.evade;   
            await Task.Delay(100);
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources._2;
            madness += 1;
            mady(madness);
            madlab(madness, label1);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.restrain;
        }

        private void button1_DoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources._4;

        }

        private async void button4_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "погладить";
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.cool;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            mad(madness, pictureBox1);
            kd(label2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using(MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.comfort))
            {
                new SoundPlayer(stream).Play();
            }

            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.calm;
            madness -= 1;
            mady(madness);
            madlab(madness, label1);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.NOO_VSE_YA_OBIDELSYA))
            {
                new SoundPlayer(stream).Play();
            }

            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.foresinght;
            MessageBox.Show("Ну все я обиделся....");
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.smil;
            using(MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.ti_loh))
            {
                new SoundPlayer(stream).Play();
            }
            MessageBox.Show("ТЫ ЛОХ)))))).....");
            this.Close();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "оскорбить";
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.offended;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.questioner;
            using(MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.ne_nado_menya_oskorblyat))
            {
                new SoundPlayer(stream).Play();
            }
            MessageBox.Show("не надо меня оскорблять..");
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.questioner;
            using(MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.oKEy))
            {
                new SoundPlayer(stream).Play();
            }
            MessageBox.Show("OK???????");
            mad(madness, pictureBox1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.BAM))
            {
                new SoundPlayer(stream).Play();
            }
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.questioner;
            MessageBox.Show("ЭТО ПРАВДА???..");
            using (MemoryStream strem = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.eto_pravda_ili_net))
            {
                new SoundPlayer(strem).Play();
            }
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.insult;
            MessageBox.Show("или нет???..");
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.calm;
            using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.noo_ladno_spasibo))
            {
                new SoundPlayer(stream).Play(); 
            }
            MessageBox.Show("ну ладно спасибо..");
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.smil;
            madness -= 10;
            mady(madness);
            madlab(madness, label1);

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "KILL";
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources._3;

        }

        private async void button3_MouseHover(object sender, EventArgs e)
        {
            await Task.Delay(500);
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources._4;
            using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.nakonec_to))
            {
                new SoundPlayer(stream).Play();
            }
            MessageBox.Show("наконец-то");
            this.Close();
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            kd(label2);
            mad(madness, pictureBox1);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randy = rnd.Next(0, 2);
            if (randy == 0)
            {
                pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.radid;
                this.Close();
            }
            else
            {
                pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.radid;
                await Task.Delay(500);
                madness = 0;
                madlab(madness, label1);
                using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.chtosh_ya_ubil_cogo_ti_hotel))
                {
                    new SoundPlayer(stream).Play();
                }
                MessageBox.Show("чтож я убил, кого ты хотел.");
                pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.smil;
            }

        }

        private async void button6_Click(object sender, EventArgs e)
        {
            kd2(label3);
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;

            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.questioner;

            label2.Visible = false;
            label3.Visible = true;

            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = ("это не кнопка..");
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            kd(label2);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "курсор рядом с Блокси";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            kd(label2);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            kd(label2);
            mad(madness, pictureBox1);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "похвалить";
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            kd(label2);
            mad(madness, pictureBox1);
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "покормить";
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            kd(label2);
            mad(madness, pictureBox1);
        }

        private async void pictureBox2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rand = rnd.Next(0, 20);
            int oper = rnd.Next(0, 2);
            string says;
            Image imsays;
            if (oper == 0)
            {
                madness -= rand;
            }
            else
            {
                madness += rand;
            }
            if (rand >= 0 && rand <= 5)
            {
                says = "ММММММ я такой ВКУСНЫЙ))))))";
                imsays = Bloxi_tamogotchi.Properties.Resources.restrain;
                using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.MMMMMMM_YA_TOKOY_VKUSNEEY))
                {
                    new SoundPlayer(stream).Play();
                }
            }
            else if (rand > 5 && rand <= 10)
            {
                says = "Я не такой.... такой.... ЗАЧЕМ ты меня заставил есть себя??";
                imsays = Bloxi_tamogotchi.Properties.Resources.calm;
                using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.ya_ne_takoy_takoy_zhem_ti_zastavil_menya_est_sebya))
                {
                    new SoundPlayer(stream).Play();
                }
            }
            else if (rand > 10 && rand <= 15)
            {
                says = "рррр... какой я безвкусный... ужастно чувствую...";
                imsays = Bloxi_tamogotchi.Properties.Resources._2;
                using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.rrrrrrrrrr_kakoy_ya_bezvcusny))
                {
                    new SoundPlayer(stream).Play();
                }
            }
            else if (rand == 16)
            {
                says = "КАКОЙ НЕ ПОНЯТНЫЙ Я...... Я ВРОДЕ УЖАСНЫЙ ИЛИ ИЗУМИТЕЛЬНЫ";
                imsays = Bloxi_tamogotchi.Properties.Resources._2;
                using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.KAKOY_NE_PONYATNIY_YA))
                {
                    new SoundPlayer(stream).Play();
                }
            }
            else
            {
                says = "РРРРФХРФРФХРФФХРХРФХФРАРАФФХАРФАРФАРФАХРРРРРХФРХРФФХРХФРХФРХФРХФРХРФХРФФРХФХРРХФРФХРХФХРФРХФХРФХРФХРФХФРХРФФХР";
                imsays = Bloxi_tamogotchi.Properties.Resources.radid;
                using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.RRRRRRRRRRRRAWEIOGJWAEOIRMSWAJRENGV_ajwegvbweeeeeeeeeeeeeRRRRRRRRRRVHPHPHPH))
                {
                    new SoundPlayer(stream).Play();
                }

            }

            pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.tansed;
            MessageBox.Show(says);
            mady(madness);
            madlab(madness, label1);
            pictureBox1.Image = imsays;
            foodfalse(madness, label2, label3, pictureBox1, pictureBox2, button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, textBox1);
            
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            label3.Text = "блокси";
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            kd2(label3);
            stopX = 0;
            madnessW = 100;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foodfalse(madness, label2, label3, pictureBox1, pictureBox2, button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, textBox1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            madness -= 100;
            madlab(madness, label1);
            pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.foresinght;
            using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.gribi_vkusnye_mne_oni_vsegda_nrav))
            {
                new SoundPlayer(stream).Play();
            }
            MessageBox.Show("грибы вкусные, мне они мне всегда нравится, спасибо.");
            mad(madness, pictureBox1);
            foodfalse(madness, label2, label3, pictureBox1, pictureBox2, button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, textBox1);

        }

        private async void button9_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            madness += 910593232;
            madlab(madness, label1);
            pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.puke;
            MessageBox.Show("erorr");
            await Task.Delay(100);
            pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.tansed;
            MessageBox.Show("");
            pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.calm;
            await Task.Delay(3000);
            pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.tansed;
            await Task.Delay(500);
            pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources._2;
            await Task.Delay(100);
            pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.puke;
            await Task.Delay(1000);
            pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources._2;
            await Task.Delay(500);
            pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.smil;
            Thread.Sleep(10000);
            pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.error;
            Thread.Sleep(3000);
            pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources._2;
            using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.ya_mogu_tebya_ubit))
            {
                new SoundPlayer(stream).Play();
            }
            MessageBox.Show("Я МОГУ ТЕБЯ УБИТЬ???....");
            Thread.Sleep(100);
            this.Close();

        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            label3.Text = "грибами";
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            kd2(label3);
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            label3.Text = "не чем";
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            label3.Text = "плотью";
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            kd2(label3);
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            kd2(label3);
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            label3.Text = "чем-то";
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            kd2(label3);
        }

        private async void label3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.tansed;
            madness -= 2;
            label3.Text = "НЕ НЕ НАДО МЕНЯ ЕСТЬ";
            await Task.Delay(500);
            pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.calm;
            label3.Visible = false;
            this.Controls.Remove(label3);
            this.Controls.Remove(label2);
            using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.Takoe_sebe_konecho))
            {
                new SoundPlayer(stream).Play();
            }
            MessageBox.Show("такое себе конечно");
            foodfalse(madness, label2, label3, pictureBox1, pictureBox2, button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, textBox1);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;

            button11.Visible = true;
            textBox1.Visible = true;
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            string food = textBox1.Text;
            label3.Text = food;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            kd2(label3);
        }
        int debil = 0;

        private async void button11_Click(object sender, EventArgs e)
        {
            string food = textBox1.Text;
            Random rnd = new Random();
            int rand = rnd.Next(0, 21);
            if (food == "")
            {
                if (debil >= 20 && debil <25)
                {
                    pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.tansed;
                    debil += 1;
                }
                else if (debil >= 25)
                {

                    pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.foresinght;
                    this.Close();
                }
                else
                {
                    pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.cool;
                    debil += 1;
                }
            }
            else if(food == "грибами" || food == "ГРИБАМИ" || food == "грибочками" || food == "ГРИБОЧКАМИ" || food == "грибы" || food == "ГРИБЫ")
            {
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.calm;
                using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.eto_cshe_vseo_ravno_gribi))
                {
                    new SoundPlayer(stream).Play();
                }
                MessageBox.Show(food + " это же все равно грибы..");
                madness -= 100;
                madlab(madness, label1);
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.foresinght;
                using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.gribi_vkusnye_mne_oni_vsegda_nrav))
                {
                    new SoundPlayer(stream).Play();
                }
                MessageBox.Show("грибы вкусные, мне они мне всегда нравится, спасибо.");
                mad(madness, pictureBox1);
                foodfalse(madness, label2, label3, pictureBox1, pictureBox2, button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, textBox1);
            }
            else if (food == "плотью" || food == "ПЛОТЬЮ" || food == "мясом" || food == "МЯСОМ" || food == "плоть" || food == "ПЛОТЬ" || food == "мясо" || food == "МЯСО")
            {
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources._2;
                using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.ti_chto_geniy))
                {
                    new SoundPlayer(stream).Play();
                }
                MessageBox.Show("ТЫ ЧТО ГЕНИЙ МЕНЯ " + food + " КОРМИТЬ ЧЕРЕЗ ТЕКСТ?");
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                madness += 910593232;
                madlab(madness, label1);
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.puke;
                MessageBox.Show("erorr");
                await Task.Delay(100);
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.tansed;
                MessageBox.Show("");
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.calm;
                await Task.Delay(3000);
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.tansed;
                await Task.Delay(500);
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources._2;
                await Task.Delay(100);
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.puke;
                await Task.Delay(1000);
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources._2;
                await Task.Delay(500);
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.smil;
                Thread.Sleep(10000);
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.error;
                Thread.Sleep(3000);
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources._2;
                using(MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.ya_mogu_tebya_ubit))
                {
                    new SoundPlayer(stream).Play();
                }
                MessageBox.Show("Я МОГУ ТЕБЯ УБИТЬ???....");
                Thread.Sleep(100);
                this.Close();
            }
            else if (food == "не чем" || food == "НЕ ЧЕМ" || food == "нечем" || food == "НЕЧЕМ" || food == "ничем" || food == "НИЧЕМ" || food == "ни чем" || food == "НИ ЧЕМ")
            {
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources._0;
                Thread.Sleep(2000);
                using(MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.iiiirrrri_kakoy_ti_serezney))
                {
                    new SoundPlayer(stream).Play();
                }
                MessageBox.Show("ррр какой ты серьезный....");
                foodfalse(madness, label2, label3, pictureBox1, pictureBox2, button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, textBox1);
            }
            else if (food == "ЕДОЙ")
            {
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.insult;
                using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.ne_original))
                {
                    new SoundPlayer(stream).Play();
                }
                MessageBox.Show("НЕ  О Р И Г И Н А Л Ь Н О");
                textBox1.Text = "если что пиши здесь";
            }
            else if (food == "едой")
            {
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.calm;
                using (MemoryStream stre = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.ne_dumayou_chto_eto_original))
                {
                    new SoundPlayer(stre).Play();
                }
                MessageBox.Show(".....не думаю что это оригинально.");
            }
            else if (food == "если что пиши здесь")
            {
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.tansed;
                textBox1.Text = "Тебе смешно? А МНЕ НЕТ.";
                label3.Text = "НАПИШИ УЖЕ ЧТО-НИБУТЬ";
            }
            else if (food == "Тебе смешно? А МНЕ НЕТ.")
            {
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources._2;
                textBox1.Text = "РРрарГРАdsghjiFHIUfhfHUIFHifhlkы";
                label3.Text = "ну емае";
            }
            else if (food == "РРрарГРАdsghjiFHIUfhfHUIFHifhlkы")
            {
                label3.Visible = false;
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources._3;
                using(MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.ya_budu_rad_sdelat_eto))
                {
                    new SoundPlayer(stream).Play();
                }
                MessageBox.Show("я буду рад сделать это...");
                this.Close();
            }
            else if (food == "foxi boxi" || food == "foxi boxi?" || food == "FOXI BOXI" || food == "FOXI BOXI?")
            {
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.foresinght;
                MessageBox.Show("во первых...");
                MessageBox.Show("ДАА Я ЗНАЮ, что я жалкая породия на Фокси Бокси с другим названием.");
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.insult;
                MessageBox.Show("во вторых...");
                pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.calm;
                MessageBox.Show("они не вкусные");
                Random rund = new Random();
                int raand = rund.Next(0, 20);
                int oper = rund.Next(0, 2);
                if (oper == 0)
                {
                    madness -= raand;
                }
                else
                {
                    madness += raand;
                }
                mady(madness);
                madlab(madness, label1);
                foodfalse(madness, label2, label3, pictureBox1, pictureBox2, button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, textBox1);

            }
            else
            {
                Random foood = new Random();
                int rnd1 = foood.Next(1, 51);
                if (rand == 1 || rand == 0)
                {
                    pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.smil;
                    using (MemoryStream stream = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.mNE_PONRAVILOS_ETO))
                    {
                        new SoundPlayer(stream).Play();
                    }
                    MessageBox.Show("МНЕ ПОНРАВИЛОСЬ " + food +"!");
                    madness -= 50;
                    mady(madness);
                    madlab(madness, label1);
                    foodfalse(madness, label2, label3, pictureBox1, pictureBox2, button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, textBox1);
                }
                else
                {
                    Random jo = new Random();
                    int oper = jo.Next(0,2);
                    if (oper == 0)
                    {
                        madness += rand;
                    }
                    else
                    {
                        madness -= rand;
                    }
                    if (rnd1 == 1)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v1))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Я не могу съесть это, я уже сыт");
                    }
                    else if (rnd1 == 2)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v2))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Если ВСЕ - это грибы, то я готов съесть все, что угодно");
                    }
                    else if (rnd1 == 3)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v3))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("О, это звучит аппетитно, но я не ем такое");
                    }
                    else if (rnd1 == 4)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v4))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Это слишком сладко, я предпочитаю есть грибы");
                    }
                    else if (rnd1 == 5)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v5))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Мне нужно что-то более питательное, например грибы");
                    }
                    else if (rnd1 == 6)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v6))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Я могу есть все, что хочу, но только в меру");
                    }
                    else if (rnd1 == 7)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v7))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Я люблю экспериментировать с новыми вкусами");
                    }
                    else if (rnd1 == 8)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v8))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("давайте попробуем грибы");
                    }
                    else if (rnd1 == 9)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v9))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Я предпочитаю готовить сам, а не есть то, что мне дают");
                    }
                    else if (rnd1 == 10 || rnd1 == 11)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v10))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Я мог бы съесть это, но у меня есть более важные дела, например: убить... ");
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v11))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("ой то есть выж.. ладно если хочешь накормить меня то можешь накормить меня грибами");
                    }

                    
                    else if (rnd1 == 12 || rnd1 == 13)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v12))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Я знаю, что это вредно для моего здоровья,");
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v13))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("но иногда можно сделать исключение");
                    }
                    
                    else if (rnd1 == 14)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v14))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Фуууу невкусно.. ");
                    }
                    else if (rnd1 == 15)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v15))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Я НЕ ЕМ СЛАДКОЕ, я предпочитаю есть грибы.");
                    }
                    else if (rnd1 == 16)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v16))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Я вегетарианец, я такое не ем.");
                    }
                    else if (rnd1 == 17)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v17))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Мммм здоровый образ жизни... котороuj нет....");
                    }
                    else if (rnd1 == 18)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v18))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Ну что вы, я вообще-то очень вкусно готовлю, давайте я вас накормлю, я захватил с собой, я сожарил паука,  и сделал грибной суп с лягушками, поверь тебе понравится.\r\n");
                    }
                    else if (rnd1 == 19)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v19))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("я заинтересован, но есть это не буду.");
                    }
                    else if (rnd1 == 20)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v20))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Это похоже на алкоголь... тут даже спор от грибов нет... Я не употребляю спиртное.");
                    }
                    else if (rnd1 == 21)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v21))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("ОНО противоречит вашим моральным принципам,.... Умри...");
                    }
                    else if (rnd1 == 22)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v22))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Поверь я не голоден, я в полне могу сам себе приготовить, если на то будут причины.");
                    }
                    else if (rnd1 == 23)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v23))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Как насчет того, чтобы я съел это позже?");
                    }
                    else if (rnd1 == 24)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v24))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Конечно, я съем это, но для начало мне нужно убить тебя.\r\n");
                    }
                    else if (rnd1 == 25)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v25))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Ну, я не знаю... Я не очень голоден, но если ты настаиваешь, то я могу попробовать.... ");
                    }
                    else if (rnd1 == 26)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v26))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Не знаю, смогу ли я съесть это. Я всегда стараюсь питаться правильно и следить за своим здоровьем. (нет)");
                    }
                    else if (rnd1 == 27)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v27))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Спасибо, но я уже сыт.");
                    }
                    else if (rnd1 == 28)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v28))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Спешу тебя разочеровать, мне не нужна еда.");
                    }
                    else if (rnd1 == 29)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v29))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Не нужно меня кормить.");
                    }
                    else if (rnd1 == 30)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v30))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("я не нуждаюсь в пище.");
                    }
                    else if (rnd1 == 31)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v31))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Это очень вкусно! (нет)");
                    }
                    else if (rnd1 == 32)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v32))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Что это? Еда? Я не знаю что такое еда, но я знаю что такое грибы.");
                    }
                    else if (rnd1 == 33)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v33))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Я не могу это съесть.");
                    }
                    else if (rnd1 == 34)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v34))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Это не требуется, я все же сам умею готовить.");
                    }
                    else if (rnd1 == 35)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v35))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Вы думайте что я голоден?");
                    }
                    else if (rnd1 == 36)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v36))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Мне нужно больше времени на переваривание... этого.");
                    }
                    else if (rnd1 == 37)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v37))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Это было очень странно...");
                    }
                    else if (rnd1 == 38)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v38))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Это наверно еда богов. Мне не понравилось.");
                    }
                    else if (rnd1 == 39)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v39))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("ЫЩВЗШШОФЦУШЩПРФЩШЦУКПОФЖДЦКОПФШЩЛЦКАПЩШЖЛФОКАПЖИЩШФЦГКАПИШЩФЛЦЫКТИШЖЩЛФЦКЩИШЛФЦЫОЬИЖЩШЛФУАЕШИЩОФЦКЩЗРИФЦАШРИЩФЦОКПШЩРФОАШПЩИФКШПГРКФРГШзШЩрашщфрашщфуаружаошщшужпощжушпоулашощшщзашофывщшпофцущшШЩОАфшщыаофшцщупофщцзужфцщзэупоЙЩЗПОвщз*?НЕА ?*Щ№НК*(\"№);)(*№\"?*!(\"?Н*(%!\"№к9864-\"№НК З983нкрЗГ\"№ШРКЕ(З№Г*\"Р№\"Г*РЕНЙНРЕ*Й\")№НШУР№");
                    }
                    else if (rnd1 == 40)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v40))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("?*(№%?*(№\"?;(*\"?;(*\"?%*()№?%)(_!\"?*;()\"!*;_)(\"*;_()!\";(?*№(!%:\"?№(*;:*?\"№:;?**947209847*№(574*(*(?\";)!(\"*;*(!\");?)(*№;*?№\":;)(*!\"№;?*!\":);\"(*!?_!\")(;(!№*(№;90!\"*?;(*\"?;(\"?;)(*\"?!;)ъ");
                    }
                    else if (rnd1 == 41)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v41))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("11010000 10100011 11010000 10010100 11010000 10010000 11010000 10011011 11010000 10011000 100000 11010000 10011100 11010000 10010101 11010000 10011101 11010000 10101111");
                    }
                    else if (rnd1 == 42)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v42))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("z yt levfk xnj nt,t ghtqltncz rjhvbnm vtyz, vyt yt ye;yf tlf xnj,s gbnfnmcz< vyt ye;yf ndjz cvthnm/");
                    }
                    else if (rnd1 == 43)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v43))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("ckfdj ,jue xnj rjulf z yfgflf. buhf pfrhsdftncz\r\n");
                    }
                    else if (rnd1 == 44)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v44))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Это? Что такое Это? Я СВОСЕМ НЕ ЗНАЮ ЭТОГО.");
                    }
                    else if (rnd1 == 45)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v45))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("это то, что вы едите, чтобы жить? А. зачем вы это едите если я могу....");
                    }
                    else if (rnd1 == 46)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v46))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Без еды ты не выжевешь, лучше сам съешь, чем отдавать это тому который не внуждается в еде.");
                    }
                    else if (rnd1 == 47)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v47))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Тогда почему ты не можешь это съесть?");
                    }
                    else if (rnd1 == 48)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v48))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Я предпочту съесть твои зубы.");
                    }
                    else if (rnd1 == 49)
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v49))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("интересно, как мне теперь тебя олагадрить. Я могу наградить тебя быстрой готовкой еды.");
                    }
                    else
                    {
                        using (MemoryStream a = new MemoryStream(Bloxi_tamogotchi.Properties.Resources.v50))
                        {
                            new SoundPlayer(a).Play();
                        }
                        MessageBox.Show("Это что Японское блюдО? Я ТАКОЕ ТОЖЕ КОГДА-ТО 7385623 ЛЕТ НАЗАД ГОТОВИЛ.");
                    }
                    pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.calm;
                    mady(madness);
                    madlab(madness, label1);
                    foodfalse(madness, label2, label3, pictureBox1, pictureBox2, button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, textBox1);
                }
                MessageBox.Show("вы распорядились " + food);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button11_Click(sender, e);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Point lustpoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources._2;
                this.Left += e.X - lustpoint.X;
                this.Top += e.Y - lustpoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.tansed;
            lustpoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources._1;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.calm;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            mad(madness, pictureBox1);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Bloxi_tamogotchi.Properties.Resources.X;
            pictureBox1.Image = Bloxi_tamogotchi.Properties.Resources.smil;
            pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources._3;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Bloxi_tamogotchi.Properties.Resources.X1;
            pictureBox2.Image = Bloxi_tamogotchi.Properties.Resources.questioner;
            mad(madness, pictureBox1);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Bloxi_tamogotchi.Properties.Resources.X2;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            stopX = 1;
            expact(madnessW, stopX, pictureBox1, pictureBox2);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            stopX = 1;
            expact(madnessW, stopX, pictureBox1, pictureBox2);
        }
    }
}
