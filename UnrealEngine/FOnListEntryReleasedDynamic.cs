using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000868 RID: 2152
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnListEntryReleasedDynamic : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BB06 RID: 47878 RVA: 0x0012B763 File Offset: 0x00129963
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnListEntryReleasedDynamic.StaticFunctionPtr();
		}

		// Token: 0x0600BB07 RID: 47879 RVA: 0x0012B76F File Offset: 0x0012996F
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnListEntryReleasedDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnListEntryReleasedDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnListEntryReleasedDynamic__DelegateSignature");
			}
			return FOnListEntryReleasedDynamic._FunctionPtr;
		}

		// Token: 0x0600BB08 RID: 47880 RVA: 0x0012B792 File Offset: 0x00129992
		public FOnListEntryReleasedDynamic()
		{
		}

		// Token: 0x0600BB09 RID: 47881 RVA: 0x0012B79A File Offset: 0x0012999A
		[NullableContext(2)]
		public FOnListEntryReleasedDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BB0A RID: 47882 RVA: 0x0012B7A4 File Offset: 0x001299A4
		public FOnListEntryReleasedDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BB0B RID: 47883 RVA: 0x0012B7AF File Offset: 0x001299AF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UUserWidget>) ?? ((Action<UUserWidget>)Delegate.CreateDelegate(typeof(Action<UUserWidget>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BB0C RID: 47884 RVA: 0x0012B7E1 File Offset: 0x001299E1
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUserWidget> Callback)
		{
			if (FOnListEntryReleasedDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnListEntryReleasedDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnListEntryReleasedDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnListEntryReleasedDynamic.OnScriptCallback));
				}
				FOnListEntryReleasedDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnListEntryReleasedDynamic.RegisterId);
		}

		// Token: 0x0600BB0D RID: 47885 RVA: 0x0012B81B File Offset: 0x00129A1B
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUserWidget> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600BB0E RID: 47886 RVA: 0x0012B824 File Offset: 0x00129A24
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UUserWidget Widget)
		{
			FOnListEntryReleasedDynamic.__FOnListEntryReleasedDynamic_DelegateParams* ptr = stackalloc FOnListEntryReleasedDynamic.__FOnListEntryReleasedDynamic_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnListEntryReleasedDynamic.__FOnListEntryReleasedDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnListEntryReleasedDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Widget = ((Widget != null) ? Widget.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600BB0F RID: 47887 RVA: 0x0012B870 File Offset: 0x00129A70
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UUserWidget> action = target as Action<UUserWidget>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UUserWidget orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUserWidget>(((FOnListEntryReleasedDynamic.__FOnListEntryReleasedDynamic_DelegateParams*)__Parameters)->Widget);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x040054C2 RID: 21698
		internal static IntPtr _FunctionPtr;

		// Token: 0x040054C3 RID: 21699
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnListEntryReleasedDynamic__DelegateSignature";

		// Token: 0x040054C4 RID: 21700
		private static int RegisterId;

		// Token: 0x02001405 RID: 5125
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnListEntryReleasedDynamic_DelegateParams
		{
			// Token: 0x040068B1 RID: 26801
			[FieldOffset(0)]
			public IntPtr Widget;
		}

		// Token: 0x02001406 RID: 5126
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040068B2 RID: 26802
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
