using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000865 RID: 2149
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnItemIsHoveredChangedDynamic : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BAE8 RID: 47848 RVA: 0x0012B312 File Offset: 0x00129512
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnItemIsHoveredChangedDynamic.StaticFunctionPtr();
		}

		// Token: 0x0600BAE9 RID: 47849 RVA: 0x0012B31E File Offset: 0x0012951E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnItemIsHoveredChangedDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnItemIsHoveredChangedDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnItemIsHoveredChangedDynamic__DelegateSignature");
			}
			return FOnItemIsHoveredChangedDynamic._FunctionPtr;
		}

		// Token: 0x0600BAEA RID: 47850 RVA: 0x0012B341 File Offset: 0x00129541
		public FOnItemIsHoveredChangedDynamic()
		{
		}

		// Token: 0x0600BAEB RID: 47851 RVA: 0x0012B349 File Offset: 0x00129549
		[NullableContext(2)]
		public FOnItemIsHoveredChangedDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BAEC RID: 47852 RVA: 0x0012B353 File Offset: 0x00129553
		public FOnItemIsHoveredChangedDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BAED RID: 47853 RVA: 0x0012B35E File Offset: 0x0012955E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UObject, bool>) ?? ((Action<UObject, bool>)Delegate.CreateDelegate(typeof(Action<UObject, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BAEE RID: 47854 RVA: 0x0012B390 File Offset: 0x00129590
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject, bool> Callback)
		{
			if (FOnItemIsHoveredChangedDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnItemIsHoveredChangedDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnItemIsHoveredChangedDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnItemIsHoveredChangedDynamic.OnScriptCallback));
				}
				FOnItemIsHoveredChangedDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnItemIsHoveredChangedDynamic.RegisterId);
		}

		// Token: 0x0600BAEF RID: 47855 RVA: 0x0012B3CA File Offset: 0x001295CA
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600BAF0 RID: 47856 RVA: 0x0012B3D4 File Offset: 0x001295D4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UObject Item, bool bIsHovered)
		{
			FOnItemIsHoveredChangedDynamic.__FOnItemIsHoveredChangedDynamic_DelegateParams* ptr = stackalloc FOnItemIsHoveredChangedDynamic.__FOnItemIsHoveredChangedDynamic_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnItemIsHoveredChangedDynamic.__FOnItemIsHoveredChangedDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnItemIsHoveredChangedDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Item = ((Item != null) ? Item.NativePtr : IntPtr.Zero);
			ptr->bIsHovered = bIsHovered;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600BAF1 RID: 47857 RVA: 0x0012B428 File Offset: 0x00129628
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UObject, bool> action = target as Action<UObject, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((FOnItemIsHoveredChangedDynamic.__FOnItemIsHoveredChangedDynamic_DelegateParams*)__Parameters)->Item);
			action(orCreateUObjectByNativePointer, ((FOnItemIsHoveredChangedDynamic.__FOnItemIsHoveredChangedDynamic_DelegateParams*)__Parameters)->bIsHovered);
		}

		// Token: 0x040054B9 RID: 21689
		internal static IntPtr _FunctionPtr;

		// Token: 0x040054BA RID: 21690
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnItemIsHoveredChangedDynamic__DelegateSignature";

		// Token: 0x040054BB RID: 21691
		private static int RegisterId;

		// Token: 0x020013FF RID: 5119
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnItemIsHoveredChangedDynamic_DelegateParams
		{
			// Token: 0x040068A9 RID: 26793
			[FieldOffset(0)]
			public IntPtr Item;

			// Token: 0x040068AA RID: 26794
			[FieldOffset(8)]
			public bool bIsHovered;
		}

		// Token: 0x02001400 RID: 5120
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040068AB RID: 26795
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
