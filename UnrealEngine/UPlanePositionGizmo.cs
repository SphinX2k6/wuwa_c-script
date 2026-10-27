using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200158F RID: 5519
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.PlanePositionGizmo")]
	[UnrealStructLayout(448, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UPlanePositionGizmo : UInteractiveGizmo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013E99 RID: 81561 RVA: 0x001D3DAA File Offset: 0x001D1FAA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlanePositionGizmo._ClassPtr;
		}

		// Token: 0x06013E9A RID: 81562 RVA: 0x001D3DB8 File Offset: 0x001D1FB8
		public UPlanePositionGizmo() : this(BuiltinUtils.AllocNativeUObject(UPlanePositionGizmo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E9B RID: 81563 RVA: 0x001D3DE0 File Offset: 0x001D1FE0
		[NullableContext(1)]
		public UPlanePositionGizmo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPlanePositionGizmo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DEE RID: 19950
		// (get) Token: 0x06013E9C RID: 81564 RVA: 0x001D3E13 File Offset: 0x001D2013
		// (set) Token: 0x06013E9D RID: 81565 RVA: 0x001D3E2D File Offset: 0x001D202D
		public unsafe IGizmoAxisSource AxisSource
		{
			get
			{
				return (IGizmoAxisSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_AxisSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_AxisSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004DEF RID: 19951
		// (get) Token: 0x06013E9E RID: 81566 RVA: 0x001D3E53 File Offset: 0x001D2053
		// (set) Token: 0x06013E9F RID: 81567 RVA: 0x001D3E6D File Offset: 0x001D206D
		public unsafe IGizmoVec2ParameterSource ParameterSource
		{
			get
			{
				return (IGizmoVec2ParameterSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_ParameterSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_ParameterSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004DF0 RID: 19952
		// (get) Token: 0x06013EA0 RID: 81568 RVA: 0x001D3E93 File Offset: 0x001D2093
		// (set) Token: 0x06013EA1 RID: 81569 RVA: 0x001D3EAD File Offset: 0x001D20AD
		public unsafe IGizmoClickTarget HitTarget
		{
			get
			{
				return (IGizmoClickTarget)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_HitTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_HitTarget) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004DF1 RID: 19953
		// (get) Token: 0x06013EA2 RID: 81570 RVA: 0x001D3ED3 File Offset: 0x001D20D3
		// (set) Token: 0x06013EA3 RID: 81571 RVA: 0x001D3EED File Offset: 0x001D20ED
		public unsafe IGizmoStateTarget StateTarget
		{
			get
			{
				return (IGizmoStateTarget)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_StateTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_StateTarget) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004DF2 RID: 19954
		// (get) Token: 0x06013EA4 RID: 81572 RVA: 0x001D3F13 File Offset: 0x001D2113
		// (set) Token: 0x06013EA5 RID: 81573 RVA: 0x001D3F23 File Offset: 0x001D2123
		public unsafe bool bEnableSignedAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_bEnableSignedAxis) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_bEnableSignedAxis) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004DF3 RID: 19955
		// (get) Token: 0x06013EA6 RID: 81574 RVA: 0x001D3F34 File Offset: 0x001D2134
		// (set) Token: 0x06013EA7 RID: 81575 RVA: 0x001D3F44 File Offset: 0x001D2144
		public unsafe bool bFlipX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_bFlipX) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_bFlipX) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004DF4 RID: 19956
		// (get) Token: 0x06013EA8 RID: 81576 RVA: 0x001D3F55 File Offset: 0x001D2155
		// (set) Token: 0x06013EA9 RID: 81577 RVA: 0x001D3F65 File Offset: 0x001D2165
		public unsafe bool bFlipY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_bFlipY) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_bFlipY) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004DF5 RID: 19957
		// (get) Token: 0x06013EAA RID: 81578 RVA: 0x001D3F76 File Offset: 0x001D2176
		// (set) Token: 0x06013EAB RID: 81579 RVA: 0x001D3F86 File Offset: 0x001D2186
		public unsafe bool bInInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_bInInteraction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_bInInteraction) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004DF6 RID: 19958
		// (get) Token: 0x06013EAC RID: 81580 RVA: 0x001D3F97 File Offset: 0x001D2197
		// (set) Token: 0x06013EAD RID: 81581 RVA: 0x001D3FAB File Offset: 0x001D21AB
		public unsafe FVector InteractionOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_InteractionOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_InteractionOrigin) = value;
			}
		}

		// Token: 0x17004DF7 RID: 19959
		// (get) Token: 0x06013EAE RID: 81582 RVA: 0x001D3FC0 File Offset: 0x001D21C0
		// (set) Token: 0x06013EAF RID: 81583 RVA: 0x001D3FD4 File Offset: 0x001D21D4
		public unsafe FVector InteractionNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_InteractionNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_InteractionNormal) = value;
			}
		}

		// Token: 0x17004DF8 RID: 19960
		// (get) Token: 0x06013EB0 RID: 81584 RVA: 0x001D3FE9 File Offset: 0x001D21E9
		// (set) Token: 0x06013EB1 RID: 81585 RVA: 0x001D3FFD File Offset: 0x001D21FD
		public unsafe FVector InteractionAxisX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_InteractionAxisX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_InteractionAxisX) = value;
			}
		}

		// Token: 0x17004DF9 RID: 19961
		// (get) Token: 0x06013EB2 RID: 81586 RVA: 0x001D4012 File Offset: 0x001D2212
		// (set) Token: 0x06013EB3 RID: 81587 RVA: 0x001D4026 File Offset: 0x001D2226
		public unsafe FVector InteractionAxisY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_InteractionAxisY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_InteractionAxisY) = value;
			}
		}

		// Token: 0x17004DFA RID: 19962
		// (get) Token: 0x06013EB4 RID: 81588 RVA: 0x001D403B File Offset: 0x001D223B
		// (set) Token: 0x06013EB5 RID: 81589 RVA: 0x001D404F File Offset: 0x001D224F
		public unsafe FVector InteractionStartPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_InteractionStartPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_InteractionStartPoint) = value;
			}
		}

		// Token: 0x17004DFB RID: 19963
		// (get) Token: 0x06013EB6 RID: 81590 RVA: 0x001D4064 File Offset: 0x001D2264
		// (set) Token: 0x06013EB7 RID: 81591 RVA: 0x001D4078 File Offset: 0x001D2278
		public unsafe FVector InteractionCurPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_InteractionCurPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_InteractionCurPoint) = value;
			}
		}

		// Token: 0x17004DFC RID: 19964
		// (get) Token: 0x06013EB8 RID: 81592 RVA: 0x001D408D File Offset: 0x001D228D
		// (set) Token: 0x06013EB9 RID: 81593 RVA: 0x001D40A1 File Offset: 0x001D22A1
		public unsafe FVector2D InteractionStartParameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_InteractionStartParameter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_InteractionStartParameter) = value;
			}
		}

		// Token: 0x17004DFD RID: 19965
		// (get) Token: 0x06013EBA RID: 81594 RVA: 0x001D40B6 File Offset: 0x001D22B6
		// (set) Token: 0x06013EBB RID: 81595 RVA: 0x001D40CA File Offset: 0x001D22CA
		public unsafe FVector2D InteractionCurParameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_InteractionCurParameter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_InteractionCurParameter) = value;
			}
		}

		// Token: 0x17004DFE RID: 19966
		// (get) Token: 0x06013EBC RID: 81596 RVA: 0x001D40DF File Offset: 0x001D22DF
		// (set) Token: 0x06013EBD RID: 81597 RVA: 0x001D40F3 File Offset: 0x001D22F3
		public unsafe FVector2D ParameterSigns
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_ParameterSigns);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanePositionGizmo.__PropertyOffset_ParameterSigns) = value;
			}
		}

		// Token: 0x06013EBE RID: 81598 RVA: 0x001D4108 File Offset: 0x001D2308
		static UPlanePositionGizmo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.PlanePositionGizmo");
		}

		// Token: 0x06013EBF RID: 81599 RVA: 0x001D4116 File Offset: 0x001D2316
		protected UPlanePositionGizmo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC70 RID: 44144
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.PlanePositionGizmo";

		// Token: 0x0400AC71 RID: 44145
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC72 RID: 44146
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AC73 RID: 44147
		internal static int __PropertyOffset_AxisSource;

		// Token: 0x0400AC74 RID: 44148
		internal static int __PropertyOffset_ParameterSource;

		// Token: 0x0400AC75 RID: 44149
		internal static int __PropertyOffset_HitTarget;

		// Token: 0x0400AC76 RID: 44150
		internal static int __PropertyOffset_StateTarget;

		// Token: 0x0400AC77 RID: 44151
		internal static int __PropertyOffset_bEnableSignedAxis;

		// Token: 0x0400AC78 RID: 44152
		internal static int __PropertyOffset_bFlipX;

		// Token: 0x0400AC79 RID: 44153
		internal static int __PropertyOffset_bFlipY;

		// Token: 0x0400AC7A RID: 44154
		internal static int __PropertyOffset_bInInteraction;

		// Token: 0x0400AC7B RID: 44155
		internal static int __PropertyOffset_InteractionOrigin;

		// Token: 0x0400AC7C RID: 44156
		internal static int __PropertyOffset_InteractionNormal;

		// Token: 0x0400AC7D RID: 44157
		internal static int __PropertyOffset_InteractionAxisX;

		// Token: 0x0400AC7E RID: 44158
		internal static int __PropertyOffset_InteractionAxisY;

		// Token: 0x0400AC7F RID: 44159
		internal static int __PropertyOffset_InteractionStartPoint;

		// Token: 0x0400AC80 RID: 44160
		internal static int __PropertyOffset_InteractionCurPoint;

		// Token: 0x0400AC81 RID: 44161
		internal static int __PropertyOffset_InteractionStartParameter;

		// Token: 0x0400AC82 RID: 44162
		internal static int __PropertyOffset_InteractionCurParameter;

		// Token: 0x0400AC83 RID: 44163
		internal static int __PropertyOffset_ParameterSigns;
	}
}
