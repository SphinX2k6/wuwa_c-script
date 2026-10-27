using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010CC RID: 4300
	[UnrealObjectPath("/Script/Engine.ScalarMaterialInput")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FScalarMaterialInput : FMaterialInput, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F55F RID: 62815 RVA: 0x0016BAAD File Offset: 0x00169CAD
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FScalarMaterialInput._ScriptStructPtr != 0) ? FScalarMaterialInput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ScalarMaterialInput", ref FScalarMaterialInput._ScriptStructPtr);
		}

		// Token: 0x0600F560 RID: 62816 RVA: 0x0016BAD1 File Offset: 0x00169CD1
		public FScalarMaterialInput()
		{
		}

		// Token: 0x0600F561 RID: 62817 RVA: 0x0016BAD9 File Offset: 0x00169CD9
		[NullableContext(1)]
		public FScalarMaterialInput(bool UseConstant, float Constant, UMaterialExpression Expression, int OutputIndex, FName InputName, int Mask, int MaskR, int MaskG, int MaskB, int MaskA, FName ExpressionName)
		{
			base.OutputIndex = OutputIndex;
			base.ExpressionName = ExpressionName;
		}

		// Token: 0x0600F562 RID: 62818 RVA: 0x0016BAF1 File Offset: 0x00169CF1
		protected override IntPtr GetUStructPtr()
		{
			return FScalarMaterialInput.StaticStruct();
		}

		// Token: 0x0600F563 RID: 62819 RVA: 0x0016BAFD File Offset: 0x00169CFD
		[NullableContext(2)]
		public FScalarMaterialInput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F564 RID: 62820 RVA: 0x0016BB07 File Offset: 0x00169D07
		public FScalarMaterialInput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F565 RID: 62821 RVA: 0x0016BB12 File Offset: 0x00169D12
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FScalarMaterialInput(Pointer, false, true);
		}

		// Token: 0x0600F566 RID: 62822 RVA: 0x0016BB1C File Offset: 0x00169D1C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FScalarMaterialInput(Pointer, MemoryOwner);
		}

		// Token: 0x040084F3 RID: 34035
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ScalarMaterialInput";

		// Token: 0x040084F4 RID: 34036
		private static IntPtr _ScriptStructPtr;
	}
}
