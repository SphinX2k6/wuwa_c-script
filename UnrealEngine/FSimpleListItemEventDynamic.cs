using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029D5 RID: 10709
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSimpleListItemEventDynamic : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060279B8 RID: 162232 RVA: 0x003C6959 File Offset: 0x003C4B59
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSimpleListItemEventDynamic.StaticFunctionPtr();
		}

		// Token: 0x060279B9 RID: 162233 RVA: 0x003C6965 File Offset: 0x003C4B65
		private static IntPtr StaticFunctionPtr()
		{
			if (FSimpleListItemEventDynamic._FunctionPtr == IntPtr.Zero)
			{
				FSimpleListItemEventDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.SimpleListItemEventDynamic__DelegateSignature");
			}
			return FSimpleListItemEventDynamic._FunctionPtr;
		}

		// Token: 0x060279BA RID: 162234 RVA: 0x003C6988 File Offset: 0x003C4B88
		public FSimpleListItemEventDynamic()
		{
		}

		// Token: 0x060279BB RID: 162235 RVA: 0x003C6990 File Offset: 0x003C4B90
		[NullableContext(2)]
		public FSimpleListItemEventDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060279BC RID: 162236 RVA: 0x003C699A File Offset: 0x003C4B9A
		public FSimpleListItemEventDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060279BD RID: 162237 RVA: 0x003C69A5 File Offset: 0x003C4BA5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UObject>) ?? ((Action<UObject>)Delegate.CreateDelegate(typeof(Action<UObject>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060279BE RID: 162238 RVA: 0x003C69D7 File Offset: 0x003C4BD7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject> Callback)
		{
			if (FSimpleListItemEventDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSimpleListItemEventDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSimpleListItemEventDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSimpleListItemEventDynamic.OnScriptCallback));
				}
				FSimpleListItemEventDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSimpleListItemEventDynamic.RegisterId);
		}

		// Token: 0x060279BF RID: 162239 RVA: 0x003C6A11 File Offset: 0x003C4C11
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060279C0 RID: 162240 RVA: 0x003C6A1C File Offset: 0x003C4C1C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UObject Item)
		{
			FSimpleListItemEventDynamic.__FSimpleListItemEventDynamic_DelegateParams* ptr = stackalloc FSimpleListItemEventDynamic.__FSimpleListItemEventDynamic_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSimpleListItemEventDynamic.__FSimpleListItemEventDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSimpleListItemEventDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Item = ((Item != null) ? Item.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060279C1 RID: 162241 RVA: 0x003C6A68 File Offset: 0x003C4C68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UObject> action = target as Action<UObject>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((FSimpleListItemEventDynamic.__FSimpleListItemEventDynamic_DelegateParams*)__Parameters)->Item);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04015B3D RID: 88893
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015B3E RID: 88894
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.SimpleListItemEventDynamic__DelegateSignature";

		// Token: 0x04015B3F RID: 88895
		private static int RegisterId;

		// Token: 0x02003BD0 RID: 15312
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FSimpleListItemEventDynamic_DelegateParams
		{
			// Token: 0x04017DBA RID: 97722
			[FieldOffset(0)]
			public IntPtr Item;
		}

		// Token: 0x02003BD1 RID: 15313
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017DBB RID: 97723
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
