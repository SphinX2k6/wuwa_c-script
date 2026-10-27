using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200139F RID: 5023
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayTagResponseTableEntry")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FGameplayTagResponseTableEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601271F RID: 75551 RVA: 0x001B1DB8 File Offset: 0x001AFFB8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTagResponseTableEntry._ScriptStructPtr != 0) ? FGameplayTagResponseTableEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayTagResponseTableEntry", ref FGameplayTagResponseTableEntry._ScriptStructPtr);
		}

		// Token: 0x170047EA RID: 18410
		// (get) Token: 0x06012720 RID: 75552 RVA: 0x001B1DDC File Offset: 0x001AFFDC
		// (set) Token: 0x06012721 RID: 75553 RVA: 0x001B1E1F File Offset: 0x001B001F
		public FGameplayTagReponsePair Positive
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagReponsePair result;
				if ((result = this._Positive) == null)
				{
					result = (this._Positive = new FGameplayTagReponsePair(base.NativePtr + (IntPtr)FGameplayTagResponseTableEntry.__PropertyOffset_Positive, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagReponsePair.StaticStruct(), base.NativePtr + (IntPtr)FGameplayTagResponseTableEntry.__PropertyOffset_Positive, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047EB RID: 18411
		// (get) Token: 0x06012722 RID: 75554 RVA: 0x001B1E40 File Offset: 0x001B0040
		// (set) Token: 0x06012723 RID: 75555 RVA: 0x001B1E83 File Offset: 0x001B0083
		public FGameplayTagReponsePair Negative
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagReponsePair result;
				if ((result = this._Negative) == null)
				{
					result = (this._Negative = new FGameplayTagReponsePair(base.NativePtr + (IntPtr)FGameplayTagResponseTableEntry.__PropertyOffset_Negative, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagReponsePair.StaticStruct(), base.NativePtr + (IntPtr)FGameplayTagResponseTableEntry.__PropertyOffset_Negative, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06012724 RID: 75556 RVA: 0x001B1EA4 File Offset: 0x001B00A4
		public FGameplayTagResponseTableEntry()
		{
		}

		// Token: 0x06012725 RID: 75557 RVA: 0x001B1EAC File Offset: 0x001B00AC
		public FGameplayTagResponseTableEntry(FGameplayTagReponsePair Positive, FGameplayTagReponsePair Negative)
		{
			this.Positive = Positive;
			this.Negative = Negative;
		}

		// Token: 0x06012726 RID: 75558 RVA: 0x001B1EC2 File Offset: 0x001B00C2
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayTagResponseTableEntry.StaticStruct();
		}

		// Token: 0x06012727 RID: 75559 RVA: 0x001B1ECE File Offset: 0x001B00CE
		[NullableContext(2)]
		public FGameplayTagResponseTableEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012728 RID: 75560 RVA: 0x001B1ED8 File Offset: 0x001B00D8
		public FGameplayTagResponseTableEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012729 RID: 75561 RVA: 0x001B1EE3 File Offset: 0x001B00E3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayTagResponseTableEntry(Pointer, false, true);
		}

		// Token: 0x0601272A RID: 75562 RVA: 0x001B1EED File Offset: 0x001B00ED
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayTagResponseTableEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04009E08 RID: 40456
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayTagResponseTableEntry";

		// Token: 0x04009E09 RID: 40457
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009E0A RID: 40458
		internal static int __PropertyOffset_Positive;

		// Token: 0x04009E0B RID: 40459
		[Nullable(2)]
		private FGameplayTagReponsePair _Positive;

		// Token: 0x04009E0C RID: 40460
		internal static int __PropertyOffset_Negative;

		// Token: 0x04009E0D RID: 40461
		[Nullable(2)]
		private FGameplayTagReponsePair _Negative;
	}
}
