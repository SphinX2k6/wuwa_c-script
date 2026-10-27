using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001CF2 RID: 7410
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSCDamageRelated")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FKSCDamageRelated : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C812 RID: 116754 RVA: 0x002A26EC File Offset: 0x002A08EC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSCDamageRelated._ScriptStructPtr != 0) ? FKSCDamageRelated._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSCDamageRelated", ref FKSCDamageRelated._ScriptStructPtr);
		}

		// Token: 0x170072D5 RID: 29397
		// (get) Token: 0x0601C813 RID: 116755 RVA: 0x002A2710 File Offset: 0x002A0910
		// (set) Token: 0x0601C814 RID: 116756 RVA: 0x002A2720 File Offset: 0x002A0920
		public unsafe float Amplify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCDamageRelated.__PropertyOffset_Amplify);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCDamageRelated.__PropertyOffset_Amplify) = value;
			}
		}

		// Token: 0x170072D6 RID: 29398
		// (get) Token: 0x0601C815 RID: 116757 RVA: 0x002A2731 File Offset: 0x002A0931
		// (set) Token: 0x0601C816 RID: 116758 RVA: 0x002A2741 File Offset: 0x002A0941
		public unsafe EKSC_AttrType RelatedProperty
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)FKSCDamageRelated.__PropertyOffset_RelatedProperty));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCDamageRelated.__PropertyOffset_RelatedProperty) = (byte)value;
			}
		}

		// Token: 0x170072D7 RID: 29399
		// (get) Token: 0x0601C817 RID: 116759 RVA: 0x002A2752 File Offset: 0x002A0952
		// (set) Token: 0x0601C818 RID: 116760 RVA: 0x002A2762 File Offset: 0x002A0962
		public unsafe EKSC_AttrType MainDamageType
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)FKSCDamageRelated.__PropertyOffset_MainDamageType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCDamageRelated.__PropertyOffset_MainDamageType) = (byte)value;
			}
		}

		// Token: 0x170072D8 RID: 29400
		// (get) Token: 0x0601C819 RID: 116761 RVA: 0x002A2773 File Offset: 0x002A0973
		// (set) Token: 0x0601C81A RID: 116762 RVA: 0x002A2783 File Offset: 0x002A0983
		public unsafe EKSC_AttrType SubDamageType
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)FKSCDamageRelated.__PropertyOffset_SubDamageType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCDamageRelated.__PropertyOffset_SubDamageType) = (byte)value;
			}
		}

		// Token: 0x0601C81B RID: 116763 RVA: 0x002A2794 File Offset: 0x002A0994
		public FKSCDamageRelated()
		{
		}

		// Token: 0x0601C81C RID: 116764 RVA: 0x002A279C File Offset: 0x002A099C
		public FKSCDamageRelated(float Amplify, EKSC_AttrType RelatedProperty, EKSC_AttrType MainDamageType, EKSC_AttrType SubDamageType)
		{
			this.Amplify = Amplify;
			this.RelatedProperty = RelatedProperty;
			this.MainDamageType = MainDamageType;
			this.SubDamageType = SubDamageType;
		}

		// Token: 0x0601C81D RID: 116765 RVA: 0x002A27C1 File Offset: 0x002A09C1
		protected override IntPtr GetUStructPtr()
		{
			return FKSCDamageRelated.StaticStruct();
		}

		// Token: 0x0601C81E RID: 116766 RVA: 0x002A27CD File Offset: 0x002A09CD
		[NullableContext(2)]
		public FKSCDamageRelated(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C81F RID: 116767 RVA: 0x002A27D7 File Offset: 0x002A09D7
		public FKSCDamageRelated(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C820 RID: 116768 RVA: 0x002A27E2 File Offset: 0x002A09E2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSCDamageRelated(Pointer, false, true);
		}

		// Token: 0x0601C821 RID: 116769 RVA: 0x002A27EC File Offset: 0x002A09EC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSCDamageRelated(Pointer, MemoryOwner);
		}

		// Token: 0x0400F750 RID: 63312
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSCDamageRelated";

		// Token: 0x0400F751 RID: 63313
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F752 RID: 63314
		internal static int __PropertyOffset_Amplify;

		// Token: 0x0400F753 RID: 63315
		internal static int __PropertyOffset_RelatedProperty;

		// Token: 0x0400F754 RID: 63316
		internal static int __PropertyOffset_MainDamageType;

		// Token: 0x0400F755 RID: 63317
		internal static int __PropertyOffset_SubDamageType;
	}
}
