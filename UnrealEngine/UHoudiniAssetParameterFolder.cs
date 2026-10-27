using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014B0 RID: 5296
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetParameterFolder")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UHoudiniAssetParameterFolder : UHoudiniAssetParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013312 RID: 78610 RVA: 0x001C3AC6 File Offset: 0x001C1CC6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetParameterFolder._ClassPtr;
		}

		// Token: 0x06013313 RID: 78611 RVA: 0x001C3AD4 File Offset: 0x001C1CD4
		public UHoudiniAssetParameterFolder() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterFolder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013314 RID: 78612 RVA: 0x001C3AFC File Offset: 0x001C1CFC
		[NullableContext(1)]
		public UHoudiniAssetParameterFolder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterFolder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013315 RID: 78613 RVA: 0x001C3B2F File Offset: 0x001C1D2F
		static UHoudiniAssetParameterFolder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetParameterFolder");
		}

		// Token: 0x06013316 RID: 78614 RVA: 0x001C3B3D File Offset: 0x001C1D3D
		protected UHoudiniAssetParameterFolder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5D7 RID: 42455
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetParameterFolder";

		// Token: 0x0400A5D8 RID: 42456
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5D9 RID: 42457
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
