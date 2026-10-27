using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000164 RID: 356
	[UnrealObjectPath("/Script/AIModule.BTTask_Wait")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UBTTask_Wait : UBTTaskNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600182E RID: 6190 RVA: 0x00023A39 File Offset: 0x00021C39
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_Wait._ClassPtr;
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x00023A48 File Offset: 0x00021C48
		public UBTTask_Wait() : this(BuiltinUtils.AllocNativeUObject(UBTTask_Wait.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00023A70 File Offset: 0x00021C70
		[NullableContext(1)]
		public UBTTask_Wait(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTTask_Wait.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x00023AA3 File Offset: 0x00021CA3
		// (set) Token: 0x06001832 RID: 6194 RVA: 0x00023AB3 File Offset: 0x00021CB3
		public unsafe float WaitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTTask_Wait.__PropertyOffset_WaitTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTTask_Wait.__PropertyOffset_WaitTime) = value;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x00023AC4 File Offset: 0x00021CC4
		// (set) Token: 0x06001834 RID: 6196 RVA: 0x00023AD4 File Offset: 0x00021CD4
		public unsafe float RandomDeviation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTTask_Wait.__PropertyOffset_RandomDeviation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTTask_Wait.__PropertyOffset_RandomDeviation) = value;
			}
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00023AE5 File Offset: 0x00021CE5
		static UBTTask_Wait()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_Wait");
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x00023AF3 File Offset: 0x00021CF3
		protected UBTTask_Wait(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000604 RID: 1540
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTTask_Wait";

		// Token: 0x04000605 RID: 1541
		private static IntPtr _ClassPtr;

		// Token: 0x04000606 RID: 1542
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000607 RID: 1543
		internal static int __PropertyOffset_WaitTime;

		// Token: 0x04000608 RID: 1544
		internal static int __PropertyOffset_RandomDeviation;
	}
}
