using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200140E RID: 5134
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCache.GeometryCacheCodecBase")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UGeometryCacheCodecBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012BD3 RID: 76755 RVA: 0x001B95F1 File Offset: 0x001B77F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGeometryCacheCodecBase._ClassPtr;
		}

		// Token: 0x06012BD4 RID: 76756 RVA: 0x001B9600 File Offset: 0x001B7800
		public UGeometryCacheCodecBase() : this(BuiltinUtils.AllocNativeUObject(UGeometryCacheCodecBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012BD5 RID: 76757 RVA: 0x001B9628 File Offset: 0x001B7828
		public UGeometryCacheCodecBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGeometryCacheCodecBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170048A4 RID: 18596
		// (get) Token: 0x06012BD6 RID: 76758 RVA: 0x001B965C File Offset: 0x001B785C
		// (set) Token: 0x06012BD7 RID: 76759 RVA: 0x001B9695 File Offset: 0x001B7895
		public TArray<int> TopologyRanges
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._TopologyRanges) == null)
				{
					result = (this._TopologyRanges = new TArray<int>(base.NativePtr + (IntPtr)UGeometryCacheCodecBase.__PropertyOffset_TopologyRanges, this));
				}
				return result;
			}
			set
			{
				this.TopologyRanges.CopyAssign(value);
			}
		}

		// Token: 0x06012BD8 RID: 76760 RVA: 0x001B96A3 File Offset: 0x001B78A3
		static UGeometryCacheCodecBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCache.GeometryCacheCodecBase");
		}

		// Token: 0x06012BD9 RID: 76761 RVA: 0x001B96B1 File Offset: 0x001B78B1
		protected UGeometryCacheCodecBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A04E RID: 41038
		public new const string __ObjectPath = "/Script/GeometryCache.GeometryCacheCodecBase";

		// Token: 0x0400A04F RID: 41039
		private static IntPtr _ClassPtr;

		// Token: 0x0400A050 RID: 41040
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A051 RID: 41041
		internal static int __PropertyOffset_TopologyRanges;

		// Token: 0x0400A052 RID: 41042
		[Nullable(2)]
		private TArray<int> _TopologyRanges;
	}
}
