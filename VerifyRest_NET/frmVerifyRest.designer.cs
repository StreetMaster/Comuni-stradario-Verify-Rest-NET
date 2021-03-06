﻿namespace VerifyRest_NET
{
    partial class frmVerifyRest
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerifyRest));
            this.btnCallVerify = new System.Windows.Forms.Button();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.txtInProvincia = new System.Windows.Forms.TextBox();
            this.lblInProv = new System.Windows.Forms.Label();
            this.txtInCap = new System.Windows.Forms.TextBox();
            this.lblInCap = new System.Windows.Forms.Label();
            this.txtInIndirizzo = new System.Windows.Forms.TextBox();
            this.lblInIndirizzo = new System.Windows.Forms.Label();
            this.txtInComune = new System.Windows.Forms.TextBox();
            this.lblInComune = new System.Windows.Forms.Label();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.txtOutScoreComune = new System.Windows.Forms.TextBox();
            this.lblOutScoreComune = new System.Windows.Forms.Label();
            this.txtOutScoreStrada = new System.Windows.Forms.TextBox();
            this.lblOutScoreStrada = new System.Windows.Forms.Label();
            this.btnMoveNext = new System.Windows.Forms.Button();
            this.btnMovePrev = new System.Windows.Forms.Button();
            this.lblCandNum = new System.Windows.Forms.Label();
            this.gbCandidato = new System.Windows.Forms.GroupBox();
            this.txtOutFrazione = new System.Windows.Forms.TextBox();
            this.lblOutFrazione = new System.Windows.Forms.Label();
            this.txtOutProvincia = new System.Windows.Forms.TextBox();
            this.lblOutProvincia = new System.Windows.Forms.Label();
            this.txtOutCap = new System.Windows.Forms.TextBox();
            this.lblOutCap = new System.Windows.Forms.Label();
            this.txtOutIndirizzo = new System.Windows.Forms.TextBox();
            this.lblOutIndirizzo = new System.Windows.Forms.Label();
            this.txtOutComune = new System.Windows.Forms.TextBox();
            this.lblOutComune = new System.Windows.Forms.Label();
            this.txtOutCodErr = new System.Windows.Forms.TextBox();
            this.lblOutCodErr = new System.Windows.Forms.Label();
            this.txtOutNumCand = new System.Windows.Forms.TextBox();
            this.lblOutNumCand = new System.Windows.Forms.Label();
            this.txtOutEsito = new System.Windows.Forms.TextBox();
            this.lblOutEsito = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbInput.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.gbCandidato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCallVerify
            // 
            this.btnCallVerify.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallVerify.Location = new System.Drawing.Point(271, 154);
            this.btnCallVerify.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCallVerify.Name = "btnCallVerify";
            this.btnCallVerify.Size = new System.Drawing.Size(110, 23);
            this.btnCallVerify.TabIndex = 0;
            this.btnCallVerify.Text = "Call Verify";
            this.btnCallVerify.UseVisualStyleBackColor = true;
            this.btnCallVerify.Click += new System.EventHandler(this.btnCallVerify_Click);
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.txtInProvincia);
            this.gbInput.Controls.Add(this.lblInProv);
            this.gbInput.Controls.Add(this.txtInCap);
            this.gbInput.Controls.Add(this.lblInCap);
            this.gbInput.Controls.Add(this.txtInIndirizzo);
            this.gbInput.Controls.Add(this.lblInIndirizzo);
            this.gbInput.Controls.Add(this.txtInComune);
            this.gbInput.Controls.Add(this.lblInComune);
            this.gbInput.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInput.Location = new System.Drawing.Point(13, 12);
            this.gbInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInput.Name = "gbInput";
            this.gbInput.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInput.Size = new System.Drawing.Size(886, 115);
            this.gbInput.TabIndex = 1;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input";
            // 
            // txtInProvincia
            // 
            this.txtInProvincia.Location = new System.Drawing.Point(529, 29);
            this.txtInProvincia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInProvincia.Name = "txtInProvincia";
            this.txtInProvincia.Size = new System.Drawing.Size(49, 23);
            this.txtInProvincia.TabIndex = 9;
            // 
            // lblInProv
            // 
            this.lblInProv.AutoSize = true;
            this.lblInProv.Location = new System.Drawing.Point(450, 32);
            this.lblInProv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInProv.Name = "lblInProv";
            this.lblInProv.Size = new System.Drawing.Size(80, 16);
            this.lblInProv.TabIndex = 8;
            this.lblInProv.Text = "Provincia:";
            // 
            // txtInCap
            // 
            this.txtInCap.Location = new System.Drawing.Point(653, 29);
            this.txtInCap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInCap.Name = "txtInCap";
            this.txtInCap.Size = new System.Drawing.Size(65, 23);
            this.txtInCap.TabIndex = 7;
            // 
            // lblInCap
            // 
            this.lblInCap.AutoSize = true;
            this.lblInCap.Location = new System.Drawing.Point(612, 32);
            this.lblInCap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInCap.Name = "lblInCap";
            this.lblInCap.Size = new System.Drawing.Size(42, 16);
            this.lblInCap.TabIndex = 6;
            this.lblInCap.Text = "CAP:";
            // 
            // txtInIndirizzo
            // 
            this.txtInIndirizzo.Location = new System.Drawing.Point(99, 68);
            this.txtInIndirizzo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInIndirizzo.Name = "txtInIndirizzo";
            this.txtInIndirizzo.Size = new System.Drawing.Size(677, 23);
            this.txtInIndirizzo.TabIndex = 3;
            // 
            // lblInIndirizzo
            // 
            this.lblInIndirizzo.AutoSize = true;
            this.lblInIndirizzo.Location = new System.Drawing.Point(19, 71);
            this.lblInIndirizzo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInIndirizzo.Name = "lblInIndirizzo";
            this.lblInIndirizzo.Size = new System.Drawing.Size(76, 16);
            this.lblInIndirizzo.TabIndex = 2;
            this.lblInIndirizzo.Text = "Indirizzo:";
            // 
            // txtInComune
            // 
            this.txtInComune.Location = new System.Drawing.Point(99, 29);
            this.txtInComune.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInComune.Name = "txtInComune";
            this.txtInComune.Size = new System.Drawing.Size(343, 23);
            this.txtInComune.TabIndex = 1;
            // 
            // lblInComune
            // 
            this.lblInComune.AutoSize = true;
            this.lblInComune.Location = new System.Drawing.Point(19, 32);
            this.lblInComune.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInComune.Name = "lblInComune";
            this.lblInComune.Size = new System.Drawing.Size(73, 16);
            this.lblInComune.TabIndex = 0;
            this.lblInComune.Text = "Comune:";
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.txtOutScoreComune);
            this.gbOutput.Controls.Add(this.lblOutScoreComune);
            this.gbOutput.Controls.Add(this.txtOutScoreStrada);
            this.gbOutput.Controls.Add(this.lblOutScoreStrada);
            this.gbOutput.Controls.Add(this.btnMoveNext);
            this.gbOutput.Controls.Add(this.btnMovePrev);
            this.gbOutput.Controls.Add(this.lblCandNum);
            this.gbOutput.Controls.Add(this.gbCandidato);
            this.gbOutput.Controls.Add(this.txtOutCodErr);
            this.gbOutput.Controls.Add(this.lblOutCodErr);
            this.gbOutput.Controls.Add(this.txtOutNumCand);
            this.gbOutput.Controls.Add(this.lblOutNumCand);
            this.gbOutput.Controls.Add(this.txtOutEsito);
            this.gbOutput.Controls.Add(this.lblOutEsito);
            this.gbOutput.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOutput.Location = new System.Drawing.Point(13, 203);
            this.gbOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbOutput.Size = new System.Drawing.Size(886, 279);
            this.gbOutput.TabIndex = 2;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // txtOutScoreComune
            // 
            this.txtOutScoreComune.Location = new System.Drawing.Point(610, 64);
            this.txtOutScoreComune.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOutScoreComune.Name = "txtOutScoreComune";
            this.txtOutScoreComune.ReadOnly = true;
            this.txtOutScoreComune.Size = new System.Drawing.Size(49, 22);
            this.txtOutScoreComune.TabIndex = 35;
            // 
            // lblOutScoreComune
            // 
            this.lblOutScoreComune.AutoSize = true;
            this.lblOutScoreComune.Location = new System.Drawing.Point(498, 67);
            this.lblOutScoreComune.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutScoreComune.Name = "lblOutScoreComune";
            this.lblOutScoreComune.Size = new System.Drawing.Size(107, 14);
            this.lblOutScoreComune.TabIndex = 34;
            this.lblOutScoreComune.Text = "Score Comune:";
            // 
            // txtOutScoreStrada
            // 
            this.txtOutScoreStrada.Location = new System.Drawing.Point(773, 64);
            this.txtOutScoreStrada.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOutScoreStrada.Name = "txtOutScoreStrada";
            this.txtOutScoreStrada.ReadOnly = true;
            this.txtOutScoreStrada.Size = new System.Drawing.Size(65, 22);
            this.txtOutScoreStrada.TabIndex = 33;
            // 
            // lblOutScoreStrada
            // 
            this.lblOutScoreStrada.AutoSize = true;
            this.lblOutScoreStrada.Location = new System.Drawing.Point(667, 67);
            this.lblOutScoreStrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutScoreStrada.Name = "lblOutScoreStrada";
            this.lblOutScoreStrada.Size = new System.Drawing.Size(98, 14);
            this.lblOutScoreStrada.TabIndex = 32;
            this.lblOutScoreStrada.Text = "Score Strada:";
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Location = new System.Drawing.Point(69, 63);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.Size = new System.Drawing.Size(39, 23);
            this.btnMoveNext.TabIndex = 27;
            this.btnMoveNext.Text = ">>";
            this.btnMoveNext.UseVisualStyleBackColor = true;
            this.btnMoveNext.Click += new System.EventHandler(this.btnMoveNext_Click);
            // 
            // btnMovePrev
            // 
            this.btnMovePrev.Location = new System.Drawing.Point(22, 63);
            this.btnMovePrev.Name = "btnMovePrev";
            this.btnMovePrev.Size = new System.Drawing.Size(41, 23);
            this.btnMovePrev.TabIndex = 26;
            this.btnMovePrev.Text = "<<";
            this.btnMovePrev.UseVisualStyleBackColor = true;
            this.btnMovePrev.Click += new System.EventHandler(this.btnMovePrev_Click);
            // 
            // lblCandNum
            // 
            this.lblCandNum.AutoSize = true;
            this.lblCandNum.Location = new System.Drawing.Point(194, 72);
            this.lblCandNum.Name = "lblCandNum";
            this.lblCandNum.Size = new System.Drawing.Size(0, 14);
            this.lblCandNum.TabIndex = 25;
            // 
            // gbCandidato
            // 
            this.gbCandidato.Controls.Add(this.txtOutFrazione);
            this.gbCandidato.Controls.Add(this.lblOutFrazione);
            this.gbCandidato.Controls.Add(this.txtOutProvincia);
            this.gbCandidato.Controls.Add(this.lblOutProvincia);
            this.gbCandidato.Controls.Add(this.txtOutCap);
            this.gbCandidato.Controls.Add(this.lblOutCap);
            this.gbCandidato.Controls.Add(this.txtOutIndirizzo);
            this.gbCandidato.Controls.Add(this.lblOutIndirizzo);
            this.gbCandidato.Controls.Add(this.txtOutComune);
            this.gbCandidato.Controls.Add(this.lblOutComune);
            this.gbCandidato.Location = new System.Drawing.Point(24, 89);
            this.gbCandidato.Name = "gbCandidato";
            this.gbCandidato.Size = new System.Drawing.Size(816, 153);
            this.gbCandidato.TabIndex = 24;
            this.gbCandidato.TabStop = false;
            // 
            // txtOutFrazione
            // 
            this.txtOutFrazione.Location = new System.Drawing.Point(103, 61);
            this.txtOutFrazione.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOutFrazione.Name = "txtOutFrazione";
            this.txtOutFrazione.ReadOnly = true;
            this.txtOutFrazione.Size = new System.Drawing.Size(343, 22);
            this.txtOutFrazione.TabIndex = 33;
            // 
            // lblOutFrazione
            // 
            this.lblOutFrazione.AutoSize = true;
            this.lblOutFrazione.Location = new System.Drawing.Point(30, 64);
            this.lblOutFrazione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutFrazione.Name = "lblOutFrazione";
            this.lblOutFrazione.Size = new System.Drawing.Size(69, 14);
            this.lblOutFrazione.TabIndex = 32;
            this.lblOutFrazione.Text = "Frazione:";
            // 
            // txtOutProvincia
            // 
            this.txtOutProvincia.Location = new System.Drawing.Point(556, 21);
            this.txtOutProvincia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOutProvincia.Name = "txtOutProvincia";
            this.txtOutProvincia.ReadOnly = true;
            this.txtOutProvincia.Size = new System.Drawing.Size(49, 22);
            this.txtOutProvincia.TabIndex = 31;
            // 
            // lblOutProvincia
            // 
            this.lblOutProvincia.AutoSize = true;
            this.lblOutProvincia.Location = new System.Drawing.Point(474, 24);
            this.lblOutProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutProvincia.Name = "lblOutProvincia";
            this.lblOutProvincia.Size = new System.Drawing.Size(74, 14);
            this.lblOutProvincia.TabIndex = 30;
            this.lblOutProvincia.Text = "Provincia:";
            // 
            // txtOutCap
            // 
            this.txtOutCap.Location = new System.Drawing.Point(660, 21);
            this.txtOutCap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOutCap.Name = "txtOutCap";
            this.txtOutCap.ReadOnly = true;
            this.txtOutCap.Size = new System.Drawing.Size(65, 22);
            this.txtOutCap.TabIndex = 29;
            // 
            // lblOutCap
            // 
            this.lblOutCap.AutoSize = true;
            this.lblOutCap.Location = new System.Drawing.Point(613, 24);
            this.lblOutCap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutCap.Name = "lblOutCap";
            this.lblOutCap.Size = new System.Drawing.Size(39, 14);
            this.lblOutCap.TabIndex = 28;
            this.lblOutCap.Text = "CAP:";
            // 
            // txtOutIndirizzo
            // 
            this.txtOutIndirizzo.Location = new System.Drawing.Point(103, 102);
            this.txtOutIndirizzo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOutIndirizzo.Name = "txtOutIndirizzo";
            this.txtOutIndirizzo.ReadOnly = true;
            this.txtOutIndirizzo.Size = new System.Drawing.Size(677, 22);
            this.txtOutIndirizzo.TabIndex = 27;
            // 
            // lblOutIndirizzo
            // 
            this.lblOutIndirizzo.AutoSize = true;
            this.lblOutIndirizzo.Location = new System.Drawing.Point(25, 105);
            this.lblOutIndirizzo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutIndirizzo.Name = "lblOutIndirizzo";
            this.lblOutIndirizzo.Size = new System.Drawing.Size(70, 14);
            this.lblOutIndirizzo.TabIndex = 26;
            this.lblOutIndirizzo.Text = "Indirizzo:";
            // 
            // txtOutComune
            // 
            this.txtOutComune.Location = new System.Drawing.Point(103, 21);
            this.txtOutComune.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOutComune.Name = "txtOutComune";
            this.txtOutComune.ReadOnly = true;
            this.txtOutComune.Size = new System.Drawing.Size(343, 22);
            this.txtOutComune.TabIndex = 25;
            // 
            // lblOutComune
            // 
            this.lblOutComune.AutoSize = true;
            this.lblOutComune.Location = new System.Drawing.Point(30, 24);
            this.lblOutComune.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutComune.Name = "lblOutComune";
            this.lblOutComune.Size = new System.Drawing.Size(65, 14);
            this.lblOutComune.TabIndex = 24;
            this.lblOutComune.Text = "Comune:";
            // 
            // txtOutCodErr
            // 
            this.txtOutCodErr.Location = new System.Drawing.Point(265, 31);
            this.txtOutCodErr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOutCodErr.Name = "txtOutCodErr";
            this.txtOutCodErr.ReadOnly = true;
            this.txtOutCodErr.Size = new System.Drawing.Size(50, 22);
            this.txtOutCodErr.TabIndex = 13;
            // 
            // lblOutCodErr
            // 
            this.lblOutCodErr.AutoSize = true;
            this.lblOutCodErr.Location = new System.Drawing.Point(180, 35);
            this.lblOutCodErr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutCodErr.Name = "lblOutCodErr";
            this.lblOutCodErr.Size = new System.Drawing.Size(87, 14);
            this.lblOutCodErr.TabIndex = 12;
            this.lblOutCodErr.Text = "Cod. Errore:";
            // 
            // txtOutNumCand
            // 
            this.txtOutNumCand.Location = new System.Drawing.Point(406, 30);
            this.txtOutNumCand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOutNumCand.Name = "txtOutNumCand";
            this.txtOutNumCand.ReadOnly = true;
            this.txtOutNumCand.Size = new System.Drawing.Size(50, 22);
            this.txtOutNumCand.TabIndex = 11;
            // 
            // lblOutNumCand
            // 
            this.lblOutNumCand.AutoSize = true;
            this.lblOutNumCand.Location = new System.Drawing.Point(321, 36);
            this.lblOutNumCand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutNumCand.Name = "lblOutNumCand";
            this.lblOutNumCand.Size = new System.Drawing.Size(87, 14);
            this.lblOutNumCand.TabIndex = 10;
            this.lblOutNumCand.Text = "Num. Cand.:";
            // 
            // txtOutEsito
            // 
            this.txtOutEsito.Location = new System.Drawing.Point(125, 30);
            this.txtOutEsito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOutEsito.Name = "txtOutEsito";
            this.txtOutEsito.ReadOnly = true;
            this.txtOutEsito.Size = new System.Drawing.Size(50, 22);
            this.txtOutEsito.TabIndex = 9;
            // 
            // lblOutEsito
            // 
            this.lblOutEsito.AutoSize = true;
            this.lblOutEsito.Location = new System.Drawing.Point(29, 35);
            this.lblOutEsito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutEsito.Name = "lblOutEsito";
            this.lblOutEsito.Size = new System.Drawing.Size(99, 14);
            this.lblOutEsito.TabIndex = 8;
            this.lblOutEsito.Text = "Esito Verifica:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "KEY:";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(443, 156);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(348, 21);
            this.txtKey.TabIndex = 4;
            this.txtKey.Text = "Specificare una chiave per il servizio Verify";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 64);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmVerifyRest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(933, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.btnCallVerify);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmVerifyRest";
            this.Text = "Demo Verify WS";
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            this.gbCandidato.ResumeLayout(false);
            this.gbCandidato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCallVerify;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtInProvincia;
        private System.Windows.Forms.Label lblInProv;
        private System.Windows.Forms.TextBox txtInCap;
        private System.Windows.Forms.Label lblInCap;
        private System.Windows.Forms.TextBox txtInIndirizzo;
        private System.Windows.Forms.Label lblInIndirizzo;
        private System.Windows.Forms.TextBox txtInComune;
        private System.Windows.Forms.Label lblInComune;
        private System.Windows.Forms.TextBox txtOutCodErr;
        private System.Windows.Forms.Label lblOutCodErr;
        private System.Windows.Forms.TextBox txtOutNumCand;
        private System.Windows.Forms.Label lblOutNumCand;
        private System.Windows.Forms.TextBox txtOutEsito;
        private System.Windows.Forms.Label lblOutEsito;
        private System.Windows.Forms.Button btnMoveNext;
        private System.Windows.Forms.Button btnMovePrev;
        private System.Windows.Forms.Label lblCandNum;
        private System.Windows.Forms.GroupBox gbCandidato;
        private System.Windows.Forms.TextBox txtOutFrazione;
        private System.Windows.Forms.Label lblOutFrazione;
        private System.Windows.Forms.TextBox txtOutProvincia;
        private System.Windows.Forms.Label lblOutProvincia;
        private System.Windows.Forms.TextBox txtOutCap;
        private System.Windows.Forms.Label lblOutCap;
        private System.Windows.Forms.TextBox txtOutIndirizzo;
        private System.Windows.Forms.Label lblOutIndirizzo;
        private System.Windows.Forms.TextBox txtOutComune;
        private System.Windows.Forms.Label lblOutComune;
        private System.Windows.Forms.TextBox txtOutScoreComune;
        private System.Windows.Forms.Label lblOutScoreComune;
        private System.Windows.Forms.TextBox txtOutScoreStrada;
        private System.Windows.Forms.Label lblOutScoreStrada;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

