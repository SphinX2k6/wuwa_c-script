using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008C8 RID: 2248
	[UnrealObjectPath("/Script/Engine.BlueprintInputTouchDelegateBinding")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FBlueprintInputTouchDelegateBinding : FBlueprintInputDelegateBinding, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007AC5 RID: 31429 RVA: 0x000AF9E7 File Offset: 0x000ADBE7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlueprintInputTouchDelegateBinding._ScriptStructPtr != 0) ? FBlueprintInputTouchDelegateBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BlueprintInputTouchDelegateBinding", ref FBlueprintInputTouchDelegateBinding._ScriptStructPtr);
		}

		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x06007AC6 RID: 31430 RVA: 0x000AFA0B File Offset: 0x000ADC0B
		// (set) Token: 0x06007AC7 RID: 31431 RVA: 0x000AFA1F File Offset: 0x000ADC1F
		public unsafe TEnumAsByte<EInputEvent> InputKeyEvent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlueprintInputTouchDelegateBinding.__PropertyOffset_InputKeyEvent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintInputTouchDelegateBinding.__PropertyOffset_InputKeyEvent) = value;
			}
		}

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x06007AC8 RID: 31432 RVA: 0x000AFA34 File Offset: 0x000ADC34
		// (set) Token: 0x06007AC9 RID: 31433 RVA: 0x000AFA48 File Offset: 0x000ADC48
		public unsafe FName FunctionNameToBind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlueprintInputTouchDelegateBinding.__PropertyOffset_FunctionNameToBind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintInputTouchDelegateBinding.__PropertyOffset_FunctionNameToBind) = value;
			}
		}

		// Token: 0x06007ACA RID: 31434 RVA: 0x000AFA5D File Offset: 0x000ADC5D
		public FBlueprintInputTouchDelegateBinding()
		{
		}

		// Token: 0x06007ACB RID: 31435 RVA: 0x000AFA65 File Offset: 0x000ADC65
		public FBlueprintInputTouchDelegateBinding(TEnumAsByte<EInputEvent> InputKeyEvent, FName FunctionNameToBind, bool bConsumeInput, bool bExecuteWhenPaused, bool bOverrideParentBinding)
		{
			this.InputKeyEvent = InputKeyEvent;
			this.FunctionNameToBind = FunctionNameToBind;
			base.bConsumeInput = bConsumeInput;
			base.bExecuteWhenPaused = bExecuteWhenPaused;
			base.bOverrideParentBinding = bOverrideParentBinding;
		}

		// Token: 0x06007ACC RID: 31436 RVA: 0x000AFA92 File Offset: 0x000ADC92
		protected override IntPtr GetUStructPtr()
		{
			return FBlueprintInputTouchDelegateBinding.StaticStruct();
		}

		// Token: 0x06007ACD RID: 31437 RVA: 0x000AFA9E File Offset: 0x000ADC9E
		[NullableContext(2)]
		public FBlueprintInputTouchDelegateBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007ACE RID: 31438 RVA: 0x000AFAA8 File Offset: 0x000ADCA8
		public FBlueprintInputTouchDelegateBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007ACF RID: 31439 RVA: 0x000AFAB3 File Offset: 0x000ADCB3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlueprintInputTouchDelegateBinding(Pointer, false, true);
		}

		// Token: 0x06007AD0 RID: 31440 RVA: 0x000AFABD File Offset: 0x000ADCBD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlueprintInputTouchDelegateBinding(Pointer, MemoryOwner);
		}

		// Token: 0x04003B0C RID: 15116
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BlueprintInputTouchDelegateBinding";

		// Token: 0x04003B0D RID: 15117
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003B0E RID: 15118
		internal static int __PropertyOffset_InputKeyEvent;

		// Token: 0x04003B0F RID: 15119
		internal static int __PropertyOffset_FunctionNameToBind;
	}
}
