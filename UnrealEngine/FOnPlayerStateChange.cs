using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E6A RID: 7786
	public sealed class FOnPlayerStateChange : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DAA1 RID: 121505 RVA: 0x002BCFE7 File Offset: 0x002BB1E7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnPlayerStateChange.StaticFunctionPtr();
		}

		// Token: 0x0601DAA2 RID: 121506 RVA: 0x002BCFF3 File Offset: 0x002BB1F3
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnPlayerStateChange._FunctionPtr == IntPtr.Zero)
			{
				FOnPlayerStateChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnPlayerStateChange__DelegateSignature");
			}
			return FOnPlayerStateChange._FunctionPtr;
		}

		// Token: 0x0601DAA3 RID: 121507 RVA: 0x002BD016 File Offset: 0x002BB216
		public FOnPlayerStateChange()
		{
		}

		// Token: 0x0601DAA4 RID: 121508 RVA: 0x002BD01E File Offset: 0x002BB21E
		[NullableContext(2)]
		public FOnPlayerStateChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DAA5 RID: 121509 RVA: 0x002BD028 File Offset: 0x002BB228
		public FOnPlayerStateChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DAA6 RID: 121510 RVA: 0x002BD033 File Offset: 0x002BB233
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DAA7 RID: 121511 RVA: 0x002BD065 File Offset: 0x002BB265
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<bool> Callback)
		{
			if (FOnPlayerStateChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnPlayerStateChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnPlayerStateChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnPlayerStateChange.OnScriptCallback));
				}
				FOnPlayerStateChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnPlayerStateChange.RegisterId);
		}

		// Token: 0x0601DAA8 RID: 121512 RVA: 0x002BD0A0 File Offset: 0x002BB2A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool IsAlive)
		{
			FOnPlayerStateChange.__FOnPlayerStateChange_DelegateParams* ptr = stackalloc FOnPlayerStateChange.__FOnPlayerStateChange_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnPlayerStateChange.__FOnPlayerStateChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnPlayerStateChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->IsAlive = IsAlive;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601DAA9 RID: 121513 RVA: 0x002BD0E0 File Offset: 0x002BB2E0
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
			action(((FOnPlayerStateChange.__FOnPlayerStateChange_DelegateParams*)__Parameters)->IsAlive);
		}

		// Token: 0x04010121 RID: 65825
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010122 RID: 65826
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnPlayerStateChange__DelegateSignature";

		// Token: 0x04010123 RID: 65827
		private static int RegisterId;

		// Token: 0x020032BE RID: 12990
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnPlayerStateChange_DelegateParams
		{
			// Token: 0x04017162 RID: 94562
			[FieldOffset(0)]
			public bool IsAlive;
		}

		// Token: 0x020032BF RID: 12991
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017163 RID: 94563
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
