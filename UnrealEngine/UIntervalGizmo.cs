using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001583 RID: 5507
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.IntervalGizmo")]
	[UnrealStructLayout(576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class UIntervalGizmo : UInteractiveGizmo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013E41 RID: 81473 RVA: 0x001D34B2 File Offset: 0x001D16B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UIntervalGizmo._ClassPtr;
		}

		// Token: 0x06013E42 RID: 81474 RVA: 0x001D34C0 File Offset: 0x001D16C0
		public UIntervalGizmo() : this(BuiltinUtils.AllocNativeUObject(UIntervalGizmo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E43 RID: 81475 RVA: 0x001D34E8 File Offset: 0x001D16E8
		[NullableContext(1)]
		public UIntervalGizmo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UIntervalGizmo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DE0 RID: 19936
		// (get) Token: 0x06013E44 RID: 81476 RVA: 0x001D351B File Offset: 0x001D171B
		// (set) Token: 0x06013E45 RID: 81477 RVA: 0x001D352F File Offset: 0x001D172F
		public unsafe UGizmoTransformChangeStateTarget StateTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGizmoTransformChangeStateTarget>(base.NativePtr / (IntPtr)sizeof(void*) + UIntervalGizmo.__PropertyOffset_StateTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UIntervalGizmo.__PropertyOffset_StateTarget, value);
			}
		}

		// Token: 0x17004DE1 RID: 19937
		// (get) Token: 0x06013E46 RID: 81478 RVA: 0x001D3544 File Offset: 0x001D1744
		// (set) Token: 0x06013E47 RID: 81479 RVA: 0x001D3558 File Offset: 0x001D1758
		public unsafe UTransformProxy TransformProxy
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTransformProxy>(base.NativePtr / (IntPtr)sizeof(void*) + UIntervalGizmo.__PropertyOffset_TransformProxy);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UIntervalGizmo.__PropertyOffset_TransformProxy, value);
			}
		}

		// Token: 0x17004DE2 RID: 19938
		// (get) Token: 0x06013E48 RID: 81480 RVA: 0x001D3570 File Offset: 0x001D1770
		// (set) Token: 0x06013E49 RID: 81481 RVA: 0x001D35A9 File Offset: 0x001D17A9
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
					result = (this._ActiveComponents = new TArray<UPrimitiveComponent>(base.NativePtr + (IntPtr)UIntervalGizmo.__PropertyOffset_ActiveComponents, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ActiveComponents.CopyAssign(value);
			}
		}

		// Token: 0x17004DE3 RID: 19939
		// (get) Token: 0x06013E4A RID: 81482 RVA: 0x001D35B8 File Offset: 0x001D17B8
		// (set) Token: 0x06013E4B RID: 81483 RVA: 0x001D35F1 File Offset: 0x001D17F1
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
					result = (this._ActiveGizmos = new TArray<UInteractiveGizmo>(base.NativePtr + (IntPtr)UIntervalGizmo.__PropertyOffset_ActiveGizmos, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ActiveGizmos.CopyAssign(value);
			}
		}

		// Token: 0x17004DE4 RID: 19940
		// (get) Token: 0x06013E4C RID: 81484 RVA: 0x001D35FF File Offset: 0x001D17FF
		// (set) Token: 0x06013E4D RID: 81485 RVA: 0x001D3613 File Offset: 0x001D1813
		public unsafe UGizmoComponentAxisSource AxisYSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGizmoComponentAxisSource>(base.NativePtr / (IntPtr)sizeof(void*) + UIntervalGizmo.__PropertyOffset_AxisYSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UIntervalGizmo.__PropertyOffset_AxisYSource, value);
			}
		}

		// Token: 0x17004DE5 RID: 19941
		// (get) Token: 0x06013E4E RID: 81486 RVA: 0x001D3628 File Offset: 0x001D1828
		// (set) Token: 0x06013E4F RID: 81487 RVA: 0x001D363C File Offset: 0x001D183C
		public unsafe UGizmoComponentAxisSource AxisZSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGizmoComponentAxisSource>(base.NativePtr / (IntPtr)sizeof(void*) + UIntervalGizmo.__PropertyOffset_AxisZSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UIntervalGizmo.__PropertyOffset_AxisZSource, value);
			}
		}

		// Token: 0x06013E50 RID: 81488 RVA: 0x001D3651 File Offset: 0x001D1851
		static UIntervalGizmo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.IntervalGizmo");
		}

		// Token: 0x06013E51 RID: 81489 RVA: 0x001D365F File Offset: 0x001D185F
		protected UIntervalGizmo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC38 RID: 44088
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.IntervalGizmo";

		// Token: 0x0400AC39 RID: 44089
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC3A RID: 44090
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AC3B RID: 44091
		internal static int __PropertyOffset_StateTarget;

		// Token: 0x0400AC3C RID: 44092
		internal static int __PropertyOffset_TransformProxy;

		// Token: 0x0400AC3D RID: 44093
		internal static int __PropertyOffset_ActiveComponents;

		// Token: 0x0400AC3E RID: 44094
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPrimitiveComponent> _ActiveComponents;

		// Token: 0x0400AC3F RID: 44095
		internal static int __PropertyOffset_ActiveGizmos;

		// Token: 0x0400AC40 RID: 44096
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UInteractiveGizmo> _ActiveGizmos;

		// Token: 0x0400AC41 RID: 44097
		internal static int __PropertyOffset_AxisYSource;

		// Token: 0x0400AC42 RID: 44098
		internal static int __PropertyOffset_AxisZSource;
	}
}
