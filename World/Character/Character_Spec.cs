using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 자료형 byte  :  8bit 0~255
interface Fight
{
    uint levelUp();
    uint AddAt(uint _At);
    uint AddDef(uint _def);
}
class Character_Spec 
{
    //케릭터 생성시 입력되는 필수 속성
    protected string m_UserName;
    protected Item[] m_Item;

    //stat point
    protected uint m_BonusStat;

    protected uint m_Gender;
    protected byte m_Age;



    //외부 영향으로 변경되는 케릭터 속성
    protected byte m_Level;

    protected byte m_Weight;
    protected byte m_WeightMax;

    protected uint m_HPTotal;
    protected uint m_HPMax;
    //
    protected uint m_HPHead;
    protected uint m_HPHeadMax;
    protected uint m_HPBody;
    protected uint m_HPBodyMax;
    protected uint m_HPArms;
    protected uint m_HPArmsMax;
    protected uint m_HPLegs;
    protected uint m_HPLegsMax;

    //케릭터 행동 시 소모되는 속성
    protected uint m_Stamina;
    protected uint m_StaminaMax;
    protected uint m_Satiety;
    protected uint m_SatietyMax;
    protected uint m_Hunger;
    protected uint m_HungerMax;

    //기본 능력치
    protected uint m_At;
    protected uint m_Def;


    //public uint HPHead
    //{
    //    get { return m_HPHead; }
    //    set { m_HPHead = value; }
    //}
    //public uint HPBody
    //{
    //    get { return m_HPBody; }
    //    set { m_HPBody = value; }
    //}
    //public uint HPArms
    //{
    //    get { return m_HPArms; }
    //    set { m_HPArms = value; }
    //}
    //public uint HPLegs
    //{
    //    get { return m_HPLegs; }
    //    set { m_HPLegs = value; }
    //}

    public virtual string UserName
    {
        get { return m_UserName; }
        set { m_UserName = value; }
    }
    public virtual byte Level
    {
        get { return m_Level; }
        set { m_Level = value; }
    }
    public virtual uint HPTotal
    {
        get { return m_HPTotal = (m_HPHead + m_HPBody + m_HPArms + m_HPLegs); }
        set { HPTotal = value; }
    }
    public virtual uint HPMax
    {
        get { return m_HPMax; }
        set { m_HPMax = value; }
    }



}