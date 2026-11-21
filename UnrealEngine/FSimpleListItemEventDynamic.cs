using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200086F RID: 2159
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSimpleListItemEventDynamic : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BB5B RID: 47963 RVA: 0x0012C045 File Offset: 0x0012A245
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSimpleListItemEventDynamic.StaticFunctionPtr();
		}

		// Token: 0x0600BB5C RID: 47964 RVA: 0x0012C051 File Offset: 0x0012A251
		private static IntPtr StaticFunctionPtr()
		{
			if (FSimpleListItemEventDynamic._FunctionPtr == IntPtr.Zero)
			{
				FSimpleListItemEventDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.SimpleListItemEventDynamic__DelegateSignature");
			}
			return FSimpleListItemEventDynamic._FunctionPtr;
		}

		// Token: 0x0600BB5D RID: 47965 RVA: 0x0012C074 File Offset: 0x0012A274
		public FSimpleListItemEventDynamic()
		{
		}

		// Token: 0x0600BB5E RID: 47966 RVA: 0x0012C07C File Offset: 0x0012A27C
		[NullableContext(2)]
		public FSimpleListItemEventDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BB5F RID: 47967 RVA: 0x0012C086 File Offset: 0x0012A286
		public FSimpleListItemEventDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BB60 RID: 47968 RVA: 0x0012C091 File Offset: 0x0012A291
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UObject>) ?? ((Action<UObject>)Delegate.CreateDelegate(typeof(Action<UObject>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BB61 RID: 47969 RVA: 0x0012C0C3 File Offset: 0x0012A2C3
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

		// Token: 0x0600BB62 RID: 47970 RVA: 0x0012C0FD File Offset: 0x0012A2FD
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600BB63 RID: 47971 RVA: 0x0012C108 File Offset: 0x0012A308
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UObject Item)
		{
			FSimpleListItemEventDynamic.__FSimpleListItemEventDynamic_DelegateParams* ptr = stackalloc FSimpleListItemEventDynamic.__FSimpleListItemEventDynamic_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSimpleListItemEventDynamic.__FSimpleListItemEventDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSimpleListItemEventDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Item = ((Item != null) ? Item.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600BB64 RID: 47972 RVA: 0x0012C154 File Offset: 0x0012A354
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040054DA RID: 21722
		internal static IntPtr _FunctionPtr;

		// Token: 0x040054DB RID: 21723
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.SimpleListItemEventDynamic__DelegateSignature";

		// Token: 0x040054DC RID: 21724
		private static int RegisterId;

		// Token: 0x0200140E RID: 5134
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FSimpleListItemEventDynamic_DelegateParams
		{
			// Token: 0x040068BC RID: 26812
			[FieldOffset(0)]
			public IntPtr Item;
		}

		// Token: 0x0200140F RID: 5135
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040068BD RID: 26813
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
