using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000107 RID: 263
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AISenseEvent_Damage")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UAISenseEvent_Damage : UAISenseEvent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060013C6 RID: 5062 RVA: 0x0001D28D File Offset: 0x0001B48D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISenseEvent_Damage._ClassPtr;
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x0001D29C File Offset: 0x0001B49C
		public UAISenseEvent_Damage() : this(BuiltinUtils.AllocNativeUObject(UAISenseEvent_Damage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0001D2C4 File Offset: 0x0001B4C4
		public UAISenseEvent_Damage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAISenseEvent_Damage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x0001D2F8 File Offset: 0x0001B4F8
		// (set) Token: 0x060013CA RID: 5066 RVA: 0x0001D331 File Offset: 0x0001B531
		public FAIDamageEvent Event
		{
			get
			{
				base.FastCheckIsValid();
				FAIDamageEvent result;
				if ((result = this._Event) == null)
				{
					result = (this._Event = new FAIDamageEvent(base.NativePtr + (IntPtr)UAISenseEvent_Damage.__PropertyOffset_Event, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDamageEvent.StaticStruct(), base.NativePtr + (IntPtr)UAISenseEvent_Damage.__PropertyOffset_Event, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x0001D352 File Offset: 0x0001B552
		static UAISenseEvent_Damage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISenseEvent_Damage");
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0001D360 File Offset: 0x0001B560
		protected UAISenseEvent_Damage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040003C2 RID: 962
		public new const string __ObjectPath = "/Script/AIModule.AISenseEvent_Damage";

		// Token: 0x040003C3 RID: 963
		private static IntPtr _ClassPtr;

		// Token: 0x040003C4 RID: 964
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040003C5 RID: 965
		internal static int __PropertyOffset_Event;

		// Token: 0x040003C6 RID: 966
		[Nullable(2)]
		private FAIDamageEvent _Event;
	}
}
