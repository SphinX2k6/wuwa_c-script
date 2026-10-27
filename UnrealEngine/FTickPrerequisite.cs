using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011E8 RID: 4584
	[UnrealObjectPath("/Script/Engine.TickPrerequisite")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FTickPrerequisite : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010E1C RID: 69148 RVA: 0x0018CADD File Offset: 0x0018ACDD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTickPrerequisite._ScriptStructPtr != 0) ? FTickPrerequisite._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TickPrerequisite", ref FTickPrerequisite._ScriptStructPtr);
		}

		// Token: 0x06010E1D RID: 69149 RVA: 0x0018CB01 File Offset: 0x0018AD01
		public FTickPrerequisite()
		{
		}

		// Token: 0x06010E1E RID: 69150 RVA: 0x0018CB09 File Offset: 0x0018AD09
		protected override IntPtr GetUStructPtr()
		{
			return FTickPrerequisite.StaticStruct();
		}

		// Token: 0x06010E1F RID: 69151 RVA: 0x0018CB15 File Offset: 0x0018AD15
		[NullableContext(2)]
		public FTickPrerequisite(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010E20 RID: 69152 RVA: 0x0018CB1F File Offset: 0x0018AD1F
		public FTickPrerequisite(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010E21 RID: 69153 RVA: 0x0018CB2A File Offset: 0x0018AD2A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTickPrerequisite(Pointer, false, true);
		}

		// Token: 0x06010E22 RID: 69154 RVA: 0x0018CB34 File Offset: 0x0018AD34
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTickPrerequisite(Pointer, MemoryOwner);
		}

		// Token: 0x040090CB RID: 37067
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TickPrerequisite";

		// Token: 0x040090CC RID: 37068
		private static IntPtr _ScriptStructPtr;
	}
}
