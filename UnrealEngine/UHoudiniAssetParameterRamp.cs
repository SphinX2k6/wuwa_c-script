using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014B5 RID: 5301
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetParameterRamp")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UHoudiniAssetParameterRamp : UHoudiniAssetParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601332B RID: 78635 RVA: 0x001C3D46 File Offset: 0x001C1F46
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetParameterRamp._ClassPtr;
		}

		// Token: 0x0601332C RID: 78636 RVA: 0x001C3D54 File Offset: 0x001C1F54
		public UHoudiniAssetParameterRamp() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterRamp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601332D RID: 78637 RVA: 0x001C3D7C File Offset: 0x001C1F7C
		[NullableContext(1)]
		public UHoudiniAssetParameterRamp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterRamp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601332E RID: 78638 RVA: 0x001C3DAF File Offset: 0x001C1FAF
		static UHoudiniAssetParameterRamp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetParameterRamp");
		}

		// Token: 0x0601332F RID: 78639 RVA: 0x001C3DBD File Offset: 0x001C1FBD
		protected UHoudiniAssetParameterRamp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5E6 RID: 42470
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetParameterRamp";

		// Token: 0x0400A5E7 RID: 42471
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5E8 RID: 42472
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
