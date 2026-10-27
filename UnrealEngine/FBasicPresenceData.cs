using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001E8E RID: 7822
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.BasicPresenceData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FBasicPresenceData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601DC19 RID: 121881 RVA: 0x002BF735 File Offset: 0x002BD935
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBasicPresenceData._ScriptStructPtr != 0) ? FBasicPresenceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.BasicPresenceData", ref FBasicPresenceData._ScriptStructPtr);
		}

		// Token: 0x17007785 RID: 30597
		// (get) Token: 0x0601DC1A RID: 121882 RVA: 0x002BF759 File Offset: 0x002BD959
		// (set) Token: 0x0601DC1B RID: 121883 RVA: 0x002BF76D File Offset: 0x002BD96D
		public unsafe string accountId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBasicPresenceData.__PropertyOffset_accountId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBasicPresenceData.__PropertyOffset_accountId)), value);
			}
		}

		// Token: 0x17007786 RID: 30598
		// (get) Token: 0x0601DC1C RID: 121884 RVA: 0x002BF782 File Offset: 0x002BD982
		// (set) Token: 0x0601DC1D RID: 121885 RVA: 0x002BF792 File Offset: 0x002BD992
		public unsafe int OnlineState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasicPresenceData.__PropertyOffset_OnlineState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasicPresenceData.__PropertyOffset_OnlineState) = value;
			}
		}

		// Token: 0x17007787 RID: 30599
		// (get) Token: 0x0601DC1E RID: 121886 RVA: 0x002BF7A3 File Offset: 0x002BD9A3
		// (set) Token: 0x0601DC1F RID: 121887 RVA: 0x002BF7B3 File Offset: 0x002BD9B3
		public unsafe bool Context
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasicPresenceData.__PropertyOffset_Context) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasicPresenceData.__PropertyOffset_Context) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601DC20 RID: 121888 RVA: 0x002BF7C4 File Offset: 0x002BD9C4
		public FBasicPresenceData()
		{
		}

		// Token: 0x0601DC21 RID: 121889 RVA: 0x002BF7CC File Offset: 0x002BD9CC
		public FBasicPresenceData(string accountId, int OnlineState, bool Context)
		{
			this.accountId = accountId;
			this.OnlineState = OnlineState;
			this.Context = Context;
		}

		// Token: 0x0601DC22 RID: 121890 RVA: 0x002BF7E9 File Offset: 0x002BD9E9
		protected override IntPtr GetUStructPtr()
		{
			return FBasicPresenceData.StaticStruct();
		}

		// Token: 0x0601DC23 RID: 121891 RVA: 0x002BF7F5 File Offset: 0x002BD9F5
		[NullableContext(2)]
		public FBasicPresenceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DC24 RID: 121892 RVA: 0x002BF7FF File Offset: 0x002BD9FF
		public FBasicPresenceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DC25 RID: 121893 RVA: 0x002BF80A File Offset: 0x002BDA0A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBasicPresenceData(Pointer, false, true);
		}

		// Token: 0x0601DC26 RID: 121894 RVA: 0x002BF814 File Offset: 0x002BDA14
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBasicPresenceData(Pointer, MemoryOwner);
		}

		// Token: 0x040101C7 RID: 65991
		public const string __ObjectPath = "/Script/KuroUtility.BasicPresenceData";

		// Token: 0x040101C8 RID: 65992
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040101C9 RID: 65993
		internal static int __PropertyOffset_accountId;

		// Token: 0x040101CA RID: 65994
		internal static int __PropertyOffset_OnlineState;

		// Token: 0x040101CB RID: 65995
		internal static int __PropertyOffset_Context;
	}
}
