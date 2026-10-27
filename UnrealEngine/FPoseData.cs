using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200101D RID: 4125
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PoseData")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FPoseData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E1B2 RID: 57778 RVA: 0x0014BABC File Offset: 0x00149CBC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPoseData._ScriptStructPtr != 0) ? FPoseData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PoseData", ref FPoseData._ScriptStructPtr);
		}

		// Token: 0x17003500 RID: 13568
		// (get) Token: 0x0600E1B3 RID: 57779 RVA: 0x0014BAE0 File Offset: 0x00149CE0
		// (set) Token: 0x0600E1B4 RID: 57780 RVA: 0x0014BB23 File Offset: 0x00149D23
		public TArray<FTransform> LocalSpacePose
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._LocalSpacePose) == null)
				{
					result = (this._LocalSpacePose = new TArray<FTransform>(base.NativePtr + (IntPtr)FPoseData.__PropertyOffset_LocalSpacePose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LocalSpacePose.CopyAssign(value);
			}
		}

		// Token: 0x17003501 RID: 13569
		// (get) Token: 0x0600E1B5 RID: 57781 RVA: 0x0014BB34 File Offset: 0x00149D34
		// (set) Token: 0x0600E1B6 RID: 57782 RVA: 0x0014BB77 File Offset: 0x00149D77
		public TMap<int, int> TrackToBufferIndex
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._TrackToBufferIndex) == null)
				{
					result = (this._TrackToBufferIndex = new TMap<int, int>(base.NativePtr + (IntPtr)FPoseData.__PropertyOffset_TrackToBufferIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TrackToBufferIndex.CopyAssign(value);
			}
		}

		// Token: 0x17003502 RID: 13570
		// (get) Token: 0x0600E1B7 RID: 57783 RVA: 0x0014BB88 File Offset: 0x00149D88
		// (set) Token: 0x0600E1B8 RID: 57784 RVA: 0x0014BBCB File Offset: 0x00149DCB
		public TArray<float> CurveData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CurveData) == null)
				{
					result = (this._CurveData = new TArray<float>(base.NativePtr + (IntPtr)FPoseData.__PropertyOffset_CurveData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CurveData.CopyAssign(value);
			}
		}

		// Token: 0x0600E1B9 RID: 57785 RVA: 0x0014BBD9 File Offset: 0x00149DD9
		public FPoseData()
		{
		}

		// Token: 0x0600E1BA RID: 57786 RVA: 0x0014BBE1 File Offset: 0x00149DE1
		public FPoseData(TArray<FTransform> SourceLocalSpacePose, TArray<float> SourceCurveData, TArray<FTransform> LocalSpacePose, TMap<int, int> TrackToBufferIndex, TArray<float> CurveData)
		{
			this.LocalSpacePose = LocalSpacePose;
			this.TrackToBufferIndex = TrackToBufferIndex;
			this.CurveData = CurveData;
		}

		// Token: 0x0600E1BB RID: 57787 RVA: 0x0014BC00 File Offset: 0x00149E00
		protected override IntPtr GetUStructPtr()
		{
			return FPoseData.StaticStruct();
		}

		// Token: 0x0600E1BC RID: 57788 RVA: 0x0014BC0C File Offset: 0x00149E0C
		[NullableContext(2)]
		public FPoseData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E1BD RID: 57789 RVA: 0x0014BC16 File Offset: 0x00149E16
		public FPoseData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E1BE RID: 57790 RVA: 0x0014BC21 File Offset: 0x00149E21
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPoseData(Pointer, false, true);
		}

		// Token: 0x0600E1BF RID: 57791 RVA: 0x0014BC2B File Offset: 0x00149E2B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPoseData(Pointer, MemoryOwner);
		}

		// Token: 0x04007925 RID: 31013
		public const string __ObjectPath = "/Script/Engine.PoseData";

		// Token: 0x04007926 RID: 31014
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007927 RID: 31015
		internal static int __PropertyOffset_LocalSpacePose;

		// Token: 0x04007928 RID: 31016
		[Nullable(2)]
		private TArray<FTransform> _LocalSpacePose;

		// Token: 0x04007929 RID: 31017
		internal static int __PropertyOffset_TrackToBufferIndex;

		// Token: 0x0400792A RID: 31018
		[Nullable(2)]
		private TMap<int, int> _TrackToBufferIndex;

		// Token: 0x0400792B RID: 31019
		internal static int __PropertyOffset_CurveData;

		// Token: 0x0400792C RID: 31020
		[Nullable(2)]
		private TArray<float> _CurveData;
	}
}
