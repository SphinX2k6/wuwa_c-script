using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001733 RID: 5939
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/KuroBullet.KSC_SkillKuroBullet")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 16)]
	public struct FKSC_SkillKuroBullet : IEqualityOperators<FKSC_SkillKuroBullet, FKSC_SkillKuroBullet, bool>, IEquatable<FKSC_SkillKuroBullet>, IUnrealScriptStruct
	{
		// Token: 0x06015622 RID: 87586 RVA: 0x001F6AF4 File Offset: 0x001F4CF4
		public FKSC_SkillKuroBullet(float Time, long BulletId)
		{
			this.Time = Time;
			this.BulletId = BulletId;
		}

		// Token: 0x06015623 RID: 87587 RVA: 0x001F6B04 File Offset: 0x001F4D04
		public static bool operator ==(FKSC_SkillKuroBullet left, FKSC_SkillKuroBullet right)
		{
			return left.Time == right.Time && left.BulletId == right.BulletId;
		}

		// Token: 0x06015624 RID: 87588 RVA: 0x001F6B24 File Offset: 0x001F4D24
		public static bool operator !=(FKSC_SkillKuroBullet left, FKSC_SkillKuroBullet right)
		{
			return !(left == right);
		}

		// Token: 0x06015625 RID: 87589 RVA: 0x001F6B30 File Offset: 0x001F4D30
		public bool Equals(FKSC_SkillKuroBullet other)
		{
			return this == other;
		}

		// Token: 0x06015626 RID: 87590 RVA: 0x001F6B40 File Offset: 0x001F4D40
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FKSC_SkillKuroBullet)
			{
				FKSC_SkillKuroBullet other = (FKSC_SkillKuroBullet)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06015627 RID: 87591 RVA: 0x001F6B65 File Offset: 0x001F4D65
		public override int GetHashCode()
		{
			return HashCode.Combine<float, long>(this.Time, this.BulletId);
		}

		// Token: 0x06015628 RID: 87592 RVA: 0x001F6B78 File Offset: 0x001F4D78
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_SkillKuroBullet._ScriptStructPtr != 0) ? FKSC_SkillKuroBullet._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBullet.KSC_SkillKuroBullet", ref FKSC_SkillKuroBullet._ScriptStructPtr);
		}

		// Token: 0x0400BA92 RID: 47762
		[FieldOffset(0)]
		public float Time;

		// Token: 0x0400BA93 RID: 47763
		[FieldOffset(8)]
		public long BulletId;

		// Token: 0x0400BA94 RID: 47764
		public const string __ObjectPath = "/Script/KuroBullet.KSC_SkillKuroBullet";

		// Token: 0x0400BA95 RID: 47765
		private static IntPtr _ScriptStructPtr;
	}
}
