using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001571 RID: 5489
	[UnrealObjectPath("/Script/InteractiveToolsFramework.InputRouter")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UInputRouter : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013DD8 RID: 81368 RVA: 0x001D2BB2 File Offset: 0x001D0DB2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInputRouter._ClassPtr;
		}

		// Token: 0x06013DD9 RID: 81369 RVA: 0x001D2BC0 File Offset: 0x001D0DC0
		public UInputRouter() : this(BuiltinUtils.AllocNativeUObject(UInputRouter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013DDA RID: 81370 RVA: 0x001D2BE8 File Offset: 0x001D0DE8
		[NullableContext(1)]
		public UInputRouter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInputRouter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DCD RID: 19917
		// (get) Token: 0x06013DDB RID: 81371 RVA: 0x001D2C1B File Offset: 0x001D0E1B
		// (set) Token: 0x06013DDC RID: 81372 RVA: 0x001D2C2B File Offset: 0x001D0E2B
		public unsafe bool bAutoInvalidateOnHover
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInputRouter.__PropertyOffset_bAutoInvalidateOnHover) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInputRouter.__PropertyOffset_bAutoInvalidateOnHover) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004DCE RID: 19918
		// (get) Token: 0x06013DDD RID: 81373 RVA: 0x001D2C3C File Offset: 0x001D0E3C
		// (set) Token: 0x06013DDE RID: 81374 RVA: 0x001D2C4C File Offset: 0x001D0E4C
		public unsafe bool bAutoInvalidateOnCapture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInputRouter.__PropertyOffset_bAutoInvalidateOnCapture) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInputRouter.__PropertyOffset_bAutoInvalidateOnCapture) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004DCF RID: 19919
		// (get) Token: 0x06013DDF RID: 81375 RVA: 0x001D2C5D File Offset: 0x001D0E5D
		// (set) Token: 0x06013DE0 RID: 81376 RVA: 0x001D2C71 File Offset: 0x001D0E71
		[Nullable(2)]
		public unsafe UInputBehaviorSet ActiveInputBehaviors
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInputBehaviorSet>(base.NativePtr / (IntPtr)sizeof(void*) + UInputRouter.__PropertyOffset_ActiveInputBehaviors);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInputRouter.__PropertyOffset_ActiveInputBehaviors, value);
			}
		}

		// Token: 0x06013DE1 RID: 81377 RVA: 0x001D2C86 File Offset: 0x001D0E86
		static UInputRouter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.InputRouter");
		}

		// Token: 0x06013DE2 RID: 81378 RVA: 0x001D2C94 File Offset: 0x001D0E94
		protected UInputRouter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ABF3 RID: 44019
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.InputRouter";

		// Token: 0x0400ABF4 RID: 44020
		private static IntPtr _ClassPtr;

		// Token: 0x0400ABF5 RID: 44021
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ABF6 RID: 44022
		internal static int __PropertyOffset_bAutoInvalidateOnHover;

		// Token: 0x0400ABF7 RID: 44023
		internal static int __PropertyOffset_bAutoInvalidateOnCapture;

		// Token: 0x0400ABF8 RID: 44024
		internal static int __PropertyOffset_ActiveInputBehaviors;
	}
}
