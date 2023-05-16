namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnBlend = new System.Windows.Forms.Button();
            this.btnMed = new System.Windows.Forms.Button();
            this.btnXor = new System.Windows.Forms.Button();
            this.btnAnd = new System.Windows.Forms.Button();
            this.btnNot = new System.Windows.Forms.Button();
            this.btnOr = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LoadImgA = new System.Windows.Forms.Button();
            this.LoadImgB = new System.Windows.Forms.Button();
            this.SalvarImagem = new System.Windows.Forms.Button();
            this.RGBToBit = new System.Windows.Forms.Button();
            this.RGBTo8Bit = new System.Windows.Forms.Button();
            this.Realces = new System.Windows.Forms.Label();
            this.btnRealceMedia = new System.Windows.Forms.Button();
            this.btnRealceMin = new System.Windows.Forms.Button();
            this.btnRealceMax = new System.Windows.Forms.Button();
            this.btnRealceSuavConservativa = new System.Windows.Forms.Button();
            this.btnRealceOrdem = new System.Windows.Forms.Button();
            this.btnRealceMediana = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SDBI = new System.Windows.Forms.Button();
            this.negativo = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.equalizarHistograma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(484, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adição";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(484, 52);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(88, 23);
            this.btnSub.TabIndex = 1;
            this.btnSub.Text = "Subtração";
            this.btnSub.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(484, 81);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(88, 23);
            this.btnMult.TabIndex = 2;
            this.btnMult.Text = "Multiplicação";
            this.btnMult.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(484, 110);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(88, 23);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "Divisão";
            this.btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnBlend
            // 
            this.btnBlend.Location = new System.Drawing.Point(484, 139);
            this.btnBlend.Name = "btnBlend";
            this.btnBlend.Size = new System.Drawing.Size(88, 23);
            this.btnBlend.TabIndex = 4;
            this.btnBlend.Text = "Blending";
            this.btnBlend.UseVisualStyleBackColor = true;
            // 
            // btnMed
            // 
            this.btnMed.Location = new System.Drawing.Point(484, 168);
            this.btnMed.Name = "btnMed";
            this.btnMed.Size = new System.Drawing.Size(88, 23);
            this.btnMed.TabIndex = 5;
            this.btnMed.Text = "Media";
            this.btnMed.UseVisualStyleBackColor = true;
            // 
            // btnXor
            // 
            this.btnXor.Location = new System.Drawing.Point(631, 111);
            this.btnXor.Name = "btnXor";
            this.btnXor.Size = new System.Drawing.Size(53, 23);
            this.btnXor.TabIndex = 6;
            this.btnXor.Text = "XOR";
            this.btnXor.UseVisualStyleBackColor = true;
            // 
            // btnAnd
            // 
            this.btnAnd.Location = new System.Drawing.Point(631, 25);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(53, 23);
            this.btnAnd.TabIndex = 7;
            this.btnAnd.Text = "AND";
            this.btnAnd.UseVisualStyleBackColor = true;
            // 
            // btnNot
            // 
            this.btnNot.Location = new System.Drawing.Point(631, 55);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(53, 23);
            this.btnNot.TabIndex = 8;
            this.btnNot.Text = "NOT";
            this.btnNot.UseVisualStyleBackColor = true;
            // 
            // btnOr
            // 
            this.btnOr.Location = new System.Drawing.Point(631, 84);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(53, 23);
            this.btnOr.TabIndex = 9;
            this.btnOr.Text = "OR";
            this.btnOr.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(574, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(574, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(36, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(574, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(36, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(574, 113);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(36, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(574, 141);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(36, 20);
            this.textBox5.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 207);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(702, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 207);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(270, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(208, 207);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // LoadImgA
            // 
            this.LoadImgA.Location = new System.Drawing.Point(34, 237);
            this.LoadImgA.Name = "LoadImgA";
            this.LoadImgA.Size = new System.Drawing.Size(208, 23);
            this.LoadImgA.TabIndex = 18;
            this.LoadImgA.Text = "Carregar imagem A";
            this.LoadImgA.UseVisualStyleBackColor = true;
            // 
            // LoadImgB
            // 
            this.LoadImgB.Location = new System.Drawing.Point(270, 237);
            this.LoadImgB.Name = "LoadImgB";
            this.LoadImgB.Size = new System.Drawing.Size(208, 23);
            this.LoadImgB.TabIndex = 19;
            this.LoadImgB.Text = "Carregar Imagem B";
            this.LoadImgB.UseVisualStyleBackColor = true;
            // 
            // SalvarImagem
            // 
            this.SalvarImagem.Location = new System.Drawing.Point(702, 237);
            this.SalvarImagem.Name = "SalvarImagem";
            this.SalvarImagem.Size = new System.Drawing.Size(208, 23);
            this.SalvarImagem.TabIndex = 20;
            this.SalvarImagem.Text = "Salvar imagem";
            this.SalvarImagem.UseVisualStyleBackColor = true;
            // 
            // RGBToBit
            // 
            this.RGBToBit.Location = new System.Drawing.Point(34, 284);
            this.RGBToBit.Name = "RGBToBit";
            this.RGBToBit.Size = new System.Drawing.Size(75, 23);
            this.RGBToBit.TabIndex = 21;
            this.RGBToBit.Text = "RGB --> 1bit ";
            this.RGBToBit.UseVisualStyleBackColor = true;
            // 
            // RGBTo8Bit
            // 
            this.RGBTo8Bit.Location = new System.Drawing.Point(34, 313);
            this.RGBTo8Bit.Name = "RGBTo8Bit";
            this.RGBTo8Bit.Size = new System.Drawing.Size(75, 23);
            this.RGBTo8Bit.TabIndex = 22;
            this.RGBTo8Bit.Text = "RGB --> 8bit ";
            this.RGBTo8Bit.UseVisualStyleBackColor = true;
            // 
            // Realces
            // 
            this.Realces.AutoSize = true;
            this.Realces.Location = new System.Drawing.Point(150, 289);
            this.Realces.Name = "Realces";
            this.Realces.Size = new System.Drawing.Size(46, 13);
            this.Realces.TabIndex = 24;
            this.Realces.Text = "Realces";
            // 
            // btnRealceMedia
            // 
            this.btnRealceMedia.Location = new System.Drawing.Point(197, 342);
            this.btnRealceMedia.Name = "btnRealceMedia";
            this.btnRealceMedia.Size = new System.Drawing.Size(75, 23);
            this.btnRealceMedia.TabIndex = 27;
            this.btnRealceMedia.Text = "MÉDIA";
            this.btnRealceMedia.UseVisualStyleBackColor = true;
            // 
            // btnRealceMin
            // 
            this.btnRealceMin.Location = new System.Drawing.Point(197, 313);
            this.btnRealceMin.Name = "btnRealceMin";
            this.btnRealceMin.Size = new System.Drawing.Size(75, 23);
            this.btnRealceMin.TabIndex = 26;
            this.btnRealceMin.Text = "MIN";
            this.btnRealceMin.UseVisualStyleBackColor = true;
            // 
            // btnRealceMax
            // 
            this.btnRealceMax.Location = new System.Drawing.Point(197, 284);
            this.btnRealceMax.Name = "btnRealceMax";
            this.btnRealceMax.Size = new System.Drawing.Size(75, 23);
            this.btnRealceMax.TabIndex = 25;
            this.btnRealceMax.Text = "MÁX";
            this.btnRealceMax.UseVisualStyleBackColor = true;
            // 
            // btnRealceSuavConservativa
            // 
            this.btnRealceSuavConservativa.Location = new System.Drawing.Point(278, 342);
            this.btnRealceSuavConservativa.Name = "btnRealceSuavConservativa";
            this.btnRealceSuavConservativa.Size = new System.Drawing.Size(135, 23);
            this.btnRealceSuavConservativa.TabIndex = 30;
            this.btnRealceSuavConservativa.Text = "SUAV. CONSERVATIVA";
            this.btnRealceSuavConservativa.UseVisualStyleBackColor = true;
            // 
            // btnRealceOrdem
            // 
            this.btnRealceOrdem.Location = new System.Drawing.Point(278, 313);
            this.btnRealceOrdem.Name = "btnRealceOrdem";
            this.btnRealceOrdem.Size = new System.Drawing.Size(75, 23);
            this.btnRealceOrdem.TabIndex = 29;
            this.btnRealceOrdem.Text = "ORDEM";
            this.btnRealceOrdem.UseVisualStyleBackColor = true;
            // 
            // btnRealceMediana
            // 
            this.btnRealceMediana.Location = new System.Drawing.Point(278, 284);
            this.btnRealceMediana.Name = "btnRealceMediana";
            this.btnRealceMediana.Size = new System.Drawing.Size(75, 23);
            this.btnRealceMediana.TabIndex = 28;
            this.btnRealceMediana.Text = "MEDIANA";
            this.btnRealceMediana.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(359, 315);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(54, 20);
            this.textBox6.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Melhorias";
            // 
            // SDBI
            // 
            this.SDBI.Location = new System.Drawing.Point(484, 284);
            this.SDBI.Name = "SDBI";
            this.SDBI.Size = new System.Drawing.Size(212, 23);
            this.SDBI.TabIndex = 33;
            this.SDBI.Text = "Standart Deviation Based Image Stretching";
            this.SDBI.UseVisualStyleBackColor = true;
            // 
            // negativo
            // 
            this.negativo.Location = new System.Drawing.Point(553, 315);
            this.negativo.Name = "negativo";
            this.negativo.Size = new System.Drawing.Size(75, 23);
            this.negativo.TabIndex = 34;
            this.negativo.Text = "Negativo";
            this.negativo.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(34, 403);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(319, 196);
            this.chart1.TabIndex = 35;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(591, 403);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(319, 196);
            this.chart2.TabIndex = 36;
            this.chart2.Text = "chart2";
            // 
            // equalizarHistograma
            // 
            this.equalizarHistograma.Location = new System.Drawing.Point(386, 476);
            this.equalizarHistograma.Name = "equalizarHistograma";
            this.equalizarHistograma.Size = new System.Drawing.Size(186, 23);
            this.equalizarHistograma.TabIndex = 37;
            this.equalizarHistograma.Text = "Equalizar histograma";
            this.equalizarHistograma.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 613);
            this.Controls.Add(this.equalizarHistograma);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.negativo);
            this.Controls.Add(this.SDBI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.btnRealceSuavConservativa);
            this.Controls.Add(this.btnRealceOrdem);
            this.Controls.Add(this.btnRealceMediana);
            this.Controls.Add(this.btnRealceMedia);
            this.Controls.Add(this.btnRealceMin);
            this.Controls.Add(this.btnRealceMax);
            this.Controls.Add(this.Realces);
            this.Controls.Add(this.RGBTo8Bit);
            this.Controls.Add(this.RGBToBit);
            this.Controls.Add(this.SalvarImagem);
            this.Controls.Add(this.LoadImgB);
            this.Controls.Add(this.LoadImgA);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOr);
            this.Controls.Add(this.btnNot);
            this.Controls.Add(this.btnAnd);
            this.Controls.Add(this.btnXor);
            this.Controls.Add(this.btnMed);
            this.Controls.Add(this.btnBlend);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnBlend;
        private System.Windows.Forms.Button btnMed;
        private System.Windows.Forms.Button btnXor;
        private System.Windows.Forms.Button btnAnd;
        private System.Windows.Forms.Button btnNot;
        private System.Windows.Forms.Button btnOr;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button LoadImgA;
        private System.Windows.Forms.Button LoadImgB;
        private System.Windows.Forms.Button SalvarImagem;
        private System.Windows.Forms.Button RGBToBit;
        private System.Windows.Forms.Button RGBTo8Bit;
        private System.Windows.Forms.Label Realces;
        private System.Windows.Forms.Button btnRealceMedia;
        private System.Windows.Forms.Button btnRealceMin;
        private System.Windows.Forms.Button btnRealceMax;
        private System.Windows.Forms.Button btnRealceSuavConservativa;
        private System.Windows.Forms.Button btnRealceOrdem;
        private System.Windows.Forms.Button btnRealceMediana;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SDBI;
        private System.Windows.Forms.Button negativo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button equalizarHistograma;
    }
}

