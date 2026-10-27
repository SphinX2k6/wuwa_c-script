using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000331 RID: 817
	[UnrealObjectPath("/Script/AnimGraphRuntime.IKChainLink")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FIKChainLink : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002D73 RID: 11635 RVA: 0x00045B61 File Offset: 0x00043D61
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIKChainLink._ScriptStructPtr != 0) ? FIKChainLink._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.IKChainLink", ref FIKChainLink._ScriptStructPtr);
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x00045B85 File Offset: 0x00043D85
		public FIKChainLink()
		{
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x00045B8D File Offset: 0x00043D8D
		protected override IntPtr GetUStructPtr()
		{
			return FIKChainLink.StaticStruct();
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x00045B99 File Offset: 0x00043D99
		[NullableContext(2)]
		public FIKChainLink(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x00045BA3 File Offset: 0x00043DA3
		public FIKChainLink(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x00045BAE File Offset: 0x00043DAE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIKChainLink(Pointer, false, true);
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x00045BB8 File Offset: 0x00043DB8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIKChainLink(Pointer, MemoryOwner);
		}

		// Token: 0x04001378 RID: 4984
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimGraphRuntime.IKChainLink";

		// Token: 0x04001379 RID: 4985
		private static IntPtr _ScriptStructPtr;
	}
}
