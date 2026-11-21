using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005ED RID: 1517
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroTriggerVolumeManager")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UKuroTriggerVolumeManager : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600871A RID: 34586 RVA: 0x000CAA45 File Offset: 0x000C8C45
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTriggerVolumeManager._ClassPtr;
		}

		// Token: 0x0600871B RID: 34587 RVA: 0x000CAA54 File Offset: 0x000C8C54
		public UKuroTriggerVolumeManager() : this(BuiltinUtils.AllocNativeUObject(UKuroTriggerVolumeManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600871C RID: 34588 RVA: 0x000CAA7C File Offset: 0x000C8C7C
		public UKuroTriggerVolumeManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTriggerVolumeManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x0600871D RID: 34589 RVA: 0x000CAAB0 File Offset: 0x000C8CB0
		// (set) Token: 0x0600871E RID: 34590 RVA: 0x000CAAE9 File Offset: 0x000C8CE9
		public FTriggerVolumeMapUpdateDelegate OnTriggerVolumeAddToSubsystem
		{
			get
			{
				base.FastCheckIsValid();
				FTriggerVolumeMapUpdateDelegate result;
				if ((result = this._OnTriggerVolumeAddToSubsystem) == null)
				{
					result = (this._OnTriggerVolumeAddToSubsystem = new FTriggerVolumeMapUpdateDelegate(base.NativePtr + (IntPtr)UKuroTriggerVolumeManager.__PropertyOffset_OnTriggerVolumeAddToSubsystem, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroTriggerVolumeManager.__PropertyOffset_OnTriggerVolumeAddToSubsystem, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x0600871F RID: 34591 RVA: 0x000CAB0C File Offset: 0x000C8D0C
		// (set) Token: 0x06008720 RID: 34592 RVA: 0x000CAB45 File Offset: 0x000C8D45
		public FTriggerVolumeMapUpdateDelegate OnTriggerVolumeRemoveFromSubsystem
		{
			get
			{
				base.FastCheckIsValid();
				FTriggerVolumeMapUpdateDelegate result;
				if ((result = this._OnTriggerVolumeRemoveFromSubsystem) == null)
				{
					result = (this._OnTriggerVolumeRemoveFromSubsystem = new FTriggerVolumeMapUpdateDelegate(base.NativePtr + (IntPtr)UKuroTriggerVolumeManager.__PropertyOffset_OnTriggerVolumeRemoveFromSubsystem, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroTriggerVolumeManager.__PropertyOffset_OnTriggerVolumeRemoveFromSubsystem, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x06008721 RID: 34593 RVA: 0x000CAB68 File Offset: 0x000C8D68
		// (set) Token: 0x06008722 RID: 34594 RVA: 0x000CABA1 File Offset: 0x000C8DA1
		public TMap<FName, AActor> KuroTriggerVolumeMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, AActor> result;
				if ((result = this._KuroTriggerVolumeMap) == null)
				{
					result = (this._KuroTriggerVolumeMap = new TMap<FName, AActor>(base.NativePtr + (IntPtr)UKuroTriggerVolumeManager.__PropertyOffset_KuroTriggerVolumeMap, this));
				}
				return result;
			}
			set
			{
				this.KuroTriggerVolumeMap.CopyAssign(value);
			}
		}

		// Token: 0x06008723 RID: 34595 RVA: 0x000CABAF File Offset: 0x000C8DAF
		[NullableContext(2)]
		public AActor GetKuroTriggerVolume(FName ActorKey)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroTriggerVolumeManager.__GetKuroTriggerVolume_Internal(base.NativePtr, ActorKey));
		}

		// Token: 0x06008724 RID: 34596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKuroTriggerVolume_Internal(IntPtr @this, FName ActorKey);

		// Token: 0x06008725 RID: 34597 RVA: 0x000CABC2 File Offset: 0x000C8DC2
		static UKuroTriggerVolumeManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroTriggerVolumeManager");
		}

		// Token: 0x06008726 RID: 34598 RVA: 0x000CABD0 File Offset: 0x000C8DD0
		protected UKuroTriggerVolumeManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003ACC RID: 15052
		public new const string __ObjectPath = "/Script/KuroUtility.KuroTriggerVolumeManager";

		// Token: 0x04003ACD RID: 15053
		private static IntPtr _ClassPtr;

		// Token: 0x04003ACE RID: 15054
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003ACF RID: 15055
		internal static int __PropertyOffset_OnTriggerVolumeAddToSubsystem;

		// Token: 0x04003AD0 RID: 15056
		[Nullable(2)]
		private FTriggerVolumeMapUpdateDelegate _OnTriggerVolumeAddToSubsystem;

		// Token: 0x04003AD1 RID: 15057
		internal static int __PropertyOffset_OnTriggerVolumeRemoveFromSubsystem;

		// Token: 0x04003AD2 RID: 15058
		[Nullable(2)]
		private FTriggerVolumeMapUpdateDelegate _OnTriggerVolumeRemoveFromSubsystem;

		// Token: 0x04003AD3 RID: 15059
		internal static int __PropertyOffset_KuroTriggerVolumeMap;

		// Token: 0x04003AD4 RID: 15060
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, AActor> _KuroTriggerVolumeMap;
	}
}
