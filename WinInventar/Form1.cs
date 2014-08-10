using System;
using System.Data;
using System.Windows.Forms;

namespace WinInventar
{
    public partial class Form1 : Form
    {
        public int MappingID;
        public DbHandling Inventar;
        public DataTable Inventarkpl;
        public int GattungID;
        public int GruppierungID;
        public string Suchbegriff = "";
        public bool IsAktiv;
        public bool FormInit;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1Load(object sender, EventArgs e)
        {
            MappingID = 0;
            Inventar = new DbHandling("IT_Inventar", "ELITEBOOK\\SQLEXPRESS");
            //Inventar = new DbHandling("IT_Inventar", "192.168.20.18");
            Init();
        }

        private void Init()
        {
            switch (MappingID)
            {
                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                default:
                    Inventarkpl = Inventar.GetviewGeraeteKpl();
                    tabControl1.SelectedIndex = 0;
                    ResetGeraeteFilter();
                    FormInit = true;
                    break;
            }
        }

        private void ResetGeraeteFilter()
        {
            txtGeraet.Text = "";
            chbInaktive.Checked = true;
            ResetcbbGattung();
            ResetcbbGruppierung(0);
            GattungID = 0;
            GruppierungID = 0;
            Suchbegriff = "";
            IsAktiv = true;
            FillTreeView();
        }

        private void ResetcbbGattung()
        {
            cbbGattung.DataSource = null;
            cbbGattung.DataSource = Inventar.GetGattung(0, true);
            cbbGattung.DisplayMember = "Bezeichnung";
            cbbGattung.ValueMember = "ID";
        }

        private void ResetcbbGruppierung(int gattungID)
        {
            cbbGruppierung.DataSource = null;
            cbbGruppierung.DataSource = Inventar.GetGruppierung(gattungID, 0, true);
            cbbGruppierung.DisplayMember = "Bezeichnung";
            cbbGruppierung.ValueMember = "ID";
        }

        private void FillTreeView()
        {
            trvGeraete.Nodes.Clear();
            string trenner = "";
            string filter = "";
            const string sorter = "Gattung, Gruppierung, Bezeichnung";
            if (IsAktiv)
            {
                filter = String.Format("Aktiv=1");
                trenner = " AND ";
            }
            if (GattungID > 0) filter += String.Format("{0}GattungsID={1}", trenner, GattungID);
            if (GruppierungID > 0) filter += String.Format("{0}GruppierungsID={1}", trenner, GruppierungID);
            if (Suchbegriff.Length > 0) filter += String.Format("{0}Bezeichnung like '*{1}*'", trenner, Suchbegriff);
            DataRow[] geraeteTrv = Inventarkpl.Select(filter,sorter);

            var root = new TreeNode("Inventar");
            trvGeraete.Nodes.Add(root);
            root.EnsureVisible();
            root.TreeView.Focus();
            root.TreeView.Select();
            try
            {
                int gattungsID = 0;
                int gruppierungsID = 0;
                TreeNode childRoot = null;
                TreeNode child2Root = null;
                foreach (DataRow rowGeraete in geraeteTrv)
                {
                    if (gattungsID != Convert.ToInt32(rowGeraete["GattungsID"]))
                    {
                        gattungsID = Convert.ToInt32(rowGeraete["GattungsID"]);
                        childRoot = new TreeNode(rowGeraete["Gattung"].ToString());
                        root.Nodes.Add(childRoot);
                        childRoot.ImageIndex = 1;
                        childRoot.SelectedImageIndex = 1;
                        childRoot.Parent.Expand();
                        gruppierungsID = 0;
                    }
                    if (gruppierungsID != Convert.ToInt32(rowGeraete["GruppierungsID"]))
                    {
                        gruppierungsID = Convert.ToInt32(rowGeraete["GruppierungsID"]);
                        child2Root = new TreeNode(rowGeraete["Gruppierung"].ToString());
                        if (childRoot != null)
                        {
                            childRoot.Nodes.Add(child2Root);
                            child2Root.ImageIndex = 1;
                            child2Root.SelectedImageIndex = 1;
                        }
                    }
                    var lastchild = new TreeNode(rowGeraete["Bezeichnung"].ToString());
                    if (child2Root != null) 
                    {
                        child2Root.Nodes.Add(lastchild);
                        lastchild.ImageIndex = 3;
                        lastchild.SelectedImageIndex = 3;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void CbbGattungSelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormInit)
            {
                GattungID = (int) cbbGattung.SelectedValue;
                FormInit = false;
                ResetcbbGruppierung(GattungID);
                GruppierungID = 0;
                FormInit = true;
                FillTreeView();
            }
        }

        private void CbbGruppierungSelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormInit)
            {
                GruppierungID = (int) cbbGruppierung.SelectedValue;
                FillTreeView();
            }
        }

        private void TxtGeraetTextChanged(object sender, EventArgs e)
        {
            if (FormInit)
            {
                Suchbegriff = txtGeraet.Text;
                FillTreeView();
                txtGeraet.Select();
            }
        }

        private void ChbInaktiveCheckedChanged(object sender, EventArgs e)
        {
            if (FormInit)
            {
                IsAktiv = chbInaktive.Checked;
                FillTreeView();
            }
        }

        private void BtnResetInventarFilterClick(object sender, EventArgs e)
        {
            FormInit = false;
            ResetGeraeteFilter();
            FormInit = true;
            FillTreeView();
        }
    }
}
