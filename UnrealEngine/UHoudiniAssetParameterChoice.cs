using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014AC RID: 5292
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetParameterChoice")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UHoudiniAssetParameterChoice : UHoudiniAssetParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060132FE RID: 78590 RVA: 0x001C38C6 File Offset: 0x001C1AC6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetParameterChoice._ClassPtr;
		}

		// Token: 0x060132FF RID: 78591 RVA: 0x001C38D4 File Offset: 0x001C1AD4
		public UHoudiniAssetParameterChoice() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterChoice.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013300 RID: 78592 RVA: 0x001C38FC File Offset: 0x001C1AFC
		[NullableContext(1)]
		public UHoudiniAssetParameterChoice(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterChoice.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013301 RID: 78593 RVA: 0x001C392F File Offset: 0x001C1B2F
		static UHoudiniAssetParameterChoice()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetParameterChoice");
		}

		// Token: 0x06013302 RID: 78594 RVA: 0x001C393D File Offset: 0x001C1B3D
		protected UHoudiniAssetParameterChoice(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5CB RID: 42443
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetParameterChoice";

		// Token: 0x0400A5CC RID: 42444
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5CD RID: 42445
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
