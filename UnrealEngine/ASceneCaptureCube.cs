using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010D8 RID: 4312
	[UnrealObjectPath("/Script/Engine.SceneCaptureCube")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class ASceneCaptureCube : ASceneCapture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F678 RID: 63096 RVA: 0x0016D30D File Offset: 0x0016B50D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ASceneCaptureCube._ClassPtr;
		}

		// Token: 0x0600F679 RID: 63097 RVA: 0x0016D31C File Offset: 0x0016B51C
		public ASceneCaptureCube() : this(BuiltinUtils.AllocNativeUObject(ASceneCaptureCube.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F67A RID: 63098 RVA: 0x0016D344 File Offset: 0x0016B544
		[NullableContext(1)]
		public ASceneCaptureCube(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ASceneCaptureCube.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C16 RID: 15382
		// (get) Token: 0x0600F67B RID: 63099 RVA: 0x0016D377 File Offset: 0x0016B577
		// (set) Token: 0x0600F67C RID: 63100 RVA: 0x0016D38B File Offset: 0x0016B58B
		[Nullable(2)]
		public unsafe USceneCaptureComponentCube CaptureComponentCube
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponentCube>(base.NativePtr / (IntPtr)sizeof(void*) + ASceneCaptureCube.__PropertyOffset_CaptureComponentCube);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ASceneCaptureCube.__PropertyOffset_CaptureComponentCube, value);
			}
		}

		// Token: 0x0600F67D RID: 63101 RVA: 0x0016D3A0 File Offset: 0x0016B5A0
		public void OnInterpToggle(bool bEnable)
		{
			ASceneCaptureCube.__OnInterpToggle_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x0600F67E RID: 63102
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnInterpToggle_Internal(IntPtr @this, bool bEnable);

		// Token: 0x0600F67F RID: 63103 RVA: 0x0016D3AE File Offset: 0x0016B5AE
		static ASceneCaptureCube()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SceneCaptureCube");
		}

		// Token: 0x0600F680 RID: 63104 RVA: 0x0016D3BC File Offset: 0x0016B5BC
		protected ASceneCaptureCube(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008583 RID: 34179
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SceneCaptureCube";

		// Token: 0x04008584 RID: 34180
		private static IntPtr _ClassPtr;

		// Token: 0x04008585 RID: 34181
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008586 RID: 34182
		internal static int __PropertyOffset_CaptureComponentCube;
	}
}
