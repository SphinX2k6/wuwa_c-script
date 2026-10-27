using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029FA RID: 10746
	[UnrealObjectPath("/Script/UMG.WidgetAnimationPlayCallbackProxy")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UWidgetAnimationPlayCallbackProxy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027E1C RID: 163356 RVA: 0x003CC09A File Offset: 0x003CA29A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWidgetAnimationPlayCallbackProxy._ClassPtr;
		}

		// Token: 0x06027E1D RID: 163357 RVA: 0x003CC0A8 File Offset: 0x003CA2A8
		public UWidgetAnimationPlayCallbackProxy() : this(BuiltinUtils.AllocNativeUObject(UWidgetAnimationPlayCallbackProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027E1E RID: 163358 RVA: 0x003CC0D0 File Offset: 0x003CA2D0
		[NullableContext(1)]
		public UWidgetAnimationPlayCallbackProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWidgetAnimationPlayCallbackProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009882 RID: 39042
		// (get) Token: 0x06027E1F RID: 163359 RVA: 0x003CC104 File Offset: 0x003CA304
		// (set) Token: 0x06027E20 RID: 163360 RVA: 0x003CC13D File Offset: 0x003CA33D
		[Nullable(1)]
		public FWidgetAnimationResult Finished
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FWidgetAnimationResult result;
				if ((result = this._Finished) == null)
				{
					result = (this._Finished = new FWidgetAnimationResult(base.NativePtr + (IntPtr)UWidgetAnimationPlayCallbackProxy.__PropertyOffset_Finished, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UWidgetAnimationPlayCallbackProxy.__PropertyOffset_Finished, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06027E21 RID: 163361 RVA: 0x003CC160 File Offset: 0x003CA360
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UWidgetAnimationPlayCallbackProxy CreatePlayAnimationTimeRangeProxyObject(ref UUMGSequencePlayer Result, UUserWidget Widget, UWidgetAnimation InAnimation, float StartAtTime = 0f, float EndAtTime = 0f, int NumLoopsToPlay = 1, EUMGSequencePlayMode PlayMode = EUMGSequencePlayMode.Forward, float PlaybackSpeed = 1f)
		{
			UWidgetAnimationPlayCallbackProxy.__CreatePlayAnimationTimeRangeProxyObject_FunctionParams* ptr = stackalloc UWidgetAnimationPlayCallbackProxy.__CreatePlayAnimationTimeRangeProxyObject_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UWidgetAnimationPlayCallbackProxy.__CreatePlayAnimationTimeRangeProxyObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UWidgetAnimationPlayCallbackProxy.__CreatePlayAnimationTimeRangeProxyObject_NativeFunctionPtr, (void*)ptr, 1);
			ref UWidgetAnimationPlayCallbackProxy.__CreatePlayAnimationTimeRangeProxyObject_FunctionParams ptr2 = ref *ptr;
			UUMGSequencePlayer uumgsequencePlayer = Result;
			ptr2.Result = ((uumgsequencePlayer != null) ? uumgsequencePlayer.NativePtr : IntPtr.Zero);
			ptr->Widget = ((Widget != null) ? Widget.NativePtr : IntPtr.Zero);
			ptr->InAnimation = ((InAnimation != null) ? InAnimation.NativePtr : IntPtr.Zero);
			ptr->StartAtTime = StartAtTime;
			ptr->EndAtTime = EndAtTime;
			ptr->NumLoopsToPlay = NumLoopsToPlay;
			ptr->PlayMode = PlayMode;
			ptr->PlaybackSpeed = PlaybackSpeed;
			UnrealReflectionUtils.CallUFunction(UWidgetAnimationPlayCallbackProxy._ClassDefaultObjectPtr, UWidgetAnimationPlayCallbackProxy.__CreatePlayAnimationTimeRangeProxyObject_NativeFunctionPtr, (void*)ptr, 0);
			Result = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUMGSequencePlayer>(ptr->Result);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWidgetAnimationPlayCallbackProxy>(ptr->__Result);
		}

		// Token: 0x06027E22 RID: 163362 RVA: 0x003CC228 File Offset: 0x003CA428
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UWidgetAnimationPlayCallbackProxy CreatePlayAnimationProxyObject(ref UUMGSequencePlayer Result, UUserWidget Widget, UWidgetAnimation InAnimation, float StartAtTime = 0f, int NumLoopsToPlay = 1, EUMGSequencePlayMode PlayMode = EUMGSequencePlayMode.Forward, float PlaybackSpeed = 1f)
		{
			UWidgetAnimationPlayCallbackProxy.__CreatePlayAnimationProxyObject_FunctionParams* ptr = stackalloc UWidgetAnimationPlayCallbackProxy.__CreatePlayAnimationProxyObject_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UWidgetAnimationPlayCallbackProxy.__CreatePlayAnimationProxyObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UWidgetAnimationPlayCallbackProxy.__CreatePlayAnimationProxyObject_NativeFunctionPtr, (void*)ptr, 1);
			ref UWidgetAnimationPlayCallbackProxy.__CreatePlayAnimationProxyObject_FunctionParams ptr2 = ref *ptr;
			UUMGSequencePlayer uumgsequencePlayer = Result;
			ptr2.Result = ((uumgsequencePlayer != null) ? uumgsequencePlayer.NativePtr : IntPtr.Zero);
			ptr->Widget = ((Widget != null) ? Widget.NativePtr : IntPtr.Zero);
			ptr->InAnimation = ((InAnimation != null) ? InAnimation.NativePtr : IntPtr.Zero);
			ptr->StartAtTime = StartAtTime;
			ptr->NumLoopsToPlay = NumLoopsToPlay;
			ptr->PlayMode = PlayMode;
			ptr->PlaybackSpeed = PlaybackSpeed;
			UnrealReflectionUtils.CallUFunction(UWidgetAnimationPlayCallbackProxy._ClassDefaultObjectPtr, UWidgetAnimationPlayCallbackProxy.__CreatePlayAnimationProxyObject_NativeFunctionPtr, (void*)ptr, 0);
			Result = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUMGSequencePlayer>(ptr->Result);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWidgetAnimationPlayCallbackProxy>(ptr->__Result);
		}

		// Token: 0x06027E23 RID: 163363 RVA: 0x003CC2E7 File Offset: 0x003CA4E7
		static UWidgetAnimationPlayCallbackProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WidgetAnimationPlayCallbackProxy");
		}

		// Token: 0x06027E24 RID: 163364 RVA: 0x003CC2F5 File Offset: 0x003CA4F5
		protected UWidgetAnimationPlayCallbackProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015CCA RID: 89290
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.WidgetAnimationPlayCallbackProxy";

		// Token: 0x04015CCB RID: 89291
		private static IntPtr _ClassPtr;

		// Token: 0x04015CCC RID: 89292
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015CCD RID: 89293
		internal static int __PropertyOffset_Finished;

		// Token: 0x04015CCE RID: 89294
		[Nullable(2)]
		private FWidgetAnimationResult _Finished;

		// Token: 0x04015CCF RID: 89295
		private static IntPtr __CreatePlayAnimationTimeRangeProxyObject_NativeFunctionPtr;

		// Token: 0x04015CD0 RID: 89296
		private static IntPtr __CreatePlayAnimationProxyObject_NativeFunctionPtr;

		// Token: 0x02003BFF RID: 15359
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __CreatePlayAnimationTimeRangeProxyObject_FunctionParams
		{
			// Token: 0x04017E1F RID: 97823
			[FieldOffset(0)]
			public IntPtr Result;

			// Token: 0x04017E20 RID: 97824
			[FieldOffset(8)]
			public IntPtr Widget;

			// Token: 0x04017E21 RID: 97825
			[FieldOffset(16)]
			public IntPtr InAnimation;

			// Token: 0x04017E22 RID: 97826
			[FieldOffset(24)]
			public float StartAtTime;

			// Token: 0x04017E23 RID: 97827
			[FieldOffset(28)]
			public float EndAtTime;

			// Token: 0x04017E24 RID: 97828
			[FieldOffset(32)]
			public int NumLoopsToPlay;

			// Token: 0x04017E25 RID: 97829
			[FieldOffset(36)]
			public TEnumAsByte<EUMGSequencePlayMode> PlayMode;

			// Token: 0x04017E26 RID: 97830
			[FieldOffset(40)]
			public float PlaybackSpeed;

			// Token: 0x04017E27 RID: 97831
			[FieldOffset(48)]
			public IntPtr __Result;
		}

		// Token: 0x02003C00 RID: 15360
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __CreatePlayAnimationProxyObject_FunctionParams
		{
			// Token: 0x04017E28 RID: 97832
			[FieldOffset(0)]
			public IntPtr Result;

			// Token: 0x04017E29 RID: 97833
			[FieldOffset(8)]
			public IntPtr Widget;

			// Token: 0x04017E2A RID: 97834
			[FieldOffset(16)]
			public IntPtr InAnimation;

			// Token: 0x04017E2B RID: 97835
			[FieldOffset(24)]
			public float StartAtTime;

			// Token: 0x04017E2C RID: 97836
			[FieldOffset(28)]
			public int NumLoopsToPlay;

			// Token: 0x04017E2D RID: 97837
			[FieldOffset(32)]
			public TEnumAsByte<EUMGSequencePlayMode> PlayMode;

			// Token: 0x04017E2E RID: 97838
			[FieldOffset(36)]
			public float PlaybackSpeed;

			// Token: 0x04017E2F RID: 97839
			[FieldOffset(40)]
			public IntPtr __Result;
		}
	}
}
