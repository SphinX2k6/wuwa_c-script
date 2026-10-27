using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000982 RID: 2434
	[UnrealObjectPath("/Script/Engine.CurveTable")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UCurveTable : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060089A8 RID: 35240 RVA: 0x000C53F2 File Offset: 0x000C35F2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCurveTable._ClassPtr;
		}

		// Token: 0x060089A9 RID: 35241 RVA: 0x000C5400 File Offset: 0x000C3600
		public UCurveTable() : this(BuiltinUtils.AllocNativeUObject(UCurveTable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060089AA RID: 35242 RVA: 0x000C5428 File Offset: 0x000C3628
		[NullableContext(1)]
		public UCurveTable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCurveTable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060089AB RID: 35243 RVA: 0x000C545B File Offset: 0x000C365B
		static UCurveTable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CurveTable");
		}

		// Token: 0x060089AC RID: 35244 RVA: 0x000C5469 File Offset: 0x000C3669
		protected UCurveTable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400415F RID: 16735
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CurveTable";

		// Token: 0x04004160 RID: 16736
		private static IntPtr _ClassPtr;

		// Token: 0x04004161 RID: 16737
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
