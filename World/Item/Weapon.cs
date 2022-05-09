using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Weapon : Item
{
    WeaponType m_type;

    public Weapon(uint _At, WeaponType _type)
    {
        switch (_type)
        {
            case WeaponType.SPEAR:
                {
                    m_Name += " 창 ";
                    m_type = WeaponType.SPEAR;
                }
                break;
            case WeaponType.SWORD:
                {
                    m_Name += " 검 ";
                    m_type = WeaponType.SWORD;
                }
                break;
            case WeaponType.KNUCKLE:
                {
                    m_Name += " 너클 ";
                    m_type = WeaponType.KNUCKLE;
                }
                break;
            default:
                m_type = WeaponType.NONE;
                break;
        }

        m_At += _At;
        m_Def += 1;
        m_type = _type;
        m_Durability = 20;
        return;
    }



}
