using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001064 RID: 4196
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RawAnimSequenceTrack")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FRawAnimSequenceTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EEC2 RID: 61122 RVA: 0x0016228D File Offset: 0x0016048D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRawAnimSequenceTrack._ScriptStructPtr != 0) ? FRawAnimSequenceTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RawAnimSequenceTrack", ref FRawAnimSequenceTrack._ScriptStructPtr);
		}

		// Token: 0x170039CA RID: 14794
		// (get) Token: 0x0600EEC3 RID: 61123 RVA: 0x001622B4 File Offset: 0x001604B4
		// (set) Token: 0x0600EEC4 RID: 61124 RVA: 0x001622F7 File Offset: 0x001604F7
		public TArray<FVector> PosKeys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PosKeys) == null)
				{
					result = (this._PosKeys = new TArray<FVector>(base.NativePtr + (IntPtr)FRawAnimSequenceTrack.__PropertyOffset_PosKeys, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PosKeys.CopyAssign(value);
			}
		}

		// Token: 0x170039CB RID: 14795
		// (get) Token: 0x0600EEC5 RID: 61125 RVA: 0x00162308 File Offset: 0x00160508
		// (set) Token: 0x0600EEC6 RID: 61126 RVA: 0x0016234B File Offset: 0x0016054B
		public TArray<FQuat> RotKeys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FQuat> result;
				if ((result = this._RotKeys) == null)
				{
					result = (this._RotKeys = new TArray<FQuat>(base.NativePtr + (IntPtr)FRawAnimSequenceTrack.__PropertyOffset_RotKeys, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RotKeys.CopyAssign(value);
			}
		}

		// Token: 0x170039CC RID: 14796
		// (get) Token: 0x0600EEC7 RID: 61127 RVA: 0x0016235C File Offset: 0x0016055C
		// (set) Token: 0x0600EEC8 RID: 61128 RVA: 0x0016239F File Offset: 0x0016059F
		public TArray<FVector> ScaleKeys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._ScaleKeys) == null)
				{
					result = (this._ScaleKeys = new TArray<FVector>(base.NativePtr + (IntPtr)FRawAnimSequenceTrack.__PropertyOffset_ScaleKeys, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ScaleKeys.CopyAssign(value);
			}
		}

		// Token: 0x170039CD RID: 14797
		// (get) Token: 0x0600EEC9 RID: 61129 RVA: 0x001623B0 File Offset: 0x001605B0
		// (set) Token: 0x0600EECA RID: 61130 RVA: 0x001623F3 File Offset: 0x001605F3
		public TArray<FVector> ShearKeys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._ShearKeys) == null)
				{
					result = (this._ShearKeys = new TArray<FVector>(base.NativePtr + (IntPtr)FRawAnimSequenceTrack.__PropertyOffset_ShearKeys, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ShearKeys.CopyAssign(value);
			}
		}

		// Token: 0x170039CE RID: 14798
		// (get) Token: 0x0600EECB RID: 61131 RVA: 0x00162401 File Offset: 0x00160601
		// (set) Token: 0x0600EECC RID: 61132 RVA: 0x00162411 File Offset: 0x00160611
		public unsafe bool bContainsShear
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRawAnimSequenceTrack.__PropertyOffset_bContainsShear) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRawAnimSequenceTrack.__PropertyOffset_bContainsShear) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600EECD RID: 61133 RVA: 0x00162422 File Offset: 0x00160622
		public FRawAnimSequenceTrack()
		{
		}

		// Token: 0x0600EECE RID: 61134 RVA: 0x0016242A File Offset: 0x0016062A
		public FRawAnimSequenceTrack(TArray<FVector> PosKeys, TArray<FQuat> RotKeys, TArray<FVector> ScaleKeys, TArray<FVector> ShearKeys, bool bContainsShear)
		{
			this.PosKeys = PosKeys;
			this.RotKeys = RotKeys;
			this.ScaleKeys = ScaleKeys;
			this.ShearKeys = ShearKeys;
			this.bContainsShear = bContainsShear;
		}

		// Token: 0x0600EECF RID: 61135 RVA: 0x00162457 File Offset: 0x00160657
		protected override IntPtr GetUStructPtr()
		{
			return FRawAnimSequenceTrack.StaticStruct();
		}

		// Token: 0x0600EED0 RID: 61136 RVA: 0x00162463 File Offset: 0x00160663
		[NullableContext(2)]
		public FRawAnimSequenceTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EED1 RID: 61137 RVA: 0x0016246D File Offset: 0x0016066D
		public FRawAnimSequenceTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EED2 RID: 61138 RVA: 0x00162478 File Offset: 0x00160678
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRawAnimSequenceTrack(Pointer, false, true);
		}

		// Token: 0x0600EED3 RID: 61139 RVA: 0x00162482 File Offset: 0x00160682
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRawAnimSequenceTrack(Pointer, MemoryOwner);
		}

		// Token: 0x0400813A RID: 33082
		public const string __ObjectPath = "/Script/Engine.RawAnimSequenceTrack";

		// Token: 0x0400813B RID: 33083
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400813C RID: 33084
		internal static int __PropertyOffset_PosKeys;

		// Token: 0x0400813D RID: 33085
		[Nullable(2)]
		private TArray<FVector> _PosKeys;

		// Token: 0x0400813E RID: 33086
		internal static int __PropertyOffset_RotKeys;

		// Token: 0x0400813F RID: 33087
		[Nullable(2)]
		private TArray<FQuat> _RotKeys;

		// Token: 0x04008140 RID: 33088
		internal static int __PropertyOffset_ScaleKeys;

		// Token: 0x04008141 RID: 33089
		[Nullable(2)]
		private TArray<FVector> _ScaleKeys;

		// Token: 0x04008142 RID: 33090
		internal static int __PropertyOffset_ShearKeys;

		// Token: 0x04008143 RID: 33091
		[Nullable(2)]
		private TArray<FVector> _ShearKeys;

		// Token: 0x04008144 RID: 33092
		internal static int __PropertyOffset_bContainsShear;
	}
}
