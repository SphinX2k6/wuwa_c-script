using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014B6 RID: 5302
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetParameterSeparator")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UHoudiniAssetParameterSeparator : UHoudiniAssetParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013330 RID: 78640 RVA: 0x001C3DC6 File Offset: 0x001C1FC6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetParameterSeparator._ClassPtr;
		}

		// Token: 0x06013331 RID: 78641 RVA: 0x001C3DD4 File Offset: 0x001C1FD4
		public UHoudiniAssetParameterSeparator() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterSeparator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013332 RID: 78642 RVA: 0x001C3DFC File Offset: 0x001C1FFC
		[NullableContext(1)]
		public UHoudiniAssetParameterSeparator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterSeparator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013333 RID: 78643 RVA: 0x001C3E2F File Offset: 0x001C202F
		static UHoudiniAssetParameterSeparator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetParameterSeparator");
		}

		// Token: 0x06013334 RID: 78644 RVA: 0x001C3E3D File Offset: 0x001C203D
		protected UHoudiniAssetParameterSeparator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5E9 RID: 42473
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetParameterSeparator";

		// Token: 0x0400A5EA RID: 42474
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5EB RID: 42475
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
