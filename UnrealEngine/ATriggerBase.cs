using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002A4 RID: 676
	[UnrealObjectPath("/Script/Engine.TriggerBase")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public abstract class ATriggerBase : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060049FB RID: 18939 RVA: 0x00067A02 File Offset: 0x00065C02
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ATriggerBase._ClassPtr;
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x060049FC RID: 18940 RVA: 0x00067A0E File Offset: 0x00065C0E
		// (set) Token: 0x060049FD RID: 18941 RVA: 0x00067A22 File Offset: 0x00065C22
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

		// Token: 0x060049FE RID: 18942 RVA: 0x00067A37 File Offset: 0x00065C37
		static ATriggerBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TriggerBase");
		}

		// Token: 0x060049FF RID: 18943 RVA: 0x00067A48 File Offset: 0x00065C48
		protected ATriggerBase() : this(BuiltinUtils.AllocNativeUObject(ATriggerBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004A00 RID: 18944 RVA: 0x00067A70 File Offset: 0x00065C70
		protected ATriggerBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D1A RID: 7450
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TriggerBase";

		// Token: 0x04001D1B RID: 7451
		private static IntPtr _ClassPtr;

		// Token: 0x04001D1C RID: 7452
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001D1D RID: 7453
		internal static int __PropertyOffset_CollisionComponent;
	}
}
