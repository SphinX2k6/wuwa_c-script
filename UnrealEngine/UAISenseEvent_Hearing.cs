using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000108 RID: 264
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AISenseEvent_Hearing")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UAISenseEvent_Hearing : UAISenseEvent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060013CD RID: 5069 RVA: 0x0001D369 File Offset: 0x0001B569
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISenseEvent_Hearing._ClassPtr;
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0001D378 File Offset: 0x0001B578
		public UAISenseEvent_Hearing() : this(BuiltinUtils.AllocNativeUObject(UAISenseEvent_Hearing.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0001D3A0 File Offset: 0x0001B5A0
		public UAISenseEvent_Hearing(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAISenseEvent_Hearing.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x0001D3D4 File Offset: 0x0001B5D4
		// (set) Token: 0x060013D1 RID: 5073 RVA: 0x0001D40D File Offset: 0x0001B60D
		public FAINoiseEvent Event
		{
			get
			{
				base.FastCheckIsValid();
				FAINoiseEvent result;
				if ((result = this._Event) == null)
				{
					result = (this._Event = new FAINoiseEvent(base.NativePtr + (IntPtr)UAISenseEvent_Hearing.__PropertyOffset_Event, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAINoiseEvent.StaticStruct(), base.NativePtr + (IntPtr)UAISenseEvent_Hearing.__PropertyOffset_Event, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0001D42E File Offset: 0x0001B62E
		static UAISenseEvent_Hearing()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISenseEvent_Hearing");
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0001D43C File Offset: 0x0001B63C
		protected UAISenseEvent_Hearing(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040003C7 RID: 967
		public new const string __ObjectPath = "/Script/AIModule.AISenseEvent_Hearing";

		// Token: 0x040003C8 RID: 968
		private static IntPtr _ClassPtr;

		// Token: 0x040003C9 RID: 969
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040003CA RID: 970
		internal static int __PropertyOffset_Event;

		// Token: 0x040003CB RID: 971
		[Nullable(2)]
		private FAINoiseEvent _Event;
	}
}
