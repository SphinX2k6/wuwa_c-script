using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D69 RID: 3433
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LODSyncComponent")]
	[UnrealStructLayout(344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 344)]
	public class ULODSyncComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B972 RID: 47474 RVA: 0x00107DC4 File Offset: 0x00105FC4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULODSyncComponent._ClassPtr;
		}

		// Token: 0x0600B973 RID: 47475 RVA: 0x00107DD0 File Offset: 0x00105FD0
		public ULODSyncComponent() : this(BuiltinUtils.AllocNativeUObject(ULODSyncComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B974 RID: 47476 RVA: 0x00107DF8 File Offset: 0x00105FF8
		public ULODSyncComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULODSyncComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A7C RID: 10876
		// (get) Token: 0x0600B975 RID: 47477 RVA: 0x00107E2B File Offset: 0x0010602B
		// (set) Token: 0x0600B976 RID: 47478 RVA: 0x00107E3B File Offset: 0x0010603B
		public unsafe int NumLODs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULODSyncComponent.__PropertyOffset_NumLODs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULODSyncComponent.__PropertyOffset_NumLODs) = value;
			}
		}

		// Token: 0x17002A7D RID: 10877
		// (get) Token: 0x0600B977 RID: 47479 RVA: 0x00107E4C File Offset: 0x0010604C
		// (set) Token: 0x0600B978 RID: 47480 RVA: 0x00107E5C File Offset: 0x0010605C
		public unsafe int ForcedLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULODSyncComponent.__PropertyOffset_ForcedLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULODSyncComponent.__PropertyOffset_ForcedLOD) = value;
			}
		}

		// Token: 0x17002A7E RID: 10878
		// (get) Token: 0x0600B979 RID: 47481 RVA: 0x00107E70 File Offset: 0x00106070
		// (set) Token: 0x0600B97A RID: 47482 RVA: 0x00107EA9 File Offset: 0x001060A9
		public TArray<FComponentSync> ComponentsToSync
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FComponentSync> result;
				if ((result = this._ComponentsToSync) == null)
				{
					result = (this._ComponentsToSync = new TArray<FComponentSync>(base.NativePtr + (IntPtr)ULODSyncComponent.__PropertyOffset_ComponentsToSync, this));
				}
				return result;
			}
			set
			{
				this.ComponentsToSync.CopyAssign(value);
			}
		}

		// Token: 0x17002A7F RID: 10879
		// (get) Token: 0x0600B97B RID: 47483 RVA: 0x00107EB8 File Offset: 0x001060B8
		// (set) Token: 0x0600B97C RID: 47484 RVA: 0x00107EF1 File Offset: 0x001060F1
		public TMap<FName, FLODMappingData> CustomLODMapping
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLODMappingData> result;
				if ((result = this._CustomLODMapping) == null)
				{
					result = (this._CustomLODMapping = new TMap<FName, FLODMappingData>(base.NativePtr + (IntPtr)ULODSyncComponent.__PropertyOffset_CustomLODMapping, this));
				}
				return result;
			}
			set
			{
				this.CustomLODMapping.CopyAssign(value);
			}
		}

		// Token: 0x17002A80 RID: 10880
		// (get) Token: 0x0600B97D RID: 47485 RVA: 0x00107EFF File Offset: 0x001060FF
		// (set) Token: 0x0600B97E RID: 47486 RVA: 0x00107F0F File Offset: 0x0010610F
		public unsafe int CurrentLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULODSyncComponent.__PropertyOffset_CurrentLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULODSyncComponent.__PropertyOffset_CurrentLOD) = value;
			}
		}

		// Token: 0x17002A81 RID: 10881
		// (get) Token: 0x0600B97F RID: 47487 RVA: 0x00107F20 File Offset: 0x00106120
		// (set) Token: 0x0600B980 RID: 47488 RVA: 0x00107F30 File Offset: 0x00106130
		public unsafe int CurrentNumLODs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULODSyncComponent.__PropertyOffset_CurrentNumLODs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULODSyncComponent.__PropertyOffset_CurrentNumLODs) = value;
			}
		}

		// Token: 0x17002A82 RID: 10882
		// (get) Token: 0x0600B981 RID: 47489 RVA: 0x00107F44 File Offset: 0x00106144
		// (set) Token: 0x0600B982 RID: 47490 RVA: 0x00107F7D File Offset: 0x0010617D
		public TArray<UPrimitiveComponent> DriveComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UPrimitiveComponent> result;
				if ((result = this._DriveComponents) == null)
				{
					result = (this._DriveComponents = new TArray<UPrimitiveComponent>(base.NativePtr + (IntPtr)ULODSyncComponent.__PropertyOffset_DriveComponents, this));
				}
				return result;
			}
			set
			{
				this.DriveComponents.CopyAssign(value);
			}
		}

		// Token: 0x17002A83 RID: 10883
		// (get) Token: 0x0600B983 RID: 47491 RVA: 0x00107F8C File Offset: 0x0010618C
		// (set) Token: 0x0600B984 RID: 47492 RVA: 0x00107FC5 File Offset: 0x001061C5
		public TArray<UPrimitiveComponent> SubComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UPrimitiveComponent> result;
				if ((result = this._SubComponents) == null)
				{
					result = (this._SubComponents = new TArray<UPrimitiveComponent>(base.NativePtr + (IntPtr)ULODSyncComponent.__PropertyOffset_SubComponents, this));
				}
				return result;
			}
			set
			{
				this.SubComponents.CopyAssign(value);
			}
		}

		// Token: 0x0600B985 RID: 47493 RVA: 0x00107FD3 File Offset: 0x001061D3
		public string GetLODSyncDebugText()
		{
			return FString.ToStringAndDeleteNativePtr(ULODSyncComponent.__GetLODSyncDebugText_Internal(base.NativePtr));
		}

		// Token: 0x0600B986 RID: 47494
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetLODSyncDebugText_Internal(IntPtr @this);

		// Token: 0x0600B987 RID: 47495 RVA: 0x00107FE5 File Offset: 0x001061E5
		static ULODSyncComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LODSyncComponent");
		}

		// Token: 0x0600B988 RID: 47496 RVA: 0x00107FF3 File Offset: 0x001061F3
		protected ULODSyncComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006129 RID: 24873
		public new const string __ObjectPath = "/Script/Engine.LODSyncComponent";

		// Token: 0x0400612A RID: 24874
		private static IntPtr _ClassPtr;

		// Token: 0x0400612B RID: 24875
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400612C RID: 24876
		internal static int __PropertyOffset_NumLODs;

		// Token: 0x0400612D RID: 24877
		internal static int __PropertyOffset_ForcedLOD;

		// Token: 0x0400612E RID: 24878
		internal static int __PropertyOffset_ComponentsToSync;

		// Token: 0x0400612F RID: 24879
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FComponentSync> _ComponentsToSync;

		// Token: 0x04006130 RID: 24880
		internal static int __PropertyOffset_CustomLODMapping;

		// Token: 0x04006131 RID: 24881
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FLODMappingData> _CustomLODMapping;

		// Token: 0x04006132 RID: 24882
		internal static int __PropertyOffset_CurrentLOD;

		// Token: 0x04006133 RID: 24883
		internal static int __PropertyOffset_CurrentNumLODs;

		// Token: 0x04006134 RID: 24884
		internal static int __PropertyOffset_DriveComponents;

		// Token: 0x04006135 RID: 24885
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPrimitiveComponent> _DriveComponents;

		// Token: 0x04006136 RID: 24886
		internal static int __PropertyOffset_SubComponents;

		// Token: 0x04006137 RID: 24887
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPrimitiveComponent> _SubComponents;
	}
}
