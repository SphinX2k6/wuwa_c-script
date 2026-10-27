using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FFE RID: 4094
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PlatformInterfaceBase")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UPlatformInterfaceBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DDB8 RID: 56760 RVA: 0x001469FD File Offset: 0x00144BFD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlatformInterfaceBase._ClassPtr;
		}

		// Token: 0x0600DDB9 RID: 56761 RVA: 0x00146A0C File Offset: 0x00144C0C
		public UPlatformInterfaceBase() : this(BuiltinUtils.AllocNativeUObject(UPlatformInterfaceBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DDBA RID: 56762 RVA: 0x00146A34 File Offset: 0x00144C34
		public UPlatformInterfaceBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPlatformInterfaceBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700344A RID: 13386
		// (get) Token: 0x0600DDBB RID: 56763 RVA: 0x00146A68 File Offset: 0x00144C68
		// (set) Token: 0x0600DDBC RID: 56764 RVA: 0x00146AA1 File Offset: 0x00144CA1
		public TArray<FDelegateArray> AllDelegates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FDelegateArray> result;
				if ((result = this._AllDelegates) == null)
				{
					result = (this._AllDelegates = new TArray<FDelegateArray>(base.NativePtr + (IntPtr)UPlatformInterfaceBase.__PropertyOffset_AllDelegates, this));
				}
				return result;
			}
			set
			{
				this.AllDelegates.CopyAssign(value);
			}
		}

		// Token: 0x0600DDBD RID: 56765 RVA: 0x00146AAF File Offset: 0x00144CAF
		static UPlatformInterfaceBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlatformInterfaceBase");
		}

		// Token: 0x0600DDBE RID: 56766 RVA: 0x00146ABD File Offset: 0x00144CBD
		protected UPlatformInterfaceBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040077E1 RID: 30689
		public new const string __ObjectPath = "/Script/Engine.PlatformInterfaceBase";

		// Token: 0x040077E2 RID: 30690
		private static IntPtr _ClassPtr;

		// Token: 0x040077E3 RID: 30691
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040077E4 RID: 30692
		internal static int __PropertyOffset_AllDelegates;

		// Token: 0x040077E5 RID: 30693
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FDelegateArray> _AllDelegates;
	}
}
