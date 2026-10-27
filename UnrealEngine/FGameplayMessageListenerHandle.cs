using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013CE RID: 5070
	[UnrealObjectPath("/Script/GameplayMessageRuntime.GameplayMessageListenerHandle")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FGameplayMessageListenerHandle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060128F8 RID: 76024 RVA: 0x001B5007 File Offset: 0x001B3207
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayMessageListenerHandle._ScriptStructPtr != 0) ? FGameplayMessageListenerHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayMessageRuntime.GameplayMessageListenerHandle", ref FGameplayMessageListenerHandle._ScriptStructPtr);
		}

		// Token: 0x1700480E RID: 18446
		// (get) Token: 0x060128F9 RID: 76025 RVA: 0x001B502B File Offset: 0x001B322B
		// (set) Token: 0x060128FA RID: 76026 RVA: 0x001B503F File Offset: 0x001B323F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UGameplayMessageSubsystem> Subsystem
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayMessageListenerHandle.__PropertyOffset_Subsystem);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayMessageListenerHandle.__PropertyOffset_Subsystem) = value;
			}
		}

		// Token: 0x1700480F RID: 18447
		// (get) Token: 0x060128FB RID: 76027 RVA: 0x001B5054 File Offset: 0x001B3254
		// (set) Token: 0x060128FC RID: 76028 RVA: 0x001B5068 File Offset: 0x001B3268
		public unsafe FGameplayTag Channel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayMessageListenerHandle.__PropertyOffset_Channel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayMessageListenerHandle.__PropertyOffset_Channel) = value;
			}
		}

		// Token: 0x17004810 RID: 18448
		// (get) Token: 0x060128FD RID: 76029 RVA: 0x001B507D File Offset: 0x001B327D
		// (set) Token: 0x060128FE RID: 76030 RVA: 0x001B508D File Offset: 0x001B328D
		public unsafe int ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayMessageListenerHandle.__PropertyOffset_ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayMessageListenerHandle.__PropertyOffset_ID) = value;
			}
		}

		// Token: 0x060128FF RID: 76031 RVA: 0x001B509E File Offset: 0x001B329E
		public FGameplayMessageListenerHandle()
		{
		}

		// Token: 0x06012900 RID: 76032 RVA: 0x001B50A6 File Offset: 0x001B32A6
		public FGameplayMessageListenerHandle([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UGameplayMessageSubsystem> Subsystem, FGameplayTag Channel, int ID)
		{
			this.Subsystem = Subsystem;
			this.Channel = Channel;
			this.ID = ID;
		}

		// Token: 0x06012901 RID: 76033 RVA: 0x001B50C3 File Offset: 0x001B32C3
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayMessageListenerHandle.StaticStruct();
		}

		// Token: 0x06012902 RID: 76034 RVA: 0x001B50CF File Offset: 0x001B32CF
		[NullableContext(2)]
		public FGameplayMessageListenerHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012903 RID: 76035 RVA: 0x001B50D9 File Offset: 0x001B32D9
		public FGameplayMessageListenerHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012904 RID: 76036 RVA: 0x001B50E4 File Offset: 0x001B32E4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayMessageListenerHandle(Pointer, false, true);
		}

		// Token: 0x06012905 RID: 76037 RVA: 0x001B50EE File Offset: 0x001B32EE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayMessageListenerHandle(Pointer, MemoryOwner);
		}

		// Token: 0x04009EBA RID: 40634
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayMessageRuntime.GameplayMessageListenerHandle";

		// Token: 0x04009EBB RID: 40635
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009EBC RID: 40636
		internal static int __PropertyOffset_Subsystem;

		// Token: 0x04009EBD RID: 40637
		internal static int __PropertyOffset_Channel;

		// Token: 0x04009EBE RID: 40638
		internal static int __PropertyOffset_ID;
	}
}
