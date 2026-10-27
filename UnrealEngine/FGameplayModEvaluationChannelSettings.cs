using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001396 RID: 5014
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayModEvaluationChannelSettings")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class FGameplayModEvaluationChannelSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060126A2 RID: 75426 RVA: 0x001B1208 File Offset: 0x001AF408
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayModEvaluationChannelSettings._ScriptStructPtr != 0) ? FGameplayModEvaluationChannelSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayModEvaluationChannelSettings", ref FGameplayModEvaluationChannelSettings._ScriptStructPtr);
		}

		// Token: 0x170047CD RID: 18381
		// (get) Token: 0x060126A3 RID: 75427 RVA: 0x001B122C File Offset: 0x001AF42C
		// (set) Token: 0x060126A4 RID: 75428 RVA: 0x001B123C File Offset: 0x001AF43C
		public unsafe EGameplayModEvaluationChannel Channel
		{
			get
			{
				return (EGameplayModEvaluationChannel)(*(base.NativePtr + (IntPtr)FGameplayModEvaluationChannelSettings.__PropertyOffset_Channel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayModEvaluationChannelSettings.__PropertyOffset_Channel) = (byte)value;
			}
		}

		// Token: 0x060126A5 RID: 75429 RVA: 0x001B124D File Offset: 0x001AF44D
		public FGameplayModEvaluationChannelSettings()
		{
		}

		// Token: 0x060126A6 RID: 75430 RVA: 0x001B1255 File Offset: 0x001AF455
		public FGameplayModEvaluationChannelSettings(EGameplayModEvaluationChannel Channel)
		{
			this.Channel = Channel;
		}

		// Token: 0x060126A7 RID: 75431 RVA: 0x001B1264 File Offset: 0x001AF464
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayModEvaluationChannelSettings.StaticStruct();
		}

		// Token: 0x060126A8 RID: 75432 RVA: 0x001B1270 File Offset: 0x001AF470
		[NullableContext(2)]
		public FGameplayModEvaluationChannelSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060126A9 RID: 75433 RVA: 0x001B127A File Offset: 0x001AF47A
		public FGameplayModEvaluationChannelSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060126AA RID: 75434 RVA: 0x001B1285 File Offset: 0x001AF485
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayModEvaluationChannelSettings(Pointer, false, true);
		}

		// Token: 0x060126AB RID: 75435 RVA: 0x001B128F File Offset: 0x001AF48F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayModEvaluationChannelSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04009DCA RID: 40394
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayModEvaluationChannelSettings";

		// Token: 0x04009DCB RID: 40395
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009DCC RID: 40396
		internal static int __PropertyOffset_Channel;
	}
}
