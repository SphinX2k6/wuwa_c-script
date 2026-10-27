using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002475 RID: 9333
	[UnrealObjectPath("/Script/NavigationSystem.KuroNavOverrideVolume")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1136)]
	public class AKuroNavOverrideVolume : ANavModifierVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022ED5 RID: 143061 RVA: 0x0033A28D File Offset: 0x0033848D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroNavOverrideVolume._ClassPtr;
		}

		// Token: 0x06022ED6 RID: 143062 RVA: 0x0033A29C File Offset: 0x0033849C
		public AKuroNavOverrideVolume() : this(BuiltinUtils.AllocNativeUObject(AKuroNavOverrideVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022ED7 RID: 143063 RVA: 0x0033A2C4 File Offset: 0x003384C4
		[NullableContext(1)]
		public AKuroNavOverrideVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroNavOverrideVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008627 RID: 34343
		// (get) Token: 0x06022ED8 RID: 143064 RVA: 0x0033A2F7 File Offset: 0x003384F7
		// (set) Token: 0x06022ED9 RID: 143065 RVA: 0x0033A307 File Offset: 0x00338507
		public unsafe float AgentMaxClimb
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroNavOverrideVolume.__PropertyOffset_AgentMaxClimb);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroNavOverrideVolume.__PropertyOffset_AgentMaxClimb) = value;
			}
		}

		// Token: 0x06022EDA RID: 143066 RVA: 0x0033A318 File Offset: 0x00338518
		static AKuroNavOverrideVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.KuroNavOverrideVolume");
		}

		// Token: 0x06022EDB RID: 143067 RVA: 0x0033A326 File Offset: 0x00338526
		protected AKuroNavOverrideVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A58 RID: 76376
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.KuroNavOverrideVolume";

		// Token: 0x04012A59 RID: 76377
		private static IntPtr _ClassPtr;

		// Token: 0x04012A5A RID: 76378
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012A5B RID: 76379
		internal static int __PropertyOffset_AgentMaxClimb;
	}
}
