using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002AB RID: 683
	[UnrealObjectPath("/Script/Engine.UserDefinedStruct")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UUserDefinedStruct : UScriptStruct, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004A20 RID: 18976 RVA: 0x00067D4A File Offset: 0x00065F4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUserDefinedStruct._ClassPtr;
		}

		// Token: 0x06004A21 RID: 18977 RVA: 0x00067D58 File Offset: 0x00065F58
		public UUserDefinedStruct() : this(BuiltinUtils.AllocNativeUObject(UUserDefinedStruct.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004A22 RID: 18978 RVA: 0x00067D80 File Offset: 0x00065F80
		[NullableContext(1)]
		public UUserDefinedStruct(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUserDefinedStruct.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06004A23 RID: 18979 RVA: 0x00067DB3 File Offset: 0x00065FB3
		// (set) Token: 0x06004A24 RID: 18980 RVA: 0x00067DC7 File Offset: 0x00065FC7
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUserDefinedStruct.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUserDefinedStruct.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x06004A25 RID: 18981 RVA: 0x00067DDC File Offset: 0x00065FDC
		static UUserDefinedStruct()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.UserDefinedStruct");
		}

		// Token: 0x06004A26 RID: 18982 RVA: 0x00067DEA File Offset: 0x00065FEA
		protected UUserDefinedStruct(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D35 RID: 7477
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.UserDefinedStruct";

		// Token: 0x04001D36 RID: 7478
		private static IntPtr _ClassPtr;

		// Token: 0x04001D37 RID: 7479
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001D38 RID: 7480
		internal static int __PropertyOffset_Guid;
	}
}
