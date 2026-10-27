using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008C3 RID: 2243
	[UnrealObjectPath("/Script/Engine.BlueprintInputActionDelegateBinding")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FBlueprintInputActionDelegateBinding : FBlueprintInputDelegateBinding, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007A83 RID: 31363 RVA: 0x000AF436 File Offset: 0x000AD636
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlueprintInputActionDelegateBinding._ScriptStructPtr != 0) ? FBlueprintInputActionDelegateBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BlueprintInputActionDelegateBinding", ref FBlueprintInputActionDelegateBinding._ScriptStructPtr);
		}

		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x06007A84 RID: 31364 RVA: 0x000AF45A File Offset: 0x000AD65A
		// (set) Token: 0x06007A85 RID: 31365 RVA: 0x000AF46E File Offset: 0x000AD66E
		public unsafe FName InputActionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlueprintInputActionDelegateBinding.__PropertyOffset_InputActionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintInputActionDelegateBinding.__PropertyOffset_InputActionName) = value;
			}
		}

		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x06007A86 RID: 31366 RVA: 0x000AF483 File Offset: 0x000AD683
		// (set) Token: 0x06007A87 RID: 31367 RVA: 0x000AF497 File Offset: 0x000AD697
		public unsafe TEnumAsByte<EInputEvent> InputKeyEvent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlueprintInputActionDelegateBinding.__PropertyOffset_InputKeyEvent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintInputActionDelegateBinding.__PropertyOffset_InputKeyEvent) = value;
			}
		}

		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x06007A88 RID: 31368 RVA: 0x000AF4AC File Offset: 0x000AD6AC
		// (set) Token: 0x06007A89 RID: 31369 RVA: 0x000AF4C0 File Offset: 0x000AD6C0
		public unsafe FName FunctionNameToBind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlueprintInputActionDelegateBinding.__PropertyOffset_FunctionNameToBind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintInputActionDelegateBinding.__PropertyOffset_FunctionNameToBind) = value;
			}
		}

		// Token: 0x06007A8A RID: 31370 RVA: 0x000AF4D5 File Offset: 0x000AD6D5
		public FBlueprintInputActionDelegateBinding()
		{
		}

		// Token: 0x06007A8B RID: 31371 RVA: 0x000AF4DD File Offset: 0x000AD6DD
		public FBlueprintInputActionDelegateBinding(FName InputActionName, TEnumAsByte<EInputEvent> InputKeyEvent, FName FunctionNameToBind, bool bConsumeInput, bool bExecuteWhenPaused, bool bOverrideParentBinding)
		{
			this.InputActionName = InputActionName;
			this.InputKeyEvent = InputKeyEvent;
			this.FunctionNameToBind = FunctionNameToBind;
			base.bConsumeInput = bConsumeInput;
			base.bExecuteWhenPaused = bExecuteWhenPaused;
			base.bOverrideParentBinding = bOverrideParentBinding;
		}

		// Token: 0x06007A8C RID: 31372 RVA: 0x000AF512 File Offset: 0x000AD712
		protected override IntPtr GetUStructPtr()
		{
			return FBlueprintInputActionDelegateBinding.StaticStruct();
		}

		// Token: 0x06007A8D RID: 31373 RVA: 0x000AF51E File Offset: 0x000AD71E
		[NullableContext(2)]
		public FBlueprintInputActionDelegateBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007A8E RID: 31374 RVA: 0x000AF528 File Offset: 0x000AD728
		public FBlueprintInputActionDelegateBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007A8F RID: 31375 RVA: 0x000AF533 File Offset: 0x000AD733
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlueprintInputActionDelegateBinding(Pointer, false, true);
		}

		// Token: 0x06007A90 RID: 31376 RVA: 0x000AF53D File Offset: 0x000AD73D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlueprintInputActionDelegateBinding(Pointer, MemoryOwner);
		}

		// Token: 0x04003AF0 RID: 15088
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BlueprintInputActionDelegateBinding";

		// Token: 0x04003AF1 RID: 15089
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003AF2 RID: 15090
		internal static int __PropertyOffset_InputActionName;

		// Token: 0x04003AF3 RID: 15091
		internal static int __PropertyOffset_InputKeyEvent;

		// Token: 0x04003AF4 RID: 15092
		internal static int __PropertyOffset_FunctionNameToBind;
	}
}
