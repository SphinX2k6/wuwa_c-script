using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000124 RID: 292
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BlackboardKeySelector")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FBlackboardKeySelector : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600154E RID: 5454 RVA: 0x0001F4FC File Offset: 0x0001D6FC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlackboardKeySelector._ScriptStructPtr != 0) ? FBlackboardKeySelector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.BlackboardKeySelector", ref FBlackboardKeySelector._ScriptStructPtr);
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x0001F520 File Offset: 0x0001D720
		// (set) Token: 0x06001550 RID: 5456 RVA: 0x0001F563 File Offset: 0x0001D763
		public TArray<UBlackboardKeyType> AllowedTypes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBlackboardKeyType> result;
				if ((result = this._AllowedTypes) == null)
				{
					result = (this._AllowedTypes = new TArray<UBlackboardKeyType>(base.NativePtr + (IntPtr)FBlackboardKeySelector.__PropertyOffset_AllowedTypes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AllowedTypes.CopyAssign(value);
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x0001F571 File Offset: 0x0001D771
		// (set) Token: 0x06001552 RID: 5458 RVA: 0x0001F585 File Offset: 0x0001D785
		public unsafe FName SelectedKeyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlackboardKeySelector.__PropertyOffset_SelectedKeyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlackboardKeySelector.__PropertyOffset_SelectedKeyName) = value;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x0001F59A File Offset: 0x0001D79A
		// (set) Token: 0x06001554 RID: 5460 RVA: 0x0001F5AE File Offset: 0x0001D7AE
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UBlackboardKeyType> SelectedKeyType
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FBlackboardKeySelector.__PropertyOffset_SelectedKeyType);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FBlackboardKeySelector.__PropertyOffset_SelectedKeyType) = value;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x0001F5C3 File Offset: 0x0001D7C3
		// (set) Token: 0x06001556 RID: 5462 RVA: 0x0001F5D3 File Offset: 0x0001D7D3
		public unsafe byte SelectedKeyID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlackboardKeySelector.__PropertyOffset_SelectedKeyID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlackboardKeySelector.__PropertyOffset_SelectedKeyID) = value;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001557 RID: 5463 RVA: 0x0001F5E4 File Offset: 0x0001D7E4
		// (set) Token: 0x06001558 RID: 5464 RVA: 0x0001F5FD File Offset: 0x0001D7FD
		public unsafe bool bNoneIsAllowedValue
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBlackboardKeySelector.__PropertyOffset_bNoneIsAllowedValue) & FBlackboardKeySelector.__PropertyMask_bNoneIsAllowedValue) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBlackboardKeySelector.__PropertyOffset_bNoneIsAllowedValue) = ((*(base.NativePtr + (IntPtr)FBlackboardKeySelector.__PropertyOffset_bNoneIsAllowedValue) & ~FBlackboardKeySelector.__PropertyMask_bNoneIsAllowedValue) | (value ? FBlackboardKeySelector.__PropertyMask_bNoneIsAllowedValue : 0));
			}
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x0001F62D File Offset: 0x0001D82D
		public FBlackboardKeySelector()
		{
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x0001F635 File Offset: 0x0001D835
		public FBlackboardKeySelector(TArray<UBlackboardKeyType> AllowedTypes, FName SelectedKeyName, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UBlackboardKeyType> SelectedKeyType, byte SelectedKeyID, bool bNoneIsAllowedValue)
		{
			this.AllowedTypes = AllowedTypes;
			this.SelectedKeyName = SelectedKeyName;
			this.SelectedKeyType = SelectedKeyType;
			this.SelectedKeyID = SelectedKeyID;
			this.bNoneIsAllowedValue = bNoneIsAllowedValue;
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0001F662 File Offset: 0x0001D862
		protected override IntPtr GetUStructPtr()
		{
			return FBlackboardKeySelector.StaticStruct();
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0001F66E File Offset: 0x0001D86E
		[NullableContext(2)]
		public FBlackboardKeySelector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x0001F678 File Offset: 0x0001D878
		public FBlackboardKeySelector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x0001F683 File Offset: 0x0001D883
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlackboardKeySelector(Pointer, false, true);
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x0001F68D File Offset: 0x0001D88D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlackboardKeySelector(Pointer, MemoryOwner);
		}

		// Token: 0x04000477 RID: 1143
		public const string __ObjectPath = "/Script/AIModule.BlackboardKeySelector";

		// Token: 0x04000478 RID: 1144
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000479 RID: 1145
		internal static int __PropertyOffset_AllowedTypes;

		// Token: 0x0400047A RID: 1146
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBlackboardKeyType> _AllowedTypes;

		// Token: 0x0400047B RID: 1147
		internal static int __PropertyOffset_SelectedKeyName;

		// Token: 0x0400047C RID: 1148
		internal static int __PropertyOffset_SelectedKeyType;

		// Token: 0x0400047D RID: 1149
		internal static int __PropertyOffset_SelectedKeyID;

		// Token: 0x0400047E RID: 1150
		internal static int __PropertyOffset_bNoneIsAllowedValue;

		// Token: 0x0400047F RID: 1151
		internal static byte __PropertyMask_bNoneIsAllowedValue;
	}
}
