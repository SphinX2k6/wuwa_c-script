using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200092B RID: 2347
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FCharacterReachedApexSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600844E RID: 33870 RVA: 0x000BD17A File Offset: 0x000BB37A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCharacterReachedApexSignature.StaticFunctionPtr();
		}

		// Token: 0x0600844F RID: 33871 RVA: 0x000BD186 File Offset: 0x000BB386
		private static IntPtr StaticFunctionPtr()
		{
			if (FCharacterReachedApexSignature._FunctionPtr == IntPtr.Zero)
			{
				FCharacterReachedApexSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.CharacterReachedApexSignature__DelegateSignature");
			}
			return FCharacterReachedApexSignature._FunctionPtr;
		}

		// Token: 0x06008450 RID: 33872 RVA: 0x000BD1A9 File Offset: 0x000BB3A9
		public FCharacterReachedApexSignature()
		{
		}

		// Token: 0x06008451 RID: 33873 RVA: 0x000BD1B1 File Offset: 0x000BB3B1
		[NullableContext(2)]
		public FCharacterReachedApexSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008452 RID: 33874 RVA: 0x000BD1BB File Offset: 0x000BB3BB
		public FCharacterReachedApexSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008453 RID: 33875 RVA: 0x000BD1C6 File Offset: 0x000BB3C6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008454 RID: 33876 RVA: 0x000BD1F8 File Offset: 0x000BB3F8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FCharacterReachedApexSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FCharacterReachedApexSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FCharacterReachedApexSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FCharacterReachedApexSignature.OnScriptCallback));
				}
				FCharacterReachedApexSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FCharacterReachedApexSignature.RegisterId);
		}

		// Token: 0x06008455 RID: 33877 RVA: 0x000BD232 File Offset: 0x000BB432
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06008456 RID: 33878 RVA: 0x000BD23B File Offset: 0x000BB43B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06008457 RID: 33879 RVA: 0x000BD248 File Offset: 0x000BB448
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x04003F2F RID: 16175
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F30 RID: 16176
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CharacterReachedApexSignature__DelegateSignature";

		// Token: 0x04003F31 RID: 16177
		private static int RegisterId;

		// Token: 0x02002CBE RID: 11454
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401664F RID: 91727
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
