using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014B3 RID: 5299
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetParameterLabel")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UHoudiniAssetParameterLabel : UHoudiniAssetParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013321 RID: 78625 RVA: 0x001C3C46 File Offset: 0x001C1E46
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetParameterLabel._ClassPtr;
		}

		// Token: 0x06013322 RID: 78626 RVA: 0x001C3C54 File Offset: 0x001C1E54
		public UHoudiniAssetParameterLabel() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterLabel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013323 RID: 78627 RVA: 0x001C3C7C File Offset: 0x001C1E7C
		[NullableContext(1)]
		public UHoudiniAssetParameterLabel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterLabel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013324 RID: 78628 RVA: 0x001C3CAF File Offset: 0x001C1EAF
		static UHoudiniAssetParameterLabel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetParameterLabel");
		}

		// Token: 0x06013325 RID: 78629 RVA: 0x001C3CBD File Offset: 0x001C1EBD
		protected UHoudiniAssetParameterLabel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5E0 RID: 42464
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetParameterLabel";

		// Token: 0x0400A5E1 RID: 42465
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5E2 RID: 42466
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
