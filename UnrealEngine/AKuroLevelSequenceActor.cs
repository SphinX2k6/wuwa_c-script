using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004CD RID: 1229
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroLevelSequenceActor")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1232)]
	public class AKuroLevelSequenceActor : ALevelSequenceActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600727A RID: 29306 RVA: 0x000A8514 File Offset: 0x000A6714
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroLevelSequenceActor._ClassPtr;
		}

		// Token: 0x0600727B RID: 29307 RVA: 0x000A8520 File Offset: 0x000A6720
		public AKuroLevelSequenceActor() : this(BuiltinUtils.AllocNativeUObject(AKuroLevelSequenceActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600727C RID: 29308 RVA: 0x000A8548 File Offset: 0x000A6748
		[NullableContext(1)]
		public AKuroLevelSequenceActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroLevelSequenceActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x0600727D RID: 29309 RVA: 0x000A857B File Offset: 0x000A677B
		// (set) Token: 0x0600727E RID: 29310 RVA: 0x000A858F File Offset: 0x000A678F
		public unsafe FName Key
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLevelSequenceActor.__PropertyOffset_Key);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLevelSequenceActor.__PropertyOffset_Key) = value;
			}
		}

		// Token: 0x0600727F RID: 29311 RVA: 0x000A85A4 File Offset: 0x000A67A4
		static AKuroLevelSequenceActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroLevelSequenceActor");
		}

		// Token: 0x06007280 RID: 29312 RVA: 0x000A85B2 File Offset: 0x000A67B2
		protected AKuroLevelSequenceActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003150 RID: 12624
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroLevelSequenceActor";

		// Token: 0x04003151 RID: 12625
		private static IntPtr _ClassPtr;

		// Token: 0x04003152 RID: 12626
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003153 RID: 12627
		internal static int __PropertyOffset_Key;
	}
}
