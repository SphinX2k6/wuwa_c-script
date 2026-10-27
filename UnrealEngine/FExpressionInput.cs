using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BCD RID: 3021
	[UnrealObjectPath("/Script/Engine.ExpressionInput")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FExpressionInput : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009484 RID: 38020 RVA: 0x000D401C File Offset: 0x000D221C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FExpressionInput._ScriptStructPtr != 0) ? FExpressionInput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ExpressionInput", ref FExpressionInput._ScriptStructPtr);
		}

		// Token: 0x17002390 RID: 9104
		// (get) Token: 0x06009485 RID: 38021 RVA: 0x000D4040 File Offset: 0x000D2240
		// (set) Token: 0x06009486 RID: 38022 RVA: 0x000D4050 File Offset: 0x000D2250
		public unsafe int OutputIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExpressionInput.__PropertyOffset_OutputIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExpressionInput.__PropertyOffset_OutputIndex) = value;
			}
		}

		// Token: 0x17002391 RID: 9105
		// (get) Token: 0x06009487 RID: 38023 RVA: 0x000D4061 File Offset: 0x000D2261
		// (set) Token: 0x06009488 RID: 38024 RVA: 0x000D4075 File Offset: 0x000D2275
		public unsafe FName ExpressionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExpressionInput.__PropertyOffset_ExpressionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExpressionInput.__PropertyOffset_ExpressionName) = value;
			}
		}

		// Token: 0x06009489 RID: 38025 RVA: 0x000D408A File Offset: 0x000D228A
		public FExpressionInput()
		{
		}

		// Token: 0x0600948A RID: 38026 RVA: 0x000D4092 File Offset: 0x000D2292
		[NullableContext(1)]
		public FExpressionInput(UMaterialExpression Expression, int OutputIndex, FName InputName, int Mask, int MaskR, int MaskG, int MaskB, int MaskA, FName ExpressionName)
		{
			this.OutputIndex = OutputIndex;
			this.ExpressionName = ExpressionName;
		}

		// Token: 0x0600948B RID: 38027 RVA: 0x000D40A9 File Offset: 0x000D22A9
		protected override IntPtr GetUStructPtr()
		{
			return FExpressionInput.StaticStruct();
		}

		// Token: 0x0600948C RID: 38028 RVA: 0x000D40B5 File Offset: 0x000D22B5
		[NullableContext(2)]
		public FExpressionInput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600948D RID: 38029 RVA: 0x000D40BF File Offset: 0x000D22BF
		public FExpressionInput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600948E RID: 38030 RVA: 0x000D40CA File Offset: 0x000D22CA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FExpressionInput(Pointer, false, true);
		}

		// Token: 0x0600948F RID: 38031 RVA: 0x000D40D4 File Offset: 0x000D22D4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FExpressionInput(Pointer, MemoryOwner);
		}

		// Token: 0x04005372 RID: 21362
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ExpressionInput";

		// Token: 0x04005373 RID: 21363
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005374 RID: 21364
		internal static int __PropertyOffset_OutputIndex;

		// Token: 0x04005375 RID: 21365
		internal static int __PropertyOffset_ExpressionName;
	}
}
