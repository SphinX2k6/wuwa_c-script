using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000624 RID: 1572
	[UnrealObjectPath("/Script/KuroUtility.XboxRecentPlayerUpdate")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FXboxRecentPlayerUpdate : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008976 RID: 35190 RVA: 0x000CF41B File Offset: 0x000CD61B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxRecentPlayerUpdate._ScriptStructPtr != 0) ? FXboxRecentPlayerUpdate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxRecentPlayerUpdate", ref FXboxRecentPlayerUpdate._ScriptStructPtr);
		}

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x06008977 RID: 35191 RVA: 0x000CF43F File Offset: 0x000CD63F
		// (set) Token: 0x06008978 RID: 35192 RVA: 0x000CF44F File Offset: 0x000CD64F
		public unsafe long Xuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxRecentPlayerUpdate.__PropertyOffset_Xuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxRecentPlayerUpdate.__PropertyOffset_Xuid) = value;
			}
		}

		// Token: 0x06008979 RID: 35193 RVA: 0x000CF460 File Offset: 0x000CD660
		public FXboxRecentPlayerUpdate()
		{
		}

		// Token: 0x0600897A RID: 35194 RVA: 0x000CF468 File Offset: 0x000CD668
		protected override IntPtr GetUStructPtr()
		{
			return FXboxRecentPlayerUpdate.StaticStruct();
		}

		// Token: 0x0600897B RID: 35195 RVA: 0x000CF474 File Offset: 0x000CD674
		[NullableContext(2)]
		public FXboxRecentPlayerUpdate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600897C RID: 35196 RVA: 0x000CF47E File Offset: 0x000CD67E
		public FXboxRecentPlayerUpdate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600897D RID: 35197 RVA: 0x000CF489 File Offset: 0x000CD689
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxRecentPlayerUpdate(Pointer, false, true);
		}

		// Token: 0x0600897E RID: 35198 RVA: 0x000CF493 File Offset: 0x000CD693
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxRecentPlayerUpdate(Pointer, MemoryOwner);
		}

		// Token: 0x04003BA8 RID: 15272
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.XboxRecentPlayerUpdate";

		// Token: 0x04003BA9 RID: 15273
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003BAA RID: 15274
		internal static int __PropertyOffset_Xuid;
	}
}
