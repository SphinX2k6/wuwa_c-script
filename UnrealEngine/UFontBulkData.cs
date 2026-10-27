using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002815 RID: 10261
	[UnrealObjectPath("/Script/SlateCore.FontBulkData")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UFontBulkData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026263 RID: 156259 RVA: 0x0039E532 File Offset: 0x0039C732
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFontBulkData._ClassPtr;
		}

		// Token: 0x06026264 RID: 156260 RVA: 0x0039E540 File Offset: 0x0039C740
		public UFontBulkData() : this(BuiltinUtils.AllocNativeUObject(UFontBulkData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026265 RID: 156261 RVA: 0x0039E568 File Offset: 0x0039C768
		[NullableContext(1)]
		public UFontBulkData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFontBulkData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026266 RID: 156262 RVA: 0x0039E59B File Offset: 0x0039C79B
		static UFontBulkData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SlateCore.FontBulkData");
		}

		// Token: 0x06026267 RID: 156263 RVA: 0x0039E5A9 File Offset: 0x0039C7A9
		protected UFontBulkData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014E1F RID: 85535
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SlateCore.FontBulkData";

		// Token: 0x04014E20 RID: 85536
		private static IntPtr _ClassPtr;

		// Token: 0x04014E21 RID: 85537
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
