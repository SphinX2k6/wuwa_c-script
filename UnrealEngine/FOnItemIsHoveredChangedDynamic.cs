using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029A7 RID: 10663
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnItemIsHoveredChangedDynamic : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027710 RID: 161552 RVA: 0x003C28CF File Offset: 0x003C0ACF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnItemIsHoveredChangedDynamic.StaticFunctionPtr();
		}

		// Token: 0x06027711 RID: 161553 RVA: 0x003C28DB File Offset: 0x003C0ADB
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnItemIsHoveredChangedDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnItemIsHoveredChangedDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnItemIsHoveredChangedDynamic__DelegateSignature");
			}
			return FOnItemIsHoveredChangedDynamic._FunctionPtr;
		}

		// Token: 0x06027712 RID: 161554 RVA: 0x003C28FE File Offset: 0x003C0AFE
		public FOnItemIsHoveredChangedDynamic()
		{
		}

		// Token: 0x06027713 RID: 161555 RVA: 0x003C2906 File Offset: 0x003C0B06
		[NullableContext(2)]
		public FOnItemIsHoveredChangedDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027714 RID: 161556 RVA: 0x003C2910 File Offset: 0x003C0B10
		public FOnItemIsHoveredChangedDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027715 RID: 161557 RVA: 0x003C291B File Offset: 0x003C0B1B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UObject, bool>) ?? ((Action<UObject, bool>)Delegate.CreateDelegate(typeof(Action<UObject, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027716 RID: 161558 RVA: 0x003C294D File Offset: 0x003C0B4D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027717 RID: 161559 RVA: 0x003C2987 File Offset: 0x003C0B87
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06027718 RID: 161560 RVA: 0x003C2990 File Offset: 0x003C0B90
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UObject Item, bool bIsHovered)
		{
			FOnItemIsHoveredChangedDynamic.__FOnItemIsHoveredChangedDynamic_DelegateParams* ptr = stackalloc FOnItemIsHoveredChangedDynamic.__FOnItemIsHoveredChangedDynamic_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnItemIsHoveredChangedDynamic.__FOnItemIsHoveredChangedDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnItemIsHoveredChangedDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Item = ((Item != null) ? Item.NativePtr : IntPtr.Zero);
			ptr->bIsHovered = bIsHovered;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06027719 RID: 161561 RVA: 0x003C29E4 File Offset: 0x003C0BE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04015A54 RID: 88660
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A55 RID: 88661
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnItemIsHoveredChangedDynamic__DelegateSignature";

		// Token: 0x04015A56 RID: 88662
		private static int RegisterId;

		// Token: 0x02003BA5 RID: 15269
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnItemIsHoveredChangedDynamic_DelegateParams
		{
			// Token: 0x04017D84 RID: 97668
			[FieldOffset(0)]
			public IntPtr Item;

			// Token: 0x04017D85 RID: 97669
			[FieldOffset(8)]
			public bool bIsHovered;
		}

		// Token: 0x02003BA6 RID: 15270
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D86 RID: 97670
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
