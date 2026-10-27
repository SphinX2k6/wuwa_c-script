using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F48 RID: 8008
	[UnrealObjectPath("/Script/KuroWorldPartition.KuroCustomHLODModifier")]
	[UnrealStructLayout(728, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 728)]
	public class UKuroCustomHLODModifier : UWorldPartitionHLODModifier, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E761 RID: 124769 RVA: 0x002D486B File Offset: 0x002D2A6B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCustomHLODModifier._ClassPtr;
		}

		// Token: 0x0601E762 RID: 124770 RVA: 0x002D4878 File Offset: 0x002D2A78
		public UKuroCustomHLODModifier() : this(BuiltinUtils.AllocNativeUObject(UKuroCustomHLODModifier.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E763 RID: 124771 RVA: 0x002D48A0 File Offset: 0x002D2AA0
		[NullableContext(1)]
		public UKuroCustomHLODModifier(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCustomHLODModifier.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E764 RID: 124772 RVA: 0x002D48D3 File Offset: 0x002D2AD3
		static UKuroCustomHLODModifier()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroWorldPartition.KuroCustomHLODModifier");
		}

		// Token: 0x0601E765 RID: 124773 RVA: 0x002D48E1 File Offset: 0x002D2AE1
		protected UKuroCustomHLODModifier(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040106EB RID: 67307
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroWorldPartition.KuroCustomHLODModifier";

		// Token: 0x040106EC RID: 67308
		private static IntPtr _ClassPtr;

		// Token: 0x040106ED RID: 67309
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
