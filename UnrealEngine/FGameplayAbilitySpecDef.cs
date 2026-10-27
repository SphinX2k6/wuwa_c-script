using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001355 RID: 4949
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilitySpecDef")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FGameplayAbilitySpecDef : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012291 RID: 74385 RVA: 0x001AAA93 File Offset: 0x001A8C93
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAbilitySpecDef._ScriptStructPtr != 0) ? FGameplayAbilitySpecDef._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAbilitySpecDef", ref FGameplayAbilitySpecDef._ScriptStructPtr);
		}

		// Token: 0x170046BF RID: 18111
		// (get) Token: 0x06012292 RID: 74386 RVA: 0x001AAAB7 File Offset: 0x001A8CB7
		// (set) Token: 0x06012293 RID: 74387 RVA: 0x001AAACB File Offset: 0x001A8CCB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UGameplayAbility> Ability
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilitySpecDef.__PropertyOffset_Ability);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilitySpecDef.__PropertyOffset_Ability) = value;
			}
		}

		// Token: 0x170046C0 RID: 18112
		// (get) Token: 0x06012294 RID: 74388 RVA: 0x001AAAE0 File Offset: 0x001A8CE0
		// (set) Token: 0x06012295 RID: 74389 RVA: 0x001AAB23 File Offset: 0x001A8D23
		public FScalableFloat LevelScalableFloat
		{
			get
			{
				base.FastCheckIsValid();
				FScalableFloat result;
				if ((result = this._LevelScalableFloat) == null)
				{
					result = (this._LevelScalableFloat = new FScalableFloat(base.NativePtr + (IntPtr)FGameplayAbilitySpecDef.__PropertyOffset_LevelScalableFloat, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScalableFloat.StaticStruct(), base.NativePtr + (IntPtr)FGameplayAbilitySpecDef.__PropertyOffset_LevelScalableFloat, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170046C1 RID: 18113
		// (get) Token: 0x06012296 RID: 74390 RVA: 0x001AAB44 File Offset: 0x001A8D44
		// (set) Token: 0x06012297 RID: 74391 RVA: 0x001AAB54 File Offset: 0x001A8D54
		public unsafe int InputID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilitySpecDef.__PropertyOffset_InputID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilitySpecDef.__PropertyOffset_InputID) = value;
			}
		}

		// Token: 0x170046C2 RID: 18114
		// (get) Token: 0x06012298 RID: 74392 RVA: 0x001AAB65 File Offset: 0x001A8D65
		// (set) Token: 0x06012299 RID: 74393 RVA: 0x001AAB75 File Offset: 0x001A8D75
		public unsafe EGameplayEffectGrantedAbilityRemovePolicy RemovalPolicy
		{
			get
			{
				return (EGameplayEffectGrantedAbilityRemovePolicy)(*(base.NativePtr + (IntPtr)FGameplayAbilitySpecDef.__PropertyOffset_RemovalPolicy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilitySpecDef.__PropertyOffset_RemovalPolicy) = (byte)value;
			}
		}

		// Token: 0x170046C3 RID: 18115
		// (get) Token: 0x0601229A RID: 74394 RVA: 0x001AAB86 File Offset: 0x001A8D86
		// (set) Token: 0x0601229B RID: 74395 RVA: 0x001AAB9A File Offset: 0x001A8D9A
		[Nullable(2)]
		public unsafe UObject SourceObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilitySpecDef.__PropertyOffset_SourceObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayAbilitySpecDef.__PropertyOffset_SourceObject, value);
			}
		}

		// Token: 0x170046C4 RID: 18116
		// (get) Token: 0x0601229C RID: 74396 RVA: 0x001AABB0 File Offset: 0x001A8DB0
		// (set) Token: 0x0601229D RID: 74397 RVA: 0x001AABF3 File Offset: 0x001A8DF3
		public FGameplayAbilitySpecHandle AssignedHandle
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAbilitySpecHandle result;
				if ((result = this._AssignedHandle) == null)
				{
					result = (this._AssignedHandle = new FGameplayAbilitySpecHandle(base.NativePtr + (IntPtr)FGameplayAbilitySpecDef.__PropertyOffset_AssignedHandle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilitySpecHandle.StaticStruct(), base.NativePtr + (IntPtr)FGameplayAbilitySpecDef.__PropertyOffset_AssignedHandle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601229E RID: 74398 RVA: 0x001AAC14 File Offset: 0x001A8E14
		public FGameplayAbilitySpecDef()
		{
		}

		// Token: 0x0601229F RID: 74399 RVA: 0x001AAC1C File Offset: 0x001A8E1C
		public FGameplayAbilitySpecDef([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayAbility> Ability, FScalableFloat LevelScalableFloat, int InputID, EGameplayEffectGrantedAbilityRemovePolicy RemovalPolicy, UObject SourceObject, FGameplayAbilitySpecHandle AssignedHandle)
		{
			this.Ability = Ability;
			this.LevelScalableFloat = LevelScalableFloat;
			this.InputID = InputID;
			this.RemovalPolicy = RemovalPolicy;
			this.SourceObject = SourceObject;
			this.AssignedHandle = AssignedHandle;
		}

		// Token: 0x060122A0 RID: 74400 RVA: 0x001AAC51 File Offset: 0x001A8E51
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAbilitySpecDef.StaticStruct();
		}

		// Token: 0x060122A1 RID: 74401 RVA: 0x001AAC5D File Offset: 0x001A8E5D
		[NullableContext(2)]
		public FGameplayAbilitySpecDef(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060122A2 RID: 74402 RVA: 0x001AAC67 File Offset: 0x001A8E67
		public FGameplayAbilitySpecDef(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060122A3 RID: 74403 RVA: 0x001AAC72 File Offset: 0x001A8E72
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAbilitySpecDef(Pointer, false, true);
		}

		// Token: 0x060122A4 RID: 74404 RVA: 0x001AAC7C File Offset: 0x001A8E7C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAbilitySpecDef(Pointer, MemoryOwner);
		}

		// Token: 0x04009BAB RID: 39851
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilitySpecDef";

		// Token: 0x04009BAC RID: 39852
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009BAD RID: 39853
		internal static int __PropertyOffset_Ability;

		// Token: 0x04009BAE RID: 39854
		internal static int __PropertyOffset_LevelScalableFloat;

		// Token: 0x04009BAF RID: 39855
		[Nullable(2)]
		private FScalableFloat _LevelScalableFloat;

		// Token: 0x04009BB0 RID: 39856
		internal static int __PropertyOffset_InputID;

		// Token: 0x04009BB1 RID: 39857
		internal static int __PropertyOffset_RemovalPolicy;

		// Token: 0x04009BB2 RID: 39858
		internal static int __PropertyOffset_SourceObject;

		// Token: 0x04009BB3 RID: 39859
		internal static int __PropertyOffset_AssignedHandle;

		// Token: 0x04009BB4 RID: 39860
		[Nullable(2)]
		private FGameplayAbilitySpecHandle _AssignedHandle;
	}
}
