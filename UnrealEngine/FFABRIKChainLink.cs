using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002C0 RID: 704
	[UnrealObjectPath("/Script/AnimationCore.FABRIKChainLink")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FFABRIKChainLink : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002718 RID: 10008 RVA: 0x0003AB40 File Offset: 0x00038D40
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFABRIKChainLink._ScriptStructPtr != 0) ? FFABRIKChainLink._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimationCore.FABRIKChainLink", ref FFABRIKChainLink._ScriptStructPtr);
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x0003AB64 File Offset: 0x00038D64
		public FFABRIKChainLink()
		{
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x0003AB6C File Offset: 0x00038D6C
		protected override IntPtr GetUStructPtr()
		{
			return FFABRIKChainLink.StaticStruct();
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x0003AB78 File Offset: 0x00038D78
		[NullableContext(2)]
		public FFABRIKChainLink(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x0003AB82 File Offset: 0x00038D82
		public FFABRIKChainLink(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x0003AB8D File Offset: 0x00038D8D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFABRIKChainLink(Pointer, false, true);
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x0003AB97 File Offset: 0x00038D97
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFABRIKChainLink(Pointer, MemoryOwner);
		}

		// Token: 0x04000F68 RID: 3944
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimationCore.FABRIKChainLink";

		// Token: 0x04000F69 RID: 3945
		private static IntPtr _ScriptStructPtr;
	}
}
