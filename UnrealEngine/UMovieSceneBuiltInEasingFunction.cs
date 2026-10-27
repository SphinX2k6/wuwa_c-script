using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023DC RID: 9180
	[UnrealObjectPath("/Script/MovieScene.MovieSceneBuiltInEasingFunction")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UMovieSceneBuiltInEasingFunction : UObject, IUnrealUObject, IUnrealObject, IMovieSceneEasingFunction, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022795 RID: 141205 RVA: 0x0032FC1E File Offset: 0x0032DE1E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneBuiltInEasingFunction._ClassPtr;
		}

		// Token: 0x06022796 RID: 141206 RVA: 0x0032FC2A File Offset: 0x0032DE2A
		int IMovieSceneEasingFunction.InterfaceOffset()
		{
			return UMovieSceneBuiltInEasingFunction.__InterfaceOffset_IMovieSceneEasingFunction;
		}

		// Token: 0x06022797 RID: 141207 RVA: 0x0032FC34 File Offset: 0x0032DE34
		public UMovieSceneBuiltInEasingFunction() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneBuiltInEasingFunction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022798 RID: 141208 RVA: 0x0032FC5C File Offset: 0x0032DE5C
		[NullableContext(1)]
		public UMovieSceneBuiltInEasingFunction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneBuiltInEasingFunction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170084C8 RID: 33992
		// (get) Token: 0x06022799 RID: 141209 RVA: 0x0032FC8F File Offset: 0x0032DE8F
		// (set) Token: 0x0602279A RID: 141210 RVA: 0x0032FC9F File Offset: 0x0032DE9F
		public unsafe EMovieSceneBuiltInEasing Type
		{
			get
			{
				return (EMovieSceneBuiltInEasing)(*(base.NativePtr + (IntPtr)UMovieSceneBuiltInEasingFunction.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneBuiltInEasingFunction.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x0602279B RID: 141211 RVA: 0x0032FCB0 File Offset: 0x0032DEB0
		static UMovieSceneBuiltInEasingFunction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneBuiltInEasingFunction");
		}

		// Token: 0x0602279C RID: 141212 RVA: 0x0032FCBE File Offset: 0x0032DEBE
		protected UMovieSceneBuiltInEasingFunction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040126D2 RID: 75474
		internal static int __InterfaceOffset_IMovieSceneEasingFunction;

		// Token: 0x040126D3 RID: 75475
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneBuiltInEasingFunction";

		// Token: 0x040126D4 RID: 75476
		private static IntPtr _ClassPtr;

		// Token: 0x040126D5 RID: 75477
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040126D6 RID: 75478
		internal static int __PropertyOffset_Type;
	}
}
