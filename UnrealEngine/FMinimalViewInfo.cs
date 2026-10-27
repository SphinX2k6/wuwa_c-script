using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EB0 RID: 3760
	[UnrealObjectPath("/Script/Engine.MinimalViewInfo")]
	[UnrealStructLayout(2736, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2736)]
	public class FMinimalViewInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CB76 RID: 52086 RVA: 0x00128974 File Offset: 0x00126B74
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMinimalViewInfo._ScriptStructPtr != 0) ? FMinimalViewInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MinimalViewInfo", ref FMinimalViewInfo._ScriptStructPtr);
		}

		// Token: 0x17002FDB RID: 12251
		// (get) Token: 0x0600CB77 RID: 52087 RVA: 0x00128998 File Offset: 0x00126B98
		// (set) Token: 0x0600CB78 RID: 52088 RVA: 0x001289AC File Offset: 0x00126BAC
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17002FDC RID: 12252
		// (get) Token: 0x0600CB79 RID: 52089 RVA: 0x001289C1 File Offset: 0x00126BC1
		// (set) Token: 0x0600CB7A RID: 52090 RVA: 0x001289D5 File Offset: 0x00126BD5
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17002FDD RID: 12253
		// (get) Token: 0x0600CB7B RID: 52091 RVA: 0x001289EA File Offset: 0x00126BEA
		// (set) Token: 0x0600CB7C RID: 52092 RVA: 0x001289FA File Offset: 0x00126BFA
		public unsafe float FOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_FOV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_FOV) = value;
			}
		}

		// Token: 0x17002FDE RID: 12254
		// (get) Token: 0x0600CB7D RID: 52093 RVA: 0x00128A0B File Offset: 0x00126C0B
		// (set) Token: 0x0600CB7E RID: 52094 RVA: 0x00128A1B File Offset: 0x00126C1B
		public unsafe float DesiredFOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_DesiredFOV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_DesiredFOV) = value;
			}
		}

		// Token: 0x17002FDF RID: 12255
		// (get) Token: 0x0600CB7F RID: 52095 RVA: 0x00128A2C File Offset: 0x00126C2C
		// (set) Token: 0x0600CB80 RID: 52096 RVA: 0x00128A3C File Offset: 0x00126C3C
		public unsafe float OrthoWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_OrthoWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_OrthoWidth) = value;
			}
		}

		// Token: 0x17002FE0 RID: 12256
		// (get) Token: 0x0600CB81 RID: 52097 RVA: 0x00128A4D File Offset: 0x00126C4D
		// (set) Token: 0x0600CB82 RID: 52098 RVA: 0x00128A5D File Offset: 0x00126C5D
		public unsafe float OrthoNearClipPlane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_OrthoNearClipPlane);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_OrthoNearClipPlane) = value;
			}
		}

		// Token: 0x17002FE1 RID: 12257
		// (get) Token: 0x0600CB83 RID: 52099 RVA: 0x00128A6E File Offset: 0x00126C6E
		// (set) Token: 0x0600CB84 RID: 52100 RVA: 0x00128A7E File Offset: 0x00126C7E
		public unsafe float OrthoFarClipPlane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_OrthoFarClipPlane);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_OrthoFarClipPlane) = value;
			}
		}

		// Token: 0x17002FE2 RID: 12258
		// (get) Token: 0x0600CB85 RID: 52101 RVA: 0x00128A8F File Offset: 0x00126C8F
		// (set) Token: 0x0600CB86 RID: 52102 RVA: 0x00128A9F File Offset: 0x00126C9F
		public unsafe float AspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_AspectRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_AspectRatio) = value;
			}
		}

		// Token: 0x17002FE3 RID: 12259
		// (get) Token: 0x0600CB87 RID: 52103 RVA: 0x00128AB0 File Offset: 0x00126CB0
		// (set) Token: 0x0600CB88 RID: 52104 RVA: 0x00128AC9 File Offset: 0x00126CC9
		public unsafe bool bConstrainAspectRatio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_bConstrainAspectRatio) & FMinimalViewInfo.__PropertyMask_bConstrainAspectRatio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_bConstrainAspectRatio) = ((*(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_bConstrainAspectRatio) & ~FMinimalViewInfo.__PropertyMask_bConstrainAspectRatio) | (value ? FMinimalViewInfo.__PropertyMask_bConstrainAspectRatio : 0));
			}
		}

		// Token: 0x17002FE4 RID: 12260
		// (get) Token: 0x0600CB89 RID: 52105 RVA: 0x00128AF9 File Offset: 0x00126CF9
		// (set) Token: 0x0600CB8A RID: 52106 RVA: 0x00128B12 File Offset: 0x00126D12
		public unsafe bool bUseFieldOfViewForLOD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_bUseFieldOfViewForLOD) & FMinimalViewInfo.__PropertyMask_bUseFieldOfViewForLOD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_bUseFieldOfViewForLOD) = ((*(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_bUseFieldOfViewForLOD) & ~FMinimalViewInfo.__PropertyMask_bUseFieldOfViewForLOD) | (value ? FMinimalViewInfo.__PropertyMask_bUseFieldOfViewForLOD : 0));
			}
		}

		// Token: 0x17002FE5 RID: 12261
		// (get) Token: 0x0600CB8B RID: 52107 RVA: 0x00128B42 File Offset: 0x00126D42
		// (set) Token: 0x0600CB8C RID: 52108 RVA: 0x00128B56 File Offset: 0x00126D56
		public unsafe TEnumAsByte<ECameraProjectionMode> ProjectionMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_ProjectionMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_ProjectionMode) = value;
			}
		}

		// Token: 0x17002FE6 RID: 12262
		// (get) Token: 0x0600CB8D RID: 52109 RVA: 0x00128B6B File Offset: 0x00126D6B
		// (set) Token: 0x0600CB8E RID: 52110 RVA: 0x00128B7B File Offset: 0x00126D7B
		public unsafe float PostProcessBlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_PostProcessBlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_PostProcessBlendWeight) = value;
			}
		}

		// Token: 0x17002FE7 RID: 12263
		// (get) Token: 0x0600CB8F RID: 52111 RVA: 0x00128B8C File Offset: 0x00126D8C
		// (set) Token: 0x0600CB90 RID: 52112 RVA: 0x00128BCF File Offset: 0x00126DCF
		[Nullable(1)]
		public FPostProcessSettings PostProcessSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPostProcessSettings result;
				if ((result = this._PostProcessSettings) == null)
				{
					result = (this._PostProcessSettings = new FPostProcessSettings(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_PostProcessSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPostProcessSettings.StaticStruct(), base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_PostProcessSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002FE8 RID: 12264
		// (get) Token: 0x0600CB91 RID: 52113 RVA: 0x00128BF0 File Offset: 0x00126DF0
		// (set) Token: 0x0600CB92 RID: 52114 RVA: 0x00128C09 File Offset: 0x00126E09
		public unsafe bool bEnableScissorOffCenter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_bEnableScissorOffCenter) & FMinimalViewInfo.__PropertyMask_bEnableScissorOffCenter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_bEnableScissorOffCenter) = ((*(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_bEnableScissorOffCenter) & ~FMinimalViewInfo.__PropertyMask_bEnableScissorOffCenter) | (value ? FMinimalViewInfo.__PropertyMask_bEnableScissorOffCenter : 0));
			}
		}

		// Token: 0x17002FE9 RID: 12265
		// (get) Token: 0x0600CB93 RID: 52115 RVA: 0x00128C39 File Offset: 0x00126E39
		// (set) Token: 0x0600CB94 RID: 52116 RVA: 0x00128C4D File Offset: 0x00126E4D
		public unsafe FVector2D OffCenterProjectionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_OffCenterProjectionOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMinimalViewInfo.__PropertyOffset_OffCenterProjectionOffset) = value;
			}
		}

		// Token: 0x0600CB95 RID: 52117 RVA: 0x00128C62 File Offset: 0x00126E62
		public FMinimalViewInfo()
		{
		}

		// Token: 0x0600CB96 RID: 52118 RVA: 0x00128C6C File Offset: 0x00126E6C
		public FMinimalViewInfo(FVector Location, FRotator Rotation, float FOV, float DesiredFOV, float OrthoWidth, float OrthoNearClipPlane, float OrthoFarClipPlane, float AspectRatio, bool bConstrainAspectRatio, bool bUseFieldOfViewForLOD, TEnumAsByte<ECameraProjectionMode> ProjectionMode, float PostProcessBlendWeight, [Nullable(1)] FPostProcessSettings PostProcessSettings, bool bEnableScissorOffCenter, FVector2D OffCenterProjectionOffset)
		{
			this.Location = Location;
			this.Rotation = Rotation;
			this.FOV = FOV;
			this.DesiredFOV = DesiredFOV;
			this.OrthoWidth = OrthoWidth;
			this.OrthoNearClipPlane = OrthoNearClipPlane;
			this.OrthoFarClipPlane = OrthoFarClipPlane;
			this.AspectRatio = AspectRatio;
			this.bConstrainAspectRatio = bConstrainAspectRatio;
			this.bUseFieldOfViewForLOD = bUseFieldOfViewForLOD;
			this.ProjectionMode = ProjectionMode;
			this.PostProcessBlendWeight = PostProcessBlendWeight;
			this.PostProcessSettings = PostProcessSettings;
			this.bEnableScissorOffCenter = bEnableScissorOffCenter;
			this.OffCenterProjectionOffset = OffCenterProjectionOffset;
		}

		// Token: 0x0600CB97 RID: 52119 RVA: 0x00128CF4 File Offset: 0x00126EF4
		protected override IntPtr GetUStructPtr()
		{
			return FMinimalViewInfo.StaticStruct();
		}

		// Token: 0x0600CB98 RID: 52120 RVA: 0x00128D00 File Offset: 0x00126F00
		[NullableContext(2)]
		public FMinimalViewInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CB99 RID: 52121 RVA: 0x00128D0A File Offset: 0x00126F0A
		public FMinimalViewInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CB9A RID: 52122 RVA: 0x00128D15 File Offset: 0x00126F15
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMinimalViewInfo(Pointer, false, true);
		}

		// Token: 0x0600CB9B RID: 52123 RVA: 0x00128D1F File Offset: 0x00126F1F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMinimalViewInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04006DA1 RID: 28065
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MinimalViewInfo";

		// Token: 0x04006DA2 RID: 28066
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006DA3 RID: 28067
		internal static int __PropertyOffset_Location;

		// Token: 0x04006DA4 RID: 28068
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04006DA5 RID: 28069
		internal static int __PropertyOffset_FOV;

		// Token: 0x04006DA6 RID: 28070
		internal static int __PropertyOffset_DesiredFOV;

		// Token: 0x04006DA7 RID: 28071
		internal static int __PropertyOffset_OrthoWidth;

		// Token: 0x04006DA8 RID: 28072
		internal static int __PropertyOffset_OrthoNearClipPlane;

		// Token: 0x04006DA9 RID: 28073
		internal static int __PropertyOffset_OrthoFarClipPlane;

		// Token: 0x04006DAA RID: 28074
		internal static int __PropertyOffset_AspectRatio;

		// Token: 0x04006DAB RID: 28075
		internal static int __PropertyOffset_bConstrainAspectRatio;

		// Token: 0x04006DAC RID: 28076
		internal static byte __PropertyMask_bConstrainAspectRatio;

		// Token: 0x04006DAD RID: 28077
		internal static int __PropertyOffset_bUseFieldOfViewForLOD;

		// Token: 0x04006DAE RID: 28078
		internal static byte __PropertyMask_bUseFieldOfViewForLOD;

		// Token: 0x04006DAF RID: 28079
		internal static int __PropertyOffset_ProjectionMode;

		// Token: 0x04006DB0 RID: 28080
		internal static int __PropertyOffset_PostProcessBlendWeight;

		// Token: 0x04006DB1 RID: 28081
		internal static int __PropertyOffset_PostProcessSettings;

		// Token: 0x04006DB2 RID: 28082
		[Nullable(2)]
		private FPostProcessSettings _PostProcessSettings;

		// Token: 0x04006DB3 RID: 28083
		internal static int __PropertyOffset_bEnableScissorOffCenter;

		// Token: 0x04006DB4 RID: 28084
		internal static byte __PropertyMask_bEnableScissorOffCenter;

		// Token: 0x04006DB5 RID: 28085
		internal static int __PropertyOffset_OffCenterProjectionOffset;
	}
}
