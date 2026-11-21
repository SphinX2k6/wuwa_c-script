using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200083C RID: 2108
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpineAnimationStartDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B7B8 RID: 47032 RVA: 0x00126851 File Offset: 0x00124A51
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpineAnimationStartDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600B7B9 RID: 47033 RVA: 0x0012685D File Offset: 0x00124A5D
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpineAnimationStartDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSpineAnimationStartDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SpinePlugin.SpineAnimationStartDelegate__DelegateSignature");
			}
			return FSpineAnimationStartDelegate._FunctionPtr;
		}

		// Token: 0x0600B7BA RID: 47034 RVA: 0x00126880 File Offset: 0x00124A80
		public FSpineAnimationStartDelegate()
		{
		}

		// Token: 0x0600B7BB RID: 47035 RVA: 0x00126888 File Offset: 0x00124A88
		[NullableContext(2)]
		public FSpineAnimationStartDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B7BC RID: 47036 RVA: 0x00126892 File Offset: 0x00124A92
		public FSpineAnimationStartDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B7BD RID: 47037 RVA: 0x0012689D File Offset: 0x00124A9D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UTrackEntry>) ?? ((Action<UTrackEntry>)Delegate.CreateDelegate(typeof(Action<UTrackEntry>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B7BE RID: 47038 RVA: 0x001268CF File Offset: 0x00124ACF
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UTrackEntry> Callback)
		{
			if (FSpineAnimationStartDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSpineAnimationStartDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSpineAnimationStartDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSpineAnimationStartDelegate.OnScriptCallback));
				}
				FSpineAnimationStartDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSpineAnimationStartDelegate.RegisterId);
		}

		// Token: 0x0600B7BF RID: 47039 RVA: 0x00126909 File Offset: 0x00124B09
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UTrackEntry> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600B7C0 RID: 47040 RVA: 0x00126914 File Offset: 0x00124B14
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UTrackEntry entry)
		{
			FSpineAnimationStartDelegate.__FSpineAnimationStartDelegate_DelegateParams* ptr = stackalloc FSpineAnimationStartDelegate.__FSpineAnimationStartDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSpineAnimationStartDelegate.__FSpineAnimationStartDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpineAnimationStartDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->entry = ((entry != null) ? entry.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600B7C1 RID: 47041 RVA: 0x00126960 File Offset: 0x00124B60
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UTrackEntry> action = target as Action<UTrackEntry>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UTrackEntry orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(((FSpineAnimationStartDelegate.__FSpineAnimationStartDelegate_DelegateParams*)__Parameters)->entry);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400537A RID: 21370
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400537B RID: 21371
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SpinePlugin.SpineAnimationStartDelegate__DelegateSignature";

		// Token: 0x0400537C RID: 21372
		private static int RegisterId;

		// Token: 0x020013D4 RID: 5076
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FSpineAnimationStartDelegate_DelegateParams
		{
			// Token: 0x0400683F RID: 26687
			[FieldOffset(0)]
			public IntPtr entry;
		}

		// Token: 0x020013D5 RID: 5077
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006840 RID: 26688
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
