using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F1D RID: 3869
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMontageEndedMCDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D103 RID: 53507 RVA: 0x00131A07 File Offset: 0x0012FC07
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMontageEndedMCDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600D104 RID: 53508 RVA: 0x00131A13 File Offset: 0x0012FC13
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMontageEndedMCDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnMontageEndedMCDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnMontageEndedMCDelegate__DelegateSignature");
			}
			return FOnMontageEndedMCDelegate._FunctionPtr;
		}

		// Token: 0x0600D105 RID: 53509 RVA: 0x00131A36 File Offset: 0x0012FC36
		public FOnMontageEndedMCDelegate()
		{
		}

		// Token: 0x0600D106 RID: 53510 RVA: 0x00131A3E File Offset: 0x0012FC3E
		[NullableContext(2)]
		public FOnMontageEndedMCDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D107 RID: 53511 RVA: 0x00131A48 File Offset: 0x0012FC48
		public FOnMontageEndedMCDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D108 RID: 53512 RVA: 0x00131A53 File Offset: 0x0012FC53
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UAnimMontage, bool>) ?? ((Action<UAnimMontage, bool>)Delegate.CreateDelegate(typeof(Action<UAnimMontage, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D109 RID: 53513 RVA: 0x00131A85 File Offset: 0x0012FC85
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0600D10A RID: 53514 RVA: 0x00131ABF File Offset: 0x0012FCBF
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UAnimMontage, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D10B RID: 53515 RVA: 0x00131AC8 File Offset: 0x0012FCC8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UAnimMontage Montage, bool bInterrupted)
		{
			FOnMontageEndedMCDelegate.__FOnMontageEndedMCDelegate_DelegateParams* ptr = stackalloc FOnMontageEndedMCDelegate.__FOnMontageEndedMCDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnMontageEndedMCDelegate.__FOnMontageEndedMCDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMontageEndedMCDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Montage = ((Montage != null) ? Montage.NativePtr : IntPtr.Zero);
			ptr->bInterrupted = bInterrupted;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D10C RID: 53516 RVA: 0x00131B1C File Offset: 0x0012FD1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04007065 RID: 28773
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007066 RID: 28774
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnMontageEndedMCDelegate__DelegateSignature";

		// Token: 0x04007067 RID: 28775
		private static int RegisterId;

		// Token: 0x02002D82 RID: 11650
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnMontageEndedMCDelegate_DelegateParams
		{
			// Token: 0x040167A4 RID: 92068
			[FieldOffset(0)]
			public IntPtr Montage;

			// Token: 0x040167A5 RID: 92069
			[FieldOffset(8)]
			public bool bInterrupted;
		}

		// Token: 0x02002D83 RID: 11651
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167A6 RID: 92070
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
