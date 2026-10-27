using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200014E RID: 334
	[UnrealObjectPath("/Script/AIModule.BTService")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public abstract class UBTService : UBTAuxiliaryNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600172A RID: 5930 RVA: 0x00022149 File Offset: 0x00020349
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTService._ClassPtr;
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x00022155 File Offset: 0x00020355
		// (set) Token: 0x0600172C RID: 5932 RVA: 0x00022165 File Offset: 0x00020365
		public unsafe float Interval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTService.__PropertyOffset_Interval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTService.__PropertyOffset_Interval) = value;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x00022176 File Offset: 0x00020376
		// (set) Token: 0x0600172E RID: 5934 RVA: 0x00022186 File Offset: 0x00020386
		public unsafe float RandomDeviation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTService.__PropertyOffset_RandomDeviation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTService.__PropertyOffset_RandomDeviation) = value;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x00022197 File Offset: 0x00020397
		// (set) Token: 0x06001730 RID: 5936 RVA: 0x000221B0 File Offset: 0x000203B0
		public unsafe bool bCallTickOnSearchStart
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTService.__PropertyOffset_bCallTickOnSearchStart) & UBTService.__PropertyMask_bCallTickOnSearchStart) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTService.__PropertyOffset_bCallTickOnSearchStart) = ((*(base.NativePtr + (IntPtr)UBTService.__PropertyOffset_bCallTickOnSearchStart) & ~UBTService.__PropertyMask_bCallTickOnSearchStart) | (value ? UBTService.__PropertyMask_bCallTickOnSearchStart : 0));
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001731 RID: 5937 RVA: 0x000221E0 File Offset: 0x000203E0
		// (set) Token: 0x06001732 RID: 5938 RVA: 0x000221F9 File Offset: 0x000203F9
		public unsafe bool bRestartTimerOnEachActivation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTService.__PropertyOffset_bRestartTimerOnEachActivation) & UBTService.__PropertyMask_bRestartTimerOnEachActivation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTService.__PropertyOffset_bRestartTimerOnEachActivation) = ((*(base.NativePtr + (IntPtr)UBTService.__PropertyOffset_bRestartTimerOnEachActivation) & ~UBTService.__PropertyMask_bRestartTimerOnEachActivation) | (value ? UBTService.__PropertyMask_bRestartTimerOnEachActivation : 0));
			}
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00022229 File Offset: 0x00020429
		static UBTService()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTService");
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x00022238 File Offset: 0x00020438
		protected UBTService() : this(BuiltinUtils.AllocNativeUObject(UBTService.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00022260 File Offset: 0x00020460
		protected UBTService(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400056A RID: 1386
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTService";

		// Token: 0x0400056B RID: 1387
		private static IntPtr _ClassPtr;

		// Token: 0x0400056C RID: 1388
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400056D RID: 1389
		internal static int __PropertyOffset_Interval;

		// Token: 0x0400056E RID: 1390
		internal static int __PropertyOffset_RandomDeviation;

		// Token: 0x0400056F RID: 1391
		internal static int __PropertyOffset_bCallTickOnSearchStart;

		// Token: 0x04000570 RID: 1392
		internal static byte __PropertyMask_bCallTickOnSearchStart;

		// Token: 0x04000571 RID: 1393
		internal static int __PropertyOffset_bRestartTimerOnEachActivation;

		// Token: 0x04000572 RID: 1394
		internal static byte __PropertyMask_bRestartTimerOnEachActivation;
	}
}
