using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Armor : Item
{
    ArmmorType m_type;
    public Armor(uint _def, ArmmorType _type)
    {
        switch (_type)
        {
            case ArmmorType.SHIELD:
                {
                    m_Name += " 갑옷 ";
                    m_type = ArmmorType.SHIELD;
                }
                break;
            case ArmmorType.HELMET:
                {
                    m_Name += " 투구 ";
                    m_type = ArmmorType.HELMET;
                }
                break;
            default:
                m_type = ArmmorType.NONE;
                break;
        }

        m_At += 0;
        m_Def += _def;
        m_type = _type;
        m_Durability = 20;
        return;
    }
}
