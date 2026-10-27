using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004C6 RID: 1222
	[UnrealObjectPath("/Script/ControlRig.ControlRigGizmoActor")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1088)]
	public class AControlRigGizmoActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060041A2 RID: 16802 RVA: 0x00062450 File Offset: 0x00060650
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AControlRigGizmoActor._ClassPtr;
		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x0006245C File Offset: 0x0006065C
		public AControlRigGizmoActor() : this(BuiltinUtils.AllocNativeUObject(AControlRigGizmoActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x00062484 File Offset: 0x00060684
		[NullableContext(1)]
		public AControlRigGizmoActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AControlRigGizmoActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x060041A5 RID: 16805 RVA: 0x000624B7 File Offset: 0x000606B7
		// (set) Token: 0x060041A6 RID: 16806 RVA: 0x000624CB File Offset: 0x000606CB
		[Nullable(2)]
		public unsafe USceneComponent ActorRootComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AControlRigGizmoActor.__PropertyOffset_ActorRootComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AControlRigGizmoActor.__PropertyOffset_ActorRootComponent, value);
			}
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x060041A7 RID: 16807 RVA: 0x000624E0 File Offset: 0x000606E0
		// (set) Token: 0x060041A8 RID: 16808 RVA: 0x000624F4 File Offset: 0x000606F4
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMeshComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AControlRigGizmoActor.__PropertyOffset_StaticMeshComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AControlRigGizmoActor.__PropertyOffset_StaticMeshComponent, value);
			}
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x060041A9 RID: 16809 RVA: 0x00062509 File Offset: 0x00060709
		// (set) Token: 0x060041AA RID: 16810 RVA: 0x00062519 File Offset: 0x00060719
		public unsafe uint ControlRigIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AControlRigGizmoActor.__PropertyOffset_ControlRigIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AControlRigGizmoActor.__PropertyOffset_ControlRigIndex) = (int)value;
			}
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x060041AB RID: 16811 RVA: 0x0006252A File Offset: 0x0006072A
		// (set) Token: 0x060041AC RID: 16812 RVA: 0x0006253E File Offset: 0x0006073E
		public unsafe FName ControlName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AControlRigGizmoActor.__PropertyOffset_ControlName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AControlRigGizmoActor.__PropertyOffset_ControlName) = value;
			}
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x060041AD RID: 16813 RVA: 0x00062553 File Offset: 0x00060753
		// (set) Token: 0x060041AE RID: 16814 RVA: 0x00062567 File Offset: 0x00060767
		public unsafe FName ColorParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AControlRigGizmoActor.__PropertyOffset_ColorParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AControlRigGizmoActor.__PropertyOffset_ColorParameterName) = value;
			}
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x060041AF RID: 16815 RVA: 0x0006257C File Offset: 0x0006077C
		// (set) Token: 0x060041B0 RID: 16816 RVA: 0x00062595 File Offset: 0x00060795
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AControlRigGizmoActor.__PropertyOffset_bEnabled) & AControlRigGizmoActor.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AControlRigGizmoActor.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)AControlRigGizmoActor.__PropertyOffset_bEnabled) & ~AControlRigGizmoActor.__PropertyMask_bEnabled) | (value ? AControlRigGizmoActor.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x060041B1 RID: 16817 RVA: 0x000625C5 File Offset: 0x000607C5
		// (set) Token: 0x060041B2 RID: 16818 RVA: 0x000625DE File Offset: 0x000607DE
		public unsafe bool bSelected
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AControlRigGizmoActor.__PropertyOffset_bSelected) & AControlRigGizmoActor.__PropertyMask_bSelected) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AControlRigGizmoActor.__PropertyOffset_bSelected) = ((*(base.NativePtr + (IntPtr)AControlRigGizmoActor.__PropertyOffset_bSelected) & ~AControlRigGizmoActor.__PropertyMask_bSelected) | (value ? AControlRigGizmoActor.__PropertyMask_bSelected : 0));
			}
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x060041B3 RID: 16819 RVA: 0x0006260E File Offset: 0x0006080E
		// (set) Token: 0x060041B4 RID: 16820 RVA: 0x00062627 File Offset: 0x00060827
		public unsafe bool bSelectable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AControlRigGizmoActor.__PropertyOffset_bSelectable) & AControlRigGizmoActor.__PropertyMask_bSelectable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AControlRigGizmoActor.__PropertyOffset_bSelectable) = ((*(base.NativePtr + (IntPtr)AControlRigGizmoActor.__PropertyOffset_bSelectable) & ~AControlRigGizmoActor.__PropertyMask_bSelectable) | (value ? AControlRigGizmoActor.__PropertyMask_bSelectable : 0));
			}
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x060041B5 RID: 16821 RVA: 0x00062657 File Offset: 0x00060857
		// (set) Token: 0x060041B6 RID: 16822 RVA: 0x00062670 File Offset: 0x00060870
		public unsafe bool bHovered
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AControlRigGizmoActor.__PropertyOffset_bHovered) & AControlRigGizmoActor.__PropertyMask_bHovered) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AControlRigGizmoActor.__PropertyOffset_bHovered) = ((*(base.NativePtr + (IntPtr)AControlRigGizmoActor.__PropertyOffset_bHovered) & ~AControlRigGizmoActor.__PropertyMask_bHovered) | (value ? AControlRigGizmoActor.__PropertyMask_bHovered : 0));
			}
		}

		// Token: 0x060041B7 RID: 16823 RVA: 0x000626A0 File Offset: 0x000608A0
		public void SetSelected(bool bInSelected)
		{
			AControlRigGizmoActor.__SetSelected_Internal(base.NativePtr, bInSelected);
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x000626AE File Offset: 0x000608AE
		public void SetSelectable(bool bInSelectable)
		{
			AControlRigGizmoActor.__SetSelectable_Internal(base.NativePtr, bInSelectable);
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x000626BC File Offset: 0x000608BC
		public void SetHovered(bool bInHovered)
		{
			AControlRigGizmoActor.__SetHovered_Internal(base.NativePtr, bInHovered);
		}

		// Token: 0x060041BA RID: 16826 RVA: 0x000626CC File Offset: 0x000608CC
		public unsafe void SetGlobalTransform(in FTransform InTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InTransform;
			AControlRigGizmoActor.__SetGlobalTransform_Internal(base.NativePtr, ptr);
		}

		// Token: 0x060041BB RID: 16827 RVA: 0x00062701 File Offset: 0x00060901
		public void SetEnabled(bool bInEnabled)
		{
			AControlRigGizmoActor.__SetEnabled_Internal(base.NativePtr, bInEnabled);
		}

		// Token: 0x060041BC RID: 16828 RVA: 0x00062710 File Offset: 0x00060910
		public unsafe virtual void OnTransformChanged(in FTransform NewTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			AControlRigGizmoActor.__OnTransformChanged_Internal(base.NativePtr, ptr);
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x00062745 File Offset: 0x00060945
		public virtual void OnSelectionChanged(bool bIsSelected)
		{
			AControlRigGizmoActor.__OnSelectionChanged_Internal(base.NativePtr, bIsSelected);
		}

		// Token: 0x060041BE RID: 16830 RVA: 0x00062753 File Offset: 0x00060953
		public virtual void OnManipulatingChanged(bool bIsManipulating)
		{
			AControlRigGizmoActor.__OnManipulatingChanged_Internal(base.NativePtr, bIsManipulating);
		}

		// Token: 0x060041BF RID: 16831 RVA: 0x00062761 File Offset: 0x00060961
		public virtual void OnHoveredChanged(bool bIsSelected)
		{
			AControlRigGizmoActor.__OnHoveredChanged_Internal(base.NativePtr, bIsSelected);
		}

		// Token: 0x060041C0 RID: 16832 RVA: 0x0006276F File Offset: 0x0006096F
		public virtual void OnEnabledChanged(bool bIsEnabled)
		{
			AControlRigGizmoActor.__OnEnabledChanged_Internal(base.NativePtr, bIsEnabled);
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x0006277D File Offset: 0x0006097D
		public bool IsSelectedInEditor()
		{
			return AControlRigGizmoActor.__IsSelectedInEditor_Internal(base.NativePtr);
		}

		// Token: 0x060041C2 RID: 16834 RVA: 0x0006278A File Offset: 0x0006098A
		public bool IsHovered()
		{
			return AControlRigGizmoActor.__IsHovered_Internal(base.NativePtr);
		}

		// Token: 0x060041C3 RID: 16835 RVA: 0x00062797 File Offset: 0x00060997
		public bool IsEnabled()
		{
			return AControlRigGizmoActor.__IsEnabled_Internal(base.NativePtr);
		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x000627A4 File Offset: 0x000609A4
		public FTransform GetGlobalTransform()
		{
			return AControlRigGizmoActor.__GetGlobalTransform_Internal(base.NativePtr);
		}

		// Token: 0x060041C5 RID: 16837
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelected_Internal(IntPtr @this, bool bInSelected);

		// Token: 0x060041C6 RID: 16838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectable_Internal(IntPtr @this, bool bInSelectable);

		// Token: 0x060041C7 RID: 16839
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHovered_Internal(IntPtr @this, bool bInHovered);

		// Token: 0x060041C8 RID: 16840
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalTransform_Internal(IntPtr @this, in FTransform InTransform);

		// Token: 0x060041C9 RID: 16841
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnabled_Internal(IntPtr @this, bool bInEnabled);

		// Token: 0x060041CA RID: 16842
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnTransformChanged_Internal(IntPtr @this, in FTransform NewTransform);

		// Token: 0x060041CB RID: 16843
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnSelectionChanged_Internal(IntPtr @this, bool bIsSelected);

		// Token: 0x060041CC RID: 16844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnManipulatingChanged_Internal(IntPtr @this, bool bIsManipulating);

		// Token: 0x060041CD RID: 16845
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnHoveredChanged_Internal(IntPtr @this, bool bIsSelected);

		// Token: 0x060041CE RID: 16846
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnEnabledChanged_Internal(IntPtr @this, bool bIsEnabled);

		// Token: 0x060041CF RID: 16847
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSelectedInEditor_Internal(IntPtr @this);

		// Token: 0x060041D0 RID: 16848
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsHovered_Internal(IntPtr @this);

		// Token: 0x060041D1 RID: 16849
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEnabled_Internal(IntPtr @this);

		// Token: 0x060041D2 RID: 16850
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetGlobalTransform_Internal(IntPtr @this);

		// Token: 0x060041D3 RID: 16851 RVA: 0x000627B1 File Offset: 0x000609B1
		static AControlRigGizmoActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ControlRig.ControlRigGizmoActor");
		}

		// Token: 0x060041D4 RID: 16852 RVA: 0x000627BF File Offset: 0x000609BF
		protected AControlRigGizmoActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F38 RID: 7992
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.ControlRigGizmoActor";

		// Token: 0x04001F39 RID: 7993
		private static IntPtr _ClassPtr;

		// Token: 0x04001F3A RID: 7994
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001F3B RID: 7995
		internal static int __PropertyOffset_ActorRootComponent;

		// Token: 0x04001F3C RID: 7996
		internal static int __PropertyOffset_StaticMeshComponent;

		// Token: 0x04001F3D RID: 7997
		internal static int __PropertyOffset_ControlRigIndex;

		// Token: 0x04001F3E RID: 7998
		internal static int __PropertyOffset_ControlName;

		// Token: 0x04001F3F RID: 7999
		internal static int __PropertyOffset_ColorParameterName;

		// Token: 0x04001F40 RID: 8000
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04001F41 RID: 8001
		internal static byte __PropertyMask_bEnabled;

		// Token: 0x04001F42 RID: 8002
		internal static int __PropertyOffset_bSelected;

		// Token: 0x04001F43 RID: 8003
		internal static byte __PropertyMask_bSelected;

		// Token: 0x04001F44 RID: 8004
		internal static int __PropertyOffset_bSelectable;

		// Token: 0x04001F45 RID: 8005
		internal static byte __PropertyMask_bSelectable;

		// Token: 0x04001F46 RID: 8006
		internal static int __PropertyOffset_bHovered;

		// Token: 0x04001F47 RID: 8007
		internal static byte __PropertyMask_bHovered;

		// Token: 0x02002C44 RID: 11332
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __OnTransformChanged_FunctionParams
		{
			// Token: 0x0401654D RID: 91469
			[FieldOffset(0)]
			public FTransform NewTransform;
		}

		// Token: 0x02002C45 RID: 11333
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnSelectionChanged_FunctionParams
		{
			// Token: 0x0401654E RID: 91470
			[FieldOffset(0)]
			public bool bIsSelected;
		}

		// Token: 0x02002C46 RID: 11334
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnManipulatingChanged_FunctionParams
		{
			// Token: 0x0401654F RID: 91471
			[FieldOffset(0)]
			public bool bIsManipulating;
		}

		// Token: 0x02002C47 RID: 11335
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnHoveredChanged_FunctionParams
		{
			// Token: 0x04016550 RID: 91472
			[FieldOffset(0)]
			public bool bIsSelected;
		}

		// Token: 0x02002C48 RID: 11336
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnEnabledChanged_FunctionParams
		{
			// Token: 0x04016551 RID: 91473
			[FieldOffset(0)]
			public bool bIsEnabled;
		}
	}
}
