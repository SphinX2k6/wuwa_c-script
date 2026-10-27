using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200273B RID: 10043
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FSharpherealTestSparseMultiDelegate1 : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060252D5 RID: 152277 RVA: 0x003712B2 File Offset: 0x0036F4B2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealTestSparseMultiDelegate1.StaticFunctionPtr();
		}

		// Token: 0x060252D6 RID: 152278 RVA: 0x003712BE File Offset: 0x0036F4BE
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealTestSparseMultiDelegate1._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealTestSparseMultiDelegate1._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SharpherealTest.SharpherealTestSparseMultiDelegate1__DelegateSignature");
			}
			return FSharpherealTestSparseMultiDelegate1._FunctionPtr;
		}

		// Token: 0x17008F6B RID: 36715
		// (get) Token: 0x060252D7 RID: 152279 RVA: 0x003712E1 File Offset: 0x0036F4E1
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.SparseMulti1;
			}
		}

		// Token: 0x060252D8 RID: 152280 RVA: 0x003712E8 File Offset: 0x0036F4E8
		[NullableContext(2)]
		public FSharpherealTestSparseMultiDelegate1(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060252D9 RID: 152281 RVA: 0x003712F2 File Offset: 0x0036F4F2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060252DA RID: 152282 RVA: 0x00371324 File Offset: 0x0036F524
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (FSharpherealTestSparseMultiDelegate1.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealTestSparseMultiDelegate1.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealTestSparseMultiDelegate1.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealTestSparseMultiDelegate1.OnScriptCallback));
				}
				FSharpherealTestSparseMultiDelegate1.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FSharpherealTestSparseMultiDelegate1.RegisterId);
		}

		// Token: 0x060252DB RID: 152283 RVA: 0x00371374 File Offset: 0x0036F574
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x060252DC RID: 152284 RVA: 0x00371394 File Offset: 0x0036F594
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int Val)
		{
			FSharpherealTestSparseMultiDelegate1.__FSharpherealTestSparseMultiDelegate1_DelegateParams* ptr = stackalloc FSharpherealTestSparseMultiDelegate1.__FSharpherealTestSparseMultiDelegate1_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FSharpherealTestSparseMultiDelegate1.__FSharpherealTestSparseMultiDelegate1_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSharpherealTestSparseMultiDelegate1.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Val = Val;
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x060252DD RID: 152285 RVA: 0x003713E0 File Offset: 0x0036F5E0
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
			action(((FSharpherealTestSparseMultiDelegate1.__FSharpherealTestSparseMultiDelegate1_DelegateParams*)__Parameters)->Val);
		}

		// Token: 0x04014096 RID: 82070
		internal static IntPtr _FunctionPtr;

		// Token: 0x04014097 RID: 82071
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestSparseMultiDelegate1__DelegateSignature";

		// Token: 0x04014098 RID: 82072
		private static int RegisterId;

		// Token: 0x020036C8 RID: 14024
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FSharpherealTestSparseMultiDelegate1_DelegateParams
		{
			// Token: 0x040177EB RID: 96235
			[FieldOffset(0)]
			public int Val;
		}

		// Token: 0x020036C9 RID: 14025
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040177EC RID: 96236
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
