using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BDD RID: 3037
	[UnrealObjectPath("/Script/Engine.FlowMapSVTAuthoringSettings")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FFlowMapSVTAuthoringSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009554 RID: 38228 RVA: 0x000D5017 File Offset: 0x000D3217
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFlowMapSVTAuthoringSettings._ScriptStructPtr != 0) ? FFlowMapSVTAuthoringSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FlowMapSVTAuthoringSettings", ref FFlowMapSVTAuthoringSettings._ScriptStructPtr);
		}

		// Token: 0x170023B9 RID: 9145
		// (get) Token: 0x06009555 RID: 38229 RVA: 0x000D503B File Offset: 0x000D323B
		// (set) Token: 0x06009556 RID: 38230 RVA: 0x000D504F File Offset: 0x000D324F
		public unsafe FVector2D WorldOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_WorldOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_WorldOrigin) = value;
			}
		}

		// Token: 0x170023BA RID: 9146
		// (get) Token: 0x06009557 RID: 38231 RVA: 0x000D5064 File Offset: 0x000D3264
		// (set) Token: 0x06009558 RID: 38232 RVA: 0x000D5078 File Offset: 0x000D3278
		public unsafe FVector2D WorldUnitsPerTexel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_WorldUnitsPerTexel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_WorldUnitsPerTexel) = value;
			}
		}

		// Token: 0x170023BB RID: 9147
		// (get) Token: 0x06009559 RID: 38233 RVA: 0x000D508D File Offset: 0x000D328D
		// (set) Token: 0x0600955A RID: 38234 RVA: 0x000D50A1 File Offset: 0x000D32A1
		public unsafe FVector2D WorldSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_WorldSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_WorldSize) = value;
			}
		}

		// Token: 0x170023BC RID: 9148
		// (get) Token: 0x0600955B RID: 38235 RVA: 0x000D50B6 File Offset: 0x000D32B6
		// (set) Token: 0x0600955C RID: 38236 RVA: 0x000D50CA File Offset: 0x000D32CA
		public unsafe FIntPoint LogicalResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_LogicalResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_LogicalResolution) = value;
			}
		}

		// Token: 0x170023BD RID: 9149
		// (get) Token: 0x0600955D RID: 38237 RVA: 0x000D50DF File Offset: 0x000D32DF
		// (set) Token: 0x0600955E RID: 38238 RVA: 0x000D50EF File Offset: 0x000D32EF
		public unsafe int TileSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_TileSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_TileSize) = value;
			}
		}

		// Token: 0x170023BE RID: 9150
		// (get) Token: 0x0600955F RID: 38239 RVA: 0x000D5100 File Offset: 0x000D3300
		// (set) Token: 0x06009560 RID: 38240 RVA: 0x000D5110 File Offset: 0x000D3310
		public unsafe int TileBorderSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_TileBorderSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_TileBorderSize) = value;
			}
		}

		// Token: 0x170023BF RID: 9151
		// (get) Token: 0x06009561 RID: 38241 RVA: 0x000D5121 File Offset: 0x000D3321
		// (set) Token: 0x06009562 RID: 38242 RVA: 0x000D5131 File Offset: 0x000D3331
		public unsafe int DenseTailStartMip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_DenseTailStartMip);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_DenseTailStartMip) = value;
			}
		}

		// Token: 0x170023C0 RID: 9152
		// (get) Token: 0x06009563 RID: 38243 RVA: 0x000D5142 File Offset: 0x000D3342
		// (set) Token: 0x06009564 RID: 38244 RVA: 0x000D5152 File Offset: 0x000D3352
		public unsafe EFlowMapSVTRuntimePixelFormat RuntimePixelFormat
		{
			get
			{
				return (EFlowMapSVTRuntimePixelFormat)(*(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_RuntimePixelFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_RuntimePixelFormat) = (byte)value;
			}
		}

		// Token: 0x170023C1 RID: 9153
		// (get) Token: 0x06009565 RID: 38245 RVA: 0x000D5163 File Offset: 0x000D3363
		// (set) Token: 0x06009566 RID: 38246 RVA: 0x000D5177 File Offset: 0x000D3377
		public unsafe FVector2D DefaultFlowValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_DefaultFlowValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_DefaultFlowValue) = value;
			}
		}

		// Token: 0x170023C2 RID: 9154
		// (get) Token: 0x06009567 RID: 38247 RVA: 0x000D518C File Offset: 0x000D338C
		// (set) Token: 0x06009568 RID: 38248 RVA: 0x000D519C File Offset: 0x000D339C
		public unsafe float DefaultSurfaceHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_DefaultSurfaceHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_DefaultSurfaceHeight) = value;
			}
		}

		// Token: 0x170023C3 RID: 9155
		// (get) Token: 0x06009569 RID: 38249 RVA: 0x000D51AD File Offset: 0x000D33AD
		// (set) Token: 0x0600956A RID: 38250 RVA: 0x000D51BD File Offset: 0x000D33BD
		public unsafe float DefaultAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_DefaultAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFlowMapSVTAuthoringSettings.__PropertyOffset_DefaultAlpha) = value;
			}
		}

		// Token: 0x0600956B RID: 38251 RVA: 0x000D51CE File Offset: 0x000D33CE
		public FFlowMapSVTAuthoringSettings()
		{
		}

		// Token: 0x0600956C RID: 38252 RVA: 0x000D51D8 File Offset: 0x000D33D8
		public FFlowMapSVTAuthoringSettings(FVector2D WorldOrigin, FVector2D WorldUnitsPerTexel, FVector2D WorldSize, FIntPoint LogicalResolution, int TileSize, int TileBorderSize, int DenseTailStartMip, EFlowMapSVTRuntimePixelFormat RuntimePixelFormat, FVector2D DefaultFlowValue, float DefaultSurfaceHeight, float DefaultAlpha)
		{
			this.WorldOrigin = WorldOrigin;
			this.WorldUnitsPerTexel = WorldUnitsPerTexel;
			this.WorldSize = WorldSize;
			this.LogicalResolution = LogicalResolution;
			this.TileSize = TileSize;
			this.TileBorderSize = TileBorderSize;
			this.DenseTailStartMip = DenseTailStartMip;
			this.RuntimePixelFormat = RuntimePixelFormat;
			this.DefaultFlowValue = DefaultFlowValue;
			this.DefaultSurfaceHeight = DefaultSurfaceHeight;
			this.DefaultAlpha = DefaultAlpha;
		}

		// Token: 0x0600956D RID: 38253 RVA: 0x000D5240 File Offset: 0x000D3440
		protected override IntPtr GetUStructPtr()
		{
			return FFlowMapSVTAuthoringSettings.StaticStruct();
		}

		// Token: 0x0600956E RID: 38254 RVA: 0x000D524C File Offset: 0x000D344C
		[NullableContext(2)]
		public FFlowMapSVTAuthoringSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600956F RID: 38255 RVA: 0x000D5256 File Offset: 0x000D3456
		public FFlowMapSVTAuthoringSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009570 RID: 38256 RVA: 0x000D5261 File Offset: 0x000D3461
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFlowMapSVTAuthoringSettings(Pointer, false, true);
		}

		// Token: 0x06009571 RID: 38257 RVA: 0x000D526B File Offset: 0x000D346B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFlowMapSVTAuthoringSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040053CA RID: 21450
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.FlowMapSVTAuthoringSettings";

		// Token: 0x040053CB RID: 21451
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040053CC RID: 21452
		internal static int __PropertyOffset_WorldOrigin;

		// Token: 0x040053CD RID: 21453
		internal static int __PropertyOffset_WorldUnitsPerTexel;

		// Token: 0x040053CE RID: 21454
		internal static int __PropertyOffset_WorldSize;

		// Token: 0x040053CF RID: 21455
		internal static int __PropertyOffset_LogicalResolution;

		// Token: 0x040053D0 RID: 21456
		internal static int __PropertyOffset_TileSize;

		// Token: 0x040053D1 RID: 21457
		internal static int __PropertyOffset_TileBorderSize;

		// Token: 0x040053D2 RID: 21458
		internal static int __PropertyOffset_DenseTailStartMip;

		// Token: 0x040053D3 RID: 21459
		internal static int __PropertyOffset_RuntimePixelFormat;

		// Token: 0x040053D4 RID: 21460
		internal static int __PropertyOffset_DefaultFlowValue;

		// Token: 0x040053D5 RID: 21461
		internal static int __PropertyOffset_DefaultSurfaceHeight;

		// Token: 0x040053D6 RID: 21462
		internal static int __PropertyOffset_DefaultAlpha;
	}
}
