using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200102E RID: 4142
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PrecomputedVisibilityVolume")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class APrecomputedVisibilityVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600E900 RID: 59648 RVA: 0x0015A27A File Offset: 0x0015847A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APrecomputedVisibilityVolume._ClassPtr;
		}

		// Token: 0x0600E901 RID: 59649 RVA: 0x0015A288 File Offset: 0x00158488
		public APrecomputedVisibilityVolume() : this(BuiltinUtils.AllocNativeUObject(APrecomputedVisibilityVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E902 RID: 59650 RVA: 0x0015A2B0 File Offset: 0x001584B0
		public APrecomputedVisibilityVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APrecomputedVisibilityVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003869 RID: 14441
		// (get) Token: 0x0600E903 RID: 59651 RVA: 0x0015A2E4 File Offset: 0x001584E4
		// (set) Token: 0x0600E904 RID: 59652 RVA: 0x0015A31D File Offset: 0x0015851D
		public TArray<FMeshVisibilityInfo> AllMeshVisibilityInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMeshVisibilityInfo> result;
				if ((result = this._AllMeshVisibilityInfos) == null)
				{
					result = (this._AllMeshVisibilityInfos = new TArray<FMeshVisibilityInfo>(base.NativePtr + (IntPtr)APrecomputedVisibilityVolume.__PropertyOffset_AllMeshVisibilityInfos, this));
				}
				return result;
			}
			set
			{
				this.AllMeshVisibilityInfos.CopyAssign(value);
			}
		}

		// Token: 0x0600E905 RID: 59653 RVA: 0x0015A32B File Offset: 0x0015852B
		static APrecomputedVisibilityVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PrecomputedVisibilityVolume");
		}

		// Token: 0x0600E906 RID: 59654 RVA: 0x0015A339 File Offset: 0x00158539
		protected APrecomputedVisibilityVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007E80 RID: 32384
		public new const string __ObjectPath = "/Script/Engine.PrecomputedVisibilityVolume";

		// Token: 0x04007E81 RID: 32385
		private static IntPtr _ClassPtr;

		// Token: 0x04007E82 RID: 32386
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007E83 RID: 32387
		internal static int __PropertyOffset_AllMeshVisibilityInfos;

		// Token: 0x04007E84 RID: 32388
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMeshVisibilityInfo> _AllMeshVisibilityInfos;
	}
}
