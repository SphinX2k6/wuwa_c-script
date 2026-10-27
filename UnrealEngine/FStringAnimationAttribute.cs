using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011B0 RID: 4528
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StringAnimationAttribute")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FStringAnimationAttribute : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010B33 RID: 68403 RVA: 0x001885E2 File Offset: 0x001867E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStringAnimationAttribute._ScriptStructPtr != 0) ? FStringAnimationAttribute._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StringAnimationAttribute", ref FStringAnimationAttribute._ScriptStructPtr);
		}

		// Token: 0x1700413D RID: 16701
		// (get) Token: 0x06010B34 RID: 68404 RVA: 0x00188606 File Offset: 0x00186806
		// (set) Token: 0x06010B35 RID: 68405 RVA: 0x0018861A File Offset: 0x0018681A
		public unsafe string Value
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FStringAnimationAttribute.__PropertyOffset_Value)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FStringAnimationAttribute.__PropertyOffset_Value)), value);
			}
		}

		// Token: 0x06010B36 RID: 68406 RVA: 0x0018862F File Offset: 0x0018682F
		public FStringAnimationAttribute()
		{
		}

		// Token: 0x06010B37 RID: 68407 RVA: 0x00188637 File Offset: 0x00186837
		public FStringAnimationAttribute(string Value)
		{
			this.Value = Value;
		}

		// Token: 0x06010B38 RID: 68408 RVA: 0x00188646 File Offset: 0x00186846
		protected override IntPtr GetUStructPtr()
		{
			return FStringAnimationAttribute.StaticStruct();
		}

		// Token: 0x06010B39 RID: 68409 RVA: 0x00188652 File Offset: 0x00186852
		[NullableContext(2)]
		public FStringAnimationAttribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010B3A RID: 68410 RVA: 0x0018865C File Offset: 0x0018685C
		public FStringAnimationAttribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010B3B RID: 68411 RVA: 0x00188667 File Offset: 0x00186867
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStringAnimationAttribute(Pointer, false, true);
		}

		// Token: 0x06010B3C RID: 68412 RVA: 0x00188671 File Offset: 0x00186871
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStringAnimationAttribute(Pointer, MemoryOwner);
		}

		// Token: 0x04008EE5 RID: 36581
		public const string __ObjectPath = "/Script/Engine.StringAnimationAttribute";

		// Token: 0x04008EE6 RID: 36582
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008EE7 RID: 36583
		internal static int __PropertyOffset_Value;
	}
}
