//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
namespace WhippedCream.Data.User
{
    
    [System.Data.Services.Common.DataServiceEntity]
    [System.Data.Services.Common.DataServiceKey("UserId", "AgentIdId")]
    public partial class AgentId : System.IEquatable<AgentId>
    {
        public System.Guid UserId { get; set; }
        public System.Guid AgentIdId { get; set; }
        public string Value { get; set; }
        public int Type { get; set; }
    
        public virtual User User { get; set; }
    
    	#region Members overriden from System.Object
    
    	public override bool Equals(object obj)
    	{
    		return obj is AgentId ? Equals(obj as AgentId) : false;
    	}
    
    	/// <summary>
    	/// The Implementation of this algorithm was taken
    	/// from [here](http://www.isthe.com/chongo/tech/comp/fnv/).
    	/// </summary>
    	public override int GetHashCode()
    	{
    		int hash = 13;
    		unchecked
    		{
    			hash = (hash * 16777619) ^ UserId.GetHashCode();
    			hash = (hash * 16777619) ^ AgentIdId.GetHashCode();
    			hash = (hash * 16777619) ^ (Value == null ? 0 : Value.GetHashCode());
    			hash = (hash * 16777619) ^ Type.GetHashCode();
    		}
    		return hash;
    	}
    
    	public override string ToString()
    	{
    		return base.ToString();
    	}
    
    	#endregion
    
    	#region IEquatable<AgentId> Members
    
    	public bool Equals(AgentId rhs)
    	{
    		if(rhs == null)
    			return false;
    			
    		return System.Collections.Generic.EqualityComparer<AgentId>.Equals(UserId, rhs.UserId) && System.Collections.Generic.EqualityComparer<AgentId>.Equals(AgentIdId, rhs.AgentIdId) && System.Collections.Generic.EqualityComparer<AgentId>.Equals(Value, rhs.Value) && System.Collections.Generic.EqualityComparer<AgentId>.Equals(Type, rhs.Type);
    	}
    
    	#endregion
    }
}