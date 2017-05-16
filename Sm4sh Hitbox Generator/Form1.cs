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
                //Basic params
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
                    _kbg = 0;
                }
                string _size = size.Text;
                string _z = z.Text;
                string _y = y.Text;
                string _x = x.Text;
                setEffect();
                string _trip = trip.Text;
                string _hitlag = hitlag.Text;
                string _sdi = sdi.Text;
                int _rebound = Int32.Parse(rebound.Text);
                int _clang = Int32.Parse(clang.Text);
                int _shielddamage = Int32.Parse(shielddamage.Text);
                int _sfxtype = Int32.Parse(sfxtype.Text);
                int _sfxid = Int32.Parse(sfxid.Text);
                int _groundair = 0;
                if (groundair.Text == "Ground Only")
                {
                    _groundair = 1;
                }
                if (groundair.Text == "Air Only")
                {
                    _groundair = 2;
                }
                int _directindirect = 0;
                if (directindirect.Text == "Indirect Attack")
                {
                    _directindirect = 1;
                }
                int _type = Int32.Parse(type.Text);

                //Generate Hitbox & get other params
                if (hitboxtype.Text == "Hitbox")
                {
                    //Hitbox gen
                    output.Text = output.Text + "Hitbox(ID=0x" + _id.ToString("X") + ", Part=0x" + _part.ToString("X") + ", Bone=0x" + _bone.ToString("X") + ", Damage=" + _damage + ", Angle=0x" + _angle.ToString("X") + ", KBG=0x" + _kbg.ToString("X") + ", FKB=0x" + _fkb.ToString("X") + ", BKB=0x" + _bkb.ToString("X") + ", Size=" + _size + ", Z=" + _z + ", Y=" + _y + ", X=" + _x + ", Effect=0x" + _effect.ToString("X") + ", Trip=" + _trip + ", Hitlag=" + _hitlag + ", SDI=" + _sdi + ", Clang=0x" + _clang.ToString("X") + ", Rebound=0x" + _rebound.ToString("X") + ", ShieldDamage=0x" + _shielddamage.ToString("X") + ", SFXType=0x" + _sfxtype.ToString("X") + ", SFXID=0x" + _sfxid.ToString("X") + ", Ground/Air=0x" + _groundair.ToString("X") + ", Direct/Indirect=0x" + _directindirect.ToString("X") + ", Type=0x" + _type.ToString("X") + ")\n";
                }

                if (hitboxtype.Text == "Special Hitbox")
                {
                    //Additional params
                    int _blockable = 0;
                    int _reflectable = 0;
                    int _absorbable = 0;
                    int _rehit_rate = Int32.Parse(rehitrate.Text);
                    int _piercing = 0;
                    int _reversable = 0;
                    int _grippy = 0;
                    int _friendly_fire = 0;
                    int _hitlag_disable = 0;
                    int _gfx_disable = 0;
                    int _flinchless = 0;
                    if (blockable.Checked == true)
                    {
                        _blockable = 1;
                    }
                    if (reflectable.Checked == true)
                    {
                        _reflectable = 1;
                    }
                    if (absorbable.Checked == true)
                    {
                        _absorbable = 1;
                    }
                    if (piercing.Checked == true)
                    {
                        _piercing = 1;
                    }
                    if (grippy.Checked == true)
                    {
                        _grippy = 1;
                    }
                    if (friendlyfire.Checked == true)
                    {
                        _friendly_fire = 1;
                    }
                    if (hitlagdisable.Checked == true)
                    {
                        _hitlag_disable = 1;
                    }
                    if (gfxdisable.Checked == true)
                    {
                        _gfx_disable = 1;
                    }
                    if (flinchless.Checked == true)
                    {
                        _flinchless = 1;
                    }

                    //Hitbox gen

                    if (specialhitbox2.Checked == false)
                    {
                        output.Text = output.Text + "Special_Hitbox(ID=0x" + _id.ToString("X") + ", Part=0x" + _part.ToString("X") + ", Bone=0x" + _bone.ToString("X") + ", Damage=" + _damage + ", Angle=0x" + _angle.ToString("X") + ", KBG=0x" + _kbg.ToString("X") + ", FKB=0x" + _fkb.ToString("X") + ", BKB=0x" + _bkb.ToString("X") + ", Size=" + _size + ", Z=" + _z + ", Y=" + _y + ", X=" + _x + ", Effect=0x" + _effect.ToString("X") + ", Trip=" + _trip + ", Hitlag=" + _hitlag + ", SDI=" + _sdi + ", Clang=0x" + _clang.ToString("X") + ", Rebound=0x" + _rebound.ToString("X") + ", ShieldDamage=0x" + _shielddamage.ToString("X") + ", SFXType=0x" + _sfxtype.ToString("X") + ", SFXID=0x" + _sfxid.ToString("X") + ", Ground/Air=0x" + _groundair.ToString("X") + ", Direct/Indirect=0x" + _directindirect.ToString("X") + ", Type=0x" + _type.ToString("X") + ", Unknown=0x0, Unknown=0x0, Unknown=0x0, Unknown=0x0, Blockable=0x" + _blockable.ToString("X") + ", Reflectable=0x" + _reflectable.ToString("X") + ", Absorbable=0x" + _absorbable.ToString("X") + ", Rehit_Rate=0x" + _rehit_rate.ToString("X") + ", Piercing=0x" + _piercing.ToString("X") + ", Unknown=0x0, Reversable=0x" + _reversable.ToString("X") + ", Grippy=0x" + _grippy.ToString("X") + ", Friendly_Fire=0x" + _friendly_fire.ToString("X") + ", Hitlag_Disable=0x" + _hitlag_disable.ToString("X") + ", GFX_Disable=0x" + _gfx_disable.ToString("X") + ", Flinchless=0x" + _flinchless.ToString("X") + ", Unknown=0x0)\n";
                    }
                    if (specialhitbox2.Checked == true)
                    {
                        output.Text = output.Text + "Special_Hitbox2(ID=0x" + _id.ToString("X") + ", Part=0x" + _part.ToString("X") + ", Bone=0x" + _bone.ToString("X") + ", Damage=" + _damage + ", Angle=0x" + _angle.ToString("X") + ", KBG=0x" + _kbg.ToString("X") + ", FKB=0x" + _fkb.ToString("X") + ", BKB=0x" + _bkb.ToString("X") + ", Size=" + _size + ", Z=" + _z + ", Y=" + _y + ", X=" + _x + ", Effect=0x" + _effect.ToString("X") + ", Trip=" + _trip + ", Hitlag=" + _hitlag + ", SDI=" + _sdi + ", Clang=0x" + _clang.ToString("X") + ", Rebound=0x" + _rebound.ToString("X") + ", ShieldDamage=0x" + _shielddamage.ToString("X") + ", SFXType=0x" + _sfxtype.ToString("X") + ", SFXID=0x" + _sfxid.ToString("X") + ", Ground/Air=0x" + _groundair.ToString("X") + ", Direct/Indirect=0x" + _directindirect.ToString("X") + ", Type=0x" + _type.ToString("X") + ", Unknown=0x0, Unknown=0x0, Unknown=0x0, Unknown=0x0, Blockable=0x" + _blockable.ToString("X") + ", Reflectable=0x" + _reflectable.ToString("X") + ", Absorbable=0x" + _absorbable.ToString("X") + ", Rehit_Rate=0x" + _rehit_rate.ToString("X") + ", Piercing=0x" + _piercing.ToString("X") + ", Unknown=0x0, Reversable=0x" + _reversable.ToString("X") + ", Grippy=0x" + _grippy.ToString("X") + ", Friendly_Fire=0x" + _friendly_fire.ToString("X") + ", Hitlag_Disable=0x" + _hitlag_disable.ToString("X") + ", GFX_Disable=0x" + _gfx_disable.ToString("X") + ", Flinchless=0x" + _flinchless.ToString("X") + ", Unknown=0x0)\n";
                    }
                }

                if (hitboxtype.Text == "Extended Hitbox")
                {
                    //Additional params
                    int _xextent = Int32.Parse(xextent.Text);
                    int _yextent = Int32.Parse(yextent.Text);
                    int _zextent = Int32.Parse(zextent.Text);

                    //Hitbox gen
                    output.Text = output.Text + "Extended_Hitbox(ID=0x" + _id.ToString("X") + ", Part=0x" + _part.ToString("X") + ", Bone=0x" + _bone.ToString("X") + ", Damage=" + _damage + ", Angle=0x" + _angle.ToString("X") + ", KBG=0x" + _kbg.ToString("X") + ", FKB=0x" + _fkb.ToString("X") + ", BKB=0x" + _bkb.ToString("X") + ", Size=" + _size + ", Z=" + _z + ", Y=" + _y + ", X=" + _x + ", Effect=0x" + _effect.ToString("X") + ", Trip=" + _trip + ", Hitlag=" + _hitlag + ", SDI=" + _sdi + ", Clang=0x" + _clang.ToString("X") + ", Rebound=0x" + _rebound.ToString("X") + ", ShieldDamage=0x" + _shielddamage.ToString("X") + ", SFXType=0x" + _sfxtype.ToString("X") + ", SFXID=0x" + _sfxid.ToString("X") + ", Ground/Air=0x" + _groundair.ToString("X") + ", Direct/Indirect=0x" + _directindirect.ToString("X") + ", Type=0x" + _type.ToString("X") + ", Z=0x" + _zextent.ToString("X") + ", Y=0x" + _yextent.ToString("X") + ", X=0x" + _xextent.ToString("X") + ")\n";
                }

                if (hitboxtype.Text == "Extended Special Hitbox")
                {
                    //Additional params
                    int _blockable = 0;
                    int _reflectable = 0;
                    int _absorbable = 0;
                    int _rehit_rate = Int32.Parse(rehitrate.Text);
                    int _piercing = 0;
                    int _reversable = 0;
                    int _grippy = 0;
                    int _friendly_fire = 0;
                    int _hitlag_disable = 0;
                    int _gfx_disable = 0;
                    int _flinchless = 0;
                    if (blockable.Checked == true)
                    {
                        _blockable = 1;
                    }
                    if (reflectable.Checked == true)
                    {
                        _reflectable = 1;
                    }
                    if (absorbable.Checked == true)
                    {
                        _absorbable = 1;
                    }
                    if (piercing.Checked == true)
                    {
                        _piercing = 1;
                    }
                    if (grippy.Checked == true)
                    {
                        _grippy = 1;
                    }
                    if (friendlyfire.Checked == true)
                    {
                        _friendly_fire = 1;
                    }
                    if (hitlagdisable.Checked == true)
                    {
                        _hitlag_disable = 1;
                    }
                    if (gfxdisable.Checked == true)
                    {
                        _gfx_disable = 1;
                    }
                    if (flinchless.Checked == true)
                    {
                        _flinchless = 1;
                    }
                    string _xextent = xextent.Text;
                    string _yextent = yextent.Text;
                    string _zextent = zextent.Text;

                    //Hitbox gen
                    output.Text = output.Text + "Extended_Special_Hitbox(ID=0x" + _id.ToString("X") + ", Part=0x" + _part.ToString("X") + ", Bone=0x" + _bone.ToString("X") + ", Damage=" + _damage + ", Angle=0x" + _angle.ToString("X") + ", KBG=0x" + _kbg.ToString("X") + ", FKB=0x" + _fkb.ToString("X") + ", BKB=0x" + _bkb.ToString("X") + ", Size=" + _size + ", Z=" + _z + ", Y=" + _y + ", X=" + _x + ", Effect=0x" + _effect.ToString("X") + ", Trip=" + _trip + ", Hitlag=" + _hitlag + ", SDI=" + _sdi + ", Clang=0x" + _clang.ToString("X") + ", Rebound=0x" + _rebound.ToString("X") + ", ShieldDamage=0x" + _shielddamage.ToString("X") + ", SFXType=0x" + _sfxtype.ToString("X") + ", SFXID=0x" + _sfxid.ToString("X") + ", Ground/Air=0x" + _groundair.ToString("X") + ", Direct/Indirect=0x" + _directindirect.ToString("X") + ", Type=0x" + _type.ToString("X") + ", Unknown=0x0, Unknown=0x0, Unknown=0x0, Unknown=0x0, Blockable=0x" + _blockable.ToString("X") + ", Reflectable=0x" + _reflectable.ToString("X") + ", Absorbable=0x" + _absorbable.ToString("X") + ", Rehit_Rate=0x" + _rehit_rate.ToString("X") + ", Piercing=0x" + _piercing.ToString("X") + ", Unknown=0x0, Reversable=0x" + _reversable.ToString("X") + ", Grippy=0x" + _grippy.ToString("X") + ", Friendly_Fire=0x" + _friendly_fire.ToString("X") + ", Hitlag_Disable=0x" + _hitlag_disable.ToString("X") + ", GFX_Disable=0x" + _gfx_disable.ToString("X") + ", Flinchless=0x" + _flinchless.ToString("X") + ", Z=" + _zextent + ", Y=" + _yextent + ", X=" + _xextent + ")\n";
                }
            }
            catch
            {
                //Error message, duh
                MessageBox.Show("Error: Could not parse values", "Sm4sh HitBox Generator");
            }
        }

        public void setEffect()
        {
            if (effect.Text == "Normal")
            {
                _effect = 0;
            }
            if (effect.Text == "Slash")
            {
                _effect = 2;
            }
            if (effect.Text == "Electric")
            {
                _effect = 3;
            }
            if (effect.Text == "Freezing")
            {
                _effect = 4;
            }
            if (effect.Text == "Flame")
            {
                _effect = 5;
            }
            if (effect.Text == "Coin")
            {
                _effect = 6;
            }
            if (effect.Text == "Reverse")
            {
                _effect = 7;
            }
            if (effect.Text == "Slip")
            {
                _effect = 8;
            }
            if (effect.Text == "Sleep")
            {
                _effect = 9;
            }
            if (effect.Text == "Bury")
            {
                _effect = 11;
            }
            if (effect.Text == "Stun")
            {
                _effect = 12;
            }
            if (effect.Text == "Flower")
            {
                _effect = 14;
            }
            if (effect.Text == "Death (Insta-Kill)")
            {
                _effect = 16;
            }
            if (effect.Text == "Grass (Unused)")
            {
                _effect = 17;
            }
            if (effect.Text == "Water")
            {
                _effect = 18;
            }
            if (effect.Text == "Darkness")
            {
                _effect = 19;
            }
            if (effect.Text == "Paralyze")
            {
                _effect = 20;
            }
            if (effect.Text == "Aura")
            {
                _effect = 21;
            }
            if (effect.Text == "Plunge")
            {
                _effect = 22;
            }
            if (effect.Text == "Down (Unused)")
            {
                _effect = 23;
            }
            if (effect.Text == "Adhension")
            {
                _effect = 24;
                MessageBox.Show("WARNING: The Adhension effect will crash the game if it is set to a normal move!", "Sm4sh Hitbox Generator");
            }
            if (effect.Text == "Stab")
            {
                _effect = 25;
            }
            if (effect.Text == "Magic")
            {
                _effect = 26;
            }
            if (effect.Text == "Flinchless #1")
            {
                _effect = 27;
            }
            if (effect.Text == "Flinchless #2")
            {
                _effect = 28;
            }
            if (effect.Text == "Solar")
            {
                _effect = 29;
            }
            if (effect.Text == "Focus Attack")
            {
                _effect = 30;
            }
            if (effect.Text == "Disable")
            {
                _effect = 31;
            }
            if (effect.Text == "Dragon Lunge")
            {
                _effect = 32;
            }
            if (effect.Text == "Bullet Climax")
            {
                _effect = 36;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            output.Text = "";
        }

        private void hitboxtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Hitbox type testing and stuff
            if (hitboxtype.Text == "Hitbox")
            {
                unihitboxparam.Enabled = true;
                outputcontainer.Enabled = true;
                extendhitboxparam.Enabled = false;
                spechitboxparam.Enabled = false;
            }
            if (hitboxtype.Text == "Special Hitbox")
            {
                unihitboxparam.Enabled = true;
                outputcontainer.Enabled = true;
                extendhitboxparam.Enabled = false;
                spechitboxparam.Enabled = true;
            }
            if (hitboxtype.Text == "Extended Hitbox")
            {
                unihitboxparam.Enabled = true;
                outputcontainer.Enabled = true;
                extendhitboxparam.Enabled = true;
                spechitboxparam.Enabled = false;
            }
            if (hitboxtype.Text == "Extended Special Hitbox")
            {
                unihitboxparam.Enabled = true;
                outputcontainer.Enabled = true;
                extendhitboxparam.Enabled = true;
                spechitboxparam.Enabled = true;
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }
    }
}
