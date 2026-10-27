using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001015 RID: 4117
	[UnrealObjectPath("/Script/Engine.PointerToUberGraphFrame")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPointerToUberGraphFrame : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E113 RID: 57619 RVA: 0x0014AF0D File Offset: 0x0014910D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPointerToUberGraphFrame._ScriptStructPtr != 0) ? FPointerToUberGraphFrame._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PointerToUberGraphFrame", ref FPointerToUberGraphFrame._ScriptStructPtr);
		}

		// Token: 0x0600E114 RID: 57620 RVA: 0x0014AF31 File Offset: 0x00149131
		public FPointerToUberGraphFrame()
		{
		}

		// Token: 0x0600E115 RID: 57621 RVA: 0x0014AF39 File Offset: 0x00149139
		protected override IntPtr GetUStructPtr()
		{
			return FPointerToUberGraphFrame.StaticStruct();
		}

		// Token: 0x0600E116 RID: 57622 RVA: 0x0014AF45 File Offset: 0x00149145
		[NullableContext(2)]
		public FPointerToUberGraphFrame(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E117 RID: 57623 RVA: 0x0014AF4F File Offset: 0x0014914F
		public FPointerToUberGraphFrame(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E118 RID: 57624 RVA: 0x0014AF5A File Offset: 0x0014915A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPointerToUberGraphFrame(Pointer, false, true);
		}

		// Token: 0x0600E119 RID: 57625 RVA: 0x0014AF64 File Offset: 0x00149164
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPointerToUberGraphFrame(Pointer, MemoryOwner);
		}

		// Token: 0x040078E4 RID: 30948
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PointerToUberGraphFrame";

		// Token: 0x040078E5 RID: 30949
		private static IntPtr _ScriptStructPtr;
	}
}
