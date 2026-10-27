using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001748 RID: 5960
	[UnrealObjectPath("/Script/KuroCollision.KuroCollisionSubSystem")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UKuroCollisionSubSystem : UEngineSubsystem, IUnrealUObject, IUnrealObject, IInterface_CollisionDataProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601571D RID: 87837 RVA: 0x001F83C4 File Offset: 0x001F65C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCollisionSubSystem._ClassPtr;
		}

		// Token: 0x0601571E RID: 87838 RVA: 0x001F83D0 File Offset: 0x001F65D0
		int IInterface_CollisionDataProvider.InterfaceOffset()
		{
			return UKuroCollisionSubSystem.__InterfaceOffset_IInterface_CollisionDataProvider;
		}

		// Token: 0x0601571F RID: 87839 RVA: 0x001F83D8 File Offset: 0x001F65D8
		public UKuroCollisionSubSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroCollisionSubSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015720 RID: 87840 RVA: 0x001F8400 File Offset: 0x001F6600
		[NullableContext(1)]
		public UKuroCollisionSubSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCollisionSubSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170054A4 RID: 21668
		// (get) Token: 0x06015721 RID: 87841 RVA: 0x001F8434 File Offset: 0x001F6634
		// (set) Token: 0x06015722 RID: 87842 RVA: 0x001F846D File Offset: 0x001F666D
		[Nullable(1)]
		public TMap<FSoftObjectPath, FKuroBodySetupInfo> CollisionClusterBodySetups
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FSoftObjectPath, FKuroBodySetupInfo> result;
				if ((result = this._CollisionClusterBodySetups) == null)
				{
					result = (this._CollisionClusterBodySetups = new TMap<FSoftObjectPath, FKuroBodySetupInfo>(base.NativePtr + (IntPtr)UKuroCollisionSubSystem.__PropertyOffset_CollisionClusterBodySetups, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CollisionClusterBodySetups.CopyAssign(value);
			}
		}

		// Token: 0x06015723 RID: 87843 RVA: 0x001F847B File Offset: 0x001F667B
		static UKuroCollisionSubSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCollision.KuroCollisionSubSystem");
		}

		// Token: 0x06015724 RID: 87844 RVA: 0x001F8489 File Offset: 0x001F6689
		protected UKuroCollisionSubSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BB07 RID: 47879
		internal static int __InterfaceOffset_IInterface_CollisionDataProvider;

		// Token: 0x0400BB08 RID: 47880
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCollision.KuroCollisionSubSystem";

		// Token: 0x0400BB09 RID: 47881
		private static IntPtr _ClassPtr;

		// Token: 0x0400BB0A RID: 47882
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BB0B RID: 47883
		internal static int __PropertyOffset_CollisionClusterBodySetups;

		// Token: 0x0400BB0C RID: 47884
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FSoftObjectPath, FKuroBodySetupInfo> _CollisionClusterBodySetups;
	}
}
