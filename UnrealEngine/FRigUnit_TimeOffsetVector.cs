using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006E4 RID: 1764
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_TimeOffsetVector")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FRigUnit_TimeOffsetVector : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005EB2 RID: 24242 RVA: 0x00087D50 File Offset: 0x00085F50
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_TimeOffsetVector._ScriptStructPtr != 0) ? FRigUnit_TimeOffsetVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_TimeOffsetVector", ref FRigUnit_TimeOffsetVector._ScriptStructPtr);
		}

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x06005EB3 RID: 24243 RVA: 0x00087D74 File Offset: 0x00085F74
		// (set) Token: 0x06005EB4 RID: 24244 RVA: 0x00087D88 File Offset: 0x00085F88
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetVector.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetVector.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x06005EB5 RID: 24245 RVA: 0x00087D9D File Offset: 0x00085F9D
		// (set) Token: 0x06005EB6 RID: 24246 RVA: 0x00087DAD File Offset: 0x00085FAD
		public unsafe float SecondsAgo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetVector.__PropertyOffset_SecondsAgo);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetVector.__PropertyOffset_SecondsAgo) = value;
			}
		}

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x06005EB7 RID: 24247 RVA: 0x00087DBE File Offset: 0x00085FBE
		// (set) Token: 0x06005EB8 RID: 24248 RVA: 0x00087DCE File Offset: 0x00085FCE
		public unsafe int BufferSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetVector.__PropertyOffset_BufferSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetVector.__PropertyOffset_BufferSize) = value;
			}
		}

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x06005EB9 RID: 24249 RVA: 0x00087DDF File Offset: 0x00085FDF
		// (set) Token: 0x06005EBA RID: 24250 RVA: 0x00087DEF File Offset: 0x00085FEF
		public unsafe float TimeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetVector.__PropertyOffset_TimeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetVector.__PropertyOffset_TimeRange) = value;
			}
		}

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x06005EBB RID: 24251 RVA: 0x00087E00 File Offset: 0x00086000
		// (set) Token: 0x06005EBC RID: 24252 RVA: 0x00087E14 File Offset: 0x00086014
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetVector.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetVector.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x06005EBD RID: 24253 RVA: 0x00087E2C File Offset: 0x0008602C
		// (set) Token: 0x06005EBE RID: 24254 RVA: 0x00087E6F File Offset: 0x0008606F
		public TArray<FVector> Buffer
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Buffer) == null)
				{
					result = (this._Buffer = new TArray<FVector>(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetVector.__PropertyOffset_Buffer, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Buffer.CopyAssign(value);
			}
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x06005EBF RID: 24255 RVA: 0x00087E80 File Offset: 0x00086080
		// (set) Token: 0x06005EC0 RID: 24256 RVA: 0x00087EC3 File Offset: 0x000860C3
		public TArray<float> DeltaTimes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._DeltaTimes) == null)
				{
					result = (this._DeltaTimes = new TArray<float>(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetVector.__PropertyOffset_DeltaTimes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DeltaTimes.CopyAssign(value);
			}
		}

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x06005EC1 RID: 24257 RVA: 0x00087ED1 File Offset: 0x000860D1
		// (set) Token: 0x06005EC2 RID: 24258 RVA: 0x00087EE1 File Offset: 0x000860E1
		public unsafe int LastInsertIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetVector.__PropertyOffset_LastInsertIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetVector.__PropertyOffset_LastInsertIndex) = value;
			}
		}

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x06005EC3 RID: 24259 RVA: 0x00087EF2 File Offset: 0x000860F2
		// (set) Token: 0x06005EC4 RID: 24260 RVA: 0x00087F02 File Offset: 0x00086102
		public unsafe int UpperBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetVector.__PropertyOffset_UpperBound);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TimeOffsetVector.__PropertyOffset_UpperBound) = value;
			}
		}

		// Token: 0x06005EC5 RID: 24261 RVA: 0x00087F13 File Offset: 0x00086113
		public FRigUnit_TimeOffsetVector()
		{
		}

		// Token: 0x06005EC6 RID: 24262 RVA: 0x00087F1C File Offset: 0x0008611C
		public FRigUnit_TimeOffsetVector(FVector Value, float SecondsAgo, int BufferSize, float TimeRange, FVector Result, TArray<FVector> Buffer, TArray<float> DeltaTimes, int LastInsertIndex, int UpperBound)
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

		// Token: 0x06005EC7 RID: 24263 RVA: 0x00087F74 File Offset: 0x00086174
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_TimeOffsetVector.StaticStruct();
		}

		// Token: 0x06005EC8 RID: 24264 RVA: 0x00087F80 File Offset: 0x00086180
		[NullableContext(2)]
		public FRigUnit_TimeOffsetVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005EC9 RID: 24265 RVA: 0x00087F8A File Offset: 0x0008618A
		public FRigUnit_TimeOffsetVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005ECA RID: 24266 RVA: 0x00087F95 File Offset: 0x00086195
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_TimeOffsetVector(Pointer, false, true);
		}

		// Token: 0x06005ECB RID: 24267 RVA: 0x00087F9F File Offset: 0x0008619F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_TimeOffsetVector(Pointer, MemoryOwner);
		}

		// Token: 0x04002C4A RID: 11338
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_TimeOffsetVector";

		// Token: 0x04002C4B RID: 11339
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002C4C RID: 11340
		internal static int __PropertyOffset_Value;

		// Token: 0x04002C4D RID: 11341
		internal static int __PropertyOffset_SecondsAgo;

		// Token: 0x04002C4E RID: 11342
		internal static int __PropertyOffset_BufferSize;

		// Token: 0x04002C4F RID: 11343
		internal static int __PropertyOffset_TimeRange;

		// Token: 0x04002C50 RID: 11344
		internal static int __PropertyOffset_Result;

		// Token: 0x04002C51 RID: 11345
		internal static int __PropertyOffset_Buffer;

		// Token: 0x04002C52 RID: 11346
		[Nullable(2)]
		private TArray<FVector> _Buffer;

		// Token: 0x04002C53 RID: 11347
		internal static int __PropertyOffset_DeltaTimes;

		// Token: 0x04002C54 RID: 11348
		[Nullable(2)]
		private TArray<float> _DeltaTimes;

		// Token: 0x04002C55 RID: 11349
		internal static int __PropertyOffset_LastInsertIndex;

		// Token: 0x04002C56 RID: 11350
		internal static int __PropertyOffset_UpperBound;
	}
}
