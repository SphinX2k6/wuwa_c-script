using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002C4 RID: 708
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAttributeData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FGameplayAttributeData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004D8F RID: 19855 RVA: 0x0006C5BA File Offset: 0x0006A7BA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAttributeData._ScriptStructPtr != 0) ? FGameplayAttributeData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAttributeData", ref FGameplayAttributeData._ScriptStructPtr);
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06004D90 RID: 19856 RVA: 0x0006C5DE File Offset: 0x0006A7DE
		// (set) Token: 0x06004D91 RID: 19857 RVA: 0x0006C5EE File Offset: 0x0006A7EE
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

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06004D92 RID: 19858 RVA: 0x0006C5FF File Offset: 0x0006A7FF
		// (set) Token: 0x06004D93 RID: 19859 RVA: 0x0006C60F File Offset: 0x0006A80F
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

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06004D94 RID: 19860 RVA: 0x0006C620 File Offset: 0x0006A820
		// (set) Token: 0x06004D95 RID: 19861 RVA: 0x0006C630 File Offset: 0x0006A830
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

		// Token: 0x06004D96 RID: 19862 RVA: 0x0006C641 File Offset: 0x0006A841
		public FGameplayAttributeData()
		{
		}

		// Token: 0x06004D97 RID: 19863 RVA: 0x0006C649 File Offset: 0x0006A849
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAttributeData.StaticStruct();
		}

		// Token: 0x06004D98 RID: 19864 RVA: 0x0006C655 File Offset: 0x0006A855
		[NullableContext(2)]
		public FGameplayAttributeData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004D99 RID: 19865 RVA: 0x0006C65F File Offset: 0x0006A85F
		public FGameplayAttributeData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004D9A RID: 19866 RVA: 0x0006C66A File Offset: 0x0006A86A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAttributeData(Pointer, false, true);
		}

		// Token: 0x06004D9B RID: 19867 RVA: 0x0006C674 File Offset: 0x0006A874
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAttributeData(Pointer, MemoryOwner);
		}

		// Token: 0x04001EF0 RID: 7920
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayAttributeData";

		// Token: 0x04001EF1 RID: 7921
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001EF2 RID: 7922
		internal static int __PropertyOffset_BaseValue;

		// Token: 0x04001EF3 RID: 7923
		internal static int __PropertyOffset_CurrentValue;

		// Token: 0x04001EF4 RID: 7924
		internal static int __PropertyOffset_AttributeType;
	}
}
