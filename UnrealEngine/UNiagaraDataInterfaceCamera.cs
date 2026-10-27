using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200256B RID: 9579
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceCamera")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UNiagaraDataInterfaceCamera : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602391D RID: 145693 RVA: 0x003493EB File Offset: 0x003475EB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceCamera._ClassPtr;
		}

		// Token: 0x0602391E RID: 145694 RVA: 0x003493F8 File Offset: 0x003475F8
		public UNiagaraDataInterfaceCamera() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceCamera.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602391F RID: 145695 RVA: 0x00349420 File Offset: 0x00347620
		[NullableContext(1)]
		public UNiagaraDataInterfaceCamera(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceCamera.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700887B RID: 34939
		// (get) Token: 0x06023920 RID: 145696 RVA: 0x00349453 File Offset: 0x00347653
		// (set) Token: 0x06023921 RID: 145697 RVA: 0x00349463 File Offset: 0x00347663
		public unsafe int PlayerControllerIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCamera.__PropertyOffset_PlayerControllerIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCamera.__PropertyOffset_PlayerControllerIndex) = value;
			}
		}

		// Token: 0x1700887C RID: 34940
		// (get) Token: 0x06023922 RID: 145698 RVA: 0x00349474 File Offset: 0x00347674
		// (set) Token: 0x06023923 RID: 145699 RVA: 0x00349484 File Offset: 0x00347684
		public unsafe bool bRequireCurrentFrameData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCamera.__PropertyOffset_bRequireCurrentFrameData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCamera.__PropertyOffset_bRequireCurrentFrameData) = (value ? 1 : 0);
			}
		}

		// Token: 0x06023924 RID: 145700 RVA: 0x00349495 File Offset: 0x00347695
		static UNiagaraDataInterfaceCamera()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceCamera");
		}

		// Token: 0x06023925 RID: 145701 RVA: 0x003494A3 File Offset: 0x003476A3
		protected UNiagaraDataInterfaceCamera(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401310C RID: 78092
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceCamera";

		// Token: 0x0401310D RID: 78093
		private static IntPtr _ClassPtr;

		// Token: 0x0401310E RID: 78094
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401310F RID: 78095
		internal static int __PropertyOffset_PlayerControllerIndex;

		// Token: 0x04013110 RID: 78096
		internal static int __PropertyOffset_bRequireCurrentFrameData;
	}
}
