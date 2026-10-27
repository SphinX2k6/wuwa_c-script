using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001895 RID: 6293
	public sealed class FEffectAudioControllerAddPlayEffectAudioPriorityRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060172C7 RID: 94919 RVA: 0x0021C9D7 File Offset: 0x0021ABD7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.StaticFunctionPtr();
		}

		// Token: 0x060172C8 RID: 94920 RVA: 0x0021C9E3 File Offset: 0x0021ABE3
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectAudioControllerAddPlayEffectAudioPriorityRetVal._FunctionPtr == IntPtr.Zero)
			{
				FEffectAudioControllerAddPlayEffectAudioPriorityRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectAudioControllerAddPlayEffectAudioPriorityRetVal__DelegateSignature");
			}
			return FEffectAudioControllerAddPlayEffectAudioPriorityRetVal._FunctionPtr;
		}

		// Token: 0x060172C9 RID: 94921 RVA: 0x0021CA06 File Offset: 0x0021AC06
		public FEffectAudioControllerAddPlayEffectAudioPriorityRetVal()
		{
		}

		// Token: 0x060172CA RID: 94922 RVA: 0x0021CA0E File Offset: 0x0021AC0E
		[NullableContext(2)]
		public FEffectAudioControllerAddPlayEffectAudioPriorityRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060172CB RID: 94923 RVA: 0x0021CA18 File Offset: 0x0021AC18
		public FEffectAudioControllerAddPlayEffectAudioPriorityRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060172CC RID: 94924 RVA: 0x0021CA23 File Offset: 0x0021AC23
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<UEffectModelAudio, AActor, int, int, int>) ?? ((Func<UEffectModelAudio, AActor, int, int, int>)Delegate.CreateDelegate(typeof(Func<UEffectModelAudio, AActor, int, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060172CD RID: 94925 RVA: 0x0021CA55 File Offset: 0x0021AC55
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Func<UEffectModelAudio, AActor, int, int, int> Callback)
		{
			if (FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.OnScriptCallback));
				}
				FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.RegisterId);
		}

		// Token: 0x060172CE RID: 94926 RVA: 0x0021CA90 File Offset: 0x0021AC90
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int Execute(UEffectModelAudio EffectModel, AActor EffectActor, int EffectType, int Priority)
		{
			FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.__FEffectAudioControllerAddPlayEffectAudioPriorityRetVal_DelegateParams* ptr = stackalloc FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.__FEffectAudioControllerAddPlayEffectAudioPriorityRetVal_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.__FEffectAudioControllerAddPlayEffectAudioPriorityRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EffectModel = ((EffectModel != null) ? EffectModel.NativePtr : IntPtr.Zero);
			ptr->EffectActor = ((EffectActor != null) ? EffectActor.NativePtr : IntPtr.Zero);
			ptr->EffectType = EffectType;
			ptr->Priority = Priority;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060172CF RID: 94927 RVA: 0x0021CB08 File Offset: 0x0021AD08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<UEffectModelAudio, AActor, int, int, int> func = target as Func<UEffectModelAudio, AActor, int, int, int>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UEffectModelAudio orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UEffectModelAudio>(((FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.__FEffectAudioControllerAddPlayEffectAudioPriorityRetVal_DelegateParams*)__Parameters)->EffectModel);
			AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.__FEffectAudioControllerAddPlayEffectAudioPriorityRetVal_DelegateParams*)__Parameters)->EffectActor);
			int _Result = func(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, ((FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.__FEffectAudioControllerAddPlayEffectAudioPriorityRetVal_DelegateParams*)__Parameters)->EffectType, ((FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.__FEffectAudioControllerAddPlayEffectAudioPriorityRetVal_DelegateParams*)__Parameters)->Priority);
			((FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.__FEffectAudioControllerAddPlayEffectAudioPriorityRetVal_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x0400C925 RID: 51493
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C926 RID: 51494
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectAudioControllerAddPlayEffectAudioPriorityRetVal__DelegateSignature";

		// Token: 0x0400C927 RID: 51495
		private static int RegisterId;

		// Token: 0x02002F97 RID: 12183
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FEffectAudioControllerAddPlayEffectAudioPriorityRetVal_DelegateParams
		{
			// Token: 0x04016B64 RID: 93028
			[FieldOffset(0)]
			public IntPtr EffectModel;

			// Token: 0x04016B65 RID: 93029
			[FieldOffset(8)]
			public IntPtr EffectActor;

			// Token: 0x04016B66 RID: 93030
			[FieldOffset(16)]
			public int EffectType;

			// Token: 0x04016B67 RID: 93031
			[FieldOffset(20)]
			public int Priority;

			// Token: 0x04016B68 RID: 93032
			[FieldOffset(24)]
			public int __Result;
		}

		// Token: 0x02002F98 RID: 12184
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B69 RID: 93033
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
