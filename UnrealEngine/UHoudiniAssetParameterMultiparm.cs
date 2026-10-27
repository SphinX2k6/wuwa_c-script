using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014B4 RID: 5300
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetParameterMultiparm")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UHoudiniAssetParameterMultiparm : UHoudiniAssetParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013326 RID: 78630 RVA: 0x001C3CC6 File Offset: 0x001C1EC6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetParameterMultiparm._ClassPtr;
		}

		// Token: 0x06013327 RID: 78631 RVA: 0x001C3CD4 File Offset: 0x001C1ED4
		public UHoudiniAssetParameterMultiparm() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterMultiparm.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013328 RID: 78632 RVA: 0x001C3CFC File Offset: 0x001C1EFC
		[NullableContext(1)]
		public UHoudiniAssetParameterMultiparm(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterMultiparm.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013329 RID: 78633 RVA: 0x001C3D2F File Offset: 0x001C1F2F
		static UHoudiniAssetParameterMultiparm()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetParameterMultiparm");
		}

		// Token: 0x0601332A RID: 78634 RVA: 0x001C3D3D File Offset: 0x001C1F3D
		protected UHoudiniAssetParameterMultiparm(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5E3 RID: 42467
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetParameterMultiparm";

		// Token: 0x0400A5E4 RID: 42468
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5E5 RID: 42469
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
