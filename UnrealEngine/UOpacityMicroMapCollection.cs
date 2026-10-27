using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002620 RID: 9760
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/OpacityMicroMap.OpacityMicroMapCollection")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UOpacityMicroMapCollection : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024490 RID: 148624 RVA: 0x0035B8A7 File Offset: 0x00359AA7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOpacityMicroMapCollection._ClassPtr;
		}

		// Token: 0x06024491 RID: 148625 RVA: 0x0035B8B4 File Offset: 0x00359AB4
		public UOpacityMicroMapCollection() : this(BuiltinUtils.AllocNativeUObject(UOpacityMicroMapCollection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024492 RID: 148626 RVA: 0x0035B8DC File Offset: 0x00359ADC
		public UOpacityMicroMapCollection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOpacityMicroMapCollection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008BB4 RID: 35764
		// (get) Token: 0x06024493 RID: 148627 RVA: 0x0035B910 File Offset: 0x00359B10
		// (set) Token: 0x06024494 RID: 148628 RVA: 0x0035B949 File Offset: 0x00359B49
		public TMap<ulong, UOpacityMicroMapData> Collection
		{
			get
			{
				base.FastCheckIsValid();
				TMap<ulong, UOpacityMicroMapData> result;
				if ((result = this._Collection) == null)
				{
					result = (this._Collection = new TMap<ulong, UOpacityMicroMapData>(base.NativePtr + (IntPtr)UOpacityMicroMapCollection.__PropertyOffset_Collection, this));
				}
				return result;
			}
			set
			{
				this.Collection.CopyAssign(value);
			}
		}

		// Token: 0x06024495 RID: 148629 RVA: 0x0035B957 File Offset: 0x00359B57
		static UOpacityMicroMapCollection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/OpacityMicroMap.OpacityMicroMapCollection");
		}

		// Token: 0x06024496 RID: 148630 RVA: 0x0035B965 File Offset: 0x00359B65
		protected UOpacityMicroMapCollection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401376D RID: 79725
		public new const string __ObjectPath = "/Script/OpacityMicroMap.OpacityMicroMapCollection";

		// Token: 0x0401376E RID: 79726
		private static IntPtr _ClassPtr;

		// Token: 0x0401376F RID: 79727
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013770 RID: 79728
		internal static int __PropertyOffset_Collection;

		// Token: 0x04013771 RID: 79729
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<ulong, UOpacityMicroMapData> _Collection;
	}
}
