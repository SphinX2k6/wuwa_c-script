using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000145 RID: 325
	[UnrealObjectPath("/Script/AIModule.BTDecorator_IsBBEntryOfClass")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UBTDecorator_IsBBEntryOfClass : UBTDecorator_BlackboardBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600169D RID: 5789 RVA: 0x00021505 File Offset: 0x0001F705
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_IsBBEntryOfClass._ClassPtr;
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00021514 File Offset: 0x0001F714
		public UBTDecorator_IsBBEntryOfClass() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_IsBBEntryOfClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x0002153C File Offset: 0x0001F73C
		[NullableContext(1)]
		public UBTDecorator_IsBBEntryOfClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_IsBBEntryOfClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x0002156F File Offset: 0x0001F76F
		// (set) Token: 0x060016A1 RID: 5793 RVA: 0x00021583 File Offset: 0x0001F783
		public unsafe UClassStackOnlyPtr TestClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_IsBBEntryOfClass.__PropertyOffset_TestClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_IsBBEntryOfClass.__PropertyOffset_TestClass) = value;
			}
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00021598 File Offset: 0x0001F798
		static UBTDecorator_IsBBEntryOfClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator_IsBBEntryOfClass");
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x000215A6 File Offset: 0x0001F7A6
		protected UBTDecorator_IsBBEntryOfClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000535 RID: 1333
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator_IsBBEntryOfClass";

		// Token: 0x04000536 RID: 1334
		private static IntPtr _ClassPtr;

		// Token: 0x04000537 RID: 1335
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000538 RID: 1336
		internal static int __PropertyOffset_TestClass;
	}
}
