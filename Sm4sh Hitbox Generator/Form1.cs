using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sm4sh_Hitbox_Generator
{
    public partial class Form1 : Form
    {
        public int _effect = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            try
            {
                int _id = Int32.Parse(id.Text);
                int _part = Int32.Parse(part.Text);
                int _bone = Int32.Parse(bone.Text);
                int _damage = Int32.Parse(damage.Text);
                int _angle = Int32.Parse(angle.Text);
                int _kbg = Int32.Parse(kbg.Text);
                int _fkb = 0;
                int _bkb = Int32.Parse(bkb.Text);
                if (fkb.Checked)
                {
                    _fkb = Int32.Parse(bkb.Text);
                    _bkb = 0;
                }
                int _size = Int32.Parse(size.Text);
                int _z = Int32.Parse(z.Text);
                int _y = Int32.Parse(y.Text);
                int _x = Int32.Parse(x.Text);
                setEffect();
                int _trip = Int32.Parse(trip.Text);
                int _hitlag = Int32.Parse(hitlag.Text);
                int _sdi = Int32.Parse(sdi.Text);
                int _clang = Int32.Parse(clang.Text);
                int _shielddamage = Int32.Parse(shielddamage.Text);
                int _sfxtype = Int32.Parse(sfxtype.Text);
                int _groundair = 0;
                if (groundair.SelectedText == "Air Attack")
                {
                    _groundair = 1;
                }
                int _directindirect = 0;
                if (directindirect.SelectedText == "Indirect Attack")
                {
                    _directindirect = 1;
                }

                output.Text = output.Text + "Hitbox(ID=0x" + _id.ToString("X") + ", Part=0x" + _part.ToString("X") + ", Bone=0x" + _bone.ToString("X") + ", Damage=" + _damage + ", Angle=0x" + _angle.ToString("X") + ", KBG=0x" + _kbg.ToString("X") + ", FKB=0x" + _fkb.ToString("X") + ", BKB=0x" + _bkb.ToString("X") + ", Size=" + _size + ", Z=" + _z + ", Y=" + _y + ", X=" + _x + ", Effect=0x" + _effect.ToString("X") + ", Trip=" + _trip + ", Hitlag=" + _hitlag + ", SDI=" + _sdi + ", Clang=0x" + _clang.ToString("X") + ", Unknown=0x0, SFXType=0x" + _sfxtype.ToString("X") + ", Ground/Air=0x" + _groundair.ToString("X") + ", Direct/Indirect=0x" + _directindirect.ToString("X") + ", Unknown=0x0, Unknown=0x0)\n";
            }
            catch
            {
                MessageBox.Show("Error: Could not parse values", "Sm4sh HitBox Generator");
            }
        }

        public void setEffect()
        {
            if (effect.SelectedText == "Normal")
            {
                _effect = 0;
            }
            if (effect.SelectedText == "Slash")
            {
                _effect = 2;
            }
            if (effect.SelectedText == "Electric")
            {
                _effect = 3;
            }
            if (effect.SelectedText == "Freezing")
            {
                _effect = 4;
            }
            if (effect.SelectedText == "Flame")
            {
                _effect = 5;
            }
            if (effect.SelectedText == "Coin")
            {
                _effect = 6;
            }
            if (effect.SelectedText == "Reverse")
            {
                _effect = 7;
            }
            if (effect.SelectedText == "Slip")
            {
                _effect = 8;
            }
            if (effect.SelectedText == "Sleep")
            {
                _effect = 9;
            }
            if (effect.SelectedText == "Bury")
            {
                _effect = 11;
            }
            if (effect.SelectedText == "Stun")
            {
                _effect = 12;
            }
            if (effect.SelectedText == "Flower")
            {
                _effect = 14;
            }
            if (effect.SelectedText == "Death (Insta-Kill)")
            {
                _effect = 16;
            }
            if (effect.SelectedText == "Grass (Unused)")
            {
                _effect = 17;
            }
            if (effect.SelectedText == "Water")
            {
                _effect = 18;
            }
            if (effect.SelectedText == "Darkness")
            {
                _effect = 19;
            }
            if (effect.SelectedText == "Paralyze")
            {
                _effect = 20;
            }
            if (effect.SelectedText == "Aura")
            {
                _effect = 21;
            }
            if (effect.SelectedText == "Plunge")
            {
                _effect = 22;
            }
            if (effect.SelectedText == "Down (Unused)")
            {
                _effect = 23;
            }
            if (effect.SelectedText == "Adhension")
            {
                _effect = 24;
                MessageBox.Show("WARNING: The Adhension effect will crash the game if it is set to a normal move!", "Sm4sh Hitbox Generator");
            }
            if (effect.SelectedText == "Stab")
            {
                _effect = 25;
            }
            if (effect.SelectedText == "Magic")
            {
                _effect = 26;
            }
            if (effect.SelectedText == "Flinchless #1")
            {
                _effect = 27;
            }
            if (effect.SelectedText == "Flinchless #2")
            {
                _effect = 28;
            }
            if (effect.SelectedText == "Solar")
            {
                _effect = 29;
            }
            if (effect.SelectedText == "Focus Attack")
            {
                _effect = 30;
            }
            if (effect.SelectedText == "Disable")
            {
                _effect = 31;
            }
            if (effect.SelectedText == "Dragon Lunge")
            {
                _effect = 32;
            }
            if (effect.SelectedText == "Bullet Climax")
            {
                _effect = 36;
            }
        }
    }
}
