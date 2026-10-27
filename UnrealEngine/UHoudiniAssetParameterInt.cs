using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014B2 RID: 5298
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetParameterInt")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UHoudiniAssetParameterInt : UHoudiniAssetParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601331C RID: 78620 RVA: 0x001C3BC6 File Offset: 0x001C1DC6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetParameterInt._ClassPtr;
		}

		// Token: 0x0601331D RID: 78621 RVA: 0x001C3BD4 File Offset: 0x001C1DD4
		public UHoudiniAssetParameterInt() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterInt.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601331E RID: 78622 RVA: 0x001C3BFC File Offset: 0x001C1DFC
		[NullableContext(1)]
		public UHoudiniAssetParameterInt(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterInt.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601331F RID: 78623 RVA: 0x001C3C2F File Offset: 0x001C1E2F
		static UHoudiniAssetParameterInt()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetParameterInt");
		}

		// Token: 0x06013320 RID: 78624 RVA: 0x001C3C3D File Offset: 0x001C1E3D
		protected UHoudiniAssetParameterInt(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5DD RID: 42461
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetParameterInt";

		// Token: 0x0400A5DE RID: 42462
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5DF RID: 42463
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
