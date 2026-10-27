using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008C4 RID: 2244
	[UnrealObjectPath("/Script/Engine.BlueprintInputAxisDelegateBinding")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FBlueprintInputAxisDelegateBinding : FBlueprintInputDelegateBinding, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007A91 RID: 31377 RVA: 0x000AF546 File Offset: 0x000AD746
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlueprintInputAxisDelegateBinding._ScriptStructPtr != 0) ? FBlueprintInputAxisDelegateBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BlueprintInputAxisDelegateBinding", ref FBlueprintInputAxisDelegateBinding._ScriptStructPtr);
		}

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x06007A92 RID: 31378 RVA: 0x000AF56A File Offset: 0x000AD76A
		// (set) Token: 0x06007A93 RID: 31379 RVA: 0x000AF57E File Offset: 0x000AD77E
		public unsafe FName InputAxisName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlueprintInputAxisDelegateBinding.__PropertyOffset_InputAxisName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintInputAxisDelegateBinding.__PropertyOffset_InputAxisName) = value;
			}
		}

		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x06007A94 RID: 31380 RVA: 0x000AF593 File Offset: 0x000AD793
		// (set) Token: 0x06007A95 RID: 31381 RVA: 0x000AF5A7 File Offset: 0x000AD7A7
		public unsafe FName FunctionNameToBind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlueprintInputAxisDelegateBinding.__PropertyOffset_FunctionNameToBind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintInputAxisDelegateBinding.__PropertyOffset_FunctionNameToBind) = value;
			}
		}

		// Token: 0x06007A96 RID: 31382 RVA: 0x000AF5BC File Offset: 0x000AD7BC
		public FBlueprintInputAxisDelegateBinding()
		{
		}

		// Token: 0x06007A97 RID: 31383 RVA: 0x000AF5C4 File Offset: 0x000AD7C4
		public FBlueprintInputAxisDelegateBinding(FName InputAxisName, FName FunctionNameToBind, bool bConsumeInput, bool bExecuteWhenPaused, bool bOverrideParentBinding)
		{
			this.InputAxisName = InputAxisName;
			this.FunctionNameToBind = FunctionNameToBind;
			base.bConsumeInput = bConsumeInput;
			base.bExecuteWhenPaused = bExecuteWhenPaused;
			base.bOverrideParentBinding = bOverrideParentBinding;
		}

		// Token: 0x06007A98 RID: 31384 RVA: 0x000AF5F1 File Offset: 0x000AD7F1
		protected override IntPtr GetUStructPtr()
		{
			return FBlueprintInputAxisDelegateBinding.StaticStruct();
		}

		// Token: 0x06007A99 RID: 31385 RVA: 0x000AF5FD File Offset: 0x000AD7FD
		[NullableContext(2)]
		public FBlueprintInputAxisDelegateBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007A9A RID: 31386 RVA: 0x000AF607 File Offset: 0x000AD807
		public FBlueprintInputAxisDelegateBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007A9B RID: 31387 RVA: 0x000AF612 File Offset: 0x000AD812
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlueprintInputAxisDelegateBinding(Pointer, false, true);
		}

		// Token: 0x06007A9C RID: 31388 RVA: 0x000AF61C File Offset: 0x000AD81C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlueprintInputAxisDelegateBinding(Pointer, MemoryOwner);
		}

		// Token: 0x04003AF5 RID: 15093
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BlueprintInputAxisDelegateBinding";

		// Token: 0x04003AF6 RID: 15094
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003AF7 RID: 15095
		internal static int __PropertyOffset_InputAxisName;

		// Token: 0x04003AF8 RID: 15096
		internal static int __PropertyOffset_FunctionNameToBind;
	}
}
