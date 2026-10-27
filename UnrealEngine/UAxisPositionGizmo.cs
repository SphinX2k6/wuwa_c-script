using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001536 RID: 5430
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.AxisPositionGizmo")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UAxisPositionGizmo : UInteractiveGizmo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013B6F RID: 80751 RVA: 0x001CF422 File Offset: 0x001CD622
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAxisPositionGizmo._ClassPtr;
		}

		// Token: 0x06013B70 RID: 80752 RVA: 0x001CF430 File Offset: 0x001CD630
		public UAxisPositionGizmo() : this(BuiltinUtils.AllocNativeUObject(UAxisPositionGizmo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013B71 RID: 80753 RVA: 0x001CF458 File Offset: 0x001CD658
		[NullableContext(1)]
		public UAxisPositionGizmo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAxisPositionGizmo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D31 RID: 19761
		// (get) Token: 0x06013B72 RID: 80754 RVA: 0x001CF48B File Offset: 0x001CD68B
		// (set) Token: 0x06013B73 RID: 80755 RVA: 0x001CF4A5 File Offset: 0x001CD6A5
		public unsafe IGizmoAxisSource AxisSource
		{
			get
			{
				return (IGizmoAxisSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_AxisSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_AxisSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004D32 RID: 19762
		// (get) Token: 0x06013B74 RID: 80756 RVA: 0x001CF4CB File Offset: 0x001CD6CB
		// (set) Token: 0x06013B75 RID: 80757 RVA: 0x001CF4E5 File Offset: 0x001CD6E5
		public unsafe IGizmoFloatParameterSource ParameterSource
		{
			get
			{
				return (IGizmoFloatParameterSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_ParameterSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_ParameterSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004D33 RID: 19763
		// (get) Token: 0x06013B76 RID: 80758 RVA: 0x001CF50B File Offset: 0x001CD70B
		// (set) Token: 0x06013B77 RID: 80759 RVA: 0x001CF525 File Offset: 0x001CD725
		public unsafe IGizmoClickTarget HitTarget
		{
			get
			{
				return (IGizmoClickTarget)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_HitTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_HitTarget) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004D34 RID: 19764
		// (get) Token: 0x06013B78 RID: 80760 RVA: 0x001CF54B File Offset: 0x001CD74B
		// (set) Token: 0x06013B79 RID: 80761 RVA: 0x001CF565 File Offset: 0x001CD765
		public unsafe IGizmoStateTarget StateTarget
		{
			get
			{
				return (IGizmoStateTarget)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_StateTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_StateTarget) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004D35 RID: 19765
		// (get) Token: 0x06013B7A RID: 80762 RVA: 0x001CF58B File Offset: 0x001CD78B
		// (set) Token: 0x06013B7B RID: 80763 RVA: 0x001CF59B File Offset: 0x001CD79B
		public unsafe bool bEnableSignedAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_bEnableSignedAxis) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_bEnableSignedAxis) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D36 RID: 19766
		// (get) Token: 0x06013B7C RID: 80764 RVA: 0x001CF5AC File Offset: 0x001CD7AC
		// (set) Token: 0x06013B7D RID: 80765 RVA: 0x001CF5BC File Offset: 0x001CD7BC
		public unsafe bool bInInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_bInInteraction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_bInInteraction) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D37 RID: 19767
		// (get) Token: 0x06013B7E RID: 80766 RVA: 0x001CF5CD File Offset: 0x001CD7CD
		// (set) Token: 0x06013B7F RID: 80767 RVA: 0x001CF5E1 File Offset: 0x001CD7E1
		public unsafe FVector InteractionOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_InteractionOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_InteractionOrigin) = value;
			}
		}

		// Token: 0x17004D38 RID: 19768
		// (get) Token: 0x06013B80 RID: 80768 RVA: 0x001CF5F6 File Offset: 0x001CD7F6
		// (set) Token: 0x06013B81 RID: 80769 RVA: 0x001CF60A File Offset: 0x001CD80A
		public unsafe FVector InteractionAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_InteractionAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_InteractionAxis) = value;
			}
		}

		// Token: 0x17004D39 RID: 19769
		// (get) Token: 0x06013B82 RID: 80770 RVA: 0x001CF61F File Offset: 0x001CD81F
		// (set) Token: 0x06013B83 RID: 80771 RVA: 0x001CF633 File Offset: 0x001CD833
		public unsafe FVector InteractionStartPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_InteractionStartPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_InteractionStartPoint) = value;
			}
		}

		// Token: 0x17004D3A RID: 19770
		// (get) Token: 0x06013B84 RID: 80772 RVA: 0x001CF648 File Offset: 0x001CD848
		// (set) Token: 0x06013B85 RID: 80773 RVA: 0x001CF65C File Offset: 0x001CD85C
		public unsafe FVector InteractionCurPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_InteractionCurPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_InteractionCurPoint) = value;
			}
		}

		// Token: 0x17004D3B RID: 19771
		// (get) Token: 0x06013B86 RID: 80774 RVA: 0x001CF671 File Offset: 0x001CD871
		// (set) Token: 0x06013B87 RID: 80775 RVA: 0x001CF681 File Offset: 0x001CD881
		public unsafe float InteractionStartParameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_InteractionStartParameter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_InteractionStartParameter) = value;
			}
		}

		// Token: 0x17004D3C RID: 19772
		// (get) Token: 0x06013B88 RID: 80776 RVA: 0x001CF692 File Offset: 0x001CD892
		// (set) Token: 0x06013B89 RID: 80777 RVA: 0x001CF6A2 File Offset: 0x001CD8A2
		public unsafe float InteractionCurParameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_InteractionCurParameter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_InteractionCurParameter) = value;
			}
		}

		// Token: 0x17004D3D RID: 19773
		// (get) Token: 0x06013B8A RID: 80778 RVA: 0x001CF6B3 File Offset: 0x001CD8B3
		// (set) Token: 0x06013B8B RID: 80779 RVA: 0x001CF6C3 File Offset: 0x001CD8C3
		public unsafe float ParameterSign
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_ParameterSign);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisPositionGizmo.__PropertyOffset_ParameterSign) = value;
			}
		}

		// Token: 0x06013B8C RID: 80780 RVA: 0x001CF6D4 File Offset: 0x001CD8D4
		static UAxisPositionGizmo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.AxisPositionGizmo");
		}

		// Token: 0x06013B8D RID: 80781 RVA: 0x001CF6E2 File Offset: 0x001CD8E2
		protected UAxisPositionGizmo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AAA2 RID: 43682
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.AxisPositionGizmo";

		// Token: 0x0400AAA3 RID: 43683
		private static IntPtr _ClassPtr;

		// Token: 0x0400AAA4 RID: 43684
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AAA5 RID: 43685
		internal static int __PropertyOffset_AxisSource;

		// Token: 0x0400AAA6 RID: 43686
		internal static int __PropertyOffset_ParameterSource;

		// Token: 0x0400AAA7 RID: 43687
		internal static int __PropertyOffset_HitTarget;

		// Token: 0x0400AAA8 RID: 43688
		internal static int __PropertyOffset_StateTarget;

		// Token: 0x0400AAA9 RID: 43689
		internal static int __PropertyOffset_bEnableSignedAxis;

		// Token: 0x0400AAAA RID: 43690
		internal static int __PropertyOffset_bInInteraction;

		// Token: 0x0400AAAB RID: 43691
		internal static int __PropertyOffset_InteractionOrigin;

		// Token: 0x0400AAAC RID: 43692
		internal static int __PropertyOffset_InteractionAxis;

		// Token: 0x0400AAAD RID: 43693
		internal static int __PropertyOffset_InteractionStartPoint;

		// Token: 0x0400AAAE RID: 43694
		internal static int __PropertyOffset_InteractionCurPoint;

		// Token: 0x0400AAAF RID: 43695
		internal static int __PropertyOffset_InteractionStartParameter;

		// Token: 0x0400AAB0 RID: 43696
		internal static int __PropertyOffset_InteractionCurParameter;

		// Token: 0x0400AAB1 RID: 43697
		internal static int __PropertyOffset_ParameterSign;
	}
}
