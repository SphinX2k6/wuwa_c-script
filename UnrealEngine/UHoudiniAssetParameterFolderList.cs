using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014B1 RID: 5297
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetParameterFolderList")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UHoudiniAssetParameterFolderList : UHoudiniAssetParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013317 RID: 78615 RVA: 0x001C3B46 File Offset: 0x001C1D46
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetParameterFolderList._ClassPtr;
		}

		// Token: 0x06013318 RID: 78616 RVA: 0x001C3B54 File Offset: 0x001C1D54
		public UHoudiniAssetParameterFolderList() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterFolderList.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013319 RID: 78617 RVA: 0x001C3B7C File Offset: 0x001C1D7C
		[NullableContext(1)]
		public UHoudiniAssetParameterFolderList(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterFolderList.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601331A RID: 78618 RVA: 0x001C3BAF File Offset: 0x001C1DAF
		static UHoudiniAssetParameterFolderList()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetParameterFolderList");
		}

		// Token: 0x0601331B RID: 78619 RVA: 0x001C3BBD File Offset: 0x001C1DBD
		protected UHoudiniAssetParameterFolderList(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5DA RID: 42458
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetParameterFolderList";

		// Token: 0x0400A5DB RID: 42459
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5DC RID: 42460
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
