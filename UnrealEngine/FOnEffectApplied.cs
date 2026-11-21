using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000434 RID: 1076
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnEffectApplied : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600689D RID: 26781 RVA: 0x00098922 File Offset: 0x00096B22
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnEffectApplied.StaticFunctionPtr();
		}

		// Token: 0x0600689E RID: 26782 RVA: 0x0009892E File Offset: 0x00096B2E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnEffectApplied._FunctionPtr == IntPtr.Zero)
			{
				FOnEffectApplied._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnEffectApplied__DelegateSignature");
			}
			return FOnEffectApplied._FunctionPtr;
		}

		// Token: 0x0600689F RID: 26783 RVA: 0x00098951 File Offset: 0x00096B51
		public FOnEffectApplied()
		{
		}

		// Token: 0x060068A0 RID: 26784 RVA: 0x00098959 File Offset: 0x00096B59
		[NullableContext(2)]
		public FOnEffectApplied(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060068A1 RID: 26785 RVA: 0x00098963 File Offset: 0x00096B63
		public FOnEffectApplied(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060068A2 RID: 26786 RVA: 0x0009896E File Offset: 0x00096B6E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FActiveGameplayEffectHandle>) ?? ((Action<FActiveGameplayEffectHandle>)Delegate.CreateDelegate(typeof(Action<FActiveGameplayEffectHandle>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060068A3 RID: 26787 RVA: 0x000989A0 File Offset: 0x00096BA0
		[NullableContext(1)]
		public void Add(Action<FActiveGameplayEffectHandle> Callback)
		{
			if (FOnEffectApplied.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnEffectApplied.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnEffectApplied.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnEffectApplied.OnScriptCallback));
				}
				FOnEffectApplied.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnEffectApplied.RegisterId);
		}

		// Token: 0x060068A4 RID: 26788 RVA: 0x000989DA File Offset: 0x00096BDA
		[NullableContext(1)]
		public void Remove(Action<FActiveGameplayEffectHandle> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060068A5 RID: 26789 RVA: 0x000989E4 File Offset: 0x00096BE4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(FActiveGameplayEffectHandle ActiveHandle)
		{
			FOnEffectApplied.__FOnEffectApplied_DelegateParams* ptr = stackalloc FOnEffectApplied.__FOnEffectApplied_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnEffectApplied.__FOnEffectApplied_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnEffectApplied.StaticFunctionPtr(), (void*)ptr, 1);
			if (ActiveHandle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), &ptr->ActiveHandle, ActiveHandle.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060068A6 RID: 26790 RVA: 0x00098A3C File Offset: 0x00096C3C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FActiveGameplayEffectHandle> action = target as Action<FActiveGameplayEffectHandle>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FActiveGameplayEffectHandle obj = new FActiveGameplayEffectHandle(&((FOnEffectApplied.__FOnEffectApplied_DelegateParams*)__Parameters)->ActiveHandle, true, true);
			action(obj);
		}

		// Token: 0x04002C9B RID: 11419
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002C9C RID: 11420
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnEffectApplied__DelegateSignature";

		// Token: 0x04002C9D RID: 11421
		private static int RegisterId;

		// Token: 0x02000B50 RID: 2896
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnEffectApplied_DelegateParams
		{
			// Token: 0x04005C63 RID: 23651
			[FieldOffset(0)]
			public byte ActiveHandle;
		}

		// Token: 0x02000B51 RID: 2897
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005C64 RID: 23652
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
