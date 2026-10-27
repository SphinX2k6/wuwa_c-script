using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023EC RID: 9196
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEntitySystem")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UMovieSceneEntitySystem : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602284E RID: 141390 RVA: 0x00331011 File Offset: 0x0032F211
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneEntitySystem._ClassPtr;
		}

		// Token: 0x0602284F RID: 141391 RVA: 0x00331020 File Offset: 0x0032F220
		public UMovieSceneEntitySystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEntitySystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022850 RID: 141392 RVA: 0x00331048 File Offset: 0x0032F248
		[NullableContext(1)]
		public UMovieSceneEntitySystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEntitySystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170084F7 RID: 34039
		// (get) Token: 0x06022851 RID: 141393 RVA: 0x0033107B File Offset: 0x0032F27B
		// (set) Token: 0x06022852 RID: 141394 RVA: 0x0033108F File Offset: 0x0032F28F
		[Nullable(2)]
		public unsafe UMovieSceneEntitySystemLinker Linker
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneEntitySystemLinker>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneEntitySystem.__PropertyOffset_Linker);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneEntitySystem.__PropertyOffset_Linker, value);
			}
		}

		// Token: 0x06022853 RID: 141395 RVA: 0x003310A4 File Offset: 0x0032F2A4
		static UMovieSceneEntitySystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneEntitySystem");
		}

		// Token: 0x06022854 RID: 141396 RVA: 0x003310B2 File Offset: 0x0032F2B2
		protected UMovieSceneEntitySystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401273D RID: 75581
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneEntitySystem";

		// Token: 0x0401273E RID: 75582
		private static IntPtr _ClassPtr;

		// Token: 0x0401273F RID: 75583
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012740 RID: 75584
		internal static int __PropertyOffset_Linker;
	}
}
