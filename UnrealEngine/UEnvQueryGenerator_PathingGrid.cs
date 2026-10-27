using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200019A RID: 410
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryGenerator_PathingGrid")]
	[UnrealStructLayout(408, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 408)]
	public class UEnvQueryGenerator_PathingGrid : UEnvQueryGenerator_SimpleGrid, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001970 RID: 6512 RVA: 0x00025BD2 File Offset: 0x00023DD2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryGenerator_PathingGrid._ClassPtr;
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00025BE0 File Offset: 0x00023DE0
		public UEnvQueryGenerator_PathingGrid() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryGenerator_PathingGrid.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00025C08 File Offset: 0x00023E08
		public UEnvQueryGenerator_PathingGrid(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryGenerator_PathingGrid.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x00025C3C File Offset: 0x00023E3C
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x00025C75 File Offset: 0x00023E75
		public FAIDataProviderBoolValue PathToItem
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderBoolValue result;
				if ((result = this._PathToItem) == null)
				{
					result = (this._PathToItem = new FAIDataProviderBoolValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_PathingGrid.__PropertyOffset_PathToItem, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderBoolValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_PathingGrid.__PropertyOffset_PathToItem, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x00025C96 File Offset: 0x00023E96
		// (set) Token: 0x06001976 RID: 6518 RVA: 0x00025CAA File Offset: 0x00023EAA
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavigationQueryFilter> NavigationFilter
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryGenerator_PathingGrid.__PropertyOffset_NavigationFilter);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryGenerator_PathingGrid.__PropertyOffset_NavigationFilter) = value;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x00025CC0 File Offset: 0x00023EC0
		// (set) Token: 0x06001978 RID: 6520 RVA: 0x00025CF9 File Offset: 0x00023EF9
		public FAIDataProviderFloatValue ScanRangeMultiplier
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._ScanRangeMultiplier) == null)
				{
					result = (this._ScanRangeMultiplier = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_PathingGrid.__PropertyOffset_ScanRangeMultiplier, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_PathingGrid.__PropertyOffset_ScanRangeMultiplier, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00025D1A File Offset: 0x00023F1A
		static UEnvQueryGenerator_PathingGrid()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryGenerator_PathingGrid");
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00025D28 File Offset: 0x00023F28
		protected UEnvQueryGenerator_PathingGrid(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000766 RID: 1894
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryGenerator_PathingGrid";

		// Token: 0x04000767 RID: 1895
		private static IntPtr _ClassPtr;

		// Token: 0x04000768 RID: 1896
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000769 RID: 1897
		internal static int __PropertyOffset_PathToItem;

		// Token: 0x0400076A RID: 1898
		[Nullable(2)]
		private FAIDataProviderBoolValue _PathToItem;

		// Token: 0x0400076B RID: 1899
		internal static int __PropertyOffset_NavigationFilter;

		// Token: 0x0400076C RID: 1900
		internal static int __PropertyOffset_ScanRangeMultiplier;

		// Token: 0x0400076D RID: 1901
		[Nullable(2)]
		private FAIDataProviderFloatValue _ScanRangeMultiplier;
	}
}
