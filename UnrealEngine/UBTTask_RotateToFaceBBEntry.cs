using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200015F RID: 351
	[UnrealObjectPath("/Script/AIModule.BTTask_RotateToFaceBBEntry")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UBTTask_RotateToFaceBBEntry : UBTTask_BlackboardBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060017F7 RID: 6135 RVA: 0x000234D3 File Offset: 0x000216D3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_RotateToFaceBBEntry._ClassPtr;
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x000234E0 File Offset: 0x000216E0
		public UBTTask_RotateToFaceBBEntry() : this(BuiltinUtils.AllocNativeUObject(UBTTask_RotateToFaceBBEntry.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00023508 File Offset: 0x00021708
		[NullableContext(1)]
		public UBTTask_RotateToFaceBBEntry(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTTask_RotateToFaceBBEntry.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x0002353B File Offset: 0x0002173B
		// (set) Token: 0x060017FB RID: 6139 RVA: 0x0002354B File Offset: 0x0002174B
		public unsafe float Precision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTTask_RotateToFaceBBEntry.__PropertyOffset_Precision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTTask_RotateToFaceBBEntry.__PropertyOffset_Precision) = value;
			}
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x0002355C File Offset: 0x0002175C
		static UBTTask_RotateToFaceBBEntry()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_RotateToFaceBBEntry");
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x0002356A File Offset: 0x0002176A
		protected UBTTask_RotateToFaceBBEntry(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005E2 RID: 1506
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTTask_RotateToFaceBBEntry";

		// Token: 0x040005E3 RID: 1507
		private static IntPtr _ClassPtr;

		// Token: 0x040005E4 RID: 1508
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040005E5 RID: 1509
		internal static int __PropertyOffset_Precision;
	}
}
