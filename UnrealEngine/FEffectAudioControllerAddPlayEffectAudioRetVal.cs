using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001896 RID: 6294
	public sealed class FEffectAudioControllerAddPlayEffectAudioRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060172D0 RID: 94928 RVA: 0x0021CB7D File Offset: 0x0021AD7D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectAudioControllerAddPlayEffectAudioRetVal.StaticFunctionPtr();
		}

		// Token: 0x060172D1 RID: 94929 RVA: 0x0021CB89 File Offset: 0x0021AD89
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectAudioControllerAddPlayEffectAudioRetVal._FunctionPtr == IntPtr.Zero)
			{
				FEffectAudioControllerAddPlayEffectAudioRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectAudioControllerAddPlayEffectAudioRetVal__DelegateSignature");
			}
			return FEffectAudioControllerAddPlayEffectAudioRetVal._FunctionPtr;
		}

		// Token: 0x060172D2 RID: 94930 RVA: 0x0021CBAC File Offset: 0x0021ADAC
		public FEffectAudioControllerAddPlayEffectAudioRetVal()
		{
		}

		// Token: 0x060172D3 RID: 94931 RVA: 0x0021CBB4 File Offset: 0x0021ADB4
		[NullableContext(2)]
		public FEffectAudioControllerAddPlayEffectAudioRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060172D4 RID: 94932 RVA: 0x0021CBBE File Offset: 0x0021ADBE
		public FEffectAudioControllerAddPlayEffectAudioRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060172D5 RID: 94933 RVA: 0x0021CBC9 File Offset: 0x0021ADC9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<UEffectModelAudio, AActor, int, int>) ?? ((Func<UEffectModelAudio, AActor, int, int>)Delegate.CreateDelegate(typeof(Func<UEffectModelAudio, AActor, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060172D6 RID: 94934 RVA: 0x0021CBFB File Offset: 0x0021ADFB
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Func<UEffectModelAudio, AActor, int, int> Callback)
		{
			if (FEffectAudioControllerAddPlayEffectAudioRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEffectAudioControllerAddPlayEffectAudioRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEffectAudioControllerAddPlayEffectAudioRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEffectAudioControllerAddPlayEffectAudioRetVal.OnScriptCallback));
				}
				FEffectAudioControllerAddPlayEffectAudioRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FEffectAudioControllerAddPlayEffectAudioRetVal.RegisterId);
		}

		// Token: 0x060172D7 RID: 94935 RVA: 0x0021CC38 File Offset: 0x0021AE38
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int Execute(UEffectModelAudio EffectModel, AActor EffectActor, int EffectType)
		{
			FEffectAudioControllerAddPlayEffectAudioRetVal.__FEffectAudioControllerAddPlayEffectAudioRetVal_DelegateParams* ptr = stackalloc FEffectAudioControllerAddPlayEffectAudioRetVal.__FEffectAudioControllerAddPlayEffectAudioRetVal_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FEffectAudioControllerAddPlayEffectAudioRetVal.__FEffectAudioControllerAddPlayEffectAudioRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEffectAudioControllerAddPlayEffectAudioRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EffectModel = ((EffectModel != null) ? EffectModel.NativePtr : IntPtr.Zero);
			ptr->EffectActor = ((EffectActor != null) ? EffectActor.NativePtr : IntPtr.Zero);
			ptr->EffectType = EffectType;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060172D8 RID: 94936 RVA: 0x0021CCA8 File Offset: 0x0021AEA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<UEffectModelAudio, AActor, int, int> func = target as Func<UEffectModelAudio, AActor, int, int>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UEffectModelAudio orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UEffectModelAudio>(((FEffectAudioControllerAddPlayEffectAudioRetVal.__FEffectAudioControllerAddPlayEffectAudioRetVal_DelegateParams*)__Parameters)->EffectModel);
			AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FEffectAudioControllerAddPlayEffectAudioRetVal.__FEffectAudioControllerAddPlayEffectAudioRetVal_DelegateParams*)__Parameters)->EffectActor);
			int _Result = func(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, ((FEffectAudioControllerAddPlayEffectAudioRetVal.__FEffectAudioControllerAddPlayEffectAudioRetVal_DelegateParams*)__Parameters)->EffectType);
			((FEffectAudioControllerAddPlayEffectAudioRetVal.__FEffectAudioControllerAddPlayEffectAudioRetVal_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x0400C928 RID: 51496
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C929 RID: 51497
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectAudioControllerAddPlayEffectAudioRetVal__DelegateSignature";

		// Token: 0x0400C92A RID: 51498
		private static int RegisterId;

		// Token: 0x02002F99 RID: 12185
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FEffectAudioControllerAddPlayEffectAudioRetVal_DelegateParams
		{
			// Token: 0x04016B6A RID: 93034
			[FieldOffset(0)]
			public IntPtr EffectModel;

			// Token: 0x04016B6B RID: 93035
			[FieldOffset(8)]
			public IntPtr EffectActor;

			// Token: 0x04016B6C RID: 93036
			[FieldOffset(16)]
			public int EffectType;

			// Token: 0x04016B6D RID: 93037
			[FieldOffset(20)]
			public int __Result;
		}

		// Token: 0x02002F9A RID: 12186
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B6E RID: 93038
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
