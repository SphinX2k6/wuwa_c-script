using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010D2 RID: 4306
	[UnrealObjectPath("/Script/Engine.SceneCapture2D")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class ASceneCapture2D : ASceneCapture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F59C RID: 62876 RVA: 0x0016BFB5 File Offset: 0x0016A1B5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ASceneCapture2D._ClassPtr;
		}

		// Token: 0x0600F59D RID: 62877 RVA: 0x0016BFC4 File Offset: 0x0016A1C4
		public ASceneCapture2D() : this(BuiltinUtils.AllocNativeUObject(ASceneCapture2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F59E RID: 62878 RVA: 0x0016BFEC File Offset: 0x0016A1EC
		[NullableContext(1)]
		public ASceneCapture2D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ASceneCapture2D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003BCC RID: 15308
		// (get) Token: 0x0600F59F RID: 62879 RVA: 0x0016C01F File Offset: 0x0016A21F
		// (set) Token: 0x0600F5A0 RID: 62880 RVA: 0x0016C033 File Offset: 0x0016A233
		[Nullable(2)]
		public unsafe USceneCaptureComponent2D CaptureComponent2D
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + ASceneCapture2D.__PropertyOffset_CaptureComponent2D);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ASceneCapture2D.__PropertyOffset_CaptureComponent2D, value);
			}
		}

		// Token: 0x0600F5A1 RID: 62881 RVA: 0x0016C048 File Offset: 0x0016A248
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnInterpToggle(bool bEnable)
		{
			ASceneCapture2D.__OnInterpToggle_FunctionParams* ptr = stackalloc ASceneCapture2D.__OnInterpToggle_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ASceneCapture2D.__OnInterpToggle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ASceneCapture2D.__OnInterpToggle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ASceneCapture2D.__OnInterpToggle_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0600F5A2 RID: 62882 RVA: 0x0016C08F File Offset: 0x0016A28F
		static ASceneCapture2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SceneCapture2D");
		}

		// Token: 0x0600F5A3 RID: 62883 RVA: 0x0016C09D File Offset: 0x0016A29D
		protected ASceneCapture2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400850E RID: 34062
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SceneCapture2D";

		// Token: 0x0400850F RID: 34063
		private static IntPtr _ClassPtr;

		// Token: 0x04008510 RID: 34064
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008511 RID: 34065
		internal static int __PropertyOffset_CaptureComponent2D;

		// Token: 0x04008512 RID: 34066
		private static IntPtr __OnInterpToggle_NativeFunctionPtr;

		// Token: 0x02002DDE RID: 11742
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnInterpToggle_FunctionParams
		{
			// Token: 0x04016821 RID: 92193
			[FieldOffset(0)]
			public bool bEnable;
		}
	}
}
