using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019D7 RID: 6615
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroMovement.DebugTickGroupRecord")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FDebugTickGroupRecord : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601890A RID: 100618 RVA: 0x00242D3A File Offset: 0x00240F3A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDebugTickGroupRecord._ScriptStructPtr != 0) ? FDebugTickGroupRecord._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroMovement.DebugTickGroupRecord", ref FDebugTickGroupRecord._ScriptStructPtr);
		}

		// Token: 0x170061E8 RID: 25064
		// (get) Token: 0x0601890B RID: 100619 RVA: 0x00242D60 File Offset: 0x00240F60
		// (set) Token: 0x0601890C RID: 100620 RVA: 0x00242DA3 File Offset: 0x00240FA3
		public FBaseRecord Record
		{
			get
			{
				base.FastCheckIsValid();
				FBaseRecord result;
				if ((result = this._Record) == null)
				{
					result = (this._Record = new FBaseRecord(base.NativePtr + (IntPtr)FDebugTickGroupRecord.__PropertyOffset_Record, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBaseRecord.StaticStruct(), base.NativePtr + (IntPtr)FDebugTickGroupRecord.__PropertyOffset_Record, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170061E9 RID: 25065
		// (get) Token: 0x0601890D RID: 100621 RVA: 0x00242DC4 File Offset: 0x00240FC4
		// (set) Token: 0x0601890E RID: 100622 RVA: 0x00242E07 File Offset: 0x00241007
		public TArray<FDebugModifyRecord> ModifyRecords
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FDebugModifyRecord> result;
				if ((result = this._ModifyRecords) == null)
				{
					result = (this._ModifyRecords = new TArray<FDebugModifyRecord>(base.NativePtr + (IntPtr)FDebugTickGroupRecord.__PropertyOffset_ModifyRecords, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyRecords.CopyAssign(value);
			}
		}

		// Token: 0x0601890F RID: 100623 RVA: 0x00242E15 File Offset: 0x00241015
		public FDebugTickGroupRecord()
		{
		}

		// Token: 0x06018910 RID: 100624 RVA: 0x00242E1D File Offset: 0x0024101D
		public FDebugTickGroupRecord(FBaseRecord Record, TArray<FDebugModifyRecord> ModifyRecords)
		{
			this.Record = Record;
			this.ModifyRecords = ModifyRecords;
		}

		// Token: 0x06018911 RID: 100625 RVA: 0x00242E33 File Offset: 0x00241033
		protected override IntPtr GetUStructPtr()
		{
			return FDebugTickGroupRecord.StaticStruct();
		}

		// Token: 0x06018912 RID: 100626 RVA: 0x00242E3F File Offset: 0x0024103F
		[NullableContext(2)]
		public FDebugTickGroupRecord(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018913 RID: 100627 RVA: 0x00242E49 File Offset: 0x00241049
		public FDebugTickGroupRecord(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018914 RID: 100628 RVA: 0x00242E54 File Offset: 0x00241054
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDebugTickGroupRecord(Pointer, false, true);
		}

		// Token: 0x06018915 RID: 100629 RVA: 0x00242E5E File Offset: 0x0024105E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDebugTickGroupRecord(Pointer, MemoryOwner);
		}

		// Token: 0x0400D456 RID: 54358
		public const string __ObjectPath = "/Script/KuroMovement.DebugTickGroupRecord";

		// Token: 0x0400D457 RID: 54359
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D458 RID: 54360
		internal static int __PropertyOffset_Record;

		// Token: 0x0400D459 RID: 54361
		[Nullable(2)]
		private FBaseRecord _Record;

		// Token: 0x0400D45A RID: 54362
		internal static int __PropertyOffset_ModifyRecords;

		// Token: 0x0400D45B RID: 54363
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FDebugModifyRecord> _ModifyRecords;
	}
}
