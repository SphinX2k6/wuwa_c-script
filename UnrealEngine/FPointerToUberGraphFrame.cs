using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000264 RID: 612
	[UnrealObjectPath("/Script/Engine.PointerToUberGraphFrame")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPointerToUberGraphFrame : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600366B RID: 13931 RVA: 0x0004CC4B File Offset: 0x0004AE4B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPointerToUberGraphFrame._ScriptStructPtr != 0) ? FPointerToUberGraphFrame._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PointerToUberGraphFrame", ref FPointerToUberGraphFrame._ScriptStructPtr);
		}

		// Token: 0x0600366C RID: 13932 RVA: 0x0004CC6F File Offset: 0x0004AE6F
		public FPointerToUberGraphFrame()
		{
		}

		// Token: 0x0600366D RID: 13933 RVA: 0x0004CC77 File Offset: 0x0004AE77
		protected override IntPtr GetUStructPtr()
		{
			return FPointerToUberGraphFrame.StaticStruct();
		}

		// Token: 0x0600366E RID: 13934 RVA: 0x0004CC83 File Offset: 0x0004AE83
		[NullableContext(2)]
		public FPointerToUberGraphFrame(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x0004CC8D File Offset: 0x0004AE8D
		public FPointerToUberGraphFrame(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x0004CC98 File Offset: 0x0004AE98
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPointerToUberGraphFrame(Pointer, false, true);
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x0004CCA2 File Offset: 0x0004AEA2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPointerToUberGraphFrame(Pointer, MemoryOwner);
		}

		// Token: 0x040012BB RID: 4795
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PointerToUberGraphFrame";

		// Token: 0x040012BC RID: 4796
		private static IntPtr _ScriptStructPtr;
	}
}
