using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002367 RID: 9063
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEnumSection")]
	[UnrealStructLayout(456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 456)]
	public class UMovieSceneEnumSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602237E RID: 140158 RVA: 0x003299E1 File Offset: 0x00327BE1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneEnumSection._ClassPtr;
		}

		// Token: 0x0602237F RID: 140159 RVA: 0x003299F0 File Offset: 0x00327BF0
		public UMovieSceneEnumSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEnumSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022380 RID: 140160 RVA: 0x00329A18 File Offset: 0x00327C18
		public UMovieSceneEnumSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEnumSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008414 RID: 33812
		// (get) Token: 0x06022381 RID: 140161 RVA: 0x00329A4C File Offset: 0x00327C4C
		// (set) Token: 0x06022382 RID: 140162 RVA: 0x00329A85 File Offset: 0x00327C85
		public FMovieSceneByteChannel EnumCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneByteChannel result;
				if ((result = this._EnumCurve) == null)
				{
					result = (this._EnumCurve = new FMovieSceneByteChannel(base.NativePtr + (IntPtr)UMovieSceneEnumSection.__PropertyOffset_EnumCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneByteChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneEnumSection.__PropertyOffset_EnumCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022383 RID: 140163 RVA: 0x00329AA6 File Offset: 0x00327CA6
		static UMovieSceneEnumSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneEnumSection");
		}

		// Token: 0x06022384 RID: 140164 RVA: 0x00329AB4 File Offset: 0x00327CB4
		protected UMovieSceneEnumSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401243F RID: 74815
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEnumSection";

		// Token: 0x04012440 RID: 74816
		private static IntPtr _ClassPtr;

		// Token: 0x04012441 RID: 74817
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012442 RID: 74818
		internal static int __PropertyOffset_EnumCurve;

		// Token: 0x04012443 RID: 74819
		[Nullable(2)]
		private FMovieSceneByteChannel _EnumCurve;
	}
}
