using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200107D RID: 4221
	[UnrealObjectPath("/Script/Engine.RegionPackFolderFilter")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class URegionPackFolderFilter : URegionPackFilter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F02C RID: 61484 RVA: 0x0016400D File Offset: 0x0016220D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URegionPackFolderFilter._ClassPtr;
		}

		// Token: 0x0600F02D RID: 61485 RVA: 0x0016401C File Offset: 0x0016221C
		public URegionPackFolderFilter() : this(BuiltinUtils.AllocNativeUObject(URegionPackFolderFilter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F02E RID: 61486 RVA: 0x00164044 File Offset: 0x00162244
		[NullableContext(1)]
		public URegionPackFolderFilter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URegionPackFolderFilter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F02F RID: 61487 RVA: 0x00164077 File Offset: 0x00162277
		static URegionPackFolderFilter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RegionPackFolderFilter");
		}

		// Token: 0x0600F030 RID: 61488 RVA: 0x00164085 File Offset: 0x00162285
		protected URegionPackFolderFilter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040081E9 RID: 33257
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RegionPackFolderFilter";

		// Token: 0x040081EA RID: 33258
		private static IntPtr _ClassPtr;

		// Token: 0x040081EB RID: 33259
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
