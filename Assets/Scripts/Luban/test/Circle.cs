
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace cfg.test
{
/// <summary>
/// 这是一个圆
/// </summary>
public sealed partial class Circle : Shape
{
    public Circle(JSONNode _buf)  : base(_buf) 
    {
        { if(!_buf["radius"].IsNumber) { throw new SerializationException(); }  Radius = _buf["radius"]; }
    }

    public static Circle DeserializeCircle(JSONNode _buf)
    {
        return new test.Circle(_buf);
    }

    /// <summary>
    /// 半径
    /// </summary>
    public readonly float Radius;
   
    public const int __ID__ = 2131829196;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "radius:" + Radius + ","
        + "}";
    }
}

}

