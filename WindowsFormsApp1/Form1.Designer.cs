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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.txAdd = new System.Windows.Forms.TextBox();
            this.txSub = new System.Windows.Forms.TextBox();
            this.txMult = new System.Windows.Forms.TextBox();
            this.txDiv = new System.Windows.Forms.TextBox();
            this.txBlend = new System.Windows.Forms.TextBox();
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
            this.txOrdem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SDBI = new System.Windows.Forms.Button();
            this.negativo = new System.Windows.Forms.Button();
            this.histDefault = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.histNormalizado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.equalizarHistograma = new System.Windows.Forms.Button();
            this.btnToDouble = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histNormalizado)).BeginInit();
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(484, 52);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(88, 23);
            this.btnSub.TabIndex = 1;
            this.btnSub.Text = "Subtração";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(484, 81);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(88, 23);
            this.btnMult.TabIndex = 2;
            this.btnMult.Text = "Multiplicação";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(484, 110);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(88, 23);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "Divisão";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnBlend
            // 
            this.btnBlend.Location = new System.Drawing.Point(484, 139);
            this.btnBlend.Name = "btnBlend";
            this.btnBlend.Size = new System.Drawing.Size(88, 23);
            this.btnBlend.TabIndex = 4;
            this.btnBlend.Text = "Blending";
            this.btnBlend.UseVisualStyleBackColor = true;
            this.btnBlend.Click += new System.EventHandler(this.btnBlend_Click);
            // 
            // btnMed
            // 
            this.btnMed.Location = new System.Drawing.Point(484, 168);
            this.btnMed.Name = "btnMed";
            this.btnMed.Size = new System.Drawing.Size(88, 23);
            this.btnMed.TabIndex = 5;
            this.btnMed.Text = "Media";
            this.btnMed.UseVisualStyleBackColor = true;
            this.btnMed.Click += new System.EventHandler(this.btnMed_Click);
            // 
            // btnXor
            // 
            this.btnXor.Location = new System.Drawing.Point(631, 111);
            this.btnXor.Name = "btnXor";
            this.btnXor.Size = new System.Drawing.Size(53, 23);
            this.btnXor.TabIndex = 6;
            this.btnXor.Text = "XOR";
            this.btnXor.UseVisualStyleBackColor = true;
            this.btnXor.Click += new System.EventHandler(this.btnXor_Click);
            // 
            // btnAnd
            // 
            this.btnAnd.Location = new System.Drawing.Point(631, 25);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(53, 23);
            this.btnAnd.TabIndex = 7;
            this.btnAnd.Text = "AND";
            this.btnAnd.UseVisualStyleBackColor = true;
            this.btnAnd.Click += new System.EventHandler(this.btnAnd_Click);
            // 
            // btnNot
            // 
            this.btnNot.Location = new System.Drawing.Point(631, 55);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(53, 23);
            this.btnNot.TabIndex = 8;
            this.btnNot.Text = "NOT";
            this.btnNot.UseVisualStyleBackColor = true;
            this.btnNot.Click += new System.EventHandler(this.btnNot_Click);
            // 
            // btnOr
            // 
            this.btnOr.Location = new System.Drawing.Point(631, 84);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(53, 23);
            this.btnOr.TabIndex = 9;
            this.btnOr.Text = "OR";
            this.btnOr.UseVisualStyleBackColor = true;
            this.btnOr.Click += new System.EventHandler(this.btnOr_Click);
            // 
            // txAdd
            // 
            this.txAdd.Location = new System.Drawing.Point(574, 25);
            this.txAdd.Name = "txAdd";
            this.txAdd.Size = new System.Drawing.Size(36, 20);
            this.txAdd.TabIndex = 10;
            // 
            // txSub
            // 
            this.txSub.Location = new System.Drawing.Point(574, 55);
            this.txSub.Name = "txSub";
            this.txSub.Size = new System.Drawing.Size(36, 20);
            this.txSub.TabIndex = 11;
            // 
            // txMult
            // 
            this.txMult.Location = new System.Drawing.Point(574, 84);
            this.txMult.Name = "txMult";
            this.txMult.Size = new System.Drawing.Size(36, 20);
            this.txMult.TabIndex = 12;
            // 
            // txDiv
            // 
            this.txDiv.Location = new System.Drawing.Point(574, 113);
            this.txDiv.Name = "txDiv";
            this.txDiv.Size = new System.Drawing.Size(36, 20);
            this.txDiv.TabIndex = 13;
            // 
            // txBlend
            // 
            this.txBlend.Location = new System.Drawing.Point(574, 141);
            this.txBlend.Name = "txBlend";
            this.txBlend.Size = new System.Drawing.Size(36, 20);
            this.txBlend.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(270, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 207);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(703, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(209, 207);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.LoadImgA.Click += new System.EventHandler(this.LoadImgA_Click);
            // 
            // LoadImgB
            // 
            this.LoadImgB.Location = new System.Drawing.Point(270, 237);
            this.LoadImgB.Name = "LoadImgB";
            this.LoadImgB.Size = new System.Drawing.Size(208, 23);
            this.LoadImgB.TabIndex = 19;
            this.LoadImgB.Text = "Carregar Imagem B";
            this.LoadImgB.UseVisualStyleBackColor = true;
            this.LoadImgB.Click += new System.EventHandler(this.LoadImgB_Click);
            // 
            // SalvarImagem
            // 
            this.SalvarImagem.Location = new System.Drawing.Point(704, 237);
            this.SalvarImagem.Name = "SalvarImagem";
            this.SalvarImagem.Size = new System.Drawing.Size(208, 23);
            this.SalvarImagem.TabIndex = 20;
            this.SalvarImagem.Text = "Salvar imagem";
            this.SalvarImagem.UseVisualStyleBackColor = true;
            this.SalvarImagem.Click += new System.EventHandler(this.SalvarImagem_Click);
            // 
            // RGBToBit
            // 
            this.RGBToBit.Location = new System.Drawing.Point(34, 284);
            this.RGBToBit.Name = "RGBToBit";
            this.RGBToBit.Size = new System.Drawing.Size(75, 23);
            this.RGBToBit.TabIndex = 21;
            this.RGBToBit.Text = "RGB --> 1bit ";
            this.RGBToBit.UseVisualStyleBackColor = true;
            this.RGBToBit.Click += new System.EventHandler(this.RGBToBit_Click);
            // 
            // RGBTo8Bit
            // 
            this.RGBTo8Bit.Location = new System.Drawing.Point(34, 313);
            this.RGBTo8Bit.Name = "RGBTo8Bit";
            this.RGBTo8Bit.Size = new System.Drawing.Size(75, 23);
            this.RGBTo8Bit.TabIndex = 22;
            this.RGBTo8Bit.Text = "RGB --> 8bit ";
            this.RGBTo8Bit.UseVisualStyleBackColor = true;
            this.RGBTo8Bit.Click += new System.EventHandler(this.RGBTo8Bit_Click);
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
            this.btnRealceMedia.Click += new System.EventHandler(this.btnRealceMedia_Click);
            // 
            // btnRealceMin
            // 
            this.btnRealceMin.Location = new System.Drawing.Point(197, 313);
            this.btnRealceMin.Name = "btnRealceMin";
            this.btnRealceMin.Size = new System.Drawing.Size(75, 23);
            this.btnRealceMin.TabIndex = 26;
            this.btnRealceMin.Text = "MIN";
            this.btnRealceMin.UseVisualStyleBackColor = true;
            this.btnRealceMin.Click += new System.EventHandler(this.btnRealceMin_Click);
            // 
            // btnRealceMax
            // 
            this.btnRealceMax.Location = new System.Drawing.Point(197, 284);
            this.btnRealceMax.Name = "btnRealceMax";
            this.btnRealceMax.Size = new System.Drawing.Size(75, 23);
            this.btnRealceMax.TabIndex = 25;
            this.btnRealceMax.Text = "MÁX";
            this.btnRealceMax.UseVisualStyleBackColor = true;
            this.btnRealceMax.Click += new System.EventHandler(this.btnRealceMax_Click);
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
            // txOrdem
            // 
            this.txOrdem.Location = new System.Drawing.Point(359, 315);
            this.txOrdem.Name = "txOrdem";
            this.txOrdem.Size = new System.Drawing.Size(54, 20);
            this.txOrdem.TabIndex = 31;
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
            // histDefault
            // 
            chartArea9.Name = "ChartArea1";
            this.histDefault.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.histDefault.Legends.Add(legend9);
            this.histDefault.Location = new System.Drawing.Point(34, 405);
            this.histDefault.Name = "histDefault";
            this.histDefault.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.histDefault.Series.Add(series9);
            this.histDefault.Size = new System.Drawing.Size(403, 196);
            this.histDefault.TabIndex = 35;
            this.histDefault.Text = "chart1";
            // 
            // histNormalizado
            // 
            chartArea10.Name = "ChartArea1";
            this.histNormalizado.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.histNormalizado.Legends.Add(legend10);
            this.histNormalizado.Location = new System.Drawing.Point(509, 405);
            this.histNormalizado.Name = "histNormalizado";
            this.histNormalizado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.histNormalizado.Series.Add(series10);
            this.histNormalizado.Size = new System.Drawing.Size(403, 196);
            this.histNormalizado.TabIndex = 36;
            this.histNormalizado.Tag = "";
            this.histNormalizado.Text = "chart2";
            // 
            // equalizarHistograma
            // 
            this.equalizarHistograma.Location = new System.Drawing.Point(440, 479);
            this.equalizarHistograma.Name = "equalizarHistograma";
            this.equalizarHistograma.Size = new System.Drawing.Size(67, 44);
            this.equalizarHistograma.TabIndex = 37;
            this.equalizarHistograma.Text = "Equalizar histograma";
            this.equalizarHistograma.UseVisualStyleBackColor = true;
            this.equalizarHistograma.Click += new System.EventHandler(this.equalizarHistograma_Click);
            // 
            // btnToDouble
            // 
            this.btnToDouble.Location = new System.Drawing.Point(34, 342);
            this.btnToDouble.Name = "btnToDouble";
            this.btnToDouble.Size = new System.Drawing.Size(75, 23);
            this.btnToDouble.TabIndex = 38;
            this.btnToDouble.Text = "ToDouble";
            this.btnToDouble.UseVisualStyleBackColor = true;
            this.btnToDouble.Click += new System.EventHandler(this.btnToDouble_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 613);
            this.Controls.Add(this.btnToDouble);
            this.Controls.Add(this.equalizarHistograma);
            this.Controls.Add(this.histNormalizado);
            this.Controls.Add(this.histDefault);
            this.Controls.Add(this.negativo);
            this.Controls.Add(this.SDBI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txOrdem);
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
            this.Controls.Add(this.txBlend);
            this.Controls.Add(this.txDiv);
            this.Controls.Add(this.txMult);
            this.Controls.Add(this.txSub);
            this.Controls.Add(this.txAdd);
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
            ((System.ComponentModel.ISupportInitialize)(this.histDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histNormalizado)).EndInit();
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
        private System.Windows.Forms.TextBox txAdd;
        private System.Windows.Forms.TextBox txSub;
        private System.Windows.Forms.TextBox txMult;
        private System.Windows.Forms.TextBox txDiv;
        private System.Windows.Forms.TextBox txBlend;
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
        private System.Windows.Forms.TextBox txOrdem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SDBI;
        private System.Windows.Forms.Button negativo;
        private System.Windows.Forms.DataVisualization.Charting.Chart histDefault;
        private System.Windows.Forms.DataVisualization.Charting.Chart histNormalizado;
        private System.Windows.Forms.Button equalizarHistograma;
        private System.Windows.Forms.Button btnToDouble;
    }
}

