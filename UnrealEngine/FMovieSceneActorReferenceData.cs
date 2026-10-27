using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002336 RID: 9014
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneActorReferenceData")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FMovieSceneActorReferenceData : FMovieSceneChannel, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602216D RID: 139629 RVA: 0x003266DA File Offset: 0x003248DA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneActorReferenceData._ScriptStructPtr != 0) ? FMovieSceneActorReferenceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneActorReferenceData", ref FMovieSceneActorReferenceData._ScriptStructPtr);
		}

		// Token: 0x170083B2 RID: 33714
		// (get) Token: 0x0602216E RID: 139630 RVA: 0x00326700 File Offset: 0x00324900
		// (set) Token: 0x0602216F RID: 139631 RVA: 0x00326743 File Offset: 0x00324943
		public TArray<FFrameNumber> KeyTimes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFrameNumber> result;
				if ((result = this._KeyTimes) == null)
				{
					result = (this._KeyTimes = new TArray<FFrameNumber>(base.NativePtr + (IntPtr)FMovieSceneActorReferenceData.__PropertyOffset_KeyTimes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KeyTimes.CopyAssign(value);
			}
		}

		// Token: 0x170083B3 RID: 33715
		// (get) Token: 0x06022170 RID: 139632 RVA: 0x00326754 File Offset: 0x00324954
		// (set) Token: 0x06022171 RID: 139633 RVA: 0x00326797 File Offset: 0x00324997
		public TArray<FMovieSceneActorReferenceKey> KeyValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneActorReferenceKey> result;
				if ((result = this._KeyValues) == null)
				{
					result = (this._KeyValues = new TArray<FMovieSceneActorReferenceKey>(base.NativePtr + (IntPtr)FMovieSceneActorReferenceData.__PropertyOffset_KeyValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KeyValues.CopyAssign(value);
			}
		}

		// Token: 0x06022172 RID: 139634 RVA: 0x003267A5 File Offset: 0x003249A5
		public FMovieSceneActorReferenceData()
		{
		}

		// Token: 0x06022173 RID: 139635 RVA: 0x003267AD File Offset: 0x003249AD
		public FMovieSceneActorReferenceData(TArray<FFrameNumber> KeyTimes, TArray<FMovieSceneActorReferenceKey> KeyValues)
		{
			this.KeyTimes = KeyTimes;
			this.KeyValues = KeyValues;
		}

		// Token: 0x06022174 RID: 139636 RVA: 0x003267C3 File Offset: 0x003249C3
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneActorReferenceData.StaticStruct();
		}

		// Token: 0x06022175 RID: 139637 RVA: 0x003267CF File Offset: 0x003249CF
		[NullableContext(2)]
		public FMovieSceneActorReferenceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022176 RID: 139638 RVA: 0x003267D9 File Offset: 0x003249D9
		public FMovieSceneActorReferenceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022177 RID: 139639 RVA: 0x003267E4 File Offset: 0x003249E4
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneActorReferenceData(Pointer, false, true);
		}

		// Token: 0x06022178 RID: 139640 RVA: 0x003267EE File Offset: 0x003249EE
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneActorReferenceData(Pointer, MemoryOwner);
		}

		// Token: 0x0401231C RID: 74524
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneActorReferenceData";

		// Token: 0x0401231D RID: 74525
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401231E RID: 74526
		internal static int __PropertyOffset_KeyTimes;

		// Token: 0x0401231F RID: 74527
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFrameNumber> _KeyTimes;

		// Token: 0x04012320 RID: 74528
		internal static int __PropertyOffset_KeyValues;

		// Token: 0x04012321 RID: 74529
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneActorReferenceKey> _KeyValues;
	}
}
