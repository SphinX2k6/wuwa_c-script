using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025D7 RID: 9687
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/Niagara.NiagaraRandInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FNiagaraRandInfo : IEqualityOperators<FNiagaraRandInfo, FNiagaraRandInfo, bool>, IEquatable<FNiagaraRandInfo>, IUnrealScriptStruct
	{
		// Token: 0x06023FED RID: 147437 RVA: 0x00353EF6 File Offset: 0x003520F6
		public FNiagaraRandInfo(int Seed1, int Seed2, int Seed3)
		{
			this.Seed1 = Seed1;
			this.Seed2 = Seed2;
			this.Seed3 = Seed3;
		}

		// Token: 0x06023FEE RID: 147438 RVA: 0x00353F0D File Offset: 0x0035210D
		public static bool operator ==(FNiagaraRandInfo left, FNiagaraRandInfo right)
		{
			return left.Seed1 == right.Seed1 && left.Seed2 == right.Seed2 && left.Seed3 == right.Seed3;
		}

		// Token: 0x06023FEF RID: 147439 RVA: 0x00353F3B File Offset: 0x0035213B
		public static bool operator !=(FNiagaraRandInfo left, FNiagaraRandInfo right)
		{
			return !(left == right);
		}

		// Token: 0x06023FF0 RID: 147440 RVA: 0x00353F47 File Offset: 0x00352147
		public bool Equals(FNiagaraRandInfo other)
		{
			return this == other;
		}

		// Token: 0x06023FF1 RID: 147441 RVA: 0x00353F58 File Offset: 0x00352158
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FNiagaraRandInfo)
			{
				FNiagaraRandInfo other = (FNiagaraRandInfo)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06023FF2 RID: 147442 RVA: 0x00353F7D File Offset: 0x0035217D
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int, int>(this.Seed1, this.Seed2, this.Seed3);
		}

		// Token: 0x06023FF3 RID: 147443 RVA: 0x00353F96 File Offset: 0x00352196
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraRandInfo._ScriptStructPtr != 0) ? FNiagaraRandInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraRandInfo", ref FNiagaraRandInfo._ScriptStructPtr);
		}

		// Token: 0x040134CC RID: 79052
		[FieldOffset(0)]
		public int Seed1;

		// Token: 0x040134CD RID: 79053
		[FieldOffset(4)]
		public int Seed2;

		// Token: 0x040134CE RID: 79054
		[FieldOffset(8)]
		public int Seed3;

		// Token: 0x040134CF RID: 79055
		public const string __ObjectPath = "/Script/Niagara.NiagaraRandInfo";

		// Token: 0x040134D0 RID: 79056
		private static IntPtr _ScriptStructPtr;
	}
}
