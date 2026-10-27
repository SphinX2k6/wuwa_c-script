using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C77 RID: 7287
	[UnrealObjectPath("/Script/KuroRopeEffect.RopeEffectDataAsset")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class URopeEffectDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C452 RID: 115794 RVA: 0x0029AC7E File Offset: 0x00298E7E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URopeEffectDataAsset._ClassPtr;
		}

		// Token: 0x0601C453 RID: 115795 RVA: 0x0029AC8C File Offset: 0x00298E8C
		public URopeEffectDataAsset() : this(BuiltinUtils.AllocNativeUObject(URopeEffectDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C454 RID: 115796 RVA: 0x0029ACB4 File Offset: 0x00298EB4
		[NullableContext(1)]
		public URopeEffectDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URopeEffectDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007242 RID: 29250
		// (get) Token: 0x0601C455 RID: 115797 RVA: 0x0029ACE7 File Offset: 0x00298EE7
		// (set) Token: 0x0601C456 RID: 115798 RVA: 0x0029ACF7 File Offset: 0x00298EF7
		public unsafe ERopeAxisMode AxisMode
		{
			get
			{
				return (ERopeAxisMode)(*(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_AxisMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_AxisMode) = (byte)value;
			}
		}

		// Token: 0x17007243 RID: 29251
		// (get) Token: 0x0601C457 RID: 115799 RVA: 0x0029AD08 File Offset: 0x00298F08
		// (set) Token: 0x0601C458 RID: 115800 RVA: 0x0029AD18 File Offset: 0x00298F18
		public unsafe int NumRopes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_NumRopes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_NumRopes) = value;
			}
		}

		// Token: 0x17007244 RID: 29252
		// (get) Token: 0x0601C459 RID: 115801 RVA: 0x0029AD29 File Offset: 0x00298F29
		// (set) Token: 0x0601C45A RID: 115802 RVA: 0x0029AD39 File Offset: 0x00298F39
		public unsafe float SliceStartAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_SliceStartAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_SliceStartAlpha) = value;
			}
		}

		// Token: 0x17007245 RID: 29253
		// (get) Token: 0x0601C45B RID: 115803 RVA: 0x0029AD4A File Offset: 0x00298F4A
		// (set) Token: 0x0601C45C RID: 115804 RVA: 0x0029AD5A File Offset: 0x00298F5A
		public unsafe float SliceEndAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_SliceEndAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_SliceEndAlpha) = value;
			}
		}

		// Token: 0x17007246 RID: 29254
		// (get) Token: 0x0601C45D RID: 115805 RVA: 0x0029AD6B File Offset: 0x00298F6B
		// (set) Token: 0x0601C45E RID: 115806 RVA: 0x0029AD7B File Offset: 0x00298F7B
		public unsafe float SliceThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_SliceThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_SliceThickness) = value;
			}
		}

		// Token: 0x17007247 RID: 29255
		// (get) Token: 0x0601C45F RID: 115807 RVA: 0x0029AD8C File Offset: 0x00298F8C
		// (set) Token: 0x0601C460 RID: 115808 RVA: 0x0029AD9C File Offset: 0x00298F9C
		public unsafe int PointsPerRope
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_PointsPerRope);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_PointsPerRope) = value;
			}
		}

		// Token: 0x17007248 RID: 29256
		// (get) Token: 0x0601C461 RID: 115809 RVA: 0x0029ADAD File Offset: 0x00298FAD
		// (set) Token: 0x0601C462 RID: 115810 RVA: 0x0029ADBD File Offset: 0x00298FBD
		public unsafe float RadiusPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_RadiusPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_RadiusPadding) = value;
			}
		}

		// Token: 0x17007249 RID: 29257
		// (get) Token: 0x0601C463 RID: 115811 RVA: 0x0029ADCE File Offset: 0x00298FCE
		// (set) Token: 0x0601C464 RID: 115812 RVA: 0x0029ADDE File Offset: 0x00298FDE
		public unsafe int MinPointsPerSlice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_MinPointsPerSlice);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_MinPointsPerSlice) = value;
			}
		}

		// Token: 0x1700724A RID: 29258
		// (get) Token: 0x0601C465 RID: 115813 RVA: 0x0029ADEF File Offset: 0x00298FEF
		// (set) Token: 0x0601C466 RID: 115814 RVA: 0x0029ADFF File Offset: 0x00298FFF
		public unsafe int PreferredLODIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_PreferredLODIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_PreferredLODIndex) = value;
			}
		}

		// Token: 0x1700724B RID: 29259
		// (get) Token: 0x0601C467 RID: 115815 RVA: 0x0029AE10 File Offset: 0x00299010
		// (set) Token: 0x0601C468 RID: 115816 RVA: 0x0029AE20 File Offset: 0x00299020
		public unsafe bool bClosedLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_bClosedLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_bClosedLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700724C RID: 29260
		// (get) Token: 0x0601C469 RID: 115817 RVA: 0x0029AE31 File Offset: 0x00299031
		// (set) Token: 0x0601C46A RID: 115818 RVA: 0x0029AE41 File Offset: 0x00299041
		public unsafe float SplineVisualizationWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_SplineVisualizationWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_SplineVisualizationWidth) = value;
			}
		}

		// Token: 0x1700724D RID: 29261
		// (get) Token: 0x0601C46B RID: 115819 RVA: 0x0029AE52 File Offset: 0x00299052
		// (set) Token: 0x0601C46C RID: 115820 RVA: 0x0029AE66 File Offset: 0x00299066
		public unsafe FLinearColor SplineColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_SplineColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_SplineColor) = value;
			}
		}

		// Token: 0x1700724E RID: 29262
		// (get) Token: 0x0601C46D RID: 115821 RVA: 0x0029AE7B File Offset: 0x0029907B
		// (set) Token: 0x0601C46E RID: 115822 RVA: 0x0029AE8B File Offset: 0x0029908B
		public unsafe bool bEnableDynamicRopeTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_bEnableDynamicRopeTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_bEnableDynamicRopeTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700724F RID: 29263
		// (get) Token: 0x0601C46F RID: 115823 RVA: 0x0029AE9C File Offset: 0x0029909C
		// (set) Token: 0x0601C470 RID: 115824 RVA: 0x0029AEAC File Offset: 0x002990AC
		public unsafe int DynamicRopeUpdateRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_DynamicRopeUpdateRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_DynamicRopeUpdateRate) = value;
			}
		}

		// Token: 0x17007250 RID: 29264
		// (get) Token: 0x0601C471 RID: 115825 RVA: 0x0029AEBD File Offset: 0x002990BD
		// (set) Token: 0x0601C472 RID: 115826 RVA: 0x0029AECD File Offset: 0x002990CD
		public unsafe float PositionChangeThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_PositionChangeThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeEffectDataAsset.__PropertyOffset_PositionChangeThreshold) = value;
			}
		}

		// Token: 0x0601C473 RID: 115827 RVA: 0x0029AEDE File Offset: 0x002990DE
		static URopeEffectDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRopeEffect.RopeEffectDataAsset");
		}

		// Token: 0x0601C474 RID: 115828 RVA: 0x0029AEEC File Offset: 0x002990EC
		protected URopeEffectDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F336 RID: 62262
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRopeEffect.RopeEffectDataAsset";

		// Token: 0x0400F337 RID: 62263
		private static IntPtr _ClassPtr;

		// Token: 0x0400F338 RID: 62264
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F339 RID: 62265
		internal static int __PropertyOffset_AxisMode;

		// Token: 0x0400F33A RID: 62266
		internal static int __PropertyOffset_NumRopes;

		// Token: 0x0400F33B RID: 62267
		internal static int __PropertyOffset_SliceStartAlpha;

		// Token: 0x0400F33C RID: 62268
		internal static int __PropertyOffset_SliceEndAlpha;

		// Token: 0x0400F33D RID: 62269
		internal static int __PropertyOffset_SliceThickness;

		// Token: 0x0400F33E RID: 62270
		internal static int __PropertyOffset_PointsPerRope;

		// Token: 0x0400F33F RID: 62271
		internal static int __PropertyOffset_RadiusPadding;

		// Token: 0x0400F340 RID: 62272
		internal static int __PropertyOffset_MinPointsPerSlice;

		// Token: 0x0400F341 RID: 62273
		internal static int __PropertyOffset_PreferredLODIndex;

		// Token: 0x0400F342 RID: 62274
		internal static int __PropertyOffset_bClosedLoop;

		// Token: 0x0400F343 RID: 62275
		internal static int __PropertyOffset_SplineVisualizationWidth;

		// Token: 0x0400F344 RID: 62276
		internal static int __PropertyOffset_SplineColor;

		// Token: 0x0400F345 RID: 62277
		internal static int __PropertyOffset_bEnableDynamicRopeTick;

		// Token: 0x0400F346 RID: 62278
		internal static int __PropertyOffset_DynamicRopeUpdateRate;

		// Token: 0x0400F347 RID: 62279
		internal static int __PropertyOffset_PositionChangeThreshold;
	}
}
