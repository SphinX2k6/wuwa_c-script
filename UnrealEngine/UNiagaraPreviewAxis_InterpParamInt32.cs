using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025D0 RID: 9680
	[UnrealObjectPath("/Script/Niagara.NiagaraPreviewAxis_InterpParamInt32")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UNiagaraPreviewAxis_InterpParamInt32 : UNiagaraPreviewAxis_InterpParamBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023F9D RID: 147357 RVA: 0x003536AC File Offset: 0x003518AC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraPreviewAxis_InterpParamInt32._ClassPtr;
		}

		// Token: 0x06023F9E RID: 147358 RVA: 0x003536B8 File Offset: 0x003518B8
		public UNiagaraPreviewAxis_InterpParamInt32() : this(BuiltinUtils.AllocNativeUObject(UNiagaraPreviewAxis_InterpParamInt32.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023F9F RID: 147359 RVA: 0x003536E0 File Offset: 0x003518E0
		[NullableContext(1)]
		public UNiagaraPreviewAxis_InterpParamInt32(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraPreviewAxis_InterpParamInt32.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008A56 RID: 35414
		// (get) Token: 0x06023FA0 RID: 147360 RVA: 0x00353713 File Offset: 0x00351913
		// (set) Token: 0x06023FA1 RID: 147361 RVA: 0x00353723 File Offset: 0x00351923
		public unsafe int Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamInt32.__PropertyOffset_Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamInt32.__PropertyOffset_Min) = value;
			}
		}

		// Token: 0x17008A57 RID: 35415
		// (get) Token: 0x06023FA2 RID: 147362 RVA: 0x00353734 File Offset: 0x00351934
		// (set) Token: 0x06023FA3 RID: 147363 RVA: 0x00353744 File Offset: 0x00351944
		public unsafe int Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamInt32.__PropertyOffset_Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamInt32.__PropertyOffset_Max) = value;
			}
		}

		// Token: 0x06023FA4 RID: 147364 RVA: 0x00353755 File Offset: 0x00351955
		static UNiagaraPreviewAxis_InterpParamInt32()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraPreviewAxis_InterpParamInt32");
		}

		// Token: 0x06023FA5 RID: 147365 RVA: 0x00353763 File Offset: 0x00351963
		protected UNiagaraPreviewAxis_InterpParamInt32(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401349C RID: 79004
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraPreviewAxis_InterpParamInt32";

		// Token: 0x0401349D RID: 79005
		private static IntPtr _ClassPtr;

		// Token: 0x0401349E RID: 79006
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401349F RID: 79007
		internal static int __PropertyOffset_Min;

		// Token: 0x040134A0 RID: 79008
		internal static int __PropertyOffset_Max;
	}
}
