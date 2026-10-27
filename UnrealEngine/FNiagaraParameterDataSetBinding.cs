using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025C1 RID: 9665
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/Niagara.NiagaraParameterDataSetBinding")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FNiagaraParameterDataSetBinding : IEqualityOperators<FNiagaraParameterDataSetBinding, FNiagaraParameterDataSetBinding, bool>, IEquatable<FNiagaraParameterDataSetBinding>, IUnrealScriptStruct
	{
		// Token: 0x06023EF4 RID: 147188 RVA: 0x00352599 File Offset: 0x00350799
		public FNiagaraParameterDataSetBinding(int ParameterOffset, int DataSetComponentOffset)
		{
			this.ParameterOffset = ParameterOffset;
			this.DataSetComponentOffset = DataSetComponentOffset;
		}

		// Token: 0x06023EF5 RID: 147189 RVA: 0x003525A9 File Offset: 0x003507A9
		public static bool operator ==(FNiagaraParameterDataSetBinding left, FNiagaraParameterDataSetBinding right)
		{
			return left.ParameterOffset == right.ParameterOffset && left.DataSetComponentOffset == right.DataSetComponentOffset;
		}

		// Token: 0x06023EF6 RID: 147190 RVA: 0x003525C9 File Offset: 0x003507C9
		public static bool operator !=(FNiagaraParameterDataSetBinding left, FNiagaraParameterDataSetBinding right)
		{
			return !(left == right);
		}

		// Token: 0x06023EF7 RID: 147191 RVA: 0x003525D5 File Offset: 0x003507D5
		public bool Equals(FNiagaraParameterDataSetBinding other)
		{
			return this == other;
		}

		// Token: 0x06023EF8 RID: 147192 RVA: 0x003525E4 File Offset: 0x003507E4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FNiagaraParameterDataSetBinding)
			{
				FNiagaraParameterDataSetBinding other = (FNiagaraParameterDataSetBinding)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06023EF9 RID: 147193 RVA: 0x00352609 File Offset: 0x00350809
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.ParameterOffset, this.DataSetComponentOffset);
		}

		// Token: 0x06023EFA RID: 147194 RVA: 0x0035261C File Offset: 0x0035081C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraParameterDataSetBinding._ScriptStructPtr != 0) ? FNiagaraParameterDataSetBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraParameterDataSetBinding", ref FNiagaraParameterDataSetBinding._ScriptStructPtr);
		}

		// Token: 0x04013446 RID: 78918
		[FieldOffset(0)]
		public int ParameterOffset;

		// Token: 0x04013447 RID: 78919
		[FieldOffset(4)]
		public int DataSetComponentOffset;

		// Token: 0x04013448 RID: 78920
		public const string __ObjectPath = "/Script/Niagara.NiagaraParameterDataSetBinding";

		// Token: 0x04013449 RID: 78921
		private static IntPtr _ScriptStructPtr;
	}
}
