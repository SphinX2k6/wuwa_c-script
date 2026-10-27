using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200010F RID: 271
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AISense_Touch")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UAISense_Touch : UAISense, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001423 RID: 5155 RVA: 0x0001DB82 File Offset: 0x0001BD82
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISense_Touch._ClassPtr;
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0001DB90 File Offset: 0x0001BD90
		public UAISense_Touch() : this(BuiltinUtils.AllocNativeUObject(UAISense_Touch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x0001DBB8 File Offset: 0x0001BDB8
		public UAISense_Touch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAISense_Touch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x0001DBEC File Offset: 0x0001BDEC
		// (set) Token: 0x06001427 RID: 5159 RVA: 0x0001DC25 File Offset: 0x0001BE25
		public TArray<FAITouchEvent> RegisteredEvents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAITouchEvent> result;
				if ((result = this._RegisteredEvents) == null)
				{
					result = (this._RegisteredEvents = new TArray<FAITouchEvent>(base.NativePtr + (IntPtr)UAISense_Touch.__PropertyOffset_RegisteredEvents, this));
				}
				return result;
			}
			set
			{
				this.RegisteredEvents.CopyAssign(value);
			}
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x0001DC33 File Offset: 0x0001BE33
		static UAISense_Touch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISense_Touch");
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x0001DC41 File Offset: 0x0001BE41
		protected UAISense_Touch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040003F2 RID: 1010
		public new const string __ObjectPath = "/Script/AIModule.AISense_Touch";

		// Token: 0x040003F3 RID: 1011
		private static IntPtr _ClassPtr;

		// Token: 0x040003F4 RID: 1012
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040003F5 RID: 1013
		internal static int __PropertyOffset_RegisteredEvents;

		// Token: 0x040003F6 RID: 1014
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAITouchEvent> _RegisteredEvents;
	}
}
