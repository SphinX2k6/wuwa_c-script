using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200107B RID: 4219
	[UnrealObjectPath("/Script/Engine.RegionPackBoundsFilter")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class URegionPackBoundsFilter : URegionPackFilter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F023 RID: 61475 RVA: 0x00163F43 File Offset: 0x00162143
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URegionPackBoundsFilter._ClassPtr;
		}

		// Token: 0x0600F024 RID: 61476 RVA: 0x00163F50 File Offset: 0x00162150
		public URegionPackBoundsFilter() : this(BuiltinUtils.AllocNativeUObject(URegionPackBoundsFilter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F025 RID: 61477 RVA: 0x00163F78 File Offset: 0x00162178
		[NullableContext(1)]
		public URegionPackBoundsFilter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URegionPackBoundsFilter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F026 RID: 61478 RVA: 0x00163FAB File Offset: 0x001621AB
		static URegionPackBoundsFilter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RegionPackBoundsFilter");
		}

		// Token: 0x0600F027 RID: 61479 RVA: 0x00163FB9 File Offset: 0x001621B9
		protected URegionPackBoundsFilter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040081E3 RID: 33251
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RegionPackBoundsFilter";

		// Token: 0x040081E4 RID: 33252
		private static IntPtr _ClassPtr;

		// Token: 0x040081E5 RID: 33253
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
