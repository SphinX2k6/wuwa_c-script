using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EF5 RID: 3829
	[UnrealObjectPath("/Script/Engine.NonBlendableIntegerAnimationAttribute")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FNonBlendableIntegerAnimationAttribute : FIntegerAnimationAttribute, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CF99 RID: 53145 RVA: 0x0012ECE1 File Offset: 0x0012CEE1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNonBlendableIntegerAnimationAttribute._ScriptStructPtr != 0) ? FNonBlendableIntegerAnimationAttribute._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NonBlendableIntegerAnimationAttribute", ref FNonBlendableIntegerAnimationAttribute._ScriptStructPtr);
		}

		// Token: 0x0600CF9A RID: 53146 RVA: 0x0012ED05 File Offset: 0x0012CF05
		public FNonBlendableIntegerAnimationAttribute()
		{
		}

		// Token: 0x0600CF9B RID: 53147 RVA: 0x0012ED0D File Offset: 0x0012CF0D
		public FNonBlendableIntegerAnimationAttribute(int Value)
		{
			base.Value = Value;
		}

		// Token: 0x0600CF9C RID: 53148 RVA: 0x0012ED1C File Offset: 0x0012CF1C
		protected override IntPtr GetUStructPtr()
		{
			return FNonBlendableIntegerAnimationAttribute.StaticStruct();
		}

		// Token: 0x0600CF9D RID: 53149 RVA: 0x0012ED28 File Offset: 0x0012CF28
		[NullableContext(2)]
		public FNonBlendableIntegerAnimationAttribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CF9E RID: 53150 RVA: 0x0012ED32 File Offset: 0x0012CF32
		public FNonBlendableIntegerAnimationAttribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CF9F RID: 53151 RVA: 0x0012ED3D File Offset: 0x0012CF3D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNonBlendableIntegerAnimationAttribute(Pointer, false, true);
		}

		// Token: 0x0600CFA0 RID: 53152 RVA: 0x0012ED47 File Offset: 0x0012CF47
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNonBlendableIntegerAnimationAttribute(Pointer, MemoryOwner);
		}

		// Token: 0x04006FED RID: 28653
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.NonBlendableIntegerAnimationAttribute";

		// Token: 0x04006FEE RID: 28654
		private static IntPtr _ScriptStructPtr;
	}
}
