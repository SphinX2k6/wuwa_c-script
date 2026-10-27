using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018F6 RID: 6390
	public sealed class FKuroLoadResourceDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017B43 RID: 97091 RVA: 0x0022BC5D File Offset: 0x00229E5D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroLoadResourceDelegate.StaticFunctionPtr();
		}

		// Token: 0x06017B44 RID: 97092 RVA: 0x0022BC69 File Offset: 0x00229E69
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroLoadResourceDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroLoadResourceDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.KuroLoadResourceDelegate__DelegateSignature");
			}
			return FKuroLoadResourceDelegate._FunctionPtr;
		}

		// Token: 0x06017B45 RID: 97093 RVA: 0x0022BC8C File Offset: 0x00229E8C
		public FKuroLoadResourceDelegate()
		{
		}

		// Token: 0x06017B46 RID: 97094 RVA: 0x0022BC94 File Offset: 0x00229E94
		[NullableContext(2)]
		public FKuroLoadResourceDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017B47 RID: 97095 RVA: 0x0022BC9E File Offset: 0x00229E9E
		public FKuroLoadResourceDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017B48 RID: 97096 RVA: 0x0022BCA9 File Offset: 0x00229EA9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017B49 RID: 97097 RVA: 0x0022BCDB File Offset: 0x00229EDB
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int> Callback)
		{
			if (FKuroLoadResourceDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroLoadResourceDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroLoadResourceDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroLoadResourceDelegate.OnScriptCallback));
				}
				FKuroLoadResourceDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroLoadResourceDelegate.RegisterId);
		}

		// Token: 0x06017B4A RID: 97098 RVA: 0x0022BD18 File Offset: 0x00229F18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int HandleId)
		{
			FKuroLoadResourceDelegate.__FKuroLoadResourceDelegate_DelegateParams* ptr = stackalloc FKuroLoadResourceDelegate.__FKuroLoadResourceDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKuroLoadResourceDelegate.__FKuroLoadResourceDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroLoadResourceDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->HandleId = HandleId;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06017B4B RID: 97099 RVA: 0x0022BD58 File Offset: 0x00229F58
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
			action(((FKuroLoadResourceDelegate.__FKuroLoadResourceDelegate_DelegateParams*)__Parameters)->HandleId);
		}

		// Token: 0x0400CDEA RID: 52714
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CDEB RID: 52715
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroLoadResourceDelegate__DelegateSignature";

		// Token: 0x0400CDEC RID: 52716
		private static int RegisterId;

		// Token: 0x02002FD5 RID: 12245
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FKuroLoadResourceDelegate_DelegateParams
		{
			// Token: 0x04016BC5 RID: 93125
			[FieldOffset(0)]
			public int HandleId;
		}

		// Token: 0x02002FD6 RID: 12246
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016BC6 RID: 93126
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
