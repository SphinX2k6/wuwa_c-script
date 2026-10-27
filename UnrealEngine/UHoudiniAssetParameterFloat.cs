using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014AF RID: 5295
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetParameterFloat")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UHoudiniAssetParameterFloat : UHoudiniAssetParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601330D RID: 78605 RVA: 0x001C3A46 File Offset: 0x001C1C46
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetParameterFloat._ClassPtr;
		}

		// Token: 0x0601330E RID: 78606 RVA: 0x001C3A54 File Offset: 0x001C1C54
		public UHoudiniAssetParameterFloat() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterFloat.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601330F RID: 78607 RVA: 0x001C3A7C File Offset: 0x001C1C7C
		[NullableContext(1)]
		public UHoudiniAssetParameterFloat(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterFloat.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013310 RID: 78608 RVA: 0x001C3AAF File Offset: 0x001C1CAF
		static UHoudiniAssetParameterFloat()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetParameterFloat");
		}

		// Token: 0x06013311 RID: 78609 RVA: 0x001C3ABD File Offset: 0x001C1CBD
		protected UHoudiniAssetParameterFloat(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5D4 RID: 42452
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetParameterFloat";

		// Token: 0x0400A5D5 RID: 42453
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5D6 RID: 42454
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
