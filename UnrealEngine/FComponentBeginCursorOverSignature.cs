using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001AA RID: 426
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentBeginCursorOverSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001FD9 RID: 8153 RVA: 0x0002E00C File Offset: 0x0002C20C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentBeginCursorOverSignature.StaticFunctionPtr();
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x0002E018 File Offset: 0x0002C218
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentBeginCursorOverSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentBeginCursorOverSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentBeginCursorOverSignature__DelegateSignature");
			}
			return FComponentBeginCursorOverSignature._FunctionPtr;
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x0002E03B File Offset: 0x0002C23B
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnBeginCursorOver;
			}
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x0002E042 File Offset: 0x0002C242
		[NullableContext(2)]
		public FComponentBeginCursorOverSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x0002E04C File Offset: 0x0002C24C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent>) ?? ((Action<UPrimitiveComponent>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x0002E080 File Offset: 0x0002C280
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UPrimitiveComponent> Callback)
		{
			if (FComponentBeginCursorOverSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentBeginCursorOverSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentBeginCursorOverSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentBeginCursorOverSignature.OnScriptCallback));
				}
				FComponentBeginCursorOverSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentBeginCursorOverSignature.RegisterId);
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x0002E0D0 File Offset: 0x0002C2D0
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UPrimitiveComponent> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x0002E0F0 File Offset: 0x0002C2F0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UPrimitiveComponent TouchedComponent)
		{
			FComponentBeginCursorOverSignature.__FComponentBeginCursorOverSignature_DelegateParams* ptr = stackalloc FComponentBeginCursorOverSignature.__FComponentBeginCursorOverSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FComponentBeginCursorOverSignature.__FComponentBeginCursorOverSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentBeginCursorOverSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchedComponent = ((TouchedComponent != null) ? TouchedComponent.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x0002E14C File Offset: 0x0002C34C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UPrimitiveComponent> action = target as Action<UPrimitiveComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentBeginCursorOverSignature.__FComponentBeginCursorOverSignature_DelegateParams*)__Parameters)->TouchedComponent);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04000A97 RID: 2711
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000A98 RID: 2712
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentBeginCursorOverSignature__DelegateSignature";

		// Token: 0x04000A99 RID: 2713
		private static int RegisterId;

		// Token: 0x0200097B RID: 2427
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FComponentBeginCursorOverSignature_DelegateParams
		{
			// Token: 0x040058C5 RID: 22725
			[FieldOffset(0)]
			public IntPtr TouchedComponent;
		}

		// Token: 0x0200097C RID: 2428
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040058C6 RID: 22726
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
