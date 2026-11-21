using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005D4 RID: 1492
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroDemoInteractSubSystem")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UKuroDemoInteractSubSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008440 RID: 33856 RVA: 0x000C4510 File Offset: 0x000C2710
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDemoInteractSubSystem._ClassPtr;
		}

		// Token: 0x06008441 RID: 33857 RVA: 0x000C451C File Offset: 0x000C271C
		public UKuroDemoInteractSubSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroDemoInteractSubSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008442 RID: 33858 RVA: 0x000C4544 File Offset: 0x000C2744
		public UKuroDemoInteractSubSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDemoInteractSubSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x06008443 RID: 33859 RVA: 0x000C4578 File Offset: 0x000C2778
		// (set) Token: 0x06008444 RID: 33860 RVA: 0x000C45B1 File Offset: 0x000C27B1
		public FDemoInteractiveActorMapUpdateDelegate OnDemoInteractiveActorAdd
		{
			get
			{
				base.FastCheckIsValid();
				FDemoInteractiveActorMapUpdateDelegate result;
				if ((result = this._OnDemoInteractiveActorAdd) == null)
				{
					result = (this._OnDemoInteractiveActorAdd = new FDemoInteractiveActorMapUpdateDelegate(base.NativePtr + (IntPtr)UKuroDemoInteractSubSystem.__PropertyOffset_OnDemoInteractiveActorAdd, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroDemoInteractSubSystem.__PropertyOffset_OnDemoInteractiveActorAdd, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x06008445 RID: 33861 RVA: 0x000C45D4 File Offset: 0x000C27D4
		// (set) Token: 0x06008446 RID: 33862 RVA: 0x000C460D File Offset: 0x000C280D
		public FDemoInteractiveActorMapUpdateDelegate OnDemoInteractiveActorRemove
		{
			get
			{
				base.FastCheckIsValid();
				FDemoInteractiveActorMapUpdateDelegate result;
				if ((result = this._OnDemoInteractiveActorRemove) == null)
				{
					result = (this._OnDemoInteractiveActorRemove = new FDemoInteractiveActorMapUpdateDelegate(base.NativePtr + (IntPtr)UKuroDemoInteractSubSystem.__PropertyOffset_OnDemoInteractiveActorRemove, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroDemoInteractSubSystem.__PropertyOffset_OnDemoInteractiveActorRemove, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x06008447 RID: 33863 RVA: 0x000C4630 File Offset: 0x000C2830
		// (set) Token: 0x06008448 RID: 33864 RVA: 0x000C4669 File Offset: 0x000C2869
		public TMap<FName, AActor> DemoInteractiveActorMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, AActor> result;
				if ((result = this._DemoInteractiveActorMap) == null)
				{
					result = (this._DemoInteractiveActorMap = new TMap<FName, AActor>(base.NativePtr + (IntPtr)UKuroDemoInteractSubSystem.__PropertyOffset_DemoInteractiveActorMap, this));
				}
				return result;
			}
			set
			{
				this.DemoInteractiveActorMap.CopyAssign(value);
			}
		}

		// Token: 0x06008449 RID: 33865 RVA: 0x000C4677 File Offset: 0x000C2877
		[NullableContext(2)]
		public AActor GetDemoInteractiveActor(FName ActorKey)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroDemoInteractSubSystem.__GetDemoInteractiveActor_Internal(base.NativePtr, ActorKey));
		}

		// Token: 0x0600844A RID: 33866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDemoInteractiveActor_Internal(IntPtr @this, FName ActorKey);

		// Token: 0x0600844B RID: 33867 RVA: 0x000C468A File Offset: 0x000C288A
		static UKuroDemoInteractSubSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroDemoInteractSubSystem");
		}

		// Token: 0x0600844C RID: 33868 RVA: 0x000C4698 File Offset: 0x000C2898
		protected UKuroDemoInteractSubSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040039C8 RID: 14792
		public new const string __ObjectPath = "/Script/KuroUtility.KuroDemoInteractSubSystem";

		// Token: 0x040039C9 RID: 14793
		private static IntPtr _ClassPtr;

		// Token: 0x040039CA RID: 14794
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040039CB RID: 14795
		internal static int __PropertyOffset_OnDemoInteractiveActorAdd;

		// Token: 0x040039CC RID: 14796
		[Nullable(2)]
		private FDemoInteractiveActorMapUpdateDelegate _OnDemoInteractiveActorAdd;

		// Token: 0x040039CD RID: 14797
		internal static int __PropertyOffset_OnDemoInteractiveActorRemove;

		// Token: 0x040039CE RID: 14798
		[Nullable(2)]
		private FDemoInteractiveActorMapUpdateDelegate _OnDemoInteractiveActorRemove;

		// Token: 0x040039CF RID: 14799
		internal static int __PropertyOffset_DemoInteractiveActorMap;

		// Token: 0x040039D0 RID: 14800
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, AActor> _DemoInteractiveActorMap;
	}
}
