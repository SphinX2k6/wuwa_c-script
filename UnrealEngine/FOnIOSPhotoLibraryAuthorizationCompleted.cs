using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001947 RID: 6471
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnIOSPhotoLibraryAuthorizationCompleted : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017FB2 RID: 98226 RVA: 0x00232CF2 File Offset: 0x00230EF2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnIOSPhotoLibraryAuthorizationCompleted.StaticFunctionPtr();
		}

		// Token: 0x06017FB3 RID: 98227 RVA: 0x00232CFE File Offset: 0x00230EFE
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnIOSPhotoLibraryAuthorizationCompleted._FunctionPtr == IntPtr.Zero)
			{
				FOnIOSPhotoLibraryAuthorizationCompleted._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameScreenshot.OnIOSPhotoLibraryAuthorizationCompleted__DelegateSignature");
			}
			return FOnIOSPhotoLibraryAuthorizationCompleted._FunctionPtr;
		}

		// Token: 0x06017FB4 RID: 98228 RVA: 0x00232D21 File Offset: 0x00230F21
		public FOnIOSPhotoLibraryAuthorizationCompleted()
		{
		}

		// Token: 0x06017FB5 RID: 98229 RVA: 0x00232D29 File Offset: 0x00230F29
		[NullableContext(2)]
		public FOnIOSPhotoLibraryAuthorizationCompleted(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017FB6 RID: 98230 RVA: 0x00232D33 File Offset: 0x00230F33
		public FOnIOSPhotoLibraryAuthorizationCompleted(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017FB7 RID: 98231 RVA: 0x00232D3E File Offset: 0x00230F3E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017FB8 RID: 98232 RVA: 0x00232D70 File Offset: 0x00230F70
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool> Callback)
		{
			if (FOnIOSPhotoLibraryAuthorizationCompleted.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnIOSPhotoLibraryAuthorizationCompleted.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnIOSPhotoLibraryAuthorizationCompleted.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnIOSPhotoLibraryAuthorizationCompleted.OnScriptCallback));
				}
				FOnIOSPhotoLibraryAuthorizationCompleted.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnIOSPhotoLibraryAuthorizationCompleted.RegisterId);
		}

		// Token: 0x06017FB9 RID: 98233 RVA: 0x00232DAA File Offset: 0x00230FAA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06017FBA RID: 98234 RVA: 0x00232DB4 File Offset: 0x00230FB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool IsGranted)
		{
			FOnIOSPhotoLibraryAuthorizationCompleted.__FOnIOSPhotoLibraryAuthorizationCompleted_DelegateParams* ptr = stackalloc FOnIOSPhotoLibraryAuthorizationCompleted.__FOnIOSPhotoLibraryAuthorizationCompleted_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnIOSPhotoLibraryAuthorizationCompleted.__FOnIOSPhotoLibraryAuthorizationCompleted_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnIOSPhotoLibraryAuthorizationCompleted.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->IsGranted = IsGranted;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06017FBB RID: 98235 RVA: 0x00232DF0 File Offset: 0x00230FF0
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
			action(((FOnIOSPhotoLibraryAuthorizationCompleted.__FOnIOSPhotoLibraryAuthorizationCompleted_DelegateParams*)__Parameters)->IsGranted);
		}

		// Token: 0x0400CF8F RID: 53135
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CF90 RID: 53136
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameScreenshot.OnIOSPhotoLibraryAuthorizationCompleted__DelegateSignature";

		// Token: 0x0400CF91 RID: 53137
		private static int RegisterId;

		// Token: 0x02003017 RID: 12311
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnIOSPhotoLibraryAuthorizationCompleted_DelegateParams
		{
			// Token: 0x04016C4D RID: 93261
			[FieldOffset(0)]
			public bool IsGranted;
		}

		// Token: 0x02003018 RID: 12312
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016C4E RID: 93262
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
