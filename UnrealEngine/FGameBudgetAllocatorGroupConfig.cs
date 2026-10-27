using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001860 RID: 6240
	[UnrealObjectPath("/Script/KuroGameBudget.GameBudgetAllocatorGroupConfig")]
	[UnrealStructLayout(208, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FGameBudgetAllocatorGroupConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016F50 RID: 94032 RVA: 0x00217E42 File Offset: 0x00216042
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameBudgetAllocatorGroupConfig._ScriptStructPtr != 0) ? FGameBudgetAllocatorGroupConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameBudget.GameBudgetAllocatorGroupConfig", ref FGameBudgetAllocatorGroupConfig._ScriptStructPtr);
		}

		// Token: 0x17005C79 RID: 23673
		// (get) Token: 0x06016F51 RID: 94033 RVA: 0x00217E66 File Offset: 0x00216066
		// (set) Token: 0x06016F52 RID: 94034 RVA: 0x00217E7A File Offset: 0x0021607A
		public unsafe FName GroupName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_GroupName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_GroupName) = value;
			}
		}

		// Token: 0x17005C7A RID: 23674
		// (get) Token: 0x06016F53 RID: 94035 RVA: 0x00217E8F File Offset: 0x0021608F
		// (set) Token: 0x06016F54 RID: 94036 RVA: 0x00217E9F File Offset: 0x0021609F
		public unsafe ESignificanceGroup SignificanceGroup
		{
			get
			{
				return (ESignificanceGroup)(*(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_SignificanceGroup));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_SignificanceGroup) = (byte)value;
			}
		}

		// Token: 0x17005C7B RID: 23675
		// (get) Token: 0x06016F55 RID: 94037 RVA: 0x00217EB0 File Offset: 0x002160B0
		// (set) Token: 0x06016F56 RID: 94038 RVA: 0x00217EC0 File Offset: 0x002160C0
		public unsafe uint TickPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_TickPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_TickPriority) = (int)value;
			}
		}

		// Token: 0x17005C7C RID: 23676
		// (get) Token: 0x06016F57 RID: 94039 RVA: 0x00217ED1 File Offset: 0x002160D1
		// (set) Token: 0x06016F58 RID: 94040 RVA: 0x00217EE1 File Offset: 0x002160E1
		public unsafe EDisableActorTickStrategy DisableActorTickStrategy
		{
			get
			{
				return (EDisableActorTickStrategy)(*(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_DisableActorTickStrategy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_DisableActorTickStrategy) = (byte)value;
			}
		}

		// Token: 0x17005C7D RID: 23677
		// (get) Token: 0x06016F59 RID: 94041 RVA: 0x00217EF2 File Offset: 0x002160F2
		// (set) Token: 0x06016F5A RID: 94042 RVA: 0x00217F02 File Offset: 0x00216102
		public unsafe uint DisableActorTickDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_DisableActorTickDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_DisableActorTickDistance) = (int)value;
			}
		}

		// Token: 0x06016F5B RID: 94043 RVA: 0x00217F13 File Offset: 0x00216113
		public FGameBudgetAllocatorGroupConfig()
		{
		}

		// Token: 0x06016F5C RID: 94044 RVA: 0x00217F1B File Offset: 0x0021611B
		public FGameBudgetAllocatorGroupConfig(FName GroupName, ESignificanceGroup SignificanceGroup, uint TickPriority, EDisableActorTickStrategy DisableActorTickStrategy, uint DisableActorTickDistance)
		{
			this.GroupName = GroupName;
			this.SignificanceGroup = SignificanceGroup;
			this.TickPriority = TickPriority;
			this.DisableActorTickStrategy = DisableActorTickStrategy;
			this.DisableActorTickDistance = DisableActorTickDistance;
		}

		// Token: 0x06016F5D RID: 94045 RVA: 0x00217F48 File Offset: 0x00216148
		protected override IntPtr GetUStructPtr()
		{
			return FGameBudgetAllocatorGroupConfig.StaticStruct();
		}

		// Token: 0x06016F5E RID: 94046 RVA: 0x00217F54 File Offset: 0x00216154
		[NullableContext(2)]
		public FGameBudgetAllocatorGroupConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016F5F RID: 94047 RVA: 0x00217F5E File Offset: 0x0021615E
		public FGameBudgetAllocatorGroupConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016F60 RID: 94048 RVA: 0x00217F69 File Offset: 0x00216169
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameBudgetAllocatorGroupConfig(Pointer, false, true);
		}

		// Token: 0x06016F61 RID: 94049 RVA: 0x00217F73 File Offset: 0x00216173
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameBudgetAllocatorGroupConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400C7A5 RID: 51109
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameBudget.GameBudgetAllocatorGroupConfig";

		// Token: 0x0400C7A6 RID: 51110
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C7A7 RID: 51111
		internal static int __PropertyOffset_GroupName;

		// Token: 0x0400C7A8 RID: 51112
		internal static int __PropertyOffset_SignificanceGroup;

		// Token: 0x0400C7A9 RID: 51113
		internal static int __PropertyOffset_TickPriority;

		// Token: 0x0400C7AA RID: 51114
		internal static int __PropertyOffset_DisableActorTickStrategy;

		// Token: 0x0400C7AB RID: 51115
		internal static int __PropertyOffset_DisableActorTickDistance;
	}
}
