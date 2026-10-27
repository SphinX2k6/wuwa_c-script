using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200010A RID: 266
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AISense_Damage")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UAISense_Damage : UAISense, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060013EC RID: 5100 RVA: 0x0001D645 File Offset: 0x0001B845
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISense_Damage._ClassPtr;
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x0001D654 File Offset: 0x0001B854
		public UAISense_Damage() : this(BuiltinUtils.AllocNativeUObject(UAISense_Damage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x0001D67C File Offset: 0x0001B87C
		public UAISense_Damage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAISense_Damage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x0001D6B0 File Offset: 0x0001B8B0
		// (set) Token: 0x060013F0 RID: 5104 RVA: 0x0001D6E9 File Offset: 0x0001B8E9
		public TArray<FAIDamageEvent> RegisteredEvents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAIDamageEvent> result;
				if ((result = this._RegisteredEvents) == null)
				{
					result = (this._RegisteredEvents = new TArray<FAIDamageEvent>(base.NativePtr + (IntPtr)UAISense_Damage.__PropertyOffset_RegisteredEvents, this));
				}
				return result;
			}
			set
			{
				this.RegisteredEvents.CopyAssign(value);
			}
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x0001D6F7 File Offset: 0x0001B8F7
		[NullableContext(2)]
		public static void ReportDamageEvent(UObject WorldContextObject, AActor DamagedActor, AActor Instigator, float DamageAmount, FVector EventLocation, FVector HitLocation)
		{
			UAISense_Damage.__ReportDamageEvent_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (DamagedActor != null) ? DamagedActor.NativePtr : IntPtr.Zero, (Instigator != null) ? Instigator.NativePtr : IntPtr.Zero, DamageAmount, EventLocation, HitLocation);
		}

		// Token: 0x060013F2 RID: 5106
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReportDamageEvent_Internal(IntPtr WorldContextObject, IntPtr DamagedActor, IntPtr Instigator, float DamageAmount, FVector EventLocation, FVector HitLocation);

		// Token: 0x060013F3 RID: 5107 RVA: 0x0001D733 File Offset: 0x0001B933
		static UAISense_Damage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISense_Damage");
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x0001D741 File Offset: 0x0001B941
		protected UAISense_Damage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040003D4 RID: 980
		public new const string __ObjectPath = "/Script/AIModule.AISense_Damage";

		// Token: 0x040003D5 RID: 981
		private static IntPtr _ClassPtr;

		// Token: 0x040003D6 RID: 982
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040003D7 RID: 983
		internal static int __PropertyOffset_RegisteredEvents;

		// Token: 0x040003D8 RID: 984
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAIDamageEvent> _RegisteredEvents;
	}
}
