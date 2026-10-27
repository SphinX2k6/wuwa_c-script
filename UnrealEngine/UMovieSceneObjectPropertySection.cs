using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200238D RID: 9101
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneObjectPropertySection")]
	[UnrealStructLayout(504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 504)]
	public class UMovieSceneObjectPropertySection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060224CE RID: 140494 RVA: 0x0032B967 File Offset: 0x00329B67
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneObjectPropertySection._ClassPtr;
		}

		// Token: 0x060224CF RID: 140495 RVA: 0x0032B974 File Offset: 0x00329B74
		public UMovieSceneObjectPropertySection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneObjectPropertySection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060224D0 RID: 140496 RVA: 0x0032B99C File Offset: 0x00329B9C
		public UMovieSceneObjectPropertySection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneObjectPropertySection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008441 RID: 33857
		// (get) Token: 0x060224D1 RID: 140497 RVA: 0x0032B9D0 File Offset: 0x00329BD0
		// (set) Token: 0x060224D2 RID: 140498 RVA: 0x0032BA09 File Offset: 0x00329C09
		public FMovieSceneObjectPathChannel ObjectChannel
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneObjectPathChannel result;
				if ((result = this._ObjectChannel) == null)
				{
					result = (this._ObjectChannel = new FMovieSceneObjectPathChannel(base.NativePtr + (IntPtr)UMovieSceneObjectPropertySection.__PropertyOffset_ObjectChannel, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneObjectPathChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneObjectPropertySection.__PropertyOffset_ObjectChannel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060224D3 RID: 140499 RVA: 0x0032BA2A File Offset: 0x00329C2A
		static UMovieSceneObjectPropertySection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneObjectPropertySection");
		}

		// Token: 0x060224D4 RID: 140500 RVA: 0x0032BA38 File Offset: 0x00329C38
		protected UMovieSceneObjectPropertySection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124F8 RID: 75000
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneObjectPropertySection";

		// Token: 0x040124F9 RID: 75001
		private static IntPtr _ClassPtr;

		// Token: 0x040124FA RID: 75002
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124FB RID: 75003
		internal static int __PropertyOffset_ObjectChannel;

		// Token: 0x040124FC RID: 75004
		[Nullable(2)]
		private FMovieSceneObjectPathChannel _ObjectChannel;
	}
}
