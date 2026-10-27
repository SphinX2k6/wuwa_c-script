using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006E3 RID: 1763
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_TimeOffsetTransform")]
	[UnrealStructLayout(176, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FRigUnit_TimeOffsetTransform : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005E98 RID: 24216 RVA: 0x00087AF8 File Offset: 0x00085CF8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_TimeOffsetTransform._ScriptStructPtr != 0) ? FRigUnit_TimeOffsetTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_TimeOffsetTransform", ref FRigUnit_TimeOffsetTransform._ScriptStructPtr);
		}

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x06005E99 RID: 24217 RVA: 0x00087B1C File Offset: 0x00085D1C
		// (set) Token: 0x06005E9A RID: 24218 RVA: 0x00087B30 File Offset: 0x00085D30
		public unsafe FTransform Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetTransform.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetTransform.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x06005E9B RID: 24219 RVA: 0x00087B45 File Offset: 0x00085D45
		// (set) Token: 0x06005E9C RID: 24220 RVA: 0x00087B55 File Offset: 0x00085D55
		public unsafe float SecondsAgo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetTransform.__PropertyOffset_SecondsAgo);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetTransform.__PropertyOffset_SecondsAgo) = value;
			}
		}

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x06005E9D RID: 24221 RVA: 0x00087B66 File Offset: 0x00085D66
		// (set) Token: 0x06005E9E RID: 24222 RVA: 0x00087B76 File Offset: 0x00085D76
		public unsafe int BufferSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetTransform.__PropertyOffset_BufferSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetTransform.__PropertyOffset_BufferSize) = value;
			}
		}

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x06005E9F RID: 24223 RVA: 0x00087B87 File Offset: 0x00085D87
		// (set) Token: 0x06005EA0 RID: 24224 RVA: 0x00087B97 File Offset: 0x00085D97
		public unsafe float TimeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetTransform.__PropertyOffset_TimeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetTransform.__PropertyOffset_TimeRange) = value;
			}
		}

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x06005EA1 RID: 24225 RVA: 0x00087BA8 File Offset: 0x00085DA8
		// (set) Token: 0x06005EA2 RID: 24226 RVA: 0x00087BBC File Offset: 0x00085DBC
		public unsafe FTransform Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetTransform.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetTransform.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x06005EA3 RID: 24227 RVA: 0x00087BD4 File Offset: 0x00085DD4
		// (set) Token: 0x06005EA4 RID: 24228 RVA: 0x00087C17 File Offset: 0x00085E17
		public TArray<FTransform> Buffer
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._Buffer) == null)
				{
					result = (this._Buffer = new TArray<FTransform>(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetTransform.__PropertyOffset_Buffer, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Buffer.CopyAssign(value);
			}
		}

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x06005EA5 RID: 24229 RVA: 0x00087C28 File Offset: 0x00085E28
		// (set) Token: 0x06005EA6 RID: 24230 RVA: 0x00087C6B File Offset: 0x00085E6B
		public TArray<float> DeltaTimes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._DeltaTimes) == null)
				{
					result = (this._DeltaTimes = new TArray<float>(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetTransform.__PropertyOffset_DeltaTimes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DeltaTimes.CopyAssign(value);
			}
		}

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x06005EA7 RID: 24231 RVA: 0x00087C79 File Offset: 0x00085E79
		// (set) Token: 0x06005EA8 RID: 24232 RVA: 0x00087C89 File Offset: 0x00085E89
		public unsafe int LastInsertIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetTransform.__PropertyOffset_LastInsertIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetTransform.__PropertyOffset_LastInsertIndex) = value;
			}
		}

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x06005EA9 RID: 24233 RVA: 0x00087C9A File Offset: 0x00085E9A
		// (set) Token: 0x06005EAA RID: 24234 RVA: 0x00087CAA File Offset: 0x00085EAA
		public unsafe int UpperBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetTransform.__PropertyOffset_UpperBound);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetTransform.__PropertyOffset_UpperBound) = value;
			}
		}

		// Token: 0x06005EAB RID: 24235 RVA: 0x00087CBB File Offset: 0x00085EBB
		public FRigUnit_TimeOffsetTransform()
		{
		}

		// Token: 0x06005EAC RID: 24236 RVA: 0x00087CC4 File Offset: 0x00085EC4
		public FRigUnit_TimeOffsetTransform(FTransform Value, float SecondsAgo, int BufferSize, float TimeRange, FTransform Result, TArray<FTransform> Buffer, TArray<float> DeltaTimes, int LastInsertIndex, int UpperBound)
		{
			this.Value = Value;
			this.SecondsAgo = SecondsAgo;
			this.BufferSize = BufferSize;
			this.TimeRange = TimeRange;
			this.Result = Result;
			this.Buffer = Buffer;
			this.DeltaTimes = DeltaTimes;
			this.LastInsertIndex = LastInsertIndex;
			this.UpperBound = UpperBound;
		}

		// Token: 0x06005EAD RID: 24237 RVA: 0x00087D1C File Offset: 0x00085F1C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_TimeOffsetTransform.StaticStruct();
		}

		// Token: 0x06005EAE RID: 24238 RVA: 0x00087D28 File Offset: 0x00085F28
		[NullableContext(2)]
		public FRigUnit_TimeOffsetTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005EAF RID: 24239 RVA: 0x00087D32 File Offset: 0x00085F32
		public FRigUnit_TimeOffsetTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005EB0 RID: 24240 RVA: 0x00087D3D File Offset: 0x00085F3D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_TimeOffsetTransform(Pointer, false, true);
		}

		// Token: 0x06005EB1 RID: 24241 RVA: 0x00087D47 File Offset: 0x00085F47
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_TimeOffsetTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04002C3D RID: 11325
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_TimeOffsetTransform";

		// Token: 0x04002C3E RID: 11326
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002C3F RID: 11327
		internal static int __PropertyOffset_Value;

		// Token: 0x04002C40 RID: 11328
		internal static int __PropertyOffset_SecondsAgo;

		// Token: 0x04002C41 RID: 11329
		internal static int __PropertyOffset_BufferSize;

		// Token: 0x04002C42 RID: 11330
		internal static int __PropertyOffset_TimeRange;

		// Token: 0x04002C43 RID: 11331
		internal static int __PropertyOffset_Result;

		// Token: 0x04002C44 RID: 11332
		internal static int __PropertyOffset_Buffer;

		// Token: 0x04002C45 RID: 11333
		[Nullable(2)]
		private TArray<FTransform> _Buffer;

		// Token: 0x04002C46 RID: 11334
		internal static int __PropertyOffset_DeltaTimes;

		// Token: 0x04002C47 RID: 11335
		[Nullable(2)]
		private TArray<float> _DeltaTimes;

		// Token: 0x04002C48 RID: 11336
		internal static int __PropertyOffset_LastInsertIndex;

		// Token: 0x04002C49 RID: 11337
		internal static int __PropertyOffset_UpperBound;
	}
}
