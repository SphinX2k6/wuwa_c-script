using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EDF RID: 7903
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FObjectLoadedDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E0DB RID: 123099 RVA: 0x002C9969 File Offset: 0x002C7B69
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FObjectLoadedDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601E0DC RID: 123100 RVA: 0x002C9975 File Offset: 0x002C7B75
		private static IntPtr StaticFunctionPtr()
		{
			if (FObjectLoadedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FObjectLoadedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.ObjectLoadedDelegate__DelegateSignature");
			}
			return FObjectLoadedDelegate._FunctionPtr;
		}

		// Token: 0x0601E0DD RID: 123101 RVA: 0x002C9998 File Offset: 0x002C7B98
		public FObjectLoadedDelegate()
		{
		}

		// Token: 0x0601E0DE RID: 123102 RVA: 0x002C99A0 File Offset: 0x002C7BA0
		[NullableContext(2)]
		public FObjectLoadedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E0DF RID: 123103 RVA: 0x002C99AA File Offset: 0x002C7BAA
		public FObjectLoadedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E0E0 RID: 123104 RVA: 0x002C99B5 File Offset: 0x002C7BB5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UObject, UObject>) ?? ((Action<UObject, UObject>)Delegate.CreateDelegate(typeof(Action<UObject, UObject>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E0E1 RID: 123105 RVA: 0x002C99E7 File Offset: 0x002C7BE7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<UObject, UObject> Callback)
		{
			if (FObjectLoadedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FObjectLoadedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FObjectLoadedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FObjectLoadedDelegate.OnScriptCallback));
				}
				FObjectLoadedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FObjectLoadedDelegate.RegisterId);
		}

		// Token: 0x0601E0E2 RID: 123106 RVA: 0x002C9A21 File Offset: 0x002C7C21
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<UObject, UObject> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601E0E3 RID: 123107 RVA: 0x002C9A2C File Offset: 0x002C7C2C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UObject ObjectLoaded, UObject UserData)
		{
			FObjectLoadedDelegate.__FObjectLoadedDelegate_DelegateParams* ptr = stackalloc FObjectLoadedDelegate.__FObjectLoadedDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FObjectLoadedDelegate.__FObjectLoadedDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FObjectLoadedDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ObjectLoaded = ((ObjectLoaded != null) ? ObjectLoaded.NativePtr : IntPtr.Zero);
			ptr->UserData = ((UserData != null) ? UserData.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601E0E4 RID: 123108 RVA: 0x002C9A90 File Offset: 0x002C7C90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UObject, UObject> action = target as Action<UObject, UObject>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((FObjectLoadedDelegate.__FObjectLoadedDelegate_DelegateParams*)__Parameters)->ObjectLoaded);
			UObject orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((FObjectLoadedDelegate.__FObjectLoadedDelegate_DelegateParams*)__Parameters)->UserData);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
		}

		// Token: 0x040103F7 RID: 66551
		internal static IntPtr _FunctionPtr;

		// Token: 0x040103F8 RID: 66552
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.ObjectLoadedDelegate__DelegateSignature";

		// Token: 0x040103F9 RID: 66553
		private static int RegisterId;

		// Token: 0x020033A6 RID: 13222
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FObjectLoadedDelegate_DelegateParams
		{
			// Token: 0x04017359 RID: 95065
			[FieldOffset(0)]
			public IntPtr ObjectLoaded;

			// Token: 0x0401735A RID: 95066
			[FieldOffset(8)]
			public IntPtr UserData;
		}

		// Token: 0x020033A7 RID: 13223
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401735B RID: 95067
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
