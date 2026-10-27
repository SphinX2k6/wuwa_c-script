using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C49 RID: 3145
	[UnrealObjectPath("/Script/Engine.InertializationPoseDiff")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FInertializationPoseDiff : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009F88 RID: 40840 RVA: 0x000E2AEB File Offset: 0x000E0CEB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInertializationPoseDiff._ScriptStructPtr != 0) ? FInertializationPoseDiff._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InertializationPoseDiff", ref FInertializationPoseDiff._ScriptStructPtr);
		}

		// Token: 0x06009F89 RID: 40841 RVA: 0x000E2B0F File Offset: 0x000E0D0F
		public FInertializationPoseDiff()
		{
		}

		// Token: 0x06009F8A RID: 40842 RVA: 0x000E2B17 File Offset: 0x000E0D17
		protected override IntPtr GetUStructPtr()
		{
			return FInertializationPoseDiff.StaticStruct();
		}

		// Token: 0x06009F8B RID: 40843 RVA: 0x000E2B23 File Offset: 0x000E0D23
		[NullableContext(2)]
		public FInertializationPoseDiff(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009F8C RID: 40844 RVA: 0x000E2B2D File Offset: 0x000E0D2D
		public FInertializationPoseDiff(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009F8D RID: 40845 RVA: 0x000E2B38 File Offset: 0x000E0D38
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInertializationPoseDiff(Pointer, false, true);
		}

		// Token: 0x06009F8E RID: 40846 RVA: 0x000E2B42 File Offset: 0x000E0D42
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInertializationPoseDiff(Pointer, MemoryOwner);
		}

		// Token: 0x040057C7 RID: 22471
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InertializationPoseDiff";

		// Token: 0x040057C8 RID: 22472
		private static IntPtr _ScriptStructPtr;
	}
}
