using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001970 RID: 6512
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnInhibitionChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018336 RID: 99126 RVA: 0x0023ADE2 File Offset: 0x00238FE2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnInhibitionChanged.StaticFunctionPtr();
		}

		// Token: 0x06018337 RID: 99127 RVA: 0x0023ADEE File Offset: 0x00238FEE
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnInhibitionChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnInhibitionChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnInhibitionChanged__DelegateSignature");
			}
			return FOnInhibitionChanged._FunctionPtr;
		}

		// Token: 0x06018338 RID: 99128 RVA: 0x0023AE11 File Offset: 0x00239011
		public FOnInhibitionChanged()
		{
		}

		// Token: 0x06018339 RID: 99129 RVA: 0x0023AE19 File Offset: 0x00239019
		[NullableContext(2)]
		public FOnInhibitionChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601833A RID: 99130 RVA: 0x0023AE23 File Offset: 0x00239023
		public FOnInhibitionChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601833B RID: 99131 RVA: 0x0023AE2E File Offset: 0x0023902E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601833C RID: 99132 RVA: 0x0023AE60 File Offset: 0x00239060
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool> Callback)
		{
			if (FOnInhibitionChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnInhibitionChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnInhibitionChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnInhibitionChanged.OnScriptCallback));
				}
				FOnInhibitionChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnInhibitionChanged.RegisterId);
		}

		// Token: 0x0601833D RID: 99133 RVA: 0x0023AE9A File Offset: 0x0023909A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601833E RID: 99134 RVA: 0x0023AEA4 File Offset: 0x002390A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool IsInhibited)
		{
			FOnInhibitionChanged.__FOnInhibitionChanged_DelegateParams* ptr = stackalloc FOnInhibitionChanged.__FOnInhibitionChanged_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnInhibitionChanged.__FOnInhibitionChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnInhibitionChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->IsInhibited = IsInhibited;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601833F RID: 99135 RVA: 0x0023AEE0 File Offset: 0x002390E0
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
			action(((FOnInhibitionChanged.__FOnInhibitionChanged_DelegateParams*)__Parameters)->IsInhibited);
		}

		// Token: 0x0400D1C6 RID: 53702
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D1C7 RID: 53703
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnInhibitionChanged__DelegateSignature";

		// Token: 0x0400D1C8 RID: 53704
		private static int RegisterId;

		// Token: 0x02003062 RID: 12386
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnInhibitionChanged_DelegateParams
		{
			// Token: 0x04016D30 RID: 93488
			[FieldOffset(0)]
			public bool IsInhibited;
		}

		// Token: 0x02003063 RID: 12387
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D31 RID: 93489
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
