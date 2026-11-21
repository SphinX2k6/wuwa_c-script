using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001AE RID: 430
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentBeginTouchOverSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001FFD RID: 8189 RVA: 0x0002E7D6 File Offset: 0x0002C9D6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentBeginTouchOverSignature.StaticFunctionPtr();
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x0002E7E2 File Offset: 0x0002C9E2
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentBeginTouchOverSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentBeginTouchOverSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentBeginTouchOverSignature__DelegateSignature");
			}
			return FComponentBeginTouchOverSignature._FunctionPtr;
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x0002E805 File Offset: 0x0002CA05
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnInputTouchEnter;
			}
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x0002E80C File Offset: 0x0002CA0C
		[NullableContext(2)]
		public FComponentBeginTouchOverSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x0002E816 File Offset: 0x0002CA16
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>) ?? ((Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x0002E848 File Offset: 0x0002CA48
		public void Add([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent> Callback)
		{
			if (FComponentBeginTouchOverSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentBeginTouchOverSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentBeginTouchOverSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentBeginTouchOverSignature.OnScriptCallback));
				}
				FComponentBeginTouchOverSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentBeginTouchOverSignature.RegisterId);
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x0002E898 File Offset: 0x0002CA98
		public void Remove([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x0002E8B8 File Offset: 0x0002CAB8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(ETouchIndex FingerIndex, UPrimitiveComponent TouchedComponent)
		{
			FComponentBeginTouchOverSignature.__FComponentBeginTouchOverSignature_DelegateParams* ptr = stackalloc FComponentBeginTouchOverSignature.__FComponentBeginTouchOverSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FComponentBeginTouchOverSignature.__FComponentBeginTouchOverSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentBeginTouchOverSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->TouchedComponent = ((TouchedComponent != null) ? TouchedComponent.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x0002E920 File Offset: 0x0002CB20
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent> action = target as Action<TEnumAsByte<ETouchIndex>, UPrimitiveComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentBeginTouchOverSignature.__FComponentBeginTouchOverSignature_DelegateParams*)__Parameters)->TouchedComponent);
			action(((FComponentBeginTouchOverSignature.__FComponentBeginTouchOverSignature_DelegateParams*)__Parameters)->FingerIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x04000AA3 RID: 2723
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000AA4 RID: 2724
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentBeginTouchOverSignature__DelegateSignature";

		// Token: 0x04000AA5 RID: 2725
		private static int RegisterId;

		// Token: 0x02000983 RID: 2435
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FComponentBeginTouchOverSignature_DelegateParams
		{
			// Token: 0x040058D9 RID: 22745
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x040058DA RID: 22746
			[FieldOffset(8)]
			public IntPtr TouchedComponent;
		}

		// Token: 0x02000984 RID: 2436
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040058DB RID: 22747
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
