using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028F4 RID: 10484
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.TUHUD")]
	[UnrealStructLayout(1192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1192)]
	public class UTUHUD : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026E21 RID: 159265 RVA: 0x003B4F6F File Offset: 0x003B316F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTUHUD._ClassPtr;
		}

		// Token: 0x06026E22 RID: 159266 RVA: 0x003B4F7C File Offset: 0x003B317C
		public UTUHUD() : this(BuiltinUtils.AllocNativeUObject(UTUHUD.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026E23 RID: 159267 RVA: 0x003B4FA4 File Offset: 0x003B31A4
		[NullableContext(1)]
		public UTUHUD(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTUHUD.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170095CB RID: 38347
		// (get) Token: 0x06026E24 RID: 159268 RVA: 0x003B4FD7 File Offset: 0x003B31D7
		// (set) Token: 0x06026E25 RID: 159269 RVA: 0x003B4FEB File Offset: 0x003B31EB
		public unsafe UTextBlock TitleLabel
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + UTUHUD.__PropertyOffset_TitleLabel);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTUHUD.__PropertyOffset_TitleLabel, value);
			}
		}

		// Token: 0x170095CC RID: 38348
		// (get) Token: 0x06026E26 RID: 159270 RVA: 0x003B5000 File Offset: 0x003B3200
		// (set) Token: 0x06026E27 RID: 159271 RVA: 0x003B5014 File Offset: 0x003B3214
		public unsafe USizeBox ImageBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USizeBox>(base.NativePtr / (IntPtr)sizeof(void*) + UTUHUD.__PropertyOffset_ImageBox);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTUHUD.__PropertyOffset_ImageBox, value);
			}
		}

		// Token: 0x170095CD RID: 38349
		// (get) Token: 0x06026E28 RID: 159272 RVA: 0x003B5029 File Offset: 0x003B3229
		// (set) Token: 0x06026E29 RID: 159273 RVA: 0x003B503D File Offset: 0x003B323D
		public unsafe UOverlay BackView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UOverlay>(base.NativePtr / (IntPtr)sizeof(void*) + UTUHUD.__PropertyOffset_BackView);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTUHUD.__PropertyOffset_BackView, value);
			}
		}

		// Token: 0x06026E2A RID: 159274 RVA: 0x003B5054 File Offset: 0x003B3254
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ShowWaitAndToast(string Toast)
		{
			UTUHUD.__ShowWaitAndToast_FunctionParams* ptr = stackalloc UTUHUD.__ShowWaitAndToast_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTUHUD.__ShowWaitAndToast_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTUHUD.__ShowWaitAndToast_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Toast), Toast);
			UnrealReflectionUtils.CallUFunction(UTUHUD._ClassDefaultObjectPtr, UTUHUD.__ShowWaitAndToast_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTUHUD.__ShowWaitAndToast_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026E2B RID: 159275 RVA: 0x003B50B1 File Offset: 0x003B32B1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void ShowWait()
		{
			UnrealReflectionUtils.CallUFunction(UTUHUD._ClassDefaultObjectPtr, UTUHUD.__ShowWait_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026E2C RID: 159276 RVA: 0x003B50C8 File Offset: 0x003B32C8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ShowToast(string Toast, float TimeInterval = 3f)
		{
			UTUHUD.__ShowToast_FunctionParams* ptr = stackalloc UTUHUD.__ShowToast_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTUHUD.__ShowToast_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTUHUD.__ShowToast_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Toast), Toast);
			ptr->TimeInterval = TimeInterval;
			UnrealReflectionUtils.CallUFunction(UTUHUD._ClassDefaultObjectPtr, UTUHUD.__ShowToast_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTUHUD.__ShowToast_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026E2D RID: 159277 RVA: 0x003B512C File Offset: 0x003B332C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void Dismiss()
		{
			UnrealReflectionUtils.CallUFunction(UTUHUD._ClassDefaultObjectPtr, UTUHUD.__Dismiss_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026E2E RID: 159278 RVA: 0x003B5140 File Offset: 0x003B3340
		static UTUHUD()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TapCommon.TUHUD");
		}

		// Token: 0x06026E2F RID: 159279 RVA: 0x003B514E File Offset: 0x003B334E
		protected UTUHUD(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401558E RID: 87438
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TapCommon.TUHUD";

		// Token: 0x0401558F RID: 87439
		private static IntPtr _ClassPtr;

		// Token: 0x04015590 RID: 87440
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015591 RID: 87441
		internal static int __PropertyOffset_TitleLabel;

		// Token: 0x04015592 RID: 87442
		internal static int __PropertyOffset_ImageBox;

		// Token: 0x04015593 RID: 87443
		internal static int __PropertyOffset_BackView;

		// Token: 0x04015594 RID: 87444
		private static IntPtr __ShowWaitAndToast_NativeFunctionPtr;

		// Token: 0x04015595 RID: 87445
		private static IntPtr __ShowWait_NativeFunctionPtr;

		// Token: 0x04015596 RID: 87446
		private static IntPtr __ShowToast_NativeFunctionPtr;

		// Token: 0x04015597 RID: 87447
		private static IntPtr __Dismiss_NativeFunctionPtr;

		// Token: 0x02003B53 RID: 15187
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ShowWaitAndToast_FunctionParams
		{
			// Token: 0x04017CFB RID: 97531
			[FieldOffset(0)]
			public FString Toast;
		}

		// Token: 0x02003B54 RID: 15188
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ShowToast_FunctionParams
		{
			// Token: 0x04017CFC RID: 97532
			[FieldOffset(0)]
			public FString Toast;

			// Token: 0x04017CFD RID: 97533
			[FieldOffset(16)]
			public float TimeInterval;
		}
	}
}
