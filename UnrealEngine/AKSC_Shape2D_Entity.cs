using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E34 RID: 7732
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_Entity")]
	[UnrealStructLayout(1472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1472)]
	public class AKSC_Shape2D_Entity : AKSC_Entity, IUnrealUObject, IUnrealObject, IKSC_ShapeCollisionInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601D764 RID: 120676 RVA: 0x002B826B File Offset: 0x002B646B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Shape2D_Entity._ClassPtr;
		}

		// Token: 0x0601D765 RID: 120677 RVA: 0x002B8277 File Offset: 0x002B6477
		int IKSC_ShapeCollisionInterface.InterfaceOffset()
		{
			return AKSC_Shape2D_Entity.__InterfaceOffset_IKSC_ShapeCollisionInterface;
		}

		// Token: 0x0601D766 RID: 120678 RVA: 0x002B8280 File Offset: 0x002B6480
		public AKSC_Shape2D_Entity() : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D767 RID: 120679 RVA: 0x002B82A8 File Offset: 0x002B64A8
		[NullableContext(1)]
		public AKSC_Shape2D_Entity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076BF RID: 30399
		// (get) Token: 0x0601D768 RID: 120680 RVA: 0x002B82DB File Offset: 0x002B64DB
		// (set) Token: 0x0601D769 RID: 120681 RVA: 0x002B82EF File Offset: 0x002B64EF
		public unsafe UKSC_Shape2D_World KscShapeWorld
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Shape2D_World>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Shape2D_Entity.__PropertyOffset_KscShapeWorld);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Shape2D_Entity.__PropertyOffset_KscShapeWorld, value);
			}
		}

		// Token: 0x170076C0 RID: 30400
		// (get) Token: 0x0601D76A RID: 120682 RVA: 0x002B8304 File Offset: 0x002B6504
		// (set) Token: 0x0601D76B RID: 120683 RVA: 0x002B8318 File Offset: 0x002B6518
		public unsafe UKSC_Shape2DComp ShapeComp_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Shape2DComp>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Shape2D_Entity.__PropertyOffset_ShapeComp_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Shape2D_Entity.__PropertyOffset_ShapeComp_, value);
			}
		}

		// Token: 0x170076C1 RID: 30401
		// (get) Token: 0x0601D76C RID: 120684 RVA: 0x002B832D File Offset: 0x002B652D
		// (set) Token: 0x0601D76D RID: 120685 RVA: 0x002B8341 File Offset: 0x002B6541
		public unsafe UKSC_Shape2DAnim AnimComp_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Shape2DAnim>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Shape2D_Entity.__PropertyOffset_AnimComp_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Shape2D_Entity.__PropertyOffset_AnimComp_, value);
			}
		}

		// Token: 0x170076C2 RID: 30402
		// (get) Token: 0x0601D76E RID: 120686 RVA: 0x002B8356 File Offset: 0x002B6556
		// (set) Token: 0x0601D76F RID: 120687 RVA: 0x002B836A File Offset: 0x002B656A
		public unsafe UKSC_Shape2DMove MoveComp_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Shape2DMove>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Shape2D_Entity.__PropertyOffset_MoveComp_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Shape2D_Entity.__PropertyOffset_MoveComp_, value);
			}
		}

		// Token: 0x0601D770 RID: 120688 RVA: 0x002B837F File Offset: 0x002B657F
		public void AssignSkillStateChange(in FOnShape2DSkillStateChange InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnShape2DSkillStateChange fonShape2DSkillStateChange = InDelegate;
			AKSC_Shape2D_Entity.__AssignSkillStateChange_Internal(nativePtr, (fonShape2DSkillStateChange != null) ? fonShape2DSkillStateChange.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601D771 RID: 120689
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignSkillStateChange_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0601D772 RID: 120690 RVA: 0x002B839B File Offset: 0x002B659B
		static AKSC_Shape2D_Entity()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2D_Entity");
		}

		// Token: 0x0601D773 RID: 120691 RVA: 0x002B83A9 File Offset: 0x002B65A9
		protected AKSC_Shape2D_Entity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF94 RID: 65428
		internal static int __InterfaceOffset_IKSC_ShapeCollisionInterface;

		// Token: 0x0400FF95 RID: 65429
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_Entity";

		// Token: 0x0400FF96 RID: 65430
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF97 RID: 65431
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF98 RID: 65432
		internal static int __PropertyOffset_KscShapeWorld;

		// Token: 0x0400FF99 RID: 65433
		internal static int __PropertyOffset_ShapeComp_;

		// Token: 0x0400FF9A RID: 65434
		internal static int __PropertyOffset_AnimComp_;

		// Token: 0x0400FF9B RID: 65435
		internal static int __PropertyOffset_MoveComp_;
	}
}
