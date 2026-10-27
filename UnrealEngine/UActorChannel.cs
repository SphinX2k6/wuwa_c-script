using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007AA RID: 1962
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ActorChannel")]
	[UnrealStructLayout(672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 672)]
	public class UActorChannel : UChannel, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600685B RID: 26715 RVA: 0x00095423 File Offset: 0x00093623
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActorChannel._ClassPtr;
		}

		// Token: 0x0600685C RID: 26716 RVA: 0x00095430 File Offset: 0x00093630
		public UActorChannel() : this(BuiltinUtils.AllocNativeUObject(UActorChannel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600685D RID: 26717 RVA: 0x00095458 File Offset: 0x00093658
		public UActorChannel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActorChannel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x0600685E RID: 26718 RVA: 0x0009548B File Offset: 0x0009368B
		// (set) Token: 0x0600685F RID: 26719 RVA: 0x0009549F File Offset: 0x0009369F
		[Nullable(2)]
		public unsafe AActor Actor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UActorChannel.__PropertyOffset_Actor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UActorChannel.__PropertyOffset_Actor, value);
			}
		}

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x06006860 RID: 26720 RVA: 0x000954B4 File Offset: 0x000936B4
		// (set) Token: 0x06006861 RID: 26721 RVA: 0x000954ED File Offset: 0x000936ED
		public TArray<UObject> CreateSubObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._CreateSubObjects) == null)
				{
					result = (this._CreateSubObjects = new TArray<UObject>(base.NativePtr + (IntPtr)UActorChannel.__PropertyOffset_CreateSubObjects, this));
				}
				return result;
			}
			set
			{
				this.CreateSubObjects.CopyAssign(value);
			}
		}

		// Token: 0x06006862 RID: 26722 RVA: 0x000954FB File Offset: 0x000936FB
		static UActorChannel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ActorChannel");
		}

		// Token: 0x06006863 RID: 26723 RVA: 0x00095509 File Offset: 0x00093709
		protected UActorChannel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400322C RID: 12844
		public new const string __ObjectPath = "/Script/Engine.ActorChannel";

		// Token: 0x0400322D RID: 12845
		private static IntPtr _ClassPtr;

		// Token: 0x0400322E RID: 12846
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400322F RID: 12847
		internal static int __PropertyOffset_Actor;

		// Token: 0x04003230 RID: 12848
		internal static int __PropertyOffset_CreateSubObjects;

		// Token: 0x04003231 RID: 12849
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _CreateSubObjects;
	}
}
