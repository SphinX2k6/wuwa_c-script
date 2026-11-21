using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200079C RID: 1948
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnNavDataGenericEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A865 RID: 43109 RVA: 0x000F8A5A File Offset: 0x000F6C5A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnNavDataGenericEvent.StaticFunctionPtr();
		}

		// Token: 0x0600A866 RID: 43110 RVA: 0x000F8A66 File Offset: 0x000F6C66
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnNavDataGenericEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnNavDataGenericEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/NavigationSystem.OnNavDataGenericEvent__DelegateSignature");
			}
			return FOnNavDataGenericEvent._FunctionPtr;
		}

		// Token: 0x0600A867 RID: 43111 RVA: 0x000F8A89 File Offset: 0x000F6C89
		public FOnNavDataGenericEvent()
		{
		}

		// Token: 0x0600A868 RID: 43112 RVA: 0x000F8A91 File Offset: 0x000F6C91
		[NullableContext(2)]
		public FOnNavDataGenericEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A869 RID: 43113 RVA: 0x000F8A9B File Offset: 0x000F6C9B
		public FOnNavDataGenericEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A86A RID: 43114 RVA: 0x000F8AA6 File Offset: 0x000F6CA6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<ANavigationData>) ?? ((Action<ANavigationData>)Delegate.CreateDelegate(typeof(Action<ANavigationData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A86B RID: 43115 RVA: 0x000F8AD8 File Offset: 0x000F6CD8
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

		// Token: 0x0600A86C RID: 43116 RVA: 0x000F8B12 File Offset: 0x000F6D12
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<ANavigationData> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600A86D RID: 43117 RVA: 0x000F8B1C File Offset: 0x000F6D1C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(ANavigationData NavData)
		{
			FOnNavDataGenericEvent.__FOnNavDataGenericEvent_DelegateParams* ptr = stackalloc FOnNavDataGenericEvent.__FOnNavDataGenericEvent_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnNavDataGenericEvent.__FOnNavDataGenericEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnNavDataGenericEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NavData = ((NavData != null) ? NavData.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600A86E RID: 43118 RVA: 0x000F8B68 File Offset: 0x000F6D68
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400481D RID: 18461
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400481E RID: 18462
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NavigationSystem.OnNavDataGenericEvent__DelegateSignature";

		// Token: 0x0400481F RID: 18463
		private static int RegisterId;

		// Token: 0x02000F5D RID: 3933
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnNavDataGenericEvent_DelegateParams
		{
			// Token: 0x04006333 RID: 25395
			[FieldOffset(0)]
			public IntPtr NavData;
		}

		// Token: 0x02000F5E RID: 3934
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006334 RID: 25396
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
