using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Player : Character_Spec 
{
    Item[] t_items = new Item[2];

    
    public uint levelUp()
    {
        m_Level += 1;
        return 0;
    }
    public uint AddAt(Weapon _item)
    {
        return m_At + _item.At;
    }
    public uint AddDef(Armor _item)
    {
        return m_Def + _item.Def;
    }

    public override string UserName
    {
        get { return m_UserName; }
        set { m_UserName = value; }
    }
    public override byte Level
    {
        get { return m_Level; }
        set { m_Level = value; }
    }
    public override uint HPTotal
    {
        get { return m_HPTotal = (m_HPHead + m_HPBody + m_HPArms + m_HPLegs); }
        set { HPTotal = value; }
    }
    public override uint HPMax
    {
        get { return m_HPMax; }
        set { m_HPMax = value; }
    }
    public Item[] HaveItems
    {
        get
        {
            return t_items;
        }
    }

}



class Monster : Character_Spec
{

}
