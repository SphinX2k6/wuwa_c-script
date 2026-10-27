using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002496 RID: 9366
	[UnrealObjectPath("/Script/NavigationSystem.NavigationSystemModuleConfig")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UNavigationSystemModuleConfig : UNavigationSystemConfig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023058 RID: 143448 RVA: 0x0033C7B1 File Offset: 0x0033A9B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavigationSystemModuleConfig._ClassPtr;
		}

		// Token: 0x06023059 RID: 143449 RVA: 0x0033C7C0 File Offset: 0x0033A9C0
		public UNavigationSystemModuleConfig() : this(BuiltinUtils.AllocNativeUObject(UNavigationSystemModuleConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602305A RID: 143450 RVA: 0x0033C7E8 File Offset: 0x0033A9E8
		[NullableContext(1)]
		public UNavigationSystemModuleConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavigationSystemModuleConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008689 RID: 34441
		// (get) Token: 0x0602305B RID: 143451 RVA: 0x0033C81B File Offset: 0x0033AA1B
		// (set) Token: 0x0602305C RID: 143452 RVA: 0x0033C834 File Offset: 0x0033AA34
		public unsafe bool bStrictlyStatic
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavigationSystemModuleConfig.__PropertyOffset_bStrictlyStatic) & UNavigationSystemModuleConfig.__PropertyMask_bStrictlyStatic) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavigationSystemModuleConfig.__PropertyOffset_bStrictlyStatic) = ((*(base.NativePtr + (IntPtr)UNavigationSystemModuleConfig.__PropertyOffset_bStrictlyStatic) & ~UNavigationSystemModuleConfig.__PropertyMask_bStrictlyStatic) | (value ? UNavigationSystemModuleConfig.__PropertyMask_bStrictlyStatic : 0));
			}
		}

		// Token: 0x1700868A RID: 34442
		// (get) Token: 0x0602305D RID: 143453 RVA: 0x0033C864 File Offset: 0x0033AA64
		// (set) Token: 0x0602305E RID: 143454 RVA: 0x0033C87D File Offset: 0x0033AA7D
		public unsafe bool bCreateOnClient
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavigationSystemModuleConfig.__PropertyOffset_bCreateOnClient) & UNavigationSystemModuleConfig.__PropertyMask_bCreateOnClient) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavigationSystemModuleConfig.__PropertyOffset_bCreateOnClient) = ((*(base.NativePtr + (IntPtr)UNavigationSystemModuleConfig.__PropertyOffset_bCreateOnClient) & ~UNavigationSystemModuleConfig.__PropertyMask_bCreateOnClient) | (value ? UNavigationSystemModuleConfig.__PropertyMask_bCreateOnClient : 0));
			}
		}

		// Token: 0x1700868B RID: 34443
		// (get) Token: 0x0602305F RID: 143455 RVA: 0x0033C8AD File Offset: 0x0033AAAD
		// (set) Token: 0x06023060 RID: 143456 RVA: 0x0033C8C6 File Offset: 0x0033AAC6
		public unsafe bool bAutoSpawnMissingNavData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavigationSystemModuleConfig.__PropertyOffset_bAutoSpawnMissingNavData) & UNavigationSystemModuleConfig.__PropertyMask_bAutoSpawnMissingNavData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavigationSystemModuleConfig.__PropertyOffset_bAutoSpawnMissingNavData) = ((*(base.NativePtr + (IntPtr)UNavigationSystemModuleConfig.__PropertyOffset_bAutoSpawnMissingNavData) & ~UNavigationSystemModuleConfig.__PropertyMask_bAutoSpawnMissingNavData) | (value ? UNavigationSystemModuleConfig.__PropertyMask_bAutoSpawnMissingNavData : 0));
			}
		}

		// Token: 0x1700868C RID: 34444
		// (get) Token: 0x06023061 RID: 143457 RVA: 0x0033C8F6 File Offset: 0x0033AAF6
		// (set) Token: 0x06023062 RID: 143458 RVA: 0x0033C90F File Offset: 0x0033AB0F
		public unsafe bool bSpawnNavDataInNavBoundsLevel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavigationSystemModuleConfig.__PropertyOffset_bSpawnNavDataInNavBoundsLevel) & UNavigationSystemModuleConfig.__PropertyMask_bSpawnNavDataInNavBoundsLevel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavigationSystemModuleConfig.__PropertyOffset_bSpawnNavDataInNavBoundsLevel) = ((*(base.NativePtr + (IntPtr)UNavigationSystemModuleConfig.__PropertyOffset_bSpawnNavDataInNavBoundsLevel) & ~UNavigationSystemModuleConfig.__PropertyMask_bSpawnNavDataInNavBoundsLevel) | (value ? UNavigationSystemModuleConfig.__PropertyMask_bSpawnNavDataInNavBoundsLevel : 0));
			}
		}

		// Token: 0x06023063 RID: 143459 RVA: 0x0033C93F File Offset: 0x0033AB3F
		static UNavigationSystemModuleConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavigationSystemModuleConfig");
		}

		// Token: 0x06023064 RID: 143460 RVA: 0x0033C94D File Offset: 0x0033AB4D
		protected UNavigationSystemModuleConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B2D RID: 76589
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavigationSystemModuleConfig";

		// Token: 0x04012B2E RID: 76590
		private static IntPtr _ClassPtr;

		// Token: 0x04012B2F RID: 76591
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012B30 RID: 76592
		internal static int __PropertyOffset_bStrictlyStatic;

		// Token: 0x04012B31 RID: 76593
		internal static byte __PropertyMask_bStrictlyStatic;

		// Token: 0x04012B32 RID: 76594
		internal static int __PropertyOffset_bCreateOnClient;

		// Token: 0x04012B33 RID: 76595
		internal static byte __PropertyMask_bCreateOnClient;

		// Token: 0x04012B34 RID: 76596
		internal static int __PropertyOffset_bAutoSpawnMissingNavData;

		// Token: 0x04012B35 RID: 76597
		internal static byte __PropertyMask_bAutoSpawnMissingNavData;

		// Token: 0x04012B36 RID: 76598
		internal static int __PropertyOffset_bSpawnNavDataInNavBoundsLevel;

		// Token: 0x04012B37 RID: 76599
		internal static byte __PropertyMask_bSpawnNavDataInNavBoundsLevel;
	}
}
