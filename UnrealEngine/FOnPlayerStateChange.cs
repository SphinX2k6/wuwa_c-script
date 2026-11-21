using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200059D RID: 1437
	public sealed class FOnPlayerStateChange : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600820B RID: 33291 RVA: 0x000C02C3 File Offset: 0x000BE4C3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnPlayerStateChange.StaticFunctionPtr();
		}

		// Token: 0x0600820C RID: 33292 RVA: 0x000C02CF File Offset: 0x000BE4CF
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnPlayerStateChange._FunctionPtr == IntPtr.Zero)
			{
				FOnPlayerStateChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnPlayerStateChange__DelegateSignature");
			}
			return FOnPlayerStateChange._FunctionPtr;
		}

		// Token: 0x0600820D RID: 33293 RVA: 0x000C02F2 File Offset: 0x000BE4F2
		public FOnPlayerStateChange()
		{
		}

		// Token: 0x0600820E RID: 33294 RVA: 0x000C02FA File Offset: 0x000BE4FA
		[NullableContext(2)]
		public FOnPlayerStateChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600820F RID: 33295 RVA: 0x000C0304 File Offset: 0x000BE504
		public FOnPlayerStateChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008210 RID: 33296 RVA: 0x000C030F File Offset: 0x000BE50F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008211 RID: 33297 RVA: 0x000C0341 File Offset: 0x000BE541
		[NullableContext(1)]
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

		// Token: 0x06008212 RID: 33298 RVA: 0x000C037C File Offset: 0x000BE57C
		[SkipLocalsInit]
		public unsafe void Execute(bool IsAlive)
		{
			FOnPlayerStateChange.__FOnPlayerStateChange_DelegateParams* ptr = stackalloc FOnPlayerStateChange.__FOnPlayerStateChange_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnPlayerStateChange.__FOnPlayerStateChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnPlayerStateChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->IsAlive = IsAlive;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06008213 RID: 33299 RVA: 0x000C03BC File Offset: 0x000BE5BC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnPlayerStateChange.__FOnPlayerStateChange_DelegateParams*)__Parameters)->IsAlive);
		}

		// Token: 0x040038B6 RID: 14518
		internal static IntPtr _FunctionPtr;

		// Token: 0x040038B7 RID: 14519
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnPlayerStateChange__DelegateSignature";

		// Token: 0x040038B8 RID: 14520
		private static int RegisterId;

		// Token: 0x02000D1D RID: 3357
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FOnPlayerStateChange_DelegateParams
		{
			// Token: 0x04005FAE RID: 24494
			[FieldOffset(0)]
			public bool IsAlive;
		}

		// Token: 0x02000D1E RID: 3358
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FAF RID: 24495
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
