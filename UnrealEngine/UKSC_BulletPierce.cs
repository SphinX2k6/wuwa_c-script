using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D3F RID: 7487
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_BulletPierce")]
	[UnrealStructLayout(336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UKSC_BulletPierce : UKSC_Bullet, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CAE4 RID: 117476 RVA: 0x002A665D File Offset: 0x002A485D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_BulletPierce._ClassPtr;
		}

		// Token: 0x0601CAE5 RID: 117477 RVA: 0x002A666C File Offset: 0x002A486C
		public UKSC_BulletPierce() : this(BuiltinUtils.AllocNativeUObject(UKSC_BulletPierce.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CAE6 RID: 117478 RVA: 0x002A6694 File Offset: 0x002A4894
		public UKSC_BulletPierce(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_BulletPierce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700735D RID: 29533
		// (get) Token: 0x0601CAE7 RID: 117479 RVA: 0x002A66C8 File Offset: 0x002A48C8
		// (set) Token: 0x0601CAE8 RID: 117480 RVA: 0x002A6701 File Offset: 0x002A4901
		public TArray<UKSC_SkillComp> Targets_
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_SkillComp> result;
				if ((result = this._Targets_) == null)
				{
					result = (this._Targets_ = new TArray<UKSC_SkillComp>(base.NativePtr + (IntPtr)UKSC_BulletPierce.__PropertyOffset_Targets_, this));
				}
				return result;
			}
			set
			{
				this.Targets_.CopyAssign(value);
			}
		}

		// Token: 0x0601CAE9 RID: 117481 RVA: 0x002A670F File Offset: 0x002A490F
		static UKSC_BulletPierce()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_BulletPierce");
		}

		// Token: 0x0601CAEA RID: 117482 RVA: 0x002A671D File Offset: 0x002A491D
		protected UKSC_BulletPierce(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8CB RID: 63691
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_BulletPierce";

		// Token: 0x0400F8CC RID: 63692
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8CD RID: 63693
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F8CE RID: 63694
		public static IntPtr __OnBulletHits__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F8CF RID: 63695
		internal static int __PropertyOffset_Targets_;

		// Token: 0x0400F8D0 RID: 63696
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_SkillComp> _Targets_;
	}
}
