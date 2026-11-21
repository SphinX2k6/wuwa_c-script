using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000599 RID: 1433
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnKSCBuffChange : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060081E6 RID: 33254 RVA: 0x000BFC63 File Offset: 0x000BDE63
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKSCBuffChange.StaticFunctionPtr();
		}

		// Token: 0x060081E7 RID: 33255 RVA: 0x000BFC6F File Offset: 0x000BDE6F
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKSCBuffChange._FunctionPtr == IntPtr.Zero)
			{
				FOnKSCBuffChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnKSCBuffChange__DelegateSignature");
			}
			return FOnKSCBuffChange._FunctionPtr;
		}

		// Token: 0x060081E8 RID: 33256 RVA: 0x000BFC92 File Offset: 0x000BDE92
		public FOnKSCBuffChange()
		{
		}

		// Token: 0x060081E9 RID: 33257 RVA: 0x000BFC9A File Offset: 0x000BDE9A
		[NullableContext(2)]
		public FOnKSCBuffChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060081EA RID: 33258 RVA: 0x000BFCA4 File Offset: 0x000BDEA4
		public FOnKSCBuffChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060081EB RID: 33259 RVA: 0x000BFCAF File Offset: 0x000BDEAF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UKSC_DA_Buff, int>) ?? ((Action<UKSC_DA_Buff, int>)Delegate.CreateDelegate(typeof(Action<UKSC_DA_Buff, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060081EC RID: 33260 RVA: 0x000BFCE1 File Offset: 0x000BDEE1
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UKSC_DA_Buff, int> Callback)
		{
			if (FOnKSCBuffChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnKSCBuffChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnKSCBuffChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnKSCBuffChange.OnScriptCallback));
				}
				FOnKSCBuffChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnKSCBuffChange.RegisterId);
		}

		// Token: 0x060081ED RID: 33261 RVA: 0x000BFD1B File Offset: 0x000BDF1B
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UKSC_DA_Buff, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060081EE RID: 33262 RVA: 0x000BFD24 File Offset: 0x000BDF24
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UKSC_DA_Buff BuffDa, int Count)
		{
			FOnKSCBuffChange.__FOnKSCBuffChange_DelegateParams* ptr = stackalloc FOnKSCBuffChange.__FOnKSCBuffChange_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnKSCBuffChange.__FOnKSCBuffChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnKSCBuffChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->BuffDa = ((BuffDa != null) ? BuffDa.NativePtr : IntPtr.Zero);
			ptr->Count = Count;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060081EF RID: 33263 RVA: 0x000BFD78 File Offset: 0x000BDF78
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UKSC_DA_Buff, int> action = target as Action<UKSC_DA_Buff, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UKSC_DA_Buff orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKSC_DA_Buff>(((FOnKSCBuffChange.__FOnKSCBuffChange_DelegateParams*)__Parameters)->BuffDa);
			action(orCreateUObjectByNativePointer, ((FOnKSCBuffChange.__FOnKSCBuffChange_DelegateParams*)__Parameters)->Count);
		}

		// Token: 0x040038AA RID: 14506
		internal static IntPtr _FunctionPtr;

		// Token: 0x040038AB RID: 14507
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnKSCBuffChange__DelegateSignature";

		// Token: 0x040038AC RID: 14508
		private static int RegisterId;

		// Token: 0x02000D12 RID: 3346
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnKSCBuffChange_DelegateParams
		{
			// Token: 0x04005FA2 RID: 24482
			[FieldOffset(0)]
			public IntPtr BuffDa;

			// Token: 0x04005FA3 RID: 24483
			[FieldOffset(8)]
			public int Count;
		}

		// Token: 0x02000D13 RID: 3347
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FA4 RID: 24484
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
