using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001DE9 RID: 7657
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_HeadHpContext")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKSC_HeadHpContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D443 RID: 119875 RVA: 0x002B3840 File Offset: 0x002B1A40
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_HeadHpContext._ScriptStructPtr != 0) ? FKSC_HeadHpContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_HeadHpContext", ref FKSC_HeadHpContext._ScriptStructPtr);
		}

		// Token: 0x1700762F RID: 30255
		// (get) Token: 0x0601D444 RID: 119876 RVA: 0x002B3864 File Offset: 0x002B1A64
		// (set) Token: 0x0601D445 RID: 119877 RVA: 0x002B3874 File Offset: 0x002B1A74
		public unsafe EKSC_HeadHpContextType ActionType
		{
			get
			{
				return (EKSC_HeadHpContextType)(*(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_ActionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_ActionType) = (byte)value;
			}
		}

		// Token: 0x17007630 RID: 30256
		// (get) Token: 0x0601D446 RID: 119878 RVA: 0x002B3885 File Offset: 0x002B1A85
		// (set) Token: 0x0601D447 RID: 119879 RVA: 0x002B3899 File Offset: 0x002B1A99
		public unsafe FVectorDouble Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17007631 RID: 30257
		// (get) Token: 0x0601D448 RID: 119880 RVA: 0x002B38AE File Offset: 0x002B1AAE
		// (set) Token: 0x0601D449 RID: 119881 RVA: 0x002B38BE File Offset: 0x002B1ABE
		public unsafe int EntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_EntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_EntityId) = value;
			}
		}

		// Token: 0x17007632 RID: 30258
		// (get) Token: 0x0601D44A RID: 119882 RVA: 0x002B38CF File Offset: 0x002B1ACF
		// (set) Token: 0x0601D44B RID: 119883 RVA: 0x002B38DF File Offset: 0x002B1ADF
		public unsafe int CurHp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_CurHp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_CurHp) = value;
			}
		}

		// Token: 0x17007633 RID: 30259
		// (get) Token: 0x0601D44C RID: 119884 RVA: 0x002B38F0 File Offset: 0x002B1AF0
		// (set) Token: 0x0601D44D RID: 119885 RVA: 0x002B3900 File Offset: 0x002B1B00
		public unsafe int MaxHp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_MaxHp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_MaxHp) = value;
			}
		}

		// Token: 0x17007634 RID: 30260
		// (get) Token: 0x0601D44E RID: 119886 RVA: 0x002B3911 File Offset: 0x002B1B11
		// (set) Token: 0x0601D44F RID: 119887 RVA: 0x002B3921 File Offset: 0x002B1B21
		public unsafe int Shield
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_Shield);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_Shield) = value;
			}
		}

		// Token: 0x17007635 RID: 30261
		// (get) Token: 0x0601D450 RID: 119888 RVA: 0x002B3932 File Offset: 0x002B1B32
		// (set) Token: 0x0601D451 RID: 119889 RVA: 0x002B3942 File Offset: 0x002B1B42
		public unsafe EKSC_HeadUiType HeadUiType
		{
			get
			{
				return (EKSC_HeadUiType)(*(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_HeadUiType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadHpContext.__PropertyOffset_HeadUiType) = (byte)value;
			}
		}

		// Token: 0x0601D452 RID: 119890 RVA: 0x002B3953 File Offset: 0x002B1B53
		public FKSC_HeadHpContext()
		{
		}

		// Token: 0x0601D453 RID: 119891 RVA: 0x002B395B File Offset: 0x002B1B5B
		public FKSC_HeadHpContext(EKSC_HeadHpContextType ActionType, FVectorDouble Location, int EntityId, int CurHp, int MaxHp, int Shield, EKSC_HeadUiType HeadUiType)
		{
			this.ActionType = ActionType;
			this.Location = Location;
			this.EntityId = EntityId;
			this.CurHp = CurHp;
			this.MaxHp = MaxHp;
			this.Shield = Shield;
			this.HeadUiType = HeadUiType;
		}

		// Token: 0x0601D454 RID: 119892 RVA: 0x002B3998 File Offset: 0x002B1B98
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_HeadHpContext.StaticStruct();
		}

		// Token: 0x0601D455 RID: 119893 RVA: 0x002B39A4 File Offset: 0x002B1BA4
		[NullableContext(2)]
		public FKSC_HeadHpContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D456 RID: 119894 RVA: 0x002B39AE File Offset: 0x002B1BAE
		public FKSC_HeadHpContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D457 RID: 119895 RVA: 0x002B39B9 File Offset: 0x002B1BB9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_HeadHpContext(Pointer, false, true);
		}

		// Token: 0x0601D458 RID: 119896 RVA: 0x002B39C3 File Offset: 0x002B1BC3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_HeadHpContext(Pointer, MemoryOwner);
		}

		// Token: 0x0400FE20 RID: 65056
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_HeadHpContext";

		// Token: 0x0400FE21 RID: 65057
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FE22 RID: 65058
		internal static int __PropertyOffset_ActionType;

		// Token: 0x0400FE23 RID: 65059
		internal static int __PropertyOffset_Location;

		// Token: 0x0400FE24 RID: 65060
		internal static int __PropertyOffset_EntityId;

		// Token: 0x0400FE25 RID: 65061
		internal static int __PropertyOffset_CurHp;

		// Token: 0x0400FE26 RID: 65062
		internal static int __PropertyOffset_MaxHp;

		// Token: 0x0400FE27 RID: 65063
		internal static int __PropertyOffset_Shield;

		// Token: 0x0400FE28 RID: 65064
		internal static int __PropertyOffset_HeadUiType;
	}
}
