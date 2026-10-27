using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006BB RID: 1723
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetControlRotator")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FRigUnit_SetControlRotator : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005C0D RID: 23565 RVA: 0x00084275 File Offset: 0x00082475
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetControlRotator._ScriptStructPtr != 0) ? FRigUnit_SetControlRotator._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetControlRotator", ref FRigUnit_SetControlRotator._ScriptStructPtr);
		}

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x06005C0E RID: 23566 RVA: 0x00084299 File Offset: 0x00082499
		// (set) Token: 0x06005C0F RID: 23567 RVA: 0x000842AD File Offset: 0x000824AD
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlRotator.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlRotator.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x06005C10 RID: 23568 RVA: 0x000842C2 File Offset: 0x000824C2
		// (set) Token: 0x06005C11 RID: 23569 RVA: 0x000842D2 File Offset: 0x000824D2
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlRotator.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlRotator.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x06005C12 RID: 23570 RVA: 0x000842E3 File Offset: 0x000824E3
		// (set) Token: 0x06005C13 RID: 23571 RVA: 0x000842F7 File Offset: 0x000824F7
		public unsafe FRotator Rotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlRotator.__PropertyOffset_Rotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlRotator.__PropertyOffset_Rotator) = value;
			}
		}

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x06005C14 RID: 23572 RVA: 0x0008430C File Offset: 0x0008250C
		// (set) Token: 0x06005C15 RID: 23573 RVA: 0x0008431C File Offset: 0x0008251C
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_SetControlRotator.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlRotator.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x06005C16 RID: 23574 RVA: 0x00084330 File Offset: 0x00082530
		// (set) Token: 0x06005C17 RID: 23575 RVA: 0x00084373 File Offset: 0x00082573
		public FCachedRigElement CachedControlIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedControlIndex) == null)
				{
					result = (this._CachedControlIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetControlRotator.__PropertyOffset_CachedControlIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetControlRotator.__PropertyOffset_CachedControlIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005C18 RID: 23576 RVA: 0x00084394 File Offset: 0x00082594
		public FRigUnit_SetControlRotator()
		{
		}

		// Token: 0x06005C19 RID: 23577 RVA: 0x0008439C File Offset: 0x0008259C
		public FRigUnit_SetControlRotator(FName Control, float Weight, FRotator Rotator, EBoneGetterSetterMode Space, FCachedRigElement CachedControlIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.Control = Control;
			this.Weight = Weight;
			this.Rotator = Rotator;
			this.Space = Space;
			this.CachedControlIndex = CachedControlIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005C1A RID: 23578 RVA: 0x000843D1 File Offset: 0x000825D1
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetControlRotator.StaticStruct();
		}

		// Token: 0x06005C1B RID: 23579 RVA: 0x000843DD File Offset: 0x000825DD
		[NullableContext(2)]
		public FRigUnit_SetControlRotator(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005C1C RID: 23580 RVA: 0x000843E7 File Offset: 0x000825E7
		public FRigUnit_SetControlRotator(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005C1D RID: 23581 RVA: 0x000843F2 File Offset: 0x000825F2
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetControlRotator(Pointer, false, true);
		}

		// Token: 0x06005C1E RID: 23582 RVA: 0x000843FC File Offset: 0x000825FC
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetControlRotator(Pointer, MemoryOwner);
		}

		// Token: 0x04002B17 RID: 11031
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetControlRotator";

		// Token: 0x04002B18 RID: 11032
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B19 RID: 11033
		internal static int __PropertyOffset_Control;

		// Token: 0x04002B1A RID: 11034
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002B1B RID: 11035
		internal static int __PropertyOffset_Rotator;

		// Token: 0x04002B1C RID: 11036
		internal static int __PropertyOffset_Space;

		// Token: 0x04002B1D RID: 11037
		internal static int __PropertyOffset_CachedControlIndex;

		// Token: 0x04002B1E RID: 11038
		[Nullable(2)]
		private FCachedRigElement _CachedControlIndex;
	}
}
