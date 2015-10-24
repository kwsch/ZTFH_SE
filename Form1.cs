using System;
using System.Collections.Generic;
using System.IO;
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

            // Assemble items to edit
            CB_Info.ValueMember = "Value";
            CB_Info.DisplayMember = "Text";
            List<object> dataSource = new List<object>();
            foreach (string t in Editables)
            {
                string val = t.Split(' ')[0].Replace("0x", "");
                int value = Convert.ToInt32(val, 16);
                string text = t.Substring(val.Length + 3);
                dataSource.Add(new
                {
                    Value = value,
                    Text = text,
                });
            }
            CB_Info.DataSource = dataSource;
        }

        internal static int getIndex(ComboBox cb)
        {
            int val;
            if (cb.SelectedValue == null) return 0;

            try { val = int.Parse(cb.SelectedValue.ToString()); }
            catch { val = cb.SelectedIndex; if (val < 0) val = 0; }

            return val;
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            setEntry();
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

            MessageBox.Show("Saved SAV to:" + Environment.NewLine + path);
        }
        private void B_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                FileName = "SaveData.bin",
                Filter = "BIN File|*.bin" +
                         "|All Files|*.*"
            };

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            string path = ofd.FileName;

            byte[] data = File.ReadAllBytes(path);
            if (data.Length != SAV.SIZE)
            {
                MessageBox.Show("Invalid file size!");
                return;
            }

            sav = new SAV(data);

            NUD_Rupees.Value = sav.Rupees;
            TB_PlayerName.Text = sav.PlayerName;
            CB_Info.SelectedIndex = 0;
            loadEntry();
            GB_Save.Enabled = B_Save.Enabled = true;
        }

        private int entry = -1;
        private void changeEntry(object sender, EventArgs e)
        {
            setEntry();
            loadEntry();
        }
        private void setEntry()
        {
            if (entry == -1)
                return;
            int offset = getIndex(CB_Info);
            sav.Data[offset] = (byte)NUD_Value.Value;
        }
        private void loadEntry()
        {
            int offset = getIndex(CB_Info);
            NUD_Value.Value = sav.Data[offset];
            entry = CB_Info.SelectedIndex;
        }
    }
}
