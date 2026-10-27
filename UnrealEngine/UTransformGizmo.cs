using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200159E RID: 5534
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.TransformGizmo")]
	[UnrealStructLayout(704, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 704)]
	public class UTransformGizmo : UInteractiveGizmo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013EFC RID: 81660 RVA: 0x001D465E File Offset: 0x001D285E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTransformGizmo._ClassPtr;
		}

		// Token: 0x06013EFD RID: 81661 RVA: 0x001D466C File Offset: 0x001D286C
		public UTransformGizmo() : this(BuiltinUtils.AllocNativeUObject(UTransformGizmo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013EFE RID: 81662 RVA: 0x001D4694 File Offset: 0x001D2894
		[NullableContext(1)]
		public UTransformGizmo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTransformGizmo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004E03 RID: 19971
		// (get) Token: 0x06013EFF RID: 81663 RVA: 0x001D46C7 File Offset: 0x001D28C7
		// (set) Token: 0x06013F00 RID: 81664 RVA: 0x001D46DB File Offset: 0x001D28DB
		public unsafe UTransformProxy ActiveTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTransformProxy>(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_ActiveTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_ActiveTarget, value);
			}
		}

		// Token: 0x17004E04 RID: 19972
		// (get) Token: 0x06013F01 RID: 81665 RVA: 0x001D46F0 File Offset: 0x001D28F0
		// (set) Token: 0x06013F02 RID: 81666 RVA: 0x001D4700 File Offset: 0x001D2900
		public unsafe bool bSnapToWorldGrid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransformGizmo.__PropertyOffset_bSnapToWorldGrid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransformGizmo.__PropertyOffset_bSnapToWorldGrid) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E05 RID: 19973
		// (get) Token: 0x06013F03 RID: 81667 RVA: 0x001D4711 File Offset: 0x001D2911
		// (set) Token: 0x06013F04 RID: 81668 RVA: 0x001D4721 File Offset: 0x001D2921
		public unsafe bool bGridSizeIsExplicit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransformGizmo.__PropertyOffset_bGridSizeIsExplicit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransformGizmo.__PropertyOffset_bGridSizeIsExplicit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E06 RID: 19974
		// (get) Token: 0x06013F05 RID: 81669 RVA: 0x001D4732 File Offset: 0x001D2932
		// (set) Token: 0x06013F06 RID: 81670 RVA: 0x001D4746 File Offset: 0x001D2946
		public unsafe FVector ExplicitGridSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransformGizmo.__PropertyOffset_ExplicitGridSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransformGizmo.__PropertyOffset_ExplicitGridSize) = value;
			}
		}

		// Token: 0x17004E07 RID: 19975
		// (get) Token: 0x06013F07 RID: 81671 RVA: 0x001D475B File Offset: 0x001D295B
		// (set) Token: 0x06013F08 RID: 81672 RVA: 0x001D476B File Offset: 0x001D296B
		public unsafe bool bRotationGridSizeIsExplicit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransformGizmo.__PropertyOffset_bRotationGridSizeIsExplicit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransformGizmo.__PropertyOffset_bRotationGridSizeIsExplicit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E08 RID: 19976
		// (get) Token: 0x06013F09 RID: 81673 RVA: 0x001D477C File Offset: 0x001D297C
		// (set) Token: 0x06013F0A RID: 81674 RVA: 0x001D4790 File Offset: 0x001D2990
		public unsafe FRotator ExplicitRotationGridSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransformGizmo.__PropertyOffset_ExplicitRotationGridSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransformGizmo.__PropertyOffset_ExplicitRotationGridSize) = value;
			}
		}

		// Token: 0x17004E09 RID: 19977
		// (get) Token: 0x06013F0B RID: 81675 RVA: 0x001D47A5 File Offset: 0x001D29A5
		// (set) Token: 0x06013F0C RID: 81676 RVA: 0x001D47B5 File Offset: 0x001D29B5
		public unsafe bool bSnapToWorldRotGrid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransformGizmo.__PropertyOffset_bSnapToWorldRotGrid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransformGizmo.__PropertyOffset_bSnapToWorldRotGrid) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E0A RID: 19978
		// (get) Token: 0x06013F0D RID: 81677 RVA: 0x001D47C6 File Offset: 0x001D29C6
		// (set) Token: 0x06013F0E RID: 81678 RVA: 0x001D47D6 File Offset: 0x001D29D6
		public unsafe bool bUseContextCoordinateSystem
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransformGizmo.__PropertyOffset_bUseContextCoordinateSystem) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransformGizmo.__PropertyOffset_bUseContextCoordinateSystem) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E0B RID: 19979
		// (get) Token: 0x06013F0F RID: 81679 RVA: 0x001D47E7 File Offset: 0x001D29E7
		// (set) Token: 0x06013F10 RID: 81680 RVA: 0x001D47F7 File Offset: 0x001D29F7
		public unsafe EToolContextCoordinateSystem CurrentCoordinateSystem
		{
			get
			{
				return (EToolContextCoordinateSystem)(*(base.NativePtr + (IntPtr)UTransformGizmo.__PropertyOffset_CurrentCoordinateSystem));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransformGizmo.__PropertyOffset_CurrentCoordinateSystem) = (int)value;
			}
		}

		// Token: 0x17004E0C RID: 19980
		// (get) Token: 0x06013F11 RID: 81681 RVA: 0x001D4808 File Offset: 0x001D2A08
		// (set) Token: 0x06013F12 RID: 81682 RVA: 0x001D4841 File Offset: 0x001D2A41
		[Nullable(1)]
		public TArray<UPrimitiveComponent> ActiveComponents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UPrimitiveComponent> result;
				if ((result = this._ActiveComponents) == null)
				{
					result = (this._ActiveComponents = new TArray<UPrimitiveComponent>(base.NativePtr + (IntPtr)UTransformGizmo.__PropertyOffset_ActiveComponents, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ActiveComponents.CopyAssign(value);
			}
		}

		// Token: 0x17004E0D RID: 19981
		// (get) Token: 0x06013F13 RID: 81683 RVA: 0x001D4850 File Offset: 0x001D2A50
		// (set) Token: 0x06013F14 RID: 81684 RVA: 0x001D4889 File Offset: 0x001D2A89
		[Nullable(1)]
		public TArray<UPrimitiveComponent> NonuniformScaleComponents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UPrimitiveComponent> result;
				if ((result = this._NonuniformScaleComponents) == null)
				{
					result = (this._NonuniformScaleComponents = new TArray<UPrimitiveComponent>(base.NativePtr + (IntPtr)UTransformGizmo.__PropertyOffset_NonuniformScaleComponents, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NonuniformScaleComponents.CopyAssign(value);
			}
		}

		// Token: 0x17004E0E RID: 19982
		// (get) Token: 0x06013F15 RID: 81685 RVA: 0x001D4898 File Offset: 0x001D2A98
		// (set) Token: 0x06013F16 RID: 81686 RVA: 0x001D48D1 File Offset: 0x001D2AD1
		[Nullable(1)]
		public TArray<UInteractiveGizmo> ActiveGizmos
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UInteractiveGizmo> result;
				if ((result = this._ActiveGizmos) == null)
				{
					result = (this._ActiveGizmos = new TArray<UInteractiveGizmo>(base.NativePtr + (IntPtr)UTransformGizmo.__PropertyOffset_ActiveGizmos, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ActiveGizmos.CopyAssign(value);
			}
		}

		// Token: 0x17004E0F RID: 19983
		// (get) Token: 0x06013F17 RID: 81687 RVA: 0x001D48DF File Offset: 0x001D2ADF
		// (set) Token: 0x06013F18 RID: 81688 RVA: 0x001D48F3 File Offset: 0x001D2AF3
		public unsafe UGizmoConstantFrameAxisSource CameraAxisSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGizmoConstantFrameAxisSource>(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_CameraAxisSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_CameraAxisSource, value);
			}
		}

		// Token: 0x17004E10 RID: 19984
		// (get) Token: 0x06013F19 RID: 81689 RVA: 0x001D4908 File Offset: 0x001D2B08
		// (set) Token: 0x06013F1A RID: 81690 RVA: 0x001D491C File Offset: 0x001D2B1C
		public unsafe UGizmoComponentAxisSource AxisXSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGizmoComponentAxisSource>(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_AxisXSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_AxisXSource, value);
			}
		}

		// Token: 0x17004E11 RID: 19985
		// (get) Token: 0x06013F1B RID: 81691 RVA: 0x001D4931 File Offset: 0x001D2B31
		// (set) Token: 0x06013F1C RID: 81692 RVA: 0x001D4945 File Offset: 0x001D2B45
		public unsafe UGizmoComponentAxisSource AxisYSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGizmoComponentAxisSource>(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_AxisYSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_AxisYSource, value);
			}
		}

		// Token: 0x17004E12 RID: 19986
		// (get) Token: 0x06013F1D RID: 81693 RVA: 0x001D495A File Offset: 0x001D2B5A
		// (set) Token: 0x06013F1E RID: 81694 RVA: 0x001D496E File Offset: 0x001D2B6E
		public unsafe UGizmoComponentAxisSource AxisZSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGizmoComponentAxisSource>(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_AxisZSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_AxisZSource, value);
			}
		}

		// Token: 0x17004E13 RID: 19987
		// (get) Token: 0x06013F1F RID: 81695 RVA: 0x001D4983 File Offset: 0x001D2B83
		// (set) Token: 0x06013F20 RID: 81696 RVA: 0x001D4997 File Offset: 0x001D2B97
		public unsafe UGizmoComponentAxisSource UnitAxisXSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGizmoComponentAxisSource>(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_UnitAxisXSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_UnitAxisXSource, value);
			}
		}

		// Token: 0x17004E14 RID: 19988
		// (get) Token: 0x06013F21 RID: 81697 RVA: 0x001D49AC File Offset: 0x001D2BAC
		// (set) Token: 0x06013F22 RID: 81698 RVA: 0x001D49C0 File Offset: 0x001D2BC0
		public unsafe UGizmoComponentAxisSource UnitAxisYSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGizmoComponentAxisSource>(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_UnitAxisYSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_UnitAxisYSource, value);
			}
		}

		// Token: 0x17004E15 RID: 19989
		// (get) Token: 0x06013F23 RID: 81699 RVA: 0x001D49D5 File Offset: 0x001D2BD5
		// (set) Token: 0x06013F24 RID: 81700 RVA: 0x001D49E9 File Offset: 0x001D2BE9
		public unsafe UGizmoComponentAxisSource UnitAxisZSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGizmoComponentAxisSource>(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_UnitAxisZSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_UnitAxisZSource, value);
			}
		}

		// Token: 0x17004E16 RID: 19990
		// (get) Token: 0x06013F25 RID: 81701 RVA: 0x001D49FE File Offset: 0x001D2BFE
		// (set) Token: 0x06013F26 RID: 81702 RVA: 0x001D4A12 File Offset: 0x001D2C12
		public unsafe UGizmoTransformChangeStateTarget StateTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGizmoTransformChangeStateTarget>(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_StateTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_StateTarget, value);
			}
		}

		// Token: 0x17004E17 RID: 19991
		// (get) Token: 0x06013F27 RID: 81703 RVA: 0x001D4A27 File Offset: 0x001D2C27
		// (set) Token: 0x06013F28 RID: 81704 RVA: 0x001D4A3B File Offset: 0x001D2C3B
		public unsafe UGizmoScaledTransformSource ScaledTransformSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGizmoScaledTransformSource>(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_ScaledTransformSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTransformGizmo.__PropertyOffset_ScaledTransformSource, value);
			}
		}

		// Token: 0x06013F29 RID: 81705 RVA: 0x001D4A50 File Offset: 0x001D2C50
		static UTransformGizmo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.TransformGizmo");
		}

		// Token: 0x06013F2A RID: 81706 RVA: 0x001D4A5E File Offset: 0x001D2C5E
		protected UTransformGizmo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ACAB RID: 44203
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.TransformGizmo";

		// Token: 0x0400ACAC RID: 44204
		private static IntPtr _ClassPtr;

		// Token: 0x0400ACAD RID: 44205
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ACAE RID: 44206
		internal static int __PropertyOffset_ActiveTarget;

		// Token: 0x0400ACAF RID: 44207
		internal static int __PropertyOffset_bSnapToWorldGrid;

		// Token: 0x0400ACB0 RID: 44208
		internal static int __PropertyOffset_bGridSizeIsExplicit;

		// Token: 0x0400ACB1 RID: 44209
		internal static int __PropertyOffset_ExplicitGridSize;

		// Token: 0x0400ACB2 RID: 44210
		internal static int __PropertyOffset_bRotationGridSizeIsExplicit;

		// Token: 0x0400ACB3 RID: 44211
		internal static int __PropertyOffset_ExplicitRotationGridSize;

		// Token: 0x0400ACB4 RID: 44212
		internal static int __PropertyOffset_bSnapToWorldRotGrid;

		// Token: 0x0400ACB5 RID: 44213
		internal static int __PropertyOffset_bUseContextCoordinateSystem;

		// Token: 0x0400ACB6 RID: 44214
		internal static int __PropertyOffset_CurrentCoordinateSystem;

		// Token: 0x0400ACB7 RID: 44215
		internal static int __PropertyOffset_ActiveComponents;

		// Token: 0x0400ACB8 RID: 44216
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPrimitiveComponent> _ActiveComponents;

		// Token: 0x0400ACB9 RID: 44217
		internal static int __PropertyOffset_NonuniformScaleComponents;

		// Token: 0x0400ACBA RID: 44218
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPrimitiveComponent> _NonuniformScaleComponents;

		// Token: 0x0400ACBB RID: 44219
		internal static int __PropertyOffset_ActiveGizmos;

		// Token: 0x0400ACBC RID: 44220
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UInteractiveGizmo> _ActiveGizmos;

		// Token: 0x0400ACBD RID: 44221
		internal static int __PropertyOffset_CameraAxisSource;

		// Token: 0x0400ACBE RID: 44222
		internal static int __PropertyOffset_AxisXSource;

		// Token: 0x0400ACBF RID: 44223
		internal static int __PropertyOffset_AxisYSource;

		// Token: 0x0400ACC0 RID: 44224
		internal static int __PropertyOffset_AxisZSource;

		// Token: 0x0400ACC1 RID: 44225
		internal static int __PropertyOffset_UnitAxisXSource;

		// Token: 0x0400ACC2 RID: 44226
		internal static int __PropertyOffset_UnitAxisYSource;

		// Token: 0x0400ACC3 RID: 44227
		internal static int __PropertyOffset_UnitAxisZSource;

		// Token: 0x0400ACC4 RID: 44228
		internal static int __PropertyOffset_StateTarget;

		// Token: 0x0400ACC5 RID: 44229
		internal static int __PropertyOffset_ScaledTransformSource;
	}
}
