using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200010E RID: 270
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AISense_Team")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UAISense_Team : UAISense, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600141C RID: 5148 RVA: 0x0001DABC File Offset: 0x0001BCBC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISense_Team._ClassPtr;
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x0001DAC8 File Offset: 0x0001BCC8
		public UAISense_Team() : this(BuiltinUtils.AllocNativeUObject(UAISense_Team.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x0001DAF0 File Offset: 0x0001BCF0
		public UAISense_Team(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAISense_Team.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x0001DB24 File Offset: 0x0001BD24
		// (set) Token: 0x06001420 RID: 5152 RVA: 0x0001DB5D File Offset: 0x0001BD5D
		public TArray<FAITeamStimulusEvent> RegisteredEvents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAITeamStimulusEvent> result;
				if ((result = this._RegisteredEvents) == null)
				{
					result = (this._RegisteredEvents = new TArray<FAITeamStimulusEvent>(base.NativePtr + (IntPtr)UAISense_Team.__PropertyOffset_RegisteredEvents, this));
				}
				return result;
			}
			set
			{
				this.RegisteredEvents.CopyAssign(value);
			}
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0001DB6B File Offset: 0x0001BD6B
		static UAISense_Team()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISense_Team");
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x0001DB79 File Offset: 0x0001BD79
		protected UAISense_Team(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040003ED RID: 1005
		public new const string __ObjectPath = "/Script/AIModule.AISense_Team";

		// Token: 0x040003EE RID: 1006
		private static IntPtr _ClassPtr;

		// Token: 0x040003EF RID: 1007
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040003F0 RID: 1008
		internal static int __PropertyOffset_RegisteredEvents;

		// Token: 0x040003F1 RID: 1009
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAITeamStimulusEvent> _RegisteredEvents;
	}
}
