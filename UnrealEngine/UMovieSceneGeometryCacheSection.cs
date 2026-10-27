using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001408 RID: 5128
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCacheTracks.MovieSceneGeometryCacheSection")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class UMovieSceneGeometryCacheSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012B93 RID: 76691 RVA: 0x001B8F54 File Offset: 0x001B7154
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneGeometryCacheSection._ClassPtr;
		}

		// Token: 0x06012B94 RID: 76692 RVA: 0x001B8F60 File Offset: 0x001B7160
		public UMovieSceneGeometryCacheSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneGeometryCacheSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012B95 RID: 76693 RVA: 0x001B8F88 File Offset: 0x001B7188
		public UMovieSceneGeometryCacheSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneGeometryCacheSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004898 RID: 18584
		// (get) Token: 0x06012B96 RID: 76694 RVA: 0x001B8FBC File Offset: 0x001B71BC
		// (set) Token: 0x06012B97 RID: 76695 RVA: 0x001B8FF5 File Offset: 0x001B71F5
		public FMovieSceneGeometryCacheParams Params
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneGeometryCacheParams result;
				if ((result = this._Params) == null)
				{
					result = (this._Params = new FMovieSceneGeometryCacheParams(base.NativePtr + (IntPtr)UMovieSceneGeometryCacheSection.__PropertyOffset_Params, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneGeometryCacheParams.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneGeometryCacheSection.__PropertyOffset_Params, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06012B98 RID: 76696 RVA: 0x001B9016 File Offset: 0x001B7216
		static UMovieSceneGeometryCacheSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCacheTracks.MovieSceneGeometryCacheSection");
		}

		// Token: 0x06012B99 RID: 76697 RVA: 0x001B9024 File Offset: 0x001B7224
		protected UMovieSceneGeometryCacheSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A028 RID: 41000
		public new const string __ObjectPath = "/Script/GeometryCacheTracks.MovieSceneGeometryCacheSection";

		// Token: 0x0400A029 RID: 41001
		private static IntPtr _ClassPtr;

		// Token: 0x0400A02A RID: 41002
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A02B RID: 41003
		internal static int __PropertyOffset_Params;

		// Token: 0x0400A02C RID: 41004
		[Nullable(2)]
		private FMovieSceneGeometryCacheParams _Params;
	}
}
