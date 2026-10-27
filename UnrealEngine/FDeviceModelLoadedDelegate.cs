using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200145F RID: 5215
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FDeviceModelLoadedDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601308A RID: 77962 RVA: 0x001C013D File Offset: 0x001BE33D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FDeviceModelLoadedDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601308B RID: 77963 RVA: 0x001C0149 File Offset: 0x001BE349
		private static IntPtr StaticFunctionPtr()
		{
			if (FDeviceModelLoadedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FDeviceModelLoadedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/HeadMountedDisplay.DeviceModelLoadedDelegate__DelegateSignature");
			}
			return FDeviceModelLoadedDelegate._FunctionPtr;
		}

		// Token: 0x0601308C RID: 77964 RVA: 0x001C016C File Offset: 0x001BE36C
		public FDeviceModelLoadedDelegate()
		{
		}

		// Token: 0x0601308D RID: 77965 RVA: 0x001C0174 File Offset: 0x001BE374
		[NullableContext(2)]
		public FDeviceModelLoadedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601308E RID: 77966 RVA: 0x001C017E File Offset: 0x001BE37E
		public FDeviceModelLoadedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601308F RID: 77967 RVA: 0x001C0189 File Offset: 0x001BE389
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent>) ?? ((Action<UPrimitiveComponent>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06013090 RID: 77968 RVA: 0x001C01BB File Offset: 0x001BE3BB
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UPrimitiveComponent> Callback)
		{
			if (FDeviceModelLoadedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FDeviceModelLoadedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FDeviceModelLoadedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FDeviceModelLoadedDelegate.OnScriptCallback));
				}
				FDeviceModelLoadedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FDeviceModelLoadedDelegate.RegisterId);
		}

		// Token: 0x06013091 RID: 77969 RVA: 0x001C01F5 File Offset: 0x001BE3F5
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UPrimitiveComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06013092 RID: 77970 RVA: 0x001C0200 File Offset: 0x001BE400
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UPrimitiveComponent LoadedComponent)
		{
			FDeviceModelLoadedDelegate.__FDeviceModelLoadedDelegate_DelegateParams* ptr = stackalloc FDeviceModelLoadedDelegate.__FDeviceModelLoadedDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FDeviceModelLoadedDelegate.__FDeviceModelLoadedDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FDeviceModelLoadedDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->LoadedComponent = ((LoadedComponent != null) ? LoadedComponent.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06013093 RID: 77971 RVA: 0x001C024C File Offset: 0x001BE44C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UPrimitiveComponent> action = target as Action<UPrimitiveComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FDeviceModelLoadedDelegate.__FDeviceModelLoadedDelegate_DelegateParams*)__Parameters)->LoadedComponent);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400A343 RID: 41795
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400A344 RID: 41796
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HeadMountedDisplay.DeviceModelLoadedDelegate__DelegateSignature";

		// Token: 0x0400A345 RID: 41797
		private static int RegisterId;

		// Token: 0x02002EA9 RID: 11945
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FDeviceModelLoadedDelegate_DelegateParams
		{
			// Token: 0x0401699A RID: 92570
			[FieldOffset(0)]
			public IntPtr LoadedComponent;
		}

		// Token: 0x02002EAA RID: 11946
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401699B RID: 92571
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
