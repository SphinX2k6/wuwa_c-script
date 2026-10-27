using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010C4 RID: 4292
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RuntimeSpatialHashExternalStreamingObject")]
	[UnrealStructLayout(568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 568)]
	public class URuntimeSpatialHashExternalStreamingObject : URuntimeHashExternalStreamingObjectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F4EB RID: 62699 RVA: 0x0016B215 File Offset: 0x00169415
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimeSpatialHashExternalStreamingObject._ClassPtr;
		}

		// Token: 0x0600F4EC RID: 62700 RVA: 0x0016B224 File Offset: 0x00169424
		public URuntimeSpatialHashExternalStreamingObject() : this(BuiltinUtils.AllocNativeUObject(URuntimeSpatialHashExternalStreamingObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F4ED RID: 62701 RVA: 0x0016B24C File Offset: 0x0016944C
		public URuntimeSpatialHashExternalStreamingObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URuntimeSpatialHashExternalStreamingObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003BA1 RID: 15265
		// (get) Token: 0x0600F4EE RID: 62702 RVA: 0x0016B280 File Offset: 0x00169480
		// (set) Token: 0x0600F4EF RID: 62703 RVA: 0x0016B2B9 File Offset: 0x001694B9
		public TArray<FSpatialHashStreamingGrid> StreamingGrids
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSpatialHashStreamingGrid> result;
				if ((result = this._StreamingGrids) == null)
				{
					result = (this._StreamingGrids = new TArray<FSpatialHashStreamingGrid>(base.NativePtr + (IntPtr)URuntimeSpatialHashExternalStreamingObject.__PropertyOffset_StreamingGrids, this));
				}
				return result;
			}
			set
			{
				this.StreamingGrids.CopyAssign(value);
			}
		}

		// Token: 0x0600F4F0 RID: 62704 RVA: 0x0016B2C7 File Offset: 0x001694C7
		static URuntimeSpatialHashExternalStreamingObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimeSpatialHashExternalStreamingObject");
		}

		// Token: 0x0600F4F1 RID: 62705 RVA: 0x0016B2D5 File Offset: 0x001694D5
		protected URuntimeSpatialHashExternalStreamingObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040084BB RID: 33979
		public new const string __ObjectPath = "/Script/Engine.RuntimeSpatialHashExternalStreamingObject";

		// Token: 0x040084BC RID: 33980
		private static IntPtr _ClassPtr;

		// Token: 0x040084BD RID: 33981
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040084BE RID: 33982
		internal static int __PropertyOffset_StreamingGrids;

		// Token: 0x040084BF RID: 33983
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpatialHashStreamingGrid> _StreamingGrids;
	}
}
