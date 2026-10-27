using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200137E RID: 4990
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectAttributeCaptureDefinition")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FGameplayEffectAttributeCaptureDefinition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601252C RID: 75052 RVA: 0x001AE9B0 File Offset: 0x001ACBB0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayEffectAttributeCaptureDefinition._ScriptStructPtr != 0) ? FGameplayEffectAttributeCaptureDefinition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayEffectAttributeCaptureDefinition", ref FGameplayEffectAttributeCaptureDefinition._ScriptStructPtr);
		}

		// Token: 0x1700476A RID: 18282
		// (get) Token: 0x0601252D RID: 75053 RVA: 0x001AE9D4 File Offset: 0x001ACBD4
		// (set) Token: 0x0601252E RID: 75054 RVA: 0x001AEA17 File Offset: 0x001ACC17
		public FGameplayAttribute AttributeToCapture
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttribute result;
				if ((result = this._AttributeToCapture) == null)
				{
					result = (this._AttributeToCapture = new FGameplayAttribute(base.NativePtr + (IntPtr)FGameplayEffectAttributeCaptureDefinition.__PropertyOffset_AttributeToCapture, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttribute.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectAttributeCaptureDefinition.__PropertyOffset_AttributeToCapture, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700476B RID: 18283
		// (get) Token: 0x0601252F RID: 75055 RVA: 0x001AEA38 File Offset: 0x001ACC38
		// (set) Token: 0x06012530 RID: 75056 RVA: 0x001AEA48 File Offset: 0x001ACC48
		public unsafe EGameplayEffectAttributeCaptureSource AttributeSource
		{
			get
			{
				return (EGameplayEffectAttributeCaptureSource)(*(base.NativePtr + (IntPtr)FGameplayEffectAttributeCaptureDefinition.__PropertyOffset_AttributeSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectAttributeCaptureDefinition.__PropertyOffset_AttributeSource) = (byte)value;
			}
		}

		// Token: 0x1700476C RID: 18284
		// (get) Token: 0x06012531 RID: 75057 RVA: 0x001AEA59 File Offset: 0x001ACC59
		// (set) Token: 0x06012532 RID: 75058 RVA: 0x001AEA69 File Offset: 0x001ACC69
		public unsafe bool bSnapshot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectAttributeCaptureDefinition.__PropertyOffset_bSnapshot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectAttributeCaptureDefinition.__PropertyOffset_bSnapshot) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700476D RID: 18285
		// (get) Token: 0x06012533 RID: 75059 RVA: 0x001AEA7A File Offset: 0x001ACC7A
		// (set) Token: 0x06012534 RID: 75060 RVA: 0x001AEA8E File Offset: 0x001ACC8E
		public unsafe FGameplayTag DataTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectAttributeCaptureDefinition.__PropertyOffset_DataTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectAttributeCaptureDefinition.__PropertyOffset_DataTag) = value;
			}
		}

		// Token: 0x1700476E RID: 18286
		// (get) Token: 0x06012535 RID: 75061 RVA: 0x001AEAA3 File Offset: 0x001ACCA3
		// (set) Token: 0x06012536 RID: 75062 RVA: 0x001AEAB7 File Offset: 0x001ACCB7
		public unsafe FGameplayTag DataTag2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectAttributeCaptureDefinition.__PropertyOffset_DataTag2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectAttributeCaptureDefinition.__PropertyOffset_DataTag2) = value;
			}
		}

		// Token: 0x06012537 RID: 75063 RVA: 0x001AEACC File Offset: 0x001ACCCC
		public FGameplayEffectAttributeCaptureDefinition()
		{
		}

		// Token: 0x06012538 RID: 75064 RVA: 0x001AEAD4 File Offset: 0x001ACCD4
		public FGameplayEffectAttributeCaptureDefinition(FGameplayAttribute AttributeToCapture, EGameplayEffectAttributeCaptureSource AttributeSource, bool bSnapshot, FGameplayTag DataTag, FGameplayTag DataTag2)
		{
			this.AttributeToCapture = AttributeToCapture;
			this.AttributeSource = AttributeSource;
			this.bSnapshot = bSnapshot;
			this.DataTag = DataTag;
			this.DataTag2 = DataTag2;
		}

		// Token: 0x06012539 RID: 75065 RVA: 0x001AEB01 File Offset: 0x001ACD01
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayEffectAttributeCaptureDefinition.StaticStruct();
		}

		// Token: 0x0601253A RID: 75066 RVA: 0x001AEB0D File Offset: 0x001ACD0D
		[NullableContext(2)]
		public FGameplayEffectAttributeCaptureDefinition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601253B RID: 75067 RVA: 0x001AEB17 File Offset: 0x001ACD17
		public FGameplayEffectAttributeCaptureDefinition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601253C RID: 75068 RVA: 0x001AEB22 File Offset: 0x001ACD22
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayEffectAttributeCaptureDefinition(Pointer, false, true);
		}

		// Token: 0x0601253D RID: 75069 RVA: 0x001AEB2C File Offset: 0x001ACD2C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayEffectAttributeCaptureDefinition(Pointer, MemoryOwner);
		}

		// Token: 0x04009CFA RID: 40186
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectAttributeCaptureDefinition";

		// Token: 0x04009CFB RID: 40187
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009CFC RID: 40188
		internal static int __PropertyOffset_AttributeToCapture;

		// Token: 0x04009CFD RID: 40189
		[Nullable(2)]
		private FGameplayAttribute _AttributeToCapture;

		// Token: 0x04009CFE RID: 40190
		internal static int __PropertyOffset_AttributeSource;

		// Token: 0x04009CFF RID: 40191
		internal static int __PropertyOffset_bSnapshot;

		// Token: 0x04009D00 RID: 40192
		internal static int __PropertyOffset_DataTag;

		// Token: 0x04009D01 RID: 40193
		internal static int __PropertyOffset_DataTag2;
	}
}
