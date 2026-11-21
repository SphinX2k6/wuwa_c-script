using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000570 RID: 1392
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_SceneSegmentContainer")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKSC_DA_SceneSegmentContainer : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007E7C RID: 32380 RVA: 0x000BB702 File Offset: 0x000B9902
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_SceneSegmentContainer._ClassPtr;
		}

		// Token: 0x06007E7D RID: 32381 RVA: 0x000BB710 File Offset: 0x000B9910
		public UKSC_DA_SceneSegmentContainer() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_SceneSegmentContainer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007E7E RID: 32382 RVA: 0x000BB738 File Offset: 0x000B9938
		[NullableContext(1)]
		public UKSC_DA_SceneSegmentContainer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_SceneSegmentContainer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007E7F RID: 32383 RVA: 0x000BB76B File Offset: 0x000B996B
		static UKSC_DA_SceneSegmentContainer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_SceneSegmentContainer");
		}

		// Token: 0x06007E80 RID: 32384 RVA: 0x000BB779 File Offset: 0x000B9979
		protected UKSC_DA_SceneSegmentContainer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003736 RID: 14134
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_SceneSegmentContainer";

		// Token: 0x04003737 RID: 14135
		private static IntPtr _ClassPtr;

		// Token: 0x04003738 RID: 14136
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
