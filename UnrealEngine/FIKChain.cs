using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000330 RID: 816
	[UnrealObjectPath("/Script/AnimGraphRuntime.IKChain")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FIKChain : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002D6C RID: 11628 RVA: 0x00045B01 File Offset: 0x00043D01
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIKChain._ScriptStructPtr != 0) ? FIKChain._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.IKChain", ref FIKChain._ScriptStructPtr);
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x00045B25 File Offset: 0x00043D25
		public FIKChain()
		{
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x00045B2D File Offset: 0x00043D2D
		protected override IntPtr GetUStructPtr()
		{
			return FIKChain.StaticStruct();
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x00045B39 File Offset: 0x00043D39
		[NullableContext(2)]
		public FIKChain(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x00045B43 File Offset: 0x00043D43
		public FIKChain(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x00045B4E File Offset: 0x00043D4E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIKChain(Pointer, false, true);
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x00045B58 File Offset: 0x00043D58
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIKChain(Pointer, MemoryOwner);
		}

		// Token: 0x04001376 RID: 4982
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimGraphRuntime.IKChain";

		// Token: 0x04001377 RID: 4983
		private static IntPtr _ScriptStructPtr;
	}
}
