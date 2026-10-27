using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EDB RID: 7899
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroTriggerVolumeManager")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UKuroTriggerVolumeManager : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E0A5 RID: 123045 RVA: 0x002C945B File Offset: 0x002C765B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTriggerVolumeManager._ClassPtr;
		}

		// Token: 0x0601E0A6 RID: 123046 RVA: 0x002C9468 File Offset: 0x002C7668
		public UKuroTriggerVolumeManager() : this(BuiltinUtils.AllocNativeUObject(UKuroTriggerVolumeManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E0A7 RID: 123047 RVA: 0x002C9490 File Offset: 0x002C7690
		public UKuroTriggerVolumeManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTriggerVolumeManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170077BC RID: 30652
		// (get) Token: 0x0601E0A8 RID: 123048 RVA: 0x002C94C4 File Offset: 0x002C76C4
		// (set) Token: 0x0601E0A9 RID: 123049 RVA: 0x002C94FD File Offset: 0x002C76FD
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

		// Token: 0x170077BD RID: 30653
		// (get) Token: 0x0601E0AA RID: 123050 RVA: 0x002C9520 File Offset: 0x002C7720
		// (set) Token: 0x0601E0AB RID: 123051 RVA: 0x002C9559 File Offset: 0x002C7759
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

		// Token: 0x170077BE RID: 30654
		// (get) Token: 0x0601E0AC RID: 123052 RVA: 0x002C957C File Offset: 0x002C777C
		// (set) Token: 0x0601E0AD RID: 123053 RVA: 0x002C95B5 File Offset: 0x002C77B5
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

		// Token: 0x0601E0AE RID: 123054 RVA: 0x002C95C3 File Offset: 0x002C77C3
		[NullableContext(2)]
		public AActor GetKuroTriggerVolume(FName ActorKey)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroTriggerVolumeManager.__GetKuroTriggerVolume_Internal(base.NativePtr, ActorKey));
		}

		// Token: 0x0601E0AF RID: 123055
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKuroTriggerVolume_Internal(IntPtr @this, FName ActorKey);

		// Token: 0x0601E0B0 RID: 123056 RVA: 0x002C95D6 File Offset: 0x002C77D6
		static UKuroTriggerVolumeManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroTriggerVolumeManager");
		}

		// Token: 0x0601E0B1 RID: 123057 RVA: 0x002C95E4 File Offset: 0x002C77E4
		protected UKuroTriggerVolumeManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040103E5 RID: 66533
		public new const string __ObjectPath = "/Script/KuroUtility.KuroTriggerVolumeManager";

		// Token: 0x040103E6 RID: 66534
		private static IntPtr _ClassPtr;

		// Token: 0x040103E7 RID: 66535
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040103E8 RID: 66536
		internal static int __PropertyOffset_OnTriggerVolumeAddToSubsystem;

		// Token: 0x040103E9 RID: 66537
		[Nullable(2)]
		private FTriggerVolumeMapUpdateDelegate _OnTriggerVolumeAddToSubsystem;

		// Token: 0x040103EA RID: 66538
		internal static int __PropertyOffset_OnTriggerVolumeRemoveFromSubsystem;

		// Token: 0x040103EB RID: 66539
		[Nullable(2)]
		private FTriggerVolumeMapUpdateDelegate _OnTriggerVolumeRemoveFromSubsystem;

		// Token: 0x040103EC RID: 66540
		internal static int __PropertyOffset_KuroTriggerVolumeMap;

		// Token: 0x040103ED RID: 66541
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, AActor> _KuroTriggerVolumeMap;
	}
}
