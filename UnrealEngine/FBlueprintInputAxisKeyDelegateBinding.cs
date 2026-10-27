using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008C5 RID: 2245
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BlueprintInputAxisKeyDelegateBinding")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FBlueprintInputAxisKeyDelegateBinding : FBlueprintInputDelegateBinding, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007A9D RID: 31389 RVA: 0x000AF625 File Offset: 0x000AD825
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlueprintInputAxisKeyDelegateBinding._ScriptStructPtr != 0) ? FBlueprintInputAxisKeyDelegateBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BlueprintInputAxisKeyDelegateBinding", ref FBlueprintInputAxisKeyDelegateBinding._ScriptStructPtr);
		}

		// Token: 0x17001CFA RID: 7418
		// (get) Token: 0x06007A9E RID: 31390 RVA: 0x000AF64C File Offset: 0x000AD84C
		// (set) Token: 0x06007A9F RID: 31391 RVA: 0x000AF68F File Offset: 0x000AD88F
		public FKey AxisKey
		{
			get
			{
				base.FastCheckIsValid();
				FKey result;
				if ((result = this._AxisKey) == null)
				{
					result = (this._AxisKey = new FKey(base.NativePtr + (IntPtr)FBlueprintInputAxisKeyDelegateBinding.__PropertyOffset_AxisKey, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), base.NativePtr + (IntPtr)FBlueprintInputAxisKeyDelegateBinding.__PropertyOffset_AxisKey, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x06007AA0 RID: 31392 RVA: 0x000AF6B0 File Offset: 0x000AD8B0
		// (set) Token: 0x06007AA1 RID: 31393 RVA: 0x000AF6C4 File Offset: 0x000AD8C4
		public unsafe FName FunctionNameToBind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlueprintInputAxisKeyDelegateBinding.__PropertyOffset_FunctionNameToBind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintInputAxisKeyDelegateBinding.__PropertyOffset_FunctionNameToBind) = value;
			}
		}

		// Token: 0x06007AA2 RID: 31394 RVA: 0x000AF6D9 File Offset: 0x000AD8D9
		public FBlueprintInputAxisKeyDelegateBinding()
		{
		}

		// Token: 0x06007AA3 RID: 31395 RVA: 0x000AF6E1 File Offset: 0x000AD8E1
		public FBlueprintInputAxisKeyDelegateBinding(FKey AxisKey, FName FunctionNameToBind, bool bConsumeInput, bool bExecuteWhenPaused, bool bOverrideParentBinding)
		{
			this.AxisKey = AxisKey;
			this.FunctionNameToBind = FunctionNameToBind;
			base.bConsumeInput = bConsumeInput;
			base.bExecuteWhenPaused = bExecuteWhenPaused;
			base.bOverrideParentBinding = bOverrideParentBinding;
		}

		// Token: 0x06007AA4 RID: 31396 RVA: 0x000AF70E File Offset: 0x000AD90E
		protected override IntPtr GetUStructPtr()
		{
			return FBlueprintInputAxisKeyDelegateBinding.StaticStruct();
		}

		// Token: 0x06007AA5 RID: 31397 RVA: 0x000AF71A File Offset: 0x000AD91A
		[NullableContext(2)]
		public FBlueprintInputAxisKeyDelegateBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007AA6 RID: 31398 RVA: 0x000AF724 File Offset: 0x000AD924
		public FBlueprintInputAxisKeyDelegateBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007AA7 RID: 31399 RVA: 0x000AF72F File Offset: 0x000AD92F
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlueprintInputAxisKeyDelegateBinding(Pointer, false, true);
		}

		// Token: 0x06007AA8 RID: 31400 RVA: 0x000AF739 File Offset: 0x000AD939
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlueprintInputAxisKeyDelegateBinding(Pointer, MemoryOwner);
		}

		// Token: 0x04003AF9 RID: 15097
		public new const string __ObjectPath = "/Script/Engine.BlueprintInputAxisKeyDelegateBinding";

		// Token: 0x04003AFA RID: 15098
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003AFB RID: 15099
		internal static int __PropertyOffset_AxisKey;

		// Token: 0x04003AFC RID: 15100
		[Nullable(2)]
		private FKey _AxisKey;

		// Token: 0x04003AFD RID: 15101
		internal static int __PropertyOffset_FunctionNameToBind;
	}
}
