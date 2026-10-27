using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007B7 RID: 1975
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ActorContainer")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UActorContainer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060069B1 RID: 27057 RVA: 0x00097C7F File Offset: 0x00095E7F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActorContainer._ClassPtr;
		}

		// Token: 0x060069B2 RID: 27058 RVA: 0x00097C8C File Offset: 0x00095E8C
		public UActorContainer() : this(BuiltinUtils.AllocNativeUObject(UActorContainer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060069B3 RID: 27059 RVA: 0x00097CB4 File Offset: 0x00095EB4
		public UActorContainer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActorContainer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x060069B4 RID: 27060 RVA: 0x00097CE8 File Offset: 0x00095EE8
		// (set) Token: 0x060069B5 RID: 27061 RVA: 0x00097D21 File Offset: 0x00095F21
		public TMap<FName, AActor> Actors
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, AActor> result;
				if ((result = this._Actors) == null)
				{
					result = (this._Actors = new TMap<FName, AActor>(base.NativePtr + (IntPtr)UActorContainer.__PropertyOffset_Actors, this));
				}
				return result;
			}
			set
			{
				this.Actors.CopyAssign(value);
			}
		}

		// Token: 0x060069B6 RID: 27062 RVA: 0x00097D2F File Offset: 0x00095F2F
		static UActorContainer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ActorContainer");
		}

		// Token: 0x060069B7 RID: 27063 RVA: 0x00097D3D File Offset: 0x00095F3D
		protected UActorContainer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040032F4 RID: 13044
		public new const string __ObjectPath = "/Script/Engine.ActorContainer";

		// Token: 0x040032F5 RID: 13045
		private static IntPtr _ClassPtr;

		// Token: 0x040032F6 RID: 13046
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040032F7 RID: 13047
		internal static int __PropertyOffset_Actors;

		// Token: 0x040032F8 RID: 13048
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, AActor> _Actors;
	}
}
