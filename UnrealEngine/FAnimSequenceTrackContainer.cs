using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200083B RID: 2107
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimSequenceTrackContainer")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAnimSequenceTrackContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007176 RID: 29046 RVA: 0x000A2949 File Offset: 0x000A0B49
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimSequenceTrackContainer._ScriptStructPtr != 0) ? FAnimSequenceTrackContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimSequenceTrackContainer", ref FAnimSequenceTrackContainer._ScriptStructPtr);
		}

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x06007177 RID: 29047 RVA: 0x000A2970 File Offset: 0x000A0B70
		// (set) Token: 0x06007178 RID: 29048 RVA: 0x000A29B3 File Offset: 0x000A0BB3
		public TArray<FRawAnimSequenceTrack> AnimationTracks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRawAnimSequenceTrack> result;
				if ((result = this._AnimationTracks) == null)
				{
					result = (this._AnimationTracks = new TArray<FRawAnimSequenceTrack>(base.NativePtr + (IntPtr)FAnimSequenceTrackContainer.__PropertyOffset_AnimationTracks, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AnimationTracks.CopyAssign(value);
			}
		}

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x06007179 RID: 29049 RVA: 0x000A29C4 File Offset: 0x000A0BC4
		// (set) Token: 0x0600717A RID: 29050 RVA: 0x000A2A07 File Offset: 0x000A0C07
		public TArray<FName> TrackNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TrackNames) == null)
				{
					result = (this._TrackNames = new TArray<FName>(base.NativePtr + (IntPtr)FAnimSequenceTrackContainer.__PropertyOffset_TrackNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TrackNames.CopyAssign(value);
			}
		}

		// Token: 0x0600717B RID: 29051 RVA: 0x000A2A15 File Offset: 0x000A0C15
		public FAnimSequenceTrackContainer()
		{
		}

		// Token: 0x0600717C RID: 29052 RVA: 0x000A2A1D File Offset: 0x000A0C1D
		public FAnimSequenceTrackContainer(TArray<FRawAnimSequenceTrack> AnimationTracks, TArray<FName> TrackNames)
		{
			this.AnimationTracks = AnimationTracks;
			this.TrackNames = TrackNames;
		}

		// Token: 0x0600717D RID: 29053 RVA: 0x000A2A33 File Offset: 0x000A0C33
		protected override IntPtr GetUStructPtr()
		{
			return FAnimSequenceTrackContainer.StaticStruct();
		}

		// Token: 0x0600717E RID: 29054 RVA: 0x000A2A3F File Offset: 0x000A0C3F
		[NullableContext(2)]
		public FAnimSequenceTrackContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600717F RID: 29055 RVA: 0x000A2A49 File Offset: 0x000A0C49
		public FAnimSequenceTrackContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007180 RID: 29056 RVA: 0x000A2A54 File Offset: 0x000A0C54
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimSequenceTrackContainer(Pointer, false, true);
		}

		// Token: 0x06007181 RID: 29057 RVA: 0x000A2A5E File Offset: 0x000A0C5E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimSequenceTrackContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04003685 RID: 13957
		public const string __ObjectPath = "/Script/Engine.AnimSequenceTrackContainer";

		// Token: 0x04003686 RID: 13958
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003687 RID: 13959
		internal static int __PropertyOffset_AnimationTracks;

		// Token: 0x04003688 RID: 13960
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRawAnimSequenceTrack> _AnimationTracks;

		// Token: 0x04003689 RID: 13961
		internal static int __PropertyOffset_TrackNames;

		// Token: 0x0400368A RID: 13962
		[Nullable(2)]
		private TArray<FName> _TrackNames;
	}
}
