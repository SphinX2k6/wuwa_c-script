using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020029DA RID: 10714
	[UnrealObjectPath("/Script/UMG.SlateChildSize")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FSlateChildSize : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027A50 RID: 162384 RVA: 0x003C7584 File Offset: 0x003C5784
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSlateChildSize._ScriptStructPtr != 0) ? FSlateChildSize._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.SlateChildSize", ref FSlateChildSize._ScriptStructPtr);
		}

		// Token: 0x170097DD RID: 38877
		// (get) Token: 0x06027A51 RID: 162385 RVA: 0x003C75A8 File Offset: 0x003C57A8
		// (set) Token: 0x06027A52 RID: 162386 RVA: 0x003C75B8 File Offset: 0x003C57B8
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateChildSize.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateChildSize.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170097DE RID: 38878
		// (get) Token: 0x06027A53 RID: 162387 RVA: 0x003C75C9 File Offset: 0x003C57C9
		// (set) Token: 0x06027A54 RID: 162388 RVA: 0x003C75DD File Offset: 0x003C57DD
		public unsafe TEnumAsByte<ESlateSizeRule> SizeRule
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateChildSize.__PropertyOffset_SizeRule);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateChildSize.__PropertyOffset_SizeRule) = value;
			}
		}

		// Token: 0x06027A55 RID: 162389 RVA: 0x003C75F2 File Offset: 0x003C57F2
		public FSlateChildSize()
		{
		}

		// Token: 0x06027A56 RID: 162390 RVA: 0x003C75FA File Offset: 0x003C57FA
		public FSlateChildSize(float Value, TEnumAsByte<ESlateSizeRule> SizeRule)
		{
			this.Value = Value;
			this.SizeRule = SizeRule;
		}

		// Token: 0x06027A57 RID: 162391 RVA: 0x003C7610 File Offset: 0x003C5810
		protected override IntPtr GetUStructPtr()
		{
			return FSlateChildSize.StaticStruct();
		}

		// Token: 0x06027A58 RID: 162392 RVA: 0x003C761C File Offset: 0x003C581C
		[NullableContext(2)]
		public FSlateChildSize(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027A59 RID: 162393 RVA: 0x003C7626 File Offset: 0x003C5826
		public FSlateChildSize(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027A5A RID: 162394 RVA: 0x003C7631 File Offset: 0x003C5831
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSlateChildSize(Pointer, false, true);
		}

		// Token: 0x06027A5B RID: 162395 RVA: 0x003C763B File Offset: 0x003C583B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSlateChildSize(Pointer, MemoryOwner);
		}

		// Token: 0x04015B73 RID: 88947
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.SlateChildSize";

		// Token: 0x04015B74 RID: 88948
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015B75 RID: 88949
		internal static int __PropertyOffset_Value;

		// Token: 0x04015B76 RID: 88950
		internal static int __PropertyOffset_SizeRule;
	}
}
