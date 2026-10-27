using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008C6 RID: 2246
	[UnrealObjectPath("/Script/Engine.BlueprintInputDelegateBinding")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FBlueprintInputDelegateBinding : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007AA9 RID: 31401 RVA: 0x000AF742 File Offset: 0x000AD942
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlueprintInputDelegateBinding._ScriptStructPtr != 0) ? FBlueprintInputDelegateBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BlueprintInputDelegateBinding", ref FBlueprintInputDelegateBinding._ScriptStructPtr);
		}

		// Token: 0x17001CFC RID: 7420
		// (get) Token: 0x06007AAA RID: 31402 RVA: 0x000AF766 File Offset: 0x000AD966
		// (set) Token: 0x06007AAB RID: 31403 RVA: 0x000AF77F File Offset: 0x000AD97F
		public unsafe bool bConsumeInput
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBlueprintInputDelegateBinding.__PropertyOffset_bConsumeInput) & FBlueprintInputDelegateBinding.__PropertyMask_bConsumeInput) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBlueprintInputDelegateBinding.__PropertyOffset_bConsumeInput) = ((*(base.NativePtr + (IntPtr)FBlueprintInputDelegateBinding.__PropertyOffset_bConsumeInput) & ~FBlueprintInputDelegateBinding.__PropertyMask_bConsumeInput) | (value ? FBlueprintInputDelegateBinding.__PropertyMask_bConsumeInput : 0));
			}
		}

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x06007AAC RID: 31404 RVA: 0x000AF7AF File Offset: 0x000AD9AF
		// (set) Token: 0x06007AAD RID: 31405 RVA: 0x000AF7C8 File Offset: 0x000AD9C8
		public unsafe bool bExecuteWhenPaused
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBlueprintInputDelegateBinding.__PropertyOffset_bExecuteWhenPaused) & FBlueprintInputDelegateBinding.__PropertyMask_bExecuteWhenPaused) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBlueprintInputDelegateBinding.__PropertyOffset_bExecuteWhenPaused) = ((*(base.NativePtr + (IntPtr)FBlueprintInputDelegateBinding.__PropertyOffset_bExecuteWhenPaused) & ~FBlueprintInputDelegateBinding.__PropertyMask_bExecuteWhenPaused) | (value ? FBlueprintInputDelegateBinding.__PropertyMask_bExecuteWhenPaused : 0));
			}
		}

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x06007AAE RID: 31406 RVA: 0x000AF7F8 File Offset: 0x000AD9F8
		// (set) Token: 0x06007AAF RID: 31407 RVA: 0x000AF811 File Offset: 0x000ADA11
		public unsafe bool bOverrideParentBinding
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBlueprintInputDelegateBinding.__PropertyOffset_bOverrideParentBinding) & FBlueprintInputDelegateBinding.__PropertyMask_bOverrideParentBinding) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBlueprintInputDelegateBinding.__PropertyOffset_bOverrideParentBinding) = ((*(base.NativePtr + (IntPtr)FBlueprintInputDelegateBinding.__PropertyOffset_bOverrideParentBinding) & ~FBlueprintInputDelegateBinding.__PropertyMask_bOverrideParentBinding) | (value ? FBlueprintInputDelegateBinding.__PropertyMask_bOverrideParentBinding : 0));
			}
		}

		// Token: 0x06007AB0 RID: 31408 RVA: 0x000AF841 File Offset: 0x000ADA41
		public FBlueprintInputDelegateBinding()
		{
		}

		// Token: 0x06007AB1 RID: 31409 RVA: 0x000AF849 File Offset: 0x000ADA49
		public FBlueprintInputDelegateBinding(bool bConsumeInput, bool bExecuteWhenPaused, bool bOverrideParentBinding)
		{
			this.bConsumeInput = bConsumeInput;
			this.bExecuteWhenPaused = bExecuteWhenPaused;
			this.bOverrideParentBinding = bOverrideParentBinding;
		}

		// Token: 0x06007AB2 RID: 31410 RVA: 0x000AF866 File Offset: 0x000ADA66
		protected override IntPtr GetUStructPtr()
		{
			return FBlueprintInputDelegateBinding.StaticStruct();
		}

		// Token: 0x06007AB3 RID: 31411 RVA: 0x000AF872 File Offset: 0x000ADA72
		[NullableContext(2)]
		public FBlueprintInputDelegateBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007AB4 RID: 31412 RVA: 0x000AF87C File Offset: 0x000ADA7C
		public FBlueprintInputDelegateBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007AB5 RID: 31413 RVA: 0x000AF887 File Offset: 0x000ADA87
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlueprintInputDelegateBinding(Pointer, false, true);
		}

		// Token: 0x06007AB6 RID: 31414 RVA: 0x000AF891 File Offset: 0x000ADA91
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlueprintInputDelegateBinding(Pointer, MemoryOwner);
		}

		// Token: 0x04003AFE RID: 15102
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BlueprintInputDelegateBinding";

		// Token: 0x04003AFF RID: 15103
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003B00 RID: 15104
		internal static int __PropertyOffset_bConsumeInput;

		// Token: 0x04003B01 RID: 15105
		internal static byte __PropertyMask_bConsumeInput;

		// Token: 0x04003B02 RID: 15106
		internal static int __PropertyOffset_bExecuteWhenPaused;

		// Token: 0x04003B03 RID: 15107
		internal static byte __PropertyMask_bExecuteWhenPaused;

		// Token: 0x04003B04 RID: 15108
		internal static int __PropertyOffset_bOverrideParentBinding;

		// Token: 0x04003B05 RID: 15109
		internal static byte __PropertyMask_bOverrideParentBinding;
	}
}
