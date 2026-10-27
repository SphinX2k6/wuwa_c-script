using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200242E RID: 9262
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSequence")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UMovieSceneSequence : UMovieSceneSignedObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022B35 RID: 142133 RVA: 0x00335290 File Offset: 0x00333490
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSequence._ClassPtr;
		}

		// Token: 0x06022B36 RID: 142134 RVA: 0x0033529C File Offset: 0x0033349C
		public UMovieSceneSequence() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSequence.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022B37 RID: 142135 RVA: 0x003352C4 File Offset: 0x003334C4
		public UMovieSceneSequence(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSequence.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008580 RID: 34176
		// (get) Token: 0x06022B38 RID: 142136 RVA: 0x003352F7 File Offset: 0x003334F7
		// (set) Token: 0x06022B39 RID: 142137 RVA: 0x0033530B File Offset: 0x0033350B
		[Nullable(2)]
		public unsafe UMovieSceneCompiledData CompiledData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneCompiledData>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneSequence.__PropertyOffset_CompiledData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneSequence.__PropertyOffset_CompiledData, value);
			}
		}

		// Token: 0x17008581 RID: 34177
		// (get) Token: 0x06022B3A RID: 142138 RVA: 0x00335320 File Offset: 0x00333520
		// (set) Token: 0x06022B3B RID: 142139 RVA: 0x00335330 File Offset: 0x00333530
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

		// Token: 0x17008582 RID: 34178
		// (get) Token: 0x06022B3C RID: 142140 RVA: 0x00335341 File Offset: 0x00333541
		// (set) Token: 0x06022B3D RID: 142141 RVA: 0x00335351 File Offset: 0x00333551
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

		// Token: 0x17008583 RID: 34179
		// (get) Token: 0x06022B3E RID: 142142 RVA: 0x00335362 File Offset: 0x00333562
		// (set) Token: 0x06022B3F RID: 142143 RVA: 0x00335372 File Offset: 0x00333572
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

		// Token: 0x17008584 RID: 34180
		// (get) Token: 0x06022B40 RID: 142144 RVA: 0x00335383 File Offset: 0x00333583
		// (set) Token: 0x06022B41 RID: 142145 RVA: 0x00335393 File Offset: 0x00333593
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

		// Token: 0x06022B42 RID: 142146 RVA: 0x003353A4 File Offset: 0x003335A4
		public bool HasMasterTrackTag(FName InTrackTagName, bool IncludeSubSequence)
		{
			return UMovieSceneSequence.__HasMasterTrackTag_Internal(base.NativePtr, InTrackTagName, IncludeSubSequence);
		}

		// Token: 0x06022B43 RID: 142147 RVA: 0x003353B3 File Offset: 0x003335B3
		public bool HasBindingTag(FName InBindingName, bool IncludeSubSequence)
		{
			return UMovieSceneSequence.__HasBindingTag_Internal(base.NativePtr, InBindingName, IncludeSubSequence);
		}

		// Token: 0x06022B44 RID: 142148 RVA: 0x003353C2 File Offset: 0x003335C2
		public TArray<UMovieSceneTrack> FindMasterTracksByTag(FName InTrackTagName)
		{
			return new TArray<UMovieSceneTrack>(UMovieSceneSequence.__FindMasterTracksByTag_Internal(base.NativePtr, InTrackTagName), null);
		}

		// Token: 0x06022B45 RID: 142149 RVA: 0x003353D6 File Offset: 0x003335D6
		public TArray<UMovieSceneTrack> FindMasterTracksByBothTags([Nullable(2)] TArray<FName> InTrackTagNames)
		{
			return new TArray<UMovieSceneTrack>(UMovieSceneSequence.__FindMasterTracksByBothTags_Internal(base.NativePtr, (InTrackTagNames ?? new TArray<FName>()).NativePtr), null);
		}

		// Token: 0x06022B46 RID: 142150 RVA: 0x003353F8 File Offset: 0x003335F8
		[NullableContext(2)]
		public UMovieSceneTrack FindMasterTrackByTag(FName InTrackTagName)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMovieSceneTrack>(UMovieSceneSequence.__FindMasterTrackByTag_Internal(base.NativePtr, InTrackTagName));
		}

		// Token: 0x06022B47 RID: 142151 RVA: 0x0033540B File Offset: 0x0033360B
		public TArray<FMovieSceneObjectBindingID> FindBindingsByTag(FName InBindingName)
		{
			return new TArray<FMovieSceneObjectBindingID>(UMovieSceneSequence.__FindBindingsByTag_Internal(base.NativePtr, InBindingName), null);
		}

		// Token: 0x06022B48 RID: 142152 RVA: 0x0033541F File Offset: 0x0033361F
		public TArray<FMovieSceneObjectBindingID> FindBindingsByBothTags([Nullable(2)] TArray<FName> InBindingNames)
		{
			return new TArray<FMovieSceneObjectBindingID>(UMovieSceneSequence.__FindBindingsByBothTags_Internal(base.NativePtr, (InBindingNames ?? new TArray<FName>()).NativePtr), null);
		}

		// Token: 0x06022B49 RID: 142153 RVA: 0x00335441 File Offset: 0x00333641
		public FMovieSceneObjectBindingID FindBindingByTag(FName InBindingName)
		{
			return new FMovieSceneObjectBindingID(UMovieSceneSequence.__FindBindingByTag_Internal(base.NativePtr, InBindingName), null);
		}

		// Token: 0x06022B4A RID: 142154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasMasterTrackTag_Internal(IntPtr @this, FName InTrackTagName, bool IncludeSubSequence);

		// Token: 0x06022B4B RID: 142155
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasBindingTag_Internal(IntPtr @this, FName InBindingName, bool IncludeSubSequence);

		// Token: 0x06022B4C RID: 142156
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindMasterTracksByTag_Internal(IntPtr @this, FName InTrackTagName);

		// Token: 0x06022B4D RID: 142157
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindMasterTracksByBothTags_Internal(IntPtr @this, IntPtr InTrackTagNames);

		// Token: 0x06022B4E RID: 142158
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindMasterTrackByTag_Internal(IntPtr @this, FName InTrackTagName);

		// Token: 0x06022B4F RID: 142159
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindBindingsByTag_Internal(IntPtr @this, FName InBindingName);

		// Token: 0x06022B50 RID: 142160
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindBindingsByBothTags_Internal(IntPtr @this, IntPtr InBindingNames);

		// Token: 0x06022B51 RID: 142161
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindBindingByTag_Internal(IntPtr @this, FName InBindingName);

		// Token: 0x06022B52 RID: 142162 RVA: 0x00335455 File Offset: 0x00333655
		static UMovieSceneSequence()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneSequence");
		}

		// Token: 0x06022B53 RID: 142163 RVA: 0x00335463 File Offset: 0x00333663
		protected UMovieSceneSequence(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040128A1 RID: 75937
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneSequence";

		// Token: 0x040128A2 RID: 75938
		private static IntPtr _ClassPtr;

		// Token: 0x040128A3 RID: 75939
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040128A4 RID: 75940
		internal static int __PropertyOffset_CompiledData;

		// Token: 0x040128A5 RID: 75941
		internal static int __PropertyOffset_DefaultCompletionMode;

		// Token: 0x040128A6 RID: 75942
		internal static int __PropertyOffset_bParentContextsAreSignificant;

		// Token: 0x040128A7 RID: 75943
		internal static int __PropertyOffset_bPlayableDirectly;

		// Token: 0x040128A8 RID: 75944
		internal static int __PropertyOffset_SequenceFlags;
	}
}
