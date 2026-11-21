using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000249 RID: 585
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.NavigationSystemConfig")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UNavigationSystemConfig : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600327C RID: 12924 RVA: 0x0004805D File Offset: 0x0004625D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavigationSystemConfig._ClassPtr;
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x0004806C File Offset: 0x0004626C
		public UNavigationSystemConfig() : this(BuiltinUtils.AllocNativeUObject(UNavigationSystemConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x00048094 File Offset: 0x00046294
		public UNavigationSystemConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavigationSystemConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x0600327F RID: 12927 RVA: 0x000480C8 File Offset: 0x000462C8
		// (set) Token: 0x06003280 RID: 12928 RVA: 0x00048101 File Offset: 0x00046301
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

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06003281 RID: 12929 RVA: 0x00048122 File Offset: 0x00046322
		// (set) Token: 0x06003282 RID: 12930 RVA: 0x00048136 File Offset: 0x00046336
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

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06003283 RID: 12931 RVA: 0x0004814B File Offset: 0x0004634B
		// (set) Token: 0x06003284 RID: 12932 RVA: 0x00048164 File Offset: 0x00046364
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

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06003285 RID: 12933 RVA: 0x00048194 File Offset: 0x00046394
		// (set) Token: 0x06003286 RID: 12934 RVA: 0x000481AD File Offset: 0x000463AD
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

		// Token: 0x06003287 RID: 12935 RVA: 0x000481DD File Offset: 0x000463DD
		static UNavigationSystemConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NavigationSystemConfig");
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x000481EB File Offset: 0x000463EB
		protected UNavigationSystemConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400119A RID: 4506
		public new const string __ObjectPath = "/Script/Engine.NavigationSystemConfig";

		// Token: 0x0400119B RID: 4507
		private static IntPtr _ClassPtr;

		// Token: 0x0400119C RID: 4508
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400119D RID: 4509
		internal static int __PropertyOffset_NavigationSystemClass;

		// Token: 0x0400119E RID: 4510
		[Nullable(2)]
		private FSoftClassPath _NavigationSystemClass;

		// Token: 0x0400119F RID: 4511
		internal static int __PropertyOffset_DefaultAgentName;

		// Token: 0x040011A0 RID: 4512
		internal static int __PropertyOffset_bEnableNavMeshMultiPlatform;

		// Token: 0x040011A1 RID: 4513
		internal static byte __PropertyMask_bEnableNavMeshMultiPlatform;

		// Token: 0x040011A2 RID: 4514
		internal static int __PropertyOffset_bIsOverriden;

		// Token: 0x040011A3 RID: 4515
		internal static byte __PropertyMask_bIsOverriden;
	}
}
