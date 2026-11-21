using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200049E RID: 1182
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FAllowedNotificationsDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006E24 RID: 28196 RVA: 0x000A21A6 File Offset: 0x000A03A6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAllowedNotificationsDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006E25 RID: 28197 RVA: 0x000A21B2 File Offset: 0x000A03B2
		private static IntPtr StaticFunctionPtr()
		{
			if (FAllowedNotificationsDelegate._FunctionPtr == IntPtr.Zero)
			{
				FAllowedNotificationsDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroPushSdk.AllowedNotificationsDelegate__DelegateSignature");
			}
			return FAllowedNotificationsDelegate._FunctionPtr;
		}

		// Token: 0x06006E26 RID: 28198 RVA: 0x000A21D5 File Offset: 0x000A03D5
		public FAllowedNotificationsDelegate()
		{
		}

		// Token: 0x06006E27 RID: 28199 RVA: 0x000A21DD File Offset: 0x000A03DD
		[NullableContext(2)]
		public FAllowedNotificationsDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006E28 RID: 28200 RVA: 0x000A21E7 File Offset: 0x000A03E7
		public FAllowedNotificationsDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006E29 RID: 28201 RVA: 0x000A21F2 File Offset: 0x000A03F2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006E2A RID: 28202 RVA: 0x000A2224 File Offset: 0x000A0424
		[NullableContext(1)]
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

		// Token: 0x06006E2B RID: 28203 RVA: 0x000A225E File Offset: 0x000A045E
		[NullableContext(1)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06006E2C RID: 28204 RVA: 0x000A2268 File Offset: 0x000A0468
		[SkipLocalsInit]
		public unsafe void Broadcast(bool result)
		{
			FAllowedNotificationsDelegate.__FAllowedNotificationsDelegate_DelegateParams* ptr = stackalloc FAllowedNotificationsDelegate.__FAllowedNotificationsDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FAllowedNotificationsDelegate.__FAllowedNotificationsDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAllowedNotificationsDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->result = result;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06006E2D RID: 28205 RVA: 0x000A22A4 File Offset: 0x000A04A4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FAllowedNotificationsDelegate.__FAllowedNotificationsDelegate_DelegateParams*)__Parameters)->result);
		}

		// Token: 0x04002F2D RID: 12077
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002F2E RID: 12078
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroPushSdk.AllowedNotificationsDelegate__DelegateSignature";

		// Token: 0x04002F2F RID: 12079
		private static int RegisterId;

		// Token: 0x02000BD5 RID: 3029
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FAllowedNotificationsDelegate_DelegateParams
		{
			// Token: 0x04005D80 RID: 23936
			[FieldOffset(0)]
			public bool result;
		}

		// Token: 0x02000BD6 RID: 3030
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D81 RID: 23937
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
