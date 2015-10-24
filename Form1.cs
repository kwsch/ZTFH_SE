using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ZTFH_SE
{
    public partial class Form1 : Form
    {
        #region Edit Bytes
        private string[] Editables =
        {
            "0x230 Lady's Glasses (Key Item)",
            "0x231 Lady's Collar (Key Item)",
            "0x232 Lady's Parasol (Key Item)",
            "0x233 Frilly Fabric",
            "0x234 Friendly Token",
            "0x235 Freebie",
            "0x236 Blob Jelly",
            "0x237 Armos Spirit",
            "0x238 Tektite Shell",
            "0x239 Sweet Shroom",
            "0x23A Blin Bling",
            "0x23B Ghoma's Eye",
            "0x23C Mystery Jade",
            "0x23D Supple Leaf",
            "0x23E Fresh Kelp",
            "0x23F Zora Scale",
            "0x240 Hytopian Silk",
            "0x241 Aqua Crown",
            "0x242 Octorok Sucker",
            "0x243 Fairy Dust",
            "0x244 Rainbow Coral",
            "0x245 Thornberry",
            "0x246 Goron Ore",
            "0x247 Monster Guts",
            "0x248 Demon Fossil",
            "0x249 Rugged Horn",
            "0x24A Kodongo Tail",
            "0x24B Keese Wing",
            "0x24C Star Fragment",
            "0x24D Divine Whiskers",
            "0x24E Fluffy Fuzz",
            "0x24F Tiny Snowflake",
            "0x250 Serpent Fangs",
            "0x251 Crimson Shell",
            "0x252 Freezard Water",
            "0x253 Chill Stone",
            "0x254 Ice Rose",
            "0x255 Beastie Patch",
            "0x256 Stiff Puff",
            "0x257 Silver Thread",
            "0x258 Royal Ring",
            "0x259 Antique Coin",
            "0x25A Fancy Fabric",
            "0x25B Exquisite Lace",
            "0x25C Vibrant Brooch",
            "0x25D Brittle Papyrus",
            "0x25E Palm Cone",
            "0x25F Ancient Fin",
            "0x260 Vintage Linen",
            "0x261 Gibdo Bandage",
            "0x262 Stal Skull",
            "0x263 Sandy Ribbon",
            "0x264 Crystal Skull",
            "0x265 Golden Insect",
            "0x266 Carrumpkin",
            "0x267 Mystery Extract",
            "0x268 Spider Silk Lace",
            "0x269 Poe Soul",
            "0x26A Twisted Twig",
            "0x26B Lava Drop",
            "0x26C Sanctuary Mask",
            "0x26D Gold Dust",
            "0x26E Cucco Feathers",
            "0x26F Carmine Pearl",
            "0x270 Sky Dragon Tail",
            "0x271 Pretty Plum",
            "0x272 Mock Fairy",
            "0x273 Aurora Stone",
            "0x274 Steel Mask",
            "0x275 Fabled Butteryfly",
        };
        #endregion

        private SAV sav = new SAV(new byte[SAV.SIZE]);
        public Form1()
        {
            InitializeComponent();
            DragEnter += tabMain_DragEnter;
            DragDrop += tabMain_DragDrop;

            // Assemble items to edit
            CB_Info.ValueMember = "Value";
            CB_Info.DisplayMember = "Text";
            CB_Info.DataSource = (from t in Editables
                let val = t.Split(' ')[0].Replace("0x", "")
                select new cbItem
                {
                    Value = Convert.ToInt32(val, 16), 
                    Text = t.Substring(val.Length + 3),
                }).OrderBy(d => d.Text).ToArray();
        }
        // Drag & Drop Events
        private void tabMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void tabMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string path = files[0]; // open first D&D
            openQuick(path);
        }

        private void Menu_Save_Click(object sender, EventArgs e)
        {
            setItem();
            sav.Rupees = (ushort)NUD_Rupees.Value;
            sav.PlayerName = TB_PlayerName.Text;
            byte[] data = sav.Write();

            SaveFileDialog sfd = new SaveFileDialog
            {
                FileName = "SaveData.bin",
                Filter = "BIN File|*.bin" +
                         "|All Files|*.*"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            string path = sfd.FileName;
            
            File.WriteAllBytes(path, data);

            Alert("Saved SAV to:" + Environment.NewLine + path);
        }
        private void Menu_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                FileName = "SaveData.bin",
                Filter = "BIN File|*.bin" +
                         "|All Files|*.*"
            };

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            openQuick(ofd.FileName);
        }
        private void Menu_About_Click(object sender, EventArgs e)
        {
            Alert("ZTFH_SE, by Kaphotics");
        }
        private void Menu_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void openQuick(string path)
        {
            byte[] data = File.ReadAllBytes(path);
            if (data.Length != SAV.SIZE)
            {
                Error("Invalid file size!", 
                    String.Format("File size was 0x{0} bytes.", data.Length.ToString("X")));
                return;
            }

            sav = new SAV(data);

            NUD_Rupees.Value = sav.Rupees;
            TB_PlayerName.Text = sav.PlayerName;
            offset = -1;
            CB_Info.SelectedIndex = 0;
            getItem();
            GB_Save.Enabled = Menu_Save.Enabled = Menu_Tools.Enabled = true;
        }
        private int offset = -1;
        private void changeItem(object sender, EventArgs e)
        {
            setItem();
            getItem();
        }
        private void setItem()
        {
            if (offset == -1)
                return;
            sav.Data[offset] = (byte)NUD_Value.Value;
        }
        private void getItem()
        {
            offset = getIndex(CB_Info);
            NUD_Value.Value = sav.Data[offset];
        }

        private void Menu_GiveAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CB_Info.Items.Count; i++)
            {
                CB_Info.SelectedIndex = i;
                if (!CB_Info.Text.Contains("Key Item"))
                    NUD_Value.Value = NUD_Value.Maximum;
            }
            Alert("All Items have been set to 99 quantity.", "Key item counts have not been altered.");
        }
        private void Menu_RemoveAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CB_Info.Items.Count; i++)
            {
                CB_Info.SelectedIndex = i;
                if (!CB_Info.Text.Contains("Key Item"))
                    NUD_Value.Value = NUD_Value.Minimum;
            }
            Alert("All Items have been set to 99 quantity.", "Key item counts have not been altered.");
        }

        // Utility
        public class cbItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
        }
        internal static int getIndex(ComboBox cb)
        {
            int val;
            if (cb.SelectedValue == null) return 0;

            try { val = int.Parse(cb.SelectedValue.ToString()); }
            catch { val = cb.SelectedIndex; if (val < 0) val = 0; }

            return val;
        }
        // Message Displays
        internal static DialogResult Error(params string[] lines)
        {
            System.Media.SystemSounds.Exclamation.Play();
            string msg = String.Join(Environment.NewLine + Environment.NewLine, lines);
            return MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        internal static DialogResult Alert(params string[] lines)
        {
            System.Media.SystemSounds.Asterisk.Play();
            string msg = String.Join(Environment.NewLine + Environment.NewLine, lines);
            return MessageBox.Show(msg, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        internal static DialogResult Prompt(MessageBoxButtons btn, params string[] lines)
        {
            System.Media.SystemSounds.Question.Play();
            string msg = String.Join(Environment.NewLine + Environment.NewLine, lines);
            return MessageBox.Show(msg, "Prompt", btn, MessageBoxIcon.Asterisk);
        }
    }
}
