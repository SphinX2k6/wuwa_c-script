using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000481 RID: 1153
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroNetworkChangeDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006D06 RID: 27910 RVA: 0x0009F47A File Offset: 0x0009D67A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroNetworkChangeDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006D07 RID: 27911 RVA: 0x0009F486 File Offset: 0x0009D686
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroNetworkChangeDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroNetworkChangeDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.KuroNetworkChangeDelegate__DelegateSignature");
			}
			return FKuroNetworkChangeDelegate._FunctionPtr;
		}

		// Token: 0x06006D08 RID: 27912 RVA: 0x0009F4A9 File Offset: 0x0009D6A9
		public FKuroNetworkChangeDelegate()
		{
		}

		// Token: 0x06006D09 RID: 27913 RVA: 0x0009F4B1 File Offset: 0x0009D6B1
		[NullableContext(2)]
		public FKuroNetworkChangeDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D0A RID: 27914 RVA: 0x0009F4BB File Offset: 0x0009D6BB
		public FKuroNetworkChangeDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D0B RID: 27915 RVA: 0x0009F4C6 File Offset: 0x0009D6C6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<byte>) ?? ((Action<byte>)Delegate.CreateDelegate(typeof(Action<byte>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006D0C RID: 27916 RVA: 0x0009F4F8 File Offset: 0x0009D6F8
		[NullableContext(1)]
		public void Add(Action<byte> Callback)
		{
			if (FKuroNetworkChangeDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroNetworkChangeDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroNetworkChangeDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroNetworkChangeDelegate.OnScriptCallback));
				}
				FKuroNetworkChangeDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroNetworkChangeDelegate.RegisterId);
		}

		// Token: 0x06006D0D RID: 27917 RVA: 0x0009F532 File Offset: 0x0009D732
		[NullableContext(1)]
		public void Remove(Action<byte> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06006D0E RID: 27918 RVA: 0x0009F53C File Offset: 0x0009D73C
		[SkipLocalsInit]
		public unsafe void Broadcast(byte NetworkTransportType)
		{
			FKuroNetworkChangeDelegate.__FKuroNetworkChangeDelegate_DelegateParams* ptr = stackalloc FKuroNetworkChangeDelegate.__FKuroNetworkChangeDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FKuroNetworkChangeDelegate.__FKuroNetworkChangeDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroNetworkChangeDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NetworkTransportType = NetworkTransportType;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06006D0F RID: 27919 RVA: 0x0009F578 File Offset: 0x0009D778
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<byte> action = target as Action<byte>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroNetworkChangeDelegate.__FKuroNetworkChangeDelegate_DelegateParams*)__Parameters)->NetworkTransportType);
		}

		// Token: 0x04002E94 RID: 11924
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002E95 RID: 11925
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.KuroNetworkChangeDelegate__DelegateSignature";

		// Token: 0x04002E96 RID: 11926
		private static int RegisterId;

		// Token: 0x02000B8D RID: 2957
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FKuroNetworkChangeDelegate_DelegateParams
		{
			// Token: 0x04005D02 RID: 23810
			[FieldOffset(0)]
			public byte NetworkTransportType;
		}

		// Token: 0x02000B8E RID: 2958
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D03 RID: 23811
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
