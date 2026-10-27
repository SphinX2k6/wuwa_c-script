using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000151 RID: 337
	[UnrealObjectPath("/Script/AIModule.BTService_DefaultFocus")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UBTService_DefaultFocus : UBTService_BlackboardBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600175A RID: 5978 RVA: 0x00022579 File Offset: 0x00020779
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTService_DefaultFocus._ClassPtr;
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x00022588 File Offset: 0x00020788
		public UBTService_DefaultFocus() : this(BuiltinUtils.AllocNativeUObject(UBTService_DefaultFocus.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x000225B0 File Offset: 0x000207B0
		[NullableContext(1)]
		public UBTService_DefaultFocus(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTService_DefaultFocus.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x000225E3 File Offset: 0x000207E3
		// (set) Token: 0x0600175E RID: 5982 RVA: 0x000225F3 File Offset: 0x000207F3
		public unsafe byte FocusPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTService_DefaultFocus.__PropertyOffset_FocusPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTService_DefaultFocus.__PropertyOffset_FocusPriority) = value;
			}
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x00022604 File Offset: 0x00020804
		static UBTService_DefaultFocus()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTService_DefaultFocus");
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x00022612 File Offset: 0x00020812
		protected UBTService_DefaultFocus(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000581 RID: 1409
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTService_DefaultFocus";

		// Token: 0x04000582 RID: 1410
		private static IntPtr _ClassPtr;

		// Token: 0x04000583 RID: 1411
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000584 RID: 1412
		internal static int __PropertyOffset_FocusPriority;
	}
}
