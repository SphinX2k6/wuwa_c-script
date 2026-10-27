using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025D3 RID: 9683
	[UnrealObjectPath("/Script/Niagara.NiagaraPreviewAxis_InterpParamVector2D")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UNiagaraPreviewAxis_InterpParamVector2D : UNiagaraPreviewAxis_InterpParamBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023FB8 RID: 147384 RVA: 0x0035390C File Offset: 0x00351B0C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraPreviewAxis_InterpParamVector2D._ClassPtr;
		}

		// Token: 0x06023FB9 RID: 147385 RVA: 0x00353918 File Offset: 0x00351B18
		public UNiagaraPreviewAxis_InterpParamVector2D() : this(BuiltinUtils.AllocNativeUObject(UNiagaraPreviewAxis_InterpParamVector2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023FBA RID: 147386 RVA: 0x00353940 File Offset: 0x00351B40
		[NullableContext(1)]
		public UNiagaraPreviewAxis_InterpParamVector2D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraPreviewAxis_InterpParamVector2D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008A5C RID: 35420
		// (get) Token: 0x06023FBB RID: 147387 RVA: 0x00353973 File Offset: 0x00351B73
		// (set) Token: 0x06023FBC RID: 147388 RVA: 0x00353987 File Offset: 0x00351B87
		public unsafe FVector2D Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamVector2D.__PropertyOffset_Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamVector2D.__PropertyOffset_Min) = value;
			}
		}

		// Token: 0x17008A5D RID: 35421
		// (get) Token: 0x06023FBD RID: 147389 RVA: 0x0035399C File Offset: 0x00351B9C
		// (set) Token: 0x06023FBE RID: 147390 RVA: 0x003539B0 File Offset: 0x00351BB0
		public unsafe FVector2D Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamVector2D.__PropertyOffset_Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamVector2D.__PropertyOffset_Max) = value;
			}
		}

		// Token: 0x06023FBF RID: 147391 RVA: 0x003539C5 File Offset: 0x00351BC5
		static UNiagaraPreviewAxis_InterpParamVector2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraPreviewAxis_InterpParamVector2D");
		}

		// Token: 0x06023FC0 RID: 147392 RVA: 0x003539D3 File Offset: 0x00351BD3
		protected UNiagaraPreviewAxis_InterpParamVector2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040134AB RID: 79019
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraPreviewAxis_InterpParamVector2D";

		// Token: 0x040134AC RID: 79020
		private static IntPtr _ClassPtr;

		// Token: 0x040134AD RID: 79021
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040134AE RID: 79022
		internal static int __PropertyOffset_Min;

		// Token: 0x040134AF RID: 79023
		internal static int __PropertyOffset_Max;
	}
}
