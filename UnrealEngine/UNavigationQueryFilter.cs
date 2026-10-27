using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002495 RID: 9365
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NavigationSystem.NavigationQueryFilter")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class UNavigationQueryFilter : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602304E RID: 143438 RVA: 0x0033C6CC File Offset: 0x0033A8CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavigationQueryFilter._ClassPtr;
		}

		// Token: 0x17008686 RID: 34438
		// (get) Token: 0x0602304F RID: 143439 RVA: 0x0033C6D8 File Offset: 0x0033A8D8
		// (set) Token: 0x06023050 RID: 143440 RVA: 0x0033C711 File Offset: 0x0033A911
		public TArray<FNavigationFilterArea> Areas
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNavigationFilterArea> result;
				if ((result = this._Areas) == null)
				{
					result = (this._Areas = new TArray<FNavigationFilterArea>(base.NativePtr + (IntPtr)UNavigationQueryFilter.__PropertyOffset_Areas, this));
				}
				return result;
			}
			set
			{
				this.Areas.CopyAssign(value);
			}
		}

		// Token: 0x17008687 RID: 34439
		// (get) Token: 0x06023051 RID: 143441 RVA: 0x0033C71F File Offset: 0x0033A91F
		// (set) Token: 0x06023052 RID: 143442 RVA: 0x0033C733 File Offset: 0x0033A933
		public unsafe FNavigationFilterFlags IncludeFlags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavigationQueryFilter.__PropertyOffset_IncludeFlags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavigationQueryFilter.__PropertyOffset_IncludeFlags) = value;
			}
		}

		// Token: 0x17008688 RID: 34440
		// (get) Token: 0x06023053 RID: 143443 RVA: 0x0033C748 File Offset: 0x0033A948
		// (set) Token: 0x06023054 RID: 143444 RVA: 0x0033C75C File Offset: 0x0033A95C
		public unsafe FNavigationFilterFlags ExcludeFlags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavigationQueryFilter.__PropertyOffset_ExcludeFlags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavigationQueryFilter.__PropertyOffset_ExcludeFlags) = value;
			}
		}

		// Token: 0x06023055 RID: 143445 RVA: 0x0033C771 File Offset: 0x0033A971
		static UNavigationQueryFilter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavigationQueryFilter");
		}

		// Token: 0x06023056 RID: 143446 RVA: 0x0033C780 File Offset: 0x0033A980
		protected UNavigationQueryFilter() : this(BuiltinUtils.AllocNativeUObject(UNavigationQueryFilter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023057 RID: 143447 RVA: 0x0033C7A8 File Offset: 0x0033A9A8
		protected UNavigationQueryFilter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B26 RID: 76582
		public new const string __ObjectPath = "/Script/NavigationSystem.NavigationQueryFilter";

		// Token: 0x04012B27 RID: 76583
		private static IntPtr _ClassPtr;

		// Token: 0x04012B28 RID: 76584
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012B29 RID: 76585
		internal static int __PropertyOffset_Areas;

		// Token: 0x04012B2A RID: 76586
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNavigationFilterArea> _Areas;

		// Token: 0x04012B2B RID: 76587
		internal static int __PropertyOffset_IncludeFlags;

		// Token: 0x04012B2C RID: 76588
		internal static int __PropertyOffset_ExcludeFlags;
	}
}
