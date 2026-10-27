using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001A5 RID: 421
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryManager")]
	[UnrealStructLayout(504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 504)]
	public class UEnvQueryManager : UAISubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060019CB RID: 6603 RVA: 0x00026401 File Offset: 0x00024601
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryManager._ClassPtr;
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x00026410 File Offset: 0x00024610
		public UEnvQueryManager() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x00026438 File Offset: 0x00024638
		public UEnvQueryManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x0002646C File Offset: 0x0002466C
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x000264A5 File Offset: 0x000246A5
		public TArray<FEnvQueryInstanceCache> InstanceCache
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FEnvQueryInstanceCache> result;
				if ((result = this._InstanceCache) == null)
				{
					result = (this._InstanceCache = new TArray<FEnvQueryInstanceCache>(base.NativePtr + (IntPtr)UEnvQueryManager.__PropertyOffset_InstanceCache, this));
				}
				return result;
			}
			set
			{
				this.InstanceCache.CopyAssign(value);
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x000264B4 File Offset: 0x000246B4
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x000264ED File Offset: 0x000246ED
		public TArray<UEnvQueryContext> LocalContexts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UEnvQueryContext> result;
				if ((result = this._LocalContexts) == null)
				{
					result = (this._LocalContexts = new TArray<UEnvQueryContext>(base.NativePtr + (IntPtr)UEnvQueryManager.__PropertyOffset_LocalContexts, this));
				}
				return result;
			}
			set
			{
				this.LocalContexts.CopyAssign(value);
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x000264FC File Offset: 0x000246FC
		// (set) Token: 0x060019D3 RID: 6611 RVA: 0x00026535 File Offset: 0x00024735
		public TArray<UEnvQueryInstanceBlueprintWrapper> GCShieldedWrappers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UEnvQueryInstanceBlueprintWrapper> result;
				if ((result = this._GCShieldedWrappers) == null)
				{
					result = (this._GCShieldedWrappers = new TArray<UEnvQueryInstanceBlueprintWrapper>(base.NativePtr + (IntPtr)UEnvQueryManager.__PropertyOffset_GCShieldedWrappers, this));
				}
				return result;
			}
			set
			{
				this.GCShieldedWrappers.CopyAssign(value);
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060019D4 RID: 6612 RVA: 0x00026543 File Offset: 0x00024743
		// (set) Token: 0x060019D5 RID: 6613 RVA: 0x00026553 File Offset: 0x00024753
		public unsafe float MaxAllowedTestingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryManager.__PropertyOffset_MaxAllowedTestingTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryManager.__PropertyOffset_MaxAllowedTestingTime) = value;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x00026564 File Offset: 0x00024764
		// (set) Token: 0x060019D7 RID: 6615 RVA: 0x00026574 File Offset: 0x00024774
		public unsafe bool bTestQueriesUsingBreadth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryManager.__PropertyOffset_bTestQueriesUsingBreadth) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryManager.__PropertyOffset_bTestQueriesUsingBreadth) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x00026585 File Offset: 0x00024785
		// (set) Token: 0x060019D9 RID: 6617 RVA: 0x00026595 File Offset: 0x00024795
		public unsafe int QueryCountWarningThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryManager.__PropertyOffset_QueryCountWarningThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryManager.__PropertyOffset_QueryCountWarningThreshold) = value;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x000265A6 File Offset: 0x000247A6
		// (set) Token: 0x060019DB RID: 6619 RVA: 0x000265B6 File Offset: 0x000247B6
		public unsafe double QueryCountWarningInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryManager.__PropertyOffset_QueryCountWarningInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryManager.__PropertyOffset_QueryCountWarningInterval) = value;
			}
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x000265C8 File Offset: 0x000247C8
		[NullableContext(2)]
		public static UEnvQueryInstanceBlueprintWrapper RunEQSQuery(UObject WorldContextObject, UEnvQuery QueryTemplate, UObject Querier, EEnvQueryRunMode RunMode, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UEnvQueryInstanceBlueprintWrapper> WrapperClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UEnvQueryInstanceBlueprintWrapper>(UEnvQueryManager.__RunEQSQuery_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (QueryTemplate != null) ? QueryTemplate.NativePtr : IntPtr.Zero, (Querier != null) ? Querier.NativePtr : IntPtr.Zero, RunMode, WrapperClass._NativePtr));
		}

		// Token: 0x060019DD RID: 6621
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RunEQSQuery_Internal(IntPtr WorldContextObject, IntPtr QueryTemplate, IntPtr Querier, TEnumAsByte<EEnvQueryRunMode> RunMode, IntPtr WrapperClass);

		// Token: 0x060019DE RID: 6622 RVA: 0x0002661C File Offset: 0x0002481C
		static UEnvQueryManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryManager");
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x0002662A File Offset: 0x0002482A
		protected UEnvQueryManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400079A RID: 1946
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryManager";

		// Token: 0x0400079B RID: 1947
		private static IntPtr _ClassPtr;

		// Token: 0x0400079C RID: 1948
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400079D RID: 1949
		internal static int __PropertyOffset_InstanceCache;

		// Token: 0x0400079E RID: 1950
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FEnvQueryInstanceCache> _InstanceCache;

		// Token: 0x0400079F RID: 1951
		internal static int __PropertyOffset_LocalContexts;

		// Token: 0x040007A0 RID: 1952
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UEnvQueryContext> _LocalContexts;

		// Token: 0x040007A1 RID: 1953
		internal static int __PropertyOffset_GCShieldedWrappers;

		// Token: 0x040007A2 RID: 1954
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UEnvQueryInstanceBlueprintWrapper> _GCShieldedWrappers;

		// Token: 0x040007A3 RID: 1955
		internal static int __PropertyOffset_MaxAllowedTestingTime;

		// Token: 0x040007A4 RID: 1956
		internal static int __PropertyOffset_bTestQueriesUsingBreadth;

		// Token: 0x040007A5 RID: 1957
		internal static int __PropertyOffset_QueryCountWarningThreshold;

		// Token: 0x040007A6 RID: 1958
		internal static int __PropertyOffset_QueryCountWarningInterval;
	}
}
