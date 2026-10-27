using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BF5 RID: 3061
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.FunctionExpressionInput")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FFunctionExpressionInput : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009709 RID: 38665 RVA: 0x000D7672 File Offset: 0x000D5872
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFunctionExpressionInput._ScriptStructPtr != 0) ? FFunctionExpressionInput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FunctionExpressionInput", ref FFunctionExpressionInput._ScriptStructPtr);
		}

		// Token: 0x1700243A RID: 9274
		// (get) Token: 0x0600970A RID: 38666 RVA: 0x000D7696 File Offset: 0x000D5896
		// (set) Token: 0x0600970B RID: 38667 RVA: 0x000D76AA File Offset: 0x000D58AA
		[Nullable(2)]
		public unsafe UMaterialExpressionFunctionInput ExpressionInput
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialExpressionFunctionInput>(base.NativePtr / (IntPtr)sizeof(void*) + FFunctionExpressionInput.__PropertyOffset_ExpressionInput);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FFunctionExpressionInput.__PropertyOffset_ExpressionInput, value);
			}
		}

		// Token: 0x1700243B RID: 9275
		// (get) Token: 0x0600970C RID: 38668 RVA: 0x000D76BF File Offset: 0x000D58BF
		// (set) Token: 0x0600970D RID: 38669 RVA: 0x000D76D3 File Offset: 0x000D58D3
		public unsafe FGuid ExpressionInputId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFunctionExpressionInput.__PropertyOffset_ExpressionInputId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFunctionExpressionInput.__PropertyOffset_ExpressionInputId) = value;
			}
		}

		// Token: 0x1700243C RID: 9276
		// (get) Token: 0x0600970E RID: 38670 RVA: 0x000D76E8 File Offset: 0x000D58E8
		// (set) Token: 0x0600970F RID: 38671 RVA: 0x000D772B File Offset: 0x000D592B
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)FFunctionExpressionInput.__PropertyOffset_Input, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)FFunctionExpressionInput.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06009710 RID: 38672 RVA: 0x000D774C File Offset: 0x000D594C
		public FFunctionExpressionInput()
		{
		}

		// Token: 0x06009711 RID: 38673 RVA: 0x000D7754 File Offset: 0x000D5954
		public FFunctionExpressionInput(UMaterialExpressionFunctionInput ExpressionInput, FGuid ExpressionInputId, FExpressionInput Input)
		{
			this.ExpressionInput = ExpressionInput;
			this.ExpressionInputId = ExpressionInputId;
			this.Input = Input;
		}

		// Token: 0x06009712 RID: 38674 RVA: 0x000D7771 File Offset: 0x000D5971
		protected override IntPtr GetUStructPtr()
		{
			return FFunctionExpressionInput.StaticStruct();
		}

		// Token: 0x06009713 RID: 38675 RVA: 0x000D777D File Offset: 0x000D597D
		[NullableContext(2)]
		public FFunctionExpressionInput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009714 RID: 38676 RVA: 0x000D7787 File Offset: 0x000D5987
		public FFunctionExpressionInput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009715 RID: 38677 RVA: 0x000D7792 File Offset: 0x000D5992
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFunctionExpressionInput(Pointer, false, true);
		}

		// Token: 0x06009716 RID: 38678 RVA: 0x000D779C File Offset: 0x000D599C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFunctionExpressionInput(Pointer, MemoryOwner);
		}

		// Token: 0x040054B0 RID: 21680
		public const string __ObjectPath = "/Script/Engine.FunctionExpressionInput";

		// Token: 0x040054B1 RID: 21681
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040054B2 RID: 21682
		internal static int __PropertyOffset_ExpressionInput;

		// Token: 0x040054B3 RID: 21683
		internal static int __PropertyOffset_ExpressionInputId;

		// Token: 0x040054B4 RID: 21684
		internal static int __PropertyOffset_Input;

		// Token: 0x040054B5 RID: 21685
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
