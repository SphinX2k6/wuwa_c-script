using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F1A RID: 7962
	[UnrealObjectPath("/Script/KuroUtility.XboxRecentPlayerUpdate")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FXboxRecentPlayerUpdate : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E368 RID: 123752 RVA: 0x002CE9B0 File Offset: 0x002CCBB0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxRecentPlayerUpdate._ScriptStructPtr != 0) ? FXboxRecentPlayerUpdate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxRecentPlayerUpdate", ref FXboxRecentPlayerUpdate._ScriptStructPtr);
		}

		// Token: 0x170077FF RID: 30719
		// (get) Token: 0x0601E369 RID: 123753 RVA: 0x002CE9D4 File Offset: 0x002CCBD4
		// (set) Token: 0x0601E36A RID: 123754 RVA: 0x002CE9E4 File Offset: 0x002CCBE4
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

		// Token: 0x17007800 RID: 30720
		// (get) Token: 0x0601E36B RID: 123755 RVA: 0x002CE9F5 File Offset: 0x002CCBF5
		// (set) Token: 0x0601E36C RID: 123756 RVA: 0x002CEA05 File Offset: 0x002CCC05
		public unsafe EXboxMultiplayerActivityEncounterType EncounterType
		{
			get
			{
				return (EXboxMultiplayerActivityEncounterType)(*(base.NativePtr + (IntPtr)FXboxRecentPlayerUpdate.__PropertyOffset_EncounterType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxRecentPlayerUpdate.__PropertyOffset_EncounterType) = (byte)value;
			}
		}

		// Token: 0x0601E36D RID: 123757 RVA: 0x002CEA16 File Offset: 0x002CCC16
		public FXboxRecentPlayerUpdate()
		{
		}

		// Token: 0x0601E36E RID: 123758 RVA: 0x002CEA1E File Offset: 0x002CCC1E
		public FXboxRecentPlayerUpdate(long Xuid, EXboxMultiplayerActivityEncounterType EncounterType)
		{
			this.Xuid = Xuid;
			this.EncounterType = EncounterType;
		}

		// Token: 0x0601E36F RID: 123759 RVA: 0x002CEA34 File Offset: 0x002CCC34
		protected override IntPtr GetUStructPtr()
		{
			return FXboxRecentPlayerUpdate.StaticStruct();
		}

		// Token: 0x0601E370 RID: 123760 RVA: 0x002CEA40 File Offset: 0x002CCC40
		[NullableContext(2)]
		public FXboxRecentPlayerUpdate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E371 RID: 123761 RVA: 0x002CEA4A File Offset: 0x002CCC4A
		public FXboxRecentPlayerUpdate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E372 RID: 123762 RVA: 0x002CEA55 File Offset: 0x002CCC55
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxRecentPlayerUpdate(Pointer, false, true);
		}

		// Token: 0x0601E373 RID: 123763 RVA: 0x002CEA5F File Offset: 0x002CCC5F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxRecentPlayerUpdate(Pointer, MemoryOwner);
		}

		// Token: 0x040104E4 RID: 66788
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.XboxRecentPlayerUpdate";

		// Token: 0x040104E5 RID: 66789
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040104E6 RID: 66790
		internal static int __PropertyOffset_Xuid;

		// Token: 0x040104E7 RID: 66791
		internal static int __PropertyOffset_EncounterType;
	}
}
