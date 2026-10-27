using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026D2 RID: 9938
	[UnrealObjectPath("/Script/RoadNetNavigationRuntime.RoadNetNavigationSetting")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class URoadNetNavigationSetting : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024E43 RID: 151107 RVA: 0x0036918C File Offset: 0x0036738C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URoadNetNavigationSetting._ClassPtr;
		}

		// Token: 0x06024E44 RID: 151108 RVA: 0x00369198 File Offset: 0x00367398
		public URoadNetNavigationSetting() : this(BuiltinUtils.AllocNativeUObject(URoadNetNavigationSetting.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024E45 RID: 151109 RVA: 0x003691C0 File Offset: 0x003673C0
		[NullableContext(1)]
		public URoadNetNavigationSetting(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URoadNetNavigationSetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008E78 RID: 36472
		// (get) Token: 0x06024E46 RID: 151110 RVA: 0x003691F3 File Offset: 0x003673F3
		// (set) Token: 0x06024E47 RID: 151111 RVA: 0x00369203 File Offset: 0x00367403
		public unsafe int MaxPathPoints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URoadNetNavigationSetting.__PropertyOffset_MaxPathPoints);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URoadNetNavigationSetting.__PropertyOffset_MaxPathPoints) = value;
			}
		}

		// Token: 0x17008E79 RID: 36473
		// (get) Token: 0x06024E48 RID: 151112 RVA: 0x00369214 File Offset: 0x00367414
		// (set) Token: 0x06024E49 RID: 151113 RVA: 0x00369224 File Offset: 0x00367424
		public unsafe int MaxSearchPoints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URoadNetNavigationSetting.__PropertyOffset_MaxSearchPoints);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URoadNetNavigationSetting.__PropertyOffset_MaxSearchPoints) = value;
			}
		}

		// Token: 0x17008E7A RID: 36474
		// (get) Token: 0x06024E4A RID: 151114 RVA: 0x00369235 File Offset: 0x00367435
		// (set) Token: 0x06024E4B RID: 151115 RVA: 0x00369245 File Offset: 0x00367445
		public unsafe int MaxCheckCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URoadNetNavigationSetting.__PropertyOffset_MaxCheckCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URoadNetNavigationSetting.__PropertyOffset_MaxCheckCount) = value;
			}
		}

		// Token: 0x17008E7B RID: 36475
		// (get) Token: 0x06024E4C RID: 151116 RVA: 0x00369256 File Offset: 0x00367456
		// (set) Token: 0x06024E4D RID: 151117 RVA: 0x00369266 File Offset: 0x00367466
		public unsafe float DotAngleThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URoadNetNavigationSetting.__PropertyOffset_DotAngleThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URoadNetNavigationSetting.__PropertyOffset_DotAngleThreshold) = value;
			}
		}

		// Token: 0x17008E7C RID: 36476
		// (get) Token: 0x06024E4E RID: 151118 RVA: 0x00369277 File Offset: 0x00367477
		// (set) Token: 0x06024E4F RID: 151119 RVA: 0x0036928B File Offset: 0x0036748B
		public unsafe FVector FinderHalfExtents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URoadNetNavigationSetting.__PropertyOffset_FinderHalfExtents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URoadNetNavigationSetting.__PropertyOffset_FinderHalfExtents) = value;
			}
		}

		// Token: 0x06024E50 RID: 151120 RVA: 0x003692A0 File Offset: 0x003674A0
		static URoadNetNavigationSetting()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/RoadNetNavigationRuntime.RoadNetNavigationSetting");
		}

		// Token: 0x06024E51 RID: 151121 RVA: 0x003692AE File Offset: 0x003674AE
		protected URoadNetNavigationSetting(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013DF9 RID: 81401
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/RoadNetNavigationRuntime.RoadNetNavigationSetting";

		// Token: 0x04013DFA RID: 81402
		private static IntPtr _ClassPtr;

		// Token: 0x04013DFB RID: 81403
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013DFC RID: 81404
		internal static int __PropertyOffset_MaxPathPoints;

		// Token: 0x04013DFD RID: 81405
		internal static int __PropertyOffset_MaxSearchPoints;

		// Token: 0x04013DFE RID: 81406
		internal static int __PropertyOffset_MaxCheckCount;

		// Token: 0x04013DFF RID: 81407
		internal static int __PropertyOffset_DotAngleThreshold;

		// Token: 0x04013E00 RID: 81408
		internal static int __PropertyOffset_FinderHalfExtents;
	}
}
