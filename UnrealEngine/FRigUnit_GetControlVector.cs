using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005B6 RID: 1462
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_GetControlVector")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FRigUnit_GetControlVector : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004EE1 RID: 20193 RVA: 0x00074801 File Offset: 0x00072A01
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_GetControlVector._ScriptStructPtr != 0) ? FRigUnit_GetControlVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_GetControlVector", ref FRigUnit_GetControlVector._ScriptStructPtr);
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x06004EE2 RID: 20194 RVA: 0x00074825 File Offset: 0x00072A25
		// (set) Token: 0x06004EE3 RID: 20195 RVA: 0x00074839 File Offset: 0x00072A39
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlVector.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlVector.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x06004EE4 RID: 20196 RVA: 0x0007484E File Offset: 0x00072A4E
		// (set) Token: 0x06004EE5 RID: 20197 RVA: 0x0007485E File Offset: 0x00072A5E
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_GetControlVector.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlVector.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x06004EE6 RID: 20198 RVA: 0x0007486F File Offset: 0x00072A6F
		// (set) Token: 0x06004EE7 RID: 20199 RVA: 0x00074883 File Offset: 0x00072A83
		public unsafe FVector Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlVector.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlVector.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x06004EE8 RID: 20200 RVA: 0x00074898 File Offset: 0x00072A98
		// (set) Token: 0x06004EE9 RID: 20201 RVA: 0x000748AC File Offset: 0x00072AAC
		public unsafe FVector Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlVector.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlVector.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06004EEA RID: 20202 RVA: 0x000748C1 File Offset: 0x00072AC1
		// (set) Token: 0x06004EEB RID: 20203 RVA: 0x000748D5 File Offset: 0x00072AD5
		public unsafe FVector Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlVector.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlVector.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x06004EEC RID: 20204 RVA: 0x000748EC File Offset: 0x00072AEC
		// (set) Token: 0x06004EED RID: 20205 RVA: 0x0007492F File Offset: 0x00072B2F
		public FCachedRigElement CachedControlIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedControlIndex) == null)
				{
					result = (this._CachedControlIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_GetControlVector.__PropertyOffset_CachedControlIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetControlVector.__PropertyOffset_CachedControlIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004EEE RID: 20206 RVA: 0x00074950 File Offset: 0x00072B50
		public FRigUnit_GetControlVector()
		{
		}

		// Token: 0x06004EEF RID: 20207 RVA: 0x00074958 File Offset: 0x00072B58
		public FRigUnit_GetControlVector(FName Control, EBoneGetterSetterMode Space, FVector Vector, FVector Minimum, FVector Maximum, FCachedRigElement CachedControlIndex)
		{
			this.Control = Control;
			this.Space = Space;
			this.Vector = Vector;
			this.Minimum = Minimum;
			this.Maximum = Maximum;
			this.CachedControlIndex = CachedControlIndex;
		}

		// Token: 0x06004EF0 RID: 20208 RVA: 0x0007498D File Offset: 0x00072B8D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_GetControlVector.StaticStruct();
		}

		// Token: 0x06004EF1 RID: 20209 RVA: 0x00074999 File Offset: 0x00072B99
		[NullableContext(2)]
		public FRigUnit_GetControlVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004EF2 RID: 20210 RVA: 0x000749A3 File Offset: 0x00072BA3
		public FRigUnit_GetControlVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004EF3 RID: 20211 RVA: 0x000749AE File Offset: 0x00072BAE
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_GetControlVector(Pointer, false, true);
		}

		// Token: 0x06004EF4 RID: 20212 RVA: 0x000749B8 File Offset: 0x00072BB8
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_GetControlVector(Pointer, MemoryOwner);
		}

		// Token: 0x04002619 RID: 9753
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_GetControlVector";

		// Token: 0x0400261A RID: 9754
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400261B RID: 9755
		internal static int __PropertyOffset_Control;

		// Token: 0x0400261C RID: 9756
		internal static int __PropertyOffset_Space;

		// Token: 0x0400261D RID: 9757
		internal static int __PropertyOffset_Vector;

		// Token: 0x0400261E RID: 9758
		internal static int __PropertyOffset_Minimum;

		// Token: 0x0400261F RID: 9759
		internal static int __PropertyOffset_Maximum;

		// Token: 0x04002620 RID: 9760
		internal static int __PropertyOffset_CachedControlIndex;

		// Token: 0x04002621 RID: 9761
		[Nullable(2)]
		private FCachedRigElement _CachedControlIndex;
	}
}
