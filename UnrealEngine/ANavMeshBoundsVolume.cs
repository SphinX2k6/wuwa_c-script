using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024A0 RID: 9376
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NavigationSystem.NavMeshBoundsVolume")]
	[UnrealStructLayout(1112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1112)]
	public class ANavMeshBoundsVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602318B RID: 143755 RVA: 0x0033E6FA File Offset: 0x0033C8FA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavMeshBoundsVolume._ClassPtr;
		}

		// Token: 0x0602318C RID: 143756 RVA: 0x0033E708 File Offset: 0x0033C908
		public ANavMeshBoundsVolume() : this(BuiltinUtils.AllocNativeUObject(ANavMeshBoundsVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602318D RID: 143757 RVA: 0x0033E730 File Offset: 0x0033C930
		public ANavMeshBoundsVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANavMeshBoundsVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170086DC RID: 34524
		// (get) Token: 0x0602318E RID: 143758 RVA: 0x0033E764 File Offset: 0x0033C964
		// (set) Token: 0x0602318F RID: 143759 RVA: 0x0033E79D File Offset: 0x0033C99D
		public FNavAgentSelector SupportedAgents
		{
			get
			{
				base.FastCheckIsValid();
				FNavAgentSelector result;
				if ((result = this._SupportedAgents) == null)
				{
					result = (this._SupportedAgents = new FNavAgentSelector(base.NativePtr + (IntPtr)ANavMeshBoundsVolume.__PropertyOffset_SupportedAgents, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAgentSelector.StaticStruct(), base.NativePtr + (IntPtr)ANavMeshBoundsVolume.__PropertyOffset_SupportedAgents, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170086DD RID: 34525
		// (get) Token: 0x06023190 RID: 143760 RVA: 0x0033E7BE File Offset: 0x0033C9BE
		// (set) Token: 0x06023191 RID: 143761 RVA: 0x0033E7CE File Offset: 0x0033C9CE
		public unsafe bool bEnableWaterFloodSpread
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavMeshBoundsVolume.__PropertyOffset_bEnableWaterFloodSpread) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavMeshBoundsVolume.__PropertyOffset_bEnableWaterFloodSpread) = (value ? 1 : 0);
			}
		}

		// Token: 0x06023192 RID: 143762 RVA: 0x0033E7DF File Offset: 0x0033C9DF
		static ANavMeshBoundsVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavMeshBoundsVolume");
		}

		// Token: 0x06023193 RID: 143763 RVA: 0x0033E7ED File Offset: 0x0033C9ED
		protected ANavMeshBoundsVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012BC7 RID: 76743
		public new const string __ObjectPath = "/Script/NavigationSystem.NavMeshBoundsVolume";

		// Token: 0x04012BC8 RID: 76744
		private static IntPtr _ClassPtr;

		// Token: 0x04012BC9 RID: 76745
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012BCA RID: 76746
		internal static int __PropertyOffset_SupportedAgents;

		// Token: 0x04012BCB RID: 76747
		[Nullable(2)]
		private FNavAgentSelector _SupportedAgents;

		// Token: 0x04012BCC RID: 76748
		internal static int __PropertyOffset_bEnableWaterFloodSpread;
	}
}
