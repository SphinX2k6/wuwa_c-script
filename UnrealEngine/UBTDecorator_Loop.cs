using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000147 RID: 327
	[UnrealObjectPath("/Script/AIModule.BTDecorator_Loop")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UBTDecorator_Loop : UBTDecorator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060016B3 RID: 5811 RVA: 0x00021797 File Offset: 0x0001F997
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_Loop._ClassPtr;
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x000217A4 File Offset: 0x0001F9A4
		public UBTDecorator_Loop() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_Loop.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x000217CC File Offset: 0x0001F9CC
		[NullableContext(1)]
		public UBTDecorator_Loop(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_Loop.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x000217FF File Offset: 0x0001F9FF
		// (set) Token: 0x060016B7 RID: 5815 RVA: 0x0002180F File Offset: 0x0001FA0F
		public unsafe int NumLoops
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_Loop.__PropertyOffset_NumLoops);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_Loop.__PropertyOffset_NumLoops) = value;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060016B8 RID: 5816 RVA: 0x00021820 File Offset: 0x0001FA20
		// (set) Token: 0x060016B9 RID: 5817 RVA: 0x00021830 File Offset: 0x0001FA30
		public unsafe bool bInfiniteLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_Loop.__PropertyOffset_bInfiniteLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_Loop.__PropertyOffset_bInfiniteLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x00021841 File Offset: 0x0001FA41
		// (set) Token: 0x060016BB RID: 5819 RVA: 0x00021851 File Offset: 0x0001FA51
		public unsafe float InfiniteLoopTimeoutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_Loop.__PropertyOffset_InfiniteLoopTimeoutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_Loop.__PropertyOffset_InfiniteLoopTimeoutTime) = value;
			}
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00021862 File Offset: 0x0001FA62
		static UBTDecorator_Loop()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator_Loop");
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00021870 File Offset: 0x0001FA70
		protected UBTDecorator_Loop(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000545 RID: 1349
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator_Loop";

		// Token: 0x04000546 RID: 1350
		private static IntPtr _ClassPtr;

		// Token: 0x04000547 RID: 1351
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000548 RID: 1352
		internal static int __PropertyOffset_NumLoops;

		// Token: 0x04000549 RID: 1353
		internal static int __PropertyOffset_bInfiniteLoop;

		// Token: 0x0400054A RID: 1354
		internal static int __PropertyOffset_InfiniteLoopTimeoutTime;
	}
}
