using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000469 RID: 1129
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Chaos.RecordedTransformTrack")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRecordedTransformTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003C2A RID: 15402 RVA: 0x0005AC18 File Offset: 0x00058E18
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRecordedTransformTrack._ScriptStructPtr != 0) ? FRecordedTransformTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Chaos.RecordedTransformTrack", ref FRecordedTransformTrack._ScriptStructPtr);
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06003C2B RID: 15403 RVA: 0x0005AC3C File Offset: 0x00058E3C
		// (set) Token: 0x06003C2C RID: 15404 RVA: 0x0005AC7F File Offset: 0x00058E7F
		public TArray<FRecordedFrame> Records
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRecordedFrame> result;
				if ((result = this._Records) == null)
				{
					result = (this._Records = new TArray<FRecordedFrame>(base.NativePtr + (IntPtr)FRecordedTransformTrack.__PropertyOffset_Records, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Records.CopyAssign(value);
			}
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x0005AC8D File Offset: 0x00058E8D
		public FRecordedTransformTrack()
		{
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x0005AC95 File Offset: 0x00058E95
		public FRecordedTransformTrack(TArray<FRecordedFrame> Records)
		{
			this.Records = Records;
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x0005ACA4 File Offset: 0x00058EA4
		protected override IntPtr GetUStructPtr()
		{
			return FRecordedTransformTrack.StaticStruct();
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x0005ACB0 File Offset: 0x00058EB0
		[NullableContext(2)]
		public FRecordedTransformTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x0005ACBA File Offset: 0x00058EBA
		public FRecordedTransformTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x0005ACC5 File Offset: 0x00058EC5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRecordedTransformTrack(Pointer, false, true);
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x0005ACCF File Offset: 0x00058ECF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRecordedTransformTrack(Pointer, MemoryOwner);
		}

		// Token: 0x04001C3E RID: 7230
		public const string __ObjectPath = "/Script/Chaos.RecordedTransformTrack";

		// Token: 0x04001C3F RID: 7231
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001C40 RID: 7232
		internal static int __PropertyOffset_Records;

		// Token: 0x04001C41 RID: 7233
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRecordedFrame> _Records;
	}
}
