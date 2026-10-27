using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200121C RID: 4636
	[UnrealObjectPath("/Script/Engine.Vector2MaterialInput")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FVector2MaterialInput : FMaterialInput, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601111B RID: 69915 RVA: 0x00190D48 File Offset: 0x0018EF48
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector2MaterialInput._ScriptStructPtr != 0) ? FVector2MaterialInput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.Vector2MaterialInput", ref FVector2MaterialInput._ScriptStructPtr);
		}

		// Token: 0x0601111C RID: 69916 RVA: 0x00190D6C File Offset: 0x0018EF6C
		public FVector2MaterialInput()
		{
		}

		// Token: 0x0601111D RID: 69917 RVA: 0x00190D74 File Offset: 0x0018EF74
		[NullableContext(1)]
		public FVector2MaterialInput(bool UseConstant, float ConstantX, float ConstantY, UMaterialExpression Expression, int OutputIndex, FName InputName, int Mask, int MaskR, int MaskG, int MaskB, int MaskA, FName ExpressionName)
		{
			base.OutputIndex = OutputIndex;
			base.ExpressionName = ExpressionName;
		}

		// Token: 0x0601111E RID: 69918 RVA: 0x00190D8C File Offset: 0x0018EF8C
		protected override IntPtr GetUStructPtr()
		{
			return FVector2MaterialInput.StaticStruct();
		}

		// Token: 0x0601111F RID: 69919 RVA: 0x00190D98 File Offset: 0x0018EF98
		[NullableContext(2)]
		public FVector2MaterialInput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011120 RID: 69920 RVA: 0x00190DA2 File Offset: 0x0018EFA2
		public FVector2MaterialInput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011121 RID: 69921 RVA: 0x00190DAD File Offset: 0x0018EFAD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVector2MaterialInput(Pointer, false, true);
		}

		// Token: 0x06011122 RID: 69922 RVA: 0x00190DB7 File Offset: 0x0018EFB7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVector2MaterialInput(Pointer, MemoryOwner);
		}

		// Token: 0x0400923B RID: 37435
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Vector2MaterialInput";

		// Token: 0x0400923C RID: 37436
		private static IntPtr _ScriptStructPtr;
	}
}
