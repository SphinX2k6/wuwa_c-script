using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001E91 RID: 7825
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.BlockUserData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FBlockUserData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601DC39 RID: 121913 RVA: 0x002BFADE File Offset: 0x002BDCDE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlockUserData._ScriptStructPtr != 0) ? FBlockUserData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.BlockUserData", ref FBlockUserData._ScriptStructPtr);
		}

		// Token: 0x17007788 RID: 30600
		// (get) Token: 0x0601DC3A RID: 121914 RVA: 0x002BFB02 File Offset: 0x002BDD02
		// (set) Token: 0x0601DC3B RID: 121915 RVA: 0x002BFB12 File Offset: 0x002BDD12
		public unsafe int nextOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlockUserData.__PropertyOffset_nextOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlockUserData.__PropertyOffset_nextOffset) = value;
			}
		}

		// Token: 0x17007789 RID: 30601
		// (get) Token: 0x0601DC3C RID: 121916 RVA: 0x002BFB23 File Offset: 0x002BDD23
		// (set) Token: 0x0601DC3D RID: 121917 RVA: 0x002BFB33 File Offset: 0x002BDD33
		public unsafe int previousOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlockUserData.__PropertyOffset_previousOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlockUserData.__PropertyOffset_previousOffset) = value;
			}
		}

		// Token: 0x1700778A RID: 30602
		// (get) Token: 0x0601DC3E RID: 121918 RVA: 0x002BFB44 File Offset: 0x002BDD44
		// (set) Token: 0x0601DC3F RID: 121919 RVA: 0x002BFB87 File Offset: 0x002BDD87
		public TArray<string> blockUsers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._blockUsers) == null)
				{
					result = (this._blockUsers = new TArray<string>(base.NativePtr + (IntPtr)FBlockUserData.__PropertyOffset_blockUsers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.blockUsers.CopyAssign(value);
			}
		}

		// Token: 0x0601DC40 RID: 121920 RVA: 0x002BFB95 File Offset: 0x002BDD95
		public FBlockUserData()
		{
		}

		// Token: 0x0601DC41 RID: 121921 RVA: 0x002BFB9D File Offset: 0x002BDD9D
		public FBlockUserData(int nextOffset, int previousOffset, TArray<string> blockUsers)
		{
			this.nextOffset = nextOffset;
			this.previousOffset = previousOffset;
			this.blockUsers = blockUsers;
		}

		// Token: 0x0601DC42 RID: 121922 RVA: 0x002BFBBA File Offset: 0x002BDDBA
		protected override IntPtr GetUStructPtr()
		{
			return FBlockUserData.StaticStruct();
		}

		// Token: 0x0601DC43 RID: 121923 RVA: 0x002BFBC6 File Offset: 0x002BDDC6
		[NullableContext(2)]
		public FBlockUserData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DC44 RID: 121924 RVA: 0x002BFBD0 File Offset: 0x002BDDD0
		public FBlockUserData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DC45 RID: 121925 RVA: 0x002BFBDB File Offset: 0x002BDDDB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlockUserData(Pointer, false, true);
		}

		// Token: 0x0601DC46 RID: 121926 RVA: 0x002BFBE5 File Offset: 0x002BDDE5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlockUserData(Pointer, MemoryOwner);
		}

		// Token: 0x040101D2 RID: 66002
		public const string __ObjectPath = "/Script/KuroUtility.BlockUserData";

		// Token: 0x040101D3 RID: 66003
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040101D4 RID: 66004
		internal static int __PropertyOffset_nextOffset;

		// Token: 0x040101D5 RID: 66005
		internal static int __PropertyOffset_previousOffset;

		// Token: 0x040101D6 RID: 66006
		internal static int __PropertyOffset_blockUsers;

		// Token: 0x040101D7 RID: 66007
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _blockUsers;
	}
}
