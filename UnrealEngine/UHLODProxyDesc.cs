using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C3A RID: 3130
	[UnrealObjectPath("/Script/Engine.HLODProxyDesc")]
	[UnrealStructLayout(368, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class UHLODProxyDesc : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009EA3 RID: 40611 RVA: 0x000E179A File Offset: 0x000DF99A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHLODProxyDesc._ClassPtr;
		}

		// Token: 0x06009EA4 RID: 40612 RVA: 0x000E17A8 File Offset: 0x000DF9A8
		public UHLODProxyDesc() : this(BuiltinUtils.AllocNativeUObject(UHLODProxyDesc.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009EA5 RID: 40613 RVA: 0x000E17D0 File Offset: 0x000DF9D0
		[NullableContext(1)]
		public UHLODProxyDesc(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHLODProxyDesc.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06009EA6 RID: 40614 RVA: 0x000E1803 File Offset: 0x000DFA03
		static UHLODProxyDesc()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HLODProxyDesc");
		}

		// Token: 0x06009EA7 RID: 40615 RVA: 0x000E1811 File Offset: 0x000DFA11
		protected UHLODProxyDesc(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005773 RID: 22387
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.HLODProxyDesc";

		// Token: 0x04005774 RID: 22388
		private static IntPtr _ClassPtr;

		// Token: 0x04005775 RID: 22389
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
