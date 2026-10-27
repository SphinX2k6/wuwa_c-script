using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001534 RID: 5428
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.AxisAngleGizmo")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UAxisAngleGizmo : UInteractiveGizmo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013B4B RID: 80715 RVA: 0x001CF0CA File Offset: 0x001CD2CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAxisAngleGizmo._ClassPtr;
		}

		// Token: 0x06013B4C RID: 80716 RVA: 0x001CF0D8 File Offset: 0x001CD2D8
		public UAxisAngleGizmo() : this(BuiltinUtils.AllocNativeUObject(UAxisAngleGizmo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013B4D RID: 80717 RVA: 0x001CF100 File Offset: 0x001CD300
		[NullableContext(1)]
		public UAxisAngleGizmo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAxisAngleGizmo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D24 RID: 19748
		// (get) Token: 0x06013B4E RID: 80718 RVA: 0x001CF133 File Offset: 0x001CD333
		// (set) Token: 0x06013B4F RID: 80719 RVA: 0x001CF14D File Offset: 0x001CD34D
		public unsafe IGizmoAxisSource AxisSource
		{
			get
			{
				return (IGizmoAxisSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_AxisSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_AxisSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004D25 RID: 19749
		// (get) Token: 0x06013B50 RID: 80720 RVA: 0x001CF173 File Offset: 0x001CD373
		// (set) Token: 0x06013B51 RID: 80721 RVA: 0x001CF18D File Offset: 0x001CD38D
		public unsafe IGizmoFloatParameterSource AngleSource
		{
			get
			{
				return (IGizmoFloatParameterSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_AngleSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_AngleSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004D26 RID: 19750
		// (get) Token: 0x06013B52 RID: 80722 RVA: 0x001CF1B3 File Offset: 0x001CD3B3
		// (set) Token: 0x06013B53 RID: 80723 RVA: 0x001CF1CD File Offset: 0x001CD3CD
		public unsafe IGizmoClickTarget HitTarget
		{
			get
			{
				return (IGizmoClickTarget)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_HitTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_HitTarget) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004D27 RID: 19751
		// (get) Token: 0x06013B54 RID: 80724 RVA: 0x001CF1F3 File Offset: 0x001CD3F3
		// (set) Token: 0x06013B55 RID: 80725 RVA: 0x001CF20D File Offset: 0x001CD40D
		public unsafe IGizmoStateTarget StateTarget
		{
			get
			{
				return (IGizmoStateTarget)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_StateTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_StateTarget) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004D28 RID: 19752
		// (get) Token: 0x06013B56 RID: 80726 RVA: 0x001CF233 File Offset: 0x001CD433
		// (set) Token: 0x06013B57 RID: 80727 RVA: 0x001CF243 File Offset: 0x001CD443
		public unsafe bool bInInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_bInInteraction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_bInInteraction) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D29 RID: 19753
		// (get) Token: 0x06013B58 RID: 80728 RVA: 0x001CF254 File Offset: 0x001CD454
		// (set) Token: 0x06013B59 RID: 80729 RVA: 0x001CF268 File Offset: 0x001CD468
		public unsafe FVector RotationOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_RotationOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_RotationOrigin) = value;
			}
		}

		// Token: 0x17004D2A RID: 19754
		// (get) Token: 0x06013B5A RID: 80730 RVA: 0x001CF27D File Offset: 0x001CD47D
		// (set) Token: 0x06013B5B RID: 80731 RVA: 0x001CF291 File Offset: 0x001CD491
		public unsafe FVector RotationAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_RotationAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_RotationAxis) = value;
			}
		}

		// Token: 0x17004D2B RID: 19755
		// (get) Token: 0x06013B5C RID: 80732 RVA: 0x001CF2A6 File Offset: 0x001CD4A6
		// (set) Token: 0x06013B5D RID: 80733 RVA: 0x001CF2BA File Offset: 0x001CD4BA
		public unsafe FVector RotationPlaneX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_RotationPlaneX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_RotationPlaneX) = value;
			}
		}

		// Token: 0x17004D2C RID: 19756
		// (get) Token: 0x06013B5E RID: 80734 RVA: 0x001CF2CF File Offset: 0x001CD4CF
		// (set) Token: 0x06013B5F RID: 80735 RVA: 0x001CF2E3 File Offset: 0x001CD4E3
		public unsafe FVector RotationPlaneY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_RotationPlaneY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_RotationPlaneY) = value;
			}
		}

		// Token: 0x17004D2D RID: 19757
		// (get) Token: 0x06013B60 RID: 80736 RVA: 0x001CF2F8 File Offset: 0x001CD4F8
		// (set) Token: 0x06013B61 RID: 80737 RVA: 0x001CF30C File Offset: 0x001CD50C
		public unsafe FVector InteractionStartPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_InteractionStartPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_InteractionStartPoint) = value;
			}
		}

		// Token: 0x17004D2E RID: 19758
		// (get) Token: 0x06013B62 RID: 80738 RVA: 0x001CF321 File Offset: 0x001CD521
		// (set) Token: 0x06013B63 RID: 80739 RVA: 0x001CF335 File Offset: 0x001CD535
		public unsafe FVector InteractionCurPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_InteractionCurPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_InteractionCurPoint) = value;
			}
		}

		// Token: 0x17004D2F RID: 19759
		// (get) Token: 0x06013B64 RID: 80740 RVA: 0x001CF34A File Offset: 0x001CD54A
		// (set) Token: 0x06013B65 RID: 80741 RVA: 0x001CF35A File Offset: 0x001CD55A
		public unsafe float InteractionStartAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_InteractionStartAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_InteractionStartAngle) = value;
			}
		}

		// Token: 0x17004D30 RID: 19760
		// (get) Token: 0x06013B66 RID: 80742 RVA: 0x001CF36B File Offset: 0x001CD56B
		// (set) Token: 0x06013B67 RID: 80743 RVA: 0x001CF37B File Offset: 0x001CD57B
		public unsafe float InteractionCurAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_InteractionCurAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAxisAngleGizmo.__PropertyOffset_InteractionCurAngle) = value;
			}
		}

		// Token: 0x06013B68 RID: 80744 RVA: 0x001CF38C File Offset: 0x001CD58C
		static UAxisAngleGizmo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.AxisAngleGizmo");
		}

		// Token: 0x06013B69 RID: 80745 RVA: 0x001CF39A File Offset: 0x001CD59A
		protected UAxisAngleGizmo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AA8F RID: 43663
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.AxisAngleGizmo";

		// Token: 0x0400AA90 RID: 43664
		private static IntPtr _ClassPtr;

		// Token: 0x0400AA91 RID: 43665
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AA92 RID: 43666
		internal static int __PropertyOffset_AxisSource;

		// Token: 0x0400AA93 RID: 43667
		internal static int __PropertyOffset_AngleSource;

		// Token: 0x0400AA94 RID: 43668
		internal static int __PropertyOffset_HitTarget;

		// Token: 0x0400AA95 RID: 43669
		internal static int __PropertyOffset_StateTarget;

		// Token: 0x0400AA96 RID: 43670
		internal static int __PropertyOffset_bInInteraction;

		// Token: 0x0400AA97 RID: 43671
		internal static int __PropertyOffset_RotationOrigin;

		// Token: 0x0400AA98 RID: 43672
		internal static int __PropertyOffset_RotationAxis;

		// Token: 0x0400AA99 RID: 43673
		internal static int __PropertyOffset_RotationPlaneX;

		// Token: 0x0400AA9A RID: 43674
		internal static int __PropertyOffset_RotationPlaneY;

		// Token: 0x0400AA9B RID: 43675
		internal static int __PropertyOffset_InteractionStartPoint;

		// Token: 0x0400AA9C RID: 43676
		internal static int __PropertyOffset_InteractionCurPoint;

		// Token: 0x0400AA9D RID: 43677
		internal static int __PropertyOffset_InteractionStartAngle;

		// Token: 0x0400AA9E RID: 43678
		internal static int __PropertyOffset_InteractionCurAngle;
	}
}
