using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AGDEditor
{
    struct AGDItem
    {
        public int Level;
        public int ExpToNext;
        public int RequiredExp;
        public int AttributePoints;
    }

    public partial class Form1 : Form
    {

        AGDItem[] LEVELS;
        string FileName;
        bool lockit = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Filter = "Xenoverse agd (*.agd)|*.agd";
            browseFile.Title = "Browse for Leveling File (agd file)";
            if (browseFile.ShowDialog() == DialogResult.Cancel)
                return;

            byte[] file = File.ReadAllBytes(browseFile.FileName);
            FileName = browseFile.FileName;

            LEVELS = new AGDItem[BitConverter.ToInt32(file,8)];
            cbLevels.Items.Clear();
            for (int i = 0; i < LEVELS.Length; i++)
            {
                LEVELS[i].Level = BitConverter.ToInt32(file, 16 + (i * 16));
                LEVELS[i].ExpToNext = BitConverter.ToInt32(file, 16 + (i * 16) + 4);
                LEVELS[i].RequiredExp = BitConverter.ToInt32(file, 16 + (i * 16) + 8);
                LEVELS[i].AttributePoints = BitConverter.ToInt32(file, 16 + (i * 16) + 12);

                
            }

            LowerD.Minimum = 1;
            LowerD.Maximum = LEVELS.Length;
            LowerD.Value = 1;
            UpperD.Minimum = 1;
            UpperD.Maximum = LEVELS.Length;
            UpperD.Value = LEVELS.Length;


            UpdateList();
            UpdateChart();

        }

        void UpdateList()
        {
            for (int i = 0; i < LEVELS.Length; i++)
            {
                cbLevels.Items.Add(LEVELS[i].Level);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if negative
            for (int i = 0; i < LEVELS.Length; i++)
            {
                if (LEVELS[i].ExpToNext < 0)
                    return;
            }

                List<byte> filebyte = new List<byte>();
            filebyte.AddRange(new byte[] { 0x23, 0x41, 0x47, 0x44, 0xFE, 0xFF, 0x10, 0x00 });
            filebyte.AddRange(BitConverter.GetBytes(LEVELS.Length));
            filebyte.AddRange(BitConverter.GetBytes(16));

            for (int i = 0; i < LEVELS.Length; i++)
            {
                filebyte.AddRange(BitConverter.GetBytes(LEVELS[i].Level));
                filebyte.AddRange(BitConverter.GetBytes(LEVELS[i].ExpToNext));
                filebyte.AddRange(BitConverter.GetBytes(LEVELS[i].RequiredExp));
                filebyte.AddRange(BitConverter.GetBytes(LEVELS[i].AttributePoints));
            }

            FileStream file = new FileStream(FileName, FileMode.Create);
            file.Write(filebyte.ToArray(),0,filebyte.Count);
            file.Close();
        }

        private void cbLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            lockit = true;
            txtToNext.Text = LEVELS[cbLevels.SelectedIndex].ExpToNext.ToString();
            txtRequired.Text = LEVELS[cbLevels.SelectedIndex].RequiredExp.ToString();
            txtAttributes.Text = LEVELS[cbLevels.SelectedIndex].AttributePoints.ToString();
            lockit = false;
        }

        private void txtToNext_TextChanged(object sender, EventArgs e)
        {
            if (!lockit)
            {
                int num;
                if (int.TryParse(txtToNext.Text, out num))
                {
                    LEVELS[cbLevels.SelectedIndex].ExpToNext = num;
                    if (cbLevels.SelectedIndex != cbLevels.Items.Count - 1)
                    {
                        LEVELS[cbLevels.SelectedIndex + 1].RequiredExp = LEVELS[cbLevels.SelectedIndex].RequiredExp + LEVELS[cbLevels.SelectedIndex].ExpToNext;
                        if (cbLevels.SelectedIndex != cbLevels.Items.Count - 2)
                            LEVELS[cbLevels.SelectedIndex + 1].ExpToNext = LEVELS[cbLevels.SelectedIndex + 2].RequiredExp - LEVELS[cbLevels.SelectedIndex + 1].RequiredExp;
                    }
                }

                UpdateChart();
            }
        }

        private void txtRequired_TextChanged(object sender, EventArgs e)
        {
            if (!lockit)
            {
                int num;
                if (int.TryParse(txtRequired.Text, out num))
                {
                    LEVELS[cbLevels.SelectedIndex].RequiredExp = num;
                    if (cbLevels.SelectedIndex != cbLevels.Items.Count - 1)
                    {
                        LEVELS[cbLevels.SelectedIndex].ExpToNext = (LEVELS[cbLevels.SelectedIndex + 1].RequiredExp - LEVELS[cbLevels.SelectedIndex].RequiredExp);
                        txtToNext.Text = LEVELS[cbLevels.SelectedIndex].ExpToNext.ToString();
                    }
                }

                UpdateChart();
            }
        }

        private void txtAttributes_TextChanged(object sender, EventArgs e)
        {
            if (!lockit)
            {
                int num;
                if (int.TryParse(txtAttributes.Text, out num))
                    LEVELS[cbLevels.SelectedIndex].AttributePoints = num;
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        void UpdateChart()
        {
            chtLevel.Series[0].Points.Clear();
            for (int i = 0; i <LEVELS.Length; i++)
                chtLevel.Series[0].Points.AddXY(LEVELS[i].Level,LEVELS[i].RequiredExp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //set all to level - 1
            if (rdBtnNext.Checked)
            {
                for (int i = (int)LowerD.Value - 1; i < (int)UpperD.Value - 1; i++)
                {
                    LEVELS[i].ExpToNext = LEVELS[i].Level;

                    LEVELS[i + 1].RequiredExp = LEVELS[i].RequiredExp + LEVELS[i].ExpToNext;
                }
            }
            else
            {
                for (int i = (int)LowerD.Value - 1; i < (int)UpperD.Value; i++)
                {
                    LEVELS[i].RequiredExp = LEVELS[i].Level - 1;

                    if (i != LEVELS.Length - 1)
                        LEVELS[i].ExpToNext = LEVELS[i + 1].RequiredExp - LEVELS[i].RequiredExp;
                }
            }
            UpdateChart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //multiply all
            int x;
            if (!int.TryParse(txtX.Text, out x))
                return;

            if (rdBtnNext.Checked)
            {
                for (int i = (int)LowerD.Value - 1; i < (int)UpperD.Value - 1; i++)
                {
                    LEVELS[i].ExpToNext *=  x;

                    LEVELS[i + 1].RequiredExp = LEVELS[i].RequiredExp + LEVELS[i].ExpToNext;
                }
            }
            else
            {
                for (int i = (int)LowerD.Value - 1; i < (int)UpperD.Value; i++)
                {
                    LEVELS[i].RequiredExp *= x;

                    if (i != LEVELS.Length - 1)
                        LEVELS[i].ExpToNext = LEVELS[i + 1].RequiredExp - LEVELS[i].RequiredExp;
                }
            }
            UpdateChart();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //square all
           

            if (rdBtnNext.Checked)
            {
                for (int i = (int)LowerD.Value - 1; i < (int)UpperD.Value - 1; i++)
                {
                    LEVELS[i].ExpToNext *= LEVELS[i].ExpToNext;

                    LEVELS[i + 1].RequiredExp = LEVELS[i].RequiredExp + LEVELS[i].ExpToNext;
                }
            }
            else
            {
                for (int i = (int)LowerD.Value - 1; i < (int)UpperD.Value; i++)
                {
                    LEVELS[i].RequiredExp *= LEVELS[i].RequiredExp;

                    if (i != LEVELS.Length - 1)
                        LEVELS[i].ExpToNext = LEVELS[i + 1].RequiredExp - LEVELS[i].RequiredExp;
                }
            }
            UpdateChart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //divide all
            int x;
            if (!int.TryParse(txtX.Text, out x))
                return;

            if (rdBtnNext.Checked)
            {
                for (int i = (int)LowerD.Value - 1; i < (int)UpperD.Value - 1; i++)
                {
                    LEVELS[i].ExpToNext /= x;

                    LEVELS[i + 1].RequiredExp = LEVELS[i].RequiredExp + LEVELS[i].ExpToNext;
                }
            }
            else
            {
                for (int i = (int)LowerD.Value - 1; i < (int)UpperD.Value; i++)
                {
                    LEVELS[i].RequiredExp /= x;

                    if (i != LEVELS.Length - 1)
                        LEVELS[i].ExpToNext = LEVELS[i + 1].RequiredExp - LEVELS[i].RequiredExp;
                }
            }
            UpdateChart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //plus all
            int x;
            if (!int.TryParse(txtX.Text, out x))
                return;

            if (rdBtnNext.Checked)
            {
                for (int i = (int)LowerD.Value - 1; i < (int)UpperD.Value - 1; i++)
                {
                    LEVELS[i].ExpToNext += x;

                    LEVELS[i + 1].RequiredExp = LEVELS[i].RequiredExp + LEVELS[i].ExpToNext;
                }
            }
            else
            {
                for (int i = (int)LowerD.Value; i < (int)UpperD.Value; i++)
                {
                    LEVELS[i].RequiredExp += x;

                    if (i != LEVELS.Length - 1)
                        LEVELS[i].ExpToNext = LEVELS[i + 1].RequiredExp - LEVELS[i].RequiredExp;
                }
            }
            UpdateChart();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //minus all
           
            int x;
            if (!int.TryParse(txtX.Text, out x))
                return;

            if (rdBtnNext.Checked)
            {
                for (int i = (int)LowerD.Value - 1; i < (int)UpperD.Value - 1; i++)
                {
                    LEVELS[i].ExpToNext -= x;

                    if (LEVELS[i].ExpToNext < 0)
                        LEVELS[i].ExpToNext = 0;
                    LEVELS[i + 1].RequiredExp = LEVELS[i].RequiredExp + LEVELS[i].ExpToNext;
                }
            }
            else
            {
                for (int i = (int)LowerD.Value; i < (int)UpperD.Value; i++)
                {
                    LEVELS[i].RequiredExp -= x;
                    if (LEVELS[i].RequiredExp < 0)
                        LEVELS[i].RequiredExp = 0;

                    if (i != LEVELS.Length - 1)
                        LEVELS[i].ExpToNext = LEVELS[i + 1].RequiredExp - LEVELS[i].RequiredExp;
                }
            }
            UpdateChart();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //cube all
            if (rdBtnNext.Checked)
            {
                for (int i = (int)LowerD.Value - 1; i < (int)UpperD.Value - 1; i++)
                {
                    LEVELS[i].ExpToNext *= LEVELS[i].ExpToNext * LEVELS[i].ExpToNext;

                    LEVELS[i + 1].RequiredExp = LEVELS[i].RequiredExp + LEVELS[i].ExpToNext;
                }
            }
            else
            {
                for (int i = (int)LowerD.Value - 1; i < (int)UpperD.Value; i++)
                {
                    LEVELS[i].RequiredExp *= LEVELS[i].RequiredExp * LEVELS[i].RequiredExp;

                    if (i != LEVELS.Length - 1)
                        LEVELS[i].ExpToNext = LEVELS[i + 1].RequiredExp - LEVELS[i].RequiredExp;
                }
            }
            UpdateChart();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //set all to 0
            if (rdBtnNext.Checked)
            {
                for (int i = (int)LowerD.Value - 1; i < (int)UpperD.Value - 1; i++)
                {
                    LEVELS[i].ExpToNext = 0;

                    LEVELS[i + 1].RequiredExp = LEVELS[i].RequiredExp + LEVELS[i].ExpToNext;
                }
            }
            else
            {
                for (int i = (int)LowerD.Value - 1; i < (int)UpperD.Value; i++)
                {
                    LEVELS[i].RequiredExp = 0;

                    if (i != LEVELS.Length - 1)
                        LEVELS[i].ExpToNext = LEVELS[i + 1].RequiredExp - LEVELS[i].RequiredExp;
                }
            }
            UpdateChart();
        }
    }
}
