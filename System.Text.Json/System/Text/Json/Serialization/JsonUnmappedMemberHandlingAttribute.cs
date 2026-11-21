using System;

namespace System.Text.Json.Serialization
{
	// Token: 0x02000091 RID: 145
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	public class JsonUnmappedMemberHandlingAttribute : JsonAttribute
	{
		// Token: 0x060008F9 RID: 2297 RVA: 0x0002815E File Offset: 0x0002635E
		public JsonUnmappedMemberHandlingAttribute(JsonUnmappedMemberHandling unmappedMemberHandling)
		{
			this.UnmappedMemberHandling = unmappedMemberHandling;
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0002816D File Offset: 0x0002636D
		public JsonUnmappedMemberHandling UnmappedMemberHandling { get; }
	}
}
