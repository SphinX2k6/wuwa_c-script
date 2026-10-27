using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010E5 RID: 4325
	[UnrealObjectPath("/Script/Engine.ShadingModelMaterialInput")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FShadingModelMaterialInput : FMaterialInput, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F84C RID: 63564 RVA: 0x0016F40F File Offset: 0x0016D60F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FShadingModelMaterialInput._ScriptStructPtr != 0) ? FShadingModelMaterialInput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ShadingModelMaterialInput", ref FShadingModelMaterialInput._ScriptStructPtr);
		}

		// Token: 0x0600F84D RID: 63565 RVA: 0x0016F433 File Offset: 0x0016D633
		public FShadingModelMaterialInput()
		{
		}

		// Token: 0x0600F84E RID: 63566 RVA: 0x0016F43B File Offset: 0x0016D63B
		[NullableContext(1)]
		public FShadingModelMaterialInput(UMaterialExpression Expression, int OutputIndex, FName InputName, int Mask, int MaskR, int MaskG, int MaskB, int MaskA, FName ExpressionName)
		{
			base.OutputIndex = OutputIndex;
			base.ExpressionName = ExpressionName;
		}

		// Token: 0x0600F84F RID: 63567 RVA: 0x0016F452 File Offset: 0x0016D652
		protected override IntPtr GetUStructPtr()
		{
			return FShadingModelMaterialInput.StaticStruct();
		}

		// Token: 0x0600F850 RID: 63568 RVA: 0x0016F45E File Offset: 0x0016D65E
		[NullableContext(2)]
		public FShadingModelMaterialInput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F851 RID: 63569 RVA: 0x0016F468 File Offset: 0x0016D668
		public FShadingModelMaterialInput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F852 RID: 63570 RVA: 0x0016F473 File Offset: 0x0016D673
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FShadingModelMaterialInput(Pointer, false, true);
		}

		// Token: 0x0600F853 RID: 63571 RVA: 0x0016F47D File Offset: 0x0016D67D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FShadingModelMaterialInput(Pointer, MemoryOwner);
		}

		// Token: 0x04008625 RID: 34341
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ShadingModelMaterialInput";

		// Token: 0x04008626 RID: 34342
		private static IntPtr _ScriptStructPtr;
	}
}
