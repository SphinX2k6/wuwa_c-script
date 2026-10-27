using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D3E RID: 7486
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Bullet")]
	[UnrealStructLayout(288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UKSC_Bullet : UKSC_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CAD7 RID: 117463 RVA: 0x002A6506 File Offset: 0x002A4706
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Bullet._ClassPtr;
		}

		// Token: 0x0601CAD8 RID: 117464 RVA: 0x002A6514 File Offset: 0x002A4714
		public UKSC_Bullet() : this(BuiltinUtils.AllocNativeUObject(UKSC_Bullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CAD9 RID: 117465 RVA: 0x002A653C File Offset: 0x002A473C
		[NullableContext(1)]
		public UKSC_Bullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Bullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007359 RID: 29529
		// (get) Token: 0x0601CADA RID: 117466 RVA: 0x002A656F File Offset: 0x002A476F
		// (set) Token: 0x0601CADB RID: 117467 RVA: 0x002A6583 File Offset: 0x002A4783
		public unsafe UKSC_SkillComp Owner_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_SkillComp>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Bullet.__PropertyOffset_Owner_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Bullet.__PropertyOffset_Owner_, value);
			}
		}

		// Token: 0x1700735A RID: 29530
		// (get) Token: 0x0601CADC RID: 117468 RVA: 0x002A6598 File Offset: 0x002A4798
		// (set) Token: 0x0601CADD RID: 117469 RVA: 0x002A65AC File Offset: 0x002A47AC
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Bullet.__PropertyOffset_Niagara);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Bullet.__PropertyOffset_Niagara, value);
			}
		}

		// Token: 0x1700735B RID: 29531
		// (get) Token: 0x0601CADE RID: 117470 RVA: 0x002A65C1 File Offset: 0x002A47C1
		// (set) Token: 0x0601CADF RID: 117471 RVA: 0x002A65D5 File Offset: 0x002A47D5
		public unsafe UKSC_SkillComp TargetEntity
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_SkillComp>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Bullet.__PropertyOffset_TargetEntity);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Bullet.__PropertyOffset_TargetEntity, value);
			}
		}

		// Token: 0x1700735C RID: 29532
		// (get) Token: 0x0601CAE0 RID: 117472 RVA: 0x002A65EC File Offset: 0x002A47EC
		// (set) Token: 0x0601CAE1 RID: 117473 RVA: 0x002A6625 File Offset: 0x002A4825
		[Nullable(1)]
		public FKSC_BulletTargetContext TargetContext
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKSC_BulletTargetContext result;
				if ((result = this._TargetContext) == null)
				{
					result = (this._TargetContext = new FKSC_BulletTargetContext(base.NativePtr + (IntPtr)UKSC_Bullet.__PropertyOffset_TargetContext, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_BulletTargetContext.StaticStruct(), base.NativePtr + (IntPtr)UKSC_Bullet.__PropertyOffset_TargetContext, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601CAE2 RID: 117474 RVA: 0x002A6646 File Offset: 0x002A4846
		static UKSC_Bullet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Bullet");
		}

		// Token: 0x0601CAE3 RID: 117475 RVA: 0x002A6654 File Offset: 0x002A4854
		protected UKSC_Bullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8C2 RID: 63682
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Bullet";

		// Token: 0x0400F8C3 RID: 63683
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8C4 RID: 63684
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F8C5 RID: 63685
		public static IntPtr __OnBulletHit__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F8C6 RID: 63686
		internal static int __PropertyOffset_Owner_;

		// Token: 0x0400F8C7 RID: 63687
		internal static int __PropertyOffset_Niagara;

		// Token: 0x0400F8C8 RID: 63688
		internal static int __PropertyOffset_TargetEntity;

		// Token: 0x0400F8C9 RID: 63689
		internal static int __PropertyOffset_TargetContext;

		// Token: 0x0400F8CA RID: 63690
		private FKSC_BulletTargetContext _TargetContext;
	}
}
