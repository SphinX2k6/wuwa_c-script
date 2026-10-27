using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025F8 RID: 9720
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/Niagara.NiagaraSystemSpawnScaleSettings")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FNiagaraSystemSpawnScaleSettings : IEqualityOperators<FNiagaraSystemSpawnScaleSettings, FNiagaraSystemSpawnScaleSettings, bool>, IEquatable<FNiagaraSystemSpawnScaleSettings>, IUnrealScriptStruct
	{
		// Token: 0x0602427D RID: 148093 RVA: 0x00358448 File Offset: 0x00356648
		public FNiagaraSystemSpawnScaleSettings(float Distance, float SpawnScale)
		{
			this.Distance = Distance;
			this.SpawnScale = SpawnScale;
		}

		// Token: 0x0602427E RID: 148094 RVA: 0x00358458 File Offset: 0x00356658
		public static bool operator ==(FNiagaraSystemSpawnScaleSettings left, FNiagaraSystemSpawnScaleSettings right)
		{
			return left.Distance == right.Distance && left.SpawnScale == right.SpawnScale;
		}

		// Token: 0x0602427F RID: 148095 RVA: 0x00358478 File Offset: 0x00356678
		public static bool operator !=(FNiagaraSystemSpawnScaleSettings left, FNiagaraSystemSpawnScaleSettings right)
		{
			return !(left == right);
		}

		// Token: 0x06024280 RID: 148096 RVA: 0x00358484 File Offset: 0x00356684
		public bool Equals(FNiagaraSystemSpawnScaleSettings other)
		{
			return this == other;
		}

		// Token: 0x06024281 RID: 148097 RVA: 0x00358494 File Offset: 0x00356694
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FNiagaraSystemSpawnScaleSettings)
			{
				FNiagaraSystemSpawnScaleSettings other = (FNiagaraSystemSpawnScaleSettings)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06024282 RID: 148098 RVA: 0x003584B9 File Offset: 0x003566B9
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float>(this.Distance, this.SpawnScale);
		}

		// Token: 0x06024283 RID: 148099 RVA: 0x003584CC File Offset: 0x003566CC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraSystemSpawnScaleSettings._ScriptStructPtr != 0) ? FNiagaraSystemSpawnScaleSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraSystemSpawnScaleSettings", ref FNiagaraSystemSpawnScaleSettings._ScriptStructPtr);
		}

		// Token: 0x04013666 RID: 79462
		[FieldOffset(0)]
		public float Distance;

		// Token: 0x04013667 RID: 79463
		[FieldOffset(4)]
		public float SpawnScale;

		// Token: 0x04013668 RID: 79464
		public const string __ObjectPath = "/Script/Niagara.NiagaraSystemSpawnScaleSettings";

		// Token: 0x04013669 RID: 79465
		private static IntPtr _ScriptStructPtr;
	}
}
