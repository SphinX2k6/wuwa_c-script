using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F0E RID: 7950
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.TrophyData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FTrophyData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E2A8 RID: 123560 RVA: 0x002CDA9A File Offset: 0x002CBC9A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTrophyData._ScriptStructPtr != 0) ? FTrophyData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.TrophyData", ref FTrophyData._ScriptStructPtr);
		}

		// Token: 0x170077D0 RID: 30672
		// (get) Token: 0x0601E2A9 RID: 123561 RVA: 0x002CDABE File Offset: 0x002CBCBE
		// (set) Token: 0x0601E2AA RID: 123562 RVA: 0x002CDACE File Offset: 0x002CBCCE
		public unsafe int trophyId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrophyData.__PropertyOffset_trophyId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrophyData.__PropertyOffset_trophyId) = value;
			}
		}

		// Token: 0x170077D1 RID: 30673
		// (get) Token: 0x0601E2AB RID: 123563 RVA: 0x002CDADF File Offset: 0x002CBCDF
		// (set) Token: 0x0601E2AC RID: 123564 RVA: 0x002CDAEF File Offset: 0x002CBCEF
		public unsafe bool unlocked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrophyData.__PropertyOffset_unlocked) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrophyData.__PropertyOffset_unlocked) = (value ? 1 : 0);
			}
		}

		// Token: 0x170077D2 RID: 30674
		// (get) Token: 0x0601E2AD RID: 123565 RVA: 0x002CDB00 File Offset: 0x002CBD00
		// (set) Token: 0x0601E2AE RID: 123566 RVA: 0x002CDB10 File Offset: 0x002CBD10
		public unsafe int progressType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrophyData.__PropertyOffset_progressType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrophyData.__PropertyOffset_progressType) = value;
			}
		}

		// Token: 0x170077D3 RID: 30675
		// (get) Token: 0x0601E2AF RID: 123567 RVA: 0x002CDB21 File Offset: 0x002CBD21
		// (set) Token: 0x0601E2B0 RID: 123568 RVA: 0x002CDB35 File Offset: 0x002CBD35
		public unsafe string progress
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTrophyData.__PropertyOffset_progress)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTrophyData.__PropertyOffset_progress)), value);
			}
		}

		// Token: 0x170077D4 RID: 30676
		// (get) Token: 0x0601E2B1 RID: 123569 RVA: 0x002CDB4A File Offset: 0x002CBD4A
		// (set) Token: 0x0601E2B2 RID: 123570 RVA: 0x002CDB5E File Offset: 0x002CBD5E
		public unsafe string timestamp
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTrophyData.__PropertyOffset_timestamp)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTrophyData.__PropertyOffset_timestamp)), value);
			}
		}

		// Token: 0x0601E2B3 RID: 123571 RVA: 0x002CDB73 File Offset: 0x002CBD73
		public FTrophyData()
		{
		}

		// Token: 0x0601E2B4 RID: 123572 RVA: 0x002CDB7B File Offset: 0x002CBD7B
		public FTrophyData(int trophyId, bool unlocked, int progressType, string progress, string timestamp)
		{
			this.trophyId = trophyId;
			this.unlocked = unlocked;
			this.progressType = progressType;
			this.progress = progress;
			this.timestamp = timestamp;
		}

		// Token: 0x0601E2B5 RID: 123573 RVA: 0x002CDBA8 File Offset: 0x002CBDA8
		protected override IntPtr GetUStructPtr()
		{
			return FTrophyData.StaticStruct();
		}

		// Token: 0x0601E2B6 RID: 123574 RVA: 0x002CDBB4 File Offset: 0x002CBDB4
		[NullableContext(2)]
		public FTrophyData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E2B7 RID: 123575 RVA: 0x002CDBBE File Offset: 0x002CBDBE
		public FTrophyData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E2B8 RID: 123576 RVA: 0x002CDBC9 File Offset: 0x002CBDC9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTrophyData(Pointer, false, true);
		}

		// Token: 0x0601E2B9 RID: 123577 RVA: 0x002CDBD3 File Offset: 0x002CBDD3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTrophyData(Pointer, MemoryOwner);
		}

		// Token: 0x04010498 RID: 66712
		public const string __ObjectPath = "/Script/KuroUtility.TrophyData";

		// Token: 0x04010499 RID: 66713
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401049A RID: 66714
		internal static int __PropertyOffset_trophyId;

		// Token: 0x0401049B RID: 66715
		internal static int __PropertyOffset_unlocked;

		// Token: 0x0401049C RID: 66716
		internal static int __PropertyOffset_progressType;

		// Token: 0x0401049D RID: 66717
		internal static int __PropertyOffset_progress;

		// Token: 0x0401049E RID: 66718
		internal static int __PropertyOffset_timestamp;
	}
}
