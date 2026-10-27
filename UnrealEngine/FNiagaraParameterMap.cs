using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025C3 RID: 9667
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/Niagara.NiagaraParameterMap")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FNiagaraParameterMap : IEqualityOperators<FNiagaraParameterMap, FNiagaraParameterMap, bool>, IEquatable<FNiagaraParameterMap>, IUnrealScriptStruct
	{
		// Token: 0x06023F07 RID: 147207 RVA: 0x0035275C File Offset: 0x0035095C
		public unsafe static bool operator ==(FNiagaraParameterMap left, FNiagaraParameterMap right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06023F08 RID: 147208 RVA: 0x00352788 File Offset: 0x00350988
		public static bool operator !=(FNiagaraParameterMap left, FNiagaraParameterMap right)
		{
			return !(left == right);
		}

		// Token: 0x06023F09 RID: 147209 RVA: 0x00352794 File Offset: 0x00350994
		public bool Equals(FNiagaraParameterMap other)
		{
			return this == other;
		}

		// Token: 0x06023F0A RID: 147210 RVA: 0x003527A4 File Offset: 0x003509A4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FNiagaraParameterMap)
			{
				FNiagaraParameterMap other = (FNiagaraParameterMap)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06023F0B RID: 147211 RVA: 0x003527C9 File Offset: 0x003509C9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraParameterMap._ScriptStructPtr != 0) ? FNiagaraParameterMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraParameterMap", ref FNiagaraParameterMap._ScriptStructPtr);
		}

		// Token: 0x04013450 RID: 78928
		public const string __ObjectPath = "/Script/Niagara.NiagaraParameterMap";

		// Token: 0x04013451 RID: 78929
		private static IntPtr _ScriptStructPtr;
	}
}
