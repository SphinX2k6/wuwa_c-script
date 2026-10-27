using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013B4 RID: 5044
	[UnrealObjectPath("/Script/GameplayAbilities.SetByCallerFloat")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSetByCallerFloat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601280E RID: 75790 RVA: 0x001B33D4 File Offset: 0x001B15D4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSetByCallerFloat._ScriptStructPtr != 0) ? FSetByCallerFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.SetByCallerFloat", ref FSetByCallerFloat._ScriptStructPtr);
		}

		// Token: 0x17004807 RID: 18439
		// (get) Token: 0x0601280F RID: 75791 RVA: 0x001B33F8 File Offset: 0x001B15F8
		// (set) Token: 0x06012810 RID: 75792 RVA: 0x001B3408 File Offset: 0x001B1608
		public unsafe int DataKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSetByCallerFloat.__PropertyOffset_DataKey);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSetByCallerFloat.__PropertyOffset_DataKey) = value;
			}
		}

		// Token: 0x17004808 RID: 18440
		// (get) Token: 0x06012811 RID: 75793 RVA: 0x001B3419 File Offset: 0x001B1619
		// (set) Token: 0x06012812 RID: 75794 RVA: 0x001B342D File Offset: 0x001B162D
		public unsafe FGameplayTag DataTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSetByCallerFloat.__PropertyOffset_DataTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSetByCallerFloat.__PropertyOffset_DataTag) = value;
			}
		}

		// Token: 0x06012813 RID: 75795 RVA: 0x001B3442 File Offset: 0x001B1642
		public FSetByCallerFloat()
		{
		}

		// Token: 0x06012814 RID: 75796 RVA: 0x001B344A File Offset: 0x001B164A
		public FSetByCallerFloat(int DataKey, FGameplayTag DataTag)
		{
			this.DataKey = DataKey;
			this.DataTag = DataTag;
		}

		// Token: 0x06012815 RID: 75797 RVA: 0x001B3460 File Offset: 0x001B1660
		protected override IntPtr GetUStructPtr()
		{
			return FSetByCallerFloat.StaticStruct();
		}

		// Token: 0x06012816 RID: 75798 RVA: 0x001B346C File Offset: 0x001B166C
		[NullableContext(2)]
		public FSetByCallerFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012817 RID: 75799 RVA: 0x001B3476 File Offset: 0x001B1676
		public FSetByCallerFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012818 RID: 75800 RVA: 0x001B3481 File Offset: 0x001B1681
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSetByCallerFloat(Pointer, false, true);
		}

		// Token: 0x06012819 RID: 75801 RVA: 0x001B348B File Offset: 0x001B168B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSetByCallerFloat(Pointer, MemoryOwner);
		}

		// Token: 0x04009E63 RID: 40547
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.SetByCallerFloat";

		// Token: 0x04009E64 RID: 40548
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009E65 RID: 40549
		internal static int __PropertyOffset_DataKey;

		// Token: 0x04009E66 RID: 40550
		internal static int __PropertyOffset_DataTag;
	}
}
