using static System.Net.Mime.MediaTypeNames;

namespace SAE_2._04
{
    partial class frmFormulaire
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormulaire));
            this.btnDemarrer = new System.Windows.Forms.Button();
            this.pnlEtape1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcbEtape1Suivant = new System.Windows.Forms.PictureBox();
            this.lblEtape1Suivant = new System.Windows.Forms.Label();
            this.grpEtape1IngredientsSelectionne = new System.Windows.Forms.GroupBox();
            this.grpEtape1Ingredients = new System.Windows.Forms.GroupBox();
            this.lblEtape1Texte1 = new System.Windows.Forms.Label();
            this.grpEtape1FamileIngredients = new System.Windows.Forms.GroupBox();
            this.pnlEtape2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEtape2AfficherRecette = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEtape2Reintialiser = new System.Windows.Forms.Button();
            this.pcbEtape2Retour = new System.Windows.Forms.PictureBox();
            this.pcbEtape2Suivant = new System.Windows.Forms.PictureBox();
            this.grpEtape2Temps = new System.Windows.Forms.GroupBox();
            this.txtEtape2TempsCuisson = new System.Windows.Forms.TextBox();
            this.lblEtape2TempsCuisson = new System.Windows.Forms.Label();
            this.grpEtape2Prix = new System.Windows.Forms.GroupBox();
            this.lblEtape2Budget3 = new System.Windows.Forms.RadioButton();
            this.lblEtape2Budget2 = new System.Windows.Forms.RadioButton();
            this.lblEtape2Budget1 = new System.Windows.Forms.RadioButton();
            this.grpEtape2TypePlat = new System.Windows.Forms.GroupBox();
            this.lblEtape0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblfrm1Etape0Fermer = new System.Windows.Forms.Label();
            this.pnlEtape1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEtape1Suivant)).BeginInit();
            this.pnlEtape2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEtape2Retour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEtape2Suivant)).BeginInit();
            this.grpEtape2Temps.SuspendLayout();
            this.grpEtape2Prix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDemarrer
            // 
            this.btnDemarrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDemarrer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDemarrer.FlatAppearance.BorderSize = 0;
            this.btnDemarrer.Font = new System.Drawing.Font("MS Reference Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemarrer.Location = new System.Drawing.Point(368, 309);
            this.btnDemarrer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDemarrer.Name = "btnDemarrer";
            this.btnDemarrer.Size = new System.Drawing.Size(523, 154);
            this.btnDemarrer.TabIndex = 0;
            this.btnDemarrer.Text = "Démarrer";
            this.btnDemarrer.UseVisualStyleBackColor = true;
            this.btnDemarrer.Click += new System.EventHandler(this.btnDemarrer_Click);
            // 
            // pnlEtape1
            // 
            this.pnlEtape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(87)))));
            this.pnlEtape1.Controls.Add(this.pictureBox2);
            this.pnlEtape1.Controls.Add(this.pcbEtape1Suivant);
            this.pnlEtape1.Controls.Add(this.lblEtape1Suivant);
            this.pnlEtape1.Controls.Add(this.grpEtape1IngredientsSelectionne);
            this.pnlEtape1.Controls.Add(this.grpEtape1Ingredients);
            this.pnlEtape1.Controls.Add(this.lblEtape1Texte1);
            this.pnlEtape1.Controls.Add(this.grpEtape1FamileIngredients);
            this.pnlEtape1.Location = new System.Drawing.Point(941, 262);
            this.pnlEtape1.Name = "pnlEtape1";
            this.pnlEtape1.Size = new System.Drawing.Size(299, 289);
            this.pnlEtape1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::SAE_2._04.Properties.Resources.croix;
            this.pictureBox2.Location = new System.Drawing.Point(1206, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnEtape0Quitter_Click);
            // 
            // pcbEtape1Suivant
            // 
            this.pcbEtape1Suivant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbEtape1Suivant.Image = global::SAE_2._04.Properties.Resources.avance1;
            this.pcbEtape1Suivant.InitialImage = global::SAE_2._04.Properties.Resources.button_blue_ffw;
            this.pcbEtape1Suivant.Location = new System.Drawing.Point(906, 585);
            this.pcbEtape1Suivant.Name = "pcbEtape1Suivant";
            this.pcbEtape1Suivant.Size = new System.Drawing.Size(329, 151);
            this.pcbEtape1Suivant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbEtape1Suivant.TabIndex = 5;
            this.pcbEtape1Suivant.TabStop = false;
            this.pcbEtape1Suivant.Click += new System.EventHandler(this.pcbEtape1Suivant_Click);
            // 
            // lblEtape1Suivant
            // 
            this.lblEtape1Suivant.Font = new System.Drawing.Font("Microsoft YaHei", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtape1Suivant.Location = new System.Drawing.Point(899, 537);
            this.lblEtape1Suivant.Name = "lblEtape1Suivant";
            this.lblEtape1Suivant.Size = new System.Drawing.Size(340, 45);
            this.lblEtape1Suivant.TabIndex = 4;
            this.lblEtape1Suivant.Text = "Passez à l\'étape suivante";
            // 
            // grpEtape1IngredientsSelectionne
            // 
            this.grpEtape1IngredientsSelectionne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(25)))));
            this.grpEtape1IngredientsSelectionne.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEtape1IngredientsSelectionne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpEtape1IngredientsSelectionne.Location = new System.Drawing.Point(405, 535);
            this.grpEtape1IngredientsSelectionne.Name = "grpEtape1IngredientsSelectionne";
            this.grpEtape1IngredientsSelectionne.Size = new System.Drawing.Size(449, 206);
            this.grpEtape1IngredientsSelectionne.TabIndex = 3;
            this.grpEtape1IngredientsSelectionne.TabStop = false;
            this.grpEtape1IngredientsSelectionne.Text = "Les ingrédients que vous voulez utiliser ";
            // 
            // grpEtape1Ingredients
            // 
            this.grpEtape1Ingredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(154)))));
            this.grpEtape1Ingredients.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEtape1Ingredients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpEtape1Ingredients.Location = new System.Drawing.Point(405, 74);
            this.grpEtape1Ingredients.Name = "grpEtape1Ingredients";
            this.grpEtape1Ingredients.Size = new System.Drawing.Size(845, 450);
            this.grpEtape1Ingredients.TabIndex = 2;
            this.grpEtape1Ingredients.TabStop = false;
            this.grpEtape1Ingredients.Text = "Liste des ingrédients :";
            // 
            // lblEtape1Texte1
            // 
            this.lblEtape1Texte1.Font = new System.Drawing.Font("Microsoft YaHei", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtape1Texte1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(0)))));
            this.lblEtape1Texte1.Location = new System.Drawing.Point(400, 12);
            this.lblEtape1Texte1.Name = "lblEtape1Texte1";
            this.lblEtape1Texte1.Size = new System.Drawing.Size(820, 157);
            this.lblEtape1Texte1.TabIndex = 0;
            this.lblEtape1Texte1.Text = "- Etape 1 : Indiquez au maximum 3 ingrédients dont vous disposez. Sinon passez di" +
    "rectement \r\nà l\'étape suivante\r\n\r\n\r\n";
            // 
            // grpEtape1FamileIngredients
            // 
            this.grpEtape1FamileIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(87)))));
            this.grpEtape1FamileIngredients.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.grpEtape1FamileIngredients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(0)))), ((int)(((byte)(126)))));
            this.grpEtape1FamileIngredients.Location = new System.Drawing.Point(12, 12);
            this.grpEtape1FamileIngredients.Name = "grpEtape1FamileIngredients";
            this.grpEtape1FamileIngredients.Size = new System.Drawing.Size(382, 730);
            this.grpEtape1FamileIngredients.TabIndex = 1;
            this.grpEtape1FamileIngredients.TabStop = false;
            this.grpEtape1FamileIngredients.Text = "Famille d\'ingrédients";
            // 
            // pnlEtape2
            // 
            this.pnlEtape2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(87)))));
            this.pnlEtape2.Controls.Add(this.pictureBox1);
            this.pnlEtape2.Controls.Add(this.lblEtape2AfficherRecette);
            this.pnlEtape2.Controls.Add(this.label2);
            this.pnlEtape2.Controls.Add(this.btnEtape2Reintialiser);
            this.pnlEtape2.Controls.Add(this.pcbEtape2Retour);
            this.pnlEtape2.Controls.Add(this.pcbEtape2Suivant);
            this.pnlEtape2.Controls.Add(this.grpEtape2Temps);
            this.pnlEtape2.Controls.Add(this.grpEtape2Prix);
            this.pnlEtape2.Controls.Add(this.grpEtape2TypePlat);
            this.pnlEtape2.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEtape2.Location = new System.Drawing.Point(44, 262);
            this.pnlEtape2.Name = "pnlEtape2";
            this.pnlEtape2.Size = new System.Drawing.Size(214, 235);
            this.pnlEtape2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::SAE_2._04.Properties.Resources.croix;
            this.pictureBox1.Location = new System.Drawing.Point(1205, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnEtape0Quitter_Click);
            // 
            // lblEtape2AfficherRecette
            // 
            this.lblEtape2AfficherRecette.Font = new System.Drawing.Font("Microsoft YaHei", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtape2AfficherRecette.Location = new System.Drawing.Point(905, 546);
            this.lblEtape2AfficherRecette.Name = "lblEtape2AfficherRecette";
            this.lblEtape2AfficherRecette.Size = new System.Drawing.Size(323, 45);
            this.lblEtape2AfficherRecette.TabIndex = 6;
            this.lblEtape2AfficherRecette.Text = "Afficher les recettes";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "Revenir en arrière";
            // 
            // btnEtape2Reintialiser
            // 
            this.btnEtape2Reintialiser.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtape2Reintialiser.Location = new System.Drawing.Point(515, 595);
            this.btnEtape2Reintialiser.Name = "btnEtape2Reintialiser";
            this.btnEtape2Reintialiser.Size = new System.Drawing.Size(286, 92);
            this.btnEtape2Reintialiser.TabIndex = 9;
            this.btnEtape2Reintialiser.Text = "Réintialiser";
            this.btnEtape2Reintialiser.UseVisualStyleBackColor = true;
            this.btnEtape2Reintialiser.Click += new System.EventHandler(this.btnEtape2Reintialiser_Click);
            // 
            // pcbEtape2Retour
            // 
            this.pcbEtape2Retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbEtape2Retour.Image = global::SAE_2._04.Properties.Resources.recule1;
            this.pcbEtape2Retour.InitialImage = global::SAE_2._04.Properties.Resources.recule1;
            this.pcbEtape2Retour.Location = new System.Drawing.Point(132, 595);
            this.pcbEtape2Retour.Name = "pcbEtape2Retour";
            this.pcbEtape2Retour.Size = new System.Drawing.Size(276, 147);
            this.pcbEtape2Retour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbEtape2Retour.TabIndex = 8;
            this.pcbEtape2Retour.TabStop = false;
            this.pcbEtape2Retour.Click += new System.EventHandler(this.pcbEtape2Retour_Click);
            // 
            // pcbEtape2Suivant
            // 
            this.pcbEtape2Suivant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbEtape2Suivant.Image = global::SAE_2._04.Properties.Resources.avance11;
            this.pcbEtape2Suivant.InitialImage = global::SAE_2._04.Properties.Resources.button_blue_ffw;
            this.pcbEtape2Suivant.Location = new System.Drawing.Point(930, 593);
            this.pcbEtape2Suivant.Name = "pcbEtape2Suivant";
            this.pcbEtape2Suivant.Size = new System.Drawing.Size(223, 155);
            this.pcbEtape2Suivant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbEtape2Suivant.TabIndex = 7;
            this.pcbEtape2Suivant.TabStop = false;
            this.pcbEtape2Suivant.Click += new System.EventHandler(this.pcbEtape2Suivant_Click);
            // 
            // grpEtape2Temps
            // 
            this.grpEtape2Temps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            this.grpEtape2Temps.Controls.Add(this.txtEtape2TempsCuisson);
            this.grpEtape2Temps.Controls.Add(this.lblEtape2TempsCuisson);
            this.grpEtape2Temps.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEtape2Temps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.grpEtape2Temps.Location = new System.Drawing.Point(110, 431);
            this.grpEtape2Temps.Name = "grpEtape2Temps";
            this.grpEtape2Temps.Size = new System.Drawing.Size(1027, 112);
            this.grpEtape2Temps.TabIndex = 2;
            this.grpEtape2Temps.TabStop = false;
            this.grpEtape2Temps.Text = "Temps de cuisson";
            // 
            // txtEtape2TempsCuisson
            // 
            this.txtEtape2TempsCuisson.Location = new System.Drawing.Point(739, 43);
            this.txtEtape2TempsCuisson.Name = "txtEtape2TempsCuisson";
            this.txtEtape2TempsCuisson.ShortcutsEnabled = false;
            this.txtEtape2TempsCuisson.Size = new System.Drawing.Size(111, 36);
            this.txtEtape2TempsCuisson.TabIndex = 1;
            this.txtEtape2TempsCuisson.TextChanged += new System.EventHandler(this.txtEtape2TempsCuisson_TextChanged);
            this.txtEtape2TempsCuisson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEtape2TempsCuisson_KeyPress);
            // 
            // lblEtape2TempsCuisson
            // 
            this.lblEtape2TempsCuisson.AutoSize = true;
            this.lblEtape2TempsCuisson.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtape2TempsCuisson.Location = new System.Drawing.Point(34, 45);
            this.lblEtape2TempsCuisson.Name = "lblEtape2TempsCuisson";
            this.lblEtape2TempsCuisson.Size = new System.Drawing.Size(558, 27);
            this.lblEtape2TempsCuisson.TabIndex = 0;
            this.lblEtape2TempsCuisson.Text = "De quel temps de cuisson disposez vous (en minute) ?";
            // 
            // grpEtape2Prix
            // 
            this.grpEtape2Prix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(87)))));
            this.grpEtape2Prix.Controls.Add(this.lblEtape2Budget3);
            this.grpEtape2Prix.Controls.Add(this.lblEtape2Budget2);
            this.grpEtape2Prix.Controls.Add(this.lblEtape2Budget1);
            this.grpEtape2Prix.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grpEtape2Prix.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEtape2Prix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(243)))));
            this.grpEtape2Prix.Location = new System.Drawing.Point(58, 256);
            this.grpEtape2Prix.Name = "grpEtape2Prix";
            this.grpEtape2Prix.Size = new System.Drawing.Size(1117, 152);
            this.grpEtape2Prix.TabIndex = 1;
            this.grpEtape2Prix.TabStop = false;
            this.grpEtape2Prix.Text = "Budget";
            // 
            // lblEtape2Budget3
            // 
            this.lblEtape2Budget3.AutoSize = true;
            this.lblEtape2Budget3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEtape2Budget3.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtape2Budget3.Location = new System.Drawing.Point(853, 62);
            this.lblEtape2Budget3.Name = "lblEtape2Budget3";
            this.lblEtape2Budget3.Size = new System.Drawing.Size(148, 34);
            this.lblEtape2Budget3.TabIndex = 12;
            this.lblEtape2Budget3.TabStop = true;
            this.lblEtape2Budget3.Tag = "0";
            this.lblEtape2Budget3.Text = "Assez cher";
            this.lblEtape2Budget3.UseVisualStyleBackColor = true;
            // 
            // lblEtape2Budget2
            // 
            this.lblEtape2Budget2.AutoSize = true;
            this.lblEtape2Budget2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEtape2Budget2.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtape2Budget2.Location = new System.Drawing.Point(470, 62);
            this.lblEtape2Budget2.Name = "lblEtape2Budget2";
            this.lblEtape2Budget2.Size = new System.Drawing.Size(166, 34);
            this.lblEtape2Budget2.TabIndex = 11;
            this.lblEtape2Budget2.TabStop = true;
            this.lblEtape2Budget2.Tag = "2";
            this.lblEtape2Budget2.Text = "Coût moyen";
            this.lblEtape2Budget2.UseVisualStyleBackColor = true;
            // 
            // lblEtape2Budget1
            // 
            this.lblEtape2Budget1.AutoSize = true;
            this.lblEtape2Budget1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEtape2Budget1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtape2Budget1.Location = new System.Drawing.Point(49, 62);
            this.lblEtape2Budget1.Name = "lblEtape2Budget1";
            this.lblEtape2Budget1.Size = new System.Drawing.Size(163, 34);
            this.lblEtape2Budget1.TabIndex = 10;
            this.lblEtape2Budget1.TabStop = true;
            this.lblEtape2Budget1.Tag = "1";
            this.lblEtape2Budget1.Text = "Bon marché";
            this.lblEtape2Budget1.UseVisualStyleBackColor = true;
            // 
            // grpEtape2TypePlat
            // 
            this.grpEtape2TypePlat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(10)))));
            this.grpEtape2TypePlat.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEtape2TypePlat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(243)))));
            this.grpEtape2TypePlat.Location = new System.Drawing.Point(14, 12);
            this.grpEtape2TypePlat.Name = "grpEtape2TypePlat";
            this.grpEtape2TypePlat.Size = new System.Drawing.Size(1188, 232);
            this.grpEtape2TypePlat.TabIndex = 0;
            this.grpEtape2TypePlat.TabStop = false;
            this.grpEtape2TypePlat.Text = "Type de plat";
            // 
            // lblEtape0
            // 
            this.lblEtape0.AutoSize = true;
            this.lblEtape0.BackColor = System.Drawing.Color.Transparent;
            this.lblEtape0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEtape0.Font = new System.Drawing.Font("Microsoft YaHei", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtape0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEtape0.Location = new System.Drawing.Point(200, 125);
            this.lblEtape0.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEtape0.Name = "lblEtape0";
            this.lblEtape0.Size = new System.Drawing.Size(834, 92);
            this.lblEtape0.TabIndex = 1;
            this.lblEtape0.Text = "Qu\'on se cuise un œuf !";
            this.lblEtape0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(10, 709);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "HERTSCHUH Louis - GUILLEMAIN Mathilde";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::SAE_2._04.Properties.Resources.croix;
            this.pictureBox3.Location = new System.Drawing.Point(1197, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btnEtape0Quitter_Click);
            // 
            // lblfrm1Etape0Fermer
            // 
            this.lblfrm1Etape0Fermer.AutoSize = true;
            this.lblfrm1Etape0Fermer.BackColor = System.Drawing.Color.Transparent;
            this.lblfrm1Etape0Fermer.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrm1Etape0Fermer.Location = new System.Drawing.Point(975, 21);
            this.lblfrm1Etape0Fermer.Name = "lblfrm1Etape0Fermer";
            this.lblfrm1Etape0Fermer.Size = new System.Drawing.Size(222, 30);
            this.lblfrm1Etape0Fermer.TabIndex = 13;
            this.lblfrm1Etape0Fermer.Text = "Fermer l\'application";
            this.lblfrm1Etape0Fermer.Click += new System.EventHandler(this.lblfrm1Etape0Fermer_Click);
            // 
            // frmFormulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.pnlEtape2);
            this.Controls.Add(this.pnlEtape1);
            this.Controls.Add(this.btnDemarrer);
            this.Controls.Add(this.lblEtape0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblfrm1Etape0Fermer);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFormulaire";
            this.Text = "Qu\'on se cuise un oeuf!";
            this.Load += new System.EventHandler(this.frmFormulaire_Load);
            this.pnlEtape1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEtape1Suivant)).EndInit();
            this.pnlEtape2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEtape2Retour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEtape2Suivant)).EndInit();
            this.grpEtape2Temps.ResumeLayout(false);
            this.grpEtape2Temps.PerformLayout();
            this.grpEtape2Prix.ResumeLayout(false);
            this.grpEtape2Prix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDemarrer;
        private System.Windows.Forms.Panel pnlEtape1;
        private System.Windows.Forms.Panel pnlEtape2;
        private System.Windows.Forms.Label lblEtape1Texte1;
        private System.Windows.Forms.GroupBox grpEtape1FamileIngredients;
        private System.Windows.Forms.Label lblEtape1Suivant;
        private System.Windows.Forms.GroupBox grpEtape1IngredientsSelectionne;
        private System.Windows.Forms.PictureBox pcbEtape1Suivant;
        private System.Windows.Forms.GroupBox grpEtape2Temps;
        private System.Windows.Forms.GroupBox grpEtape2Prix;
        private System.Windows.Forms.GroupBox grpEtape2TypePlat;
        private System.Windows.Forms.PictureBox pcbEtape2Suivant;
        private System.Windows.Forms.Label lblEtape2AfficherRecette;
        private System.Windows.Forms.PictureBox pcbEtape2Retour;
        private System.Windows.Forms.Label lblEtape0;
        private System.Windows.Forms.GroupBox grpEtape1Ingredients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEtape2TempsCuisson;
        private System.Windows.Forms.Label lblEtape2TempsCuisson;
        private System.Windows.Forms.RadioButton lblEtape2Budget3;
        private System.Windows.Forms.RadioButton lblEtape2Budget2;
        private System.Windows.Forms.RadioButton lblEtape2Budget1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEtape2Reintialiser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblfrm1Etape0Fermer;
    }
}

