using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EE1 RID: 7905
	public sealed class FOnApplicationLifeTime : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E0EF RID: 123119 RVA: 0x002C9C5B File Offset: 0x002C7E5B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnApplicationLifeTime.StaticFunctionPtr();
		}

		// Token: 0x0601E0F0 RID: 123120 RVA: 0x002C9C67 File Offset: 0x002C7E67
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnApplicationLifeTime._FunctionPtr == IntPtr.Zero)
			{
				FOnApplicationLifeTime._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnApplicationLifeTime__DelegateSignature");
			}
			return FOnApplicationLifeTime._FunctionPtr;
		}

		// Token: 0x0601E0F1 RID: 123121 RVA: 0x002C9C8A File Offset: 0x002C7E8A
		public FOnApplicationLifeTime()
		{
		}

		// Token: 0x0601E0F2 RID: 123122 RVA: 0x002C9C92 File Offset: 0x002C7E92
		[NullableContext(2)]
		public FOnApplicationLifeTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E0F3 RID: 123123 RVA: 0x002C9C9C File Offset: 0x002C7E9C
		public FOnApplicationLifeTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E0F4 RID: 123124 RVA: 0x002C9CA7 File Offset: 0x002C7EA7
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E0F5 RID: 123125 RVA: 0x002C9CD9 File Offset: 0x002C7ED9
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int> Callback)
		{
			if (FOnApplicationLifeTime.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnApplicationLifeTime.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnApplicationLifeTime.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnApplicationLifeTime.OnScriptCallback));
				}
				FOnApplicationLifeTime.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnApplicationLifeTime.RegisterId);
		}

		// Token: 0x0601E0F6 RID: 123126 RVA: 0x002C9D14 File Offset: 0x002C7F14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int Type)
		{
			FOnApplicationLifeTime.__FOnApplicationLifeTime_DelegateParams* ptr = stackalloc FOnApplicationLifeTime.__FOnApplicationLifeTime_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnApplicationLifeTime.__FOnApplicationLifeTime_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnApplicationLifeTime.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Type = Type;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E0F7 RID: 123127 RVA: 0x002C9D54 File Offset: 0x002C7F54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnApplicationLifeTime.__FOnApplicationLifeTime_DelegateParams*)__Parameters)->Type);
		}

		// Token: 0x040103FD RID: 66557
		internal static IntPtr _FunctionPtr;

		// Token: 0x040103FE RID: 66558
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnApplicationLifeTime__DelegateSignature";

		// Token: 0x040103FF RID: 66559
		private static int RegisterId;

		// Token: 0x020033AA RID: 13226
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnApplicationLifeTime_DelegateParams
		{
			// Token: 0x0401735F RID: 95071
			[FieldOffset(0)]
			public int Type;
		}

		// Token: 0x020033AB RID: 13227
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017360 RID: 95072
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
