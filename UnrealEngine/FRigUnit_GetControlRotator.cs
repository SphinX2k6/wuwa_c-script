using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005B4 RID: 1460
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_GetControlRotator")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FRigUnit_GetControlRotator : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004EB9 RID: 20153 RVA: 0x00074481 File Offset: 0x00072681
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_GetControlRotator._ScriptStructPtr != 0) ? FRigUnit_GetControlRotator._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_GetControlRotator", ref FRigUnit_GetControlRotator._ScriptStructPtr);
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x06004EBA RID: 20154 RVA: 0x000744A5 File Offset: 0x000726A5
		// (set) Token: 0x06004EBB RID: 20155 RVA: 0x000744B9 File Offset: 0x000726B9
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlRotator.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlRotator.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x06004EBC RID: 20156 RVA: 0x000744CE File Offset: 0x000726CE
		// (set) Token: 0x06004EBD RID: 20157 RVA: 0x000744DE File Offset: 0x000726DE
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_GetControlRotator.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlRotator.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x06004EBE RID: 20158 RVA: 0x000744EF File Offset: 0x000726EF
		// (set) Token: 0x06004EBF RID: 20159 RVA: 0x00074503 File Offset: 0x00072703
		public unsafe FRotator Rotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlRotator.__PropertyOffset_Rotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlRotator.__PropertyOffset_Rotator) = value;
			}
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x06004EC0 RID: 20160 RVA: 0x00074518 File Offset: 0x00072718
		// (set) Token: 0x06004EC1 RID: 20161 RVA: 0x0007452C File Offset: 0x0007272C
		public unsafe FRotator Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlRotator.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlRotator.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x06004EC2 RID: 20162 RVA: 0x00074541 File Offset: 0x00072741
		// (set) Token: 0x06004EC3 RID: 20163 RVA: 0x00074555 File Offset: 0x00072755
		public unsafe FRotator Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlRotator.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlRotator.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x06004EC4 RID: 20164 RVA: 0x0007456C File Offset: 0x0007276C
		// (set) Token: 0x06004EC5 RID: 20165 RVA: 0x000745AF File Offset: 0x000727AF
		public FCachedRigElement CachedControlIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedControlIndex) == null)
				{
					result = (this._CachedControlIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_GetControlRotator.__PropertyOffset_CachedControlIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetControlRotator.__PropertyOffset_CachedControlIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004EC6 RID: 20166 RVA: 0x000745D0 File Offset: 0x000727D0
		public FRigUnit_GetControlRotator()
		{
		}

		// Token: 0x06004EC7 RID: 20167 RVA: 0x000745D8 File Offset: 0x000727D8
		public FRigUnit_GetControlRotator(FName Control, EBoneGetterSetterMode Space, FRotator Rotator, FRotator Minimum, FRotator Maximum, FCachedRigElement CachedControlIndex)
		{
			this.Control = Control;
			this.Space = Space;
			this.Rotator = Rotator;
			this.Minimum = Minimum;
			this.Maximum = Maximum;
			this.CachedControlIndex = CachedControlIndex;
		}

		// Token: 0x06004EC8 RID: 20168 RVA: 0x0007460D File Offset: 0x0007280D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_GetControlRotator.StaticStruct();
		}

		// Token: 0x06004EC9 RID: 20169 RVA: 0x00074619 File Offset: 0x00072819
		[NullableContext(2)]
		public FRigUnit_GetControlRotator(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004ECA RID: 20170 RVA: 0x00074623 File Offset: 0x00072823
		public FRigUnit_GetControlRotator(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004ECB RID: 20171 RVA: 0x0007462E File Offset: 0x0007282E
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_GetControlRotator(Pointer, false, true);
		}

		// Token: 0x06004ECC RID: 20172 RVA: 0x00074638 File Offset: 0x00072838
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_GetControlRotator(Pointer, MemoryOwner);
		}

		// Token: 0x04002607 RID: 9735
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_GetControlRotator";

		// Token: 0x04002608 RID: 9736
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002609 RID: 9737
		internal static int __PropertyOffset_Control;

		// Token: 0x0400260A RID: 9738
		internal static int __PropertyOffset_Space;

		// Token: 0x0400260B RID: 9739
		internal static int __PropertyOffset_Rotator;

		// Token: 0x0400260C RID: 9740
		internal static int __PropertyOffset_Minimum;

		// Token: 0x0400260D RID: 9741
		internal static int __PropertyOffset_Maximum;

		// Token: 0x0400260E RID: 9742
		internal static int __PropertyOffset_CachedControlIndex;

		// Token: 0x0400260F RID: 9743
		[Nullable(2)]
		private FCachedRigElement _CachedControlIndex;
	}
}
