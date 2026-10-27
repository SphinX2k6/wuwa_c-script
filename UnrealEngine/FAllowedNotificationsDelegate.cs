using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A3E RID: 6718
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FAllowedNotificationsDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018DDF RID: 101855 RVA: 0x0024BD0E File Offset: 0x00249F0E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAllowedNotificationsDelegate.StaticFunctionPtr();
		}

		// Token: 0x06018DE0 RID: 101856 RVA: 0x0024BD1A File Offset: 0x00249F1A
		private static IntPtr StaticFunctionPtr()
		{
			if (FAllowedNotificationsDelegate._FunctionPtr == IntPtr.Zero)
			{
				FAllowedNotificationsDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroPushSdk.AllowedNotificationsDelegate__DelegateSignature");
			}
			return FAllowedNotificationsDelegate._FunctionPtr;
		}

		// Token: 0x06018DE1 RID: 101857 RVA: 0x0024BD3D File Offset: 0x00249F3D
		public FAllowedNotificationsDelegate()
		{
		}

		// Token: 0x06018DE2 RID: 101858 RVA: 0x0024BD45 File Offset: 0x00249F45
		[NullableContext(2)]
		public FAllowedNotificationsDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018DE3 RID: 101859 RVA: 0x0024BD4F File Offset: 0x00249F4F
		public FAllowedNotificationsDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018DE4 RID: 101860 RVA: 0x0024BD5A File Offset: 0x00249F5A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018DE5 RID: 101861 RVA: 0x0024BD8C File Offset: 0x00249F8C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool> Callback)
		{
			if (FAllowedNotificationsDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAllowedNotificationsDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAllowedNotificationsDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAllowedNotificationsDelegate.OnScriptCallback));
				}
				FAllowedNotificationsDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FAllowedNotificationsDelegate.RegisterId);
		}

		// Token: 0x06018DE6 RID: 101862 RVA: 0x0024BDC6 File Offset: 0x00249FC6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06018DE7 RID: 101863 RVA: 0x0024BDD0 File Offset: 0x00249FD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool result)
		{
			FAllowedNotificationsDelegate.__FAllowedNotificationsDelegate_DelegateParams* ptr = stackalloc FAllowedNotificationsDelegate.__FAllowedNotificationsDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FAllowedNotificationsDelegate.__FAllowedNotificationsDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAllowedNotificationsDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->result = result;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06018DE8 RID: 101864 RVA: 0x0024BE0C File Offset: 0x0024A00C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FAllowedNotificationsDelegate.__FAllowedNotificationsDelegate_DelegateParams*)__Parameters)->result);
		}

		// Token: 0x0400D6ED RID: 55021
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D6EE RID: 55022
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroPushSdk.AllowedNotificationsDelegate__DelegateSignature";

		// Token: 0x0400D6EF RID: 55023
		private static int RegisterId;

		// Token: 0x02003100 RID: 12544
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FAllowedNotificationsDelegate_DelegateParams
		{
			// Token: 0x04016E86 RID: 93830
			[FieldOffset(0)]
			public bool result;
		}

		// Token: 0x02003101 RID: 12545
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016E87 RID: 93831
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
