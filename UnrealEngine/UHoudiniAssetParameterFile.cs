using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014AE RID: 5294
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetParameterFile")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UHoudiniAssetParameterFile : UHoudiniAssetParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013308 RID: 78600 RVA: 0x001C39C6 File Offset: 0x001C1BC6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetParameterFile._ClassPtr;
		}

		// Token: 0x06013309 RID: 78601 RVA: 0x001C39D4 File Offset: 0x001C1BD4
		public UHoudiniAssetParameterFile() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterFile.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601330A RID: 78602 RVA: 0x001C39FC File Offset: 0x001C1BFC
		[NullableContext(1)]
		public UHoudiniAssetParameterFile(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterFile.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601330B RID: 78603 RVA: 0x001C3A2F File Offset: 0x001C1C2F
		static UHoudiniAssetParameterFile()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetParameterFile");
		}

		// Token: 0x0601330C RID: 78604 RVA: 0x001C3A3D File Offset: 0x001C1C3D
		protected UHoudiniAssetParameterFile(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5D1 RID: 42449
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetParameterFile";

		// Token: 0x0400A5D2 RID: 42450
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5D3 RID: 42451
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
