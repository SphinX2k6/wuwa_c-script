using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C2E RID: 3118
	[UnrealObjectPath("/Script/Engine.HLODHelpInfo")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UHLODHelpInfo : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009E26 RID: 40486 RVA: 0x000E0CDA File Offset: 0x000DEEDA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHLODHelpInfo._ClassPtr;
		}

		// Token: 0x06009E27 RID: 40487 RVA: 0x000E0CE8 File Offset: 0x000DEEE8
		public UHLODHelpInfo() : this(BuiltinUtils.AllocNativeUObject(UHLODHelpInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009E28 RID: 40488 RVA: 0x000E0D10 File Offset: 0x000DEF10
		[NullableContext(1)]
		public UHLODHelpInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHLODHelpInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06009E29 RID: 40489 RVA: 0x000E0D43 File Offset: 0x000DEF43
		static UHLODHelpInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HLODHelpInfo");
		}

		// Token: 0x06009E2A RID: 40490 RVA: 0x000E0D51 File Offset: 0x000DEF51
		protected UHLODHelpInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005732 RID: 22322
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.HLODHelpInfo";

		// Token: 0x04005733 RID: 22323
		private static IntPtr _ClassPtr;

		// Token: 0x04005734 RID: 22324
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
