using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000815 RID: 2069
	[UnrealObjectPath("/Script/Engine.AnimNode_Base")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAnimNode_Base : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006F4F RID: 28495 RVA: 0x0009FBDD File Offset: 0x0009DDDD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_Base._ScriptStructPtr != 0) ? FAnimNode_Base._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNode_Base", ref FAnimNode_Base._ScriptStructPtr);
		}

		// Token: 0x06006F50 RID: 28496 RVA: 0x0009FC01 File Offset: 0x0009DE01
		public FAnimNode_Base()
		{
		}

		// Token: 0x06006F51 RID: 28497 RVA: 0x0009FC09 File Offset: 0x0009DE09
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_Base.StaticStruct();
		}

		// Token: 0x06006F52 RID: 28498 RVA: 0x0009FC15 File Offset: 0x0009DE15
		[NullableContext(2)]
		public FAnimNode_Base(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006F53 RID: 28499 RVA: 0x0009FC1F File Offset: 0x0009DE1F
		public FAnimNode_Base(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006F54 RID: 28500 RVA: 0x0009FC2A File Offset: 0x0009DE2A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_Base(Pointer, false, true);
		}

		// Token: 0x06006F55 RID: 28501 RVA: 0x0009FC34 File Offset: 0x0009DE34
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_Base(Pointer, MemoryOwner);
		}

		// Token: 0x04003581 RID: 13697
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimNode_Base";

		// Token: 0x04003582 RID: 13698
		private static IntPtr _ScriptStructPtr;
	}
}
