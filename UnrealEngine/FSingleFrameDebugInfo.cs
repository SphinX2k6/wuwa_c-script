using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019E9 RID: 6633
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroMovement.SingleFrameDebugInfo")]
	[UnrealStructLayout(344, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 344)]
	public class FSingleFrameDebugInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060189B9 RID: 100793 RVA: 0x0024421B File Offset: 0x0024241B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSingleFrameDebugInfo._ScriptStructPtr != 0) ? FSingleFrameDebugInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroMovement.SingleFrameDebugInfo", ref FSingleFrameDebugInfo._ScriptStructPtr);
		}

		// Token: 0x170061F8 RID: 25080
		// (get) Token: 0x060189BA RID: 100794 RVA: 0x00244240 File Offset: 0x00242440
		// (set) Token: 0x060189BB RID: 100795 RVA: 0x00244283 File Offset: 0x00242483
		public FDebugTickGroupRecord TickStartRecord
		{
			get
			{
				base.FastCheckIsValid();
				FDebugTickGroupRecord result;
				if ((result = this._TickStartRecord) == null)
				{
					result = (this._TickStartRecord = new FDebugTickGroupRecord(base.NativePtr + (IntPtr)FSingleFrameDebugInfo.__PropertyOffset_TickStartRecord, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDebugTickGroupRecord.StaticStruct(), base.NativePtr + (IntPtr)FSingleFrameDebugInfo.__PropertyOffset_TickStartRecord, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170061F9 RID: 25081
		// (get) Token: 0x060189BC RID: 100796 RVA: 0x002442A4 File Offset: 0x002424A4
		// (set) Token: 0x060189BD RID: 100797 RVA: 0x002442E7 File Offset: 0x002424E7
		public FDebugTickGroupRecord PositionTickEnd
		{
			get
			{
				base.FastCheckIsValid();
				FDebugTickGroupRecord result;
				if ((result = this._PositionTickEnd) == null)
				{
					result = (this._PositionTickEnd = new FDebugTickGroupRecord(base.NativePtr + (IntPtr)FSingleFrameDebugInfo.__PropertyOffset_PositionTickEnd, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDebugTickGroupRecord.StaticStruct(), base.NativePtr + (IntPtr)FSingleFrameDebugInfo.__PropertyOffset_PositionTickEnd, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170061FA RID: 25082
		// (get) Token: 0x060189BE RID: 100798 RVA: 0x00244308 File Offset: 0x00242508
		// (set) Token: 0x060189BF RID: 100799 RVA: 0x0024434B File Offset: 0x0024254B
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<ETickingGroup>, FDebugTickGroupRecord> TickGroupDebugPositionInfo
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<ETickingGroup>, FDebugTickGroupRecord> result;
				if ((result = this._TickGroupDebugPositionInfo) == null)
				{
					result = (this._TickGroupDebugPositionInfo = new TMap<TEnumAsByte<ETickingGroup>, FDebugTickGroupRecord>(base.NativePtr + (IntPtr)FSingleFrameDebugInfo.__PropertyOffset_TickGroupDebugPositionInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.TickGroupDebugPositionInfo.CopyAssign(value);
			}
		}

		// Token: 0x060189C0 RID: 100800 RVA: 0x00244359 File Offset: 0x00242559
		public FSingleFrameDebugInfo()
		{
		}

		// Token: 0x060189C1 RID: 100801 RVA: 0x00244361 File Offset: 0x00242561
		public FSingleFrameDebugInfo(FDebugTickGroupRecord TickStartRecord, FDebugTickGroupRecord PositionTickEnd, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<ETickingGroup>, FDebugTickGroupRecord> TickGroupDebugPositionInfo)
		{
			this.TickStartRecord = TickStartRecord;
			this.PositionTickEnd = PositionTickEnd;
			this.TickGroupDebugPositionInfo = TickGroupDebugPositionInfo;
		}

		// Token: 0x060189C2 RID: 100802 RVA: 0x0024437E File Offset: 0x0024257E
		protected override IntPtr GetUStructPtr()
		{
			return FSingleFrameDebugInfo.StaticStruct();
		}

		// Token: 0x060189C3 RID: 100803 RVA: 0x0024438A File Offset: 0x0024258A
		[NullableContext(2)]
		public FSingleFrameDebugInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060189C4 RID: 100804 RVA: 0x00244394 File Offset: 0x00242594
		public FSingleFrameDebugInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060189C5 RID: 100805 RVA: 0x0024439F File Offset: 0x0024259F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSingleFrameDebugInfo(Pointer, false, true);
		}

		// Token: 0x060189C6 RID: 100806 RVA: 0x002443A9 File Offset: 0x002425A9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSingleFrameDebugInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400D4CF RID: 54479
		public const string __ObjectPath = "/Script/KuroMovement.SingleFrameDebugInfo";

		// Token: 0x0400D4D0 RID: 54480
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D4D1 RID: 54481
		internal static int __PropertyOffset_TickStartRecord;

		// Token: 0x0400D4D2 RID: 54482
		[Nullable(2)]
		private FDebugTickGroupRecord _TickStartRecord;

		// Token: 0x0400D4D3 RID: 54483
		internal static int __PropertyOffset_PositionTickEnd;

		// Token: 0x0400D4D4 RID: 54484
		[Nullable(2)]
		private FDebugTickGroupRecord _PositionTickEnd;

		// Token: 0x0400D4D5 RID: 54485
		internal static int __PropertyOffset_TickGroupDebugPositionInfo;

		// Token: 0x0400D4D6 RID: 54486
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<ETickingGroup>, FDebugTickGroupRecord> _TickGroupDebugPositionInfo;
	}
}
