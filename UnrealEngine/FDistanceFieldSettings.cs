using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A65 RID: 6757
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.DistanceFieldSettings")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FDistanceFieldSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601907A RID: 102522 RVA: 0x0024FBBF File Offset: 0x0024DDBF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDistanceFieldSettings._ScriptStructPtr != 0) ? FDistanceFieldSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.DistanceFieldSettings", ref FDistanceFieldSettings._ScriptStructPtr);
		}

		// Token: 0x17006346 RID: 25414
		// (get) Token: 0x0601907B RID: 102523 RVA: 0x0024FBE3 File Offset: 0x0024DDE3
		// (set) Token: 0x0601907C RID: 102524 RVA: 0x0024FBFC File Offset: 0x0024DDFC
		public unsafe bool bOverride_OcclusionMaxDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_bOverride_OcclusionMaxDistance) & FDistanceFieldSettings.__PropertyMask_bOverride_OcclusionMaxDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_bOverride_OcclusionMaxDistance) = ((*(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_bOverride_OcclusionMaxDistance) & ~FDistanceFieldSettings.__PropertyMask_bOverride_OcclusionMaxDistance) | (value ? FDistanceFieldSettings.__PropertyMask_bOverride_OcclusionMaxDistance : 0));
			}
		}

		// Token: 0x17006347 RID: 25415
		// (get) Token: 0x0601907D RID: 102525 RVA: 0x0024FC2C File Offset: 0x0024DE2C
		// (set) Token: 0x0601907E RID: 102526 RVA: 0x0024FC45 File Offset: 0x0024DE45
		public unsafe bool bOverride_Contrast
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_bOverride_Contrast) & FDistanceFieldSettings.__PropertyMask_bOverride_Contrast) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_bOverride_Contrast) = ((*(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_bOverride_Contrast) & ~FDistanceFieldSettings.__PropertyMask_bOverride_Contrast) | (value ? FDistanceFieldSettings.__PropertyMask_bOverride_Contrast : 0));
			}
		}

		// Token: 0x17006348 RID: 25416
		// (get) Token: 0x0601907F RID: 102527 RVA: 0x0024FC75 File Offset: 0x0024DE75
		// (set) Token: 0x06019080 RID: 102528 RVA: 0x0024FC8E File Offset: 0x0024DE8E
		public unsafe bool bOverride_OcclusionExponent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_bOverride_OcclusionExponent) & FDistanceFieldSettings.__PropertyMask_bOverride_OcclusionExponent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_bOverride_OcclusionExponent) = ((*(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_bOverride_OcclusionExponent) & ~FDistanceFieldSettings.__PropertyMask_bOverride_OcclusionExponent) | (value ? FDistanceFieldSettings.__PropertyMask_bOverride_OcclusionExponent : 0));
			}
		}

		// Token: 0x17006349 RID: 25417
		// (get) Token: 0x06019081 RID: 102529 RVA: 0x0024FCBE File Offset: 0x0024DEBE
		// (set) Token: 0x06019082 RID: 102530 RVA: 0x0024FCD7 File Offset: 0x0024DED7
		public unsafe bool bOverride_MinOcclusion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_bOverride_MinOcclusion) & FDistanceFieldSettings.__PropertyMask_bOverride_MinOcclusion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_bOverride_MinOcclusion) = ((*(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_bOverride_MinOcclusion) & ~FDistanceFieldSettings.__PropertyMask_bOverride_MinOcclusion) | (value ? FDistanceFieldSettings.__PropertyMask_bOverride_MinOcclusion : 0));
			}
		}

		// Token: 0x1700634A RID: 25418
		// (get) Token: 0x06019083 RID: 102531 RVA: 0x0024FD07 File Offset: 0x0024DF07
		// (set) Token: 0x06019084 RID: 102532 RVA: 0x0024FD20 File Offset: 0x0024DF20
		public unsafe bool bOverride_OcclusionTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_bOverride_OcclusionTint) & FDistanceFieldSettings.__PropertyMask_bOverride_OcclusionTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_bOverride_OcclusionTint) = ((*(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_bOverride_OcclusionTint) & ~FDistanceFieldSettings.__PropertyMask_bOverride_OcclusionTint) | (value ? FDistanceFieldSettings.__PropertyMask_bOverride_OcclusionTint : 0));
			}
		}

		// Token: 0x1700634B RID: 25419
		// (get) Token: 0x06019085 RID: 102533 RVA: 0x0024FD50 File Offset: 0x0024DF50
		// (set) Token: 0x06019086 RID: 102534 RVA: 0x0024FD60 File Offset: 0x0024DF60
		public unsafe float OcclusionMaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_OcclusionMaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_OcclusionMaxDistance) = value;
			}
		}

		// Token: 0x1700634C RID: 25420
		// (get) Token: 0x06019087 RID: 102535 RVA: 0x0024FD71 File Offset: 0x0024DF71
		// (set) Token: 0x06019088 RID: 102536 RVA: 0x0024FD81 File Offset: 0x0024DF81
		public unsafe float Contrast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_Contrast);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_Contrast) = value;
			}
		}

		// Token: 0x1700634D RID: 25421
		// (get) Token: 0x06019089 RID: 102537 RVA: 0x0024FD92 File Offset: 0x0024DF92
		// (set) Token: 0x0601908A RID: 102538 RVA: 0x0024FDA2 File Offset: 0x0024DFA2
		public unsafe float OcclusionExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_OcclusionExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_OcclusionExponent) = value;
			}
		}

		// Token: 0x1700634E RID: 25422
		// (get) Token: 0x0601908B RID: 102539 RVA: 0x0024FDB3 File Offset: 0x0024DFB3
		// (set) Token: 0x0601908C RID: 102540 RVA: 0x0024FDC3 File Offset: 0x0024DFC3
		public unsafe float MinOcclusion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_MinOcclusion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_MinOcclusion) = value;
			}
		}

		// Token: 0x1700634F RID: 25423
		// (get) Token: 0x0601908D RID: 102541 RVA: 0x0024FDD4 File Offset: 0x0024DFD4
		// (set) Token: 0x0601908E RID: 102542 RVA: 0x0024FDE8 File Offset: 0x0024DFE8
		public unsafe FLinearColor OcclusionTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_OcclusionTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDistanceFieldSettings.__PropertyOffset_OcclusionTint) = value;
			}
		}

		// Token: 0x0601908F RID: 102543 RVA: 0x0024FDFD File Offset: 0x0024DFFD
		public FDistanceFieldSettings()
		{
		}

		// Token: 0x06019090 RID: 102544 RVA: 0x0024FE08 File Offset: 0x0024E008
		public FDistanceFieldSettings(bool bOverride_OcclusionMaxDistance, bool bOverride_Contrast, bool bOverride_OcclusionExponent, bool bOverride_MinOcclusion, bool bOverride_OcclusionTint, float OcclusionMaxDistance, float Contrast, float OcclusionExponent, float MinOcclusion, FLinearColor OcclusionTint)
		{
			this.bOverride_OcclusionMaxDistance = bOverride_OcclusionMaxDistance;
			this.bOverride_Contrast = bOverride_Contrast;
			this.bOverride_OcclusionExponent = bOverride_OcclusionExponent;
			this.bOverride_MinOcclusion = bOverride_MinOcclusion;
			this.bOverride_OcclusionTint = bOverride_OcclusionTint;
			this.OcclusionMaxDistance = OcclusionMaxDistance;
			this.Contrast = Contrast;
			this.OcclusionExponent = OcclusionExponent;
			this.MinOcclusion = MinOcclusion;
			this.OcclusionTint = OcclusionTint;
		}

		// Token: 0x06019091 RID: 102545 RVA: 0x0024FE68 File Offset: 0x0024E068
		protected override IntPtr GetUStructPtr()
		{
			return FDistanceFieldSettings.StaticStruct();
		}

		// Token: 0x06019092 RID: 102546 RVA: 0x0024FE74 File Offset: 0x0024E074
		[NullableContext(2)]
		public FDistanceFieldSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019093 RID: 102547 RVA: 0x0024FE7E File Offset: 0x0024E07E
		public FDistanceFieldSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019094 RID: 102548 RVA: 0x0024FE89 File Offset: 0x0024E089
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDistanceFieldSettings(Pointer, false, true);
		}

		// Token: 0x06019095 RID: 102549 RVA: 0x0024FE93 File Offset: 0x0024E093
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDistanceFieldSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400D89C RID: 55452
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.DistanceFieldSettings";

		// Token: 0x0400D89D RID: 55453
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D89E RID: 55454
		internal static int __PropertyOffset_bOverride_OcclusionMaxDistance;

		// Token: 0x0400D89F RID: 55455
		internal static byte __PropertyMask_bOverride_OcclusionMaxDistance;

		// Token: 0x0400D8A0 RID: 55456
		internal static int __PropertyOffset_bOverride_Contrast;

		// Token: 0x0400D8A1 RID: 55457
		internal static byte __PropertyMask_bOverride_Contrast;

		// Token: 0x0400D8A2 RID: 55458
		internal static int __PropertyOffset_bOverride_OcclusionExponent;

		// Token: 0x0400D8A3 RID: 55459
		internal static byte __PropertyMask_bOverride_OcclusionExponent;

		// Token: 0x0400D8A4 RID: 55460
		internal static int __PropertyOffset_bOverride_MinOcclusion;

		// Token: 0x0400D8A5 RID: 55461
		internal static byte __PropertyMask_bOverride_MinOcclusion;

		// Token: 0x0400D8A6 RID: 55462
		internal static int __PropertyOffset_bOverride_OcclusionTint;

		// Token: 0x0400D8A7 RID: 55463
		internal static byte __PropertyMask_bOverride_OcclusionTint;

		// Token: 0x0400D8A8 RID: 55464
		internal static int __PropertyOffset_OcclusionMaxDistance;

		// Token: 0x0400D8A9 RID: 55465
		internal static int __PropertyOffset_Contrast;

		// Token: 0x0400D8AA RID: 55466
		internal static int __PropertyOffset_OcclusionExponent;

		// Token: 0x0400D8AB RID: 55467
		internal static int __PropertyOffset_MinOcclusion;

		// Token: 0x0400D8AC RID: 55468
		internal static int __PropertyOffset_OcclusionTint;
	}
}
