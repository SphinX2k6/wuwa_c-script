using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002465 RID: 9317
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.TestMovieSceneSubTrack")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UTestMovieSceneSubTrack : UMovieSceneSubTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022E41 RID: 142913 RVA: 0x0033960A File Offset: 0x0033780A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestMovieSceneSubTrack._ClassPtr;
		}

		// Token: 0x06022E42 RID: 142914 RVA: 0x00339618 File Offset: 0x00337818
		public UTestMovieSceneSubTrack() : this(BuiltinUtils.AllocNativeUObject(UTestMovieSceneSubTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022E43 RID: 142915 RVA: 0x00339640 File Offset: 0x00337840
		public UTestMovieSceneSubTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestMovieSceneSubTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008611 RID: 34321
		// (get) Token: 0x06022E44 RID: 142916 RVA: 0x00339674 File Offset: 0x00337874
		// (set) Token: 0x06022E45 RID: 142917 RVA: 0x003396AD File Offset: 0x003378AD
		public TArray<UMovieSceneSection> SectionArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._SectionArray) == null)
				{
					result = (this._SectionArray = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UTestMovieSceneSubTrack.__PropertyOffset_SectionArray, this));
				}
				return result;
			}
			set
			{
				this.SectionArray.CopyAssign(value);
			}
		}

		// Token: 0x06022E46 RID: 142918 RVA: 0x003396BB File Offset: 0x003378BB
		static UTestMovieSceneSubTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.TestMovieSceneSubTrack");
		}

		// Token: 0x06022E47 RID: 142919 RVA: 0x003396C9 File Offset: 0x003378C9
		protected UTestMovieSceneSubTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A02 RID: 76290
		public new const string __ObjectPath = "/Script/MovieScene.TestMovieSceneSubTrack";

		// Token: 0x04012A03 RID: 76291
		private static IntPtr _ClassPtr;

		// Token: 0x04012A04 RID: 76292
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012A05 RID: 76293
		internal static int __PropertyOffset_SectionArray;

		// Token: 0x04012A06 RID: 76294
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _SectionArray;
	}
}
