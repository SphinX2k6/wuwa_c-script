using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200299F RID: 10655
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnExpandableAreaExpansionChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060276C3 RID: 161475 RVA: 0x003C1E4A File Offset: 0x003C004A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnExpandableAreaExpansionChanged.StaticFunctionPtr();
		}

		// Token: 0x060276C4 RID: 161476 RVA: 0x003C1E56 File Offset: 0x003C0056
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnExpandableAreaExpansionChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnExpandableAreaExpansionChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnExpandableAreaExpansionChanged__DelegateSignature");
			}
			return FOnExpandableAreaExpansionChanged._FunctionPtr;
		}

		// Token: 0x060276C5 RID: 161477 RVA: 0x003C1E79 File Offset: 0x003C0079
		public FOnExpandableAreaExpansionChanged()
		{
		}

		// Token: 0x060276C6 RID: 161478 RVA: 0x003C1E81 File Offset: 0x003C0081
		[NullableContext(2)]
		public FOnExpandableAreaExpansionChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060276C7 RID: 161479 RVA: 0x003C1E8B File Offset: 0x003C008B
		public FOnExpandableAreaExpansionChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060276C8 RID: 161480 RVA: 0x003C1E96 File Offset: 0x003C0096
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UExpandableArea, bool>) ?? ((Action<UExpandableArea, bool>)Delegate.CreateDelegate(typeof(Action<UExpandableArea, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060276C9 RID: 161481 RVA: 0x003C1EC8 File Offset: 0x003C00C8
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UExpandableArea, bool> Callback)
		{
			if (FOnExpandableAreaExpansionChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnExpandableAreaExpansionChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnExpandableAreaExpansionChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnExpandableAreaExpansionChanged.OnScriptCallback));
				}
				FOnExpandableAreaExpansionChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnExpandableAreaExpansionChanged.RegisterId);
		}

		// Token: 0x060276CA RID: 161482 RVA: 0x003C1F02 File Offset: 0x003C0102
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UExpandableArea, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060276CB RID: 161483 RVA: 0x003C1F0C File Offset: 0x003C010C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UExpandableArea Area, bool bIsExpanded)
		{
			FOnExpandableAreaExpansionChanged.__FOnExpandableAreaExpansionChanged_DelegateParams* ptr = stackalloc FOnExpandableAreaExpansionChanged.__FOnExpandableAreaExpansionChanged_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnExpandableAreaExpansionChanged.__FOnExpandableAreaExpansionChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnExpandableAreaExpansionChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Area = ((Area != null) ? Area.NativePtr : IntPtr.Zero);
			ptr->bIsExpanded = bIsExpanded;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060276CC RID: 161484 RVA: 0x003C1F60 File Offset: 0x003C0160
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UExpandableArea, bool> action = target as Action<UExpandableArea, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UExpandableArea orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UExpandableArea>(((FOnExpandableAreaExpansionChanged.__FOnExpandableAreaExpansionChanged_DelegateParams*)__Parameters)->Area);
			action(orCreateUObjectByNativePointer, ((FOnExpandableAreaExpansionChanged.__FOnExpandableAreaExpansionChanged_DelegateParams*)__Parameters)->bIsExpanded);
		}

		// Token: 0x04015A3E RID: 88638
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A3F RID: 88639
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnExpandableAreaExpansionChanged__DelegateSignature";

		// Token: 0x04015A40 RID: 88640
		private static int RegisterId;

		// Token: 0x02003B97 RID: 15255
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnExpandableAreaExpansionChanged_DelegateParams
		{
			// Token: 0x04017D73 RID: 97651
			[FieldOffset(0)]
			public IntPtr Area;

			// Token: 0x04017D74 RID: 97652
			[FieldOffset(8)]
			public bool bIsExpanded;
		}

		// Token: 0x02003B98 RID: 15256
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D75 RID: 97653
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
