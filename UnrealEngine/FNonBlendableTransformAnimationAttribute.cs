using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EF6 RID: 3830
	[UnrealObjectPath("/Script/Engine.NonBlendableTransformAnimationAttribute")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FNonBlendableTransformAnimationAttribute : FTransformAnimationAttribute, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CFA1 RID: 53153 RVA: 0x0012ED50 File Offset: 0x0012CF50
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNonBlendableTransformAnimationAttribute._ScriptStructPtr != 0) ? FNonBlendableTransformAnimationAttribute._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NonBlendableTransformAnimationAttribute", ref FNonBlendableTransformAnimationAttribute._ScriptStructPtr);
		}

		// Token: 0x0600CFA2 RID: 53154 RVA: 0x0012ED74 File Offset: 0x0012CF74
		public FNonBlendableTransformAnimationAttribute()
		{
		}

		// Token: 0x0600CFA3 RID: 53155 RVA: 0x0012ED7C File Offset: 0x0012CF7C
		public FNonBlendableTransformAnimationAttribute(FTransform Value)
		{
			base.Value = Value;
		}

		// Token: 0x0600CFA4 RID: 53156 RVA: 0x0012ED8B File Offset: 0x0012CF8B
		protected override IntPtr GetUStructPtr()
		{
			return FNonBlendableTransformAnimationAttribute.StaticStruct();
		}

		// Token: 0x0600CFA5 RID: 53157 RVA: 0x0012ED97 File Offset: 0x0012CF97
		[NullableContext(2)]
		public FNonBlendableTransformAnimationAttribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CFA6 RID: 53158 RVA: 0x0012EDA1 File Offset: 0x0012CFA1
		public FNonBlendableTransformAnimationAttribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CFA7 RID: 53159 RVA: 0x0012EDAC File Offset: 0x0012CFAC
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNonBlendableTransformAnimationAttribute(Pointer, false, true);
		}

		// Token: 0x0600CFA8 RID: 53160 RVA: 0x0012EDB6 File Offset: 0x0012CFB6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNonBlendableTransformAnimationAttribute(Pointer, MemoryOwner);
		}

		// Token: 0x04006FEF RID: 28655
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.NonBlendableTransformAnimationAttribute";

		// Token: 0x04006FF0 RID: 28656
		private static IntPtr _ScriptStructPtr;
	}
}
