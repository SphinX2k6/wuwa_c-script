using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000257 RID: 599
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMontageEndedMCDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600331D RID: 13085 RVA: 0x00049387 File Offset: 0x00047587
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMontageEndedMCDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x00049393 File Offset: 0x00047593
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMontageEndedMCDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnMontageEndedMCDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnMontageEndedMCDelegate__DelegateSignature");
			}
			return FOnMontageEndedMCDelegate._FunctionPtr;
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x000493B6 File Offset: 0x000475B6
		public FOnMontageEndedMCDelegate()
		{
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x000493BE File Offset: 0x000475BE
		[NullableContext(2)]
		public FOnMontageEndedMCDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x000493C8 File Offset: 0x000475C8
		public FOnMontageEndedMCDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x000493D3 File Offset: 0x000475D3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UAnimMontage, bool>) ?? ((Action<UAnimMontage, bool>)Delegate.CreateDelegate(typeof(Action<UAnimMontage, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06003323 RID: 13091 RVA: 0x00049405 File Offset: 0x00047605
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UAnimMontage, bool> Callback)
		{
			if (FOnMontageEndedMCDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMontageEndedMCDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMontageEndedMCDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMontageEndedMCDelegate.OnScriptCallback));
				}
				FOnMontageEndedMCDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMontageEndedMCDelegate.RegisterId);
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x0004943F File Offset: 0x0004763F
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UAnimMontage, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x00049448 File Offset: 0x00047648
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UAnimMontage Montage, bool bInterrupted)
		{
			FOnMontageEndedMCDelegate.__FOnMontageEndedMCDelegate_DelegateParams* ptr = stackalloc FOnMontageEndedMCDelegate.__FOnMontageEndedMCDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnMontageEndedMCDelegate.__FOnMontageEndedMCDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMontageEndedMCDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Montage = ((Montage != null) ? Montage.NativePtr : IntPtr.Zero);
			ptr->bInterrupted = bInterrupted;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x0004949C File Offset: 0x0004769C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UAnimMontage, bool> action = target as Action<UAnimMontage, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UAnimMontage orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimMontage>(((FOnMontageEndedMCDelegate.__FOnMontageEndedMCDelegate_DelegateParams*)__Parameters)->Montage);
			action(orCreateUObjectByNativePointer, ((FOnMontageEndedMCDelegate.__FOnMontageEndedMCDelegate_DelegateParams*)__Parameters)->bInterrupted);
		}

		// Token: 0x040011D1 RID: 4561
		internal static IntPtr _FunctionPtr;

		// Token: 0x040011D2 RID: 4562
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnMontageEndedMCDelegate__DelegateSignature";

		// Token: 0x040011D3 RID: 4563
		private static int RegisterId;

		// Token: 0x020009D9 RID: 2521
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnMontageEndedMCDelegate_DelegateParams
		{
			// Token: 0x04005969 RID: 22889
			[FieldOffset(0)]
			public IntPtr Montage;

			// Token: 0x0400596A RID: 22890
			[FieldOffset(8)]
			public bool bInterrupted;
		}

		// Token: 0x020009DA RID: 2522
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400596B RID: 22891
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
