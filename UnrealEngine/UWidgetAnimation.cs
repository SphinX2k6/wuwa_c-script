using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029F6 RID: 10742
	[UnrealObjectPath("/Script/UMG.WidgetAnimation")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UWidgetAnimation : UMovieSceneSequence, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027DE5 RID: 163301 RVA: 0x003CB9A5 File Offset: 0x003C9BA5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWidgetAnimation._ClassPtr;
		}

		// Token: 0x06027DE6 RID: 163302 RVA: 0x003CB9B4 File Offset: 0x003C9BB4
		public UWidgetAnimation() : this(BuiltinUtils.AllocNativeUObject(UWidgetAnimation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027DE7 RID: 163303 RVA: 0x003CB9DC File Offset: 0x003C9BDC
		[NullableContext(1)]
		public UWidgetAnimation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWidgetAnimation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009879 RID: 39033
		// (get) Token: 0x06027DE8 RID: 163304 RVA: 0x003CBA0F File Offset: 0x003C9C0F
		// (set) Token: 0x06027DE9 RID: 163305 RVA: 0x003CBA23 File Offset: 0x003C9C23
		[Nullable(2)]
		public unsafe UMovieScene MovieScene
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieScene>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetAnimation.__PropertyOffset_MovieScene);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetAnimation.__PropertyOffset_MovieScene, value);
			}
		}

		// Token: 0x1700987A RID: 39034
		// (get) Token: 0x06027DEA RID: 163306 RVA: 0x003CBA38 File Offset: 0x003C9C38
		// (set) Token: 0x06027DEB RID: 163307 RVA: 0x003CBA71 File Offset: 0x003C9C71
		[Nullable(1)]
		public TArray<FWidgetAnimationBinding> AnimationBindings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FWidgetAnimationBinding> result;
				if ((result = this._AnimationBindings) == null)
				{
					result = (this._AnimationBindings = new TArray<FWidgetAnimationBinding>(base.NativePtr + (IntPtr)UWidgetAnimation.__PropertyOffset_AnimationBindings, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AnimationBindings.CopyAssign(value);
			}
		}

		// Token: 0x1700987B RID: 39035
		// (get) Token: 0x06027DEC RID: 163308 RVA: 0x003CBA7F File Offset: 0x003C9C7F
		// (set) Token: 0x06027DED RID: 163309 RVA: 0x003CBA8F File Offset: 0x003C9C8F
		public unsafe bool bLegacyFinishOnStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetAnimation.__PropertyOffset_bLegacyFinishOnStop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetAnimation.__PropertyOffset_bLegacyFinishOnStop) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700987C RID: 39036
		// (get) Token: 0x06027DEE RID: 163310 RVA: 0x003CBAA0 File Offset: 0x003C9CA0
		// (set) Token: 0x06027DEF RID: 163311 RVA: 0x003CBAB4 File Offset: 0x003C9CB4
		[Nullable(1)]
		public unsafe string DisplayLabel
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UWidgetAnimation.__PropertyOffset_DisplayLabel)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UWidgetAnimation.__PropertyOffset_DisplayLabel)), value);
			}
		}

		// Token: 0x06027DF0 RID: 163312 RVA: 0x003CBACC File Offset: 0x003C9CCC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void UnbindFromAnimationStarted(UUserWidget Widget, FWidgetAnimationDynamicEvent Delegate)
		{
			UWidgetAnimation.__UnbindFromAnimationStarted_FunctionParams* ptr = stackalloc UWidgetAnimation.__UnbindFromAnimationStarted_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UWidgetAnimation.__UnbindFromAnimationStarted_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UWidgetAnimation.__UnbindFromAnimationStarted_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Widget = ((Widget != null) ? Widget.NativePtr : IntPtr.Zero);
			FScriptDelegate.NativeCopy(&ptr->Delegate, (Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UWidgetAnimation.__UnbindFromAnimationStarted_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UWidgetAnimation.__UnbindFromAnimationStarted_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027DF1 RID: 163313 RVA: 0x003CBB4C File Offset: 0x003C9D4C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void UnbindFromAnimationFinished(UUserWidget Widget, FWidgetAnimationDynamicEvent Delegate)
		{
			UWidgetAnimation.__UnbindFromAnimationFinished_FunctionParams* ptr = stackalloc UWidgetAnimation.__UnbindFromAnimationFinished_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UWidgetAnimation.__UnbindFromAnimationFinished_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UWidgetAnimation.__UnbindFromAnimationFinished_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Widget = ((Widget != null) ? Widget.NativePtr : IntPtr.Zero);
			FScriptDelegate.NativeCopy(&ptr->Delegate, (Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UWidgetAnimation.__UnbindFromAnimationFinished_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UWidgetAnimation.__UnbindFromAnimationFinished_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027DF2 RID: 163314 RVA: 0x003CBBCC File Offset: 0x003C9DCC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void UnbindAllFromAnimationStarted(UUserWidget Widget)
		{
			UWidgetAnimation.__UnbindAllFromAnimationStarted_FunctionParams* ptr = stackalloc UWidgetAnimation.__UnbindAllFromAnimationStarted_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UWidgetAnimation.__UnbindAllFromAnimationStarted_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UWidgetAnimation.__UnbindAllFromAnimationStarted_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Widget = ((Widget != null) ? Widget.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UWidgetAnimation.__UnbindAllFromAnimationStarted_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027DF3 RID: 163315 RVA: 0x003CBC24 File Offset: 0x003C9E24
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void UnbindAllFromAnimationFinished(UUserWidget Widget)
		{
			UWidgetAnimation.__UnbindAllFromAnimationFinished_FunctionParams* ptr = stackalloc UWidgetAnimation.__UnbindAllFromAnimationFinished_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UWidgetAnimation.__UnbindAllFromAnimationFinished_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UWidgetAnimation.__UnbindAllFromAnimationFinished_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Widget = ((Widget != null) ? Widget.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UWidgetAnimation.__UnbindAllFromAnimationFinished_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027DF4 RID: 163316 RVA: 0x003CBC7A File Offset: 0x003C9E7A
		public float GetStartTime()
		{
			return UWidgetAnimation.__GetStartTime_Internal(base.NativePtr);
		}

		// Token: 0x06027DF5 RID: 163317 RVA: 0x003CBC87 File Offset: 0x003C9E87
		public float GetEndTime()
		{
			return UWidgetAnimation.__GetEndTime_Internal(base.NativePtr);
		}

		// Token: 0x06027DF6 RID: 163318 RVA: 0x003CBC94 File Offset: 0x003C9E94
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void BindToAnimationStarted(UUserWidget Widget, FWidgetAnimationDynamicEvent Delegate)
		{
			UWidgetAnimation.__BindToAnimationStarted_FunctionParams* ptr = stackalloc UWidgetAnimation.__BindToAnimationStarted_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UWidgetAnimation.__BindToAnimationStarted_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UWidgetAnimation.__BindToAnimationStarted_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Widget = ((Widget != null) ? Widget.NativePtr : IntPtr.Zero);
			FScriptDelegate.NativeCopy(&ptr->Delegate, (Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UWidgetAnimation.__BindToAnimationStarted_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UWidgetAnimation.__BindToAnimationStarted_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027DF7 RID: 163319 RVA: 0x003CBD14 File Offset: 0x003C9F14
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void BindToAnimationFinished(UUserWidget Widget, FWidgetAnimationDynamicEvent Delegate)
		{
			UWidgetAnimation.__BindToAnimationFinished_FunctionParams* ptr = stackalloc UWidgetAnimation.__BindToAnimationFinished_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UWidgetAnimation.__BindToAnimationFinished_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UWidgetAnimation.__BindToAnimationFinished_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Widget = ((Widget != null) ? Widget.NativePtr : IntPtr.Zero);
			FScriptDelegate.NativeCopy(&ptr->Delegate, (Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UWidgetAnimation.__BindToAnimationFinished_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UWidgetAnimation.__BindToAnimationFinished_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027DF8 RID: 163320
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStartTime_Internal(IntPtr @this);

		// Token: 0x06027DF9 RID: 163321
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetEndTime_Internal(IntPtr @this);

		// Token: 0x06027DFA RID: 163322 RVA: 0x003CBD94 File Offset: 0x003C9F94
		static UWidgetAnimation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WidgetAnimation");
		}

		// Token: 0x06027DFB RID: 163323 RVA: 0x003CBDA2 File Offset: 0x003C9FA2
		protected UWidgetAnimation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015CAE RID: 89262
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.WidgetAnimation";

		// Token: 0x04015CAF RID: 89263
		private static IntPtr _ClassPtr;

		// Token: 0x04015CB0 RID: 89264
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015CB1 RID: 89265
		internal static int __PropertyOffset_MovieScene;

		// Token: 0x04015CB2 RID: 89266
		internal static int __PropertyOffset_AnimationBindings;

		// Token: 0x04015CB3 RID: 89267
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWidgetAnimationBinding> _AnimationBindings;

		// Token: 0x04015CB4 RID: 89268
		internal static int __PropertyOffset_bLegacyFinishOnStop;

		// Token: 0x04015CB5 RID: 89269
		internal static int __PropertyOffset_DisplayLabel;

		// Token: 0x04015CB6 RID: 89270
		private static IntPtr __UnbindFromAnimationStarted_NativeFunctionPtr;

		// Token: 0x04015CB7 RID: 89271
		private static IntPtr __UnbindFromAnimationFinished_NativeFunctionPtr;

		// Token: 0x04015CB8 RID: 89272
		private static IntPtr __UnbindAllFromAnimationStarted_NativeFunctionPtr;

		// Token: 0x04015CB9 RID: 89273
		private static IntPtr __UnbindAllFromAnimationFinished_NativeFunctionPtr;

		// Token: 0x04015CBA RID: 89274
		private static IntPtr __BindToAnimationStarted_NativeFunctionPtr;

		// Token: 0x04015CBB RID: 89275
		private static IntPtr __BindToAnimationFinished_NativeFunctionPtr;

		// Token: 0x02003BF8 RID: 15352
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __UnbindFromAnimationStarted_FunctionParams
		{
			// Token: 0x04017E14 RID: 97812
			[FieldOffset(0)]
			public IntPtr Widget;

			// Token: 0x04017E15 RID: 97813
			[FieldOffset(8)]
			public byte Delegate;
		}

		// Token: 0x02003BF9 RID: 15353
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __UnbindFromAnimationFinished_FunctionParams
		{
			// Token: 0x04017E16 RID: 97814
			[FieldOffset(0)]
			public IntPtr Widget;

			// Token: 0x04017E17 RID: 97815
			[FieldOffset(8)]
			public byte Delegate;
		}

		// Token: 0x02003BFA RID: 15354
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __UnbindAllFromAnimationStarted_FunctionParams
		{
			// Token: 0x04017E18 RID: 97816
			[FieldOffset(0)]
			public IntPtr Widget;
		}

		// Token: 0x02003BFB RID: 15355
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __UnbindAllFromAnimationFinished_FunctionParams
		{
			// Token: 0x04017E19 RID: 97817
			[FieldOffset(0)]
			public IntPtr Widget;
		}

		// Token: 0x02003BFC RID: 15356
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __BindToAnimationStarted_FunctionParams
		{
			// Token: 0x04017E1A RID: 97818
			[FieldOffset(0)]
			public IntPtr Widget;

			// Token: 0x04017E1B RID: 97819
			[FieldOffset(8)]
			public byte Delegate;
		}

		// Token: 0x02003BFD RID: 15357
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __BindToAnimationFinished_FunctionParams
		{
			// Token: 0x04017E1C RID: 97820
			[FieldOffset(0)]
			public IntPtr Widget;

			// Token: 0x04017E1D RID: 97821
			[FieldOffset(8)]
			public byte Delegate;
		}
	}
}
