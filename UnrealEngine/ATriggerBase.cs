using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001203 RID: 4611
	[UnrealObjectPath("/Script/Engine.TriggerBase")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public abstract class ATriggerBase : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010FFC RID: 69628 RVA: 0x0018F244 File Offset: 0x0018D444
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ATriggerBase._ClassPtr;
		}

		// Token: 0x1700426E RID: 17006
		// (get) Token: 0x06010FFD RID: 69629 RVA: 0x0018F250 File Offset: 0x0018D450
		// (set) Token: 0x06010FFE RID: 69630 RVA: 0x0018F264 File Offset: 0x0018D464
		[Nullable(2)]
		public unsafe UShapeComponent CollisionComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UShapeComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATriggerBase.__PropertyOffset_CollisionComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATriggerBase.__PropertyOffset_CollisionComponent, value);
			}
		}

		// Token: 0x06010FFF RID: 69631 RVA: 0x0018F279 File Offset: 0x0018D479
		static ATriggerBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TriggerBase");
		}

		// Token: 0x06011000 RID: 69632 RVA: 0x0018F288 File Offset: 0x0018D488
		protected ATriggerBase() : this(BuiltinUtils.AllocNativeUObject(ATriggerBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011001 RID: 69633 RVA: 0x0018F2B0 File Offset: 0x0018D4B0
		protected ATriggerBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040091A3 RID: 37283
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TriggerBase";

		// Token: 0x040091A4 RID: 37284
		private static IntPtr _ClassPtr;

		// Token: 0x040091A5 RID: 37285
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040091A6 RID: 37286
		internal static int __PropertyOffset_CollisionComponent;
	}
}
