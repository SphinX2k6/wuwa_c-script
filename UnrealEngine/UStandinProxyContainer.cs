using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028C1 RID: 10433
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/StandinActor.StandinProxyContainer")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UStandinProxyContainer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026BCC RID: 158668 RVA: 0x003B1881 File Offset: 0x003AFA81
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStandinProxyContainer._ClassPtr;
		}

		// Token: 0x06026BCD RID: 158669 RVA: 0x003B1890 File Offset: 0x003AFA90
		public UStandinProxyContainer() : this(BuiltinUtils.AllocNativeUObject(UStandinProxyContainer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026BCE RID: 158670 RVA: 0x003B18B8 File Offset: 0x003AFAB8
		public UStandinProxyContainer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStandinProxyContainer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009540 RID: 38208
		// (get) Token: 0x06026BCF RID: 158671 RVA: 0x003B18EC File Offset: 0x003AFAEC
		// (set) Token: 0x06026BD0 RID: 158672 RVA: 0x003B1925 File Offset: 0x003AFB25
		public TArray<FStandinProxyEntry> Standins
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStandinProxyEntry> result;
				if ((result = this._Standins) == null)
				{
					result = (this._Standins = new TArray<FStandinProxyEntry>(base.NativePtr + (IntPtr)UStandinProxyContainer.__PropertyOffset_Standins, this));
				}
				return result;
			}
			set
			{
				this.Standins.CopyAssign(value);
			}
		}

		// Token: 0x06026BD1 RID: 158673 RVA: 0x003B1933 File Offset: 0x003AFB33
		static UStandinProxyContainer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/StandinActor.StandinProxyContainer");
		}

		// Token: 0x06026BD2 RID: 158674 RVA: 0x003B1941 File Offset: 0x003AFB41
		protected UStandinProxyContainer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015422 RID: 87074
		public new const string __ObjectPath = "/Script/StandinActor.StandinProxyContainer";

		// Token: 0x04015423 RID: 87075
		private static IntPtr _ClassPtr;

		// Token: 0x04015424 RID: 87076
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015425 RID: 87077
		internal static int __PropertyOffset_Standins;

		// Token: 0x04015426 RID: 87078
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStandinProxyEntry> _Standins;
	}
}
