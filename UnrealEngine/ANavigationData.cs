using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000796 RID: 1942
	[UnrealObjectPath("/Script/NavigationSystem.NavigationData")]
	[UnrealStructLayout(1632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1632)]
	public abstract class ANavigationData : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A7A2 RID: 42914 RVA: 0x000F76DE File Offset: 0x000F58DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavigationData._ClassPtr;
		}

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x0600A7A3 RID: 42915 RVA: 0x000F76EA File Offset: 0x000F58EA
		// (set) Token: 0x0600A7A4 RID: 42916 RVA: 0x000F76FE File Offset: 0x000F58FE
		[Nullable(2)]
		public unsafe UPrimitiveComponent RenderingComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationData.__PropertyOffset_RenderingComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationData.__PropertyOffset_RenderingComp, value);
			}
		}

		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x0600A7A5 RID: 42917 RVA: 0x000F7713 File Offset: 0x000F5913
		// (set) Token: 0x0600A7A6 RID: 42918 RVA: 0x000F772C File Offset: 0x000F592C
		public unsafe bool bEnableDrawing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bEnableDrawing) & ANavigationData.__PropertyMask_bEnableDrawing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bEnableDrawing) = ((*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bEnableDrawing) & ~ANavigationData.__PropertyMask_bEnableDrawing) | (value ? ANavigationData.__PropertyMask_bEnableDrawing : 0));
			}
		}

		// Token: 0x17001F2C RID: 7980
		// (get) Token: 0x0600A7A7 RID: 42919 RVA: 0x000F775C File Offset: 0x000F595C
		// (set) Token: 0x0600A7A8 RID: 42920 RVA: 0x000F7775 File Offset: 0x000F5975
		public unsafe bool bForceRebuildOnLoad
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bForceRebuildOnLoad) & ANavigationData.__PropertyMask_bForceRebuildOnLoad) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bForceRebuildOnLoad) = ((*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bForceRebuildOnLoad) & ~ANavigationData.__PropertyMask_bForceRebuildOnLoad) | (value ? ANavigationData.__PropertyMask_bForceRebuildOnLoad : 0));
			}
		}

		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x0600A7A9 RID: 42921 RVA: 0x000F77A5 File Offset: 0x000F59A5
		// (set) Token: 0x0600A7AA RID: 42922 RVA: 0x000F77BE File Offset: 0x000F59BE
		public unsafe bool bAutoDestroyWhenNoNavigation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bAutoDestroyWhenNoNavigation) & ANavigationData.__PropertyMask_bAutoDestroyWhenNoNavigation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bAutoDestroyWhenNoNavigation) = ((*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bAutoDestroyWhenNoNavigation) & ~ANavigationData.__PropertyMask_bAutoDestroyWhenNoNavigation) | (value ? ANavigationData.__PropertyMask_bAutoDestroyWhenNoNavigation : 0));
			}
		}

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x0600A7AB RID: 42923 RVA: 0x000F77EE File Offset: 0x000F59EE
		// (set) Token: 0x0600A7AC RID: 42924 RVA: 0x000F7807 File Offset: 0x000F5A07
		public unsafe bool bCanBeMainNavData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bCanBeMainNavData) & ANavigationData.__PropertyMask_bCanBeMainNavData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bCanBeMainNavData) = ((*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bCanBeMainNavData) & ~ANavigationData.__PropertyMask_bCanBeMainNavData) | (value ? ANavigationData.__PropertyMask_bCanBeMainNavData : 0));
			}
		}

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x0600A7AD RID: 42925 RVA: 0x000F7837 File Offset: 0x000F5A37
		// (set) Token: 0x0600A7AE RID: 42926 RVA: 0x000F7850 File Offset: 0x000F5A50
		public unsafe bool bCanSpawnOnRebuild
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bCanSpawnOnRebuild) & ANavigationData.__PropertyMask_bCanSpawnOnRebuild) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bCanSpawnOnRebuild) = ((*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bCanSpawnOnRebuild) & ~ANavigationData.__PropertyMask_bCanSpawnOnRebuild) | (value ? ANavigationData.__PropertyMask_bCanSpawnOnRebuild : 0));
			}
		}

		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x0600A7AF RID: 42927 RVA: 0x000F7880 File Offset: 0x000F5A80
		// (set) Token: 0x0600A7B0 RID: 42928 RVA: 0x000F7899 File Offset: 0x000F5A99
		public unsafe bool bRebuildAtRuntime_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bRebuildAtRuntime_DEPRECATED) & ANavigationData.__PropertyMask_bRebuildAtRuntime_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bRebuildAtRuntime_DEPRECATED) = ((*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bRebuildAtRuntime_DEPRECATED) & ~ANavigationData.__PropertyMask_bRebuildAtRuntime_DEPRECATED) | (value ? ANavigationData.__PropertyMask_bRebuildAtRuntime_DEPRECATED : 0));
			}
		}

		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x0600A7B1 RID: 42929 RVA: 0x000F78C9 File Offset: 0x000F5AC9
		// (set) Token: 0x0600A7B2 RID: 42930 RVA: 0x000F78D9 File Offset: 0x000F5AD9
		public unsafe float ObservedPathsTickInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_ObservedPathsTickInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_ObservedPathsTickInterval) = value;
			}
		}

		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x0600A7B3 RID: 42931 RVA: 0x000F78EA File Offset: 0x000F5AEA
		// (set) Token: 0x0600A7B4 RID: 42932 RVA: 0x000F78FA File Offset: 0x000F5AFA
		public unsafe uint DataVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_DataVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_DataVersion) = (int)value;
			}
		}

		// Token: 0x0600A7B5 RID: 42933 RVA: 0x000F790B File Offset: 0x000F5B0B
		static ANavigationData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavigationData");
		}

		// Token: 0x0600A7B6 RID: 42934 RVA: 0x000F791C File Offset: 0x000F5B1C
		protected ANavigationData() : this(BuiltinUtils.AllocNativeUObject(ANavigationData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A7B7 RID: 42935 RVA: 0x000F7944 File Offset: 0x000F5B44
		protected ANavigationData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040047D2 RID: 18386
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavigationData";

		// Token: 0x040047D3 RID: 18387
		private static IntPtr _ClassPtr;

		// Token: 0x040047D4 RID: 18388
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040047D5 RID: 18389
		internal static int __PropertyOffset_RenderingComp;

		// Token: 0x040047D6 RID: 18390
		internal static int __PropertyOffset_bEnableDrawing;

		// Token: 0x040047D7 RID: 18391
		internal static byte __PropertyMask_bEnableDrawing;

		// Token: 0x040047D8 RID: 18392
		internal static int __PropertyOffset_bForceRebuildOnLoad;

		// Token: 0x040047D9 RID: 18393
		internal static byte __PropertyMask_bForceRebuildOnLoad;

		// Token: 0x040047DA RID: 18394
		internal static int __PropertyOffset_bAutoDestroyWhenNoNavigation;

		// Token: 0x040047DB RID: 18395
		internal static byte __PropertyMask_bAutoDestroyWhenNoNavigation;

		// Token: 0x040047DC RID: 18396
		internal static int __PropertyOffset_bCanBeMainNavData;

		// Token: 0x040047DD RID: 18397
		internal static byte __PropertyMask_bCanBeMainNavData;

		// Token: 0x040047DE RID: 18398
		internal static int __PropertyOffset_bCanSpawnOnRebuild;

		// Token: 0x040047DF RID: 18399
		internal static byte __PropertyMask_bCanSpawnOnRebuild;

		// Token: 0x040047E0 RID: 18400
		internal static int __PropertyOffset_bRebuildAtRuntime_DEPRECATED;

		// Token: 0x040047E1 RID: 18401
		internal static byte __PropertyMask_bRebuildAtRuntime_DEPRECATED;

		// Token: 0x040047E2 RID: 18402
		internal static int __PropertyOffset_ObservedPathsTickInterval;

		// Token: 0x040047E3 RID: 18403
		internal static int __PropertyOffset_DataVersion;
	}
}
