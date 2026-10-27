using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014B8 RID: 5304
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetParameterToggle")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UHoudiniAssetParameterToggle : UHoudiniAssetParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601333A RID: 78650 RVA: 0x001C3EC6 File Offset: 0x001C20C6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetParameterToggle._ClassPtr;
		}

		// Token: 0x0601333B RID: 78651 RVA: 0x001C3ED4 File Offset: 0x001C20D4
		public UHoudiniAssetParameterToggle() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterToggle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601333C RID: 78652 RVA: 0x001C3EFC File Offset: 0x001C20FC
		[NullableContext(1)]
		public UHoudiniAssetParameterToggle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterToggle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601333D RID: 78653 RVA: 0x001C3F2F File Offset: 0x001C212F
		static UHoudiniAssetParameterToggle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetParameterToggle");
		}

		// Token: 0x0601333E RID: 78654 RVA: 0x001C3F3D File Offset: 0x001C213D
		protected UHoudiniAssetParameterToggle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5EF RID: 42479
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetParameterToggle";

		// Token: 0x0400A5F0 RID: 42480
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5F1 RID: 42481
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
