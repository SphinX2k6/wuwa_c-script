using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001369 RID: 4969
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAttributeData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FGameplayAttributeData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012391 RID: 74641 RVA: 0x001ABFF2 File Offset: 0x001AA1F2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAttributeData._ScriptStructPtr != 0) ? FGameplayAttributeData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAttributeData", ref FGameplayAttributeData._ScriptStructPtr);
		}

		// Token: 0x170046F8 RID: 18168
		// (get) Token: 0x06012392 RID: 74642 RVA: 0x001AC016 File Offset: 0x001AA216
		// (set) Token: 0x06012393 RID: 74643 RVA: 0x001AC026 File Offset: 0x001AA226
		public unsafe float BaseValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAttributeData.__PropertyOffset_BaseValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAttributeData.__PropertyOffset_BaseValue) = value;
			}
		}

		// Token: 0x170046F9 RID: 18169
		// (get) Token: 0x06012394 RID: 74644 RVA: 0x001AC037 File Offset: 0x001AA237
		// (set) Token: 0x06012395 RID: 74645 RVA: 0x001AC047 File Offset: 0x001AA247
		public unsafe float CurrentValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAttributeData.__PropertyOffset_CurrentValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAttributeData.__PropertyOffset_CurrentValue) = value;
			}
		}

		// Token: 0x170046FA RID: 18170
		// (get) Token: 0x06012396 RID: 74646 RVA: 0x001AC058 File Offset: 0x001AA258
		// (set) Token: 0x06012397 RID: 74647 RVA: 0x001AC068 File Offset: 0x001AA268
		public unsafe int AttributeType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAttributeData.__PropertyOffset_AttributeType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAttributeData.__PropertyOffset_AttributeType) = value;
			}
		}

		// Token: 0x06012398 RID: 74648 RVA: 0x001AC079 File Offset: 0x001AA279
		public FGameplayAttributeData()
		{
		}

		// Token: 0x06012399 RID: 74649 RVA: 0x001AC081 File Offset: 0x001AA281
		public FGameplayAttributeData(float BaseValue, float CurrentValue, int AttributeType)
		{
			this.BaseValue = BaseValue;
			this.CurrentValue = CurrentValue;
			this.AttributeType = AttributeType;
		}

		// Token: 0x0601239A RID: 74650 RVA: 0x001AC09E File Offset: 0x001AA29E
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAttributeData.StaticStruct();
		}

		// Token: 0x0601239B RID: 74651 RVA: 0x001AC0AA File Offset: 0x001AA2AA
		[NullableContext(2)]
		public FGameplayAttributeData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601239C RID: 74652 RVA: 0x001AC0B4 File Offset: 0x001AA2B4
		public FGameplayAttributeData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601239D RID: 74653 RVA: 0x001AC0BF File Offset: 0x001AA2BF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAttributeData(Pointer, false, true);
		}

		// Token: 0x0601239E RID: 74654 RVA: 0x001AC0C9 File Offset: 0x001AA2C9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAttributeData(Pointer, MemoryOwner);
		}

		// Token: 0x04009C26 RID: 39974
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayAttributeData";

		// Token: 0x04009C27 RID: 39975
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009C28 RID: 39976
		internal static int __PropertyOffset_BaseValue;

		// Token: 0x04009C29 RID: 39977
		internal static int __PropertyOffset_CurrentValue;

		// Token: 0x04009C2A RID: 39978
		internal static int __PropertyOffset_AttributeType;
	}
}
