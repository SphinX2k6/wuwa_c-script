using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EF4 RID: 3828
	[UnrealObjectPath("/Script/Engine.NonBlendableFloatAnimationAttribute")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FNonBlendableFloatAnimationAttribute : FFloatAnimationAttribute, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CF91 RID: 53137 RVA: 0x0012EC72 File Offset: 0x0012CE72
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNonBlendableFloatAnimationAttribute._ScriptStructPtr != 0) ? FNonBlendableFloatAnimationAttribute._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NonBlendableFloatAnimationAttribute", ref FNonBlendableFloatAnimationAttribute._ScriptStructPtr);
		}

		// Token: 0x0600CF92 RID: 53138 RVA: 0x0012EC96 File Offset: 0x0012CE96
		public FNonBlendableFloatAnimationAttribute()
		{
		}

		// Token: 0x0600CF93 RID: 53139 RVA: 0x0012EC9E File Offset: 0x0012CE9E
		public FNonBlendableFloatAnimationAttribute(float Value)
		{
			base.Value = Value;
		}

		// Token: 0x0600CF94 RID: 53140 RVA: 0x0012ECAD File Offset: 0x0012CEAD
		protected override IntPtr GetUStructPtr()
		{
			return FNonBlendableFloatAnimationAttribute.StaticStruct();
		}

		// Token: 0x0600CF95 RID: 53141 RVA: 0x0012ECB9 File Offset: 0x0012CEB9
		[NullableContext(2)]
		public FNonBlendableFloatAnimationAttribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CF96 RID: 53142 RVA: 0x0012ECC3 File Offset: 0x0012CEC3
		public FNonBlendableFloatAnimationAttribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CF97 RID: 53143 RVA: 0x0012ECCE File Offset: 0x0012CECE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNonBlendableFloatAnimationAttribute(Pointer, false, true);
		}

		// Token: 0x0600CF98 RID: 53144 RVA: 0x0012ECD8 File Offset: 0x0012CED8
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNonBlendableFloatAnimationAttribute(Pointer, MemoryOwner);
		}

		// Token: 0x04006FEB RID: 28651
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.NonBlendableFloatAnimationAttribute";

		// Token: 0x04006FEC RID: 28652
		private static IntPtr _ScriptStructPtr;
	}
}
