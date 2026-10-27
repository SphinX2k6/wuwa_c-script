using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008C7 RID: 2247
	[UnrealObjectPath("/Script/Engine.BlueprintInputKeyDelegateBinding")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FBlueprintInputKeyDelegateBinding : FBlueprintInputDelegateBinding, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007AB7 RID: 31415 RVA: 0x000AF89A File Offset: 0x000ADA9A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlueprintInputKeyDelegateBinding._ScriptStructPtr != 0) ? FBlueprintInputKeyDelegateBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BlueprintInputKeyDelegateBinding", ref FBlueprintInputKeyDelegateBinding._ScriptStructPtr);
		}

		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x06007AB8 RID: 31416 RVA: 0x000AF8C0 File Offset: 0x000ADAC0
		// (set) Token: 0x06007AB9 RID: 31417 RVA: 0x000AF903 File Offset: 0x000ADB03
		[Nullable(1)]
		public FInputChord InputChord
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FInputChord result;
				if ((result = this._InputChord) == null)
				{
					result = (this._InputChord = new FInputChord(base.NativePtr + (IntPtr)FBlueprintInputKeyDelegateBinding.__PropertyOffset_InputChord, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputChord.StaticStruct(), base.NativePtr + (IntPtr)FBlueprintInputKeyDelegateBinding.__PropertyOffset_InputChord, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x06007ABA RID: 31418 RVA: 0x000AF924 File Offset: 0x000ADB24
		// (set) Token: 0x06007ABB RID: 31419 RVA: 0x000AF938 File Offset: 0x000ADB38
		public unsafe TEnumAsByte<EInputEvent> InputKeyEvent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlueprintInputKeyDelegateBinding.__PropertyOffset_InputKeyEvent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintInputKeyDelegateBinding.__PropertyOffset_InputKeyEvent) = value;
			}
		}

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x06007ABC RID: 31420 RVA: 0x000AF94D File Offset: 0x000ADB4D
		// (set) Token: 0x06007ABD RID: 31421 RVA: 0x000AF961 File Offset: 0x000ADB61
		public unsafe FName FunctionNameToBind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlueprintInputKeyDelegateBinding.__PropertyOffset_FunctionNameToBind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintInputKeyDelegateBinding.__PropertyOffset_FunctionNameToBind) = value;
			}
		}

		// Token: 0x06007ABE RID: 31422 RVA: 0x000AF976 File Offset: 0x000ADB76
		public FBlueprintInputKeyDelegateBinding()
		{
		}

		// Token: 0x06007ABF RID: 31423 RVA: 0x000AF97E File Offset: 0x000ADB7E
		public FBlueprintInputKeyDelegateBinding([Nullable(1)] FInputChord InputChord, TEnumAsByte<EInputEvent> InputKeyEvent, FName FunctionNameToBind, bool bConsumeInput, bool bExecuteWhenPaused, bool bOverrideParentBinding)
		{
			this.InputChord = InputChord;
			this.InputKeyEvent = InputKeyEvent;
			this.FunctionNameToBind = FunctionNameToBind;
			base.bConsumeInput = bConsumeInput;
			base.bExecuteWhenPaused = bExecuteWhenPaused;
			base.bOverrideParentBinding = bOverrideParentBinding;
		}

		// Token: 0x06007AC0 RID: 31424 RVA: 0x000AF9B3 File Offset: 0x000ADBB3
		protected override IntPtr GetUStructPtr()
		{
			return FBlueprintInputKeyDelegateBinding.StaticStruct();
		}

		// Token: 0x06007AC1 RID: 31425 RVA: 0x000AF9BF File Offset: 0x000ADBBF
		[NullableContext(2)]
		public FBlueprintInputKeyDelegateBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007AC2 RID: 31426 RVA: 0x000AF9C9 File Offset: 0x000ADBC9
		public FBlueprintInputKeyDelegateBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007AC3 RID: 31427 RVA: 0x000AF9D4 File Offset: 0x000ADBD4
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlueprintInputKeyDelegateBinding(Pointer, false, true);
		}

		// Token: 0x06007AC4 RID: 31428 RVA: 0x000AF9DE File Offset: 0x000ADBDE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlueprintInputKeyDelegateBinding(Pointer, MemoryOwner);
		}

		// Token: 0x04003B06 RID: 15110
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BlueprintInputKeyDelegateBinding";

		// Token: 0x04003B07 RID: 15111
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003B08 RID: 15112
		internal static int __PropertyOffset_InputChord;

		// Token: 0x04003B09 RID: 15113
		[Nullable(2)]
		private FInputChord _InputChord;

		// Token: 0x04003B0A RID: 15114
		internal static int __PropertyOffset_InputKeyEvent;

		// Token: 0x04003B0B RID: 15115
		internal static int __PropertyOffset_FunctionNameToBind;
	}
}
