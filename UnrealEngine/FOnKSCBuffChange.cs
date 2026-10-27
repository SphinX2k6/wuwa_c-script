using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E66 RID: 7782
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnKSCBuffChange : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DA7C RID: 121468 RVA: 0x002BC987 File Offset: 0x002BAB87
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKSCBuffChange.StaticFunctionPtr();
		}

		// Token: 0x0601DA7D RID: 121469 RVA: 0x002BC993 File Offset: 0x002BAB93
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKSCBuffChange._FunctionPtr == IntPtr.Zero)
			{
				FOnKSCBuffChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnKSCBuffChange__DelegateSignature");
			}
			return FOnKSCBuffChange._FunctionPtr;
		}

		// Token: 0x0601DA7E RID: 121470 RVA: 0x002BC9B6 File Offset: 0x002BABB6
		public FOnKSCBuffChange()
		{
		}

		// Token: 0x0601DA7F RID: 121471 RVA: 0x002BC9BE File Offset: 0x002BABBE
		[NullableContext(2)]
		public FOnKSCBuffChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DA80 RID: 121472 RVA: 0x002BC9C8 File Offset: 0x002BABC8
		public FOnKSCBuffChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DA81 RID: 121473 RVA: 0x002BC9D3 File Offset: 0x002BABD3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UKSC_DA_Buff, int>) ?? ((Action<UKSC_DA_Buff, int>)Delegate.CreateDelegate(typeof(Action<UKSC_DA_Buff, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DA82 RID: 121474 RVA: 0x002BCA05 File Offset: 0x002BAC05
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601DA83 RID: 121475 RVA: 0x002BCA3F File Offset: 0x002BAC3F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UKSC_DA_Buff, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DA84 RID: 121476 RVA: 0x002BCA48 File Offset: 0x002BAC48
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UKSC_DA_Buff BuffDa, int Count)
		{
			FOnKSCBuffChange.__FOnKSCBuffChange_DelegateParams* ptr = stackalloc FOnKSCBuffChange.__FOnKSCBuffChange_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnKSCBuffChange.__FOnKSCBuffChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnKSCBuffChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->BuffDa = ((BuffDa != null) ? BuffDa.NativePtr : IntPtr.Zero);
			ptr->Count = Count;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601DA85 RID: 121477 RVA: 0x002BCA9C File Offset: 0x002BAC9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04010115 RID: 65813
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010116 RID: 65814
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnKSCBuffChange__DelegateSignature";

		// Token: 0x04010117 RID: 65815
		private static int RegisterId;

		// Token: 0x020032B3 RID: 12979
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnKSCBuffChange_DelegateParams
		{
			// Token: 0x04017156 RID: 94550
			[FieldOffset(0)]
			public IntPtr BuffDa;

			// Token: 0x04017157 RID: 94551
			[FieldOffset(8)]
			public int Count;
		}

		// Token: 0x020032B4 RID: 12980
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017158 RID: 94552
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
