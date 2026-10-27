using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010AF RID: 4271
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RuntimeHashSetExternalStreamingObject")]
	[UnrealStructLayout(568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 568)]
	public class URuntimeHashSetExternalStreamingObject : URuntimeHashExternalStreamingObjectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F421 RID: 62497 RVA: 0x0016A12D File Offset: 0x0016832D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimeHashSetExternalStreamingObject._ClassPtr;
		}

		// Token: 0x0600F422 RID: 62498 RVA: 0x0016A13C File Offset: 0x0016833C
		public URuntimeHashSetExternalStreamingObject() : this(BuiltinUtils.AllocNativeUObject(URuntimeHashSetExternalStreamingObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F423 RID: 62499 RVA: 0x0016A164 File Offset: 0x00168364
		public URuntimeHashSetExternalStreamingObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URuntimeHashSetExternalStreamingObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003B76 RID: 15222
		// (get) Token: 0x0600F424 RID: 62500 RVA: 0x0016A198 File Offset: 0x00168398
		// (set) Token: 0x0600F425 RID: 62501 RVA: 0x0016A1D1 File Offset: 0x001683D1
		public TArray<FRuntimePartitionStreamingData> RuntimeStreamingData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRuntimePartitionStreamingData> result;
				if ((result = this._RuntimeStreamingData) == null)
				{
					result = (this._RuntimeStreamingData = new TArray<FRuntimePartitionStreamingData>(base.NativePtr + (IntPtr)URuntimeHashSetExternalStreamingObject.__PropertyOffset_RuntimeStreamingData, this));
				}
				return result;
			}
			set
			{
				this.RuntimeStreamingData.CopyAssign(value);
			}
		}

		// Token: 0x0600F426 RID: 62502 RVA: 0x0016A1DF File Offset: 0x001683DF
		static URuntimeHashSetExternalStreamingObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimeHashSetExternalStreamingObject");
		}

		// Token: 0x0600F427 RID: 62503 RVA: 0x0016A1ED File Offset: 0x001683ED
		protected URuntimeHashSetExternalStreamingObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008451 RID: 33873
		public new const string __ObjectPath = "/Script/Engine.RuntimeHashSetExternalStreamingObject";

		// Token: 0x04008452 RID: 33874
		private static IntPtr _ClassPtr;

		// Token: 0x04008453 RID: 33875
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008454 RID: 33876
		internal static int __PropertyOffset_RuntimeStreamingData;

		// Token: 0x04008455 RID: 33877
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRuntimePartitionStreamingData> _RuntimeStreamingData;
	}
}
