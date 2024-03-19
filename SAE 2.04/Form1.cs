using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_2._04
{
    public partial class frmFormulaire : Form
    {
        List<String> Elements = new List<String>();
        String chcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./baseFrigov2023.mdb";
        OleDbConnection connec = new OleDbConnection();
        DataSet monDs = new DataSet();
        public frmFormulaire()
        {
            //
            InitializeComponent();


        }
        private void frmFormulaire_Load(object sender, EventArgs e)
        {
            //Masquage étape 1 et 2
            pnlEtape1.Visible = false;
            pnlEtape2.Visible = false;
            pnlEtape1.Dock = DockStyle.Fill;
            pnlEtape2.Dock = DockStyle.Fill;
            connec.ConnectionString = chcon;


            string requete = @"select * from Famille ORDER BY libFamille";
            OleDbDataAdapter da = new OleDbDataAdapter(requete, connec);
            da.Fill(monDs, "mesFamille");

            //chargement table ingredient
            string requete2 = @"select * from Ingrédients ORDER BY libIngredient";
            OleDbDataAdapter da2 = new OleDbDataAdapter(requete2, connec);
            da2.Fill(monDs, "mesIngrédients");

            string requete3 = @"select * from Catégories ORDER BY codeCategorie";
            OleDbDataAdapter da3 = new OleDbDataAdapter(requete3, connec);
            da3.Fill(monDs, "mesCatégories");
            // dataGridView1.DataSource = dt;

        }

        private void btnDemarrer_Click(object sender, EventArgs e)
        {
            
            pnlEtape1.Visible = true;
            pnlEtape2.Visible = false;


            ///chargement table Famille
            Button btnpourelem0 = new Button();
            btnpourelem0.Tag = (object)1;
            remplirEtape1FamilleIngredients(sender, e);
            remplirEtape1IngredientsDispo(btnpourelem0, e);
            remplireEtape2TypeDePlat();

        }

        private void remplirEtape1FamilleIngredients(object sender, EventArgs e)
        {

            int espace = ((grpEtape1FamileIngredients.Height - 40) - (40 * monDs.Tables["mesFamille"].Rows.Count)) / monDs.Tables["mesFamille"].Rows.Count + 40;
            double taillelong = grpEtape1FamileIngredients.Width * Double.Parse("0,95");
            int espacegauche = (grpEtape1FamileIngredients.Width - (int)taillelong) / 2;
            int i = 0;

            foreach (DataRow row in monDs.Tables["mesFamille"].Rows)
            {
                Button ingredients = new Button();
                pnlEtape1.Controls.Add(ingredients);
                grpEtape1FamileIngredients.Controls.Add(ingredients);
                ingredients.Location = new Point(espacegauche, 40 + i * espace);
                ingredients.Name = "button1";
                ingredients.Size = new Size((int)taillelong, 40);
                ingredients.TabIndex = (int)row[0];
                ingredients.Tag = (int)row[0];
                ingredients.Text = row[1].ToString();
                ingredients.UseVisualStyleBackColor = true;
                ingredients.Cursor = Cursors.Hand;
                i++;

                ingredients.Click += new EventHandler(bouttonFamilleIngredientsPresse);

            }
        }

        private void bouttonFamilleIngredientsPresse(object sender, EventArgs e)
        {
            //MessageBox.Show("BONJOUR" + sender.ToString());
            //UTILISER sender.Text pour acceder au nom 
            remplirEtape1IngredientsDispo(sender, e);
        }

        private void remplirEtape1IngredientsDispo(object sender, EventArgs e)
        {
            //SUPPRESSION ANCIENS ELEMENTS
            grpEtape1Ingredients.Controls.Clear();

            //RECUPERATION DES INGREDIENTS
            string requete = @"select * from Ingrédients WHERE codeFamille = " + ((Button)sender).Tag + " ORDER BY libIngredient";
            //MessageBox.Show(requete);
            OleDbDataAdapter da = new OleDbDataAdapter(requete, connec);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //EN FONCTION DU NOMBRE D'ELEMENTS, DEFINITION DU NOMBRE DE COLONNE + TAILLE DE LA POLICE
            int nombreElement = dt.Rows.Count;
            double police = 23.0;
            int colonne = 2;
            if (nombreElement > 20)
            {
                colonne = 3;
                police = 17;
            }

            //DECLARATION I, Y X 
            int i = 0;
            int x = 0;
            int y = 0;

            //AJOUT DE CHAQUE CHECKBOX DANS GRP
            foreach (DataRow row in dt.Rows)
            {
                CheckBox chkingredient = new CheckBox();
                pnlEtape1.Controls.Add(chkingredient);
                grpEtape1Ingredients.Controls.Add(chkingredient);
                chkingredient.AutoSize = true;
                chkingredient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                chkingredient.Font = new System.Drawing.Font("Microsoft YaHei", (float)police, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                chkingredient.Name = "CheckBoxEtape1Ingredients";
                chkingredient.Size = new System.Drawing.Size(266, 55);
                chkingredient.TabIndex = 89;
                chkingredient.Text = row[1].ToString();
                chkingredient.Cursor = Cursors.Hand;
                chkingredient.UseVisualStyleBackColor = true;
                if (Elements.Contains(chkingredient.Text)) {chkingredient.Checked = true;}
                else{chkingredient.Checked = false;}
                chkingredient.Click += new EventHandler(bouttonIngredientsPresse);

                //PLACEMENT DU CHECKBOX
                if (colonne < 3){y = y + ((i + 1) % colonne) * 43;
                    if (i % colonne == 0){ x = 50;}
                    else { x = 460; }
                }
                else
                {if (i % colonne == 0) { 
                        x = 50;
                        if (i != 0){y += 42;}
                        else{y = 43; }}
                else{ x = (270 * (i % colonne)) + 50;}}
                chkingredient.Location = new System.Drawing.Point(x, y);


                //SI TAILLE CHECKBOX TROP GRAND -> Police + petite & position légèrement modifiée
                if (chkingredient.Width > 400)
                {
                    chkingredient.Font = new System.Drawing.Font("Microsoft YaHei", 20, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    chkingredient.Location = new System.Drawing.Point(x, y + 2);
                }

                //Incrementation du i
                i++;


            }
        }

        private void bouttonIngredientsPresse(object sender, EventArgs e)
        {

            //MessageBox.Show("BONJOUR" + sender.ToString());
            //UTILISER sender.Text pour acceder au nom 
            //MessageBox.Show("AVANT CODE");
            int compte = Elements.Count();
            CheckBox s = (CheckBox)sender;

            if (s.Checked)
            {
                if (!Elements.Contains(s.Text))
                {
                    Elements.Add(s.Text);
                    if (Elements.Count > 3)
                    {
                        // Désélectionner la case à cocher si le nombre d'éléments dépasse 3
                        s.Checked = false;
                        Elements.Remove(s.Text);
                        MessageBox.Show("Vous ne pouvez pas sélectionner plus de 3 éléments.");
                    }
                }
            }
            else
            {
                Elements.Remove(s.Text);
                //remplireEtape1ElementsSelectionnes(sender, e);
            }

            /*String bjr = "";
            foreach (String str in Elements)
            {
                bjr += str + ",";
                
            }
            MessageBox.Show(bjr);   
            */

            //MAJ DU GRPBOX 
            remplireEtape1ElementsSelectionnes(sender, e);
        }

        private void remplireEtape1ElementsSelectionnes(object sender, EventArgs e)
        {

            grpEtape1IngredientsSelectionne.Controls.Clear();
            int i = 0;
            foreach (String str in Elements)
            {
                Label ingredients_selectionne = new Label();
                pnlEtape1.Controls.Add(ingredients_selectionne);
                grpEtape1IngredientsSelectionne.Controls.Add(ingredients_selectionne);
                ingredients_selectionne.AutoSize = true;
                ingredients_selectionne.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ingredients_selectionne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(0)))), ((int)(((byte)(126)))));
                ingredients_selectionne.Location = new System.Drawing.Point(30, 43 + i);
                ingredients_selectionne.Name = "label2";
                ingredients_selectionne.Size = new System.Drawing.Size(82, 30);
                ingredients_selectionne.TabIndex = 3;
                ingredients_selectionne.Text = str;
                ingredients_selectionne.Tag = i;
                ingredients_selectionne.Cursor = Cursors.Hand;


                Button btnEtape1Supprimer3 = new System.Windows.Forms.Button();
                pnlEtape1.Controls.Add(btnEtape1Supprimer3);
                grpEtape1IngredientsSelectionne.Controls.Add(btnEtape1Supprimer3);
                btnEtape1Supprimer3.Location = new System.Drawing.Point(285, 44 + i);
                btnEtape1Supprimer3.Name = "btnEtape1Supprimer3";
                btnEtape1Supprimer3.Size = new System.Drawing.Size(144, 33);
                btnEtape1Supprimer3.TabIndex = 2;
                btnEtape1Supprimer3.Tag = i;
                btnEtape1Supprimer3.Text = "Supprimer";
                btnEtape1Supprimer3.UseVisualStyleBackColor = true;
                btnEtape1Supprimer3.Click += new EventHandler(btnEtape1Supprimer3_Click);
                btnEtape1Supprimer3.Cursor = Cursors.Hand;


                i += 50;



            }
        }
        private void btnEtape1Supprimer3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            foreach (Label lbl in grpEtape1IngredientsSelectionne.Controls.OfType<Label>())
            {
                if ((int)lbl.Tag == (int)btn.Tag)
                {
                    //grpEtape1IngredientsSelectionne.Controls.Remove(lbl);
                    Elements.Remove(lbl.Text);

                    remplireEtape1ElementsSelectionnes(sender, e);
                    foreach (CheckBox chkingredient in grpEtape1Ingredients.Controls.OfType<CheckBox>())
                    {
                        if (chkingredient.Text == lbl.Text)
                        {
                            chkingredient.Checked = false;

                        }
                    }
                }
            }

        }
        private void pcbEtape1Suivant_Click(object sender, EventArgs e)
        {

         
                pnlEtape1.Visible = false;
                pnlEtape2.Visible = true;
    
        }

        private void pcbEtape2Retour_Click(object sender, EventArgs e)
        {
            pnlEtape2.Visible = false;
            pnlEtape1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblEtape2TypeDePlat1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void remplireEtape2TypeDePlat()
        {
            int i = 0;
            int n = 0;
            int x = 360;
            int y = 40;
            foreach (DataRow row in monDs.Tables["mesCatégories"].Rows)
            {
                RadioButton lbl = new RadioButton();

                pnlEtape2.Controls.Add(lbl);
                grpEtape2TypePlat.Controls.Add(lbl);

                lbl.AutoSize = true;
                lbl.Location = new System.Drawing.Point(55 + (i % 3) * x, 37 + (n % 4) * y);
                lbl.Name = "lblEtape2TypeDePlat";
                lbl.Size = new System.Drawing.Size(113, 35);
                lbl.TabIndex = 0;
                lbl.TabStop = true;
                lbl.TabIndex = (int)row[0];
                lbl.Tag = (int)row[0];
                lbl.Text = row[1].ToString();
                lbl.UseVisualStyleBackColor = true;
                lbl.Cursor = Cursors.Hand;
                //lbl.CheckedChanged += new System.EventHandler(this.lblEtape2TypeDePlat1_CheckedChanged);
                i++;
                n++;
            }
        }

        private void txtEtape2TempsCuisson_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEtape2TempsCuisson_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 44 && e.KeyChar != 46 && e.KeyChar != 8 && e.KeyChar != 45 && e.Handled == false || (char)e.KeyChar == '²' || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }

        private void pcbEtape2Suivant_Click(object sender, EventArgs e)
        {
            int tempscuisson = 0;
            int budget = 0;
            string typedeplat = "";
            if (!string.IsNullOrEmpty(txtEtape2TempsCuisson.Text))
            {
                if (int.Parse(txtEtape2TempsCuisson.Text) >= 0)
                {
                    tempscuisson = int.Parse(txtEtape2TempsCuisson.Text);
                }
            }
            foreach (RadioButton rdb in grpEtape2Prix.Controls.OfType<RadioButton>())
            {
                if (rdb.Checked)
                {
                    budget = int.Parse((string)rdb.Tag);
                }
            }

            bool flag = false;
            foreach (RadioButton rdb in grpEtape2TypePlat.Controls.OfType<RadioButton>())
            {
                if (rdb.Checked)
                {
                    //flag = true;
                    typedeplat = rdb.Text;
                }
            }

            frmResultat frm = new frmResultat(Elements, typedeplat, budget, tempscuisson);
            frm.ShowDialog();



            /*
      }
      if(flag==false)
      {
           MessageBox.Show("Veuillez selectionner un type de plat");
      }
       if (flag)
       {

       }*/


        }

        private void btnEtape2Reintialiser_Click(object sender, EventArgs e)
        {
            foreach(RadioButton rb in grpEtape2Prix.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
            foreach(RadioButton rb in grpEtape2TypePlat.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
            txtEtape2TempsCuisson.Text = "";
        }

        private void btnEtape0Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblfrm1Etape0Fermer_Click(object sender, EventArgs e)
        {

        }
    }
}
