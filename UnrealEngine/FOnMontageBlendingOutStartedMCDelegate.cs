using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000256 RID: 598
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMontageBlendingOutStartedMCDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06003313 RID: 13075 RVA: 0x00049218 File Offset: 0x00047418
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMontageBlendingOutStartedMCDelegate.StaticFunctionPtr();
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x00049224 File Offset: 0x00047424
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMontageBlendingOutStartedMCDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnMontageBlendingOutStartedMCDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnMontageBlendingOutStartedMCDelegate__DelegateSignature");
			}
			return FOnMontageBlendingOutStartedMCDelegate._FunctionPtr;
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x00049247 File Offset: 0x00047447
		public FOnMontageBlendingOutStartedMCDelegate()
		{
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x0004924F File Offset: 0x0004744F
		[NullableContext(2)]
		public FOnMontageBlendingOutStartedMCDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x00049259 File Offset: 0x00047459
		public FOnMontageBlendingOutStartedMCDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x00049264 File Offset: 0x00047464
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UAnimMontage, bool>) ?? ((Action<UAnimMontage, bool>)Delegate.CreateDelegate(typeof(Action<UAnimMontage, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x00049296 File Offset: 0x00047496
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UAnimMontage, bool> Callback)
		{
			if (FOnMontageBlendingOutStartedMCDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMontageBlendingOutStartedMCDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMontageBlendingOutStartedMCDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMontageBlendingOutStartedMCDelegate.OnScriptCallback));
				}
				FOnMontageBlendingOutStartedMCDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMontageBlendingOutStartedMCDelegate.RegisterId);
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x000492D0 File Offset: 0x000474D0
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UAnimMontage, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x000492DC File Offset: 0x000474DC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UAnimMontage Montage, bool bInterrupted)
		{
			FOnMontageBlendingOutStartedMCDelegate.__FOnMontageBlendingOutStartedMCDelegate_DelegateParams* ptr = stackalloc FOnMontageBlendingOutStartedMCDelegate.__FOnMontageBlendingOutStartedMCDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnMontageBlendingOutStartedMCDelegate.__FOnMontageBlendingOutStartedMCDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMontageBlendingOutStartedMCDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Montage = ((Montage != null) ? Montage.NativePtr : IntPtr.Zero);
			ptr->bInterrupted = bInterrupted;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x00049330 File Offset: 0x00047530
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UAnimMontage, bool> action = target as Action<UAnimMontage, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UAnimMontage orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimMontage>(((FOnMontageBlendingOutStartedMCDelegate.__FOnMontageBlendingOutStartedMCDelegate_DelegateParams*)__Parameters)->Montage);
			action(orCreateUObjectByNativePointer, ((FOnMontageBlendingOutStartedMCDelegate.__FOnMontageBlendingOutStartedMCDelegate_DelegateParams*)__Parameters)->bInterrupted);
		}

		// Token: 0x040011CE RID: 4558
		internal static IntPtr _FunctionPtr;

		// Token: 0x040011CF RID: 4559
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnMontageBlendingOutStartedMCDelegate__DelegateSignature";

		// Token: 0x040011D0 RID: 4560
		private static int RegisterId;

		// Token: 0x020009D7 RID: 2519
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnMontageBlendingOutStartedMCDelegate_DelegateParams
		{
			// Token: 0x04005966 RID: 22886
			[FieldOffset(0)]
			public IntPtr Montage;

			// Token: 0x04005967 RID: 22887
			[FieldOffset(8)]
			public bool bInterrupted;
		}

		// Token: 0x020009D8 RID: 2520
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005968 RID: 22888
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
