using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001731 RID: 5937
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBullet.KSC_DA_Skill_PTT_KuroBullet")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UKSC_DA_Skill_PTT_KuroBullet : UKSC_DA_Skill_Anim, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060155F1 RID: 87537 RVA: 0x001F66FB File Offset: 0x001F48FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_PTT_KuroBullet._ClassPtr;
		}

		// Token: 0x060155F2 RID: 87538 RVA: 0x001F6708 File Offset: 0x001F4908
		public UKSC_DA_Skill_PTT_KuroBullet() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_PTT_KuroBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060155F3 RID: 87539 RVA: 0x001F6730 File Offset: 0x001F4930
		public UKSC_DA_Skill_PTT_KuroBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_PTT_KuroBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700546C RID: 21612
		// (get) Token: 0x060155F4 RID: 87540 RVA: 0x001F6764 File Offset: 0x001F4964
		// (set) Token: 0x060155F5 RID: 87541 RVA: 0x001F679D File Offset: 0x001F499D
		public TArray<FKSC_KuroBulletGroupElement> Bullets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKSC_KuroBulletGroupElement> result;
				if ((result = this._Bullets) == null)
				{
					result = (this._Bullets = new TArray<FKSC_KuroBulletGroupElement>(base.NativePtr + (IntPtr)UKSC_DA_Skill_PTT_KuroBullet.__PropertyOffset_Bullets, this));
				}
				return result;
			}
			set
			{
				this.Bullets.CopyAssign(value);
			}
		}

		// Token: 0x1700546D RID: 21613
		// (get) Token: 0x060155F6 RID: 87542 RVA: 0x001F67AB File Offset: 0x001F49AB
		// (set) Token: 0x060155F7 RID: 87543 RVA: 0x001F67BB File Offset: 0x001F49BB
		public unsafe float GroupInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_PTT_KuroBullet.__PropertyOffset_GroupInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_PTT_KuroBullet.__PropertyOffset_GroupInterval) = value;
			}
		}

		// Token: 0x1700546E RID: 21614
		// (get) Token: 0x060155F8 RID: 87544 RVA: 0x001F67CC File Offset: 0x001F49CC
		// (set) Token: 0x060155F9 RID: 87545 RVA: 0x001F67DC File Offset: 0x001F49DC
		public unsafe bool AffectByAttackSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_PTT_KuroBullet.__PropertyOffset_AffectByAttackSpeed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_PTT_KuroBullet.__PropertyOffset_AffectByAttackSpeed) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700546F RID: 21615
		// (get) Token: 0x060155FA RID: 87546 RVA: 0x001F67ED File Offset: 0x001F49ED
		// (set) Token: 0x060155FB RID: 87547 RVA: 0x001F67FD File Offset: 0x001F49FD
		public unsafe float CastRangeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_PTT_KuroBullet.__PropertyOffset_CastRangeMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_PTT_KuroBullet.__PropertyOffset_CastRangeMin) = value;
			}
		}

		// Token: 0x17005470 RID: 21616
		// (get) Token: 0x060155FC RID: 87548 RVA: 0x001F6810 File Offset: 0x001F4A10
		// (set) Token: 0x060155FD RID: 87549 RVA: 0x001F6849 File Offset: 0x001F4A49
		public TArray<long> AddBuffsToSelf
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._AddBuffsToSelf) == null)
				{
					result = (this._AddBuffsToSelf = new TArray<long>(base.NativePtr + (IntPtr)UKSC_DA_Skill_PTT_KuroBullet.__PropertyOffset_AddBuffsToSelf, this));
				}
				return result;
			}
			set
			{
				this.AddBuffsToSelf.CopyAssign(value);
			}
		}

		// Token: 0x060155FE RID: 87550 RVA: 0x001F6857 File Offset: 0x001F4A57
		static UKSC_DA_Skill_PTT_KuroBullet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.KSC_DA_Skill_PTT_KuroBullet");
		}

		// Token: 0x060155FF RID: 87551 RVA: 0x001F6865 File Offset: 0x001F4A65
		protected UKSC_DA_Skill_PTT_KuroBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BA79 RID: 47737
		public new const string __ObjectPath = "/Script/KuroBullet.KSC_DA_Skill_PTT_KuroBullet";

		// Token: 0x0400BA7A RID: 47738
		private static IntPtr _ClassPtr;

		// Token: 0x0400BA7B RID: 47739
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BA7C RID: 47740
		internal static int __PropertyOffset_Bullets;

		// Token: 0x0400BA7D RID: 47741
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSC_KuroBulletGroupElement> _Bullets;

		// Token: 0x0400BA7E RID: 47742
		internal static int __PropertyOffset_GroupInterval;

		// Token: 0x0400BA7F RID: 47743
		internal static int __PropertyOffset_AffectByAttackSpeed;

		// Token: 0x0400BA80 RID: 47744
		internal static int __PropertyOffset_CastRangeMin;

		// Token: 0x0400BA81 RID: 47745
		internal static int __PropertyOffset_AddBuffsToSelf;

		// Token: 0x0400BA82 RID: 47746
		[Nullable(2)]
		private TArray<long> _AddBuffsToSelf;
	}
}
