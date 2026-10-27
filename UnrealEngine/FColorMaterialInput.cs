using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200094B RID: 2379
	[UnrealObjectPath("/Script/Engine.ColorMaterialInput")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FColorMaterialInput : FMaterialInput, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060086BA RID: 34490 RVA: 0x000C00A3 File Offset: 0x000BE2A3
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FColorMaterialInput._ScriptStructPtr != 0) ? FColorMaterialInput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ColorMaterialInput", ref FColorMaterialInput._ScriptStructPtr);
		}

		// Token: 0x060086BB RID: 34491 RVA: 0x000C00C7 File Offset: 0x000BE2C7
		public FColorMaterialInput()
		{
		}

		// Token: 0x060086BC RID: 34492 RVA: 0x000C00CF File Offset: 0x000BE2CF
		[NullableContext(1)]
		public FColorMaterialInput(bool UseConstant, FColor Constant, UMaterialExpression Expression, int OutputIndex, FName InputName, int Mask, int MaskR, int MaskG, int MaskB, int MaskA, FName ExpressionName)
		{
			base.OutputIndex = OutputIndex;
			base.ExpressionName = ExpressionName;
		}

		// Token: 0x060086BD RID: 34493 RVA: 0x000C00E7 File Offset: 0x000BE2E7
		protected override IntPtr GetUStructPtr()
		{
			return FColorMaterialInput.StaticStruct();
		}

		// Token: 0x060086BE RID: 34494 RVA: 0x000C00F3 File Offset: 0x000BE2F3
		[NullableContext(2)]
		public FColorMaterialInput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060086BF RID: 34495 RVA: 0x000C00FD File Offset: 0x000BE2FD
		public FColorMaterialInput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060086C0 RID: 34496 RVA: 0x000C0108 File Offset: 0x000BE308
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FColorMaterialInput(Pointer, false, true);
		}

		// Token: 0x060086C1 RID: 34497 RVA: 0x000C0112 File Offset: 0x000BE312
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FColorMaterialInput(Pointer, MemoryOwner);
		}

		// Token: 0x04004019 RID: 16409
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ColorMaterialInput";

		// Token: 0x0400401A RID: 16410
		private static IntPtr _ScriptStructPtr;
	}
}
