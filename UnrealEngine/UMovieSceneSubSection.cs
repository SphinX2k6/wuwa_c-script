using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000790 RID: 1936
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSubSection")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UMovieSceneSubSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A756 RID: 42838 RVA: 0x000F6FBF File Offset: 0x000F51BF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSubSection._ClassPtr;
		}

		// Token: 0x0600A757 RID: 42839 RVA: 0x000F6FCC File Offset: 0x000F51CC
		public UMovieSceneSubSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSubSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A758 RID: 42840 RVA: 0x000F6FF4 File Offset: 0x000F51F4
		public UMovieSceneSubSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSubSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x0600A759 RID: 42841 RVA: 0x000F7028 File Offset: 0x000F5228
		// (set) Token: 0x0600A75A RID: 42842 RVA: 0x000F7061 File Offset: 0x000F5261
		public FMovieSceneSectionParameters Parameters
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSectionParameters result;
				if ((result = this._Parameters) == null)
				{
					result = (this._Parameters = new FMovieSceneSectionParameters(base.NativePtr + (IntPtr)UMovieSceneSubSection.__PropertyOffset_Parameters, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSectionParameters.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneSubSection.__PropertyOffset_Parameters, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x0600A75B RID: 42843 RVA: 0x000F7082 File Offset: 0x000F5282
		// (set) Token: 0x0600A75C RID: 42844 RVA: 0x000F7092 File Offset: 0x000F5292
		public unsafe float StartOffset_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSubSection.__PropertyOffset_StartOffset_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSubSection.__PropertyOffset_StartOffset_DEPRECATED) = value;
			}
		}

		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x0600A75D RID: 42845 RVA: 0x000F70A3 File Offset: 0x000F52A3
		// (set) Token: 0x0600A75E RID: 42846 RVA: 0x000F70B3 File Offset: 0x000F52B3
		public unsafe float TimeScale_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSubSection.__PropertyOffset_TimeScale_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSubSection.__PropertyOffset_TimeScale_DEPRECATED) = value;
			}
		}

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x0600A75F RID: 42847 RVA: 0x000F70C4 File Offset: 0x000F52C4
		// (set) Token: 0x0600A760 RID: 42848 RVA: 0x000F70D4 File Offset: 0x000F52D4
		public unsafe float PrerollTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSubSection.__PropertyOffset_PrerollTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSubSection.__PropertyOffset_PrerollTime_DEPRECATED) = value;
			}
		}

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x0600A761 RID: 42849 RVA: 0x000F70E5 File Offset: 0x000F52E5
		// (set) Token: 0x0600A762 RID: 42850 RVA: 0x000F70F9 File Offset: 0x000F52F9
		[Nullable(2)]
		public unsafe UMovieSceneSequence SubSequence
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneSequence>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneSubSection.__PropertyOffset_SubSequence);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneSubSection.__PropertyOffset_SubSequence, value);
			}
		}

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x0600A763 RID: 42851 RVA: 0x000F710E File Offset: 0x000F530E
		// (set) Token: 0x0600A764 RID: 42852 RVA: 0x000F7122 File Offset: 0x000F5322
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TLazyObjectPtr<AActor> ActorToRecord
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSubSection.__PropertyOffset_ActorToRecord);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSubSection.__PropertyOffset_ActorToRecord) = value;
			}
		}

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x0600A765 RID: 42853 RVA: 0x000F7137 File Offset: 0x000F5337
		// (set) Token: 0x0600A766 RID: 42854 RVA: 0x000F714B File Offset: 0x000F534B
		public unsafe string TargetSequenceName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneSubSection.__PropertyOffset_TargetSequenceName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneSubSection.__PropertyOffset_TargetSequenceName)), value);
			}
		}

		// Token: 0x0600A767 RID: 42855 RVA: 0x000F7160 File Offset: 0x000F5360
		[NullableContext(2)]
		public void SetSequence(UMovieSceneSequence Sequence)
		{
			UMovieSceneSubSection.__SetSequence_Internal(base.NativePtr, (Sequence != null) ? Sequence.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A768 RID: 42856 RVA: 0x000F717D File Offset: 0x000F537D
		[NullableContext(2)]
		public UMovieSceneSequence GetSequence()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMovieSceneSequence>(UMovieSceneSubSection.__GetSequence_Internal(base.NativePtr));
		}

		// Token: 0x0600A769 RID: 42857
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSequence_Internal(IntPtr @this, IntPtr Sequence);

		// Token: 0x0600A76A RID: 42858
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSequence_Internal(IntPtr @this);

		// Token: 0x0600A76B RID: 42859 RVA: 0x000F718F File Offset: 0x000F538F
		static UMovieSceneSubSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneSubSection");
		}

		// Token: 0x0600A76C RID: 42860 RVA: 0x000F719D File Offset: 0x000F539D
		protected UMovieSceneSubSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040047AA RID: 18346
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneSubSection";

		// Token: 0x040047AB RID: 18347
		private static IntPtr _ClassPtr;

		// Token: 0x040047AC RID: 18348
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040047AD RID: 18349
		internal static int __PropertyOffset_Parameters;

		// Token: 0x040047AE RID: 18350
		[Nullable(2)]
		private FMovieSceneSectionParameters _Parameters;

		// Token: 0x040047AF RID: 18351
		internal static int __PropertyOffset_StartOffset_DEPRECATED;

		// Token: 0x040047B0 RID: 18352
		internal static int __PropertyOffset_TimeScale_DEPRECATED;

		// Token: 0x040047B1 RID: 18353
		internal static int __PropertyOffset_PrerollTime_DEPRECATED;

		// Token: 0x040047B2 RID: 18354
		internal static int __PropertyOffset_SubSequence;

		// Token: 0x040047B3 RID: 18355
		internal static int __PropertyOffset_ActorToRecord;

		// Token: 0x040047B4 RID: 18356
		internal static int __PropertyOffset_TargetSequenceName;
	}
}
