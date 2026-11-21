using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000B4 RID: 180
	[UnrealObjectPath("/Script/AIModule.BTService")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public abstract class UBTService : UBTAuxiliaryNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000D8D RID: 3469 RVA: 0x00015645 File Offset: 0x00013845
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTService._ClassPtr;
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x00015651 File Offset: 0x00013851
		// (set) Token: 0x06000D8F RID: 3471 RVA: 0x00015661 File Offset: 0x00013861
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

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x00015672 File Offset: 0x00013872
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x00015682 File Offset: 0x00013882
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

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x00015693 File Offset: 0x00013893
		// (set) Token: 0x06000D93 RID: 3475 RVA: 0x000156AC File Offset: 0x000138AC
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

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x000156DC File Offset: 0x000138DC
		// (set) Token: 0x06000D95 RID: 3477 RVA: 0x000156F5 File Offset: 0x000138F5
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

		// Token: 0x06000D96 RID: 3478 RVA: 0x00015725 File Offset: 0x00013925
		static UBTService()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTService");
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00015734 File Offset: 0x00013934
		protected UBTService() : this(BuiltinUtils.AllocNativeUObject(UBTService.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x0001575C File Offset: 0x0001395C
		protected UBTService(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000274 RID: 628
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTService";

		// Token: 0x04000275 RID: 629
		private static IntPtr _ClassPtr;

		// Token: 0x04000276 RID: 630
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000277 RID: 631
		internal static int __PropertyOffset_Interval;

		// Token: 0x04000278 RID: 632
		internal static int __PropertyOffset_RandomDeviation;

		// Token: 0x04000279 RID: 633
		internal static int __PropertyOffset_bCallTickOnSearchStart;

		// Token: 0x0400027A RID: 634
		internal static byte __PropertyMask_bCallTickOnSearchStart;

		// Token: 0x0400027B RID: 635
		internal static int __PropertyOffset_bRestartTimerOnEachActivation;

		// Token: 0x0400027C RID: 636
		internal static byte __PropertyMask_bRestartTimerOnEachActivation;
	}
}
