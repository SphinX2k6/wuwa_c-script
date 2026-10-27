using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000296 RID: 662
	public sealed class FOnSetCurrentAudioCultureCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060024FB RID: 9467 RVA: 0x00037262 File Offset: 0x00035462
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSetCurrentAudioCultureCallback.StaticFunctionPtr();
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x0003726E File Offset: 0x0003546E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSetCurrentAudioCultureCallback._FunctionPtr == IntPtr.Zero)
			{
				FOnSetCurrentAudioCultureCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.OnSetCurrentAudioCultureCallback__DelegateSignature");
			}
			return FOnSetCurrentAudioCultureCallback._FunctionPtr;
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x00037291 File Offset: 0x00035491
		public FOnSetCurrentAudioCultureCallback()
		{
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x00037299 File Offset: 0x00035499
		[NullableContext(2)]
		public FOnSetCurrentAudioCultureCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x000372A3 File Offset: 0x000354A3
		public FOnSetCurrentAudioCultureCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x000372AE File Offset: 0x000354AE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x000372E0 File Offset: 0x000354E0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<bool> Callback)
		{
			if (FOnSetCurrentAudioCultureCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSetCurrentAudioCultureCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSetCurrentAudioCultureCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSetCurrentAudioCultureCallback.OnScriptCallback));
				}
				FOnSetCurrentAudioCultureCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnSetCurrentAudioCultureCallback.RegisterId);
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x0003731C File Offset: 0x0003551C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool Succeeded)
		{
			FOnSetCurrentAudioCultureCallback.__FOnSetCurrentAudioCultureCallback_DelegateParams* ptr = stackalloc FOnSetCurrentAudioCultureCallback.__FOnSetCurrentAudioCultureCallback_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnSetCurrentAudioCultureCallback.__FOnSetCurrentAudioCultureCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSetCurrentAudioCultureCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Succeeded = Succeeded;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x0003735C File Offset: 0x0003555C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnSetCurrentAudioCultureCallback.__FOnSetCurrentAudioCultureCallback_DelegateParams*)__Parameters)->Succeeded);
		}

		// Token: 0x04000E0C RID: 3596
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000E0D RID: 3597
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.OnSetCurrentAudioCultureCallback__DelegateSignature";

		// Token: 0x04000E0E RID: 3598
		private static int RegisterId;

		// Token: 0x02002BA1 RID: 11169
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnSetCurrentAudioCultureCallback_DelegateParams
		{
			// Token: 0x04016437 RID: 91191
			[FieldOffset(0)]
			public bool Succeeded;
		}

		// Token: 0x02002BA2 RID: 11170
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016438 RID: 91192
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
