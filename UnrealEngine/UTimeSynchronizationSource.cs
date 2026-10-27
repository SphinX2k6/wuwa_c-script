using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002919 RID: 10521
	[UnrealObjectPath("/Script/TimeManagement.TimeSynchronizationSource")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UTimeSynchronizationSource : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026FD7 RID: 159703 RVA: 0x003B7511 File Offset: 0x003B5711
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTimeSynchronizationSource._ClassPtr;
		}

		// Token: 0x17009613 RID: 38419
		// (get) Token: 0x06026FD8 RID: 159704 RVA: 0x003B751D File Offset: 0x003B571D
		// (set) Token: 0x06026FD9 RID: 159705 RVA: 0x003B752D File Offset: 0x003B572D
		public unsafe bool bUseForSynchronization
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTimeSynchronizationSource.__PropertyOffset_bUseForSynchronization) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTimeSynchronizationSource.__PropertyOffset_bUseForSynchronization) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009614 RID: 38420
		// (get) Token: 0x06026FDA RID: 159706 RVA: 0x003B753E File Offset: 0x003B573E
		// (set) Token: 0x06026FDB RID: 159707 RVA: 0x003B754E File Offset: 0x003B574E
		public unsafe int FrameOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTimeSynchronizationSource.__PropertyOffset_FrameOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTimeSynchronizationSource.__PropertyOffset_FrameOffset) = value;
			}
		}

		// Token: 0x06026FDC RID: 159708 RVA: 0x003B755F File Offset: 0x003B575F
		static UTimeSynchronizationSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TimeManagement.TimeSynchronizationSource");
		}

		// Token: 0x06026FDD RID: 159709 RVA: 0x003B7570 File Offset: 0x003B5770
		protected UTimeSynchronizationSource() : this(BuiltinUtils.AllocNativeUObject(UTimeSynchronizationSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026FDE RID: 159710 RVA: 0x003B7598 File Offset: 0x003B5798
		protected UTimeSynchronizationSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015667 RID: 87655
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TimeManagement.TimeSynchronizationSource";

		// Token: 0x04015668 RID: 87656
		private static IntPtr _ClassPtr;

		// Token: 0x04015669 RID: 87657
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401566A RID: 87658
		internal static int __PropertyOffset_bUseForSynchronization;

		// Token: 0x0401566B RID: 87659
		internal static int __PropertyOffset_FrameOffset;
	}
}
