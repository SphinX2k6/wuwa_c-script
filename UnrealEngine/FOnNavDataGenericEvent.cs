using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024AA RID: 9386
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnNavDataGenericEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060231E4 RID: 143844 RVA: 0x0033EF06 File Offset: 0x0033D106
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnNavDataGenericEvent.StaticFunctionPtr();
		}

		// Token: 0x060231E5 RID: 143845 RVA: 0x0033EF12 File Offset: 0x0033D112
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnNavDataGenericEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnNavDataGenericEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/NavigationSystem.OnNavDataGenericEvent__DelegateSignature");
			}
			return FOnNavDataGenericEvent._FunctionPtr;
		}

		// Token: 0x060231E6 RID: 143846 RVA: 0x0033EF35 File Offset: 0x0033D135
		public FOnNavDataGenericEvent()
		{
		}

		// Token: 0x060231E7 RID: 143847 RVA: 0x0033EF3D File Offset: 0x0033D13D
		[NullableContext(2)]
		public FOnNavDataGenericEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060231E8 RID: 143848 RVA: 0x0033EF47 File Offset: 0x0033D147
		public FOnNavDataGenericEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060231E9 RID: 143849 RVA: 0x0033EF52 File Offset: 0x0033D152
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<ANavigationData>) ?? ((Action<ANavigationData>)Delegate.CreateDelegate(typeof(Action<ANavigationData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060231EA RID: 143850 RVA: 0x0033EF84 File Offset: 0x0033D184
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<ANavigationData> Callback)
		{
			if (FOnNavDataGenericEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnNavDataGenericEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnNavDataGenericEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnNavDataGenericEvent.OnScriptCallback));
				}
				FOnNavDataGenericEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnNavDataGenericEvent.RegisterId);
		}

		// Token: 0x060231EB RID: 143851 RVA: 0x0033EFBE File Offset: 0x0033D1BE
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<ANavigationData> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060231EC RID: 143852 RVA: 0x0033EFC8 File Offset: 0x0033D1C8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(ANavigationData NavData)
		{
			FOnNavDataGenericEvent.__FOnNavDataGenericEvent_DelegateParams* ptr = stackalloc FOnNavDataGenericEvent.__FOnNavDataGenericEvent_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnNavDataGenericEvent.__FOnNavDataGenericEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnNavDataGenericEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NavData = ((NavData != null) ? NavData.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060231ED RID: 143853 RVA: 0x0033F014 File Offset: 0x0033D214
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<ANavigationData> action = target as Action<ANavigationData>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ANavigationData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ANavigationData>(((FOnNavDataGenericEvent.__FOnNavDataGenericEvent_DelegateParams*)__Parameters)->NavData);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04012BF7 RID: 76791
		internal static IntPtr _FunctionPtr;

		// Token: 0x04012BF8 RID: 76792
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NavigationSystem.OnNavDataGenericEvent__DelegateSignature";

		// Token: 0x04012BF9 RID: 76793
		private static int RegisterId;

		// Token: 0x02003668 RID: 13928
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnNavDataGenericEvent_DelegateParams
		{
			// Token: 0x04017739 RID: 96057
			[FieldOffset(0)]
			public IntPtr NavData;
		}

		// Token: 0x02003669 RID: 13929
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401773A RID: 96058
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
