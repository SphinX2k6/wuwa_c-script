using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001B8 RID: 440
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentSleepSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06002057 RID: 8279 RVA: 0x0002F952 File Offset: 0x0002DB52
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentSleepSignature.StaticFunctionPtr();
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x0002F95E File Offset: 0x0002DB5E
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentSleepSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentSleepSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentSleepSignature__DelegateSignature");
			}
			return FComponentSleepSignature._FunctionPtr;
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06002059 RID: 8281 RVA: 0x0002F981 File Offset: 0x0002DB81
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnComponentSleep;
			}
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x0002F988 File Offset: 0x0002DB88
		[NullableContext(2)]
		public FComponentSleepSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x0002F992 File Offset: 0x0002DB92
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent, FName>) ?? ((Action<UPrimitiveComponent, FName>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent, FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x0002F9C4 File Offset: 0x0002DBC4
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UPrimitiveComponent, FName> Callback)
		{
			if (FComponentSleepSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentSleepSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentSleepSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentSleepSignature.OnScriptCallback));
				}
				FComponentSleepSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentSleepSignature.RegisterId);
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x0002FA14 File Offset: 0x0002DC14
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UPrimitiveComponent, FName> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x0002FA34 File Offset: 0x0002DC34
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UPrimitiveComponent SleepingComponent, FName BoneName)
		{
			FComponentSleepSignature.__FComponentSleepSignature_DelegateParams* ptr = stackalloc FComponentSleepSignature.__FComponentSleepSignature_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FComponentSleepSignature.__FComponentSleepSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentSleepSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SleepingComponent = ((SleepingComponent != null) ? SleepingComponent.NativePtr : IntPtr.Zero);
			ptr->BoneName = BoneName;
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x0002FA98 File Offset: 0x0002DC98
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UPrimitiveComponent, FName> action = target as Action<UPrimitiveComponent, FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentSleepSignature.__FComponentSleepSignature_DelegateParams*)__Parameters)->SleepingComponent);
			action(orCreateUObjectByNativePointer, ((FComponentSleepSignature.__FComponentSleepSignature_DelegateParams*)__Parameters)->BoneName);
		}

		// Token: 0x04000AC1 RID: 2753
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000AC2 RID: 2754
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentSleepSignature__DelegateSignature";

		// Token: 0x04000AC3 RID: 2755
		private static int RegisterId;

		// Token: 0x02000997 RID: 2455
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FComponentSleepSignature_DelegateParams
		{
			// Token: 0x040058FC RID: 22780
			[FieldOffset(0)]
			public IntPtr SleepingComponent;

			// Token: 0x040058FD RID: 22781
			[FieldOffset(8)]
			public FName BoneName;
		}

		// Token: 0x02000998 RID: 2456
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040058FE RID: 22782
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
