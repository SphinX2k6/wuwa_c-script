using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DAB RID: 7595
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_SceneSegmentContainer")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKSC_DA_SceneSegmentContainer : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D092 RID: 118930 RVA: 0x002AE9A0 File Offset: 0x002ACBA0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_SceneSegmentContainer._ClassPtr;
		}

		// Token: 0x0601D093 RID: 118931 RVA: 0x002AE9AC File Offset: 0x002ACBAC
		public UKSC_DA_SceneSegmentContainer() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_SceneSegmentContainer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D094 RID: 118932 RVA: 0x002AE9D4 File Offset: 0x002ACBD4
		public UKSC_DA_SceneSegmentContainer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_SceneSegmentContainer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007523 RID: 29987
		// (get) Token: 0x0601D095 RID: 118933 RVA: 0x002AEA08 File Offset: 0x002ACC08
		// (set) Token: 0x0601D096 RID: 118934 RVA: 0x002AEA41 File Offset: 0x002ACC41
		public TArray<UKSC_DA_SceneSegment> SubSceneSegments
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_DA_SceneSegment> result;
				if ((result = this._SubSceneSegments) == null)
				{
					result = (this._SubSceneSegments = new TArray<UKSC_DA_SceneSegment>(base.NativePtr + (IntPtr)UKSC_DA_SceneSegmentContainer.__PropertyOffset_SubSceneSegments, this));
				}
				return result;
			}
			set
			{
				this.SubSceneSegments.CopyAssign(value);
			}
		}

		// Token: 0x0601D097 RID: 118935 RVA: 0x002AEA4F File Offset: 0x002ACC4F
		static UKSC_DA_SceneSegmentContainer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_SceneSegmentContainer");
		}

		// Token: 0x0601D098 RID: 118936 RVA: 0x002AEA5D File Offset: 0x002ACC5D
		protected UKSC_DA_SceneSegmentContainer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC30 RID: 64560
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_SceneSegmentContainer";

		// Token: 0x0400FC31 RID: 64561
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC32 RID: 64562
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC33 RID: 64563
		internal static int __PropertyOffset_SubSceneSegments;

		// Token: 0x0400FC34 RID: 64564
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_DA_SceneSegment> _SubSceneSegments;
	}
}
