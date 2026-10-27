using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002619 RID: 9753
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/OnlineSubsystem.NamedInterfaces")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UNamedInterfaces : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024466 RID: 148582 RVA: 0x0035B410 File Offset: 0x00359610
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNamedInterfaces._ClassPtr;
		}

		// Token: 0x06024467 RID: 148583 RVA: 0x0035B41C File Offset: 0x0035961C
		public UNamedInterfaces() : this(BuiltinUtils.AllocNativeUObject(UNamedInterfaces.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024468 RID: 148584 RVA: 0x0035B444 File Offset: 0x00359644
		public UNamedInterfaces(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNamedInterfaces.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008BAF RID: 35759
		// (get) Token: 0x06024469 RID: 148585 RVA: 0x0035B478 File Offset: 0x00359678
		// (set) Token: 0x0602446A RID: 148586 RVA: 0x0035B4B1 File Offset: 0x003596B1
		public TArray<FNamedInterface> NamedInterfaces
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNamedInterface> result;
				if ((result = this._NamedInterfaces) == null)
				{
					result = (this._NamedInterfaces = new TArray<FNamedInterface>(base.NativePtr + (IntPtr)UNamedInterfaces.__PropertyOffset_NamedInterfaces, this));
				}
				return result;
			}
			set
			{
				this.NamedInterfaces.CopyAssign(value);
			}
		}

		// Token: 0x17008BB0 RID: 35760
		// (get) Token: 0x0602446B RID: 148587 RVA: 0x0035B4C0 File Offset: 0x003596C0
		// (set) Token: 0x0602446C RID: 148588 RVA: 0x0035B4F9 File Offset: 0x003596F9
		public TArray<FNamedInterfaceDef> NamedInterfaceDefs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNamedInterfaceDef> result;
				if ((result = this._NamedInterfaceDefs) == null)
				{
					result = (this._NamedInterfaceDefs = new TArray<FNamedInterfaceDef>(base.NativePtr + (IntPtr)UNamedInterfaces.__PropertyOffset_NamedInterfaceDefs, this));
				}
				return result;
			}
			set
			{
				this.NamedInterfaceDefs.CopyAssign(value);
			}
		}

		// Token: 0x0602446D RID: 148589 RVA: 0x0035B507 File Offset: 0x00359707
		static UNamedInterfaces()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/OnlineSubsystem.NamedInterfaces");
		}

		// Token: 0x0602446E RID: 148590 RVA: 0x0035B515 File Offset: 0x00359715
		protected UNamedInterfaces(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013753 RID: 79699
		public new const string __ObjectPath = "/Script/OnlineSubsystem.NamedInterfaces";

		// Token: 0x04013754 RID: 79700
		private static IntPtr _ClassPtr;

		// Token: 0x04013755 RID: 79701
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013756 RID: 79702
		internal static int __PropertyOffset_NamedInterfaces;

		// Token: 0x04013757 RID: 79703
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNamedInterface> _NamedInterfaces;

		// Token: 0x04013758 RID: 79704
		internal static int __PropertyOffset_NamedInterfaceDefs;

		// Token: 0x04013759 RID: 79705
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNamedInterfaceDef> _NamedInterfaceDefs;
	}
}
