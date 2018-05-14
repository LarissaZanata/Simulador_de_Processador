using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Processador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void CarregaRegistradores()
        {
            ir_i.Text = ir_s.Text;
            mar_i.Text = mar_s.Text;
            mbr_i.Text = mbr_s.Text;
            a_i.Text = a_s.Text;
            b_i.Text = b_s.Text;
            m1_i.Text = m1_s.Text;
            m2_i.Text = m2_s.Text;
            d1_i.Text = d1_s.Text;
            d2_i.Text = d2_s.Text;
            r_i.Text = r_s.Text;
            c_i.Text = c_s.Text;
            z_i.Text = z_s.Text;
        }

        public void memoriaFinal()
        {
            i0x00.Text = a0x00.Text;
            i0x01.Text = a0x01.Text;
            i0x02.Text = a0x02.Text;
            i0x03.Text = a0x03.Text;
            i0x04.Text = a0x04.Text;
            i0x05.Text = a0x05.Text;
            i0x06.Text = a0x06.Text;
            i0x07.Text = a0x07.Text;
            i0x08.Text = a0x08.Text;
            i0x09.Text = a0x09.Text;
            i0x0a.Text = a0x0a.Text;
            i0x0b.Text = a0x0b.Text;
            i0x0c.Text = a0x0c.Text;
            i0x0d.Text = a0x0d.Text;
            i0x0e.Text = a0x0e.Text;
            i0x0f.Text = a0x0f.Text;
        }

        public void cicloDeBusca()
        {
            mar_s.Text = pc_i.Text;
            mbr_s.Text = a0x04.Text;
            int pc_fim = Convert.ToInt32(pc_s.Text);
            pc_fim = pc_fim + 1;
            pc_s.Text = pc_fim.ToString();
            ir_s.Text = mbr_i.Text;
        }
        public void ADD()
        {
           //ADD A, 0X04;
            mar_s.Text = ir_s.Text;
            mbr_s.Text = a0x04.Text;
            int aa_i = Convert.ToInt32(a_i.Text);
            int mmbr_s = Convert.ToInt32(mbr_s.Text);
            int soma = aa_i + mmbr_s;
            a_s.Text = Convert.ToString(soma);
            int irConverte = Convert.ToInt32(pc_s.Text) + 1;
            ir_s.Text = Convert.ToString(irConverte);
        }

        public void SUB()
        {
            //SUB A, 0X07;
            mar_s.Text = ir_s.Text;
            mbr_s.Text = a0x07.Text;
            int aa_i = Convert.ToInt32(a_i.Text);
            int mmbr_s = Convert.ToInt32(mbr_s.Text);
            int sub = aa_i - mmbr_s;
            a_s.Text = Convert.ToString(sub);
            int irConverte = Convert.ToInt32(pc_s.Text) + 1;
            ir_s.Text = Convert.ToString(irConverte);
        }

        public void MUL()
        {
            // MUL A, 0x0b;
            mar_s.Text = ir_s.Text;
            mbr_s.Text = a0x0b.Text;
            m1_s.Text = a_i.Text;
            m2_s.Text = mbr_s.Text;
            int aa_i = Convert.ToInt32(a_i.Text);
            int mmbr_s = Convert.ToInt32(mbr_s.Text);
            int mul = aa_i * mmbr_s;
            z_s.Text = Convert.ToString(mul);
            int irConvete = Convert.ToInt32(pc_s.Text) + 1;
            ir_s.Text = Convert.ToString(irConvete);
        }

        public void DIV()
        {
            //DIV A, 0X0a
            mar_s.Text = ir_s.Text;
            mbr_s.Text = a0x0a.Text;
            d1_s.Text = a_i.Text;
            d2_s.Text = mbr_s.Text;
            int aa_i = Convert.ToInt32(a_i.Text);
            int mmbr_s = Convert.ToInt32(mbr_s.Text);
            int div = aa_i / mmbr_s;
            z_s.Text = Convert.ToString(div);
            int irConverte = Convert.ToInt32(pc_s.Text) + 1;
            ir_s.Text = Convert.ToString(irConverte);
        }

        public void incrementaPcInicial()
        {
            int pcInicialIncrementa = Convert.ToInt32(pc_i.Text);
            pcInicialIncrementa = pcInicialIncrementa + 1;
            pc_i.Text = pcInicialIncrementa.ToString();
        }

        public void contagemIR()
        {
            
        }

        private void btnExecuta_Click(object sender, EventArgs e)
        {

            int opcao = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Informe a opção de instrução para ser executada pelo Processador: 1-ADD | 2-SUB | 3-MUL | 4-DIV | ", "Escolha de instrução", "1"));
            
            switch(opcao)
            {
                case 1:
                    CarregaRegistradores();
                    cicloDeBusca();
                    ADD();
                    memoriaFinal();
                    break;

                case 2:
                    CarregaRegistradores();
                    cicloDeBusca();
                    SUB();
                    memoriaFinal();
                    break;

                case 3:
                    CarregaRegistradores();
                    cicloDeBusca();
                    MUL();
                    memoriaFinal();
                    break;
                case 4:
                    CarregaRegistradores();
                    cicloDeBusca();
                    DIV();
                    memoriaFinal();
                    break;
            }
            
            if(Convert.ToUInt32(pc_s.Text) > 1)
            {
                incrementaPcInicial();
            }

            
        }
        
    }
}
