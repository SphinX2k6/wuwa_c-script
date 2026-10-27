using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002441 RID: 9281
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSubSection")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UMovieSceneSubSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022CBC RID: 142524 RVA: 0x003372EB File Offset: 0x003354EB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSubSection._ClassPtr;
		}

		// Token: 0x06022CBD RID: 142525 RVA: 0x003372F8 File Offset: 0x003354F8
		public UMovieSceneSubSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSubSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022CBE RID: 142526 RVA: 0x00337320 File Offset: 0x00335520
		public UMovieSceneSubSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSubSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170085CA RID: 34250
		// (get) Token: 0x06022CBF RID: 142527 RVA: 0x00337354 File Offset: 0x00335554
		// (set) Token: 0x06022CC0 RID: 142528 RVA: 0x0033738D File Offset: 0x0033558D
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

		// Token: 0x170085CB RID: 34251
		// (get) Token: 0x06022CC1 RID: 142529 RVA: 0x003373AE File Offset: 0x003355AE
		// (set) Token: 0x06022CC2 RID: 142530 RVA: 0x003373BE File Offset: 0x003355BE
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

		// Token: 0x170085CC RID: 34252
		// (get) Token: 0x06022CC3 RID: 142531 RVA: 0x003373CF File Offset: 0x003355CF
		// (set) Token: 0x06022CC4 RID: 142532 RVA: 0x003373DF File Offset: 0x003355DF
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

		// Token: 0x170085CD RID: 34253
		// (get) Token: 0x06022CC5 RID: 142533 RVA: 0x003373F0 File Offset: 0x003355F0
		// (set) Token: 0x06022CC6 RID: 142534 RVA: 0x00337400 File Offset: 0x00335600
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

		// Token: 0x170085CE RID: 34254
		// (get) Token: 0x06022CC7 RID: 142535 RVA: 0x00337411 File Offset: 0x00335611
		// (set) Token: 0x06022CC8 RID: 142536 RVA: 0x00337425 File Offset: 0x00335625
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

		// Token: 0x170085CF RID: 34255
		// (get) Token: 0x06022CC9 RID: 142537 RVA: 0x0033743A File Offset: 0x0033563A
		// (set) Token: 0x06022CCA RID: 142538 RVA: 0x0033744E File Offset: 0x0033564E
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

		// Token: 0x170085D0 RID: 34256
		// (get) Token: 0x06022CCB RID: 142539 RVA: 0x00337463 File Offset: 0x00335663
		// (set) Token: 0x06022CCC RID: 142540 RVA: 0x00337477 File Offset: 0x00335677
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

		// Token: 0x170085D1 RID: 34257
		// (get) Token: 0x06022CCD RID: 142541 RVA: 0x0033748C File Offset: 0x0033568C
		// (set) Token: 0x06022CCE RID: 142542 RVA: 0x003374C5 File Offset: 0x003356C5
		public FDirectoryPath TargetPathToRecordTo
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._TargetPathToRecordTo) == null)
				{
					result = (this._TargetPathToRecordTo = new FDirectoryPath(base.NativePtr + (IntPtr)UMovieSceneSubSection.__PropertyOffset_TargetPathToRecordTo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneSubSection.__PropertyOffset_TargetPathToRecordTo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022CCF RID: 142543 RVA: 0x003374E6 File Offset: 0x003356E6
		[NullableContext(2)]
		public void SetSequence(UMovieSceneSequence Sequence)
		{
			UMovieSceneSubSection.__SetSequence_Internal(base.NativePtr, (Sequence != null) ? Sequence.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06022CD0 RID: 142544 RVA: 0x00337503 File Offset: 0x00335703
		[NullableContext(2)]
		public UMovieSceneSequence GetSequence()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMovieSceneSequence>(UMovieSceneSubSection.__GetSequence_Internal(base.NativePtr));
		}

		// Token: 0x06022CD1 RID: 142545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSequence_Internal(IntPtr @this, IntPtr Sequence);

		// Token: 0x06022CD2 RID: 142546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSequence_Internal(IntPtr @this);

		// Token: 0x06022CD3 RID: 142547 RVA: 0x00337515 File Offset: 0x00335715
		static UMovieSceneSubSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneSubSection");
		}

		// Token: 0x06022CD4 RID: 142548 RVA: 0x00337523 File Offset: 0x00335723
		protected UMovieSceneSubSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012942 RID: 76098
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneSubSection";

		// Token: 0x04012943 RID: 76099
		private static IntPtr _ClassPtr;

		// Token: 0x04012944 RID: 76100
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012945 RID: 76101
		internal static int __PropertyOffset_Parameters;

		// Token: 0x04012946 RID: 76102
		[Nullable(2)]
		private FMovieSceneSectionParameters _Parameters;

		// Token: 0x04012947 RID: 76103
		internal static int __PropertyOffset_StartOffset_DEPRECATED;

		// Token: 0x04012948 RID: 76104
		internal static int __PropertyOffset_TimeScale_DEPRECATED;

		// Token: 0x04012949 RID: 76105
		internal static int __PropertyOffset_PrerollTime_DEPRECATED;

		// Token: 0x0401294A RID: 76106
		internal static int __PropertyOffset_SubSequence;

		// Token: 0x0401294B RID: 76107
		internal static int __PropertyOffset_ActorToRecord;

		// Token: 0x0401294C RID: 76108
		internal static int __PropertyOffset_TargetSequenceName;

		// Token: 0x0401294D RID: 76109
		internal static int __PropertyOffset_TargetPathToRecordTo;

		// Token: 0x0401294E RID: 76110
		[Nullable(2)]
		private FDirectoryPath _TargetPathToRecordTo;
	}
}
