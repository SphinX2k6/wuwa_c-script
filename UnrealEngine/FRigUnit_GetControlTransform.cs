using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005B5 RID: 1461
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_GetControlTransform")]
	[UnrealStructLayout(208, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FRigUnit_GetControlTransform : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004ECD RID: 20173 RVA: 0x00074641 File Offset: 0x00072841
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_GetControlTransform._ScriptStructPtr != 0) ? FRigUnit_GetControlTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_GetControlTransform", ref FRigUnit_GetControlTransform._ScriptStructPtr);
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x06004ECE RID: 20174 RVA: 0x00074665 File Offset: 0x00072865
		// (set) Token: 0x06004ECF RID: 20175 RVA: 0x00074679 File Offset: 0x00072879
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlTransform.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlTransform.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x06004ED0 RID: 20176 RVA: 0x0007468E File Offset: 0x0007288E
		// (set) Token: 0x06004ED1 RID: 20177 RVA: 0x0007469E File Offset: 0x0007289E
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_GetControlTransform.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlTransform.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x06004ED2 RID: 20178 RVA: 0x000746AF File Offset: 0x000728AF
		// (set) Token: 0x06004ED3 RID: 20179 RVA: 0x000746C3 File Offset: 0x000728C3
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlTransform.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlTransform.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x06004ED4 RID: 20180 RVA: 0x000746D8 File Offset: 0x000728D8
		// (set) Token: 0x06004ED5 RID: 20181 RVA: 0x000746EC File Offset: 0x000728EC
		public unsafe FTransform Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlTransform.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlTransform.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x06004ED6 RID: 20182 RVA: 0x00074701 File Offset: 0x00072901
		// (set) Token: 0x06004ED7 RID: 20183 RVA: 0x00074715 File Offset: 0x00072915
		public unsafe FTransform Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlTransform.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlTransform.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x06004ED8 RID: 20184 RVA: 0x0007472C File Offset: 0x0007292C
		// (set) Token: 0x06004ED9 RID: 20185 RVA: 0x0007476F File Offset: 0x0007296F
		public FCachedRigElement CachedControlIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedControlIndex) == null)
				{
					result = (this._CachedControlIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_GetControlTransform.__PropertyOffset_CachedControlIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetControlTransform.__PropertyOffset_CachedControlIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004EDA RID: 20186 RVA: 0x00074790 File Offset: 0x00072990
		public FRigUnit_GetControlTransform()
		{
		}

		// Token: 0x06004EDB RID: 20187 RVA: 0x00074798 File Offset: 0x00072998
		public FRigUnit_GetControlTransform(FName Control, EBoneGetterSetterMode Space, FTransform Transform, FTransform Minimum, FTransform Maximum, FCachedRigElement CachedControlIndex)
		{
			this.Control = Control;
			this.Space = Space;
			this.Transform = Transform;
			this.Minimum = Minimum;
			this.Maximum = Maximum;
			this.CachedControlIndex = CachedControlIndex;
		}

		// Token: 0x06004EDC RID: 20188 RVA: 0x000747CD File Offset: 0x000729CD
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_GetControlTransform.StaticStruct();
		}

		// Token: 0x06004EDD RID: 20189 RVA: 0x000747D9 File Offset: 0x000729D9
		[NullableContext(2)]
		public FRigUnit_GetControlTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004EDE RID: 20190 RVA: 0x000747E3 File Offset: 0x000729E3
		public FRigUnit_GetControlTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004EDF RID: 20191 RVA: 0x000747EE File Offset: 0x000729EE
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_GetControlTransform(Pointer, false, true);
		}

		// Token: 0x06004EE0 RID: 20192 RVA: 0x000747F8 File Offset: 0x000729F8
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_GetControlTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04002610 RID: 9744
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_GetControlTransform";

		// Token: 0x04002611 RID: 9745
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002612 RID: 9746
		internal static int __PropertyOffset_Control;

		// Token: 0x04002613 RID: 9747
		internal static int __PropertyOffset_Space;

		// Token: 0x04002614 RID: 9748
		internal static int __PropertyOffset_Transform;

		// Token: 0x04002615 RID: 9749
		internal static int __PropertyOffset_Minimum;

		// Token: 0x04002616 RID: 9750
		internal static int __PropertyOffset_Maximum;

		// Token: 0x04002617 RID: 9751
		internal static int __PropertyOffset_CachedControlIndex;

		// Token: 0x04002618 RID: 9752
		[Nullable(2)]
		private FCachedRigElement _CachedControlIndex;
	}
}
