using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027E0 RID: 10208
	[UnrealObjectPath("/Script/SimplygonUObjects.SpecularCaster")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class USpecularCaster : UBaseColorCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060260EA RID: 155882 RVA: 0x0039B98D File Offset: 0x00399B8D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpecularCaster._ClassPtr;
		}

		// Token: 0x060260EB RID: 155883 RVA: 0x0039B99C File Offset: 0x00399B9C
		public USpecularCaster() : this(BuiltinUtils.AllocNativeUObject(USpecularCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060260EC RID: 155884 RVA: 0x0039B9C4 File Offset: 0x00399BC4
		[NullableContext(1)]
		public USpecularCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpecularCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060260ED RID: 155885 RVA: 0x0039B9F7 File Offset: 0x00399BF7
		static USpecularCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.SpecularCaster");
		}

		// Token: 0x060260EE RID: 155886 RVA: 0x0039BA05 File Offset: 0x00399C05
		protected USpecularCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014C83 RID: 85123
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SimplygonUObjects.SpecularCaster";

		// Token: 0x04014C84 RID: 85124
		private static IntPtr _ClassPtr;

		// Token: 0x04014C85 RID: 85125
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
