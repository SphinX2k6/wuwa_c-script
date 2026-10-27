using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C47 RID: 3143
	[UnrealObjectPath("/Script/Engine.InertializationCurveDiff")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FInertializationCurveDiff : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009F7A RID: 40826 RVA: 0x000E2A2B File Offset: 0x000E0C2B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInertializationCurveDiff._ScriptStructPtr != 0) ? FInertializationCurveDiff._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InertializationCurveDiff", ref FInertializationCurveDiff._ScriptStructPtr);
		}

		// Token: 0x06009F7B RID: 40827 RVA: 0x000E2A4F File Offset: 0x000E0C4F
		public FInertializationCurveDiff()
		{
		}

		// Token: 0x06009F7C RID: 40828 RVA: 0x000E2A57 File Offset: 0x000E0C57
		protected override IntPtr GetUStructPtr()
		{
			return FInertializationCurveDiff.StaticStruct();
		}

		// Token: 0x06009F7D RID: 40829 RVA: 0x000E2A63 File Offset: 0x000E0C63
		[NullableContext(2)]
		public FInertializationCurveDiff(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009F7E RID: 40830 RVA: 0x000E2A6D File Offset: 0x000E0C6D
		public FInertializationCurveDiff(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009F7F RID: 40831 RVA: 0x000E2A78 File Offset: 0x000E0C78
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInertializationCurveDiff(Pointer, false, true);
		}

		// Token: 0x06009F80 RID: 40832 RVA: 0x000E2A82 File Offset: 0x000E0C82
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInertializationCurveDiff(Pointer, MemoryOwner);
		}

		// Token: 0x040057C3 RID: 22467
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InertializationCurveDiff";

		// Token: 0x040057C4 RID: 22468
		private static IntPtr _ScriptStructPtr;
	}
}
