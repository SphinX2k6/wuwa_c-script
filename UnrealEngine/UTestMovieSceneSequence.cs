using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002463 RID: 9315
	[UnrealObjectPath("/Script/MovieScene.TestMovieSceneSequence")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UTestMovieSceneSequence : UMovieSceneSequence, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022E35 RID: 142901 RVA: 0x003394E2 File Offset: 0x003376E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestMovieSceneSequence._ClassPtr;
		}

		// Token: 0x06022E36 RID: 142902 RVA: 0x003394F0 File Offset: 0x003376F0
		public UTestMovieSceneSequence() : this(BuiltinUtils.AllocNativeUObject(UTestMovieSceneSequence.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022E37 RID: 142903 RVA: 0x00339518 File Offset: 0x00337718
		[NullableContext(1)]
		public UTestMovieSceneSequence(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestMovieSceneSequence.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008610 RID: 34320
		// (get) Token: 0x06022E38 RID: 142904 RVA: 0x0033954B File Offset: 0x0033774B
		// (set) Token: 0x06022E39 RID: 142905 RVA: 0x0033955F File Offset: 0x0033775F
		[Nullable(2)]
		public unsafe UMovieScene MovieScene
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieScene>(base.NativePtr / (IntPtr)sizeof(void*) + UTestMovieSceneSequence.__PropertyOffset_MovieScene);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTestMovieSceneSequence.__PropertyOffset_MovieScene, value);
			}
		}

		// Token: 0x06022E3A RID: 142906 RVA: 0x00339574 File Offset: 0x00337774
		static UTestMovieSceneSequence()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.TestMovieSceneSequence");
		}

		// Token: 0x06022E3B RID: 142907 RVA: 0x00339582 File Offset: 0x00337782
		protected UTestMovieSceneSequence(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040129FB RID: 76283
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.TestMovieSceneSequence";

		// Token: 0x040129FC RID: 76284
		private static IntPtr _ClassPtr;

		// Token: 0x040129FD RID: 76285
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040129FE RID: 76286
		internal static int __PropertyOffset_MovieScene;
	}
}
