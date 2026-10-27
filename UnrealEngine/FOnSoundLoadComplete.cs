using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000379 RID: 889
	public sealed class FOnSoundLoadComplete : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060030AD RID: 12461 RVA: 0x0004B59F File Offset: 0x0004979F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSoundLoadComplete.StaticFunctionPtr();
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x0004B5AB File Offset: 0x000497AB
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSoundLoadComplete._FunctionPtr == IntPtr.Zero)
			{
				FOnSoundLoadComplete._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AudioMixer.OnSoundLoadComplete__DelegateSignature");
			}
			return FOnSoundLoadComplete._FunctionPtr;
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x0004B5CE File Offset: 0x000497CE
		public FOnSoundLoadComplete()
		{
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x0004B5D6 File Offset: 0x000497D6
		[NullableContext(2)]
		public FOnSoundLoadComplete(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x0004B5E0 File Offset: 0x000497E0
		public FOnSoundLoadComplete(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x0004B5EB File Offset: 0x000497EB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<USoundWave, bool>) ?? ((Action<USoundWave, bool>)Delegate.CreateDelegate(typeof(Action<USoundWave, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x0004B61D File Offset: 0x0004981D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<USoundWave, bool> Callback)
		{
			if (FOnSoundLoadComplete.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSoundLoadComplete.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSoundLoadComplete.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSoundLoadComplete.OnScriptCallback));
				}
				FOnSoundLoadComplete.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnSoundLoadComplete.RegisterId);
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x0004B658 File Offset: 0x00049858
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(USoundWave LoadedSoundWave, bool WasCancelled)
		{
			FOnSoundLoadComplete.__FOnSoundLoadComplete_DelegateParams* ptr = stackalloc FOnSoundLoadComplete.__FOnSoundLoadComplete_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnSoundLoadComplete.__FOnSoundLoadComplete_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSoundLoadComplete.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->LoadedSoundWave = ((LoadedSoundWave != null) ? LoadedSoundWave.NativePtr : IntPtr.Zero);
			ptr->WasCancelled = WasCancelled;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x0004B6AC File Offset: 0x000498AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USoundWave, bool> action = target as Action<USoundWave, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USoundWave orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USoundWave>(((FOnSoundLoadComplete.__FOnSoundLoadComplete_DelegateParams*)__Parameters)->LoadedSoundWave);
			action(orCreateUObjectByNativePointer, ((FOnSoundLoadComplete.__FOnSoundLoadComplete_DelegateParams*)__Parameters)->WasCancelled);
		}

		// Token: 0x04001542 RID: 5442
		internal static IntPtr _FunctionPtr;

		// Token: 0x04001543 RID: 5443
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AudioMixer.OnSoundLoadComplete__DelegateSignature";

		// Token: 0x04001544 RID: 5444
		private static int RegisterId;

		// Token: 0x02002BFF RID: 11263
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnSoundLoadComplete_DelegateParams
		{
			// Token: 0x040164FF RID: 91391
			[FieldOffset(0)]
			public IntPtr LoadedSoundWave;

			// Token: 0x04016500 RID: 91392
			[FieldOffset(8)]
			public bool WasCancelled;
		}

		// Token: 0x02002C00 RID: 11264
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016501 RID: 91393
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
