using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002382 RID: 9090
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneIntegerSection")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UMovieSceneIntegerSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022468 RID: 140392 RVA: 0x0032B06A File Offset: 0x0032926A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneIntegerSection._ClassPtr;
		}

		// Token: 0x06022469 RID: 140393 RVA: 0x0032B078 File Offset: 0x00329278
		public UMovieSceneIntegerSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneIntegerSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602246A RID: 140394 RVA: 0x0032B0A0 File Offset: 0x003292A0
		public UMovieSceneIntegerSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneIntegerSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008434 RID: 33844
		// (get) Token: 0x0602246B RID: 140395 RVA: 0x0032B0D4 File Offset: 0x003292D4
		// (set) Token: 0x0602246C RID: 140396 RVA: 0x0032B10D File Offset: 0x0032930D
		public FMovieSceneIntegerChannel IntegerCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneIntegerChannel result;
				if ((result = this._IntegerCurve) == null)
				{
					result = (this._IntegerCurve = new FMovieSceneIntegerChannel(base.NativePtr + (IntPtr)UMovieSceneIntegerSection.__PropertyOffset_IntegerCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneIntegerChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneIntegerSection.__PropertyOffset_IntegerCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602246D RID: 140397 RVA: 0x0032B12E File Offset: 0x0032932E
		static UMovieSceneIntegerSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneIntegerSection");
		}

		// Token: 0x0602246E RID: 140398 RVA: 0x0032B13C File Offset: 0x0032933C
		protected UMovieSceneIntegerSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124C3 RID: 74947
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneIntegerSection";

		// Token: 0x040124C4 RID: 74948
		private static IntPtr _ClassPtr;

		// Token: 0x040124C5 RID: 74949
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124C6 RID: 74950
		internal static int __PropertyOffset_IntegerCurve;

		// Token: 0x040124C7 RID: 74951
		[Nullable(2)]
		private FMovieSceneIntegerChannel _IntegerCurve;
	}
}
