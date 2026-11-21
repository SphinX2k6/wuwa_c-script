using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200083A RID: 2106
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpineAnimationEndDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B7A4 RID: 47012 RVA: 0x00126591 File Offset: 0x00124791
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpineAnimationEndDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600B7A5 RID: 47013 RVA: 0x0012659D File Offset: 0x0012479D
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpineAnimationEndDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSpineAnimationEndDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SpinePlugin.SpineAnimationEndDelegate__DelegateSignature");
			}
			return FSpineAnimationEndDelegate._FunctionPtr;
		}

		// Token: 0x0600B7A6 RID: 47014 RVA: 0x001265C0 File Offset: 0x001247C0
		public FSpineAnimationEndDelegate()
		{
		}

		// Token: 0x0600B7A7 RID: 47015 RVA: 0x001265C8 File Offset: 0x001247C8
		[NullableContext(2)]
		public FSpineAnimationEndDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B7A8 RID: 47016 RVA: 0x001265D2 File Offset: 0x001247D2
		public FSpineAnimationEndDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B7A9 RID: 47017 RVA: 0x001265DD File Offset: 0x001247DD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UTrackEntry>) ?? ((Action<UTrackEntry>)Delegate.CreateDelegate(typeof(Action<UTrackEntry>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B7AA RID: 47018 RVA: 0x0012660F File Offset: 0x0012480F
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UTrackEntry> Callback)
		{
			if (FSpineAnimationEndDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSpineAnimationEndDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSpineAnimationEndDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSpineAnimationEndDelegate.OnScriptCallback));
				}
				FSpineAnimationEndDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSpineAnimationEndDelegate.RegisterId);
		}

		// Token: 0x0600B7AB RID: 47019 RVA: 0x00126649 File Offset: 0x00124849
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UTrackEntry> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600B7AC RID: 47020 RVA: 0x00126654 File Offset: 0x00124854
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UTrackEntry entry)
		{
			FSpineAnimationEndDelegate.__FSpineAnimationEndDelegate_DelegateParams* ptr = stackalloc FSpineAnimationEndDelegate.__FSpineAnimationEndDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSpineAnimationEndDelegate.__FSpineAnimationEndDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpineAnimationEndDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->entry = ((entry != null) ? entry.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600B7AD RID: 47021 RVA: 0x001266A0 File Offset: 0x001248A0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UTrackEntry> action = target as Action<UTrackEntry>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UTrackEntry orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(((FSpineAnimationEndDelegate.__FSpineAnimationEndDelegate_DelegateParams*)__Parameters)->entry);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04005374 RID: 21364
		internal static IntPtr _FunctionPtr;

		// Token: 0x04005375 RID: 21365
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SpinePlugin.SpineAnimationEndDelegate__DelegateSignature";

		// Token: 0x04005376 RID: 21366
		private static int RegisterId;

		// Token: 0x020013D0 RID: 5072
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FSpineAnimationEndDelegate_DelegateParams
		{
			// Token: 0x0400683B RID: 26683
			[FieldOffset(0)]
			public IntPtr entry;
		}

		// Token: 0x020013D1 RID: 5073
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400683C RID: 26684
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
