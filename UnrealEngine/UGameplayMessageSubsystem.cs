using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013CF RID: 5071
	[UnrealObjectPath("/Script/GameplayMessageRuntime.GameplayMessageSubsystem")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UGameplayMessageSubsystem : UGameInstanceSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012906 RID: 76038 RVA: 0x001B50F7 File Offset: 0x001B32F7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayMessageSubsystem._ClassPtr;
		}

		// Token: 0x06012907 RID: 76039 RVA: 0x001B5104 File Offset: 0x001B3304
		public UGameplayMessageSubsystem() : this(BuiltinUtils.AllocNativeUObject(UGameplayMessageSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012908 RID: 76040 RVA: 0x001B512C File Offset: 0x001B332C
		[NullableContext(1)]
		public UGameplayMessageSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayMessageSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06012909 RID: 76041 RVA: 0x001B5160 File Offset: 0x001B3360
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void K2_BroadcastMessage(FGameplayTag Channel, in int Message)
		{
			UGameplayMessageSubsystem.__K2_BroadcastMessage_FunctionParams* ptr = stackalloc UGameplayMessageSubsystem.__K2_BroadcastMessage_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UGameplayMessageSubsystem.__K2_BroadcastMessage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UGameplayMessageSubsystem.__K2_BroadcastMessage_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Channel = Channel;
			ptr->Message = Message;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UGameplayMessageSubsystem.__K2_BroadcastMessage_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601290A RID: 76042 RVA: 0x001B51AF File Offset: 0x001B33AF
		static UGameplayMessageSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayMessageRuntime.GameplayMessageSubsystem");
		}

		// Token: 0x0601290B RID: 76043 RVA: 0x001B51BD File Offset: 0x001B33BD
		protected UGameplayMessageSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009EBF RID: 40639
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayMessageRuntime.GameplayMessageSubsystem";

		// Token: 0x04009EC0 RID: 40640
		private static IntPtr _ClassPtr;

		// Token: 0x04009EC1 RID: 40641
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009EC2 RID: 40642
		private static IntPtr __K2_BroadcastMessage_NativeFunctionPtr;

		// Token: 0x02002E6E RID: 11886
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __K2_BroadcastMessage_FunctionParams
		{
			// Token: 0x04016931 RID: 92465
			[FieldOffset(0)]
			public FGameplayTag Channel;

			// Token: 0x04016932 RID: 92466
			[FieldOffset(12)]
			public int Message;
		}
	}
}
