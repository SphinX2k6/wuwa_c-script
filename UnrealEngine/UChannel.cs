using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000921 RID: 2337
	[UnrealObjectPath("/Script/Engine.Channel")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UChannel : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008104 RID: 33028 RVA: 0x000B8EE6 File Offset: 0x000B70E6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UChannel._ClassPtr;
		}

		// Token: 0x06008105 RID: 33029 RVA: 0x000B8EF4 File Offset: 0x000B70F4
		public UChannel() : this(BuiltinUtils.AllocNativeUObject(UChannel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008106 RID: 33030 RVA: 0x000B8F1C File Offset: 0x000B711C
		[NullableContext(1)]
		public UChannel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UChannel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x06008107 RID: 33031 RVA: 0x000B8F4F File Offset: 0x000B714F
		// (set) Token: 0x06008108 RID: 33032 RVA: 0x000B8F63 File Offset: 0x000B7163
		[Nullable(2)]
		public unsafe UNetConnection Connection
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNetConnection>(base.NativePtr / (IntPtr)sizeof(void*) + UChannel.__PropertyOffset_Connection);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UChannel.__PropertyOffset_Connection, value);
			}
		}

		// Token: 0x06008109 RID: 33033 RVA: 0x000B8F78 File Offset: 0x000B7178
		static UChannel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Channel");
		}

		// Token: 0x0600810A RID: 33034 RVA: 0x000B8F86 File Offset: 0x000B7186
		protected UChannel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003DBC RID: 15804
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Channel";

		// Token: 0x04003DBD RID: 15805
		private static IntPtr _ClassPtr;

		// Token: 0x04003DBE RID: 15806
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003DBF RID: 15807
		internal static int __PropertyOffset_Connection;
	}
}
