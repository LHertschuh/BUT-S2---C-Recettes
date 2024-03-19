using PdfSharp.Drawing;
using PdfSharp.Pdf;
using SAE_2._04.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UsersControlsRecettes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using ToolTip = System.Windows.Forms.ToolTip;

namespace SAE_2._04
{
    public partial class frmResultat : Form
    {


        private UsersControlsRecettes.ucPetiteRecette ucpetiterecette;
        private UsersControlsRecettes.ucEtapeSimple ucetapesimple;
        private UsersControlsRecettes.ucEtapeSimple ucetapesimple1;
        private UsersControlsRecettes.ucEtapeDecoupe ucEtapeDecoupe1;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        List<String> Elements = new List<String>();
        String typedeplat;
        int budget;
        int tempsdecuisson;
        String chcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./baseFrigov2023.mdb";
        OleDbConnection connec = new OleDbConnection();
        DataSet monDs = new DataSet();
        DataRow row = null;
        public frmResultat()
        {
            InitializeComponent();
        }

        public frmResultat(List<String> elem, String type, int budgt, int tpscuisson)
        {
            connec.ConnectionString = chcon;
            foreach (String element in elem)
            {
                Elements.Add(element);
            }
            typedeplat = type;
            budget = budgt;
            tempsdecuisson = tpscuisson;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connec.Open();
     //       MessageBox.Show(recetteSQL(0));
       //     MessageBox.Show(recetteSQL(1));
            OleDbDataAdapter da = new OleDbDataAdapter(recetteSQL(0), connec);
             dt = new DataTable();
            da.Fill(dt);
           

            OleDbDataAdapter da2 = new OleDbDataAdapter(recetteSQL(1), connec);
            dt2 = new DataTable();
            da2.Fill(dt2);

            RemplissageUserControl();
            connec.Close();
                


        }
        private void btnResultatQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }

        private void RemplissageUserControl()
        {
            List<int> recettes = new List<int>();
            int x = 20;
            int y = 50;
            int i = 0;
            pblForm2recettes.Visible = true;
           // MessageBox.Show(dt.Rows.Count.ToString());
            if (dt.Rows.Count != 0)
            {
                pblForm2recettes.Controls.Remove(lblForm2Rien);
            }
            foreach (DataRow row in dt.Rows)
            {
                recettes.Add((int)row[0]);
                i++;
                ucpetiterecette = new UsersControlsRecettes.ucPetiteRecette();
                ucpetiterecette.RecetteAfficherClick += recette_Click;
                ucpetiterecette.PdfClick += pdf_Click;
                //   ucpetiterecette.PictureBox1Clicked += recette_Click;
                ucpetiterecette.LabelNomRecette = row[1].ToString();
                ucpetiterecette.Tag = row[0];
                ucpetiterecette.LabelTemps = row[3].ToString() + " min";
                int index = imgListe.Images.IndexOfKey((string)row[4]);
                if (index != -1)
                {
                    ucpetiterecette.PictureBoxImage = imgListe.Images[index];
                }
                else
                {
                    index = imgListe.Images.IndexOfKey("cuisine.png");
                    if (index != -1)
                    {
                        ucpetiterecette.PictureBoxImage = imgListe.Images[index];
                    }
                }
                if ((int)row[5] == 1)
                {
                    ucpetiterecette.LabelCout = "Economique";
                }
                if ((int)row[5] == 2)
                {
                    ucpetiterecette.LabelCout = "Accessible";
                }
                if ((int)row[5] == 3)
                {
                    ucpetiterecette.LabelCout = "Couteux";
                }
                ucpetiterecette.Location = new Point(x, y);
                if (row[6].ToString() != "NULL")
                {
                    ucpetiterecette.TooltipText=row[6].ToString();
                }
                if (i % 5 == 0)
                {
                    y += 360;
                    x = 20;
                }
                else
                {
                    x += 250;
                }
               // MessageBox.Show(x.ToString());
                //ucpetiterecette.PcbRecette = imgListe.Images[3];
                Controls.Add(ucpetiterecette);
                pblForm2recettes.Controls.Add(ucpetiterecette);
            }

           
            if (i%6!=0)
            {
              y += 360;
            }
            else
            {
                y += 80;
            }
            x = 20;
            i = 0;
            Label lblForm2IngrePlaire = new Label();

            lblForm2IngrePlaire.AutoSize = true;
            lblForm2IngrePlaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblForm2IngrePlaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            lblForm2IngrePlaire.Location = new System.Drawing.Point(x, y);
            lblForm2IngrePlaire.Name = "lblForm2IngrePlaire";
            lblForm2IngrePlaire.Size = new System.Drawing.Size(528, 33);
            lblForm2IngrePlaire.TabIndex = 2;
            lblForm2IngrePlaire.Text = "Recettes qui pourraient vous plaire";
            Controls.Add(lblForm2IngrePlaire);
            pblForm2recettes.Controls.Add(lblForm2IngrePlaire);


            y += 40;

            foreach (DataRow row in dt2.Rows)
            {
                if (!recettes.Contains((int)row[0]))
                {
                    i++;
                    ucpetiterecette = new UsersControlsRecettes.ucPetiteRecette();
                    ucpetiterecette.LabelNomRecette = row[1].ToString();
                    ucpetiterecette.RecetteAfficherClick += recette_Click;
                    ucpetiterecette.PdfClick += pdf_Click;
                    ucpetiterecette.LabelTemps = row[3].ToString() + " minutes";
                    ucpetiterecette.Tag = row[0];
                    int index = imgListe.Images.IndexOfKey((string)row[4]);

                    if (index != -1)
                    {
                        ucpetiterecette.PictureBoxImage = imgListe.Images[index];
                    }
                    else
                    {
                        index = imgListe.Images.IndexOfKey("cuisine.png");
                        if (index != -1)
                        {
                            ucpetiterecette.PictureBoxImage = imgListe.Images[index];
                        }
                    }
                    if ((int)row[5] == 1)
                    {
                        ucpetiterecette.LabelCout = "Economique";
                    }
                    if ((int)row[5] == 2)
                    {
                        ucpetiterecette.LabelCout = "Accessible";
                    }
                    if ((int)row[5] == 3)
                    {
                        ucpetiterecette.LabelCout = "Couteux";
                    }
                    ucpetiterecette.Location = new Point(x, y);
                    if (row[6].ToString() != "NULL")
                    {
                        ucpetiterecette.TooltipText = row[6].ToString();
                    }
                    if (i % 6 == 0)
                    {
                        y += 360;
                        x = 20;
                    }
                    else
                    {
                        x += 250;
                    }
                    //ucpetiterecette.PcbRecette = imgListe.Images[3];
                    Controls.Add(ucpetiterecette);
                    pblForm2recettes.Controls.Add(ucpetiterecette);
                }

            }
            if (i == 0)
            {
                pblForm2recettes.Controls.Remove(lblForm2IngrePlaire);
            }


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string recetteSQL(int nm_requte)
        {
            string elem = "";
            string budj = "";
            string type = "";
            string tps = "";
            List<string> ajout = new List<string>();
            int compt = 0;
            
            string requete = @"SELECT DISTINCT Recettes.codeRecette, Recettes.description, Recettes.nbPersonnes, Recettes.tempsCuisson, Recettes.imageDesc, Recettes.categPrix, Recettes.Commentaire
                    FROM     ((((Recettes INNER JOIN
                  IngrédientsRecette ON Recettes.codeRecette = IngrédientsRecette.codeRecette) INNER JOIN
                  Ingrédients ON IngrédientsRecette.codeIngredient = Ingrédients.codeIngredient) INNER JOIN
                  CatégoriesRecette ON Recettes.codeRecette = CatégoriesRecette.codeRecette) INNER JOIN
                  Catégories ON CatégoriesRecette.codeCategorie = Catégories.codeCategorie) ";
            if (tempsdecuisson != 0)
            {
                ajout.Add("(Recettes.tempsCuisson <="+tempsdecuisson+")");
                compt++;
            }
            if (typedeplat != "")
            {
                ajout.Add("(Catégories.libCategorie = '" + typedeplat + "')");
                compt++;
            }
            if(budget != 0)
            {
                
                if (budget == 1)
                {
                    ajout.Add("(Recettes.categPrix = 1)");
                        
                }
                else
                {
                    ajout.Add("(Recettes.categPrix = 1) ");
                    ajout.Add("(Recettes.categPrix = 2) ");
                    compt++;
                }
                compt++;
            }

            for(int i=0;i<Elements.Count;i++)
            {
                //Elements[i] = Elements[i].Replace("'", "'");
            }


            if (Elements.Count() != 0)
            {
                elem = @"(Recettes.codeRecette IN (SELECT IR1.codeRecette FROM (IngrédientsRecette IR1 INNER JOIN Ingrédients I1 ON IR1.codeIngredient = I1.codeIngredient) WHERE   (I1.libIngredient = "+'"'+Elements[0]+'"'+")))";
                int IR = 1;
                foreach (String element in Elements)
                {
                    if (Elements[0] != element)
                    {
                        IR++;
                        if (nm_requte == 0)
                        {
                            elem += " AND ";
                        }
                        else
                        {
                            elem += " OR ";
                        }
                        elem += @"(Recettes.codeRecette IN (SELECT IR"+IR+@".codeRecette FROM (IngrédientsRecette IR"+IR+@" INNER JOIN Ingrédients I"+IR+@" ON IR"+IR+@".codeIngredient = I"+IR+@".codeIngredient) WHERE (I"+IR+@".libIngredient = "+'"'+element+'"'+"))) ";
                    }
                }
                elem += "";
                ajout.Add(elem);
                compt++;
            }

            if (compt != 0)
            {
                requete += " WHERE ";
                requete += ajout[0];
                for(int i = 1; i < ajout.Count(); i++)
                {
                    requete += " AND ";
                    requete += ajout[i];
                }
            }
            requete+= " ORDER BY Recettes.codeRecette";

            return requete;
        }

        private void grpResultAll_Enter(object sender, EventArgs e)
        {

        }

        private void recette_Click(object sender, EventArgs e)
        {
            UsersControlsRecettes.ucPetiteRecette ucpetiterecette = (UsersControlsRecettes.ucPetiteRecette)sender;
            int codeRecette = (int)ucpetiterecette.Tag;
           // MessageBox.Show("AFFICHAGE RECETTE " + ucpetiterecette.Tag);
            DataRow[] rows = dt2.Select("codeRecette = " + codeRecette);
            DataRow row = rows[0];
            //MessageBox.Show(row[1].ToString());

            pblForm2recettes.Visible = false;

            // Supprimer l'instance existante d'ucEtapeSimple s'il y en a une
            if (ucetapesimple1 != null)
            {
                Controls.Remove(ucetapesimple1);
                ucetapesimple1 = null;
            }

            ucetapesimple1 = new UsersControlsRecettes.ucEtapeSimple();
            ucetapesimple1.LabelNomRecette = row[1].ToString();
            ucetapesimple1.Tag = codeRecette;
            ucetapesimple1.LabelPersonne = row[2].ToString() + " personnes";
            int index = imgListe.Images.IndexOfKey((string)row[4]);
            ucetapesimple1.LabelTemps = row[3].ToString() + " minutes";
            if ((int)row[5] == 1)
            {
                ucetapesimple1.LabelCout = "Economique";
            }
            if ((int)row[5] == 2)
            {
                ucetapesimple1.LabelCout = "Accessible";
            }
            if ((int)row[5] == 3)
            {
                ucetapesimple1.LabelCout = "Couteux";
            }
            if (index != -1)
            {
                ucetapesimple1.PictureBoxImage = imgListe.Images[index];
            }
            ucetapesimple1.LabelEtapesRecettes = etapestring(requeteEtapeClassique(codeRecette));
            ucetapesimple1.Location = new Point(130 , 50);
            ucetapesimple1.Name = "ucEtapeSimple";
            ucetapesimple1.RetourClick += button1_Click;
            ucetapesimple1.PdfClick += pdf_Click;
            ucetapesimple1.EtapeClick += etapeUnitaire_Click;
            Controls.Add(ucetapesimple1);

        }
        private DataTable requeteIngredient(int codeRecette)
        {


            string sql = @"SELECT ir.codeIngredient, ir.quantite, ir.unité, libIngredient
                           FROM IngrédientsRecette ir INNER JOIN Ingrédients i ON ir.codeIngredient = i.codeIngredient
                           WHERE codeRecette =" + codeRecette + "";

            connec.Open();
            OleDbDataAdapter da4 = new OleDbDataAdapter(sql, connec);
            DataTable dt4;
            dt4 = new DataTable();
            da4.Fill(dt4);
            connec.Close();


            return dt4;
        }
        private void pdf_Click(object sender, EventArgs e)
        {


            // Initialisation des elemnts a afficher
            string NomRecette;
            string NumEtapeRecette;
            string EtapeRecette;
            string Quantite;
            string Mesure;
            string NomIngredient;
            string Temps;
            string Personnes;

            int codeRecette = 0;
            if (sender is ucPetiteRecette)
            {
                ucPetiteRecette ucpetiterecette = (ucPetiteRecette)sender;
                codeRecette = (int)ucpetiterecette.Tag;
                // Code spécifique à ucPetiteRecette
            }
            else if (sender is ucEtapeSimple)
            {
                ucEtapeSimple ucetapesimple = (ucEtapeSimple)sender;
                codeRecette = (int)ucetapesimple.Tag;
                // Code spécifique à ucEtapeSimple
            }
           // MessageBox.Show("AFFICHAGE RECETTE " + ucpetiterecette.Tag);

            DataRow[] rowsNom = dt2.Select("codeRecette = " + codeRecette);
            DataRow rowNom = rowsNom[0];
            NomRecette = rowNom[1].ToString();

            DataRow[] rowsNomT = dt2.Select("codeRecette = " + codeRecette);
            DataRow rowNomT = rowsNomT[0];
            Temps = rowNomT[1].ToString();

            DataRow[] rowsNomP = dt2.Select("codeRecette = " + codeRecette);
            DataRow rowNomP = rowsNomP[0];
            Personnes = rowNomP[1].ToString();


            DataTable dt3 = requeteEtapeClassique(codeRecette);
            DataTable dt4 = requeteIngredient(codeRecette);


            // Creation d' un nouveau document PDF
            PdfDocument document = new PdfDocument();

            // Ajout d'une page au document
            PdfPage page = document.AddPage();

            // Obtention du graphique de la page
            XGraphics gfx = XGraphics.FromPdfPage(page);


            // choix de la police et de la taille
            XFont fontNomRecette = new XFont("Arial", 24);
            XFont fontNumEtapeRecette = new XFont("Arial", 14);
            XFont fontEtapeRecette = new XFont("Arial", 14);
            XFont fontIngredient = new XFont("Arial", 13, XFontStyle.Italic);
            XFont fontTempsPersonne = new XFont("Arial", 15);
            XFont fontPrenom = new XFont("Arial", 10);



            //ajout de l'image de la recette

            DataRow[] rowsNomImage = dt2.Select("codeRecette = " + codeRecette);
            DataRow rowNomImage = rowsNomImage[0];
            string NomImage = rowNomImage[4].ToString();


            XImage image = XImage.FromFile("../../Images/" + NomImage);

            // Dessinez l'image sur la page PDF
            gfx.DrawImage(image, new XRect(50, 25, 135, 135));


            //ajout des textes sur la page

            //ajout du nom de la recette
            gfx.DrawString(NomRecette, fontNomRecette, XBrushes.DarkRed,
                new XRect(60, -320, page.Width, page.Height),
                XStringFormats.Center);
            int taille_haut = -230;
            int taille_gauche = 50;

            foreach (DataRow ligne in dt3.Rows)
            {
                NumEtapeRecette = "Etape " + ligne[1];
                gfx.DrawString(NumEtapeRecette, fontNumEtapeRecette, XBrushes.OrangeRed,
                    new XRect(taille_gauche, taille_haut, page.Width, page.Height),
                    XStringFormats.CenterLeft);
                taille_haut += 20;

                EtapeRecette = ligne[2].ToString();

                int positionDepart = 0;
                int tailleMax = 80;
                if (EtapeRecette.Length > tailleMax)
                {
                    while (positionDepart < EtapeRecette.Length)
                    {
                        int longueurRestante = EtapeRecette.Length - positionDepart;
                        int longueurAffichee = Math.Min(tailleMax, longueurRestante);

                        if (longueurAffichee < longueurRestante)
                        {
                            int dernierEspace = EtapeRecette.LastIndexOf(' ', positionDepart + longueurAffichee);
                            if (dernierEspace != -1 && dernierEspace > positionDepart)
                            {
                                longueurAffichee = dernierEspace - positionDepart + 1;
                            }
                            else
                            {
                                int prochainEspace = EtapeRecette.IndexOf(' ', positionDepart + longueurAffichee);
                                if (prochainEspace != -1 && prochainEspace > positionDepart)
                                {
                                    longueurAffichee = prochainEspace - positionDepart + 1;
                                }
                            }
                        }

                        string sousEtapeRecette = EtapeRecette.Substring(positionDepart, longueurAffichee);
                        positionDepart += longueurAffichee;

                        gfx.DrawString(sousEtapeRecette, fontEtapeRecette, XBrushes.Black,
                            new XRect(taille_gauche, taille_haut, page.Width, page.Height),
                            XStringFormats.CenterLeft);
                        taille_haut += 20;
                    }


                }
                else
                {
                    gfx.DrawString(EtapeRecette, fontEtapeRecette, XBrushes.Black,
                    new XRect(taille_gauche, taille_haut, page.Width, page.Height),
                    XStringFormats.CenterLeft);
                    taille_haut += 20;
                }
                taille_haut += 20;

            }

            // ajout des ingredients

            foreach (DataRow ligne in dt4.Rows)
            {
                Quantite = ligne[1].ToString();
                Mesure = ligne[2].ToString();
                NomIngredient = ligne[3].ToString();
                gfx.DrawString($"{Quantite} {Mesure} {NomIngredient}", fontIngredient, XBrushes.Gray,
                    new XRect(taille_gauche, taille_haut, page.Width, page.Height),
                    XStringFormats.CenterLeft);
                taille_haut += 20;
            }

            // ajout temps et nb personnes

            Temps = rowNomT[3].ToString();
            Personnes = rowNomP[2].ToString();
            gfx.DrawString($"Temps : {Temps} minutes", fontTempsPersonne, XBrushes.OrangeRed,
            new XRect(400, 330, page.Width, page.Height),
            XStringFormats.CenterLeft);
            taille_haut += 20;
            gfx.DrawString($"Nombre personnes : {Personnes}", fontTempsPersonne, XBrushes.OrangeRed,
            new XRect(400, 300, page.Width, page.Height),
            XStringFormats.CenterLeft);
            taille_haut += 20;


            // ajout de nos noms
            gfx.DrawString("Realisé par : Hertschuh Louis et Guillemain Mathilde", fontPrenom, XBrushes.LightCoral,
            new XRect(200, 400, page.Width, page.Height),
            XStringFormats.CenterLeft);


            // Enregistrement du document PDF
            document.Save(".\\monPDF.pdf");


            // Close du document
            document.Close();

            //MessageBox.Show("PDF généré avec succès !");

            // ouverture directe du pdf
            Process.Start(".\\monPDF.pdf");
        }
            private void button1_Click(object sender, EventArgs e)
        {
            if (ucetapesimple1 != null)
            {
                Controls.Remove(ucetapesimple1);
                ucetapesimple1 = null;
            }
            pblForm2recettes.Visible = true;
        }

        private DataTable requeteEtapeClassique(int codeRecette)
        {
            //String res = "";

            string sql = "SELECT * FROM EtapesRecette WHERE codeRecette =" + codeRecette + " ORDER BY numEtape";

            connec.Open();
            OleDbDataAdapter da3 = new OleDbDataAdapter(sql, connec);
            DataTable dt3;
            dt3 = new DataTable();
            da3.Fill(dt3);
            connec.Close();


            return dt3;
        }

        private string etapestring(DataTable dataTable)
        {
            string res = "";


            foreach(DataRow row in dataTable.Rows)
            {
                res += "Etape " + row[1] + " \n";
                res += "\t " + row[2] + "\n";
                res += "\n";
            }

            return res;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }


        /////////////////////////////////////////BINDING SOURCE/////////////////////////////
        ///

        private void RetourEtapeNormal(object sender, EventArgs e)
        {

            if (ucEtapeDecoupe1 != null)
            {
                Controls.Remove(ucEtapeDecoupe1);
                ucEtapeDecoupe1 = null;
            }
            ucetapesimple1.Visible = true;

        }
        BindingSource bs_bindingSource = new BindingSource();
        private void etapeUnitaire_Click(object sender, EventArgs e)
        {
            ucEtapeSimple ucetapesimple = (ucEtapeSimple)sender;
            int codeRecette = (int)ucetapesimple.Tag;

           
            bs_bindingSource.DataSource = requeteEtapeClassique(codeRecette);

            if (ucEtapeDecoupe1 != null)
            {
                Controls.Remove(ucEtapeDecoupe1);
                ucEtapeDecoupe1 = null;
            }

            ucEtapeDecoupe1 = new UsersControlsRecettes.ucEtapeDecoupe();

            ucEtapeDecoupe1.Tag = (int)0;
            ucEtapeDecoupe1.LabelNomRecette = "Tagliattelles aux crevettes\r\net crème coco";
            ucEtapeDecoupe1.Location = new System.Drawing.Point(250, 80);
            ucEtapeDecoupe1.LabelEtapesRecettes = "Etape";
            ucetapesimple1.Visible = false;
            ucEtapeDecoupe1.AvantClick += afficherEtapeSuivante;
            Controls.Add(ucEtapeDecoupe1);
            ucEtapeDecoupe1.Name = "ucEtapeDecoupe1";
            // ucEtapeDecoupe1.PictureBoxImage =
            ucEtapeDecoupe1.RetourClick += RetourEtapeNormal;
            ucEtapeDecoupe1.ArriereClick += afficherEtapePrec;
            DataRowView currentStep = (DataRowView)bs_bindingSource[0];
            string numeroEtape = currentStep["numEtape"].ToString();
            string etape = currentStep["texteEtape"].ToString();
            ucEtapeDecoupe1.LabelEtapesRecettes = "Étape " + numeroEtape + ": " + etape;

        }
        private void afficherEtapeSuivante(object sender, EventArgs e)
        {
            
            if ((int)ucEtapeDecoupe1.Tag < bs_bindingSource.Count-1)
            {
                ucEtapeDecoupe1.Tag = ((int)ucEtapeDecoupe1.Tag) + 1;
                DataRowView currentStep = (DataRowView)bs_bindingSource[(int)ucEtapeDecoupe1.Tag];
                string numeroEtape = currentStep["numEtape"].ToString();
                string etape = currentStep["texteEtape"].ToString();
                string nomImage = currentStep["imageEtape"].ToString();
                // Afficher l'étape sur le label
                ucEtapeDecoupe1.LabelNomEtape = "Étape " + numeroEtape;
                ucEtapeDecoupe1.LabelEtapesRecettes = etape;

                int index = imgListe.Images.IndexOfKey(nomImage);

                if (index != -1)
                {
                    ucEtapeDecoupe1.PictureBoxImage = imgListe.Images[index];
                }
                // Passer à l'étape suivante
            }
            else
            {
                // Toutes les étapes ont été affichées
                ucEtapeDecoupe1.LabelEtapesRecettes = "Savourez votre repas!";
                ucEtapeDecoupe1.LabelNomEtape = "Bonne dégustation!";
                int index = imgListe.Images.IndexOfKey("img_508740.png");
                if (index != -1)
                {
                    ucEtapeDecoupe1.PictureBoxImage = imgListe.Images[index];
                }
            }
      //      MessageBox.Show((ucEtapeDecoupe1.Tag.ToString()));
        }

        private void afficherEtapePrec(object sender, EventArgs e)
        {
            
            if (((int)ucEtapeDecoupe1.Tag) > 0)
            {
                ucEtapeDecoupe1.Tag = ((int)ucEtapeDecoupe1.Tag) - 1; // Revenir à l'étape précédente

                DataRowView previousStep = (DataRowView)bs_bindingSource[(int)ucEtapeDecoupe1.Tag];
                string numeroEtape = previousStep["numEtape"].ToString();
                string etape = previousStep["texteEtape"].ToString();
                string nomImage = previousStep["imageEtape"].ToString();

                // Afficher l'étape précédente sur le label
                ucEtapeDecoupe1.LabelNomEtape = "Étape " + numeroEtape;
                ucEtapeDecoupe1.LabelEtapesRecettes = etape;
                int index = imgListe.Images.IndexOfKey(nomImage);

                if (index != -1)
                {
                    ucEtapeDecoupe1.PictureBoxImage = imgListe.Images[index];
                }
            }
            //MessageBox.Show((ucEtapeDecoupe1.Tag.ToString()));
        }






    }
}
