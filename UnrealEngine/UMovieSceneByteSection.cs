using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002343 RID: 9027
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneByteSection")]
	[UnrealStructLayout(456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 456)]
	public class UMovieSceneByteSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602220A RID: 139786 RVA: 0x003275D9 File Offset: 0x003257D9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneByteSection._ClassPtr;
		}

		// Token: 0x0602220B RID: 139787 RVA: 0x003275E8 File Offset: 0x003257E8
		public UMovieSceneByteSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneByteSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602220C RID: 139788 RVA: 0x00327610 File Offset: 0x00325810
		public UMovieSceneByteSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneByteSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170083D0 RID: 33744
		// (get) Token: 0x0602220D RID: 139789 RVA: 0x00327644 File Offset: 0x00325844
		// (set) Token: 0x0602220E RID: 139790 RVA: 0x0032767D File Offset: 0x0032587D
		public FMovieSceneByteChannel ByteCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneByteChannel result;
				if ((result = this._ByteCurve) == null)
				{
					result = (this._ByteCurve = new FMovieSceneByteChannel(base.NativePtr + (IntPtr)UMovieSceneByteSection.__PropertyOffset_ByteCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneByteChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneByteSection.__PropertyOffset_ByteCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602220F RID: 139791 RVA: 0x0032769E File Offset: 0x0032589E
		static UMovieSceneByteSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneByteSection");
		}

		// Token: 0x06022210 RID: 139792 RVA: 0x003276AC File Offset: 0x003258AC
		protected UMovieSceneByteSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401236F RID: 74607
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneByteSection";

		// Token: 0x04012370 RID: 74608
		private static IntPtr _ClassPtr;

		// Token: 0x04012371 RID: 74609
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012372 RID: 74610
		internal static int __PropertyOffset_ByteCurve;

		// Token: 0x04012373 RID: 74611
		[Nullable(2)]
		private FMovieSceneByteChannel _ByteCurve;
	}
}
