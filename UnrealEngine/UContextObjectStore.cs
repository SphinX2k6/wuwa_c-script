using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001541 RID: 5441
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.ContextObjectStore")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UContextObjectStore : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013BFF RID: 80895 RVA: 0x001D0006 File Offset: 0x001CE206
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UContextObjectStore._ClassPtr;
		}

		// Token: 0x06013C00 RID: 80896 RVA: 0x001D0014 File Offset: 0x001CE214
		public UContextObjectStore() : this(BuiltinUtils.AllocNativeUObject(UContextObjectStore.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013C01 RID: 80897 RVA: 0x001D003C File Offset: 0x001CE23C
		public UContextObjectStore(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UContextObjectStore.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D5B RID: 19803
		// (get) Token: 0x06013C02 RID: 80898 RVA: 0x001D0070 File Offset: 0x001CE270
		// (set) Token: 0x06013C03 RID: 80899 RVA: 0x001D00A9 File Offset: 0x001CE2A9
		public TArray<UObject> ContextObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ContextObjects) == null)
				{
					result = (this._ContextObjects = new TArray<UObject>(base.NativePtr + (IntPtr)UContextObjectStore.__PropertyOffset_ContextObjects, this));
				}
				return result;
			}
			set
			{
				this.ContextObjects.CopyAssign(value);
			}
		}

		// Token: 0x06013C04 RID: 80900 RVA: 0x001D00B7 File Offset: 0x001CE2B7
		static UContextObjectStore()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.ContextObjectStore");
		}

		// Token: 0x06013C05 RID: 80901 RVA: 0x001D00C5 File Offset: 0x001CE2C5
		protected UContextObjectStore(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AAEC RID: 43756
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.ContextObjectStore";

		// Token: 0x0400AAED RID: 43757
		private static IntPtr _ClassPtr;

		// Token: 0x0400AAEE RID: 43758
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AAEF RID: 43759
		internal static int __PropertyOffset_ContextObjects;

		// Token: 0x0400AAF0 RID: 43760
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ContextObjects;
	}
}
