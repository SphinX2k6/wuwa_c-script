using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005B7 RID: 1463
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.BlockUserData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FBlockUserData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008345 RID: 33605 RVA: 0x000C2432 File Offset: 0x000C0632
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlockUserData._ScriptStructPtr != 0) ? FBlockUserData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.BlockUserData", ref FBlockUserData._ScriptStructPtr);
		}

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x06008346 RID: 33606 RVA: 0x000C2456 File Offset: 0x000C0656
		// (set) Token: 0x06008347 RID: 33607 RVA: 0x000C2466 File Offset: 0x000C0666
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

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x06008348 RID: 33608 RVA: 0x000C2477 File Offset: 0x000C0677
		// (set) Token: 0x06008349 RID: 33609 RVA: 0x000C2487 File Offset: 0x000C0687
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

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x0600834A RID: 33610 RVA: 0x000C2498 File Offset: 0x000C0698
		// (set) Token: 0x0600834B RID: 33611 RVA: 0x000C24DB File Offset: 0x000C06DB
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

		// Token: 0x0600834C RID: 33612 RVA: 0x000C24E9 File Offset: 0x000C06E9
		public FBlockUserData()
		{
		}

		// Token: 0x0600834D RID: 33613 RVA: 0x000C24F1 File Offset: 0x000C06F1
		protected override IntPtr GetUStructPtr()
		{
			return FBlockUserData.StaticStruct();
		}

		// Token: 0x0600834E RID: 33614 RVA: 0x000C24FD File Offset: 0x000C06FD
		[NullableContext(2)]
		public FBlockUserData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600834F RID: 33615 RVA: 0x000C2507 File Offset: 0x000C0707
		public FBlockUserData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008350 RID: 33616 RVA: 0x000C2512 File Offset: 0x000C0712
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlockUserData(Pointer, false, true);
		}

		// Token: 0x06008351 RID: 33617 RVA: 0x000C251C File Offset: 0x000C071C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlockUserData(Pointer, MemoryOwner);
		}

		// Token: 0x04003916 RID: 14614
		public const string __ObjectPath = "/Script/KuroUtility.BlockUserData";

		// Token: 0x04003917 RID: 14615
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003918 RID: 14616
		internal static int __PropertyOffset_nextOffset;

		// Token: 0x04003919 RID: 14617
		internal static int __PropertyOffset_previousOffset;

		// Token: 0x0400391A RID: 14618
		internal static int __PropertyOffset_blockUsers;

		// Token: 0x0400391B RID: 14619
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _blockUsers;
	}
}
