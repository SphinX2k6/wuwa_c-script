using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006E2 RID: 1762
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_TimeOffsetFloat")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FRigUnit_TimeOffsetFloat : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005E7E RID: 24190 RVA: 0x000878B2 File Offset: 0x00085AB2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_TimeOffsetFloat._ScriptStructPtr != 0) ? FRigUnit_TimeOffsetFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_TimeOffsetFloat", ref FRigUnit_TimeOffsetFloat._ScriptStructPtr);
		}

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x06005E7F RID: 24191 RVA: 0x000878D6 File Offset: 0x00085AD6
		// (set) Token: 0x06005E80 RID: 24192 RVA: 0x000878E6 File Offset: 0x00085AE6
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetFloat.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetFloat.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x06005E81 RID: 24193 RVA: 0x000878F7 File Offset: 0x00085AF7
		// (set) Token: 0x06005E82 RID: 24194 RVA: 0x00087907 File Offset: 0x00085B07
		public unsafe float SecondsAgo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetFloat.__PropertyOffset_SecondsAgo);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetFloat.__PropertyOffset_SecondsAgo) = value;
			}
		}

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x06005E83 RID: 24195 RVA: 0x00087918 File Offset: 0x00085B18
		// (set) Token: 0x06005E84 RID: 24196 RVA: 0x00087928 File Offset: 0x00085B28
		public unsafe int BufferSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetFloat.__PropertyOffset_BufferSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetFloat.__PropertyOffset_BufferSize) = value;
			}
		}

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x06005E85 RID: 24197 RVA: 0x00087939 File Offset: 0x00085B39
		// (set) Token: 0x06005E86 RID: 24198 RVA: 0x00087949 File Offset: 0x00085B49
		public unsafe float TimeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetFloat.__PropertyOffset_TimeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetFloat.__PropertyOffset_TimeRange) = value;
			}
		}

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x06005E87 RID: 24199 RVA: 0x0008795A File Offset: 0x00085B5A
		// (set) Token: 0x06005E88 RID: 24200 RVA: 0x0008796A File Offset: 0x00085B6A
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetFloat.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetFloat.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x06005E89 RID: 24201 RVA: 0x0008797C File Offset: 0x00085B7C
		// (set) Token: 0x06005E8A RID: 24202 RVA: 0x000879BF File Offset: 0x00085BBF
		public TArray<float> Buffer
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Buffer) == null)
				{
					result = (this._Buffer = new TArray<float>(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetFloat.__PropertyOffset_Buffer, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Buffer.CopyAssign(value);
			}
		}

		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x06005E8B RID: 24203 RVA: 0x000879D0 File Offset: 0x00085BD0
		// (set) Token: 0x06005E8C RID: 24204 RVA: 0x00087A13 File Offset: 0x00085C13
		public TArray<float> DeltaTimes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._DeltaTimes) == null)
				{
					result = (this._DeltaTimes = new TArray<float>(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetFloat.__PropertyOffset_DeltaTimes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DeltaTimes.CopyAssign(value);
			}
		}

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x06005E8D RID: 24205 RVA: 0x00087A21 File Offset: 0x00085C21
		// (set) Token: 0x06005E8E RID: 24206 RVA: 0x00087A31 File Offset: 0x00085C31
		public unsafe int LastInsertIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetFloat.__PropertyOffset_LastInsertIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetFloat.__PropertyOffset_LastInsertIndex) = value;
			}
		}

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x06005E8F RID: 24207 RVA: 0x00087A42 File Offset: 0x00085C42
		// (set) Token: 0x06005E90 RID: 24208 RVA: 0x00087A52 File Offset: 0x00085C52
		public unsafe int UpperBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetFloat.__PropertyOffset_UpperBound);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetFloat.__PropertyOffset_UpperBound) = value;
			}
		}

		// Token: 0x06005E91 RID: 24209 RVA: 0x00087A63 File Offset: 0x00085C63
		public FRigUnit_TimeOffsetFloat()
		{
		}

		// Token: 0x06005E92 RID: 24210 RVA: 0x00087A6C File Offset: 0x00085C6C
		public FRigUnit_TimeOffsetFloat(float Value, float SecondsAgo, int BufferSize, float TimeRange, float Result, TArray<float> Buffer, TArray<float> DeltaTimes, int LastInsertIndex, int UpperBound)
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

		// Token: 0x06005E93 RID: 24211 RVA: 0x00087AC4 File Offset: 0x00085CC4
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_TimeOffsetFloat.StaticStruct();
		}

		// Token: 0x06005E94 RID: 24212 RVA: 0x00087AD0 File Offset: 0x00085CD0
		[NullableContext(2)]
		public FRigUnit_TimeOffsetFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005E95 RID: 24213 RVA: 0x00087ADA File Offset: 0x00085CDA
		public FRigUnit_TimeOffsetFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005E96 RID: 24214 RVA: 0x00087AE5 File Offset: 0x00085CE5
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_TimeOffsetFloat(Pointer, false, true);
		}

		// Token: 0x06005E97 RID: 24215 RVA: 0x00087AEF File Offset: 0x00085CEF
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_TimeOffsetFloat(Pointer, MemoryOwner);
		}

		// Token: 0x04002C30 RID: 11312
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_TimeOffsetFloat";

		// Token: 0x04002C31 RID: 11313
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002C32 RID: 11314
		internal static int __PropertyOffset_Value;

		// Token: 0x04002C33 RID: 11315
		internal static int __PropertyOffset_SecondsAgo;

		// Token: 0x04002C34 RID: 11316
		internal static int __PropertyOffset_BufferSize;

		// Token: 0x04002C35 RID: 11317
		internal static int __PropertyOffset_TimeRange;

		// Token: 0x04002C36 RID: 11318
		internal static int __PropertyOffset_Result;

		// Token: 0x04002C37 RID: 11319
		internal static int __PropertyOffset_Buffer;

		// Token: 0x04002C38 RID: 11320
		[Nullable(2)]
		private TArray<float> _Buffer;

		// Token: 0x04002C39 RID: 11321
		internal static int __PropertyOffset_DeltaTimes;

		// Token: 0x04002C3A RID: 11322
		[Nullable(2)]
		private TArray<float> _DeltaTimes;

		// Token: 0x04002C3B RID: 11323
		internal static int __PropertyOffset_LastInsertIndex;

		// Token: 0x04002C3C RID: 11324
		internal static int __PropertyOffset_UpperBound;
	}
}
