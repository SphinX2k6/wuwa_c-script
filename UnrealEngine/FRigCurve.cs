using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200051C RID: 1308
	[UnrealObjectPath("/Script/ControlRig.RigCurve")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigCurve : FRigElement, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060044A0 RID: 17568 RVA: 0x0006638C File Offset: 0x0006458C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigCurve._ScriptStructPtr != 0) ? FRigCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigCurve", ref FRigCurve._ScriptStructPtr);
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x060044A1 RID: 17569 RVA: 0x000663B0 File Offset: 0x000645B0
		// (set) Token: 0x060044A2 RID: 17570 RVA: 0x000663C0 File Offset: 0x000645C0
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigCurve.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigCurve.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x060044A3 RID: 17571 RVA: 0x000663D1 File Offset: 0x000645D1
		public FRigCurve()
		{
		}

		// Token: 0x060044A4 RID: 17572 RVA: 0x000663D9 File Offset: 0x000645D9
		public FRigCurve(float Value, FName Name, int Index)
		{
			this.Value = Value;
			base.Name = Name;
			base.Index = Index;
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x000663F6 File Offset: 0x000645F6
		protected override IntPtr GetUStructPtr()
		{
			return FRigCurve.StaticStruct();
		}

		// Token: 0x060044A6 RID: 17574 RVA: 0x00066402 File Offset: 0x00064602
		[NullableContext(2)]
		public FRigCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060044A7 RID: 17575 RVA: 0x0006640C File Offset: 0x0006460C
		public FRigCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060044A8 RID: 17576 RVA: 0x00066417 File Offset: 0x00064617
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigCurve(Pointer, false, true);
		}

		// Token: 0x060044A9 RID: 17577 RVA: 0x00066421 File Offset: 0x00064621
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04002172 RID: 8562
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigCurve";

		// Token: 0x04002173 RID: 8563
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002174 RID: 8564
		internal static int __PropertyOffset_Value;
	}
}
