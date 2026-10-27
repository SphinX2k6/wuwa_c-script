using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002338 RID: 9016
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneActorReferenceSection")]
	[UnrealStructLayout(632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 632)]
	public class UMovieSceneActorReferenceSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022187 RID: 139655 RVA: 0x0032692B File Offset: 0x00324B2B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneActorReferenceSection._ClassPtr;
		}

		// Token: 0x06022188 RID: 139656 RVA: 0x00326938 File Offset: 0x00324B38
		public UMovieSceneActorReferenceSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneActorReferenceSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022189 RID: 139657 RVA: 0x00326960 File Offset: 0x00324B60
		public UMovieSceneActorReferenceSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneActorReferenceSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170083B7 RID: 33719
		// (get) Token: 0x0602218A RID: 139658 RVA: 0x00326994 File Offset: 0x00324B94
		// (set) Token: 0x0602218B RID: 139659 RVA: 0x003269CD File Offset: 0x00324BCD
		public FMovieSceneActorReferenceData ActorReferenceData
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneActorReferenceData result;
				if ((result = this._ActorReferenceData) == null)
				{
					result = (this._ActorReferenceData = new FMovieSceneActorReferenceData(base.NativePtr + (IntPtr)UMovieSceneActorReferenceSection.__PropertyOffset_ActorReferenceData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneActorReferenceData.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneActorReferenceSection.__PropertyOffset_ActorReferenceData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170083B8 RID: 33720
		// (get) Token: 0x0602218C RID: 139660 RVA: 0x003269F0 File Offset: 0x00324BF0
		// (set) Token: 0x0602218D RID: 139661 RVA: 0x00326A29 File Offset: 0x00324C29
		public FIntegralCurve ActorGuidIndexCurve_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FIntegralCurve result;
				if ((result = this._ActorGuidIndexCurve_DEPRECATED) == null)
				{
					result = (this._ActorGuidIndexCurve_DEPRECATED = new FIntegralCurve(base.NativePtr + (IntPtr)UMovieSceneActorReferenceSection.__PropertyOffset_ActorGuidIndexCurve_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FIntegralCurve.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneActorReferenceSection.__PropertyOffset_ActorGuidIndexCurve_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170083B9 RID: 33721
		// (get) Token: 0x0602218E RID: 139662 RVA: 0x00326A4C File Offset: 0x00324C4C
		// (set) Token: 0x0602218F RID: 139663 RVA: 0x00326A85 File Offset: 0x00324C85
		public TArray<string> ActorGuidStrings_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ActorGuidStrings_DEPRECATED) == null)
				{
					result = (this._ActorGuidStrings_DEPRECATED = new TArray<string>(base.NativePtr + (IntPtr)UMovieSceneActorReferenceSection.__PropertyOffset_ActorGuidStrings_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				this.ActorGuidStrings_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x06022190 RID: 139664 RVA: 0x00326A93 File Offset: 0x00324C93
		static UMovieSceneActorReferenceSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneActorReferenceSection");
		}

		// Token: 0x06022191 RID: 139665 RVA: 0x00326AA1 File Offset: 0x00324CA1
		protected UMovieSceneActorReferenceSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012328 RID: 74536
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneActorReferenceSection";

		// Token: 0x04012329 RID: 74537
		private static IntPtr _ClassPtr;

		// Token: 0x0401232A RID: 74538
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401232B RID: 74539
		internal static int __PropertyOffset_ActorReferenceData;

		// Token: 0x0401232C RID: 74540
		[Nullable(2)]
		private FMovieSceneActorReferenceData _ActorReferenceData;

		// Token: 0x0401232D RID: 74541
		internal static int __PropertyOffset_ActorGuidIndexCurve_DEPRECATED;

		// Token: 0x0401232E RID: 74542
		[Nullable(2)]
		private FIntegralCurve _ActorGuidIndexCurve_DEPRECATED;

		// Token: 0x0401232F RID: 74543
		internal static int __PropertyOffset_ActorGuidStrings_DEPRECATED;

		// Token: 0x04012330 RID: 74544
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ActorGuidStrings_DEPRECATED;
	}
}
