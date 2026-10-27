using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013CA RID: 5066
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayMessageRuntime.AsyncAction_ListenForGameplayMessage")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UAsyncAction_ListenForGameplayMessage : UCancellableAsyncAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060128DD RID: 75997 RVA: 0x001B4CDA File Offset: 0x001B2EDA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncAction_ListenForGameplayMessage._ClassPtr;
		}

		// Token: 0x060128DE RID: 75998 RVA: 0x001B4CE8 File Offset: 0x001B2EE8
		public UAsyncAction_ListenForGameplayMessage() : this(BuiltinUtils.AllocNativeUObject(UAsyncAction_ListenForGameplayMessage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060128DF RID: 75999 RVA: 0x001B4D10 File Offset: 0x001B2F10
		public UAsyncAction_ListenForGameplayMessage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncAction_ListenForGameplayMessage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700480D RID: 18445
		// (get) Token: 0x060128E0 RID: 76000 RVA: 0x001B4D44 File Offset: 0x001B2F44
		// (set) Token: 0x060128E1 RID: 76001 RVA: 0x001B4D7D File Offset: 0x001B2F7D
		public FAsyncGameplayMessageDelegate OnMessageReceived
		{
			get
			{
				base.FastCheckIsValid();
				FAsyncGameplayMessageDelegate result;
				if ((result = this._OnMessageReceived) == null)
				{
					result = (this._OnMessageReceived = new FAsyncGameplayMessageDelegate(base.NativePtr + (IntPtr)UAsyncAction_ListenForGameplayMessage.__PropertyOffset_OnMessageReceived, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncAction_ListenForGameplayMessage.__PropertyOffset_OnMessageReceived, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060128E2 RID: 76002 RVA: 0x001B4D9E File Offset: 0x001B2F9E
		[NullableContext(2)]
		public static UAsyncAction_ListenForGameplayMessage ListenForGameplayMessages(UObject WorldContextObject, FGameplayTag Channel, UScriptStruct PayloadType, EGameplayMessageMatch MatchType = EGameplayMessageMatch.ExactMatch)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncAction_ListenForGameplayMessage>(UAsyncAction_ListenForGameplayMessage.__ListenForGameplayMessages_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Channel, (PayloadType != null) ? PayloadType.NativePtr : IntPtr.Zero, MatchType));
		}

		// Token: 0x060128E3 RID: 76003 RVA: 0x001B4DCC File Offset: 0x001B2FCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetPayload(ref int OutPayload)
		{
			UAsyncAction_ListenForGameplayMessage.__GetPayload_FunctionParams* ptr = stackalloc UAsyncAction_ListenForGameplayMessage.__GetPayload_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UAsyncAction_ListenForGameplayMessage.__GetPayload_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncAction_ListenForGameplayMessage.__GetPayload_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutPayload = OutPayload;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncAction_ListenForGameplayMessage.__GetPayload_NativeFunctionPtr, (void*)ptr, 0);
			OutPayload = ptr->OutPayload;
			return ptr->__Result;
		}

		// Token: 0x060128E4 RID: 76004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ListenForGameplayMessages_Internal(IntPtr WorldContextObject, FGameplayTag Channel, IntPtr PayloadType, EGameplayMessageMatch MatchType);

		// Token: 0x060128E5 RID: 76005 RVA: 0x001B4E22 File Offset: 0x001B3022
		static UAsyncAction_ListenForGameplayMessage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayMessageRuntime.AsyncAction_ListenForGameplayMessage");
		}

		// Token: 0x060128E6 RID: 76006 RVA: 0x001B4E30 File Offset: 0x001B3030
		protected UAsyncAction_ListenForGameplayMessage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009EAB RID: 40619
		public new const string __ObjectPath = "/Script/GameplayMessageRuntime.AsyncAction_ListenForGameplayMessage";

		// Token: 0x04009EAC RID: 40620
		private static IntPtr _ClassPtr;

		// Token: 0x04009EAD RID: 40621
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009EAE RID: 40622
		internal static int __PropertyOffset_OnMessageReceived;

		// Token: 0x04009EAF RID: 40623
		[Nullable(2)]
		private FAsyncGameplayMessageDelegate _OnMessageReceived;

		// Token: 0x04009EB0 RID: 40624
		private static IntPtr __GetPayload_NativeFunctionPtr;

		// Token: 0x02002E6B RID: 11883
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetPayload_FunctionParams
		{
			// Token: 0x0401692C RID: 92460
			[FieldOffset(0)]
			public int OutPayload;

			// Token: 0x0401692D RID: 92461
			[FieldOffset(4)]
			public bool __Result;
		}
	}
}
