using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D8E RID: 7566
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_EntityRender")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UKSC_DA_EntityRender : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CF78 RID: 118648 RVA: 0x002AD09A File Offset: 0x002AB29A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_EntityRender._ClassPtr;
		}

		// Token: 0x0601CF79 RID: 118649 RVA: 0x002AD0A8 File Offset: 0x002AB2A8
		public UKSC_DA_EntityRender() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_EntityRender.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CF7A RID: 118650 RVA: 0x002AD0D0 File Offset: 0x002AB2D0
		public UKSC_DA_EntityRender(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_EntityRender.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074DE RID: 29918
		// (get) Token: 0x0601CF7B RID: 118651 RVA: 0x002AD103 File Offset: 0x002AB303
		// (set) Token: 0x0601CF7C RID: 118652 RVA: 0x002AD113 File Offset: 0x002AB313
		public unsafe bool bIsGPUNPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_EntityRender.__PropertyOffset_bIsGPUNPC) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_EntityRender.__PropertyOffset_bIsGPUNPC) = (value ? 1 : 0);
			}
		}

		// Token: 0x170074DF RID: 29919
		// (get) Token: 0x0601CF7D RID: 118653 RVA: 0x002AD124 File Offset: 0x002AB324
		// (set) Token: 0x0601CF7E RID: 118654 RVA: 0x002AD138 File Offset: 0x002AB338
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AActor> RenderActorClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_EntityRender.__PropertyOffset_RenderActorClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_EntityRender.__PropertyOffset_RenderActorClass) = value;
			}
		}

		// Token: 0x170074E0 RID: 29920
		// (get) Token: 0x0601CF7F RID: 118655 RVA: 0x002AD14D File Offset: 0x002AB34D
		// (set) Token: 0x0601CF80 RID: 118656 RVA: 0x002AD15D File Offset: 0x002AB35D
		public unsafe EKSC_GPUNPCAnimState InitAnimState
		{
			get
			{
				return (EKSC_GPUNPCAnimState)(*(base.NativePtr + (IntPtr)UKSC_DA_EntityRender.__PropertyOffset_InitAnimState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_EntityRender.__PropertyOffset_InitAnimState) = (byte)value;
			}
		}

		// Token: 0x170074E1 RID: 29921
		// (get) Token: 0x0601CF81 RID: 118657 RVA: 0x002AD170 File Offset: 0x002AB370
		// (set) Token: 0x0601CF82 RID: 118658 RVA: 0x002AD1A9 File Offset: 0x002AB3A9
		public TMap<EKSC_GPUNPCAnimState, FKSC_TimeLineData> TimeLine
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_GPUNPCAnimState, FKSC_TimeLineData> result;
				if ((result = this._TimeLine) == null)
				{
					result = (this._TimeLine = new TMap<EKSC_GPUNPCAnimState, FKSC_TimeLineData>(base.NativePtr + (IntPtr)UKSC_DA_EntityRender.__PropertyOffset_TimeLine, this));
				}
				return result;
			}
			set
			{
				this.TimeLine.CopyAssign(value);
			}
		}

		// Token: 0x0601CF83 RID: 118659 RVA: 0x002AD1B7 File Offset: 0x002AB3B7
		static UKSC_DA_EntityRender()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_EntityRender");
		}

		// Token: 0x0601CF84 RID: 118660 RVA: 0x002AD1C5 File Offset: 0x002AB3C5
		protected UKSC_DA_EntityRender(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB8A RID: 64394
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_EntityRender";

		// Token: 0x0400FB8B RID: 64395
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB8C RID: 64396
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB8D RID: 64397
		internal static int __PropertyOffset_bIsGPUNPC;

		// Token: 0x0400FB8E RID: 64398
		internal static int __PropertyOffset_RenderActorClass;

		// Token: 0x0400FB8F RID: 64399
		internal static int __PropertyOffset_InitAnimState;

		// Token: 0x0400FB90 RID: 64400
		internal static int __PropertyOffset_TimeLine;

		// Token: 0x0400FB91 RID: 64401
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EKSC_GPUNPCAnimState, FKSC_TimeLineData> _TimeLine;
	}
}
