using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//아이템 기본값
internal class Item
{
    protected string m_Name;

    protected uint m_At;
    protected uint m_Def;
    
    protected uint m_Value;
    protected uint m_Gold;
    protected uint m_Count;

    protected ushort m_Durability;      // 내구도 
    protected ushort m_DurabilityMAX; 

    public string Name
    {
        get { return m_Name; }
    }
    public uint At
    {
        get { return m_At; }
    }
    public uint Def
    {
        get { return m_Def; }
    }
    public ushort Durability
    {
        get { return m_Durability; }
        set { m_Durability = value; }
    }


}

//무기
enum WeaponType
{
    SPEAR,
    SWORD,
    KNUCKLE,
    NONE
}

enum ArmmorType
{
    SHIELD,
    HELMET,
    NONE
}
