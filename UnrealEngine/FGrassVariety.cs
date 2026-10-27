using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F68 RID: 8040
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.GrassVariety")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 336)]
	public class FGrassVariety : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E7C3 RID: 124867 RVA: 0x002D4FB5 File Offset: 0x002D31B5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGrassVariety._ScriptStructPtr != 0) ? FGrassVariety._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.GrassVariety", ref FGrassVariety._ScriptStructPtr);
		}

		// Token: 0x17007932 RID: 31026
		// (get) Token: 0x0601E7C4 RID: 124868 RVA: 0x002D4FD9 File Offset: 0x002D31D9
		// (set) Token: 0x0601E7C5 RID: 124869 RVA: 0x002D4FED File Offset: 0x002D31ED
		[Nullable(2)]
		public unsafe UStaticMesh GrassMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FGrassVariety.__PropertyOffset_GrassMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGrassVariety.__PropertyOffset_GrassMesh, value);
			}
		}

		// Token: 0x17007933 RID: 31027
		// (get) Token: 0x0601E7C6 RID: 124870 RVA: 0x002D5004 File Offset: 0x002D3204
		// (set) Token: 0x0601E7C7 RID: 124871 RVA: 0x002D5047 File Offset: 0x002D3247
		public TArray<UMaterialInterface> OverrideMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._OverrideMaterials) == null)
				{
					result = (this._OverrideMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_OverrideMaterials, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OverrideMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17007934 RID: 31028
		// (get) Token: 0x0601E7C8 RID: 124872 RVA: 0x002D5058 File Offset: 0x002D3258
		// (set) Token: 0x0601E7C9 RID: 124873 RVA: 0x002D509B File Offset: 0x002D329B
		public FPerPlatformFloat GrassDensity
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._GrassDensity) == null)
				{
					result = (this._GrassDensity = new FPerPlatformFloat(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_GrassDensity, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_GrassDensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007935 RID: 31029
		// (get) Token: 0x0601E7CA RID: 124874 RVA: 0x002D50BC File Offset: 0x002D32BC
		// (set) Token: 0x0601E7CB RID: 124875 RVA: 0x002D50CC File Offset: 0x002D32CC
		public unsafe bool bUseGrid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_bUseGrid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_bUseGrid) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007936 RID: 31030
		// (get) Token: 0x0601E7CC RID: 124876 RVA: 0x002D50DD File Offset: 0x002D32DD
		// (set) Token: 0x0601E7CD RID: 124877 RVA: 0x002D50ED File Offset: 0x002D32ED
		public unsafe float PlacementJitter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_PlacementJitter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_PlacementJitter) = value;
			}
		}

		// Token: 0x17007937 RID: 31031
		// (get) Token: 0x0601E7CE RID: 124878 RVA: 0x002D5100 File Offset: 0x002D3300
		// (set) Token: 0x0601E7CF RID: 124879 RVA: 0x002D5143 File Offset: 0x002D3343
		public FPerPlatformInt StartCullDistance
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._StartCullDistance) == null)
				{
					result = (this._StartCullDistance = new FPerPlatformInt(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_StartCullDistance, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_StartCullDistance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007938 RID: 31032
		// (get) Token: 0x0601E7D0 RID: 124880 RVA: 0x002D5164 File Offset: 0x002D3364
		// (set) Token: 0x0601E7D1 RID: 124881 RVA: 0x002D51A7 File Offset: 0x002D33A7
		public FPerPlatformInt EndCullDistance
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._EndCullDistance) == null)
				{
					result = (this._EndCullDistance = new FPerPlatformInt(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_EndCullDistance, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_EndCullDistance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007939 RID: 31033
		// (get) Token: 0x0601E7D2 RID: 124882 RVA: 0x002D51C8 File Offset: 0x002D33C8
		// (set) Token: 0x0601E7D3 RID: 124883 RVA: 0x002D51D8 File Offset: 0x002D33D8
		public unsafe int MinLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_MinLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_MinLOD) = value;
			}
		}

		// Token: 0x1700793A RID: 31034
		// (get) Token: 0x0601E7D4 RID: 124884 RVA: 0x002D51E9 File Offset: 0x002D33E9
		// (set) Token: 0x0601E7D5 RID: 124885 RVA: 0x002D51F9 File Offset: 0x002D33F9
		public unsafe EGrassScaling Scaling
		{
			get
			{
				return (EGrassScaling)(*(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_Scaling));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_Scaling) = (byte)value;
			}
		}

		// Token: 0x1700793B RID: 31035
		// (get) Token: 0x0601E7D6 RID: 124886 RVA: 0x002D520A File Offset: 0x002D340A
		// (set) Token: 0x0601E7D7 RID: 124887 RVA: 0x002D521E File Offset: 0x002D341E
		public unsafe FFloatInterval ScaleX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_ScaleX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_ScaleX) = value;
			}
		}

		// Token: 0x1700793C RID: 31036
		// (get) Token: 0x0601E7D8 RID: 124888 RVA: 0x002D5233 File Offset: 0x002D3433
		// (set) Token: 0x0601E7D9 RID: 124889 RVA: 0x002D5247 File Offset: 0x002D3447
		public unsafe FFloatInterval ScaleY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_ScaleY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_ScaleY) = value;
			}
		}

		// Token: 0x1700793D RID: 31037
		// (get) Token: 0x0601E7DA RID: 124890 RVA: 0x002D525C File Offset: 0x002D345C
		// (set) Token: 0x0601E7DB RID: 124891 RVA: 0x002D5270 File Offset: 0x002D3470
		public unsafe FFloatInterval ScaleZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_ScaleZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_ScaleZ) = value;
			}
		}

		// Token: 0x1700793E RID: 31038
		// (get) Token: 0x0601E7DC RID: 124892 RVA: 0x002D5285 File Offset: 0x002D3485
		// (set) Token: 0x0601E7DD RID: 124893 RVA: 0x002D5295 File Offset: 0x002D3495
		public unsafe bool RandomRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_RandomRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_RandomRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700793F RID: 31039
		// (get) Token: 0x0601E7DE RID: 124894 RVA: 0x002D52A6 File Offset: 0x002D34A6
		// (set) Token: 0x0601E7DF RID: 124895 RVA: 0x002D52B6 File Offset: 0x002D34B6
		public unsafe bool AlignToSurface
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_AlignToSurface) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_AlignToSurface) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007940 RID: 31040
		// (get) Token: 0x0601E7E0 RID: 124896 RVA: 0x002D52C7 File Offset: 0x002D34C7
		// (set) Token: 0x0601E7E1 RID: 124897 RVA: 0x002D52D7 File Offset: 0x002D34D7
		public unsafe bool bUseLandscapeLightmap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_bUseLandscapeLightmap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_bUseLandscapeLightmap) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007941 RID: 31041
		// (get) Token: 0x0601E7E2 RID: 124898 RVA: 0x002D52E8 File Offset: 0x002D34E8
		// (set) Token: 0x0601E7E3 RID: 124899 RVA: 0x002D532B File Offset: 0x002D352B
		public FLightingChannels LightingChannels
		{
			get
			{
				base.FastCheckIsValid();
				FLightingChannels result;
				if ((result = this._LightingChannels) == null)
				{
					result = (this._LightingChannels = new FLightingChannels(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_LightingChannels, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLightingChannels.StaticStruct(), base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_LightingChannels, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007942 RID: 31042
		// (get) Token: 0x0601E7E4 RID: 124900 RVA: 0x002D534C File Offset: 0x002D354C
		// (set) Token: 0x0601E7E5 RID: 124901 RVA: 0x002D535C File Offset: 0x002D355C
		public unsafe bool bReceivesDecals
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_bReceivesDecals) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_bReceivesDecals) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007943 RID: 31043
		// (get) Token: 0x0601E7E6 RID: 124902 RVA: 0x002D536D File Offset: 0x002D356D
		// (set) Token: 0x0601E7E7 RID: 124903 RVA: 0x002D537D File Offset: 0x002D357D
		public unsafe bool bCastDynamicShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_bCastDynamicShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_bCastDynamicShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007944 RID: 31044
		// (get) Token: 0x0601E7E8 RID: 124904 RVA: 0x002D538E File Offset: 0x002D358E
		// (set) Token: 0x0601E7E9 RID: 124905 RVA: 0x002D539E File Offset: 0x002D359E
		public unsafe bool bKeepInstanceBufferCPUCopy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_bKeepInstanceBufferCPUCopy) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGrassVariety.__PropertyOffset_bKeepInstanceBufferCPUCopy) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601E7EA RID: 124906 RVA: 0x002D53AF File Offset: 0x002D35AF
		public FGrassVariety()
		{
		}

		// Token: 0x0601E7EB RID: 124907 RVA: 0x002D53B8 File Offset: 0x002D35B8
		public FGrassVariety(UStaticMesh GrassMesh, TArray<UMaterialInterface> OverrideMaterials, FPerPlatformFloat GrassDensity, bool bUseGrid, float PlacementJitter, FPerPlatformInt StartCullDistance, FPerPlatformInt EndCullDistance, int MinLOD, EGrassScaling Scaling, FFloatInterval ScaleX, FFloatInterval ScaleY, FFloatInterval ScaleZ, bool RandomRotation, bool AlignToSurface, bool bUseLandscapeLightmap, FLightingChannels LightingChannels, bool bReceivesDecals, bool bCastDynamicShadow, bool bKeepInstanceBufferCPUCopy)
		{
			this.GrassMesh = GrassMesh;
			this.OverrideMaterials = OverrideMaterials;
			this.GrassDensity = GrassDensity;
			this.bUseGrid = bUseGrid;
			this.PlacementJitter = PlacementJitter;
			this.StartCullDistance = StartCullDistance;
			this.EndCullDistance = EndCullDistance;
			this.MinLOD = MinLOD;
			this.Scaling = Scaling;
			this.ScaleX = ScaleX;
			this.ScaleY = ScaleY;
			this.ScaleZ = ScaleZ;
			this.RandomRotation = RandomRotation;
			this.AlignToSurface = AlignToSurface;
			this.bUseLandscapeLightmap = bUseLandscapeLightmap;
			this.LightingChannels = LightingChannels;
			this.bReceivesDecals = bReceivesDecals;
			this.bCastDynamicShadow = bCastDynamicShadow;
			this.bKeepInstanceBufferCPUCopy = bKeepInstanceBufferCPUCopy;
		}

		// Token: 0x0601E7EC RID: 124908 RVA: 0x002D5460 File Offset: 0x002D3660
		protected override IntPtr GetUStructPtr()
		{
			return FGrassVariety.StaticStruct();
		}

		// Token: 0x0601E7ED RID: 124909 RVA: 0x002D546C File Offset: 0x002D366C
		[NullableContext(2)]
		public FGrassVariety(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E7EE RID: 124910 RVA: 0x002D5476 File Offset: 0x002D3676
		public FGrassVariety(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E7EF RID: 124911 RVA: 0x002D5481 File Offset: 0x002D3681
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGrassVariety(Pointer, false, true);
		}

		// Token: 0x0601E7F0 RID: 124912 RVA: 0x002D548B File Offset: 0x002D368B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGrassVariety(Pointer, MemoryOwner);
		}

		// Token: 0x04010799 RID: 67481
		public const string __ObjectPath = "/Script/Landscape.GrassVariety";

		// Token: 0x0401079A RID: 67482
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401079B RID: 67483
		internal static int __PropertyOffset_GrassMesh;

		// Token: 0x0401079C RID: 67484
		internal static int __PropertyOffset_OverrideMaterials;

		// Token: 0x0401079D RID: 67485
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _OverrideMaterials;

		// Token: 0x0401079E RID: 67486
		internal static int __PropertyOffset_GrassDensity;

		// Token: 0x0401079F RID: 67487
		[Nullable(2)]
		private FPerPlatformFloat _GrassDensity;

		// Token: 0x040107A0 RID: 67488
		internal static int __PropertyOffset_bUseGrid;

		// Token: 0x040107A1 RID: 67489
		internal static int __PropertyOffset_PlacementJitter;

		// Token: 0x040107A2 RID: 67490
		internal static int __PropertyOffset_StartCullDistance;

		// Token: 0x040107A3 RID: 67491
		[Nullable(2)]
		private FPerPlatformInt _StartCullDistance;

		// Token: 0x040107A4 RID: 67492
		internal static int __PropertyOffset_EndCullDistance;

		// Token: 0x040107A5 RID: 67493
		[Nullable(2)]
		private FPerPlatformInt _EndCullDistance;

		// Token: 0x040107A6 RID: 67494
		internal static int __PropertyOffset_MinLOD;

		// Token: 0x040107A7 RID: 67495
		internal static int __PropertyOffset_Scaling;

		// Token: 0x040107A8 RID: 67496
		internal static int __PropertyOffset_ScaleX;

		// Token: 0x040107A9 RID: 67497
		internal static int __PropertyOffset_ScaleY;

		// Token: 0x040107AA RID: 67498
		internal static int __PropertyOffset_ScaleZ;

		// Token: 0x040107AB RID: 67499
		internal static int __PropertyOffset_RandomRotation;

		// Token: 0x040107AC RID: 67500
		internal static int __PropertyOffset_AlignToSurface;

		// Token: 0x040107AD RID: 67501
		internal static int __PropertyOffset_bUseLandscapeLightmap;

		// Token: 0x040107AE RID: 67502
		internal static int __PropertyOffset_LightingChannels;

		// Token: 0x040107AF RID: 67503
		[Nullable(2)]
		private FLightingChannels _LightingChannels;

		// Token: 0x040107B0 RID: 67504
		internal static int __PropertyOffset_bReceivesDecals;

		// Token: 0x040107B1 RID: 67505
		internal static int __PropertyOffset_bCastDynamicShadow;

		// Token: 0x040107B2 RID: 67506
		internal static int __PropertyOffset_bKeepInstanceBufferCPUCopy;
	}
}
