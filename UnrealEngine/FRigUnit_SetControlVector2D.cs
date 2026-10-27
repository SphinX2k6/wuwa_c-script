using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006BE RID: 1726
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetControlVector2D")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRigUnit_SetControlVector2D : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005C43 RID: 23619 RVA: 0x00084725 File Offset: 0x00082925
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetControlVector2D._ScriptStructPtr != 0) ? FRigUnit_SetControlVector2D._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetControlVector2D", ref FRigUnit_SetControlVector2D._ScriptStructPtr);
		}

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x06005C44 RID: 23620 RVA: 0x00084749 File Offset: 0x00082949
		// (set) Token: 0x06005C45 RID: 23621 RVA: 0x0008475D File Offset: 0x0008295D
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlVector2D.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlVector2D.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x06005C46 RID: 23622 RVA: 0x00084772 File Offset: 0x00082972
		// (set) Token: 0x06005C47 RID: 23623 RVA: 0x00084782 File Offset: 0x00082982
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlVector2D.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlVector2D.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x06005C48 RID: 23624 RVA: 0x00084793 File Offset: 0x00082993
		// (set) Token: 0x06005C49 RID: 23625 RVA: 0x000847A7 File Offset: 0x000829A7
		public unsafe FVector2D Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlVector2D.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlVector2D.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x06005C4A RID: 23626 RVA: 0x000847BC File Offset: 0x000829BC
		// (set) Token: 0x06005C4B RID: 23627 RVA: 0x000847FF File Offset: 0x000829FF
		public FCachedRigElement CachedControlIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedControlIndex) == null)
				{
					result = (this._CachedControlIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetControlVector2D.__PropertyOffset_CachedControlIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetControlVector2D.__PropertyOffset_CachedControlIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005C4C RID: 23628 RVA: 0x00084820 File Offset: 0x00082A20
		public FRigUnit_SetControlVector2D()
		{
		}

		// Token: 0x06005C4D RID: 23629 RVA: 0x00084828 File Offset: 0x00082A28
		public FRigUnit_SetControlVector2D(FName Control, float Weight, FVector2D Vector, FCachedRigElement CachedControlIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.Control = Control;
			this.Weight = Weight;
			this.Vector = Vector;
			this.CachedControlIndex = CachedControlIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005C4E RID: 23630 RVA: 0x00084855 File Offset: 0x00082A55
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetControlVector2D.StaticStruct();
		}

		// Token: 0x06005C4F RID: 23631 RVA: 0x00084861 File Offset: 0x00082A61
		[NullableContext(2)]
		public FRigUnit_SetControlVector2D(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005C50 RID: 23632 RVA: 0x0008486B File Offset: 0x00082A6B
		public FRigUnit_SetControlVector2D(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005C51 RID: 23633 RVA: 0x00084876 File Offset: 0x00082A76
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetControlVector2D(Pointer, false, true);
		}

		// Token: 0x06005C52 RID: 23634 RVA: 0x00084880 File Offset: 0x00082A80
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetControlVector2D(Pointer, MemoryOwner);
		}

		// Token: 0x04002B2F RID: 11055
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetControlVector2D";

		// Token: 0x04002B30 RID: 11056
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B31 RID: 11057
		internal static int __PropertyOffset_Control;

		// Token: 0x04002B32 RID: 11058
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002B33 RID: 11059
		internal static int __PropertyOffset_Vector;

		// Token: 0x04002B34 RID: 11060
		internal static int __PropertyOffset_CachedControlIndex;

		// Token: 0x04002B35 RID: 11061
		[Nullable(2)]
		private FCachedRigElement _CachedControlIndex;
	}
}
