using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D24 RID: 3364
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LevelActorContainer")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class ULevelActorContainer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B484 RID: 46212 RVA: 0x00101736 File Offset: 0x000FF936
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelActorContainer._ClassPtr;
		}

		// Token: 0x0600B485 RID: 46213 RVA: 0x00101744 File Offset: 0x000FF944
		public ULevelActorContainer() : this(BuiltinUtils.AllocNativeUObject(ULevelActorContainer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B486 RID: 46214 RVA: 0x0010176C File Offset: 0x000FF96C
		public ULevelActorContainer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelActorContainer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002952 RID: 10578
		// (get) Token: 0x0600B487 RID: 46215 RVA: 0x001017A0 File Offset: 0x000FF9A0
		// (set) Token: 0x0600B488 RID: 46216 RVA: 0x001017D9 File Offset: 0x000FF9D9
		public TArray<AActor> Actors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._Actors) == null)
				{
					result = (this._Actors = new TArray<AActor>(base.NativePtr + (IntPtr)ULevelActorContainer.__PropertyOffset_Actors, this));
				}
				return result;
			}
			set
			{
				this.Actors.CopyAssign(value);
			}
		}

		// Token: 0x0600B489 RID: 46217 RVA: 0x001017E7 File Offset: 0x000FF9E7
		static ULevelActorContainer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelActorContainer");
		}

		// Token: 0x0600B48A RID: 46218 RVA: 0x001017F5 File Offset: 0x000FF9F5
		protected ULevelActorContainer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005EE5 RID: 24293
		public new const string __ObjectPath = "/Script/Engine.LevelActorContainer";

		// Token: 0x04005EE6 RID: 24294
		private static IntPtr _ClassPtr;

		// Token: 0x04005EE7 RID: 24295
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005EE8 RID: 24296
		internal static int __PropertyOffset_Actors;

		// Token: 0x04005EE9 RID: 24297
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Actors;
	}
}
