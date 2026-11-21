using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000559 RID: 1369
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSCDamage")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKSCDamage : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007D1E RID: 32030 RVA: 0x000B9BCA File Offset: 0x000B7DCA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSCDamage._ScriptStructPtr != 0) ? FKSCDamage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSCDamage", ref FKSCDamage._ScriptStructPtr);
		}

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x06007D1F RID: 32031 RVA: 0x000B9BEE File Offset: 0x000B7DEE
		// (set) Token: 0x06007D20 RID: 32032 RVA: 0x000B9BFE File Offset: 0x000B7DFE
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

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x06007D21 RID: 32033 RVA: 0x000B9C0F File Offset: 0x000B7E0F
		// (set) Token: 0x06007D22 RID: 32034 RVA: 0x000B9C1F File Offset: 0x000B7E1F
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

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x06007D23 RID: 32035 RVA: 0x000B9C30 File Offset: 0x000B7E30
		// (set) Token: 0x06007D24 RID: 32036 RVA: 0x000B9C40 File Offset: 0x000B7E40
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

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x06007D25 RID: 32037 RVA: 0x000B9C51 File Offset: 0x000B7E51
		// (set) Token: 0x06007D26 RID: 32038 RVA: 0x000B9C61 File Offset: 0x000B7E61
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

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x06007D27 RID: 32039 RVA: 0x000B9C72 File Offset: 0x000B7E72
		// (set) Token: 0x06007D28 RID: 32040 RVA: 0x000B9C82 File Offset: 0x000B7E82
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

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06007D29 RID: 32041 RVA: 0x000B9C93 File Offset: 0x000B7E93
		// (set) Token: 0x06007D2A RID: 32042 RVA: 0x000B9CA3 File Offset: 0x000B7EA3
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

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06007D2B RID: 32043 RVA: 0x000B9CB4 File Offset: 0x000B7EB4
		// (set) Token: 0x06007D2C RID: 32044 RVA: 0x000B9CF7 File Offset: 0x000B7EF7
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

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06007D2D RID: 32045 RVA: 0x000B9D05 File Offset: 0x000B7F05
		// (set) Token: 0x06007D2E RID: 32046 RVA: 0x000B9D15 File Offset: 0x000B7F15
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

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x06007D2F RID: 32047 RVA: 0x000B9D26 File Offset: 0x000B7F26
		// (set) Token: 0x06007D30 RID: 32048 RVA: 0x000B9D36 File Offset: 0x000B7F36
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

		// Token: 0x06007D31 RID: 32049 RVA: 0x000B9D47 File Offset: 0x000B7F47
		public FKSCDamage()
		{
		}

		// Token: 0x06007D32 RID: 32050 RVA: 0x000B9D4F File Offset: 0x000B7F4F
		protected override IntPtr GetUStructPtr()
		{
			return FKSCDamage.StaticStruct();
		}

		// Token: 0x06007D33 RID: 32051 RVA: 0x000B9D5B File Offset: 0x000B7F5B
		[NullableContext(2)]
		public FKSCDamage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007D34 RID: 32052 RVA: 0x000B9D65 File Offset: 0x000B7F65
		public FKSCDamage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007D35 RID: 32053 RVA: 0x000B9D70 File Offset: 0x000B7F70
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSCDamage(Pointer, false, true);
		}

		// Token: 0x06007D36 RID: 32054 RVA: 0x000B9D7A File Offset: 0x000B7F7A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSCDamage(Pointer, MemoryOwner);
		}

		// Token: 0x0400368A RID: 13962
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSCDamage";

		// Token: 0x0400368B RID: 13963
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400368C RID: 13964
		internal static int __PropertyOffset_DamageID;

		// Token: 0x0400368D RID: 13965
		internal static int __PropertyOffset_Knocked;

		// Token: 0x0400368E RID: 13966
		internal static int __PropertyOffset_CalculateType;

		// Token: 0x0400368F RID: 13967
		internal static int __PropertyOffset_Element;

		// Token: 0x04003690 RID: 13968
		internal static int __PropertyOffset_Amplify;

		// Token: 0x04003691 RID: 13969
		internal static int __PropertyOffset_RelatedProperty;

		// Token: 0x04003692 RID: 13970
		internal static int __PropertyOffset_RelatedInfos;

		// Token: 0x04003693 RID: 13971
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSCDamageRelated> _RelatedInfos;

		// Token: 0x04003694 RID: 13972
		internal static int __PropertyOffset_BaseValue;

		// Token: 0x04003695 RID: 13973
		internal static int __PropertyOffset_CritAttrType;
	}
}
