using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001225 RID: 4645
	[UnrealObjectPath("/Script/Engine.VectorMaterialInput")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FVectorMaterialInput : FMaterialInput, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601118B RID: 70027 RVA: 0x0019169B File Offset: 0x0018F89B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVectorMaterialInput._ScriptStructPtr != 0) ? FVectorMaterialInput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.VectorMaterialInput", ref FVectorMaterialInput._ScriptStructPtr);
		}

		// Token: 0x0601118C RID: 70028 RVA: 0x001916BF File Offset: 0x0018F8BF
		public FVectorMaterialInput()
		{
		}

		// Token: 0x0601118D RID: 70029 RVA: 0x001916C7 File Offset: 0x0018F8C7
		[NullableContext(1)]
		public FVectorMaterialInput(bool UseConstant, FVector Constant, UMaterialExpression Expression, int OutputIndex, FName InputName, int Mask, int MaskR, int MaskG, int MaskB, int MaskA, FName ExpressionName)
		{
			base.OutputIndex = OutputIndex;
			base.ExpressionName = ExpressionName;
		}

		// Token: 0x0601118E RID: 70030 RVA: 0x001916DF File Offset: 0x0018F8DF
		protected override IntPtr GetUStructPtr()
		{
			return FVectorMaterialInput.StaticStruct();
		}

		// Token: 0x0601118F RID: 70031 RVA: 0x001916EB File Offset: 0x0018F8EB
		[NullableContext(2)]
		public FVectorMaterialInput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011190 RID: 70032 RVA: 0x001916F5 File Offset: 0x0018F8F5
		public FVectorMaterialInput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011191 RID: 70033 RVA: 0x00191700 File Offset: 0x0018F900
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVectorMaterialInput(Pointer, false, true);
		}

		// Token: 0x06011192 RID: 70034 RVA: 0x0019170A File Offset: 0x0018F90A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVectorMaterialInput(Pointer, MemoryOwner);
		}

		// Token: 0x04009273 RID: 37491
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.VectorMaterialInput";

		// Token: 0x04009274 RID: 37492
		private static IntPtr _ScriptStructPtr;
	}
}
