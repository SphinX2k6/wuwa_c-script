using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001B0 RID: 432
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentEndCursorOverSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600200F RID: 8207 RVA: 0x0002EB25 File Offset: 0x0002CD25
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentEndCursorOverSignature.StaticFunctionPtr();
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x0002EB31 File Offset: 0x0002CD31
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentEndCursorOverSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentEndCursorOverSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentEndCursorOverSignature__DelegateSignature");
			}
			return FComponentEndCursorOverSignature._FunctionPtr;
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06002011 RID: 8209 RVA: 0x0002EB54 File Offset: 0x0002CD54
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnEndCursorOver;
			}
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x0002EB5B File Offset: 0x0002CD5B
		[NullableContext(2)]
		public FComponentEndCursorOverSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x0002EB65 File Offset: 0x0002CD65
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent>) ?? ((Action<UPrimitiveComponent>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x0002EB98 File Offset: 0x0002CD98
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UPrimitiveComponent> Callback)
		{
			if (FComponentEndCursorOverSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentEndCursorOverSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentEndCursorOverSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentEndCursorOverSignature.OnScriptCallback));
				}
				FComponentEndCursorOverSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentEndCursorOverSignature.RegisterId);
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x0002EBE8 File Offset: 0x0002CDE8
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UPrimitiveComponent> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x0002EC08 File Offset: 0x0002CE08
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UPrimitiveComponent TouchedComponent)
		{
			FComponentEndCursorOverSignature.__FComponentEndCursorOverSignature_DelegateParams* ptr = stackalloc FComponentEndCursorOverSignature.__FComponentEndCursorOverSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FComponentEndCursorOverSignature.__FComponentEndCursorOverSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentEndCursorOverSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchedComponent = ((TouchedComponent != null) ? TouchedComponent.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x0002EC64 File Offset: 0x0002CE64
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UPrimitiveComponent> action = target as Action<UPrimitiveComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentEndCursorOverSignature.__FComponentEndCursorOverSignature_DelegateParams*)__Parameters)->TouchedComponent);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04000AA9 RID: 2729
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000AAA RID: 2730
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentEndCursorOverSignature__DelegateSignature";

		// Token: 0x04000AAB RID: 2731
		private static int RegisterId;

		// Token: 0x02000987 RID: 2439
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FComponentEndCursorOverSignature_DelegateParams
		{
			// Token: 0x040058E0 RID: 22752
			[FieldOffset(0)]
			public IntPtr TouchedComponent;
		}

		// Token: 0x02000988 RID: 2440
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040058E1 RID: 22753
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
