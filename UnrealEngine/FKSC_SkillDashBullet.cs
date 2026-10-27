using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001E40 RID: 7744
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_SkillDashBullet")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 16)]
	public struct FKSC_SkillDashBullet : IEqualityOperators<FKSC_SkillDashBullet, FKSC_SkillDashBullet, bool>, IEquatable<FKSC_SkillDashBullet>, IUnrealScriptStruct
	{
		// Token: 0x0601D83A RID: 120890 RVA: 0x002B94A1 File Offset: 0x002B76A1
		public FKSC_SkillDashBullet(float Time, long BulletId)
		{
			this.Time = Time;
			this.BulletId = BulletId;
		}

		// Token: 0x0601D83B RID: 120891 RVA: 0x002B94B1 File Offset: 0x002B76B1
		public static bool operator ==(FKSC_SkillDashBullet left, FKSC_SkillDashBullet right)
		{
			return left.Time == right.Time && left.BulletId == right.BulletId;
		}

		// Token: 0x0601D83C RID: 120892 RVA: 0x002B94D1 File Offset: 0x002B76D1
		public static bool operator !=(FKSC_SkillDashBullet left, FKSC_SkillDashBullet right)
		{
			return !(left == right);
		}

		// Token: 0x0601D83D RID: 120893 RVA: 0x002B94DD File Offset: 0x002B76DD
		public bool Equals(FKSC_SkillDashBullet other)
		{
			return this == other;
		}

		// Token: 0x0601D83E RID: 120894 RVA: 0x002B94EC File Offset: 0x002B76EC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FKSC_SkillDashBullet)
			{
				FKSC_SkillDashBullet other = (FKSC_SkillDashBullet)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601D83F RID: 120895 RVA: 0x002B9511 File Offset: 0x002B7711
		public override int GetHashCode()
		{
			return HashCode.Combine<float, long>(this.Time, this.BulletId);
		}

		// Token: 0x0601D840 RID: 120896 RVA: 0x002B9524 File Offset: 0x002B7724
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_SkillDashBullet._ScriptStructPtr != 0) ? FKSC_SkillDashBullet._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_SkillDashBullet", ref FKSC_SkillDashBullet._ScriptStructPtr);
		}

		// Token: 0x0400FFFF RID: 65535
		[FieldOffset(0)]
		public float Time;

		// Token: 0x04010000 RID: 65536
		[FieldOffset(8)]
		public long BulletId;

		// Token: 0x04010001 RID: 65537
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_SkillDashBullet";

		// Token: 0x04010002 RID: 65538
		private static IntPtr _ScriptStructPtr;
	}
}
