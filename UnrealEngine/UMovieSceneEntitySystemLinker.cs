using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023F0 RID: 9200
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEntitySystemLinker")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class UMovieSceneEntitySystemLinker : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022870 RID: 141424 RVA: 0x00331287 File Offset: 0x0032F487
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneEntitySystemLinker._ClassPtr;
		}

		// Token: 0x06022871 RID: 141425 RVA: 0x00331294 File Offset: 0x0032F494
		public UMovieSceneEntitySystemLinker() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEntitySystemLinker.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022872 RID: 141426 RVA: 0x003312BC File Offset: 0x0032F4BC
		public UMovieSceneEntitySystemLinker(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEntitySystemLinker.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170084FA RID: 34042
		// (get) Token: 0x06022873 RID: 141427 RVA: 0x003312F0 File Offset: 0x0032F4F0
		// (set) Token: 0x06022874 RID: 141428 RVA: 0x00331329 File Offset: 0x0032F529
		public FMovieSceneEntitySystemGraph SystemGraph
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEntitySystemGraph result;
				if ((result = this._SystemGraph) == null)
				{
					result = (this._SystemGraph = new FMovieSceneEntitySystemGraph(base.NativePtr + (IntPtr)UMovieSceneEntitySystemLinker.__PropertyOffset_SystemGraph, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEntitySystemGraph.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneEntitySystemLinker.__PropertyOffset_SystemGraph, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022875 RID: 141429 RVA: 0x0033134A File Offset: 0x0032F54A
		static UMovieSceneEntitySystemLinker()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneEntitySystemLinker");
		}

		// Token: 0x06022876 RID: 141430 RVA: 0x00331358 File Offset: 0x0032F558
		protected UMovieSceneEntitySystemLinker(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401274A RID: 75594
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneEntitySystemLinker";

		// Token: 0x0401274B RID: 75595
		private static IntPtr _ClassPtr;

		// Token: 0x0401274C RID: 75596
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401274D RID: 75597
		internal static int __PropertyOffset_SystemGraph;

		// Token: 0x0401274E RID: 75598
		[Nullable(2)]
		private FMovieSceneEntitySystemGraph _SystemGraph;
	}
}
