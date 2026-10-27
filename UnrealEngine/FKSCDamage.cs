using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001CF1 RID: 7409
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSCDamage")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKSCDamage : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C7F8 RID: 116728 RVA: 0x002A24D7 File Offset: 0x002A06D7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSCDamage._ScriptStructPtr != 0) ? FKSCDamage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSCDamage", ref FKSCDamage._ScriptStructPtr);
		}

		// Token: 0x170072CC RID: 29388
		// (get) Token: 0x0601C7F9 RID: 116729 RVA: 0x002A24FB File Offset: 0x002A06FB
		// (set) Token: 0x0601C7FA RID: 116730 RVA: 0x002A250B File Offset: 0x002A070B
		public unsafe int DamageID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCDamage.__PropertyOffset_DamageID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCDamage.__PropertyOffset_DamageID) = value;
			}
		}

		// Token: 0x170072CD RID: 29389
		// (get) Token: 0x0601C7FB RID: 116731 RVA: 0x002A251C File Offset: 0x002A071C
		// (set) Token: 0x0601C7FC RID: 116732 RVA: 0x002A252C File Offset: 0x002A072C
		public unsafe bool Knocked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCDamage.__PropertyOffset_Knocked) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCDamage.__PropertyOffset_Knocked) = (value ? 1 : 0);
			}
		}

		// Token: 0x170072CE RID: 29390
		// (get) Token: 0x0601C7FD RID: 116733 RVA: 0x002A253D File Offset: 0x002A073D
		// (set) Token: 0x0601C7FE RID: 116734 RVA: 0x002A254D File Offset: 0x002A074D
		public unsafe EKSC_CalculateType CalculateType
		{
			get
			{
				return (EKSC_CalculateType)(*(base.NativePtr + (IntPtr)FKSCDamage.__PropertyOffset_CalculateType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCDamage.__PropertyOffset_CalculateType) = (byte)value;
			}
		}

		// Token: 0x170072CF RID: 29391
		// (get) Token: 0x0601C7FF RID: 116735 RVA: 0x002A255E File Offset: 0x002A075E
		// (set) Token: 0x0601C800 RID: 116736 RVA: 0x002A256E File Offset: 0x002A076E
		public unsafe EKSC_Element Element
		{
			get
			{
				return (EKSC_Element)(*(base.NativePtr + (IntPtr)FKSCDamage.__PropertyOffset_Element));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCDamage.__PropertyOffset_Element) = (byte)value;
			}
		}

		// Token: 0x170072D0 RID: 29392
		// (get) Token: 0x0601C801 RID: 116737 RVA: 0x002A257F File Offset: 0x002A077F
		// (set) Token: 0x0601C802 RID: 116738 RVA: 0x002A258F File Offset: 0x002A078F
		public unsafe float Amplify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCDamage.__PropertyOffset_Amplify);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCDamage.__PropertyOffset_Amplify) = value;
			}
		}

		// Token: 0x170072D1 RID: 29393
		// (get) Token: 0x0601C803 RID: 116739 RVA: 0x002A25A0 File Offset: 0x002A07A0
		// (set) Token: 0x0601C804 RID: 116740 RVA: 0x002A25B0 File Offset: 0x002A07B0
		public unsafe EKSC_AttrType RelatedProperty
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)FKSCDamage.__PropertyOffset_RelatedProperty));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCDamage.__PropertyOffset_RelatedProperty) = (byte)value;
			}
		}

		// Token: 0x170072D2 RID: 29394
		// (get) Token: 0x0601C805 RID: 116741 RVA: 0x002A25C4 File Offset: 0x002A07C4
		// (set) Token: 0x0601C806 RID: 116742 RVA: 0x002A2607 File Offset: 0x002A0807
		public TArray<FKSCDamageRelated> RelatedInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKSCDamageRelated> result;
				if ((result = this._RelatedInfos) == null)
				{
					result = (this._RelatedInfos = new TArray<FKSCDamageRelated>(base.NativePtr + (IntPtr)FKSCDamage.__PropertyOffset_RelatedInfos, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RelatedInfos.CopyAssign(value);
			}
		}

		// Token: 0x170072D3 RID: 29395
		// (get) Token: 0x0601C807 RID: 116743 RVA: 0x002A2615 File Offset: 0x002A0815
		// (set) Token: 0x0601C808 RID: 116744 RVA: 0x002A2625 File Offset: 0x002A0825
		public unsafe float BaseValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCDamage.__PropertyOffset_BaseValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCDamage.__PropertyOffset_BaseValue) = value;
			}
		}

		// Token: 0x170072D4 RID: 29396
		// (get) Token: 0x0601C809 RID: 116745 RVA: 0x002A2636 File Offset: 0x002A0836
		// (set) Token: 0x0601C80A RID: 116746 RVA: 0x002A2646 File Offset: 0x002A0846
		public unsafe EKSC_AttrType CritAttrType
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)FKSCDamage.__PropertyOffset_CritAttrType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCDamage.__PropertyOffset_CritAttrType) = (byte)value;
			}
		}

		// Token: 0x0601C80B RID: 116747 RVA: 0x002A2657 File Offset: 0x002A0857
		public FKSCDamage()
		{
		}

		// Token: 0x0601C80C RID: 116748 RVA: 0x002A2660 File Offset: 0x002A0860
		public FKSCDamage(int DamageID, bool Knocked, EKSC_CalculateType CalculateType, EKSC_Element Element, float Amplify, EKSC_AttrType RelatedProperty, TArray<FKSCDamageRelated> RelatedInfos, float BaseValue, EKSC_AttrType CritAttrType)
		{
			this.DamageID = DamageID;
			this.Knocked = Knocked;
			this.CalculateType = CalculateType;
			this.Element = Element;
			this.Amplify = Amplify;
			this.RelatedProperty = RelatedProperty;
			this.RelatedInfos = RelatedInfos;
			this.BaseValue = BaseValue;
			this.CritAttrType = CritAttrType;
		}

		// Token: 0x0601C80D RID: 116749 RVA: 0x002A26B8 File Offset: 0x002A08B8
		protected override IntPtr GetUStructPtr()
		{
			return FKSCDamage.StaticStruct();
		}

		// Token: 0x0601C80E RID: 116750 RVA: 0x002A26C4 File Offset: 0x002A08C4
		[NullableContext(2)]
		public FKSCDamage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C80F RID: 116751 RVA: 0x002A26CE File Offset: 0x002A08CE
		public FKSCDamage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C810 RID: 116752 RVA: 0x002A26D9 File Offset: 0x002A08D9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSCDamage(Pointer, false, true);
		}

		// Token: 0x0601C811 RID: 116753 RVA: 0x002A26E3 File Offset: 0x002A08E3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSCDamage(Pointer, MemoryOwner);
		}

		// Token: 0x0400F744 RID: 63300
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSCDamage";

		// Token: 0x0400F745 RID: 63301
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F746 RID: 63302
		internal static int __PropertyOffset_DamageID;

		// Token: 0x0400F747 RID: 63303
		internal static int __PropertyOffset_Knocked;

		// Token: 0x0400F748 RID: 63304
		internal static int __PropertyOffset_CalculateType;

		// Token: 0x0400F749 RID: 63305
		internal static int __PropertyOffset_Element;

		// Token: 0x0400F74A RID: 63306
		internal static int __PropertyOffset_Amplify;

		// Token: 0x0400F74B RID: 63307
		internal static int __PropertyOffset_RelatedProperty;

		// Token: 0x0400F74C RID: 63308
		internal static int __PropertyOffset_RelatedInfos;

		// Token: 0x0400F74D RID: 63309
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSCDamageRelated> _RelatedInfos;

		// Token: 0x0400F74E RID: 63310
		internal static int __PropertyOffset_BaseValue;

		// Token: 0x0400F74F RID: 63311
		internal static int __PropertyOffset_CritAttrType;
	}
}
