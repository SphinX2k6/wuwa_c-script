using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EE0 RID: 3808
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.NavigationSystemConfig")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UNavigationSystemConfig : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CE54 RID: 52820 RVA: 0x0012D189 File Offset: 0x0012B389
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavigationSystemConfig._ClassPtr;
		}

		// Token: 0x0600CE55 RID: 52821 RVA: 0x0012D198 File Offset: 0x0012B398
		public UNavigationSystemConfig() : this(BuiltinUtils.AllocNativeUObject(UNavigationSystemConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CE56 RID: 52822 RVA: 0x0012D1C0 File Offset: 0x0012B3C0
		public UNavigationSystemConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavigationSystemConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700309C RID: 12444
		// (get) Token: 0x0600CE57 RID: 52823 RVA: 0x0012D1F4 File Offset: 0x0012B3F4
		// (set) Token: 0x0600CE58 RID: 52824 RVA: 0x0012D22D File Offset: 0x0012B42D
		public FSoftClassPath NavigationSystemClass
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._NavigationSystemClass) == null)
				{
					result = (this._NavigationSystemClass = new FSoftClassPath(base.NativePtr + (IntPtr)UNavigationSystemConfig.__PropertyOffset_NavigationSystemClass, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UNavigationSystemConfig.__PropertyOffset_NavigationSystemClass, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700309D RID: 12445
		// (get) Token: 0x0600CE59 RID: 52825 RVA: 0x0012D250 File Offset: 0x0012B450
		// (set) Token: 0x0600CE5A RID: 52826 RVA: 0x0012D289 File Offset: 0x0012B489
		public FNavAgentSelector SupportedAgentsMask
		{
			get
			{
				base.FastCheckIsValid();
				FNavAgentSelector result;
				if ((result = this._SupportedAgentsMask) == null)
				{
					result = (this._SupportedAgentsMask = new FNavAgentSelector(base.NativePtr + (IntPtr)UNavigationSystemConfig.__PropertyOffset_SupportedAgentsMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAgentSelector.StaticStruct(), base.NativePtr + (IntPtr)UNavigationSystemConfig.__PropertyOffset_SupportedAgentsMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700309E RID: 12446
		// (get) Token: 0x0600CE5B RID: 52827 RVA: 0x0012D2AA File Offset: 0x0012B4AA
		// (set) Token: 0x0600CE5C RID: 52828 RVA: 0x0012D2BE File Offset: 0x0012B4BE
		public unsafe FName DefaultAgentName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavigationSystemConfig.__PropertyOffset_DefaultAgentName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavigationSystemConfig.__PropertyOffset_DefaultAgentName) = value;
			}
		}

		// Token: 0x1700309F RID: 12447
		// (get) Token: 0x0600CE5D RID: 52829 RVA: 0x0012D2D3 File Offset: 0x0012B4D3
		// (set) Token: 0x0600CE5E RID: 52830 RVA: 0x0012D2EC File Offset: 0x0012B4EC
		public unsafe bool bEnableNavMeshMultiPlatform
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavigationSystemConfig.__PropertyOffset_bEnableNavMeshMultiPlatform) & UNavigationSystemConfig.__PropertyMask_bEnableNavMeshMultiPlatform) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavigationSystemConfig.__PropertyOffset_bEnableNavMeshMultiPlatform) = ((*(base.NativePtr + (IntPtr)UNavigationSystemConfig.__PropertyOffset_bEnableNavMeshMultiPlatform) & ~UNavigationSystemConfig.__PropertyMask_bEnableNavMeshMultiPlatform) | (value ? UNavigationSystemConfig.__PropertyMask_bEnableNavMeshMultiPlatform : 0));
			}
		}

		// Token: 0x170030A0 RID: 12448
		// (get) Token: 0x0600CE5F RID: 52831 RVA: 0x0012D31C File Offset: 0x0012B51C
		// (set) Token: 0x0600CE60 RID: 52832 RVA: 0x0012D335 File Offset: 0x0012B535
		public unsafe bool bIsOverriden
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavigationSystemConfig.__PropertyOffset_bIsOverriden) & UNavigationSystemConfig.__PropertyMask_bIsOverriden) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavigationSystemConfig.__PropertyOffset_bIsOverriden) = ((*(base.NativePtr + (IntPtr)UNavigationSystemConfig.__PropertyOffset_bIsOverriden) & ~UNavigationSystemConfig.__PropertyMask_bIsOverriden) | (value ? UNavigationSystemConfig.__PropertyMask_bIsOverriden : 0));
			}
		}

		// Token: 0x0600CE61 RID: 52833 RVA: 0x0012D365 File Offset: 0x0012B565
		static UNavigationSystemConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NavigationSystemConfig");
		}

		// Token: 0x0600CE62 RID: 52834 RVA: 0x0012D373 File Offset: 0x0012B573
		protected UNavigationSystemConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006F40 RID: 28480
		public new const string __ObjectPath = "/Script/Engine.NavigationSystemConfig";

		// Token: 0x04006F41 RID: 28481
		private static IntPtr _ClassPtr;

		// Token: 0x04006F42 RID: 28482
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006F43 RID: 28483
		internal static int __PropertyOffset_NavigationSystemClass;

		// Token: 0x04006F44 RID: 28484
		[Nullable(2)]
		private FSoftClassPath _NavigationSystemClass;

		// Token: 0x04006F45 RID: 28485
		internal static int __PropertyOffset_SupportedAgentsMask;

		// Token: 0x04006F46 RID: 28486
		[Nullable(2)]
		private FNavAgentSelector _SupportedAgentsMask;

		// Token: 0x04006F47 RID: 28487
		internal static int __PropertyOffset_DefaultAgentName;

		// Token: 0x04006F48 RID: 28488
		internal static int __PropertyOffset_bEnableNavMeshMultiPlatform;

		// Token: 0x04006F49 RID: 28489
		internal static byte __PropertyMask_bEnableNavMeshMultiPlatform;

		// Token: 0x04006F4A RID: 28490
		internal static int __PropertyOffset_bIsOverriden;

		// Token: 0x04006F4B RID: 28491
		internal static byte __PropertyMask_bIsOverriden;
	}
}
