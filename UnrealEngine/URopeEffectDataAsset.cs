using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000519 RID: 1305
	[UnrealObjectPath("/Script/KuroRopeEffect.RopeEffectDataAsset")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class URopeEffectDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060079F5 RID: 31221 RVA: 0x000B2F88 File Offset: 0x000B1188
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URopeEffectDataAsset._ClassPtr;
		}

		// Token: 0x060079F6 RID: 31222 RVA: 0x000B2F94 File Offset: 0x000B1194
		public URopeEffectDataAsset() : this(BuiltinUtils.AllocNativeUObject(URopeEffectDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060079F7 RID: 31223 RVA: 0x000B2FBC File Offset: 0x000B11BC
		[NullableContext(1)]
		public URopeEffectDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URopeEffectDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x060079F8 RID: 31224 RVA: 0x000B2FEF File Offset: 0x000B11EF
		// (set) Token: 0x060079F9 RID: 31225 RVA: 0x000B2FFF File Offset: 0x000B11FF
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

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x060079FA RID: 31226 RVA: 0x000B3010 File Offset: 0x000B1210
		// (set) Token: 0x060079FB RID: 31227 RVA: 0x000B3020 File Offset: 0x000B1220
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

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x060079FC RID: 31228 RVA: 0x000B3031 File Offset: 0x000B1231
		// (set) Token: 0x060079FD RID: 31229 RVA: 0x000B3041 File Offset: 0x000B1241
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

		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x060079FE RID: 31230 RVA: 0x000B3052 File Offset: 0x000B1252
		// (set) Token: 0x060079FF RID: 31231 RVA: 0x000B3062 File Offset: 0x000B1262
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

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x06007A00 RID: 31232 RVA: 0x000B3073 File Offset: 0x000B1273
		// (set) Token: 0x06007A01 RID: 31233 RVA: 0x000B3083 File Offset: 0x000B1283
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

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x06007A02 RID: 31234 RVA: 0x000B3094 File Offset: 0x000B1294
		// (set) Token: 0x06007A03 RID: 31235 RVA: 0x000B30A4 File Offset: 0x000B12A4
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

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06007A04 RID: 31236 RVA: 0x000B30B5 File Offset: 0x000B12B5
		// (set) Token: 0x06007A05 RID: 31237 RVA: 0x000B30C5 File Offset: 0x000B12C5
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

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x06007A06 RID: 31238 RVA: 0x000B30D6 File Offset: 0x000B12D6
		// (set) Token: 0x06007A07 RID: 31239 RVA: 0x000B30E6 File Offset: 0x000B12E6
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

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x06007A08 RID: 31240 RVA: 0x000B30F7 File Offset: 0x000B12F7
		// (set) Token: 0x06007A09 RID: 31241 RVA: 0x000B3107 File Offset: 0x000B1307
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

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x06007A0A RID: 31242 RVA: 0x000B3118 File Offset: 0x000B1318
		// (set) Token: 0x06007A0B RID: 31243 RVA: 0x000B3128 File Offset: 0x000B1328
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

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06007A0C RID: 31244 RVA: 0x000B3139 File Offset: 0x000B1339
		// (set) Token: 0x06007A0D RID: 31245 RVA: 0x000B314D File Offset: 0x000B134D
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

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x06007A0E RID: 31246 RVA: 0x000B3162 File Offset: 0x000B1362
		// (set) Token: 0x06007A0F RID: 31247 RVA: 0x000B3172 File Offset: 0x000B1372
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

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x06007A10 RID: 31248 RVA: 0x000B3183 File Offset: 0x000B1383
		// (set) Token: 0x06007A11 RID: 31249 RVA: 0x000B3193 File Offset: 0x000B1393
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

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x06007A12 RID: 31250 RVA: 0x000B31A4 File Offset: 0x000B13A4
		// (set) Token: 0x06007A13 RID: 31251 RVA: 0x000B31B4 File Offset: 0x000B13B4
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

		// Token: 0x06007A14 RID: 31252 RVA: 0x000B31C5 File Offset: 0x000B13C5
		static URopeEffectDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRopeEffect.RopeEffectDataAsset");
		}

		// Token: 0x06007A15 RID: 31253 RVA: 0x000B31D3 File Offset: 0x000B13D3
		protected URopeEffectDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040033D4 RID: 13268
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRopeEffect.RopeEffectDataAsset";

		// Token: 0x040033D5 RID: 13269
		private static IntPtr _ClassPtr;

		// Token: 0x040033D6 RID: 13270
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040033D7 RID: 13271
		internal static int __PropertyOffset_NumRopes;

		// Token: 0x040033D8 RID: 13272
		internal static int __PropertyOffset_SliceStartAlpha;

		// Token: 0x040033D9 RID: 13273
		internal static int __PropertyOffset_SliceEndAlpha;

		// Token: 0x040033DA RID: 13274
		internal static int __PropertyOffset_SliceThickness;

		// Token: 0x040033DB RID: 13275
		internal static int __PropertyOffset_PointsPerRope;

		// Token: 0x040033DC RID: 13276
		internal static int __PropertyOffset_RadiusPadding;

		// Token: 0x040033DD RID: 13277
		internal static int __PropertyOffset_MinPointsPerSlice;

		// Token: 0x040033DE RID: 13278
		internal static int __PropertyOffset_PreferredLODIndex;

		// Token: 0x040033DF RID: 13279
		internal static int __PropertyOffset_bClosedLoop;

		// Token: 0x040033E0 RID: 13280
		internal static int __PropertyOffset_SplineVisualizationWidth;

		// Token: 0x040033E1 RID: 13281
		internal static int __PropertyOffset_SplineColor;

		// Token: 0x040033E2 RID: 13282
		internal static int __PropertyOffset_bEnableDynamicRopeTick;

		// Token: 0x040033E3 RID: 13283
		internal static int __PropertyOffset_DynamicRopeUpdateRate;

		// Token: 0x040033E4 RID: 13284
		internal static int __PropertyOffset_PositionChangeThreshold;
	}
}
