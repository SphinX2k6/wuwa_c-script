using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023E3 RID: 9187
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEasingExternalCurve")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UMovieSceneEasingExternalCurve : UObject, IUnrealUObject, IUnrealObject, IMovieSceneEasingFunction, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060227E6 RID: 141286 RVA: 0x003305D9 File Offset: 0x0032E7D9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneEasingExternalCurve._ClassPtr;
		}

		// Token: 0x060227E7 RID: 141287 RVA: 0x003305E5 File Offset: 0x0032E7E5
		int IMovieSceneEasingFunction.InterfaceOffset()
		{
			return UMovieSceneEasingExternalCurve.__InterfaceOffset_IMovieSceneEasingFunction;
		}

		// Token: 0x060227E8 RID: 141288 RVA: 0x003305EC File Offset: 0x0032E7EC
		public UMovieSceneEasingExternalCurve() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEasingExternalCurve.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060227E9 RID: 141289 RVA: 0x00330614 File Offset: 0x0032E814
		[NullableContext(1)]
		public UMovieSceneEasingExternalCurve(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEasingExternalCurve.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170084DC RID: 34012
		// (get) Token: 0x060227EA RID: 141290 RVA: 0x00330647 File Offset: 0x0032E847
		// (set) Token: 0x060227EB RID: 141291 RVA: 0x0033065B File Offset: 0x0032E85B
		[Nullable(2)]
		public unsafe UCurveFloat Curve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneEasingExternalCurve.__PropertyOffset_Curve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneEasingExternalCurve.__PropertyOffset_Curve, value);
			}
		}

		// Token: 0x060227EC RID: 141292 RVA: 0x00330670 File Offset: 0x0032E870
		static UMovieSceneEasingExternalCurve()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneEasingExternalCurve");
		}

		// Token: 0x060227ED RID: 141293 RVA: 0x0033067E File Offset: 0x0032E87E
		protected UMovieSceneEasingExternalCurve(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012705 RID: 75525
		internal static int __InterfaceOffset_IMovieSceneEasingFunction;

		// Token: 0x04012706 RID: 75526
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneEasingExternalCurve";

		// Token: 0x04012707 RID: 75527
		private static IntPtr _ClassPtr;

		// Token: 0x04012708 RID: 75528
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012709 RID: 75529
		internal static int __PropertyOffset_Curve;
	}
}
