using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025BE RID: 9662
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/Niagara.NiagaraNumeric")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FNiagaraNumeric : IEqualityOperators<FNiagaraNumeric, FNiagaraNumeric, bool>, IEquatable<FNiagaraNumeric>, IUnrealScriptStruct
	{
		// Token: 0x06023EB5 RID: 147125 RVA: 0x00351F58 File Offset: 0x00350158
		public unsafe static bool operator ==(FNiagaraNumeric left, FNiagaraNumeric right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06023EB6 RID: 147126 RVA: 0x00351F84 File Offset: 0x00350184
		public static bool operator !=(FNiagaraNumeric left, FNiagaraNumeric right)
		{
			return !(left == right);
		}

		// Token: 0x06023EB7 RID: 147127 RVA: 0x00351F90 File Offset: 0x00350190
		public bool Equals(FNiagaraNumeric other)
		{
			return this == other;
		}

		// Token: 0x06023EB8 RID: 147128 RVA: 0x00351FA0 File Offset: 0x003501A0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FNiagaraNumeric)
			{
				FNiagaraNumeric other = (FNiagaraNumeric)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06023EB9 RID: 147129 RVA: 0x00351FC5 File Offset: 0x003501C5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraNumeric._ScriptStructPtr != 0) ? FNiagaraNumeric._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraNumeric", ref FNiagaraNumeric._ScriptStructPtr);
		}

		// Token: 0x04013433 RID: 78899
		public const string __ObjectPath = "/Script/Niagara.NiagaraNumeric";

		// Token: 0x04013434 RID: 78900
		private static IntPtr _ScriptStructPtr;
	}
}
