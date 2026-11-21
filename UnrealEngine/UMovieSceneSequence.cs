using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000789 RID: 1929
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSequence")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UMovieSceneSequence : UMovieSceneSignedObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A65E RID: 42590 RVA: 0x000F5D81 File Offset: 0x000F3F81
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSequence._ClassPtr;
		}

		// Token: 0x0600A65F RID: 42591 RVA: 0x000F5D90 File Offset: 0x000F3F90
		public UMovieSceneSequence() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSequence.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A660 RID: 42592 RVA: 0x000F5DB8 File Offset: 0x000F3FB8
		public UMovieSceneSequence(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSequence.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x0600A661 RID: 42593 RVA: 0x000F5DEB File Offset: 0x000F3FEB
		// (set) Token: 0x0600A662 RID: 42594 RVA: 0x000F5DFB File Offset: 0x000F3FFB
		public unsafe EMovieSceneCompletionMode DefaultCompletionMode
		{
			get
			{
				return (EMovieSceneCompletionMode)(*(base.NativePtr + (IntPtr)UMovieSceneSequence.__PropertyOffset_DefaultCompletionMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSequence.__PropertyOffset_DefaultCompletionMode) = (byte)value;
			}
		}

		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x0600A663 RID: 42595 RVA: 0x000F5E0C File Offset: 0x000F400C
		// (set) Token: 0x0600A664 RID: 42596 RVA: 0x000F5E1C File Offset: 0x000F401C
		public unsafe bool bParentContextsAreSignificant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSequence.__PropertyOffset_bParentContextsAreSignificant) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSequence.__PropertyOffset_bParentContextsAreSignificant) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x0600A665 RID: 42597 RVA: 0x000F5E2D File Offset: 0x000F402D
		// (set) Token: 0x0600A666 RID: 42598 RVA: 0x000F5E3D File Offset: 0x000F403D
		public unsafe bool bPlayableDirectly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSequence.__PropertyOffset_bPlayableDirectly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSequence.__PropertyOffset_bPlayableDirectly) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x0600A667 RID: 42599 RVA: 0x000F5E4E File Offset: 0x000F404E
		// (set) Token: 0x0600A668 RID: 42600 RVA: 0x000F5E5E File Offset: 0x000F405E
		public unsafe EMovieSceneSequenceFlags SequenceFlags
		{
			get
			{
				return (EMovieSceneSequenceFlags)(*(base.NativePtr + (IntPtr)UMovieSceneSequence.__PropertyOffset_SequenceFlags));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSequence.__PropertyOffset_SequenceFlags) = (byte)value;
			}
		}

		// Token: 0x0600A669 RID: 42601 RVA: 0x000F5E6F File Offset: 0x000F406F
		public bool HasMasterTrackTag(FName InTrackTagName, bool IncludeSubSequence)
		{
			return UMovieSceneSequence.__HasMasterTrackTag_Internal(base.NativePtr, InTrackTagName, IncludeSubSequence);
		}

		// Token: 0x0600A66A RID: 42602 RVA: 0x000F5E7E File Offset: 0x000F407E
		public bool HasBindingTag(FName InBindingName, bool IncludeSubSequence)
		{
			return UMovieSceneSequence.__HasBindingTag_Internal(base.NativePtr, InBindingName, IncludeSubSequence);
		}

		// Token: 0x0600A66B RID: 42603 RVA: 0x000F5E8D File Offset: 0x000F408D
		public TArray<UMovieSceneTrack> FindMasterTracksByTag(FName InTrackTagName)
		{
			return new TArray<UMovieSceneTrack>(UMovieSceneSequence.__FindMasterTracksByTag_Internal(base.NativePtr, InTrackTagName), null);
		}

		// Token: 0x0600A66C RID: 42604 RVA: 0x000F5EA1 File Offset: 0x000F40A1
		public TArray<UMovieSceneTrack> FindMasterTracksByBothTags([Nullable(2)] TArray<FName> InTrackTagNames)
		{
			return new TArray<UMovieSceneTrack>(UMovieSceneSequence.__FindMasterTracksByBothTags_Internal(base.NativePtr, (InTrackTagNames ?? new TArray<FName>()).NativePtr), null);
		}

		// Token: 0x0600A66D RID: 42605 RVA: 0x000F5EC3 File Offset: 0x000F40C3
		[NullableContext(2)]
		public UMovieSceneTrack FindMasterTrackByTag(FName InTrackTagName)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMovieSceneTrack>(UMovieSceneSequence.__FindMasterTrackByTag_Internal(base.NativePtr, InTrackTagName));
		}

		// Token: 0x0600A66E RID: 42606 RVA: 0x000F5ED6 File Offset: 0x000F40D6
		public TArray<FMovieSceneObjectBindingID> FindBindingsByTag(FName InBindingName)
		{
			return new TArray<FMovieSceneObjectBindingID>(UMovieSceneSequence.__FindBindingsByTag_Internal(base.NativePtr, InBindingName), null);
		}

		// Token: 0x0600A66F RID: 42607 RVA: 0x000F5EEA File Offset: 0x000F40EA
		public TArray<FMovieSceneObjectBindingID> FindBindingsByBothTags([Nullable(2)] TArray<FName> InBindingNames)
		{
			return new TArray<FMovieSceneObjectBindingID>(UMovieSceneSequence.__FindBindingsByBothTags_Internal(base.NativePtr, (InBindingNames ?? new TArray<FName>()).NativePtr), null);
		}

		// Token: 0x0600A670 RID: 42608 RVA: 0x000F5F0C File Offset: 0x000F410C
		public FMovieSceneObjectBindingID FindBindingByTag(FName InBindingName)
		{
			return new FMovieSceneObjectBindingID(UMovieSceneSequence.__FindBindingByTag_Internal(base.NativePtr, InBindingName), null);
		}

		// Token: 0x0600A671 RID: 42609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasMasterTrackTag_Internal(IntPtr @this, FName InTrackTagName, bool IncludeSubSequence);

		// Token: 0x0600A672 RID: 42610
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasBindingTag_Internal(IntPtr @this, FName InBindingName, bool IncludeSubSequence);

		// Token: 0x0600A673 RID: 42611
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindMasterTracksByTag_Internal(IntPtr @this, FName InTrackTagName);

		// Token: 0x0600A674 RID: 42612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindMasterTracksByBothTags_Internal(IntPtr @this, IntPtr InTrackTagNames);

		// Token: 0x0600A675 RID: 42613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindMasterTrackByTag_Internal(IntPtr @this, FName InTrackTagName);

		// Token: 0x0600A676 RID: 42614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindBindingsByTag_Internal(IntPtr @this, FName InBindingName);

		// Token: 0x0600A677 RID: 42615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindBindingsByBothTags_Internal(IntPtr @this, IntPtr InBindingNames);

		// Token: 0x0600A678 RID: 42616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindBindingByTag_Internal(IntPtr @this, FName InBindingName);

		// Token: 0x0600A679 RID: 42617 RVA: 0x000F5F20 File Offset: 0x000F4120
		static UMovieSceneSequence()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneSequence");
		}

		// Token: 0x0600A67A RID: 42618 RVA: 0x000F5F2E File Offset: 0x000F412E
		protected UMovieSceneSequence(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004753 RID: 18259
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneSequence";

		// Token: 0x04004754 RID: 18260
		private static IntPtr _ClassPtr;

		// Token: 0x04004755 RID: 18261
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004756 RID: 18262
		internal static int __PropertyOffset_DefaultCompletionMode;

		// Token: 0x04004757 RID: 18263
		internal static int __PropertyOffset_bParentContextsAreSignificant;

		// Token: 0x04004758 RID: 18264
		internal static int __PropertyOffset_bPlayableDirectly;

		// Token: 0x04004759 RID: 18265
		internal static int __PropertyOffset_SequenceFlags;
	}
}
