using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D40 RID: 7488
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_BulletTargetContext")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKSC_BulletTargetContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601CAEB RID: 117483 RVA: 0x002A6726 File Offset: 0x002A4926
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_BulletTargetContext._ScriptStructPtr != 0) ? FKSC_BulletTargetContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_BulletTargetContext", ref FKSC_BulletTargetContext._ScriptStructPtr);
		}

		// Token: 0x1700735E RID: 29534
		// (get) Token: 0x0601CAEC RID: 117484 RVA: 0x002A674A File Offset: 0x002A494A
		// (set) Token: 0x0601CAED RID: 117485 RVA: 0x002A675A File Offset: 0x002A495A
		public unsafe int TargetEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_BulletTargetContext.__PropertyOffset_TargetEntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_BulletTargetContext.__PropertyOffset_TargetEntityId) = value;
			}
		}

		// Token: 0x1700735F RID: 29535
		// (get) Token: 0x0601CAEE RID: 117486 RVA: 0x002A676B File Offset: 0x002A496B
		// (set) Token: 0x0601CAEF RID: 117487 RVA: 0x002A677F File Offset: 0x002A497F
		[Nullable(2)]
		public unsafe UKSC_SkillComp SkillComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_SkillComp>(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_BulletTargetContext.__PropertyOffset_SkillComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_BulletTargetContext.__PropertyOffset_SkillComp, value);
			}
		}

		// Token: 0x17007360 RID: 29536
		// (get) Token: 0x0601CAF0 RID: 117488 RVA: 0x002A6794 File Offset: 0x002A4994
		// (set) Token: 0x0601CAF1 RID: 117489 RVA: 0x002A67A8 File Offset: 0x002A49A8
		public unsafe FTransform TargetTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_BulletTargetContext.__PropertyOffset_TargetTrans);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_BulletTargetContext.__PropertyOffset_TargetTrans) = value;
			}
		}

		// Token: 0x0601CAF2 RID: 117490 RVA: 0x002A67BD File Offset: 0x002A49BD
		public FKSC_BulletTargetContext()
		{
		}

		// Token: 0x0601CAF3 RID: 117491 RVA: 0x002A67C5 File Offset: 0x002A49C5
		[NullableContext(1)]
		public FKSC_BulletTargetContext(int TargetEntityId, UKSC_SkillComp SkillComp, FTransform TargetTrans)
		{
			this.TargetEntityId = TargetEntityId;
			this.SkillComp = SkillComp;
			this.TargetTrans = TargetTrans;
		}

		// Token: 0x0601CAF4 RID: 117492 RVA: 0x002A67E2 File Offset: 0x002A49E2
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_BulletTargetContext.StaticStruct();
		}

		// Token: 0x0601CAF5 RID: 117493 RVA: 0x002A67EE File Offset: 0x002A49EE
		[NullableContext(2)]
		public FKSC_BulletTargetContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601CAF6 RID: 117494 RVA: 0x002A67F8 File Offset: 0x002A49F8
		public FKSC_BulletTargetContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601CAF7 RID: 117495 RVA: 0x002A6803 File Offset: 0x002A4A03
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_BulletTargetContext(Pointer, false, true);
		}

		// Token: 0x0601CAF8 RID: 117496 RVA: 0x002A680D File Offset: 0x002A4A0D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_BulletTargetContext(Pointer, MemoryOwner);
		}

		// Token: 0x0400F8D1 RID: 63697
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_BulletTargetContext";

		// Token: 0x0400F8D2 RID: 63698
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F8D3 RID: 63699
		internal static int __PropertyOffset_TargetEntityId;

		// Token: 0x0400F8D4 RID: 63700
		internal static int __PropertyOffset_SkillComp;

		// Token: 0x0400F8D5 RID: 63701
		internal static int __PropertyOffset_TargetTrans;
	}
}
