using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000230 RID: 560
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Level")]
	[UnrealStructLayout(2400, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2400)]
	public class ULevel : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002D2E RID: 11566 RVA: 0x0003FCE0 File Offset: 0x0003DEE0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevel._ClassPtr;
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x0003FCEC File Offset: 0x0003DEEC
		public ULevel() : this(BuiltinUtils.AllocNativeUObject(ULevel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x0003FD14 File Offset: 0x0003DF14
		[NullableContext(1)]
		public ULevel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06002D31 RID: 11569 RVA: 0x0003FD47 File Offset: 0x0003DF47
		// (set) Token: 0x06002D32 RID: 11570 RVA: 0x0003FD5B File Offset: 0x0003DF5B
		public unsafe UWorld OwningWorld
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorld>(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_OwningWorld);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_OwningWorld, value);
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06002D33 RID: 11571 RVA: 0x0003FD70 File Offset: 0x0003DF70
		// (set) Token: 0x06002D34 RID: 11572 RVA: 0x0003FD84 File Offset: 0x0003DF84
		public unsafe FIntVector LastWorldOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_LastWorldOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_LastWorldOrigin) = value;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06002D35 RID: 11573 RVA: 0x0003FD99 File Offset: 0x0003DF99
		// (set) Token: 0x06002D36 RID: 11574 RVA: 0x0003FDA9 File Offset: 0x0003DFA9
		public unsafe int NumTextureStreamingUnbuiltComponents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_NumTextureStreamingUnbuiltComponents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_NumTextureStreamingUnbuiltComponents) = value;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06002D37 RID: 11575 RVA: 0x0003FDBA File Offset: 0x0003DFBA
		// (set) Token: 0x06002D38 RID: 11576 RVA: 0x0003FDCA File Offset: 0x0003DFCA
		public unsafe int NumTextureStreamingDirtyResources
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_NumTextureStreamingDirtyResources);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_NumTextureStreamingDirtyResources) = value;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06002D39 RID: 11577 RVA: 0x0003FDDB File Offset: 0x0003DFDB
		// (set) Token: 0x06002D3A RID: 11578 RVA: 0x0003FDEF File Offset: 0x0003DFEF
		public unsafe ANavigationObjectBase NavListStart
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ANavigationObjectBase>(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_NavListStart);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_NavListStart, value);
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06002D3B RID: 11579 RVA: 0x0003FE04 File Offset: 0x0003E004
		// (set) Token: 0x06002D3C RID: 11580 RVA: 0x0003FE18 File Offset: 0x0003E018
		public unsafe ANavigationObjectBase NavListEnd
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ANavigationObjectBase>(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_NavListEnd);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_NavListEnd, value);
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06002D3D RID: 11581 RVA: 0x0003FE2D File Offset: 0x0003E02D
		// (set) Token: 0x06002D3E RID: 11582 RVA: 0x0003FE3D File Offset: 0x0003E03D
		public unsafe float LightmapTotalSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_LightmapTotalSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_LightmapTotalSize) = value;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06002D3F RID: 11583 RVA: 0x0003FE4E File Offset: 0x0003E04E
		// (set) Token: 0x06002D40 RID: 11584 RVA: 0x0003FE5E File Offset: 0x0003E05E
		public unsafe float ShadowmapTotalSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_ShadowmapTotalSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_ShadowmapTotalSize) = value;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06002D41 RID: 11585 RVA: 0x0003FE70 File Offset: 0x0003E070
		// (set) Token: 0x06002D42 RID: 11586 RVA: 0x0003FEA9 File Offset: 0x0003E0A9
		[Nullable(1)]
		public TArray<FVector> StaticNavigableGeometry
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._StaticNavigableGeometry) == null)
				{
					result = (this._StaticNavigableGeometry = new TArray<FVector>(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_StaticNavigableGeometry, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StaticNavigableGeometry.CopyAssign(value);
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06002D43 RID: 11587 RVA: 0x0003FEB8 File Offset: 0x0003E0B8
		// (set) Token: 0x06002D44 RID: 11588 RVA: 0x0003FEF1 File Offset: 0x0003E0F1
		[Nullable(1)]
		public TArray<FGuid> StreamingTextureGuids
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FGuid> result;
				if ((result = this._StreamingTextureGuids) == null)
				{
					result = (this._StreamingTextureGuids = new TArray<FGuid>(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_StreamingTextureGuids, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StreamingTextureGuids.CopyAssign(value);
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06002D45 RID: 11589 RVA: 0x0003FEFF File Offset: 0x0003E0FF
		// (set) Token: 0x06002D46 RID: 11590 RVA: 0x0003FF13 File Offset: 0x0003E113
		public unsafe FGuid LevelBuildDataId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_LevelBuildDataId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_LevelBuildDataId) = value;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06002D47 RID: 11591 RVA: 0x0003FF28 File Offset: 0x0003E128
		// (set) Token: 0x06002D48 RID: 11592 RVA: 0x0003FF3C File Offset: 0x0003E13C
		public unsafe FIntVector LightBuildLevelOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_LightBuildLevelOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_LightBuildLevelOffset) = value;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06002D49 RID: 11593 RVA: 0x0003FF51 File Offset: 0x0003E151
		// (set) Token: 0x06002D4A RID: 11594 RVA: 0x0003FF6A File Offset: 0x0003E16A
		public unsafe bool bIsLightingScenario
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bIsLightingScenario) & ULevel.__PropertyMask_bIsLightingScenario) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevel.__PropertyOffset_bIsLightingScenario) = ((*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bIsLightingScenario) & ~ULevel.__PropertyMask_bIsLightingScenario) | (value ? ULevel.__PropertyMask_bIsLightingScenario : 0));
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06002D4B RID: 11595 RVA: 0x0003FF9A File Offset: 0x0003E19A
		// (set) Token: 0x06002D4C RID: 11596 RVA: 0x0003FFB3 File Offset: 0x0003E1B3
		public unsafe bool bTextureStreamingRotationChanged
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bTextureStreamingRotationChanged) & ULevel.__PropertyMask_bTextureStreamingRotationChanged) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevel.__PropertyOffset_bTextureStreamingRotationChanged) = ((*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bTextureStreamingRotationChanged) & ~ULevel.__PropertyMask_bTextureStreamingRotationChanged) | (value ? ULevel.__PropertyMask_bTextureStreamingRotationChanged : 0));
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06002D4D RID: 11597 RVA: 0x0003FFE3 File Offset: 0x0003E1E3
		// (set) Token: 0x06002D4E RID: 11598 RVA: 0x0003FFFC File Offset: 0x0003E1FC
		public unsafe bool bStaticComponentsRegisteredInStreamingManager
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bStaticComponentsRegisteredInStreamingManager) & ULevel.__PropertyMask_bStaticComponentsRegisteredInStreamingManager) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevel.__PropertyOffset_bStaticComponentsRegisteredInStreamingManager) = ((*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bStaticComponentsRegisteredInStreamingManager) & ~ULevel.__PropertyMask_bStaticComponentsRegisteredInStreamingManager) | (value ? ULevel.__PropertyMask_bStaticComponentsRegisteredInStreamingManager : 0));
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06002D4F RID: 11599 RVA: 0x0004002C File Offset: 0x0003E22C
		// (set) Token: 0x06002D50 RID: 11600 RVA: 0x00040045 File Offset: 0x0003E245
		public unsafe bool bIsVisible
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bIsVisible) & ULevel.__PropertyMask_bIsVisible) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevel.__PropertyOffset_bIsVisible) = ((*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bIsVisible) & ~ULevel.__PropertyMask_bIsVisible) | (value ? ULevel.__PropertyMask_bIsVisible : 0));
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06002D51 RID: 11601 RVA: 0x00040075 File Offset: 0x0003E275
		// (set) Token: 0x06002D52 RID: 11602 RVA: 0x0004008E File Offset: 0x0003E28E
		public unsafe bool bIsPartitioned
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bIsPartitioned) & ULevel.__PropertyMask_bIsPartitioned) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevel.__PropertyOffset_bIsPartitioned) = ((*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bIsPartitioned) & ~ULevel.__PropertyMask_bIsPartitioned) | (value ? ULevel.__PropertyMask_bIsPartitioned : 0));
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06002D53 RID: 11603 RVA: 0x000400BE File Offset: 0x0003E2BE
		// (set) Token: 0x06002D54 RID: 11604 RVA: 0x000400D7 File Offset: 0x0003E2D7
		public unsafe bool bTickEvenPaused
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bTickEvenPaused) & ULevel.__PropertyMask_bTickEvenPaused) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevel.__PropertyOffset_bTickEvenPaused) = ((*(base.NativePtr + (IntPtr)ULevel.__PropertyOffset_bTickEvenPaused) & ~ULevel.__PropertyMask_bTickEvenPaused) | (value ? ULevel.__PropertyMask_bTickEvenPaused : 0));
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06002D55 RID: 11605 RVA: 0x00040107 File Offset: 0x0003E307
		// (set) Token: 0x06002D56 RID: 11606 RVA: 0x0004011B File Offset: 0x0003E31B
		public unsafe AWorldSettings WorldSettings
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AWorldSettings>(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_WorldSettings);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevel.__PropertyOffset_WorldSettings, value);
			}
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x00040130 File Offset: 0x0003E330
		static ULevel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Level");
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x0004013E File Offset: 0x0003E33E
		protected ULevel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E58 RID: 3672
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Level";

		// Token: 0x04000E59 RID: 3673
		private static IntPtr _ClassPtr;

		// Token: 0x04000E5A RID: 3674
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000E5B RID: 3675
		internal static int __PropertyOffset_OwningWorld;

		// Token: 0x04000E5C RID: 3676
		internal static int __PropertyOffset_LastWorldOrigin;

		// Token: 0x04000E5D RID: 3677
		internal static int __PropertyOffset_NumTextureStreamingUnbuiltComponents;

		// Token: 0x04000E5E RID: 3678
		internal static int __PropertyOffset_NumTextureStreamingDirtyResources;

		// Token: 0x04000E5F RID: 3679
		internal static int __PropertyOffset_NavListStart;

		// Token: 0x04000E60 RID: 3680
		internal static int __PropertyOffset_NavListEnd;

		// Token: 0x04000E61 RID: 3681
		internal static int __PropertyOffset_LightmapTotalSize;

		// Token: 0x04000E62 RID: 3682
		internal static int __PropertyOffset_ShadowmapTotalSize;

		// Token: 0x04000E63 RID: 3683
		internal static int __PropertyOffset_StaticNavigableGeometry;

		// Token: 0x04000E64 RID: 3684
		private TArray<FVector> _StaticNavigableGeometry;

		// Token: 0x04000E65 RID: 3685
		internal static int __PropertyOffset_StreamingTextureGuids;

		// Token: 0x04000E66 RID: 3686
		private TArray<FGuid> _StreamingTextureGuids;

		// Token: 0x04000E67 RID: 3687
		internal static int __PropertyOffset_LevelBuildDataId;

		// Token: 0x04000E68 RID: 3688
		internal static int __PropertyOffset_LightBuildLevelOffset;

		// Token: 0x04000E69 RID: 3689
		internal static int __PropertyOffset_bIsLightingScenario;

		// Token: 0x04000E6A RID: 3690
		internal static byte __PropertyMask_bIsLightingScenario;

		// Token: 0x04000E6B RID: 3691
		internal static int __PropertyOffset_bTextureStreamingRotationChanged;

		// Token: 0x04000E6C RID: 3692
		internal static byte __PropertyMask_bTextureStreamingRotationChanged;

		// Token: 0x04000E6D RID: 3693
		internal static int __PropertyOffset_bStaticComponentsRegisteredInStreamingManager;

		// Token: 0x04000E6E RID: 3694
		internal static byte __PropertyMask_bStaticComponentsRegisteredInStreamingManager;

		// Token: 0x04000E6F RID: 3695
		internal static int __PropertyOffset_bIsVisible;

		// Token: 0x04000E70 RID: 3696
		internal static byte __PropertyMask_bIsVisible;

		// Token: 0x04000E71 RID: 3697
		internal static int __PropertyOffset_bIsPartitioned;

		// Token: 0x04000E72 RID: 3698
		internal static byte __PropertyMask_bIsPartitioned;

		// Token: 0x04000E73 RID: 3699
		internal static int __PropertyOffset_bTickEvenPaused;

		// Token: 0x04000E74 RID: 3700
		internal static byte __PropertyMask_bTickEvenPaused;

		// Token: 0x04000E75 RID: 3701
		internal static int __PropertyOffset_WorldSettings;
	}
}
